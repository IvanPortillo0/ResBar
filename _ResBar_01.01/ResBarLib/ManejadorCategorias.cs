using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ResBarLib
{
    public static class ManejadorCategorias
    {
        public static List<Categoria> Obtener(Boolean ConSinProducto)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query;
                    if (ConSinProducto)
                    {
                        query = "SELECT * FROM categoria;";
                        var resp = db.Query<Categoria>(query).ToList();
                        return resp;
                    }
                    else
                    {
                        query = "SELECT idCategoria FROM categoria;";
                        var respuesta2 = db.Query<Categoria>(query).ToList();
                        return respuesta2;
                    }
                }

            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException("Obtener()$ No es posible conectarse a la DB", ex.InnerException);
            }
        }

        public static int Insertar(Categoria categoria)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "INSERT INTO categoria (idCategoria, nombre) VALUES('" + categoria.idCategoria + "', '" + categoria.nombre + "');";
                    var respuesta = db.Execute(query, categoria);
                    return respuesta;
                }

            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        public static int Actualizar(Categoria categoria)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "UPDATE categoria SET nombre='" + categoria.nombre + "' WHERE idCategoria= '" + categoria.idCategoria + "';";
                    var respuesta = db.Execute(query, categoria);
                    return respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        public static int Eliminar(Categoria categoria)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "DELETE FROM categoria WHERE idCategoria='" + categoria.idCategoria + "';";
                    var respuesta = db.Execute(query, categoria);
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
                    string query = "SELECT MAX(idCategoria) FROM categoria;";
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
