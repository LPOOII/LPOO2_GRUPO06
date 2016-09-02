using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase.Model
{
    public class GestionPagoModel
    {
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

        public static decimal total_importe(int idc)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "GestionPagoTotal";
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.Parameters.AddWithValue("@idc", idc);
            decimal id = (decimal)cmd.ExecuteScalar();
            return id;
        }

        public static void insertar_pago(Orden_Pago pag)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GestionPagoAgregar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@oc", pag.Oc_Id);
            cmd.Parameters.AddWithValue("@prov", pag.Prov_Id);
            cmd.Parameters.AddWithValue("@fec", pag.Op_Fecha);
            cmd.Parameters.AddWithValue("@imp", pag.Op_Importe);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static int parametro (int oc)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "OrdenCompraTraer";
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.Parameters.AddWithValue("@oc", oc);
            int id = (int)cmd.ExecuteScalar();
            return id;
        }

        public static Orden_Compra TraerOrden_where(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "OrdenCompraTraerObjet";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Orden_Compra oOrden = null;
            if (reader.Read() == true)
            {
                oOrden = new Orden_Compra();
                oOrden.Oc_Id = (int)reader["oc_id"];
                oOrden.Oc_fecha = (DateTime)reader["oc_fecha"];
                oOrden.Pagada = (Boolean)reader["pagada"];
                oOrden.Prov_Id = (int)reader["prov_id"];
                
            }
            cnn.Close();
            return oOrden;
        }


        public static void update_orden_compra(Orden_Compra ordenCompra)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            
            cmd.CommandText = "OrdenCompraModificar";
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", ordenCompra.Oc_Id);
            cmd.Parameters.AddWithValue("@prov", ordenCompra.Prov_Id);
            cmd.Parameters.AddWithValue("@fecha", ordenCompra.Oc_fecha);
            cmd.Parameters.AddWithValue("@pag", ordenCompra.Pagada);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable TraerTodo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GestionPagoTodo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}
