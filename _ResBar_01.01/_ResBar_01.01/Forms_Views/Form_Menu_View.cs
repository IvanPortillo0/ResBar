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
    public partial class Form_Menu_View : Form
    {
        public Form_Menu_View()
        {
            InitializeComponent();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOkMenu_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_DentailOrder_View ordenDetalle = new Form_DentailOrder_View();
            ordenDetalle.Show();
            this.Close();
        }
    }
}
