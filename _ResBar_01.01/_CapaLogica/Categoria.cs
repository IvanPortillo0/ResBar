 using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class Categoria
    {
        //Esta clase se Mapeara con el ORM Dapper.-
        public Categoria()
        {
            //Inicializamos productos
            productos = new List<producto>();
        }


        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public List<producto> productos { get; set; }
    }
}
