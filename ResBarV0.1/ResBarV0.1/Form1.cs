using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResBarV0._1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            Emergentes.FrmAdminMenu objAdminMenu = new Emergentes.FrmAdminMenu();
            objAdminMenu.Show();
        }

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            Emergentes.FrmVentas objVentas = new Emergentes.FrmVentas();
            objVentas.Show();
        }
    }
}
