using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResBarLib;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            try
            {
                List<Categoria> categorias = new List<Categoria>();

                categorias = ManejadorCategorias.Obtener(true);

                dataGridView1.DataSource = categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }
    }
}
