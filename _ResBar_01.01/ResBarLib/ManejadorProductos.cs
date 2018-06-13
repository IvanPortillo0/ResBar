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
                    
                    string query = "SELECT * FROM producto AS a INNER JOIN categoria AS b ON a.idCategoria = b.idCategoria WHERE a.idCategoria =@idCateg ORDER BY idProducto;";
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

                    string query = "SELECT * FROM producto AS a INNER JOIN categoria AS b ON a.idCategoria = b.idCategoria WHERE a.nombre LIKE @nombrePro;";
                    var respuesta = db.Query<producto, Categoria, producto>(query, (prod, cat) => {
                        //sirve para que el funcione la variable Categorias de la tabla producto
                        prod.categoria = cat;
                        return prod;
                    }, new { nombrePro = "%" + nombreProd + "%" }, splitOn: "idCategoria").Distinct().ToList();
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

                    if (prod.idProducto > 0 && (!prod.nombre.Equals("")) && prod.precio > 0 && prod.categoria.idCategoria > 0 && (prod.area == 'c' || prod.area == 'b'))
                    {

                        string query;
                        //verifica si existe el producto y si la categoria que se ingresará es de las que existe en la tabla catgoria
                        query = "SELECT COUNT(*) FROM producto WHERE idProducto=@idProduct;";
                        var respuesta1 = db.Query<int>(query, new { idProduct = prod.idProducto }).SingleOrDefault();

                        query = "SELECT COUNT(*) FROM categoria WHERE idCategoria=@idCategori;";
                        var respuesta2 = db.Query<int>(query, new { idCategori = prod.categoria.idCategoria }).SingleOrDefault();

                        if (respuesta1 == 0 && respuesta2 == 1)
                        {
                            query = "INSERT INTO producto (idProducto, nombre, precio, idCategoria, area) VALUES(@idProduct, @nombr, @preci, @idCategori, @are);";
                            respuesta = db.Execute(query, param: new { idProduct = prod.idProducto, nombr = prod.nombre, preci = prod.precio, idCategori = prod.categoria.idCategoria, are = prod.area });
                        }
                        else
                        {
                            MessageBox.Show("ManejadorProductos.Insertar()$No se puede realizar la operación de Insertar, idCategoria ingresado no existe o idProducto ingresado ya existe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ManejadorProductos.Insertar()$Campo o campos invalidos");
                    }
                }

                return respuesta;
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

                    if (prod.idProducto > 0 && (!prod.nombre.Equals("")) && prod.precio > 0 && prod.categoria.idCategoria > 0 && (prod.area == 'c' || prod.area == 'b'))
                    {

                        // verifica si el idCategoria a ingresar exista en la tabla categoria
                        var query = "SELECT COUNT(*) FROM categoria WHERE idCategoria=@p2;";
                        var respuesta1 = db.Query<int>(query, new { p2 = prod.categoria.idCategoria }).SingleOrDefault();

                        if (respuesta1 == 1)
                        {
                            query = "UPDATE producto SET nombre=@nombr, precio=@preci, idCategoria=@idCategori, area=@are WHERE idProducto= @idProduct;";
                            respuesta = db.Execute(query, param: new { idProduct = prod.idProducto, nombr = prod.nombre, preci = prod.precio, idCategori = prod.categoria.idCategoria, are = prod.area });
                            if (respuesta == 0) { MessageBox.Show("ManejadorProductos.Actualizar()$No Existe registro de id=" + prod.idProducto); }
                        }
                        else
                        {
                            MessageBox.Show("ManejadorProductos.Actualizar()$No se puede realizar la operación de Actualizar, la categoria ingresada no existe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ManejadorProductos.Actualizar()$Campo o campos invalidos");
                    }
                }

                return respuesta;
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

                    string query;
                    //Sirve para comprobar si hay registros en la tabla detalleorden que esten relacionados con el registro de producto que se desea borrar
                    query = "SELECT COUNT(*) FROM detalleorden WHERE idProducto=@idProduct;";
                    respuesta = db.Query<int>(query, new { idProduct=prod.idProducto }).SingleOrDefault();


                    if (respuesta == 0)
                    {
                        query = "DELETE FROM producto WHERE idProducto=@idProduct;";
                        respuesta = db.Execute(query, new { idProduct = prod.idProducto });

                        if (respuesta == 0) { MessageBox.Show("ManejadorProductos.Eliminar()$No Existe registro de id=" + prod.idProducto); }
                    }
                    else
                    {
                        MessageBox.Show("ManejadorProductos.Eliminar()$No se puede eliminar debido a que tiene " + respuesta + " registros relacionados en la tabla detalleorden de la bd");
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
            producto respuesta = new producto();
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    if (idProducto > 0)
                    {
                        string query = "SELECT * FROM producto AS a INNER JOIN categoria AS b ON a.idCategoria = b.idCategoria WHERE idProducto = @idpro;";
                        respuesta = db.Query<producto, Categoria, producto>(query, (prod, cat) => {
                            //sirve para que el funcione la variable Categorias de la tabla producto
                            prod.categoria = cat;
                            return prod;
                        }, new { idpro = idProducto }, splitOn: "idCategoria").Distinct().SingleOrDefault();
                    }
                    else
                    {
                        MessageBox.Show("ManejadorProductos.Obtener()$id no existe");
                    }
                }
                return respuesta;
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
