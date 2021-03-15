using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiegoMendez_proyectoADO_net
{
    public partial class Form_comboSeleccionar_datagrid : Form
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter dataAdapter_ligas;
        private SqlDataAdapter dataAdapter_equipos;

        public Form_comboSeleccionar_datagrid()
        {
            InitializeComponent();
        }

        private void form_comboSeleccionar_datagrid_load(object sender, EventArgs e)
        {
            try
            {
                Conexion conn = new Conexion();

                conn.Conn.Open();

                //LIGAS

                String query = "Select * from t_ligas";

                dataAdapter_ligas = new SqlDataAdapter(query, conn.Conn);

                dataAdapter_ligas.Fill(dataSet, "Ligas");

                DataView dataView_ligas = new DataView(dataSet.Tables["Ligas"]);
                comboBox_nomLigas.DataSource = dataView_ligas;

                //Combo ligas

                comboBox_nomLigas.DisplayMember = "nomLiga"; //columna que se muestra
                comboBox_nomLigas.ValueMember = "codLiga"; //columna de la que se tomará el dato
                comboBox_nomLigas.DataSource = dataView_ligas; //DataView con la vista de las ligas

                label_numLigas.Text += dataSet.Tables["Ligas"].Rows.Count.ToString();

                conn.Conn.Close();

                comboBox_nomLigas.SelectedIndex = 0;
                comboBox_nomLigas_selectedIndexChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void comboBox_nomLigas_selectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataSet.Tables["Equipos"] != null)
                    dataSet.Tables["Equipos"].Clear();

                Conexion conn = new Conexion();

                conn.Conn.Open();

                //EQUIPOS

                String query = "Select * from t_equipos";
                dataAdapter_equipos = new SqlDataAdapter(query, conn.Conn);

                dataAdapter_equipos.Fill(dataSet, "Equipos");

                DataView dataView_equipos = new DataView(dataSet.Tables["Equipos"]);
                dataView_equipos.RowFilter = "codLiga = '" + comboBox_nomLigas.SelectedValue + "'";

                //establecemos los títulos de las columnas del DataGrid

                dataGridView_equipos.DataSource = dataView_equipos;

                dataGridView_equipos.Columns[0].HeaderText = "Código";
                dataGridView_equipos.Columns[1].HeaderText = "Nombre";
                dataGridView_equipos.Columns[2].HeaderText = "Liga";
                dataGridView_equipos.Columns[3].HeaderText = "Localidad";
                dataGridView_equipos.Columns[4].HeaderText = "Internacional";

                label_numEquipos.Text = "Número de equipos: " + dataView_equipos.Count.ToString();

                conn.Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
