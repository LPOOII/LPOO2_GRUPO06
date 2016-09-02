using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase.Model
{
    public class ListarVentaModel
    {
        public static DataTable traer_cliente()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ListarVentaTraerCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable listar_ventas(DateTime menor, DateTime mayor, int cli)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ListarVentas";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@menor", menor);
            cmd.Parameters.AddWithValue("@mayor", mayor);
            cmd.Parameters.AddWithValue("@cli", cli);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
