using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ResBarLib
{
    class DbConnection
    {
        //Metodo para la conexion a la DB.
        //usuario: resbar
        //contraseña: Restaurante2018
        //localhost.
       
       public static string Cadena()
        {
            string CadenaConexion = "server=127.0.0.1; database=resbar; Uid=resbar; pwd=Restaurante2018;";
            return CadenaConexion;
        }
    }
}
