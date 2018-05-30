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
            prod = ManejadorProductos.Buscar("c", 1);

            for (int i = 0; i < prod.Count(); i++)
            {
                MessageBox.Show("" + prod.ElementAt(i).nombre);
            }
        }

        private void btn2b_Click(object sender, EventArgs e)
        {
            //prueba de inyeccion
            List<producto> prod = new List<producto>();
            prod = ManejadorProductos.Buscar("c % ' OR 1='1", 1);

            for (int i = 0; i < prod.Count(); i++)
            {
                MessageBox.Show("" + prod.ElementAt(i).nombre);
            }
        }
        
    }
}
