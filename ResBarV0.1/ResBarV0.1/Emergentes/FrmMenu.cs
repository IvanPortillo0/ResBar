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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMostrarDetalleOrden_Click(object sender, EventArgs e)
        {
            Emergentes.FrmDetalleOrden objDetalleOrden = new Emergentes.FrmDetalleOrden();
            objDetalleOrden.Show();
            this.Dispose();
        }
    }
}
