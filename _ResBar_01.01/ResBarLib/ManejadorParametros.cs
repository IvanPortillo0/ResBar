using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ResBarLib
{
    public static class ManejadorParametros
    {
        //Va a la base de datos y obtiene todos los parametros que están en dicha tabla, devolviendo una colección de objetos parametros.
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
                throw new ErrorAplicationException("ManejadorParametros.Obtener()$ No es posible conectarse a la DB");
            }
        }

        //Actualiza el valor del parámetro en la base de datos, no se puede actualizar ni el ID, ni el nombre, solo se puede modificar el campo valor
        public static int Actualizar(parametro param)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "UPDATE parametro SET nombre=@nombr, valor=@valo WHERE idProducto=@idparametr;";
                    respuesta = db.Execute(query, new { idparametr=param.idParametro, nombr=param.nombre, valo=param.valor });
                    if (respuesta == 0) { MessageBox.Show("ManejadorParametros.Actualizar()$No Existe registro de id=" + param.idParametro); }
                }
                return respuesta;
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorParametros.Actualizar()$Problemas al conectar en la DB");
            }
        }

        //Toma el idParametro y busca en la base de datos una tupla que coincida con dicho ID, luego devuelve un objeto parametro construido acorde a la tupla
        public static parametro Obtener(int idparametro)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT* FROM parametro WHERE idParametro = @idParametr; ";
                    var respuesta = db.Query<parametro>(query, new { idParametr= idparametro }).SingleOrDefault();
                    return respuesta;
                }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorParametros.Obtener(int idparametro)$Problemas al conectar en la BD");
            }
        }
    }
}
