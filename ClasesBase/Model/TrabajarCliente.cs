using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

using ClasesBase;
using ClasesBase.Model;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        /// <summary>
        /// Metodo para traer un Cliente de la base de datos
        /// </summary>
        /// <returns></returns>
        public Cliente traerCliente() 
        {   
            Cliente cliente = new Cliente();
            cliente.Cli_Nombre = "";                
            cliente.Cli_Email = "";            
            return cliente;
        }

        public static Cliente buscarCliente(String id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Cliente where cli_id=@cli_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            if(id.Equals("")){
                id = "0";
            }
            cmd.Parameters.AddWithValue("@cli_id", Convert.ToInt32(id));
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Cliente cliente = null;
            if (reader.Read() == true)
            {
                cliente = new Cliente();
                cliente.Cli_Id = (int)reader["cli_id"];
                cliente.Cli_Nombre = (string)reader["cli_nombre"];
                cliente.Cli_Domicilio = (string)reader["cli_domicilio"];
                cliente.Cli_Departamento = (string)reader["cli_departamento"];
                cliente.Cli_Codigo_Postal = (string)reader["cli_codigo_postal"];
                cliente.Cli_Telefono = (string)reader["cli_telefono"];
                cliente.Cli_Email = (string)reader["cli_email"];
                cliente.Cli_Fecha_Nac = (DateTime)reader["cli_fecha_nac"];
                return cliente;
            }
            cnn.Close();
            return cliente;
        }
    }
}
