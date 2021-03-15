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
    public partial class Form_dosDatagridRelacionados : Form
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter sqlAdapter_ligas;
        private SqlDataAdapter sqlAdapter_equipos;
        private DataView dataView_ligas = new DataView();
        private DataRowView dataRowView_actual;

        public Form_dosDatagridRelacionados()
        {
            InitializeComponent();
        }

        private void form_dosDatagridRelacionados_load(object sender, EventArgs e)
        {
            try
            {
                Conexion conn = new Conexion();

                conn.Conn.Open();

                //LIGAS 

                String query = "Select * from t_ligas";
                sqlAdapter_ligas = new SqlDataAdapter(query, conn.Conn);

                sqlAdapter_ligas.Fill(dataSet, "Ligas");

                //EQUIPOS

                query = "Select * from t_equipos";
                sqlAdapter_equipos = new SqlDataAdapter(query, conn.Conn);

                sqlAdapter_equipos.Fill(dataSet, "Equipos");

                //A continuación establecemos la relación entre ligas y equipos

                DataColumn dataColumn_padre = dataSet.Tables["Ligas"].Columns["codLiga"];
                DataColumn dataColumn_hijo = dataSet.Tables["Equipos"].Columns["codLiga"];  //deben tener coincidencia en una columna
                DataRelation dataRelation;
                dataRelation = new DataRelation("Ligas_Equipos", dataColumn_padre, dataColumn_hijo); //ambos datos se relacionan

                dataSet.Relations.Add(dataRelation);

                //LIGAS > > > Rellenamos el DataGridView de Ligas

                dataView_ligas = new DataView(dataSet.Tables["Ligas"]);

                dataGridView_ligas.DataSource = dataView_ligas;
                dataRowView_actual = dataView_ligas[dataGridView_ligas.CurrentRow.Index];

                dataGridView_ligas.Columns[0].HeaderText = "Código";
                dataGridView_ligas.Columns[1].HeaderText = "Nombre";

                label_numeroLigas.Text = "Número de ligas: " + dataSet.Tables["Ligas"].Rows.Count.ToString();


                //EQUIPOS > > > Rellenamos el DataGridView de Equipos

                dataGridView_equipos.DataSource = dataRowView_actual.CreateChildView("Ligas_Equipos"); //aquí agregamos la columna mixta

                dataGridView_equipos.Columns[0].HeaderText = "Código";
                dataGridView_equipos.Columns[1].HeaderText = "Nombre";
                dataGridView_equipos.Columns[2].HeaderText = "Liga";
                dataGridView_equipos.Columns[3].HeaderText = "Localidad";
                dataGridView_equipos.Columns[4].HeaderText = "Internacional";

                label_numeroEquipos.Text = "Número de equipos " + dataRowView_actual.CreateChildView("Ligas_Equipos").Count.ToString();

                conn.Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void dataGridView_ligas_cellContentClick(object sender, DataGridViewCellEventArgs e)  //aquí lograremos que al seleccionar la columna de la tabla padre podamos actualizar la tabla hija
        {
            try
            {
                Conexion conn = new Conexion();

                conn.Conn.Open();

                dataRowView_actual = dataView_ligas[dataGridView_ligas.CurrentRow.Index];

                dataGridView_equipos.DataSource = dataRowView_actual.CreateChildView("Ligas_Equipos");

                label_numeroLigas.Text = (dataGridView_ligas.RowCount-1).ToString();

                conn.Conn.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
