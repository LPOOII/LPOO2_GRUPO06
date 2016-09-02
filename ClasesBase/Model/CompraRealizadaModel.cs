using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClasesBase;

namespace ClasesBase
{
    public class CompraRealizadaModel
    {
        public static DataTable listaComprasRealizadas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT";
            cmd.CommandText += " oc_id as 'Orden Compra', ";
            cmd.CommandText += " oc_fecha as 'Fecha', ";
            cmd.CommandText += " pagada as 'Estado', ";
            cmd.CommandText += " prov_nombre as 'Proveedor'";
            cmd.CommandText += " FROM Orden_Compra as OC";
            cmd.CommandText += " LEFT JOIN Proveedor as P ON (P.prov_id=OC.prov_id)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


       

        public static DataTable buscarFecha(DateTime menor, DateTime mayor, int estado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT";
            cmd.CommandText += " oc_id as 'Orden Compra', ";
            cmd.CommandText += " oc_fecha as 'Fecha', ";
            cmd.CommandText += " pagada as 'Estado', ";
            cmd.CommandText += " prov_nombre as 'Proveedor'";
            cmd.CommandText += " FROM Orden_Compra as OC";
            cmd.CommandText += " LEFT JOIN Proveedor as P ON (P.prov_id=OC.prov_id)";
            cmd.CommandText += " WHERE ";
            cmd.CommandText += " (oc_fecha >= @menor) and (oc_fecha <= @mayor) and (pagada LIKE @estado)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@menor", menor);
            cmd.Parameters.AddWithValue("@mayor", mayor);
            cmd.Parameters.AddWithValue("@estado", estado);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
