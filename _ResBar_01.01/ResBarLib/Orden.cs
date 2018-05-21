using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResBarLib
{
    public class Orden
    {
        public Orden()
        {
            //Constructor.
        }

        public int idOrden { get; set; }
        public string mesero { get; set; }
        public string mesa { get; set; }
        public string cliente { get; set; }
        public DateTime fecha { get; set; }
        public string comentario { get; set; }

        public double total { get; set; }
        public Boolean activa { get; set; }
        public List<DetalleOrden> detalle { get; set; }


        //Métodos Propios de la Clase Producto.-
        //Falta Agregar los manejos de Excepciones..-
        public void CalcularTotal()
        {
            var cuenta = new double();
            //recorro el detalleOrden para calcular el total de la orden
            foreach (DetalleOrden orden in detalle)
            {
                //asigno a una variable "cuenta" la suma cantidad multiplicada por el precio de cada producto.-
                cuenta += orden.producto.precio * orden.cantidad;
            }
            //asigno el nuevo valor a "total".-
            this.total = cuenta;
        }

        //Falta Agregar los manejos de Excepciones..-
        public void AgregarProducto(producto prod, double cant)
        {
            var nuevoDetalle = new DetalleOrden();
            //Verificar si el producto ya existe en el "DetalleOrde"
            //Busco dentro de la lista de "DetalleOrde" el producto.
            foreach (DetalleOrden orden in detalle)
            {
                if (orden.producto.nombre == prod.nombre)
                {
                    orden.cantidad += cant; //Sumo a la orden la cantidad

                }
                else
                {
                    //Si no es igual instancio un nuevo objeto de "DetalleOrden"
                    nuevoDetalle.producto = prod;
                    nuevoDetalle.cantidad = cant;
                    detalle.Add(nuevoDetalle);
                    this.CalcularTotal();
                }
            }
        }

        public void EliminarProducto(producto prod, double cant)
        {
            //Buscamos el producto a eliminar.
            foreach (DetalleOrden DetalleOrden in detalle)
            {
                if (DetalleOrden.producto.nombre == prod.nombre)
                {
                    detalle.Remove(DetalleOrden);
                    this.CalcularTotal(); //Calculo nuevamente el detalle de la Orden.-
                }

            }

        }


    }
}
