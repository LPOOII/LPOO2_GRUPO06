using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.Model
{
    public class PedidoModel
    {
        private static SqlConnection cnn;

        private static void establecerConexion()
        {
            cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
        }

        //Traer todo los clientes
        public static DataTable traerClientes()
        {
            establecerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Pedido_traerClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //Listar todos los productos terminados
        public static DataTable traerProductosTerminados()
        {
            establecerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Pedido_traerProductosTerminados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //Guardar Pedido
        public static void insertarPedido(Pedido pedido)
        {
            establecerConexion();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Pedido_insertar ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cli", pedido.Cli_id);
            cmd.Parameters.AddWithValue("@femision", pedido.Ped_fecha_emision);
            cmd.Parameters.AddWithValue("@fentrega", pedido.Ped_fecha_entrega);
            cmd.Parameters.AddWithValue("@facturado", pedido.Ped_facturado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Guardar itemsPedidos
        public static void insertarItemsPedido(Items_Pedido items_pedido)
        {
            establecerConexion();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Pedido_insertarItemsPedido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@ped_id", items_pedido.Ped_id);
            cmd.Parameters.AddWithValue("@art_id", items_pedido.Art_id);
            cmd.Parameters.AddWithValue("@precio", items_pedido.Precio);
            cmd.Parameters.AddWithValue("@cantidad", items_pedido.Cantidad);
            cmd.Parameters.AddWithValue("@importe", items_pedido.Importe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Buscar
        public static DataTable buscarProducto(string descrip)
        {
            establecerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Pedido_BuscarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descrip", "%" + descrip + "%");

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //Tremos el ultimos registro de pedidos
        public static Pedido traerUltimoPedidoInsertado()
        {
            establecerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT TOP 1 * FROM Pedido ORDER BY ped_id DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Pedido pedido = null;
            if (reader.Read())
            {
                pedido = new Pedido();
                pedido.Cli_id = (int)reader["cli_id"];
                pedido.Ped_facturado = (bool)reader["ped_facturado"];
                pedido.Ped_fecha_emision = (DateTime)reader["ped_fecha_emision"];
                pedido.Ped_fecha_entrega = (DateTime)reader["ped_fecha_entrega"];
                pedido.Ped_id = (int)reader["ped_id"];
            }
            reader.Close();
            cnn.Close();
            return pedido;
        }
    }
}
