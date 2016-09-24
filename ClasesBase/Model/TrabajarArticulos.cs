using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using ClasesBase;
using ClasesBase.Model;

namespace ClasesBase
{
    public class TrabajarArticulos
    {
        /// <summary>
        /// Metodo para traer todos los datos de la tabla Articulo de la base de datos
        /// </summary>
        /// <returns></returns>
        public static DataTable TraerArticulos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Articulo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
       }
    }
}
