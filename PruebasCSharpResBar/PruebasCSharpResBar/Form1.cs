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

namespace PruebasCSharpResBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1a_Click(object sender, EventArgs e)
        {
            //PROBANDO metodos invocacion normal
            List<producto> prod = new List<producto>();
            prod = ManejadorProductos.ObtenerxCategoria(1);

            for (int i = 0; i < prod.Count(); i++)
            {
                MessageBox.Show("" + prod.ElementAt(i).nombre);
            }
        }

        private void btn1b_Click(object sender, EventArgs e)
        {

            //probando metodos invocación con parametro invalido
            int num = -1;
            try
            {
                List<producto> prod = new List<producto>();
                prod = ManejadorProductos.ObtenerxCategoria(num);

                for (int i = 0; i < prod.Count(); i++)
                {
                    MessageBox.Show(prod.ElementAt(i).nombre);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show( exp.Message);
            }
        }

        private void btn1c_Click(object sender, EventArgs e)
        {
            //no se hara la prueba inyección de SQL porque es un in el que recibe el metodo ManejadorProductos.ObtenerxCategoria(int num)
        }

        private void btn1d_Click(object sender, EventArgs e)
        {
            try
            {
                List<producto> prod = new List<producto>();
                prod = ManejadorProductos.ObtenerxCategoria(1);

                for (int i = 0; i < prod.Count(); i++)
                {
                    MessageBox.Show(prod.ElementAt(i).nombre);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn2a_Click(object sender, EventArgs e)
        {
            List<producto> prod = new List<producto>();
            prod = ManejadorProductos.Buscar("co");

            for (int i = 0; i < prod.Count(); i++)
            {
                MessageBox.Show("" + prod.ElementAt(i).nombre);
            }
        }

        private void btn2b_Click(object sender, EventArgs e)
        {
            List<producto> prod = new List<producto>();
            prod = ManejadorProductos.Buscar("");

            for (int i = 0; i < prod.Count(); i++)
            {
                MessageBox.Show("" + prod.ElementAt(i).nombre);
            }
        }

        private void btn2c_Click(object sender, EventArgs e)
        {
            List<producto> prod = new List<producto>();
            prod = ManejadorProductos.Buscar("','");

            for (int i = 0; i < prod.Count(); i++)
            {
                MessageBox.Show("" + prod.ElementAt(i).nombre);
            }
        }

        private void btn2d_Click(object sender, EventArgs e)
        {

        }
        //ManejadorProducto.insertar()
        private void button1_Click(object sender, EventArgs e)
        {

            producto prod = new producto();
            prod.idProducto = 6;
            prod.nombre = "prueba6";
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

        private void button2_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = -6;
            prod.nombre = "prueba6";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';

            try
            {
                if (prod.idProducto > 0 && (prod.nombre!=null || prod.nombre!="") && prod.precio > 0 && prod.categoria.idCategoria > 0 && (prod.area=='c' || prod.area=='b'))
                {
                    if (ManejadorProductos.Insertar(prod) > 0)
                    {
                        MessageBox.Show("Registro Insertado");
                    }
                }
                else
                {
                    MessageBox.Show("Campos no validos");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = 6;
            prod.nombre = "','";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';
            try
            {
                if (prod.idProducto > 0 && (prod.nombre != null || prod.nombre != "") && prod.precio > 0 && prod.categoria.idCategoria > 0 && (prod.area == 'c' || prod.area == 'b'))
                {
                    if (ManejadorProductos.Insertar(prod) > 0)
                    {
                        MessageBox.Show("Registro Insertado");
                    }
                }
                else
                {
                    MessageBox.Show("Campos no validos");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = 6;
            prod.nombre = "pruebaActualizar";
            prod.precio = 15.0;
            prod.categoria.idCategoria = 2;
            prod.area = 'c';
            try
            {
                if (prod.idProducto > 0 && (prod.nombre != null || prod.nombre != "") && prod.precio > 0 && prod.categoria.idCategoria > 0 && (prod.area == 'c' || prod.area == 'b'))
                {
                    if (ManejadorProductos.Actualizar(prod) > 0)
                    {
                        MessageBox.Show("Registro Actualizado");
                    }
                }
                else
                {
                    MessageBox.Show("Campos no validos");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = -6;
            prod.nombre = "pruebaActualizar";
            prod.precio = 15.0;
            prod.categoria.idCategoria = 2;
            prod.area = 'c';
            try
            {
                if (prod.idProducto > 0 && (prod.nombre != null || prod.nombre != "") && prod.precio > 0 && prod.categoria.idCategoria > 0 && (prod.area == 'c' || prod.area == 'b'))
                {
                    if (ManejadorProductos.Actualizar(prod) > 0)
                    {
                        MessageBox.Show("Registro Actualizado");
                    }
                }
                else
                {
                    MessageBox.Show("Campos no validos");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = 6;
            prod.nombre = "','";
            prod.precio = 15.0;
            prod.categoria.idCategoria = 2;
            prod.area = 'c';
            try
            {
                if (prod.idProducto > 0 && (prod.nombre != null || prod.nombre != "") && prod.precio > 0 && prod.categoria.idCategoria > 0 && (prod.area == 'c' || prod.area == 'b'))
                {
                    if (ManejadorProductos.Actualizar(prod) > 0)
                    {
                        MessageBox.Show("Registro Actualizado");
                    }
                }
                else
                {
                    MessageBox.Show("Campos no validos");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = 6;
            prod.nombre = "prueba6";
            prod.precio = 15.0;
            prod.categoria.idCategoria = 2;
            prod.area = 'c';
            try
            {
                if (prod.idProducto > 0 )
                {
                    if (ManejadorProductos.Eliminar(prod) > 0)
                    {
                        MessageBox.Show("Registro Eliminado");
                    }
                }
                else
                {
                    MessageBox.Show("Campo no validos");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = -6;
            prod.nombre = "prueba6";
            prod.precio = 15.0;
            prod.categoria.idCategoria = 2;
            prod.area = 'c';
            try
            {
                if (prod.idProducto > 0)
                {
                    if (ManejadorProductos.Eliminar(prod) > 0)
                    {
                        MessageBox.Show("Registro Eliminado");
                    }
                }
                else
                {
                    MessageBox.Show("Campo no validos");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        //obtener
        private void button13_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            try
            {
                prod = ManejadorProductos.Obtener(2);
                MessageBox.Show("");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int num = -1;
            producto prod = new producto();
            try
            {
                if (num > 0)
                {
                    prod = ManejadorProductos.Obtener(num);
                    MessageBox.Show("" + prod.idProducto + " - " + prod.nombre);
                }
                else
                {
                    MessageBox.Show("campo invalido");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
        //obtenerID
        private void button17_Click(object sender, EventArgs e)
        {
            int num;
            try
            {
                    num = ManejadorProductos.ObtenerID();
                    MessageBox.Show("" + num);
             
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }
        //ManejadorCategoria 8.a
        private void button21_Click(object sender, EventArgs e)
        {
            List<Categoria> ktego = new List<Categoria>();
            List<producto> prod = new List<producto>();
            ktego = ManejadorCategorias.Obtener(true);

            for (int i = 0; i < ktego.Count(); i++)
            {
                MessageBox.Show("" + ktego.ElementAt(i).nombre);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.idCategoria = 8;
            cate.nombre = "algo suculento";


            try
            {
                if (cate.idCategoria >0 && cate.nombre!=null)
                {
                    if (ManejadorCategorias.Insertar(cate) > 0)
                    {
                        MessageBox.Show("Registro Insertado");
                    }
                }
                else
                {
                    MessageBox.Show("");
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button68_Click(object sender, EventArgs e)
        {
            try
            {
                List<Orden> ordenes = new List<Orden>();

                ordenes = ManejadorOrdenes.ObtenerActivas();

                for (int i = 0; i < ordenes.Count(); i++)
                {
                    MessageBox.Show(" " + ordenes.ElementAt(i).idOrden + "  " + ordenes.ElementAt(i).mesero);
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void button69_Click(object sender, EventArgs e)
        {
            //PROBANDO metodos invocacion normal
            List<Orden> orden = new List<Orden>();

            orden = ManejadorOrdenes.Obtener(-1);

            for (int i = 0; i < orden.Count(); i++)
            {
                MessageBox.Show(" " + orden.ElementAt(i).idOrden + "  " + orden.ElementAt(i).mesero + "  " + orden.ElementAt(i).mesa + "  " + orden.ElementAt(i).cliente + "  " + "  " + orden.ElementAt(i).fecha + "  " + "  " + orden.ElementAt(i).comentario + "  " + "  " + orden.ElementAt(i).total + "  ");
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            //PROBANDO metodos invocacion con parametro invalido
            List<Orden> orden = new List<Orden>();

            orden = ManejadorOrdenes.Obtener(2);

            for (int i = 0; i < orden.Count(); i++)
            {
                MessageBox.Show(" " + orden.ElementAt(i).idOrden + "  " + orden.ElementAt(i).mesero + "  " + orden.ElementAt(i).mesa + "  " + orden.ElementAt(i).cliente + "  " + "  " + orden.ElementAt(i).fecha + "  " + "  " + orden.ElementAt(i).comentario + "  " + "  " + orden.ElementAt(i).total + "  ");
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            //PROBANDO metodo desconectado a la bd
            try
            {
                List<Orden> orden = new List<Orden>();

                orden = ManejadorOrdenes.Obtener(3);

                for (int i = 0; i < orden.Count(); i++)
                {
                    MessageBox.Show(" " + orden.ElementAt(i).idOrden + "  " + orden.ElementAt(i).mesero + "  " + orden.ElementAt(i).mesa + "  " + orden.ElementAt(i).cliente + "  " + "  " + orden.ElementAt(i).fecha + "  " + "  " + orden.ElementAt(i).comentario + "  " + "  " + orden.ElementAt(i).total + "  ");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void button77_Click(object sender, EventArgs e)
        {
            List<Orden> orden = new List<Orden>();

            orden = ManejadorOrdenes.BuscarActivas("nel");

            for (int i = 0; i < orden.Count(); i++)
            {
                MessageBox.Show(" " + orden.ElementAt(i).idOrden + "  " + orden.ElementAt(i).mesero + "  " + orden.ElementAt(i).mesa + "  " + orden.ElementAt(i).cliente + "  " + "  " + orden.ElementAt(i).fecha + "  " + "  " + orden.ElementAt(i).comentario + "  " + "  " + orden.ElementAt(i).total + "  ");
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            List<Orden> orden = new List<Orden>();

            orden = ManejadorOrdenes.BuscarActivas(" ");

            for (int i = 0; i < orden.Count(); i++)
            {
                MessageBox.Show(" " + orden.ElementAt(i).idOrden + "  " + orden.ElementAt(i).mesero + "  " + orden.ElementAt(i).mesa + "  " + orden.ElementAt(i).cliente + "  " + "  " + orden.ElementAt(i).fecha + "  " + "  " + orden.ElementAt(i).comentario + "  " + "  " + orden.ElementAt(i).total + "  ");
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            List<Orden> orden = new List<Orden>();

            orden = ManejadorOrdenes.BuscarActivas("J %' OR 1='1");

            for (int i = 0; i < orden.Count(); i++)
            {
                MessageBox.Show(" " + orden.ElementAt(i).idOrden + "  " + orden.ElementAt(i).mesero + "  " + orden.ElementAt(i).mesa + "  " + orden.ElementAt(i).cliente + "  " + "  " + orden.ElementAt(i).fecha + "  " + "  " + orden.ElementAt(i).comentario + "  " + "  " + orden.ElementAt(i).total + "  ");
            }

        }

        private void button80_Click(object sender, EventArgs e)
        {
            //PROBANDO metodo desconectado a la bd
            try
            {
                List<Orden> orden = new List<Orden>();

                orden = ManejadorOrdenes.BuscarActivas("nel");

                for (int i = 0; i < orden.Count(); i++)
                {
                    MessageBox.Show(" " + orden.ElementAt(i).idOrden + "  " + orden.ElementAt(i).mesero + "  " + orden.ElementAt(i).mesa + "  " + orden.ElementAt(i).cliente + "  " + "  " + orden.ElementAt(i).fecha + "  " + "  " + orden.ElementAt(i).comentario + "  " + "  " + orden.ElementAt(i).total + "  ");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {

        }
    }
}
