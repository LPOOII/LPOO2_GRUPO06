using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using ClasesBase;

namespace ClasesBase
{
    public class ArticuloModel
    {
        //Este metodo list_Familia trae todo las familias de la tabla Familia.
        public static DataTable list_Familias()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Familia";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }//fin.list_Familia

        //Este metodo list_Familia trae todo las unidades de la tabla Unidad_Medida.
        public static DataTable list_Unidades()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Unidad_Medida";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }//fin.list_Unidades

        //Alta de Articulo
        /*El metodo insert_Articulo nos permite guardar un regsitro
          a la base de datos pasteleriaDB.*/
        public static void insert_Articulo(Articulo article) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Articulo(art_descrip, art_costo, 
                                                     art_margen_beneficio, art_precio, 
                                                     art_stock_min, art_stock_max, art_stock_reposicion,
                                                     art_stock_actual, art_maneja_stock, fam_id, um_id)
                                values(@descrip, @costo, @margBen, @precio, @stkmin, 
                                       @stkmax, @stkrep, @stkactual, @manjstk, @fam, @unMed)";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descrip", article.Art_Descrip);
            cmd.Parameters.AddWithValue("@costo", article.Art_Costo);
            cmd.Parameters.AddWithValue("@margBen", article.Art_Margen_Beneficio);
            cmd.Parameters.AddWithValue("@precio", article.Art_Precio);
            cmd.Parameters.AddWithValue("@stkmin", article.Art_Stock_Min);
            cmd.Parameters.AddWithValue("@stkmax", article.Art_Stock_Max);
            cmd.Parameters.AddWithValue("@stkrep", article.Art_Stock_Reposicion);
            cmd.Parameters.AddWithValue("@stkactual", article.Art_Stock_Actual);
            cmd.Parameters.AddWithValue("@manjstk", article.Art_Maneja_Stock);
            cmd.Parameters.AddWithValue("@fam", article.Fam_Id);
            cmd.Parameters.AddWithValue("@unMed", article.Um_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }//fin-insert_Articulo


        //Modificar de Articulo
        public static void update_Articulo(Articulo article)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

           cmd.CommandText = @"update Articulo
                                set art_descrip=@descrip, art_costo=@costo, art_margen_beneficio=@margBen,
                                    art_precio=@precio, art_stock_min=@stkmin, art_stock_max=@stkmax,
                                    art_stock_reposicion=@stkrep, art_stock_actual=@stkactual, 
                                    art_maneja_stock=@manjstk, fam_id=@fam, um_id=@unMed
                                where art_id=@artId";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@artId", article.Art_Id);
            cmd.Parameters.AddWithValue("@descrip", article.Art_Descrip);
            cmd.Parameters.AddWithValue("@costo", article.Art_Costo);
            cmd.Parameters.AddWithValue("@margBen", article.Art_Margen_Beneficio);
            cmd.Parameters.AddWithValue("@precio", article.Art_Precio);
            cmd.Parameters.AddWithValue("@stkmin", article.Art_Stock_Min);
            cmd.Parameters.AddWithValue("@stkmax", article.Art_Stock_Max);
            cmd.Parameters.AddWithValue("@stkrep", article.Art_Stock_Reposicion);
            cmd.Parameters.AddWithValue("@stkactual", article.Art_Stock_Actual);
            cmd.Parameters.AddWithValue("@manjstk", article.Art_Maneja_Stock);
            cmd.Parameters.AddWithValue("@fam", article.Fam_Id);
            cmd.Parameters.AddWithValue("@unMed", article.Um_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        //Eliminar de Articulo
        public static void delete_Articulo(Articulo article)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Articulo 
                                 where art_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            //parametros
            cmd.Parameters.AddWithValue("@id", article.Art_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        //Listar Grilla de Articulo
        /*Una vez guardado en el registro en la base de datos. Carga los datos en grilla.*/
        public static DataTable list_Articulos() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            //cmd.CommandText += " *";
            cmd.CommandText += " art_descrip as 'Descripcion', art_costo as 'Costo', ";
            cmd.CommandText += " art_margen_beneficio as 'Margen Beneficio', art_precio as 'Precio', ";
            cmd.CommandText += " art_stock_min as 'Stock Minimo', art_stock_max as 'Stock Maximo', ";
            cmd.CommandText += " art_stock_reposicion as 'Stock Reposicion', art_stock_actual as 'Stock Actual', ";
            cmd.CommandText += " art_maneja_stock as 'Maneja Stock',";
            cmd.CommandText += " Bf.fam_descrip as 'Familia',";
            cmd.CommandText += " Cum.um_descrip as 'Unidad de Medida',";
            cmd.CommandText += " art_id as 'ID Articulo' ";
            
            cmd.CommandText += " FROM Articulo as Aa";
            
            cmd.CommandText += " inner join Familia as Bf ON (Aa.fam_id = Bf.fam_id)";
            cmd.CommandText += " inner join Unidad_Medida as Cum ON (Cum.um_id = Aa.um_id)";
            

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }//fin-list_Articulos

        //Buscar Articulo

        //buscar por 2 campos
        //public static DataTable buscar_articulos(string descrip, int fam)
        public static DataTable buscar_articulos(string descrip, int fam)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            //cmd.CommandText += " *";
            cmd.CommandText += " art_descrip as 'Descripcion', art_costo as 'Costo', ";
            cmd.CommandText += " art_margen_beneficio as 'Margen Beneficio', art_precio as 'Precio', ";
            cmd.CommandText += " art_stock_min as 'Stock Minimo', art_stock_max as 'Stock Maximo', ";
            cmd.CommandText += " art_stock_reposicion as 'Stock Reposicion', art_stock_actual as 'Stock Actual', ";
            cmd.CommandText += " art_maneja_stock as 'Maneja Stock',";
            cmd.CommandText += " Bf.fam_descrip as 'Familia',";
            cmd.CommandText += " Cum.um_descrip as 'Unidad de Medida',";
            cmd.CommandText += " art_id as 'ID Articulo' ";

            cmd.CommandText += " FROM Articulo as Aa";

            cmd.CommandText += " inner join Familia as Bf ON (Aa.fam_id = Bf.fam_id)";
            cmd.CommandText += " inner join Unidad_Medida as Cum ON (Cum.um_id = Aa.um_id)";
            

            if (fam == 0)
            {
                cmd.CommandText += " WHERE";
                cmd.CommandText += " art_descrip LIKE @descrip ";
                cmd.CommandText += " OR";
                cmd.CommandText += " Aa.fam_id LIKE @fam ";
            }
            else
            {
                cmd.CommandText += " WHERE";
                cmd.CommandText += " art_descrip LIKE @descrip ";
                cmd.CommandText += " AND";
                cmd.CommandText += " Aa.fam_id LIKE @fam ";
            }

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descrip", "%" + descrip + "%");
            cmd.Parameters.AddWithValue("@fam", "%" + fam + "%");
            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //busca un articulo en la tabla de a cuerdo a su id.
        public static Articulo traer_id(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Articulo where art_id=@articulo_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@articulo_id", id);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Articulo oArticulo = null;
            if (reader.Read() == true)
            {
                oArticulo = new Articulo((int)reader["Art_Id"], (int)reader["Fam_Id"], (int)reader["Um_Id"], (decimal)reader["Art_Costo"], (decimal)reader["Art_Margen_Beneficio"], (decimal)reader["Art_Precio"], (decimal)reader["Art_Stock_Min"], (decimal)reader["Art_Stock_Reposicion"], (decimal)reader["Art_Stock_Actual"], (bool)reader["Art_Maneja_Stock"], (string)reader["Art_Descrip"], (decimal)reader["Art_Stock_Max"]);
            }
            cnn.Close();
            return oArticulo;
        }


        public static DataTable traer_articulo_orden_nombre()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ArticuloOrdenCodigo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public static DataTable traer_articulo_orden_descripcion()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ArticuloOrdenDescripcion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }//fin-ArticuloModel
}
