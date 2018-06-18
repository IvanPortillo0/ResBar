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
            DateTime fechaMenor = new DateTime(2018, 06, 01);
            DateTime fechaMayor = new DateTime(2018, 06, 10);

            List<Orden> lstOrden = new List<Orden>();
            try
            {
                lstOrden = ManejadorOrdenes.ObtenerVentas(fechaMenor, fechaMayor);

                for (int i = 0; i < lstOrden.Count(); i++)
                {
                    MessageBox.Show("" + lstOrden.ElementAt(i).idOrden + "   " + lstOrden.ElementAt(i).mesero + "   " + lstOrden.ElementAt(i).activa);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


            //List<Orden> orden = new List<Orden>();
            //string text = "m";

            //orden = ManejadorOrdenes.BuscarActivas(text);

            //for (int i = 0; i < orden.Count(); i++)
            //{
            //    MessageBox.Show(" " + orden.ElementAt(i).idOrden + "  " + orden.ElementAt(i).mesero + "  " + orden.ElementAt(i).mesa + "  " + orden.ElementAt(i).cliente + "  " + "  " + orden.ElementAt(i).fecha + "  " + "  " + orden.ElementAt(i).comentario + "  " + "  " + orden.ElementAt(i).total + "  ");
            //}

            //List<producto> prod = new List<producto>();
            //prod = ManejadorProductos.ObtenerxCategoria(1);

            //for (int i = 0; i < prod.Count(); i++)
            //{
            //    MessageBox.Show(prod.ElementAt(i).nombre + "   " + prod.ElementAt(i).categoria.idCategoria + "   " + prod.ElementAt(i).categoria.nombre);
            //}
        }

            private void btnInsertar_Click(object sender, EventArgs e)
        {

            producto prod = new producto();
            prod.idProducto = 6;
            prod.nombre = "prueba6";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 5;
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
            prod.idProducto = 6;
            prod.nombre = "prueba6_Actualizado";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 5;
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
            prod.idProducto = 6;
            prod.nombre = "prueba6";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 5;
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
            List<producto> prod = new List<producto>();
            categ = ManejadorCategorias.Obtener(consinProd);
            for (int i = 0; i < categ.Count(); i++)
            {

                prod = categ.ElementAt(i).productos;
                for (int ie = 0; ie < prod.Count(); ie++)
                {
                    MessageBox.Show("interfaz:" + categ.ElementAt(i).idCategoria + "  -----  " +prod.ElementAt(ie).idProducto );
                }
                   
            }

        }

        private void btnOrd_Click(object sender, EventArgs e)
        {   //orden a insertar
            Orden ord = new Orden();
            ord.idOrden = 1;
            ord.mesero = "mesero1";
            ord.mesa = "mesa1";
            ord.cliente = "cliente";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario";
            ord.total = 10;
            ord.activa = true;
            
            //productos que iran dentro de la orden
            producto prod = new producto();
            prod.idProducto = 4;
            prod.nombre = "prueba1";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';
            
            producto prod2 = new producto();
            prod2.idProducto = 5;
            prod2.nombre = "prueba2";
            prod2.precio = 2.0;
            prod2.categoria.idCategoria = 2;
            prod2.area = 'c';
            
            
            ord.detalle = new List<DetalleOrden>();
            DetalleOrden det = new DetalleOrden();

            DetalleOrden det2 = new DetalleOrden();
            det.producto = prod;
            det.cantidad = 4;
            ord.detalle.Add(det);
            
            det2.producto = prod2;
            det2.cantidad = 5;
            ord.detalle.Add(det2);

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
