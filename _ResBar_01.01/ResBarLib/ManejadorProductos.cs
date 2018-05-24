using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ResBarLib
{
    public static class ManejadorProductos
    {
        //Devuelve una colección de objetos productos que se corresponden con el Identificador de categoría que se pasó como parámetro.
        public static List<producto> ObtenerxCategoria(int idCategoria)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    
                    string query = "SELECT a.idProducto, a.nombre, a.precio, b.idCategoria, a.area FROM producto AS a INNER JOIN categoria AS b ON a.idCategoria = b.idCategoria WHERE a.idCategoria =" + idCategoria + " ORDER BY idProducto;";
                    var Respuesta = db.Query<producto>(query).ToList();
                    return Respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.ObtenerxCategoria()$ No es posible conectarse a la DB");
            }

        }

        //Buscara en la base de datos todos los productos cuyo Id o nombre coincida con el criterio de búsqueda, luego devuelve la colección de productos, sin devolver productos duplicados
        public static List<producto> Buscar(string nombreProd, int idCategoria)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT * FROM producto WHERE idCategoria=" + idCategoria + " AND nombre REGEXP '^[" + nombreProd + "]';";
                    var respuesta = db.Query<producto>(query).ToList();
                    return respuesta;
                }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Buscar()$ No es posible conectarse a la DB");
            }
        }

        //Agrega el objetoproducto" a la base de datos
        public static int Insertar(producto prod)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "INSERT INTO producto (idProducto, nombre, precio, idCategoria, area) VALUES('" + prod.idProducto + "', '" + prod.nombre + "', '" + prod.precio + "', '" + prod.categoria.idCategoria + "', '" + prod.area + "');";
                    respuesta = db.Execute(query, prod);
                }

                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorProductos.Insertar()$No se puede realizar la operación de Insertar");
                }
                else { return respuesta; }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Insertar()$Problemas al conectar en la DB");
            }
        }

        //Si el objeto “producto” se desea modificar este actualizara en la base de datos cuando este ya este modificado, no se modificara el ID del producto solo sus otros campos
        public static int Actualizar(producto prod)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "UPDATE producto SET nombre='" + prod.nombre + "', precio='" + prod.precio + "', idCategoria='" + prod.categoria.idCategoria + "', area='" + prod.area + "' WHERE idProducto= '" + prod.idProducto + "';";
                    respuesta = db.Execute(query, prod);
                }

                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorProductos.Actualizar()$No se puede realizar la operación de Actualizar");
                }
                else { return respuesta; }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Actualizar()$Problemas al conectar en la DB");
            }
        }

        //Elimina en la base de datos el "producto" que recibe como parametro
        public static int Eliminar(producto prod)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "DELETE FROM producto WHERE idProducto='" + prod.idProducto + "';";
                    respuesta = db.Execute(query, prod);
                }

                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorProductos.Eliminar()$No se puede realizar la operación de Eliminar");
                }
                else { return respuesta; }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Eliminar()$Problemas al conectar en la DB");
            }
        }

        //Realiza una petición a la base de datos y devuelve un objeto producto que cuyo IDProducto coincide con el valor del parámetro
        public static producto Obtener(int idProducto)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT* FROM producto WHERE idProducto = '" + idProducto + "'; ";
                    var respuesta = db.Query<producto>(query).SingleOrDefault();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Obtener()$Problemas al conectar en la DB");
            }
        }

        //Obtiene el identificador de producto, va la base de datos a obtener el ultimo ID de producto y le suma uno a dicho valor
        public static int ObtenerID()
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT MAX(idProducto) FROM producto;";
                    var id = db.Query<int>(query).SingleOrDefault();
                    id = id + 1;
                    return id;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.ObtenerID()$Problemas al conectar en la DB");
            }
        }

    }
}
