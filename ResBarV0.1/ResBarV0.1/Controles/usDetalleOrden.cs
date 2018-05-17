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
    public partial class usDetalleOrden : UserControl
    {
        public usDetalleOrden()
        {
            InitializeComponent();
        }

        private void usDetalleOrden_Load(object sender, EventArgs e)
        {
           //Crear tabla virtual
            DataTable dtDetalleOrden = new DataTable();

            //Definir columnas
            dtDetalleOrden.Columns.Add("Producto");
            dtDetalleOrden.Columns.Add("Cantidad");

            //Crear una fila y definir un registro
            DataRow row1 = dtDetalleOrden.NewRow();
            //Filas
            row1["Producto"] = "Puyaso Importado";
            row1["Cantidad"] = "20";

            //Otro Registro. 2
            DataRow row2 = dtDetalleOrden.NewRow();
            row2["Producto"] = "Tres Leches";
            row2["Cantidad"] = "08";

            //Otro Registro. 3
            DataRow row3 = dtDetalleOrden.NewRow();
            row3["Producto"] = "CocaCola";
            row3["Cantidad"] = "10";

            dtDetalleOrden.Rows.Add(row1);
            dtDetalleOrden.Rows.Add(row2);
            dtDetalleOrden.Rows.Add(row3);
            dgDetalleOrden.DataSource = dtDetalleOrden;
            dgDetalleOrden.Update();

            //Definicion de anchos de columna 
            dgDetalleOrden.Columns["Producto"].Width = 350;
            dgDetalleOrden.Columns["Cantidad"].Width = 125;

        }
    }
}
