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
    public partial class usCobrar : UserControl
    {
        public usCobrar()
        {
            InitializeComponent();
        }

        private void usCobrar_Load(object sender, EventArgs e)
        {
            //Crear tabla virtual
            DataTable dtCobrar = new DataTable();

            //Definir columnas
            dtCobrar.Columns.Add("Cantidad");
            dtCobrar.Columns.Add("Producto");
            dtCobrar.Columns.Add("P/U");
            dtCobrar.Columns.Add("Subtotal");

            //Crear una fila y definir un registro
            DataRow row1 = dtCobrar.NewRow();
            //Filas
            row1["Cantidad"] = "2";
            row1["Producto"] = "Puyaso Importado";
            row1["P/U"] = "$5.75";
            row1["Subtotal"] = "$11.50";


            //Otro Registro.
            DataRow row2 = dtCobrar.NewRow();
            row2["Cantidad"] = "4";
            row2["Producto"] = "Tres Leches";
            row2["P/U"] = "$3.25";
            row2["Subtotal"] = "$13.00";


            //Otro Registro. 3
            DataRow row3 = dtCobrar.NewRow();
            row3["Cantidad"] = "6";
            row3["Producto"] = "CocaCola";
            row3["P/U"] = "$1.25";
            row3["Subtotal"] = "$7.50";

            dtCobrar.Rows.Add(row1);
            dtCobrar.Rows.Add(row2);
            dtCobrar.Rows.Add(row3);
            dgCobrar.DataSource = dtCobrar;
            dgCobrar.Update();

            //Definicion de anchos de columna
            dgCobrar.Columns["Cantidad"].Width = 100;
            dgCobrar.Columns["Producto"].Width = 250;
            dgCobrar.Columns["P/U"].Width = 125;
            dgCobrar.Columns["Subtotal"].Width = 125;

            this.txtTotal.Text = "$32.00";
        }
    }
}
