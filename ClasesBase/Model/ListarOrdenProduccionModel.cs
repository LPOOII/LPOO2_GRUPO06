using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase.Model
{
    public class ListarOrdenProduccionModel
    {
        public static DataTable orden_produccion_fecha(DateTime menor, DateTime mayor)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarOrdenProduccionFecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@menor", menor);
            cmd.Parameters.AddWithValue("@mayor", mayor);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public static DataTable traer_orden_produccion()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarOrdenProduccion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
