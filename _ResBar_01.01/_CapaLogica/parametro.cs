using System;
using System.Collections.Generic;
using System.Text;

namespace CapaLogica
{
    //Esta clase se Mapeara con el ORM Dapper.-
    public class parametro
    {
        public parametro(){
            //Constructor.
        }


        public int idParametro { get; set; }
        public string nombre { get; set; }
        public string valor { get; set; }

    }
}
