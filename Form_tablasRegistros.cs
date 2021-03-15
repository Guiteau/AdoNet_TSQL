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
    public partial class Form_tablasRegistros : Form
    {
        private DataSet dataSet = new DataSet();   //es un caché donde se van a almacenar las 4 tablas
        private SqlDataAdapter dataAdapter_equipos;       //los DataAdapter sirven para coger esas tablas y ponerlas en el Dataset
        private SqlDataAdapter dataAdapter_ligas;
        private SqlDataAdapter dataAdapter_contratos;
        private SqlDataAdapter dataAdapter_futbolistas;

        public Form_tablasRegistros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //aquí en el load conectamos y cargamos ya los datos de las tablas en los DataGridView
        {
            try
            {
                Conexion conn = new Conexion();

                conn.Conn.Open();

                //Ligas

                String query = "Select * from t_ligas";  //se construye la consulta
                dataAdapter_ligas = new SqlDataAdapter(query, conn.Conn); //instanciamos el DataAdaptar pasando la query y la conexión por parámetro al constructor
                dataAdapter_ligas.Fill(dataSet, "Ligas"); //rellenamos el DataSet y le ponemos nombre a la tabla que tendrá con estos datos

                //asociamos el DatagridView con la tabla que tenemos en el DataSet (hay 2 formas)

                dataGridView_ligas.DataSource = dataSet.Tables["Ligas"]; //la más fácil

                /*    DataView dataview_ligas = new DataView(dataSet.Tables["Ligas"]); //la más larga, creando 1º un DataView
                    dataGridView_ligas.DataSource = dataGridView_ligas;*/

                dataGridView_ligas.Columns[0].HeaderText = "Código"; //así ponemos título a las columnas
                dataGridView_ligas.Columns[1].HeaderText = "Nombre";

                label_numLigas.Text += " " + dataSet.Tables["Ligas"].Rows.Count.ToString();

                //EQUIPOS

                query = "Select * from t_equipos";
                dataAdapter_equipos = new SqlDataAdapter(query, conn.Conn);
                dataAdapter_equipos.Fill(dataSet, "Equipos");

                dataGridView_equipos.DataSource = dataSet.Tables["Equipos"];

                dataGridView_equipos.Columns[0].HeaderText = "Código";
                dataGridView_equipos.Columns[1].HeaderText = "Nombre";
                dataGridView_equipos.Columns[2].HeaderText = "Cod. Liga";
                dataGridView_equipos.Columns[3].HeaderText = "Localidad";
                dataGridView_equipos.Columns[4].HeaderText = "Internacional";

                label_numEquipos.Text += " " + dataSet.Tables["Equipos"].Rows.Count.ToString();

                //CONTRATOS

                query = "Select * from t_contratos";
                dataAdapter_contratos = new SqlDataAdapter(query, conn.Conn);
                dataAdapter_contratos.Fill(dataSet, "Contratos");

                dataGridView_contratos.DataSource = dataSet.Tables["Contratos"];

                dataGridView_contratos.Columns[0].HeaderText = "Código";
                dataGridView_contratos.Columns[1].HeaderText = "DNI/NIE";
                dataGridView_contratos.Columns[2].HeaderText = "Cod. Equipo";
                dataGridView_contratos.Columns[3].HeaderText = "Fecha inicio";
                dataGridView_contratos.Columns[4].HeaderText = "Fecha fin";
                dataGridView_contratos.Columns[5].HeaderText = "Precio anual";
                dataGridView_contratos.Columns[6].HeaderText = "Precio rescisión";

                label_numContratos.Text += " " + dataSet.Tables["Contratos"].Rows.Count.ToString();

                //FUTBOLISTAS

                query = "Select * from t_futbolistas";
                dataAdapter_futbolistas = new SqlDataAdapter(query, conn.Conn);
                dataAdapter_futbolistas.Fill(dataSet, "Futbolistas");

                dataGridView_futbolistas.DataSource = dataSet.Tables["Futbolistas"];

                dataGridView_futbolistas.Columns[0].HeaderText = "DNI/NIE";
                dataGridView_futbolistas.Columns[1].HeaderText = "Nombre";
                dataGridView_futbolistas.Columns[2].HeaderText = "Nacionalidad";

                label_numFutbolistas.Text += " " + dataSet.Tables["Futbolistas"].Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void button_guardarDatosLigas_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter_ligas);
                dataAdapter_ligas.Update(dataSet.Tables["Ligas"]);

                label_numLigas.Text = "Número de ligas: " + dataSet.Tables["Ligas"].Rows.Count.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void button_guardarDatosEquipos_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter_equipos);
                dataAdapter_equipos.Update(dataSet.Tables["Equipos"]);

                label_numEquipos.Text = "Número de equipos: " + dataSet.Tables["Equipos"].Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void button_guardarDatosContratos_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter_contratos);
                dataAdapter_contratos.Update(dataSet.Tables["Contratos"]);

                label_numContratos.Text = "Número de contratos: " + dataSet.Tables["Contratos"].Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void button_guardarDatosFutbolistas_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter_futbolistas);
                dataAdapter_futbolistas.Update(dataSet.Tables["Futbolistas"]);

                label_numFutbolistas.Text = "Número de futbolistas: " + dataSet.Tables["Futbolistas"].Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
