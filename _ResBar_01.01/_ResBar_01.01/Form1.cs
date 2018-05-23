using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ResBar_01._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CloseWindowsP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPrincipalMenu_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_Principal_View pc = new Forms_Views.Form_Principal_View();
            pc.MdiParent = this;
            pc.Dock = DockStyle.Fill;
            pc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializo el menu principal!
            Forms_Views.Form_Principal_View pc = new Forms_Views.Form_Principal_View();
            pc.MdiParent = this;
            pc.Dock = DockStyle.Fill;
            pc.Show();
        }

        private void btnAdmonMenu_Click(object sender, EventArgs e)
        {
            Forms_Views.Form_AdmonMenu_View menu = new Forms_Views.Form_AdmonMenu_View();
            menu.MdiParent = this;
            menu.Show();
        }

        private void btnEstadisticasMenu_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Actualmente esta en desarrollo", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

            //var Query = ManejadorProductos.Obtener(1);
           
        }
    }
}
