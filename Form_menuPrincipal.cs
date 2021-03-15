using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiegoMendez_proyectoADO_net
{
    public partial class Form_menuPrincipal : Form
    {
        public Form_menuPrincipal()
        {
            InitializeComponent();
        }

        private void button_manipularRegistros_click(object sender, EventArgs e)
        {
            Form_tablasRegistros form_TablasRegistros = new Form_tablasRegistros();
            form_TablasRegistros.Show();
        }

        private void button_insercionRegistro_click(object sender, EventArgs e)
        {
            Form_insercionRegistro form_insercionRegistro = new Form_insercionRegistro();
            form_insercionRegistro.Show();
        }

        private void button_leerRegistrosDiferentesTablas_click(object sender, EventArgs e)
        {
            Form_leerRegistros form_LeerRegistros = new Form_leerRegistros();
            form_LeerRegistros.Show();
        }

        private void button_borradoRegistro_click(object sender, EventArgs e)
        {
            Form_borradoRegistro form_BorradoRegistro = new Form_borradoRegistro();
            form_BorradoRegistro.Show();
        }

        private void button_comboDentroDatagrid_click(object sender, EventArgs e)
        {
            Form_comboDentroDatagrid form_ComboDentroDatagrid = new Form_comboDentroDatagrid();
            form_ComboDentroDatagrid.Show();
        }

        private void button_edicionRegistro_click(object sender, EventArgs e)
        {
            Form_edicionRegistro form_EdicionRegistro = new Form_edicionRegistro();
            form_EdicionRegistro.Show();
        }

        private void button_comboSeleccionarDatagrid_click(object sender, EventArgs e)
        {
            Form_comboSeleccionar_datagrid form_ComboSeleccionar_Datagrid = new Form_comboSeleccionar_datagrid();
            form_ComboSeleccionar_Datagrid.Show();
        }

        private void button_dosDatagridRelacionados_click(object sender, EventArgs e)
        {
            Form_dosDatagridRelacionados form_DosDatagridRelacionados = new Form_dosDatagridRelacionados();
            form_DosDatagridRelacionados.Show();
        }

        private void button_ejecutarProcedimientosFunciones_click(object sender, EventArgs e)
        {
            Form_ejecutar_procedimientoFunciones form_Ejecutar_ProcedimientoFunciones = new Form_ejecutar_procedimientoFunciones();
            form_Ejecutar_ProcedimientoFunciones.Show();
        }
    }
}
