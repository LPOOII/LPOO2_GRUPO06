using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//importamos librerias
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ClienteModel
    {
        //Listar Clientes
        public static DataTable list_clientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Sp_Cliente_ListCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        //Guardar Cliente
        public static void insert_Cliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Cliente_InsertCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            
            cmd.Parameters.AddWithValue("@nom", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@dom", cliente.Cli_Domicilio);
            cmd.Parameters.AddWithValue("@dep", cliente.Cli_Departamento);
            cmd.Parameters.AddWithValue("@cp", cliente.Cli_Codigo_Postal);
            cmd.Parameters.AddWithValue("@tel", cliente.Cli_Telefono);
            cmd.Parameters.AddWithValue("@mail", cliente.Cli_Email);
            cmd.Parameters.AddWithValue("@fecha", cliente.Cli_Fecha_Nac);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Actualizar Cliente
        public static void update_Cliente(Cliente cliente, int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Cliente_UpdateCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@dom", cliente.Cli_Domicilio);
            cmd.Parameters.AddWithValue("@dep", cliente.Cli_Departamento);
            cmd.Parameters.AddWithValue("@cp", cliente.Cli_Codigo_Postal);
            cmd.Parameters.AddWithValue("@tel", cliente.Cli_Telefono);
            cmd.Parameters.AddWithValue("@mail", cliente.Cli_Email);
            cmd.Parameters.AddWithValue("@fecha", cliente.Cli_Fecha_Nac);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Eliminar Cliente
        public static void dalete_Cliente(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Cliente_DeleteCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Buscar por nombre o domicilio
        public static DataTable search_cliente(string nom, string dom)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Sp_Cliente_BuscarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nom", "%" + nom + "%");
            cmd.Parameters.AddWithValue("@dom", "%" + dom + "%");

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


    }
}
