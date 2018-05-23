using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ResBarLib
{
    public static class ManejadorProductos
    {
        public static List<producto> ObtenerxCategoria(int idCategoria)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT * FROM producto WHERE idCategoria=" + idCategoria + ";";
                    var Respuesta = db.Query<producto>(query).ToList();
                    return Respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }

        }

        public static List<producto> Buscar(string nombreProd, int idCategoria)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT * FROM producto WHERE idCategoria=" + idCategoria + " AND nombre REGEXP '^[" + nombreProd + "]';";
                    var respuesta = db.Query<producto>(query).ToList();
                    return respuesta;
                }

            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        public static int Insertar(producto prod)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "INSERT INTO producto (idProducto, nombre, precio, idCategoria, area) VALUES('" + prod.idProducto + "', '" + prod.nombre + "', '" + prod.precio + "', '" + prod.categoria.idCategoria + "', '" + prod.area + "');";
                    var respuesta = db.Execute(query, prod);
                    return respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }

        }

        public static int Actualizar(producto prod)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "UPDATE producto SET nombre='" + prod.nombre + "', precio='" + prod.precio + "', idCategoria='" + prod.categoria.idCategoria + "', area='" + prod.area + "' WHERE idProducto= '" + prod.idProducto + "';";
                    var respuesta = db.Execute(query, prod);
                    return respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        public static int Eliminar(producto prod)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "DELETE FROM producto WHERE idProducto='" + prod.idProducto + "';";
                    var respuesta = db.Execute(query, prod);
                    return respuesta;
                }

            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        public static producto Obtener(int idProducto)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT* FROM producto WHERE idProducto = '" + idProducto + "'; ";
                    var respuesta = db.Query<producto>(query).SingleOrDefault();
                    return respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        public static int ObtenerID()
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT MAX(idProducto) FROM producto;";
                    var id = db.Query<int>(query).SingleOrDefault();
                    id = id + 1;
                    return id;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

    }
}
