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
    public static class ManejadorCategorias
    {

        //Obtener tendrá un valor verdadero que cargaran los subproductos, y si su valor es falso no se cargaran los subproductos
        public static List<Categoria> Obtener(Boolean ConSinProducto)
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
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
                        var resp = db.Query<Categoria>(query).ToList();
                        return resp;
                    }
                }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorCategorias.Obtener()$ No es posible conectarse a la DB");
            }
        }

        //Agrega el objeto "categoría" a la base de datos
        public static int Insertar(Categoria categoria)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    
                    string query = "INSERT INTO categoria (idCategoria, nombre) VALUES('" + categoria.idCategoria + "', '" + categoria.nombre + "');";
                    respuesta = db.Execute(query, categoria);
                    
                }

                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorCategorias.Insertar()$No se puede realizar la operación de Insertar"); }
                else{ return respuesta; }

            }
            catch
            {
                throw new ErrorAplicationException("ManejadorCategorias.Insertar()$Problemas al conectar en la DB");
            }
        }

        //Si se desea modificar el objeto “categoria” este actualizara en la base de datos cuando este ya este modoficado, no se modificara el IDCategoria
        public static int Actualizar(Categoria categoria)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "UPDATE categoria SET nombre='" + categoria.nombre + "' WHERE idCategoria= '" + categoria.idCategoria + "';";
                    respuesta = db.Execute(query, categoria);
                }

                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorCategorias.Actualizar()$No se puede realizar la operación de Actualizar"); }
                else { return respuesta; }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorCategorias.Actualizar()$No es posible conectarse a la DB.");
            }
        }

        //Elimina en la base de datos el "producto" que recibe como parametro
        public static int Eliminar(Categoria categoria)
        {
            int respuesta = 0;
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    //asi estaba
                    /*string query = "DELETE FROM categoria WHERE idCategoria='" + categoria.idCategoria + "';";
                    respuesta = db.Execute(query, categoria);
                }

                if (respuesta < 0)
                {
                    throw new ErrorAplicationException("ManejadorCategorias.Eliminar()$No se puede realizar la operacion de Eliminar."); }
                else { return respuesta; }*/
                    //empieza modificacion
                    string query;

                    //Sirve para comprobar si hay registros en la tabla productos que esten relacionados con el registro de categoria que se desea borrar
                    query = "SELECT COUNT(*) from producto where idCategoria=" + categoria.idCategoria + ";";
                    respuesta = db.Query<int>(query).SingleOrDefault();
                    

                    if (respuesta==0)
                    {
                        query = "DELETE FROM categoria WHERE idCategoria='" + categoria.idCategoria + "';";
                        respuesta = db.Execute(query, categoria);

                        if (respuesta == 0) { MessageBox.Show("No Existe registro de id=" + categoria.idCategoria); respuesta = -1; }
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar debido a que tiene " + respuesta + " registros relacionados en la tabla producto de la bd");
                        respuesta = -1;
                    }
                    return respuesta;
                }
                //termina modificación
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorCategorias.Eliminar()$Problemas con la conexion a la DB");
            }
        }

        //Obtiene el identificador de categoria, va la base de datos a obtener el ultimo ID de categoria y le suma uno a dicho valor.
        public static int ObtenerID()
        {
            try
            {
                using (IDbConnection db = new MySqlConnection(DbConnection.Cadena()))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "SELECT MAX(idCategoria) FROM categoria;";
                    var id = db.Query<int>(query).SingleOrDefault();
                    id = id + 1;
                    return id;
                }
            }
            catch
            {
                throw new ErrorAplicationException("ManejadorCategorias.ObtenerID()$Problemas con la conexion a la DB.");
            }
        }
    }
}
