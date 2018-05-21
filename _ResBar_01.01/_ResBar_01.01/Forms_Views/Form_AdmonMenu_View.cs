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
    public partial class Form_AdmonMenu_View : Form
    {
        public Form_AdmonMenu_View()
        {
            InitializeComponent();
        }

        private void BtnAddCategoria_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_AddCategorias_View categoriaNueva = new Form_AddCategorias_View();
            categoriaNueva.Show();
        }

        private void btnUpdateCategoria_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_AddCategorias_View categoriaNueva = new Form_AddCategorias_View();
            categoriaNueva.Show();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_AdmonProducto_View productoNuevo = new Form_AdmonProducto_View();
            productoNuevo.Show();
        }

        private void btnUpdateProducto_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_AdmonProducto_View productoNuevo = new Form_AdmonProducto_View();
            productoNuevo.Show();

        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteCategoria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para utilizar esta funcion debe de seleccionar una categoria previamente","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
