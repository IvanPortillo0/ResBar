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
                MessageBox.Show(prod.ElementAt(i).nombre + "   " + prod.ElementAt(i).categoria.idCategoria);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            try
            {
                cat.idCategoria = Convert.ToInt32(txtTexto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cat.nombre = "categoria";

            try
            {
                if (ManejadorCategorias.Insertar(cat) > 0)
                {
                    MessageBox.Show("Registro Insertado");
                }
                else
                {
                    MessageBox.Show("No se inserto");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            producto p2 = new producto();
            p2.idProducto = 11;
            p2.nombre = "pruebaActualizar";
            p2.precio = 15.00;
            p2.categoria.idCategoria = 2;
            p2.area = 'c';

            try
            {
                if (ManejadorProductos.Actualizar(p2) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
                else
                {
                    MessageBox.Show("No se Actualizo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            try
            {
                cat.idCategoria = Convert.ToInt32(txtTexto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cat.nombre = "categoria";
               
            try
            {
                if (ManejadorCategorias.Eliminar(cat) > 0)
                {
                    MessageBox.Show("Registro Eliminado");
                }
                else
                {
                    MessageBox.Show("No se Elimino");// se podria quitar ya que muestra mensajes personalizados para cada caso cuando no se hace la eliminación
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
