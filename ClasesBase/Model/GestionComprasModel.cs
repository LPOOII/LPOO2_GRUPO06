using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using ClasesBase;

namespace ClasesBase
{
    public class GestionComprasModel
    {
        public static DataTable listarProveedor()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT";
            cmd.CommandText += " prov_id as 'Id', ";
            cmd.CommandText += " prov_nombre as 'Nombre', ";
            cmd.CommandText += " prov_domicilio as 'Domicilio', ";
            cmd.CommandText += " prov_departamento as 'Departamento', ";
            cmd.CommandText += " prov_codigo_postal as 'Codigo Postal', ";
            cmd.CommandText += " prov_telefono as 'Telefono', ";
            cmd.CommandText += " prov_email as 'Email'";
            cmd.CommandText += " FROM  Proveedor";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void ingresarProveedor(Proveedor proveedor)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Proveedor(prov_nombre,prov_domicilio,prov_departamento,prov_codigo_postal,prov_telefono,prov_email) values(@nomb,@dom,@dpto,@codPostal,@telefono,@email)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nomb", proveedor.Prov_Nombre);
            cmd.Parameters.AddWithValue("@dom", proveedor.Prov_Domicilio);
            cmd.Parameters.AddWithValue("@dpto", proveedor.Prov_Departamento);
            cmd.Parameters.AddWithValue("@codPostal", proveedor.Prov_Codigo_Postal);
            cmd.Parameters.AddWithValue("@telefono", proveedor.Prov_Telefono);
            cmd.Parameters.AddWithValue("@email", proveedor.Prov_Email);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void eliminarProveedor(Proveedor proveedor)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"DELETE from Proveedor
                                WHERE prov_id=@idProv";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProv", proveedor.Prov_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
                              
        }

        public static void modificarProveedor(Proveedor proveedor)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"update Proveedor set prov_nombre=@nomb, prov_domicilio=@dom, prov_departamento=@dpto, prov_codigo_postal=@codPostal, prov_telefono=@telefono, prov_email=@email
                                where prov_id=@idProv";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idProv", proveedor.Prov_Id);
            cmd.Parameters.AddWithValue("@nomb", proveedor.Prov_Nombre);
            cmd.Parameters.AddWithValue("@dom", proveedor.Prov_Domicilio);
            cmd.Parameters.AddWithValue("@dpto", proveedor.Prov_Departamento);
            cmd.Parameters.AddWithValue("@codPostal", proveedor.Prov_Codigo_Postal);
            cmd.Parameters.AddWithValue("@telefono", proveedor.Prov_Telefono);
            cmd.Parameters.AddWithValue("@email", proveedor.Prov_Email);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscarProveedor(string nomb, string dpto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT";
            cmd.CommandText += " prov_id as 'Id', ";
            cmd.CommandText += " prov_nombre as 'Nombre', ";
            cmd.CommandText += " prov_domicilio as 'Domicilio', ";
            cmd.CommandText += " prov_departamento as 'Departamento', ";
            cmd.CommandText += " prov_codigo_postal as 'Codigo Postal', ";
            cmd.CommandText += " prov_telefono as 'Telefono', ";
            cmd.CommandText += " prov_email as 'Email'";
            cmd.CommandText += " FROM  Proveedor";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " prov_nombre LIKE @nomb";
            cmd.CommandText += " AND";
            cmd.CommandText += " prov_departamento LIKE @dpto";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nomb", "%" + nomb + "%");
            cmd.Parameters.AddWithValue("@dpto", "%" + dpto + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        /*store procedure ordena la lista de proveedores por nombre*/
        public static DataTable traer_proveedor_orden_nombre()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ProveedorOrdenNombre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



    }
}
