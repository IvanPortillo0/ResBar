using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ResBarLib
{
    public static class ManejadorProductos
    {
        //Devuelve una colección de objetos productos que se corresponden con el Identificador de categoría que se pasó como parámetro.
        public static List<producto> ObtenerxCategoria(int idCateg)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    
                    string query = "SELECT * FROM producto AS a INNER JOIN categoria AS b ON a.idCategoria = b.idCategoria WHERE a.idCategoria =(@idCateg) ORDER BY idProducto;";
                    var respuesta = db.Query<producto, Categoria, producto>(query, (prod, cat) => {
                        //sirve para que el funcione la variable Categorias de la tabla producto
                        prod.categoria = cat;
                        return prod;
                    }, new { idCateg }, splitOn: "idCategoria").Distinct().ToList();

                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.ObtenerxCategoria()$ No es posible conectarse a la DB");
            }

        }

        //Buscara en la base de datos todos los productos cuyo Id o nombre coincida con el criterio de búsqueda, luego devuelve la colección de productos, sin devolver productos duplicados
        public static List<producto> Buscar(string nombreProd)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT * FROM producto AS a INNER JOIN categoria AS b ON a.idCategoria = b.idCategoria WHERE a.nombre LIKE ('%@nombreProd%');";
                    var respuesta = db.Query<producto, Categoria, producto>(query, (prod, cat) => {
                        //sirve para que el funcione la variable Categorias de la tabla producto
                        prod.categoria = cat;
                        return prod;
                    },new { nombreProd }, splitOn: "idCategoria").Distinct().ToList();
                    return respuesta;
                }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Buscar()$ No es posible conectarse a la DB");
            }
        }

        //Agrega el objeto "producto" a la base de datos
        public static int Insertar(producto prod)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    MessageBox.Show("001");
                    string query;
                    string query1 = "SELECT COUNT(*) FROM producto WHERE idProducto=@p1;";
                    var respuesta1 = db.Query<int>(query1, new { p1=prod.idProducto }).SingleOrDefault();

                    MessageBox.Show("002");
                    string query2 = "SELECT COUNT(*) FROM categoria WHERE idProducto=@p2;";
                    var respuesta2 = db.Query<int>(query2, new { p2=prod.categoria.idCategoria }).SingleOrDefault();


                    MessageBox.Show("1.1-" + respuesta +"     1.2-"+ respuesta2);

                    if (respuesta1 == 0 && respuesta2==1)
                    {
                        query = "INSERT INTO producto (idProducto, nombre, precio, idCategoria, area) VALUES('@prod.idProducto', '@prod.nombre', '@prod.precio', '@prod.categoria.idCategoria', '@prod.area');";
                        respuesta = db.Execute(query, new { prod.idProducto, prod.nombre, prod.precio, prod.categoria.idCategoria, prod.area });
                        MessageBox.Show("1-   " + respuesta);
                    }
                    else
                    {
                        MessageBox.Show("ManejadorProductos.Insertar()$No se puede realizar la operación de Insertar");
                    }
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Insertar()$Problemas al conectar en la DB");
            }
        }

        //Si el objeto “producto” se desea modificar este actualizara en la base de datos cuando este ya este modificado, no se modificara el ID del producto solo sus otros campos
        public static int Actualizar(producto prod)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "UPDATE producto SET nombre='" + prod.nombre + "', precio='" + prod.precio + "', idCategoria='" + prod.categoria.idCategoria + "', area='" + prod.area + "' WHERE idProducto= '" + prod.idProducto + "';";
                    respuesta = db.Execute(query, prod);
                }

                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorProductos.Actualizar()$No se puede realizar la operación de Actualizar");
                }
                else { return respuesta; }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Actualizar()$Problemas al conectar en la DB");
            }
        }

        //Elimina en la base de datos el "producto" que recibe como parametro
        public static int Eliminar(producto prod)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    /*string query = "DELETE FROM producto WHERE idProducto='" + prod.idProducto + "';";
                    respuesta = db.Execute(query, prod);
                }

                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorProductos.Eliminar()$No se puede realizar la operación de Eliminar");
                }
                else { return respuesta; }*/
                    string query;

                    //Sirve para comprobar si hay registros en la tabla detalleorden que esten relacionados con el registro de producto que se desea borrar
                    query = "SELECT COUNT(*) FROM detalleorden WHERE idProducto=" + prod.idProducto + ";";
                    respuesta = db.Query<int>(query).SingleOrDefault();


                    if (respuesta == 0)
                    {
                        query = "DELETE FROM producto WHERE idProducto='" + prod.idProducto + "';";
                        respuesta = db.Execute(query, prod);

                        if (respuesta == 0) { MessageBox.Show("No Existe registro de id=" + prod.idProducto); ; }
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar debido a que tiene " + respuesta + " registros relacionados en la tabla producto de la bd");
                    }
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Eliminar()$Problemas al conectar en la DB");
            }
        }

        //Realiza una petición a la base de datos y devuelve un objeto producto que cuyo IDProducto coincide con el valor del parámetro
        public static producto Obtener(int idProducto)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT* FROM producto AS a INNER JOIN categoria AS b ON a.idCategoria = b.idCategoria WHERE idProducto = '" + idProducto + "'; ";
                    var respuesta = db.Query<producto, Categoria, producto>(query, (prod, cat) => {
                        //sirve para que el funcione la variable Categorias de la tabla producto
                        prod.categoria = cat;
                        return prod;
                    }, splitOn: "idCategoria").Distinct().SingleOrDefault();
                    return respuesta;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.Obtener()$Problemas al conectar en la DB");
            }
        }

        //Obtiene el identificador de producto, va la base de datos a obtener el ultimo ID de producto y le suma uno a dicho valor
        public static int ObtenerID()
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT MAX(idProducto) FROM producto;";
                    var id = db.Query<int>(query).SingleOrDefault();
                    id = id + 1;
                    return id;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorProductos.ObtenerID()$Problemas al conectar en la DB");
            }
        }

    }
}
