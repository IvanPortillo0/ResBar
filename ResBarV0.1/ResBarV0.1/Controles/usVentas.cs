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
    public partial class usVentas : UserControl
    {
        public usVentas()
        {
            InitializeComponent();
        }

        private void usVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void rbtnDia_CheckedChanged(object sender, EventArgs e)
        {
            dgVentas.Refresh();

            //Crear tabla virtual
            DataTable dtVentas = new DataTable();

            //Definir columnas
            dtVentas.Columns.Add("No Orden");
            dtVentas.Columns.Add("Fecha y Hora");
            dtVentas.Columns.Add("Total ($)");

            //Crear una fila y definir un registro
            DataRow row1 = dtVentas.NewRow();
            row1["No Orden"] = "01";
            row1["Fecha y Hora"] = "10/01/18 11:30 p.m.";
            row1["Total ($)"] = "$20.45";

            //Otro Registro. 2
            DataRow row2 = dtVentas.NewRow();
            row2["No Orden"] = "02";
            row2["Fecha y Hora"] = "10/01/18 1:00 p.m.";
            row2["Total ($)"] = "$15.50";

            //Otro Registro. 3
            DataRow row3 = dtVentas.NewRow();
            row3["No Orden"] = "03";
            row3["Fecha y Hora"] = "12/01/18 10:00 a.m.";
            row3["Total ($)"] = "$10.25";

            //Otro Registro. 4
            DataRow row4 = dtVentas.NewRow();
            row4["No Orden"] = "04";
            row4["Fecha y Hora"] = "13/01/18 2:20 p.m.";
            row4["Total ($)"] = "$35.50";

            dtVentas.Rows.Add(row1);
            dtVentas.Rows.Add(row2);
            dtVentas.Rows.Add(row3);
            dtVentas.Rows.Add(row4);
            dgVentas.DataSource = dtVentas;
            dgVentas.Update();

            //Definicion de anchos de columna
            dgVentas.Columns["No Orden"].Width = 125;
            dgVentas.Columns["Fecha y Hora"].Width = 250;
            dgVentas.Columns["Total ($)"].Width = 120;
        }

        private void rbtnMes_CheckedChanged(object sender, EventArgs e)
        {
            dgVentas.Refresh();

            //Crear tabla virtual
            DataTable dtVentas = new DataTable();

            //Definir columnas
            dtVentas.Columns.Add("Fecha y Hora");
            dtVentas.Columns.Add("Total ($)");

            //Crear una fila y definir un registro
            DataRow row1 = dtVentas.NewRow();
            row1["Fecha y Hora"] = "10/01/18   11:30 p.m.";
            row1["Total ($)"] = "$35.95";

            //Otro Registro. 2
            DataRow row2 = dtVentas.NewRow();
            row2["Fecha y Hora"] = "11/01/18   1:00 p.m.";
            row2["Total ($)"] = "$15.50";

            //Otro Registro. 3
            DataRow row3 = dtVentas.NewRow();
            row3["Fecha y Hora"] = "12/01/18   10:00 a.m.";
            row3["Total ($)"] = "$10.25";

            //Otro Registro. 4
            DataRow row4 = dtVentas.NewRow();
            row4["Fecha y Hora"] = "13/01/18   2:20 p.m.";
            row4["Total ($)"] = "$35.50";

            dtVentas.Rows.Add(row1);
            dtVentas.Rows.Add(row2);
            dtVentas.Rows.Add(row3);
            dtVentas.Rows.Add(row4);
            dgVentas.DataSource = dtVentas;
            dgVentas.Update();

            //Definicion de anchos de columna
            dgVentas.Columns["Fecha y Hora"].Width = 250;
            dgVentas.Columns["Total ($)"].Width = 120;
            
        }

        
    }
}
