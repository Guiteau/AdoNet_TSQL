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
    public partial class Form_edicionRegistro : Form
    {

        DataSet dataSet = new DataSet();
        SqlDataAdapter dataAdapter_ligas;
        SqlDataAdapter dataAdapter_equipos;

        public Form_edicionRegistro()
        {
            InitializeComponent();
        }
        private void button_cargaRegistro_click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.Conn.Open();

                dataSet.Clear();

                String query = "Select*from t_ligas";

                dataAdapter_ligas = new SqlDataAdapter(query, conn.Conn);
                dataAdapter_ligas.Fill(dataSet, "Ligas");

                DataView dataView_ligas = new DataView(dataSet.Tables["Ligas"]);
                comboBox_codLiga.DataSource = dataView_ligas; //cargamos la vista en el ComboBox

                //Combo ligas
                comboBox_codLiga.DisplayMember = "nomLiga"; //columna que se visualizará
                comboBox_codLiga.ValueMember = "codLiga"; //columna que se tendrá en cuenta
                comboBox_codLiga.DataSource = dataView_ligas; //DataView con la vista (de las ligas) a visualizar en el combo. 

                comboBox_codLiga.SelectedIndex = 0;

                query = "Select * from t_equipos where codEquipo = " + textBox_codEquipo.Text;

                dataAdapter_equipos = new SqlDataAdapter(query, conn.Conn);
                dataAdapter_equipos.Fill(dataSet, "equipos");

                textBox_nomEquipo.Text = dataSet.Tables["equipos"].Rows[0]["nomEquipo"].ToString();
                comboBox_codLiga.SelectedValue = dataSet.Tables["equipos"].Rows[0]["codLiga"].ToString();
                textBox_localidad.Text = dataSet.Tables["equipos"].Rows[0]["localidad"].ToString();
                checkBox_internacional.Checked = Convert.ToBoolean(dataSet.Tables["equipos"].Rows[0]["internacional"]);

                conn.Conn.Close();
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }

        private void button_grabaEquipo_click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.Conn.Open();

                String query = "UPDATE T_EQUIPOS SET nomEquipo = @nomEquipo, codLiga = @codLiga, localidad = @localidad, internacional = @internacional " +
                    "WHERE codEquipo = @codEquipo";

                dataAdapter_equipos = new SqlDataAdapter();
                dataAdapter_equipos.UpdateCommand = new SqlCommand(query, conn.Conn);

                dataAdapter_equipos.UpdateCommand.Parameters.Add("@codEquipo", SqlDbType.Int).Value = textBox_codEquipo.Text; //indicamos el parámetro que filtra el update

                dataAdapter_equipos.UpdateCommand.Parameters.Add("@nomEquipo", SqlDbType.VarChar, 40).Value = textBox_nomEquipo.Text;
                dataAdapter_equipos.UpdateCommand.Parameters.Add("@codLiga", SqlDbType.Char, 5).Value = comboBox_codLiga.SelectedValue;
                dataAdapter_equipos.UpdateCommand.Parameters.Add("@localidad", SqlDbType.VarChar, 60).Value = textBox_localidad.Text;
                dataAdapter_equipos.UpdateCommand.Parameters.Add("@internacional", SqlDbType.TinyInt, 1).Value = checkBox_internacional.Checked;

                dataAdapter_equipos.UpdateCommand.ExecuteNonQuery();

                conn.Conn.Close();

                MessageBox.Show("Equipo con código " + textBox_codEquipo.Text + " modificado.");

                //Vacíamos el formulario

                textBox_codEquipo.Text = "";
                textBox_nomEquipo.Text = "";
                comboBox_codLiga.DataSource = null;
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
