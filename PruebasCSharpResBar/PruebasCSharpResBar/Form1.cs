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
            try
            {
                List<producto> prod = new List<producto>();
                prod = ManejadorProductos.ObtenerxCategoria(-22);

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
            prod = ManejadorProductos.Buscar("%')");

            for (int i = 0; i < prod.Count(); i++)
            {
                MessageBox.Show("" + prod.ElementAt(i).nombre);
            }
        }

        private void btn2b_Click(object sender, EventArgs e)
        {
            //prueba de inyeccion
            List<producto> prod = new List<producto>();
            prod = ManejadorProductos.Buscar("c % ' OR 1='1");

            for (int i = 0; i < prod.Count(); i++)
            {
                MessageBox.Show("" + prod.ElementAt(i).nombre);
            }
        }

        private void btn2c_Click(object sender, EventArgs e)
        {

        }

        private void btn2d_Click(object sender, EventArgs e)
        {

        }
        //ManejadorProducto.insertar()
        private void button1_Click(object sender, EventArgs e)
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
                else
                {
                    MessageBox.Show("No se Inserto");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

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

        private void button21_Click(object sender, EventArgs e)
        {

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
    }
}
