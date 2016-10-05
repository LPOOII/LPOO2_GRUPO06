using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase.Model
{
    public class GestionProductoModel
    {
        //trae una lista de productos terminados
        public static DataTable traer_articulos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
           
            cmd.CommandText = "ProductoTraerProductosTerminados";
            cmd.CommandType = CommandType.StoredProcedure;            
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //trae una lista de materias primas
        public static DataTable traer_articulos_todo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
        
            cmd.CommandText = "ProductoTraerMateriasPrimas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //trae una lista de otros costos 
        public static DataTable traer_otroscostos_todo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
          
            cmd.CommandText = "ProductoTraerOtrosCostos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //traer el ultimo id de producto
        public static int getIdenty()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
          
            cmd.CommandText = "ProductoTraerId";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cnn.Open();
            int id = (int)cmd.ExecuteScalar();
            return id;
        }
        //devuelve un cadena de conexion
        public static SqlConnection cn()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            return cnn;
        }

        //devuelve un objeto articulo de manera especifica
        public static Articulo traer_articulo_id(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
          
            cmd.CommandText = "ProductoTraerObjetArticuloId";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@articulo_id", id);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Articulo oArticulo = null;
            if (reader.Read() == true)
            {
                oArticulo = new Articulo((int)reader["Art_Id"], (Familia)reader["Fam_Id"], (Unidad_Medida)reader["Um_Id"], (decimal)reader["Art_Costo"], (decimal)reader["Art_Margen_Beneficio"], (decimal)reader["Art_Precio"], (decimal)reader["Art_Stock_Min"], (decimal)reader["Art_Stock_Reposicion"], (decimal)reader["Art_Stock_Actual"], (bool)reader["Art_Maneja_Stock"], (string)reader["Art_Descrip"], (decimal)reader["Art_Stock_Max"]);
            }
            cnn.Close();
            return oArticulo;
        }

        //actualiza un producto de manera especifica
        public static void update_producto(Articulo article)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
    
            cmd.CommandText = "ProductoActualizarProductoTerminado";
            cmd.CommandType = CommandType.StoredProcedure;
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
            //comentado para trabajar en el tp3
            //cmd.Parameters.AddWithValue("@fam", article.Fam_Id);
            //cmd.Parameters.AddWithValue("@unMed", article.Um_Id);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();       
        }
        //carga un producto en la bd
        public static void insertar_producto(Producto product)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
        
            cmd.CommandText = "ProductoAgregar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@prima", product.Total_Materia_Prima);
            cmd.Parameters.AddWithValue("@costo", product.Total_Otros_Costos);
            cmd.Parameters.AddWithValue("@final", product.Costo_Final);
            cmd.Parameters.AddWithValue("@id", product.Art_Id);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
