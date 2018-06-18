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
        //ManejadoProductos
        //ObtenerxCategoria(int) -- 1
        private void btn1a_Click(object sender, EventArgs e)
        {
            List<producto> prod = new List<producto>();
            try
            {
                prod = ManejadorProductos.ObtenerxCategoria(1);

                for (int i = 0; i < prod.Count(); i++)
                {
                    MessageBox.Show("" + prod.ElementAt(i).nombre);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
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
                MessageBox.Show(exp.Message);
            }
        }

        private void btn1c_Click(object sender, EventArgs e)
        {
            //no se hara la prueba inyección de SQL porque es un in el que recibe el metodo ManejadorProductos.ObtenerxCategoria(int num)
        }

        //Buscar(String) -- 2
        private void btn2a_Click(object sender, EventArgs e)
        {
            List<producto> prod = new List<producto>();
            try
            {
                prod = ManejadorProductos.Buscar("co");
                for (int i = 0; i < prod.Count(); i++)
                {
                    MessageBox.Show("" + prod.ElementAt(i).nombre);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn2b_Click(object sender, EventArgs e)
        {
            List<producto> prod = new List<producto>();

            try
            {
                prod = ManejadorProductos.Buscar("");

                for (int i = 0; i < prod.Count(); i++)
                {
                    MessageBox.Show("" + prod.ElementAt(i).nombre);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn2c_Click(object sender, EventArgs e)
        {
            List<producto> prod = new List<producto>();
            
            try
            {
                prod = ManejadorProductos.Buscar("%'");

                for (int i = 0; i < prod.Count(); i++)
                {
                    MessageBox.Show("" + prod.ElementAt(i).nombre);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        //insertar() -- 3
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
            prod.idProducto = 6;
            prod.nombre = "";
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
        
        //Actualizar 4
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

        private void button6_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            prod.idProducto = 6;
            prod.nombre = "";
            prod.precio = 15.0;
            prod.categoria.idCategoria = 2;
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
        //Eliminar 5
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
        //obtener(int) 6
        private void button13_Click(object sender, EventArgs e)
        {
            producto prod = new producto();
            try
            {
                prod = ManejadorProductos.Obtener(2);
                MessageBox.Show("" + prod.idProducto + " - " + prod.nombre);
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

                prod = ManejadorProductos.Obtener(num);
                if (num > 0)
                {
                    MessageBox.Show("" + prod.idProducto + " - " + prod.nombre);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //obtenerID 7
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
        //----------------------------------------------------------------------------------------------------------------------------------
        //ManejadorCategoria
        //Obtener 8
        private void button21_Click(object sender, EventArgs e)
        {
            List<Categoria> cat = new List<Categoria>();
            
            try
            {
                cat = ManejadorCategorias.Obtener(true);

                for (int i = 0; i < cat.Count(); i++)
                {
                    for (int j = 0; j < cat.ElementAt(i).productos.Count(); j++)
                    {
                        MessageBox.Show(cat.ElementAt(i).idCategoria + " - " + cat.ElementAt(i).nombre + "   -   " + cat.ElementAt(i).productos.ElementAt(j).idProducto + "   -   " + cat.ElementAt(i).productos.ElementAt(j).nombre);
                    }
                }
                MessageBox.Show("False");
                cat = ManejadorCategorias.Obtener(false);

                for (int i = 0; i < cat.Count(); i++)
                {
                    MessageBox.Show(cat.ElementAt(i).idCategoria + " - " + cat.ElementAt(i).nombre);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Actualizar 9
        private void button25_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.idCategoria = 3;
            cate.nombre = "algo suculento";
            
            try
            {
                if (ManejadorCategorias.Actualizar(cate) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.idCategoria = 3;
            cate.nombre = "";
            
            try
            {
                if (ManejadorCategorias.Actualizar(cate) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.idCategoria = 3;
            cate.nombre = "','";

            try
            {
                if (ManejadorCategorias.Actualizar(cate) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Insertar(categoria) 10
        private void button29_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.idCategoria = 3;
            cate.nombre = "pruebaBebidas3";

            try
            {
                if (ManejadorCategorias.Insertar(cate) > 0)
                {
                    MessageBox.Show("Registro Insertado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.idCategoria = 3;
            cate.nombre = "";

            try
            {
                if (ManejadorCategorias.Insertar(cate) > 0)
                {
                    MessageBox.Show("Registro Insertado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.idCategoria = 3;
            cate.nombre = "','";

            try
            {
                if (ManejadorCategorias.Insertar(cate) > 0)
                {
                    MessageBox.Show("Registro Insertado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Eliminar(categoria) 11
        private void button33_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.idCategoria = 3;
            cate.nombre = "pruebaBebidas3";

            try
            {
                if (ManejadorCategorias.Eliminar(cate) > 0)
                {
                    MessageBox.Show("Registro Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            cate.idCategoria = -3;
            cate.nombre = "pruebaBebidas3";

            try
            {
                if (ManejadorCategorias.Eliminar(cate) > 0)
                {
                    MessageBox.Show("Registro Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ObtenerID() 12
        private void button37_Click(object sender, EventArgs e)
        {
            int num;
            try
            {
                num = ManejadorCategorias.ObtenerID();
                MessageBox.Show("" + num);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Orden----------------------------------------------------------------------------------------------------------------------------
        //CalcularTotal() 13
        private void button41_Click(object sender, EventArgs e)
        {

        }

        //ManejadorParametros----------------------------------------------------------------------------------------------------------------
        //Obtener 16
        private void button53_Click(object sender, EventArgs e)
        {
            List<parametro> param = new List<parametro>();
            
            try
            {
                param = ManejadorParametros.Obtener();

                for (int i = 0; i < param.Count(); i++)
                {
                    MessageBox.Show(param.ElementAt(i).idParametro + " - " + param.ElementAt(i).nombre + "  -  " + param.ElementAt(i).valor);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Actualizar 17
        private void button57_Click(object sender, EventArgs e)
        {
            parametro param = new parametro();
            param.idParametro = 1;
            param.nombre = "empresa";
            param.valor = "actualizado - Tienda ABC";

            try
            {
                if (ManejadorParametros.Actualizar(param) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            param.valor = "Tienda ABC";

            try
            {
                ManejadorParametros.Actualizar(param);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            parametro param = new parametro();
            param.idParametro = 1;
            param.nombre = "empresa";
            param.valor = "";

            try
            {
                if (ManejadorParametros.Actualizar(param) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            parametro param = new parametro();
            param.idParametro = 1;
            param.nombre = "empresa";
            param.valor = "','";

            try
            {
                if (ManejadorParametros.Actualizar(param) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Obtener(int)  18
        private void button61_Click(object sender, EventArgs e)
        {
            parametro param = new parametro();
            
            try
            {
                param = ManejadorParametros.Obtener(1);

                MessageBox.Show(param.idParametro + " - " + param.nombre + "  -  " + param.valor);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            int num = -1;
            parametro param = new parametro();
            
            try
            {
                param = ManejadorParametros.Obtener(num);
                if (num >= 0)
                {
                    MessageBox.Show(param.idParametro + " - " + param.nombre + "  -  " + param.valor);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
            

        //ManejadorOrdenes------------------------------------------------------------------------------------------------------------------
        //ObtenerActivas 19
        private void button65_Click(object sender, EventArgs e)
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

        //Obtener 20
        private void button69_Click(object sender, EventArgs e)
        {
            Orden orden = new Orden();
            int num = 1;
            
            try
            {
                orden = ManejadorOrdenes.Obtener(num);
                if (num > 0)
                {
                    for (int i = 0; i < orden.detalle.Count(); i++)
                    {
                        MessageBox.Show(" " + orden.idOrden + "  " + orden.mesero + "   " + orden.cliente + "  " + orden.fecha + "  - - -  " + orden.detalle.ElementAt(i).producto.idProducto + "  " + orden.detalle.ElementAt(i).producto.nombre + "  ---  " + orden.detalle.ElementAt(i).producto.categoria.idCategoria + "  " + orden.detalle.ElementAt(i).producto.categoria.nombre + "  ");
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Orden orden = new Orden();
            int num = -1;
            try
            {
                orden = ManejadorOrdenes.Obtener(num);
                if (num > 0)
                {
                    for (int i = 0; i < orden.detalle.Count(); i++)
                    {
                        MessageBox.Show(" " + orden.idOrden + "  " + orden.mesero + orden.cliente + "  " + orden.fecha + "  " + orden.detalle.ElementAt(i).producto.idProducto + "  " + orden.detalle.ElementAt(i).producto.nombre + "  " + orden.detalle.ElementAt(i).producto.categoria.idCategoria + "  " + orden.detalle.ElementAt(i).producto.categoria.nombre + "  ");
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }   
        }
        
        //Actualizar 21
        private void button73_Click(object sender, EventArgs e)
        {  
            Orden ord = new Orden();
            ord.idOrden = 4;
            ord.mesero = "mesero4";
            ord.mesa = "mesa4";
            ord.cliente = "cliente4";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario_Actualizado";
            ord.total = 3.0;
            ord.activa = true;

            //productos que iran dentro de la orden
            producto prod = new producto();
            prod.idProducto = 4;
            prod.nombre = "prueba1_actualizado";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';

            producto prod2 = new producto();
            prod2.idProducto = 5;
            prod2.nombre = "prueba2_Actualizado";
            prod2.precio = 2.0;
            prod2.categoria.idCategoria = 2;
            prod2.area = 'c';
            
            //añadir registros a lista ord.detalle
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
                if (ManejadorOrdenes.Actualizar(ord) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Orden ord = new Orden();
            ord.idOrden = 4;
            ord.mesero = "mesero4";
            ord.mesa = "mesa4";
            ord.cliente = "cliente4";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario_Actualizado";
            ord.total = 3.0;
            ord.activa = true;
            ord.detalle = new List<DetalleOrden>();

            //Se intenta de actualizar sin productos

            try
            {
                if (ManejadorOrdenes.Actualizar(ord) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            Orden ord = new Orden();
            ord.idOrden = 4;
            ord.mesero = "','mesero4";
            ord.mesa = "','mesa4";
            ord.cliente = "','cliente4";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario_Actualizado";
            ord.total = 3.0;
            ord.activa = true;

            //productos que iran dentro de la orden
            producto prod = new producto();
            prod.idProducto = 4;
            prod.nombre = "prueba1_actualizado";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';

            producto prod2 = new producto();
            prod2.idProducto = 5;
            prod2.nombre = "prueba2_Actualizado";
            prod2.precio = 2.0;
            prod2.categoria.idCategoria = 2;
            prod2.area = 'c';

            //añadir registros a lista ord.detalle
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
                if (ManejadorOrdenes.Actualizar(ord) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // BuscarActivas 22
        private void button77_Click(object sender, EventArgs e)
        {
            List<Orden> orden = new List<Orden>();
            string text = "m";
            
            try
            {
                orden = ManejadorOrdenes.BuscarActivas(text);

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

        private void button78_Click(object sender, EventArgs e)
        {
            List<Orden> orden = new List<Orden>();
            
            try
            {
                orden = ManejadorOrdenes.BuscarActivas(" ");

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

        private void button79_Click(object sender, EventArgs e)
        {
            List<Orden> orden = new List<Orden>();
            
            try
            {
                orden = ManejadorOrdenes.BuscarActivas("J %' OR 1='1");

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

        //Insertar()  23
        private void button81_Click(object sender, EventArgs e)
        {
            Orden ord = new Orden();
            ord.idOrden = 4;
            ord.mesero = "mesero4";
            ord.mesa = "mesa4";
            ord.cliente = "cliente4";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario_Insertado";
            ord.total = 3.0;
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

            //añadir registros a lista ord.detalle
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

        private void button82_Click(object sender, EventArgs e)
        {
            Orden ord = new Orden();
            ord.idOrden = 4;
            ord.mesero = "mesero4";
            ord.mesa = "mesa4";
            ord.cliente = "cliente4";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario_Insertado";
            ord.total = 3.0;
            ord.activa = true;
            ord.detalle = new List<DetalleOrden>();

            //sin productos
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

        private void button83_Click(object sender, EventArgs e)
        {
            Orden ord = new Orden();
            ord.idOrden = 4;
            ord.mesero = "'','mesero4";
            ord.mesa = "mesa4";
            ord.cliente = "cliente4";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario_Insertado";
            ord.total = 3.0;
            ord.activa = true;

            //productos que iran dentro de la orden
            producto prod = new producto();
            prod.idProducto = 4;
            prod.nombre = "','";
            prod.precio = 1.0;
            prod.categoria.idCategoria = 1;
            prod.area = 'b';

            producto prod2 = new producto();
            prod2.idProducto = 5;
            prod2.nombre = "prueba2";
            prod2.precio = 2.0;
            prod2.categoria.idCategoria = 2;
            prod2.area = 'c';

            //añadir registros a lista ord.detalle
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

        //Eliminar()  24
        private void button85_Click(object sender, EventArgs e)
        {
            Orden ord = new Orden();
            ord.idOrden = 4;
            ord.mesero = "mesero4";
            ord.mesa = "mesa4";
            ord.cliente = "cliente4";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario_Insertado";
            ord.total = 3.0;
            ord.activa = true;

            try
            {
                if (ManejadorOrdenes.Eliminar(ord) > 0)
                {
                    MessageBox.Show("Registro Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            Orden ord = new Orden();
            ord.idOrden = -4;
            ord.mesero = "mesero4";
            ord.mesa = "mesa4";
            ord.cliente = "cliente4";
            ord.fecha = new DateTime(2018, 05, 31, 08, 59, 00);
            ord.comentario = "comentario_Insertado";
            ord.total = 3.0;
            ord.activa = true;

            try
            {
                if (ManejadorOrdenes.Eliminar(ord) > 0)
                {
                    MessageBox.Show("Registro Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ObtenerID() 25
        private void button89_Click(object sender, EventArgs e)
        {
            int num;
            try
            {
                num = ManejadorOrdenes.ObtenerID();
                MessageBox.Show("" + num);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //ObtenerVentas(dateTime) 26
        private void button93_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime(2018, 05, 31);

            List<Orden> lstOrden = new List<Orden>();
            try
            {
                lstOrden = ManejadorOrdenes.ObtenerVentas(fecha);

                for (int i = 0; i < lstOrden.Count(); i++)
                {
                    MessageBox.Show("" + lstOrden.ElementAt(i).idOrden + "   " + lstOrden.ElementAt(i).mesero + "   " + lstOrden.ElementAt(i).activa);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //ObtenerVentas(DateTime, DateTime) 27 
        private void button97_Click(object sender, EventArgs e)
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
        }

        private void button94_Click(object sender, EventArgs e)
        {

        }

        private void button95_Click(object sender, EventArgs e)
        {

        }
    }
}
