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
    public partial class Form_ejecutar_procedimientoFunciones : Form
    {
        public Form_ejecutar_procedimientoFunciones()
        {
            InitializeComponent();
        }

        private void button_listarContratos_click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.Conn.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.Connection = conn.Conn;
                sqlDataAdapter.SelectCommand.CommandText = "P_LISTA_CONTRATOS"; //nombre del procedimiento en la BBDD
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDataAdapter.SelectCommand.Parameters.Add("@DNIONIE", SqlDbType.Char, 9).Value = textBox_DNI_listar.Text;  //@DNIONIE es el nombre que tiene el parámetro de entrada del procedimiento

                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Contratos_por_DNI/NIE");

                dataGridView_contratos.DataSource = dataSet.Tables["Contratos_por_DNI/NIE"];
                conn.Conn.Close();

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

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.Connection = conn.Conn;
                sqlDataAdapter.SelectCommand.CommandText = "P_INSERTA_EQUIPO";
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parámetros que recibe el procedimiento almacenado

                sqlDataAdapter.SelectCommand.Parameters.Add("@nomEquipo", SqlDbType.VarChar, 40).Value = textBox_nomEquipo_procedimiento2.Text;
                sqlDataAdapter.SelectCommand.Parameters.Add("@codLiga", SqlDbType.Char, 5).Value = textBox_codEquipo_procedimiento2.Text;
                sqlDataAdapter.SelectCommand.Parameters.Add("@localidad", SqlDbType.VarChar, 60).Value = textBox_localidad_procedimiento2.Text;
                sqlDataAdapter.SelectCommand.Parameters.Add("@internacional", SqlDbType.TinyInt, 1).Value = checkBox_internacional.Checked;

                SqlParameter sqlParameter_existeLiga = new SqlParameter("@SALIDA_1", SqlDbType.Int);  //este es el parámetro de salida que indicaría si existe la liga
                sqlParameter_existeLiga.Direction = ParameterDirection.Output;
                sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter_existeLiga);


                SqlParameter sqlParameter_insercionCorrecta = new SqlParameter("@SALIDA_2", SqlDbType.Int); //indica se realizó correctamente la inserción 
                sqlParameter_insercionCorrecta.Direction = ParameterDirection.Output;
                sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter_insercionCorrecta);

                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                if (sqlDataAdapter.SelectCommand.Parameters["@SALIDA_1"].Value.ToString() == "1")
                    label_ligaExiste.Text = "Existe liga: Sí";
                else
                    label_ligaExiste.Text = "Existe liga: No";

                if (sqlDataAdapter.SelectCommand.Parameters["@SALIDA_2"].Value.ToString() == "1")
                    label_insercionCorrecta.Text = "Inserción correcta: Sí";
                else
                    label_insercionCorrecta.Text = "Inserción correcta: No";

                conn.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ha ocurrido un error: " + ex.Message);
            }
        }
        private void button_numFutbolistas_procedimiento_click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.Conn.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.Connection = conn.Conn;
                sqlDataAdapter.SelectCommand.CommandText = "P_CANTIDAD_FUTBOLISTAS";
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDataAdapter.SelectCommand.Parameters.Add("@NOMEQUIPO", SqlDbType.VarChar, 40).Value = textBox_nomEquipo_procedimiento3.Text;
                sqlDataAdapter.SelectCommand.Parameters.Add("@PRECIOANUAL", SqlDbType.Int).Value = Convert.ToInt32(textBox_precioAnual_procedimiento3.Text);
                sqlDataAdapter.SelectCommand.Parameters.Add("@PRECIORECISION", SqlDbType.Int).Value = Convert.ToInt32(textBox_precioRescision_procedimiento3.Text);

                SqlParameter sqlParameter_cantidadFutbolistasEnActivo = new SqlParameter("@FUTBOLISTAS_EN_ACTIVO", SqlDbType.Int);
                sqlParameter_cantidadFutbolistasEnActivo.Direction = ParameterDirection.Output;
                sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter_cantidadFutbolistasEnActivo);

                SqlParameter sqlParameter_precioMenor = new SqlParameter("@ACTIVOS_CON_PRECIO_Y_RESCISION", SqlDbType.Int);
                sqlParameter_precioMenor.Direction = ParameterDirection.Output;
                sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter_precioMenor);

                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                label_futbolistasEnActivo.Text = "Futbolistas en activo: " + sqlDataAdapter.SelectCommand.Parameters["@FUTBOLISTAS_EN_ACTIVO"].Value.ToString();

                label_futbolistasActivos_precioMenor.Text = "F. activos con precio inferior: " + sqlDataAdapter.SelectCommand.Parameters["@ACTIVOS_CON_PRECIO_Y_RESCISION"].Value.ToString();

                conn.Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ha ocurrido un error: " + ex.Message);
            }
        }

        private void button_numFutbolistas_funcion_click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.Connection = conn.Conn;
                sqlDataAdapter.SelectCommand.CommandText = "Select dbo.F_MESES_TOTALES(@DNIONIE)";

                sqlDataAdapter.SelectCommand.Parameters.Add("@DNIONIE", SqlDbType.VarChar, 9).Value = textBox_dniNie_funcion.Text;

                conn.Conn.Open();

                label_numMeses_funcion.Text = "Número de meses " + sqlDataAdapter.SelectCommand.ExecuteScalar().ToString();

                conn.Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ha ocurrido un error: " + ex.Message);
            }
        }

        private void form_ejecutar_procedimientoFunciones_load(object sender, EventArgs e)
        {
        }
    }
}
