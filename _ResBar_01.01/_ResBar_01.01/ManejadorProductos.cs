using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _ResBar_01
{
    class ManejadorProductos
    {
        public static List<producto> ObtenerxCategoria(int idCategoria)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "SELECT * FROM producto WHERE idProducto=" + idCategoria + ";";
                var Respuesta = db.Query<producto>(query).ToList();
                return Respuesta;
            }
        }

        public static List<producto> Buscar(string nombreProd, int idCategoria)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "SELECT * FROM producto WHERE idProducto=" + idCategoria + " AND nombre REGEXP '^[" + nombreProd + "]';";
                var respuesta = db.Query<producto>(query).ToList();
                return respuesta;
            }
        }

        public static int Insertar(producto prod)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "INSERT INTO producto (idProducto, nombre, precio, idCategoria, area) VALUES('" + prod.idProducto + "', '" + prod.nombre + "', '" + prod.precio + "', '" + prod.categoria + "', '" + prod.area + "');";
                var respuesta = db.Execute(query, prod);
                return respuesta;
               // return db.ExecuteScalar<producto>(new CommandDefinition(query));
            }
        }

        public static int Actualizar(producto prod)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "UPDATE producto SET nombre='" + prod.nombre + "', precio='" + prod.precio + "', idCategoria='" + prod.categoria + "', area='" + prod.area + "' WHERE idProducto= '" + prod.idProducto + "';";
                var respuesta = db.Execute(query, prod);
                //var respuesta = db.Query<producto>(query).SingleOrDefault();
                return respuesta;
               // return db.ExecuteScalar<producto>(new CommandDefinition(query, prod));
            }
        }

        public static int Eliminar(producto prod)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "DELETE FROM producto WHERE idProducto='" + prod.idProducto + "';";
                var respuesta = db.Execute(query, prod);
                //var respuesta = db.Query<producto>(query).SingleOrDefault();
                return respuesta;
                //var respuesta = db.ExecuteScalar<producto>(new CommandDefinition(query, prod));
            }
        }

        public static producto Obtener(int idProducto)
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

        public static int ObtenerID()
        {
            
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                    MessageBox.Show("Abrio la conexion");

                string query = "SELECT MAX(idProducto) FROM producto;";
                var id = db.Query<int>(query).SingleOrDefault();
                id = id + 1;
                return id;
            }
        }

    }
}
