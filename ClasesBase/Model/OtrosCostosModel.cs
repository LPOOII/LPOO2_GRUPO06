using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//importamos librerias
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.Model
{
    public class OtrosCostosModel
    {
        //Listar Costo
        public static DataTable list_costos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "OtroCosto_list";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //Guardar Costo
        public static void insert_Costo(Otros_Costos costo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"OtroCosto_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descrip", costo.Oc_descrip);
            cmd.Parameters.AddWithValue("@um", costo.Um_id);
            cmd.Parameters.AddWithValue("@costo", costo.Oc_costo);
            cmd.Parameters.AddWithValue("@obs", costo.Oc_observaciones);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Actualizar Costo
        public static void update_Costo(Otros_Costos costo, int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"OtroCosto_update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@descrip", costo.Oc_descrip);
            cmd.Parameters.AddWithValue("@um", costo.Um_id);
            cmd.Parameters.AddWithValue("@costo", costo.Oc_costo);
            cmd.Parameters.AddWithValue("@obs", costo.Oc_observaciones);;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Eliminar Costo
        public static void dalete_Costo(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"OtroCosto_dalete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Buscar por descripcion o id unidad medida
        public static DataTable search_Otro_Costo(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"OtroCosto_search";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //Este metodo list_Familia trae todo las unidades de la tabla Unidad_Medida.
        public static DataTable list_Unidades()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "OtroCosto_UnidadM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }//fin.list_Unidades
    }
}
