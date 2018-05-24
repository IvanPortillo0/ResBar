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
    public static class ManejadorParametros
    {
        public static List<parametro> Obtener()
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT* FROM parametro; ";
                    var respuesta = db.Query<parametro>(query).ToList();
                    return respuesta;
                }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.ObtenerxCategoria()$ No es posible conectarse a la DB");
            }
        }

        public static int Actualizar(parametro param)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "UPDATE parametro SET nombre='" + param.nombre + "', valor='" + param.valor + "' WHERE idProducto= '" + param.idParametro + "';";
                    var respuesta = db.Execute(query, param);
                    return respuesta;
                }

            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }
        public static parametro Obtener(int idparametro)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT* FROM parametro WHERE idParametro = '" + idparametro + "'; ";
                    var respuesta = db.Query<parametro>(query).SingleOrDefault();
                    return respuesta;
                }

            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }
    }
}
