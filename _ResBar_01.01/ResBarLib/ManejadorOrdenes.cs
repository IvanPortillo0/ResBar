using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ResBarLib
{
    public static class ManejadorOrdenes
    {
        //va a la base de datos y filtra todas las ordenes cuyo campo Activa=TRUE, y devuelve un colección de objetos Orden

        public static List<Orden> OrdenesActivas()
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT * FROM orden WHERE activa=true ";
                    var respuesta = db.Query<Orden>(query).ToList();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.ObtenerActivas()$ No es posible conectarse a la DB");
            }
        }

        //Recibe un entero que indica el ID de la orden y luego devuelve el objeto orden completo que corresponde
        public static List<Orden> Obtener(int idOrden)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT * FROM orden WHERE idOrden=@idOrde;";
                    var respuesta = db.Query<Orden>(query, new { idOrde=idOrden }).ToList();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.Obtener()$ No es posible conectarse a la DB");
            }
        }

        //Obtiene todas las ordenes que contenga el "criterio buscado".- (mesa, mesero o cliente)
        public static List<Orden> BuscarActivas(string criterio)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "select * from orden where (mesero like '%@criteri%') or (mesa like '%@criteri%') or (cliente like '%@criteri%') ";
                    var respuesta = db.Query<Orden>(query, new { criteri=criterio }).ToList();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.BuscarActivas()$ No es posible conectarse a la DB");
            }
        }

        //Inserta el objeto orden en la base de datos, inserta una tupla en la tabla Orden y una o varias tuplas en la tabla 
        //Detalle Orden, además verifica que la orden tenga al menos uno de los campos con valor: mesero, mesa o cliente, no 
        //permite insertar ordenes con un total de cero o negativo, o que NO posean ningún producto en su detalle
        public static int Insertar(Orden orden)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "INSERT INTO orden (idOrden, mesero, mesa, cliente, fecha, comentario, total, estado) VALUES('" + orden.idOrden + "', '" + orden.mesero + "', '" + orden.mesa + "', '" + orden.cliente + "', '" + orden.fecha + orden.comentario + orden.total + orden.activa + "');";
                    respuesta = db.Execute(query, orden);
                }
                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorOrdenes.Insertar()$No se puede realizar la operación de Insertar");
                }
                else { return respuesta; }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        //Toma un objeto orden que ya existe en la tabla Orden de la base de datos, luego verifica que el objeto 
        //orden tenga productos, que su total sea mayor que cero, en la base de datos hace update de la tabla orden, y para 
        //la tabla Detalle Orden, lo que se hace es que se eliminan las tuplas de dicha orden y luego se insertan de nuevo
        public static int Actualizar(Orden orden)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "UPDATE orden SET mesero='" + orden.mesero + "', mesa='" + orden.mesa + "', cliente='" + orden.cliente + "', fecha='" + orden.fecha + "', comentario='" + orden.comentario + "', total='" + orden.total + "', estado='" + orden.activa + "' WHERE idOrden= '" + orden.idOrden + "';";
                    respuesta = db.Execute(query, orden);
                }

                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorOrdenes.Actualizar()$No se puede realizar la operación de Actualizar");
                }
                else { return respuesta; }
            }
            catch (ErrorAplicationException ex)
            {
                throw new ErrorAplicationException(ex.Message, ex.InnerException);
            }
        }

        //Elimina dicha orden de la base de datos, eliminando sus detalles también
        public static int Eliminar(Orden orden)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "DELETE FROM detalleorden WHERE idOrden=@idOrde;";
                    respuesta = db.Execute(query, new { idOrde=orden.idOrden });
                    query = "DELETE FROM orden WHERE idOrden=@idOrde;";
                    respuesta = db.Execute(query, new { idOrde = orden.idOrden });
                    if (respuesta == 0) { MessageBox.Show("ManejadorOrdenes.Eliminar()$No Existe registro de id=" + orden.idOrden); }
                }

                return respuesta;
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.Eliminar()$Problemas al conectar en la DB");
            }
        }
        


        //Va a la base de datos y obtiene el ultimo Id de orden y le suma 1

        public static int ObtenerID()
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT MAX(idOrden) FROM orden;";
                    var id = db.Query<int>(query).SingleOrDefault();
                    id = id + 1;
                    return id;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.ObtenerID()$Problemas al conectar en la DB");
            }
        }


        //Obtiene todas las ventas realizadas para una fecha determinada, se filtra solo por día mes y año, 
        //las ordenes devueltas tienen que tener el campo activa en FALSE, pues son ordenes que ya fueron cobradas

        public static List<Orden> ObtenerVentas(DateTime fecha)

        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT * FROM orden WHERE fecha=@fech AND estado=false;";
                    var respuesta = db.Query<Orden>(query, new { fech = fecha }).ToList();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.ObtenerVentas()$ No es posible conectarse a la DB");
            }
        }

        //filtrando por un rango de fechas. Importante en este método es que los objetos Orden NO tienen 
        //cargado el detalle de sus productos.

        public static List<Orden> ObtenerVentas(DateTime fechaMayor, DateTime fechaMenor)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    String query = "SELECT * FROM orden WHERE fecha >=@fechaMay AND fecha<=@fechaMen AND estado=false";
                    var respuesta = db.Query<Orden>(query, new { fechaMay=fechaMayor, fechaMen=fechaMenor }).ToList();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.ObtenerVentas()$ No es posible conectarse a la DB");
            }
        }
    }
}
