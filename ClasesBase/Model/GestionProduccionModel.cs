using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase.Model
{
    public class GestionProduccionModel
    {
       

      
        //devuelve una lista de productos
        public static DataTable traer_productos_terminados()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ProduccionProducto";
            cmd.CommandType = CommandType.StoredProcedure;          
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //devuelve una lista de items de materia prima de acuerdo a un parametro        
        public static DataTable traer_materia_prima(int idpro)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "ProduccionTraerItemsMateriaPrima";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@idpro", idpro);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //devuelve una lista de items de otros costos de acuerdo a un parametro   
        public static DataTable traer_otros_costos(int idpro)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "ProduccionTraerItemsOtrosCostos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@idpro", idpro);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Guarda un orden de produccion
        public static void insertar_produccion(Orden_Produccion oProd)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
           
            cmd.CommandText = "ProduccionAgregar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@fec", oProd.Op_Fecha);
            cmd.Parameters.AddWithValue("@pro", oProd.Pro_Id);
            cmd.Parameters.AddWithValue("@cant", oProd.Cantidad);
            cmd.Parameters.AddWithValue("@mp", oProd.Total_Materia_Prima);
            cmd.Parameters.AddWithValue("@oc", oProd.Total_Otros_Costos);
            cmd.Parameters.AddWithValue("@cf", oProd.Costo_Final);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        
        // obtiene el ultimo id generado de la tabla Orden_Produccion 
        public static int getIdenty()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();           
            
            cmd.CommandText = "ProduccionObtenerOpId";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cnn.Open();
            int id = (int)cmd.ExecuteScalar();
            return id;
        }

        //Guarda Op_Items_Materia_Prima
        public static void insertar_items_materia_prima(OP_Items_Materia_Prima oMatP)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
         
            cmd.CommandText = "ProduccionAgregarOpItemsMateriaPrima";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@op", oMatP.Op_Id);
            cmd.Parameters.AddWithValue("@art", oMatP.Art_Id);
            cmd.Parameters.AddWithValue("@cos", oMatP.Costo);
            cmd.Parameters.AddWithValue("@cant", oMatP.Cantidad);
            cmd.Parameters.AddWithValue("@imp", oMatP.Importe);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Guarda OP_Items_Otros_Costos
        public static void insertar_items_otros_costos(OP_Items_Otros_Costos otc)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
       
            cmd.CommandText = "ProduccionAgregarOpItemsOtrosCostos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@op", otc.Op_Id);
            cmd.Parameters.AddWithValue("@oc", otc.Oc_Id);
            cmd.Parameters.AddWithValue("@cos", otc.Costo);
            cmd.Parameters.AddWithValue("@cant", otc.Cantidad);
            cmd.Parameters.AddWithValue("@imp", otc.Importe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //devuelve un id de un determinado articulo
        public static int Obtener_art_id(int prod)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
          
            cmd.CommandText = "ProduccionObtenerArtId";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.Parameters.AddWithValue("@prodID", prod);
            int id = (int)cmd.ExecuteScalar();
            return id;
        }


        //trae un articulo, segun un determinado art_id q vienen por parametro
        public static Articulo traer_producto_terminado_obj(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
          
            cmd.CommandText = "ProducionTraerProductoTerminadoObj";
            cmd.CommandType = CommandType.StoredProcedure;
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

        //actualiza un producto(de articulo) segun un objeto q viene como parametro a modificar
        public static void update_producto_terminado(Articulo article)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
     
            cmd.CommandText = "ProduccionActualizarProductoTerminado";
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
            cmd.Parameters.AddWithValue("@fam", article.Fam_Id);
            cmd.Parameters.AddWithValue("@unMed", article.Um_Id);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //trae una lista de OP_Items_Materia_Prima de acuerdo a un parametro
        public static DataTable traer_op_materia_prima(int op)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
       
            cmd.CommandText = "ProduccionTraerOpMateriaPrima";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@op", op);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
