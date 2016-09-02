using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase.Model
{
    public class CompraOrdenadasModel
    {
        public static DataTable traer_todo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "OrdenesCompraProveedorTodo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable traer_OrdenCompra()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "OrdenCompraTodo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /* traemos todos los proveedores de la orden compra sin repetir */
        public static DataTable traer_proveedor()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "OrdenesCompraProveedor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       
        public static DataTable traer_OrdenCompra_where(int prov)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListaOrdenCompra";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@prov", prov);
            DataTable dt = new DataTable();            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable traer_todo_orden_compra()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "OrdenesCompraTodoc";
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
