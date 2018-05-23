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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Categoria Nueva
            Categoria CatNueva = new Categoria();
            CatNueva.idCategoria = 6;
            CatNueva.nombre = "Boquitas";
            try
            {
                if (ManejadorCategorias.Insertar(CatNueva) > 0)
                {
                    MessageBox.Show("Registro Insertado");
                }
                else
                {
                    MessageBox.Show("No se inserto!");
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Categoria Nueva
            Categoria CatNueva = new Categoria();
            CatNueva.idCategoria = 2;
            CatNueva.nombre = "Licuados";

            try
            {
                if (ManejadorCategorias.Actualizar(CatNueva) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
                else
                {
                    MessageBox.Show("No se actualizo!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Categoria Nueva
            Categoria CatNueva = new Categoria();
            CatNueva.idCategoria = 6;
            CatNueva.nombre = "Boquitas";
            try
            {
                if (ManejadorCategorias.Eliminar(CatNueva) > 0)
                    {
                        MessageBox.Show("Registro Eliminado");
                    }
                else
                    {
                        MessageBox.Show("No se actualizo!");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObtenerID_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Su nuevo ID: "+ManejadorCategorias.ObtenerID());
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
