using System;
using System.Collections.Generic;
using System.Text;

namespace CapaLogica
{
    //Esta clase se Mapeara con el ORM Dapper.-
    public class DetalleOrden
    {
        public DetalleOrden()
        {
            producto = new producto();
        }

        public producto producto { get; set; }
        public double cantidad { get; set; }
    }
}
