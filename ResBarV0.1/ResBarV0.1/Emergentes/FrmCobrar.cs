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
    public partial class FrmCobrar : Form
    {
        public FrmCobrar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Emergentes.FrmIngresarEfectivo objIngresarEfectivo = new FrmIngresarEfectivo();
            objIngresarEfectivo.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
