using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResBarV0._1.Controles
{
    public partial class usAdminMenu : UserControl
    {
        public usAdminMenu()
        {
            InitializeComponent();
        }

        private void usAdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            Emergentes.FrmNuevaCategoria objNuevaCategoria = new Emergentes.FrmNuevaCategoria();
            objNuevaCategoria.Show();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Emergentes.FrmModificarCategoria objModificarCategoria = new Emergentes.FrmModificarCategoria();
            objModificarCategoria.Show();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Emergentes.FrmNuevoProducto objNuevoProducto = new Emergentes.FrmNuevoProducto();
            objNuevoProducto.Show();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Emergentes.FrmModificarProducto objModificarProducto = new Emergentes.FrmModificarProducto();
            objModificarProducto.Show();
        }
    }
}
