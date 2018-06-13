using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResBarLib
{
   public class DetalleOrden
    {
        //Esta clase se Mapeara con el ORM Dapper.-
        public DetalleOrden()
        {
            producto = new producto();
        }
        
        public producto producto { get; set; }
        public double cantidad { get; set; }
    }
}
