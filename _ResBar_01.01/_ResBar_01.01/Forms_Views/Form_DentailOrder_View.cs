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
    public partial class Form_DentailOrder_View : Form
    {
        public Form_DentailOrder_View()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_Menu_View menu = new Form_Menu_View();
            menu.MdiParent = Form1.ActiveForm;
            menu.Dock = DockStyle.Fill;
            menu.Show();

        }

        private void btnOkDetalleOrden_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_Principal_View principal = new Form_Principal_View();
            principal.MdiParent = Form1.ActiveForm;
            principal.Dock = DockStyle.Fill;
            principal.Show();
            this.Close();
        }

        private void btnEnviarOrden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La Orden ha sido enviado a Cocina.", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
