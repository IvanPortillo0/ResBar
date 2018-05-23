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
                List<producto> prod = new List<producto>();

                prod = ManejadorProductos.Buscar("po",2);
                //prod = ManejadorCategorias.Obtener(false);
                
                dataGridView1.DataSource = prod;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }
    }
}
