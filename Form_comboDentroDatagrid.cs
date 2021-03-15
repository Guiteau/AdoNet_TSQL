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
   
    public partial class Form_comboDentroDatagrid : Form
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter dataAdapter_ligas;
        private SqlDataAdapter dataAdapter_equipos;

        public Form_comboDentroDatagrid()
        {
            InitializeComponent();
        }

        private void button_guardarDatos_click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.Conn.Open();

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter_ligas);
                dataAdapter_ligas.Update(dataSet.Tables["Ligas"]);

                label_numLigas.Text = "Número de ligas: " + dataSet.Tables["Ligas"].Rows.Count.ToString();

                SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(dataAdapter_equipos);
                dataAdapter_equipos.Update(dataSet.Tables["Equipos"]);

                label_numEquipos.Text = "Número de equipos: " + dataSet.Tables["Equipos"].Rows.Count.ToString();


            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void form_comboDentroDatagrid_load(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {

                conn.Conn.Open();

                //LIGAS

                String query = "Select * from t_ligas";

                dataAdapter_ligas = new SqlDataAdapter(query, conn.Conn);

                dataAdapter_ligas.Fill(dataSet, "Ligas");

                //de las 2 opciones que existen para el DataSource se elegirá la más larga

                DataView dataView_ligas = new DataView(dataSet.Tables["Ligas"]);
                dataGridView_ligas.DataSource = dataView_ligas;

                dataGridView_ligas.Columns[0].HeaderText = "Código";
                dataGridView_ligas.Columns[1].HeaderText = "Nombre";

                label_numLigas.Text = "Número de equipos: " + dataSet.Tables["Ligas"].Rows.Count.ToString();

                //EQUIPOS

                query = "Select * from T_equipos";

                dataAdapter_equipos = new SqlDataAdapter(query, conn.Conn);

                dataAdapter_equipos.Fill(dataSet, "Equipos");

                DataView dataView_equipos = new DataView(dataSet.Tables["Equipos"]);
                dataGridView_equipos.DataSource = dataView_equipos;

                //Combo de ligas en el DataGridView de equipos
                DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
                dataGridViewComboBoxColumn.DataPropertyName = "codLiga"; //sería el campo que en la tabla equipos mostraría los códigos de liga
                dataGridViewComboBoxColumn.DisplayMember = "nomLiga";  //columna que se visualizará
                dataGridViewComboBoxColumn.ValueMember = "codLiga"; //columna que se tendrá en cuenta
                dataGridViewComboBoxColumn.DataSource = dataView_ligas; //DataView con la vista a visualizar en el combo, en este caso las ligas

                dataGridView_equipos.Columns.Add(dataGridViewComboBoxColumn);

                dataGridView_equipos.Columns[0].HeaderText = "Código";
                dataGridView_equipos.Columns[1].HeaderText = "Nombre";
                dataGridView_equipos.Columns[2].HeaderText = "Liga";
                dataGridView_equipos.Columns[3].HeaderText = "Localidad";
                dataGridView_equipos.Columns[4].HeaderText = "Internacional";

                dataGridView_equipos.Columns[2].Visible = false;

                label_numEquipos.Text = "Número de equipos: " + dataSet.Tables["Equipos"].Rows.Count.ToString();

                conn.Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
