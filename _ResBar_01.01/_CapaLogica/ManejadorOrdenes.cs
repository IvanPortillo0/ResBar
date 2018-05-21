
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Linq;
using MySql.Data.MySqlClient;
using _CapaLogica;
using System;

namespace CapaLogica// cambiar a ResbarLib
{
    public static class ManejadorOrdenes
    {
        //Obtienen todas las Ordenes "Activas"=True.-
        public static List<Orden> OrdenesActivas()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT * FROM orden WHERE activa=true ";
                    var Respuesta = db.Query<Orden>(query).ToList();
                    return Respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        public static int Actualizar(Orden orden)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "UPDATE orden SET mesero='" + orden.mesero + "', mesa='" + orden.mesa + "', cliente='" + orden.cliente + "', fecha='" + orden.fecha + "', comentario='" + orden.comentario + "', total='" + orden.total + "', estado='" + orden.activa + "' WHERE idOrden= '" + orden.idOrden + "';";
                    var respuesta = db.Execute(query, orden);
                    return respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        //Inserta una orden 
        public static int Insertar(Orden orden)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "INSERT INTO orden (idOrden, mesero, mesa, cliente, fecha, comentario, total, estado) VALUES('" + orden.idOrden + "', '" + orden.mesero + "', '" + orden.mesa + "', '" + orden.cliente + "', '" + orden.fecha + orden.comentario + orden.total + orden.activa + "');";
                    var respuesta = db.Execute(query, orden);
                    return respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }
        //Obtiene todas las ordenes que contenga el "criterio buscado".- (mesa, mesero o cliente)
        public static List<Orden> BuscarActivas(string criterio)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "select * from orden where (mesero like '%@criterio%') or (mesa like '%@criterio%') or (cliente like '%@criterio%') ";
                    var Respuesta = db.Query<Orden>(query).ToList();
                    return Respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        public static int Eliminar(Orden orden)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "DELETE FROM orden WHERE idOrden='" + orden.idOrden + "';";
                    var respuesta = db.Execute(query, orden);
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
                    string query = "SELECT MAX(idOrden) FROM orden;";
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

        public static List<Orden> ObtenerVentas(DateTime fecha)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT * FROM orden WHERE fecha= " + fecha + " AND activa=false;";
                    var Respuesta = db.Query<Orden>(query).ToList();
                    return Respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }
        public static List<Orden> ObtenerVentas(DateTime fechaMayor, DateTime fechaMenor)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    String query = "SELECT * FROM orden WHERE fecha >=" + fechaMenor + " AND fecha<= " + fechaMayor + "AND active=false";
                    var Respuesta = db.Query<Orden>(query).ToList();
                    return Respuesta;
                }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }
    }
}
