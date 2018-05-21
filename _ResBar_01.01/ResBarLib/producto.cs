using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResBarLib
{
    class producto
    {
        //Esta clase se Mapeara con el ORM Dapper.-
        public producto()
        {
            //Se instancia la clase categoria.
            categoria = new Categoria();
        }

        //Variables.-
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public Categoria categoria { get; set; }
        public Char area { get; set; }
    }
}
