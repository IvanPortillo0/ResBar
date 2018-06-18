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
                    string query = "SELECT * FROM parametro; ";
                    var respuesta = db.Query<parametro>(query).ToList();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorParametros.Obtener()$ No es posible conectarse a la DB.");
            }
        }

        //Actualiza el valor del parámetro en la base de datos, no se puede actualizar ni el ID, ni el nombre, solo se puede modificar el campo valor
        public static int Actualizar(parametro param)
        {
            int numMsj = 0;
            String msjExepcion = "ManejadorParametros.Actualizar()$Problemas al conectar en la DB.";
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    if (!param.valor.Equals(""))
                    {
                        string query = "UPDATE parametro SET valor=@valo WHERE idParametro=@idparametr;";
                        respuesta = db.Execute(query, new { idparametr = param.idParametro, valo = param.valor });
                        if (respuesta == 0)
                        {
                            numMsj = 2; //"ManejadorParametros.Actualizar()$No Existe registro de id=" + param.idParametro
                            throw new ErrorAplicationException();
                        }
                    }
                    else
                    {
                        numMsj = 1; //"ManejadorParametros.Actualizar()$Campo valor es vacio."
                        throw new ErrorAplicationException();
                    }
                }
               
                return respuesta;
            }
            catch
            {
                switch (numMsj)
                {
                    case 1:
                        msjExepcion = "ManejadorParametros.Actualizar()$Campo valor es vacio.";
                        break;
                    case 2:
                        msjExepcion = "ManejadorParametros.Actualizar()$No Existe registro de id=" + param.idParametro;
                        break;
                }
                throw new ErrorAplicationException(msjExepcion);
            }
        }

        //Toma el idParametro y busca en la base de datos una tupla que coincida con dicho ID, luego devuelve un objeto parametro construido acorde a la tupla
        public static parametro Obtener(int idparametro)
        {
            int numMsj = 0;
            String msjExepcion = "ManejadorParametros.Obtener()$Problemas al conectar en la BD";
            parametro respuesta = new parametro();
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    if (idparametro > 0)
                    {
                        string query = "SELECT* FROM parametro WHERE idParametro = @idParametr; ";
                        respuesta = db.Query<parametro>(query, new { idParametr = idparametro }).SingleOrDefault();
                    }
                    else
                    {
                        numMsj = 1; //"ManejadorPrametros.Obtener()$id no existe"
                        throw new ErrorAplicationException();
                    }

                    return respuesta;
                }

            }
            catch
            {
                if (numMsj == 1)
                {
                    msjExepcion = "ManejadorParametros.Obtener()$id no existe.";
                }
                throw new ErrorAplicationException(msjExepcion);
            }
        }
    }
}
