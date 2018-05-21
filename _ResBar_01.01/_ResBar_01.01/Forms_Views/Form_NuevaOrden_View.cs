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
    public partial class Form_NuevaOrden_View : Form
    {
        public Form_NuevaOrden_View()
        {
            InitializeComponent();
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_Menu_View menu = new Form_Menu_View();
            menu.MdiParent = Form1.ActiveForm;
            menu.Dock = DockStyle.Fill;
            menu.Show();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
