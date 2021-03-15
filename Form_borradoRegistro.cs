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
    public partial class Form_borradoRegistro : Form
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter dataAdapter_equipos;

        public Form_borradoRegistro()

        {
            InitializeComponent();
        }

        private void button_cargarRegistro_click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.Conn.Open();
                dataSet.Clear();

                //aquí lo que haremos será cargar los datos en el formulario para que el usuario pueda ver lo que se está borrando

                String query = "Select * from t_equipos where codEquipo =" + textBox_codigoEquipo.Text; //rescatamos el código del campo de codEquipo
                dataAdapter_equipos = new SqlDataAdapter(query, conn.Conn); //cargamos la query

                dataAdapter_equipos.Fill(dataSet, "equipos");

                textBox_nomEquipo.Text = dataSet.Tables["equipos"].Rows[0]["nomEquipo"].ToString();
                textBox_codLiga.Text = dataSet.Tables["equipos"].Rows[0]["codLiga"].ToString();
                textBox_localidad.Text = dataSet.Tables["equipos"].Rows[0]["localidad"].ToString();
                checkBox_internacional.Checked = Convert.ToBoolean(dataSet.Tables["equipos"].Rows[0]["internacional"]);

                dataSet.Clear(); //vacíamos el DataSet por si se vuelve a pulsar el botón de cargar

                conn.Conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void button_borrarEquipo_click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.Conn.Open();

                String query = "Delete from t_Equipos where codEquipo = @codEquipo"; //colocamos la etiqueta del parámetro
                dataAdapter_equipos = new SqlDataAdapter();
                dataAdapter_equipos.DeleteCommand = new SqlCommand(query, conn.Conn);

                dataAdapter_equipos.DeleteCommand.Parameters.Add("@codEquipo", SqlDbType.Int).Value = textBox_codigoEquipo.Text; //asignamos valor a la etiqueta
                dataAdapter_equipos.DeleteCommand.ExecuteNonQuery(); //hacemos que se ejecute el borrado

                conn.Conn.Close();

                MessageBox.Show("Se ha eliminado el equipo con código: " + textBox_codigoEquipo.Text);

                //Vacíamos formulario para la siguiente

                textBox_codigoEquipo.Text = "";
                textBox_nomEquipo.Text = "";
                textBox_codLiga.Text = "";
                textBox_localidad.Text = "";
                checkBox_internacional.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

    }
}
