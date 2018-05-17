using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResBarV0._1.Controles
{
    public partial class usMenu : UserControl
    {
        public usMenu()
        {
            InitializeComponent();
        }

        //Load Carga Datos de la Tabla
        private void usMenu_Load(object sender, EventArgs e)
        {
            //Crear tabla virtual
            DataTable dtProductos = new DataTable();

            //Definir columnas
            dtProductos.Columns.Add("No");
            dtProductos.Columns.Add("Nombre");
            dtProductos.Columns.Add("Cantidad");
            dtProductos.Columns.Add("Precio Venta");

            //Crear una fila y definir un registro
            DataRow row1 = dtProductos.NewRow();
            //Filas
            row1["No"] = "026";
            row1["Nombre"] = "Puyaso Importado";
            row1["Cantidad"] = "20";
            row1["Precio Venta"] = "$5.75";


            //Otro Registro.
            DataRow row2 = dtProductos.NewRow();
            row2["No"] = "084";
            row2["Nombre"] = "Tres Leches";
            row2["Cantidad"] = "08";
            row2["Precio Venta"] = "$3.25";


            //Otro Registro. 3
            DataRow row3 = dtProductos.NewRow();
            row3["No"] = "098";
            row3["Nombre"] = "CocaCola";
            row3["Cantidad"] = "10";
            row3["Precio Venta"] = "$1.25";

            dtProductos.Rows.Add(row1);
            dtProductos.Rows.Add(row2);
            dtProductos.Rows.Add(row3);
            dgProductos.DataSource = dtProductos;
            dgProductos.Update();

            //Definicion de anchos de columna
            dgProductos.Columns["No"].Width = 75;
            dgProductos.Columns["Nombre"].Width = 250;
            dgProductos.Columns["Cantidad"].Width = 125;
            dgProductos.Columns["Precio Venta"].Width = 150;
            
        }

        
    }
}
