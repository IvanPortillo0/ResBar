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
            /*
            List<producto> prod = new List<producto>();
            prod = ManejadorProductos.ObtenerxCategoria(1);
            dataGridView1.DataSource = prod;
            */

            List<producto> prod = new List<producto>();
            prod = ManejadorProductos.ObtenerxCategoria(1);

            for (int i = 0; i < prod.Count(); i++)
            {
                MessageBox.Show(prod.ElementAt(i).nombre + "   " + prod.ElementAt(i).categoria.idCategoria + "   " + prod.ElementAt(i).categoria.nombre);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            producto prod = new producto();
            prod.idProducto = 4;
            prod.nombre = "pruebaInsertar";
            prod.precio = 1;
            prod.categoria.idCategoria = 1;
            prod.area = 'c';

            try
            {
                if (ManejadorProductos.Insertar(prod) > 0)
                {
                    MessageBox.Show("Registro Insertado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = 5;
            prod.nombre = "actualizar";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'c';

            try
            {
                if (ManejadorProductos.Actualizar(prod) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = 4;
            prod.nombre = "','";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'c';

            try
            {
                if (ManejadorProductos.Eliminar(prod) > 0)
                {
                    MessageBox.Show("Registro Eliminado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnboolean_Click(object sender, EventArgs e)
        {
            Boolean consinProd= true;


            List<Categoria> categ = new List<Categoria>();
            categ = ManejadorCategorias.Obtener(consinProd);
            List<producto> prod = new List<producto>();

            dataGridView1.DataSource = categ;
            for (int i = 0; i < categ.Count(); i++)
            {

                prod = categ.ElementAt(i).productos;
                for (int ie = 0; ie < prod.Count(); ie++)
                {
                    MessageBox.Show("" + categ.ElementAt(i).idCategoria + "-----" +prod.ElementAt(ie).idProducto );
                }
                   
            }

        }
    }
}
