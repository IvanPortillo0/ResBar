using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResBarV0._1.Emergentes
{
    public partial class FrmNuevaOrden : Form
    {
        public FrmNuevaOrden()
        {
            InitializeComponent();
        }

        private void FrmNuevaOrden_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMostrarMenu_Click(object sender, EventArgs e)
        {
            Emergentes.FrmMenu objMenu = new Emergentes.FrmMenu();
            objMenu.Show();
            this.Dispose();
        }
    }
}
