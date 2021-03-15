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
    public partial class Form_leerRegistros : Form
    {
        private DataTable dataTable;

        public Form_leerRegistros()
        {
            InitializeComponent();
        }

        private void form_leerRegistros_Load(object sender, EventArgs e)
        {
            try
            {

                Conexion conn = new Conexion();

                conn.Conn.Open();

                //Ligas

                String query = "Select * from t_ligas";  //se construye la consulta

                SqlCommand command = new SqlCommand(query, conn.Conn);

                SqlDataReader sqlDataReader = command.ExecuteReader();
                dataTable = new DataTable();

                dataTable.Load(sqlDataReader);

                dataGridView_ligas.DataSource = dataTable;

                dataGridView_ligas.Columns[0].HeaderText = "Código";
                dataGridView_ligas.Columns[1].HeaderText = "Nombre";

                label_numLigas.Text = "Número de ligas: " + dataTable.Rows.Count.ToString();

                conn.Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
