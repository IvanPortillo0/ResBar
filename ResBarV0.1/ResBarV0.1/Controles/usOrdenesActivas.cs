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
    public partial class usOrdenesActivas : UserControl
    {
        public usOrdenesActivas()
        {
            InitializeComponent();
        }

        //Load Carga Datos de la Tabla
        private void usOrdenesActivas_Load(object sender, EventArgs e)
        {
            //Crear tabla virtual
            DataTable dtOrdenes = new DataTable();
            
            //Definir columnas
            dtOrdenes.Columns.Add("No");
            dtOrdenes.Columns.Add("Mesa");
            dtOrdenes.Columns.Add("Mesero");
            dtOrdenes.Columns.Add("Cliente");
            dtOrdenes.Columns.Add("Total");

            //Crear una fila y definir un registro
            DataRow row1 = dtOrdenes.NewRow();
            row1["No"] = "027";
            row1["Mesa"] = "10";
            row1["Mesero"] = "José Antonio";
            row1["Cliente"] = "Juan Perez";
            row1["Total"] = "$15.50";

            //Otro Registro. 2
            DataRow row2 = dtOrdenes.NewRow();
            row2["No"] = "021";
            row2["Mesa"] = "8";
            row2["Mesero"] = "Pedro Antonio";
            row2["Cliente"] = "Juan Perez";
            row2["Total"] = "$15.50";

            //Otro Registro. 3
            DataRow row3 = dtOrdenes.NewRow();
            row3["No"] = "026";
            row3["Mesa"] = "15";
            row3["Mesero"] = "Pedro Antonio";
            row3["Cliente"] = "Juan Perez";
            row3["Total"] = "$15.50";

            //Otro Registro. 4
            DataRow row4 = dtOrdenes.NewRow();
            row4["No"] = "016";
            row4["Mesa"] = "12";
            row4["Mesero"] = "Luis Alfredo";
            row4["Cliente"] = "Carlos Chacon";
            row4["Total"] = "$35.50";

            dtOrdenes.Rows.Add(row1);
            dtOrdenes.Rows.Add(row2);
            dtOrdenes.Rows.Add(row3);
            dtOrdenes.Rows.Add(row4);
            dgOrdenes.DataSource = dtOrdenes;
            dgOrdenes.Update();

            //Definicion de anchos de columna
            dgOrdenes.Columns["No"].Width = 75;
            dgOrdenes.Columns["Mesa"].Width = 75;
            dgOrdenes.Columns["Mesero"].Width = 225;
            dgOrdenes.Columns["Cliente"].Width = 225;
            dgOrdenes.Columns["Total"].Width = 100;

        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            Emergentes.FrmNuevaOrden objNuevaOrden = new Emergentes.FrmNuevaOrden();
            objNuevaOrden.Show();
        }

        private void btnNuevaOrden_Click_1(object sender, EventArgs e)
        {
            Emergentes.FrmNuevaOrden objNuevaOrden = new Emergentes.FrmNuevaOrden();
            objNuevaOrden.Show();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Emergentes.FrmMenu objMenu = new Emergentes.FrmMenu();
            objMenu.Show();
        }

        private void btnModificarCuenta_Click(object sender, EventArgs e)
        {
            Emergentes.FrmDetalleOrden objDetalleOrden = new Emergentes.FrmDetalleOrden();
            objDetalleOrden.Show();
        }

        private void btnImprimirOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Emergentes.FrmCobrar objCobrar = new Emergentes.FrmCobrar();
            objCobrar.Show();
        }
    }
}
