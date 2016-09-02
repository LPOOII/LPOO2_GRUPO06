using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class VentasModel
    {
        //Listar todo los Pedido donde ped_facturado='False'
        public static DataTable listar_pedido()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Sp_Venta_ListarPedido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        //Traemos el objeto pedido para mostrar algunos datos
        public static Pedido traer_pedido(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Sp_Venta_TraerPedido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Pedido oPedido = null;
            if (reader.Read())
            {
                oPedido = new Pedido();
                oPedido.Ped_id=(int)reader["Ped_id"];
                oPedido.Cli_id = (int)reader["Cli_id"];
                oPedido.Ped_fecha_emision = (DateTime)reader["Ped_fecha_emision"];
                oPedido.Ped_fecha_entrega = (DateTime)reader["Ped_fecha_entrega"];
                oPedido.Ped_facturado = (bool)reader["ped_facturado"];

            }
            reader.Close();
            cnn.Close();
            return oPedido;
        }

        //Traemos el objeto cliente para mostrar algunos datos
        public static Cliente traer_Cliente(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Sp_Venta_TraerCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Cliente oCliente = null;
            if (reader.Read())
            {
                oCliente = new Cliente();
                oCliente.Cli_Id = (int)reader["Cli_Id"];
                oCliente.Cli_Nombre = (string)reader["Cli_Nombre"];
                oCliente.Cli_Domicilio = (string)reader["Cli_Domicilio"];
                oCliente.Cli_Departamento = (string)reader["Cli_Departamento"];
                oCliente.Cli_Codigo_Postal = (string)reader["Cli_Codigo_Postal"];
                oCliente.Cli_Telefono = (string)reader["Cli_Telefono"];
                oCliente.Cli_Email = (string)reader["Cli_Email"];
                oCliente.Cli_Fecha_Nac = (DateTime)reader["Cli_Fecha_Nac"];
            }
            reader.Close();
            cnn.Close();
            return oCliente;
        }
       
        //Listar los Pedido que tiene el cliente
        public static DataTable traer_Articulo_pedido(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Venta_TraerArticuloPedido";
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        //Listar la forma de Pagos
        public static DataTable traer_Form_Pago()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Forma_Pago";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        //Guardar Factura
        public static void insert_Factura(Factura factura)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Venta_InsertFactura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ped_id", factura.Ped_id);
            cmd.Parameters.AddWithValue("@cli_id", factura.Cli_id);
            cmd.Parameters.AddWithValue("@fac_numero", factura.Fac_numero);
            cmd.Parameters.AddWithValue("@fac_fecha", factura.Fac_fecha);
            cmd.Parameters.AddWithValue("@fp_id", factura.Fp_id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        
        //Guardar Items_Factura
        public static void insert_Items_Factura(Items_Factura itemFactura)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"Sp_Venta_InsertItemsFactura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@f_id", itemFactura.Fac_id);
            cmd.Parameters.AddWithValue("@a_id", itemFactura.Art_id);
            cmd.Parameters.AddWithValue("@pre", itemFactura.Precio);
            cmd.Parameters.AddWithValue("@cant", itemFactura.Cantidad);
            cmd.Parameters.AddWithValue("@imp", itemFactura.Importe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        //total
        //Obtener Total( Con Sum() ): Calculamos el importe total 
        public static decimal get_ImporteTotal(int id)
        {
            decimal total = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Venta_ImporteTotal";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Anadir un parametro de ENTRADA
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters["@id"].Direction = ParameterDirection.Input;

            //Anadir un parametro de SALIDA
            cmd.Parameters.Add("@total", SqlDbType.Decimal);
            cmd.Parameters["@total"].Direction = ParameterDirection.Output;

            //Ejecuta la consulta.
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            total = (decimal)cmd.Parameters["@total"].Value;
            return total;
        }

        //Actualizar Articulo de Pedido
        public static void update_Articulo_Pedido(Articulo article, int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Venta_UpdateArticuloPedido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@stkactual", article.Art_Stock_Actual);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Actualizar Pedido
        public static void update_Pedido(Pedido pedido, int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Venta_UpdatePedido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fac", pedido.Ped_facturado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Devolvemos el ultimo registro de Factura
        /*  y traemos el objeto factura para mostrar algunos datos*/
        public static Factura get_id_Factura()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Venta_GetIdFactura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Factura factura = null;
            if (reader.Read())
            {
                factura = new Factura();
                factura.Fac_id = (int)reader["fac_id"];
                factura.Ped_id = (int)reader["ped_id"];
                factura.Cli_id = (int)reader["cli_id"];
                factura.Fac_numero = (int)reader["fac_numero"];
                factura.Fac_fecha=(DateTime)reader["fac_fecha"];
                factura.Fp_id = (int)reader["fp_id"];
            }
            reader.Close();
            cnn.Close();
            return factura;
        }

        

    }
}
