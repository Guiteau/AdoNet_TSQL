using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DiegoMendez_proyectoADO_net
{
    public partial class Form_insercionRegistro : Form
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter dataAdapter_ligas;
        private SqlDataAdapter dataAdapter_equipos;
        private DataView dataView_ligas;

        public Form_insercionRegistro()
        {
            InitializeComponent();
        }

        private void form_insercionRegistro_load(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.Conn.Open();

                String query = "Select * from t_Ligas";
                dataAdapter_ligas = new SqlDataAdapter(query, conn.Conn);  //esto lo haremos para cargar el combo de ligas cuando se abra la ventana

                dataAdapter_ligas.Fill(dataSet, "Ligas"); //rellenamos el adaptador con las ligas

                dataView_ligas = new DataView(dataSet.Tables["Ligas"]);  //creamos un DataView para asociar el combo con los datos de la tabla
                comboBox_nomLiga.DataSource = dataView_ligas;

                //Combo ligas
                comboBox_nomLiga.DisplayMember = "nomLiga"; //columna que se visualizará
                comboBox_nomLiga.ValueMember = "codLiga"; //columna que se tendrá en cuenta
                comboBox_nomLiga.DataSource = dataView_ligas; //DataView con la vista que se visualizará en el combo

                conn.Conn.Close();

                comboBox_nomLiga.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void button_insertarEquipo_click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.Conn.Open();

                String query = "Insert into t_equipos values (@nomEquipo, @codLiga, @localidad, @internacional)"; //colocamos las etiquetas de los parámetros para la inserción
                dataAdapter_equipos = new SqlDataAdapter();
                dataAdapter_equipos.InsertCommand = new SqlCommand(query, conn.Conn);

                dataAdapter_equipos.InsertCommand.Parameters.Add("@nomEquipo", SqlDbType.VarChar, 40).Value = textBox_nomEquipo.Text; //aplicamos el tipo de dato al parámetro e insertamos el contenido de los componentes
                dataAdapter_equipos.InsertCommand.Parameters.Add("@codLiga", SqlDbType.Char, 5).Value = comboBox_nomLiga.SelectedValue;
                dataAdapter_equipos.InsertCommand.Parameters.Add("@localidad", SqlDbType.VarChar, 60).Value = textBox_localidad.Text;
                dataAdapter_equipos.InsertCommand.Parameters.Add("@internacional", SqlDbType.TinyInt, 1).Value = checkBox_internacional.Checked;

                dataAdapter_equipos.InsertCommand.ExecuteNonQuery();

                conn.Conn.Close();

                MessageBox.Show("Equipo " + textBox_nomEquipo.Text + " insertado.");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }
    }
}
