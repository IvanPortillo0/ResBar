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

        public static List<Orden> ObtenerActivas()
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
                throw new ErrorAplicationException("ManejadorOrdenes.ObtenerActivas()$ No es posible conectarse a la DB.");
            }
        }

        //Recibe un entero que indica el ID de la orden y luego devuelve el objeto orden completo que corresponde
        public static Orden Obtener(int idOrden)
        {
            int numMsj = 0;
            String msjExepcion = "ManejadorOrdenes.Obtener()$ No es posible conectarse a la DB.";
            Orden objOrden = new Orden();
            try
            {
                DetalleOrden deto = new DetalleOrden();
                List<DetalleOrden> lstDetalle = new List<DetalleOrden>();

                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    if (idOrden > 0)
                    {
                        string query = "SELECT * FROM orden WHERE idOrden=@idOrde;";
                        objOrden = db.Query<Orden>(query, new { idOrde = idOrden }).SingleOrDefault();

                        query = "SELECT a.idProducto, a.cantidad, b.idProducto, b.nombre, b.precio, b.idCategoria, b.area, c.idCategoria, c.nombre FROM detalleorden AS a " +
                            "INNER JOIN producto AS b ON a.idProducto = b.idProducto INNER JOIN categoria AS c ON b.idCategoria = c.idCategoria WHERE a.idOrden = @idOrde;";
                        lstDetalle = db.Query<DetalleOrden, producto, Categoria, DetalleOrden>(query, (detOrd, prod, cat) => {
                            prod.categoria = cat;
                            detOrd.producto = prod;
                            return detOrd;
                        }, new { idOrde = idOrden }, splitOn: "idProducto,idCategoria").Distinct().ToList();

                        objOrden.detalle = new List<DetalleOrden>();
                        for (int i = 0; i < lstDetalle.Count(); i++)
                        {
                            objOrden.detalle.Add(lstDetalle.ElementAt(i));
                        }
                    }
                    else
                    {
                        numMsj = 1; //"ManejadorProductos.Obtener()$id no existe"
                        throw new ErrorAplicationException();
                    }
                }

                return objOrden;
            }
            catch
            {
                if (numMsj == 1)
                {
                    msjExepcion = "ManejadorProductos.Obtener()$id no existe.";
                }
                throw new ErrorAplicationException(msjExepcion);
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
                    
                    string query = "SELECT * FROM orden WHERE (mesero LIKE @criteri) OR (mesa LIKE @criteri) OR (cliente LIKE @criteri) OR (comentario LIKE @criteri);";
                    var respuesta = db.Query<Orden>(query, new { criteri= "%" + criterio + "%" }).ToList();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.BuscarActivas()$ No es posible conectarse a la DB.");
            }
        }

        //Inserta el objeto orden en la base de datos, inserta una tupla en la tabla Orden y una o varias tuplas en la tabla 
        //Detalle Orden, además verifica que la orden tenga al menos uno de los campos con valor: mesero, mesa o cliente, no 
        //permite insertar ordenes con un total de cero o negativo, o que NO posean ningún producto en su detalle
        public static int Insertar(Orden orden)
        {
            int numMsj = 0;
            String msjExepcion = "ManejadorOrdenes.Insertar()$ No es posible conectarse a la DB.";
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    //los siguientes 3 if son para saber si: -mesero, mesa y cliente tiene al menos uno de ello dato -total mayor a 0 -tenga producto
                    if (!orden.mesero.Equals("") || !orden.mesa.Equals("") || !orden.cliente.Equals(""))
                    {
                        if (orden.detalle.Count() > 0)
                        {
                            if (orden.total > 0)
                            {
                                String query;
                                query = "SELECT COUNT(*) FROM orden WHERE idOrden=@idOrde;";
                                var respuesta1 = db.Query<int>(query, new { idOrde = orden.idOrden }).SingleOrDefault();

                                if (respuesta1 == 0)
                                {
                                    query = "INSERT INTO orden (idOrden, mesero, mesa, cliente, fecha, comentario, total, activa) VALUES(@idOrde, @meser, @mesaa, @client, @fech, @comentari, @tota, @activ);";
                                    respuesta = db.Execute(query, new { idOrde = orden.idOrden, meser = orden.mesero, mesaa = orden.mesa, client = orden.cliente, fech = orden.fecha, comentari = orden.comentario, tota = orden.total, activ = orden.activa });
                                    for (int i = 0; i < orden.detalle.Count; i++)
                                    {
                                        query = "INSERT INTO detalleorden (idOrden, idProducto, cantidad) VALUES(@idOrde, @idProduct, @cantida);";
                                        respuesta = db.Execute(query, new { idOrde = orden.idOrden, idProduct = orden.detalle.ElementAt(i).producto.idProducto, cantida = orden.detalle.ElementAt(i).cantidad });
                                    }
                                }
                                else
                                {
                                    numMsj = 4; //"ManejadorOrdenes.Insertar()$No se puede realizar la operación Insertar, idOrden ingresado ya existe"
                                    throw new ErrorAplicationException();
                                }
                            }
                            else
                            {
                                numMsj = 3; //"ManejadorOrdenes.Insertar()$Su total es menor o igual a 0, no se realizo la operación insertar"
                                throw new ErrorAplicationException();
                            }
                        }
                        else
                        {
                            numMsj = 2; //"ManejadorOrdenes.Insertar()$No tiene productos para insertar en la tabla detalleorden"
                            throw new ErrorAplicationException();
                        }
                    }
                    else
                    {
                        numMsj = 1; //"ManejadorOrdenes.Insertar()$No inserto datos de mesero, mesa y cliente, necesita al menos uno de estos campos lleno"
                        throw new ErrorAplicationException();
                    }

                    return respuesta;
                }
            }
            catch
            {
                switch (numMsj)
                {
                    case 1:
                        msjExepcion = "ManejadorOrdenes.Insertar()$No inserto datos de mesero, mesa y cliente, necesita al menos uno de estos campos lleno.";
                        break;
                    case 2:
                        msjExepcion = "ManejadorOrdenes.Insertar()$No tiene productos para insertar en la tabla detalleorden.";
                        break;
                    case 3:
                        msjExepcion = "ManejadorOrdenes.Insertar()$Su total es menor o igual a 0, no se realizo la operación insertar.";
                        break;
                    case 4:
                        msjExepcion = "ManejadorOrdenes.Insertar()$No se puede realizar la operación Insertar, idOrden ingresado ya existe.";
                        break;
                }
                throw new ErrorAplicationException(msjExepcion);
            }
        }

        //Toma un objeto orden que ya existe en la tabla Orden de la base de datos, luego verifica que el objeto 
        //orden tenga productos, que su total sea mayor que cero, en la base de datos hace update de la tabla orden, y para 
        //la tabla Detalle Orden, lo que se hace es que se eliminan las tuplas de dicha orden y luego se insertan de nuevo
        public static int Actualizar(Orden orden)
        {
            int numMsj = 0;
            String msjExepcion = "ManejadorOrdenes.Actualizar()$ No es posible conectarse a la DB.";
            int respuesta = 0, respuesta1 = 0, respuesta2 = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    var query = "SELECT COUNT(*) FROM orden WHERE idOrden=@idOrde;";
                    respuesta1 = db.Query<int>(query, new { idOrde = orden.idOrden }).SingleOrDefault();

                    if (respuesta1 == 1)
                    {
                        if (orden.detalle.Count() > 0)
                        {
                            if (orden.total > 0)
                            {
                                query = "UPDATE orden SET mesero=@meser, mesa=@mesaa, cliente=@client, fecha=@fech, comentario=@comentari, total=@tota, activa=@activ WHERE idOrden=@idOrde;";
                                respuesta = db.Execute(query, new { idOrde = orden.idOrden, meser = orden.mesero, mesaa = orden.mesa, client = orden.cliente, fech = orden.fecha, comentari = orden.comentario, tota = orden.total, activ = orden.activa });

                                query = "DELETE FROM detalleorden WHERE idOrden=@idOrde;";
                                respuesta2 = db.Execute(query, new { idOrde = orden.idOrden });

                                for (int i = 0; i < orden.detalle.Count; i++)
                                {
                                    query = "INSERT INTO detalleorden (idOrden, idProducto, cantidad) VALUES(@idOrde, @idProduct, @cantida);";
                                    respuesta2 = db.Execute(query, new { idOrde = orden.idOrden, idProduct = orden.detalle.ElementAt(i).producto.idProducto, cantida = orden.detalle.ElementAt(i).cantidad });
                                }

                            }
                            else
                            {
                                numMsj = 3; //"ManejadorOrdenes.Actualizar()$Su total es menor o igual a cero, no se realizo la operación actualizar"
                                throw new ErrorAplicationException();
                            }
                        }
                        else
                        {
                            numMsj = 2; //"ManejadorOrdenes.Actualizar()$No tiene productos en el objeto orden para actualizar en la tabla detalleorden"
                            throw new ErrorAplicationException();
                        }
                    }
                    else
                    {
                        numMsj = 1; //"ManejadorOrdenes.Actualizar()$No Existe registro de id=" + orden.idOrden
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
                        msjExepcion = "ManejadorOrdenes.Actualizar()$No Existe registro de id=" + orden.idOrden;
                        break;
                    case 2:
                        msjExepcion = "ManejadorOrdenes.Actualizar()$No tiene productos en el objeto orden para actualizar en la tabla detalleorden.";
                        break;
                    case 3:
                        msjExepcion = "ManejadorOrdenes.Actualizar()$Su total es menor o igual a cero, no se realizo la operación actualizar.";
                        break;
                }
                throw new ErrorAplicationException(msjExepcion);
            }
        }

        //Elimina dicha orden de la base de datos, eliminando sus detalles también
        public static int Eliminar(Orden orden)
        {
            int numMsj = 0;
            String msjExepcion = "ManejadorOrdenes.Eliminar()$Problemas al conectar en la DB.";
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
                    if (respuesta == 0)
                    {
                        numMsj = 1; //"ManejadorOrdenes.Eliminar()$No Existe registro de id=" + orden.idOrden
                        throw new ErrorAplicationException();
                    }
                }

                return respuesta;
            }
            catch
            {
                if (numMsj == 1)
                {
                    msjExepcion = "ManejadorOrdenes.Eliminar()$No Existe registro de id=" + orden.idOrden;
                }
                throw new ErrorAplicationException(msjExepcion);
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
                throw new ErrorAplicationException("ManejadorOrdenes.ObtenerID()$Problemas al conectar en la DB.");
            }
        }


        //Obtiene todas las ventas realizadas para una fecha determinada, se filtra solo por día mes y año, 
        //las ordenes devueltas tienen que tener el campo activa en FALSE, pues son ordenes que ya fueron cobradas

        public static List<Orden> ObtenerVentas(DateTime fecha)
        {
            //sirve para configurar fecha en 2 variables,una en 00:00:00 y otra en 23:59:59, asi la consulta se hace de un mismo dia (consulta no se realiza si poner la hora)
            TimeSpan TShora = new TimeSpan(0, 0, 0);
            DateTime fechaMenor = fecha.Date + TShora;
            TShora = new TimeSpan(23, 59, 59);
            DateTime fechaMayor = fecha.Date + TShora;

            //DateTime de c# muestra formato de hora en A.M. y P.M., transforma a formato de 24 Horas
            String textMenor = fechaMenor.ToString("yyyy/MM/dd HH:mm:ss");
            String textMayor = fechaMayor.ToString("yyyy/MM/dd HH:mm:ss");

            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    String query = "SELECT * FROM orden WHERE fecha BETWEEN @fechaMen AND @fechaMay AND activa=false;";
                    var respuesta = db.Query<Orden>(query, new { fechaMen = textMenor, fechaMay = textMayor }).ToList();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.ObtenerVentas()$ No es posible conectarse a la DB.");
            }
        }

        //filtrando por un rango de fechas. Importante en este método es que los objetos Orden NO tienen 
        //cargado el detalle de sus productos.
        public static List<Orden> ObtenerVentas(DateTime fechaMenor, DateTime fechaMayor)
        {
            //Se modifican las horas del DateTime para que en la consulta abarque todo el dia de ambas fechas
            TimeSpan TShora = new TimeSpan(0, 0, 0);
            fechaMenor = fechaMenor.Date + TShora;
            TShora = new TimeSpan(23, 59, 59);
            fechaMayor = fechaMayor.Date + TShora;

            //DateTime de c# muestra formato de hora en A.M. y P.M., transforma a formato de 24 Horas
            String textMenor = fechaMenor.ToString("yyyy/MM/dd HH:mm:ss");
            String textMayor = fechaMayor.ToString("yyyy/MM/dd HH:mm:ss");
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    String query = "SELECT * FROM orden WHERE fecha BETWEEN @fechaMen AND @fechaMay AND activa=false;";
                    var respuesta = db.Query<Orden>(query, new { fechaMen=textMenor, fechaMay=textMayor }).ToList();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorOrdenes.ObtenerVentas()$ No es posible conectarse a la DB.");
            }
        }
    }
}
