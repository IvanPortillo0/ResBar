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
            prod.nombre = "prueba1";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';

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
            prod.idProducto = 4;
            prod.nombre = "prueba1";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';

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
            prod.nombre = "prueba1";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';

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

        private void btnOrd_Click(object sender, EventArgs e)
        {
            Orden ord = new Orden();
            ord.idOrden = 1;
            ord.mesero = "mesero1";
            ord.mesa = "mesa1";
            ord.cliente = "cliente";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario";
            ord.total = 10;
            ord.activa = true;
            
            producto prod = new producto();
            prod.idProducto = 4;
            prod.nombre = "prueba1";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';
            
            producto prod2 = new producto();
            prod.idProducto = 5;
            prod.nombre = "prueba2";
            prod.precio = 2.0;
            prod.categoria.idCategoria = 2;
            prod.area = 'c';
            
            DetalleOrden det= new DetalleOrden();

            List<DetalleOrden> detalle = new List<DetalleOrden>();
            MessageBox.Show("deteccion001   detalle=ord.detalle");
            detalle = ord.detalle;
            MessageBox.Show("deteccion002");
            det.producto = prod;
            det.cantidad = 3;
            //MessageBox.Show("deteccion004   detalle.add(det)");
            //detalle.Add(det);
            //MessageBox.Show("deteccion0005");
            det.producto = prod2;
            det.cantidad = 5;

            //MessageBox.Show("deteccion004   detalle.add(det)");
            //detalle.Add(det);
            //MessageBox.Show("deteccion0005");


            MessageBox.Show("deteccion0   ingresar");
            try
            {
                if (ManejadorOrdenes.Insertar(ord) > 0)
                {
                    MessageBox.Show("Registro Insertado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
