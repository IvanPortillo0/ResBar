using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ResBar_01._01.Forms_Views
{
    public partial class Form_Principal_View : Form
    {
        public Form_Principal_View()
        {
            InitializeComponent();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_NuevaOrden_View ordenNueva = new Form_NuevaOrden_View();
            ordenNueva.MdiParent = Form1.ActiveForm;
            ordenNueva.Show();
            
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            //antes de llamar el formulario de Menu para agregar mas productos a la orden, se debe validar
            //que este seleccionada una orden en la tabla de Ordenes "Activas".
            Forms_Views.Form_Menu_View menu = new Form_Menu_View();
            menu.MdiParent = Form1.ActiveForm;
            menu.Dock = DockStyle.Fill;
            menu.Show();
        }

        private void btnModificarCuenta_Click(object sender, EventArgs e)
        {
            //antes de llamar el formulario de DetailOrder para ver el detalle de una orden, se debe validar
            //que este seleccionada una orden en la tabla de Ordenes "Activas".
            Forms_Views.Form_DentailOrder_View OrdenDatail = new Form_DentailOrder_View();
            OrdenDatail.MdiParent = Form1.ActiveForm;
            //No coloco el DockStyle, debido a que esta pantalla se mostraria como una Modal
            OrdenDatail.Show();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La orden se esta imprimiendo...", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
