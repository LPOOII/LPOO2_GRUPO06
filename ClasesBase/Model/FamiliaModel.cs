using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase.Model
{
    public class FamiliaModel
    {
        public static DataTable traer_familia()
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
        }

        public static void insertar_familia(Familia fam)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "FamiliaAgregar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@des", fam.Fam_Descrip);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void delete_familia(Familia fam)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "FamiliaEliminar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;            
            cmd.Parameters.AddWithValue("@id", fam.Fam_Id);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void update_familia(Familia fam)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "FamiliaModificar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", fam.Fam_Id);
            cmd.Parameters.AddWithValue("@des", fam.Fam_Descrip);
    
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
