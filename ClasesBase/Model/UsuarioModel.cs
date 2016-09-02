using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using ClasesBase;

namespace ClasesBase
{
    public class UsuarioModel
    {   //Ejecutamos una consulta a la base de dato.
        
        //Este metodo listarRol trae todo los roles de la tabla roles.
        public static DataTable listarRol() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            
            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            
                da.Fill(dt);

            return dt;
        }//fin-listarRol
       
        //traer a todos los usuarios: es usado para hacer el login de los diferntes usuarios
        public static Usuario traer_usuario(string u)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Usuario where usr_username=@u";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@u", u);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Usuario oUsuario = null;
            if (reader.Read() == true)
            {
                oUsuario = new Usuario();

                oUsuario.Usr_UserName = (string)reader["usr_username"];
                oUsuario.Usr_Nombre = (string)reader["usr_nombre"];
                oUsuario.Usr_Apellido = (string)reader["usr_apellido"];
                oUsuario.Usr_Password = (string)reader["usr_password"];
                oUsuario.Rol_Id = (int)reader["rol_id"];
                oUsuario.Usr_Email = (string)reader["usr_email"];
                oUsuario.Usr_Id = (int)reader["usr_id"];

            }
            cnn.Close();
            return oUsuario;
        }

        //El metodo insertarUsuario nos permite guardar un regsitro
        //a la base de datos pasteleriaDB.
        public static void insertarUsuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Usuario(rol_id,usr_apellido,usr_nombre,usr_email,usr_username,usr_password) values(@rol,@ape,@nom,@email,@usu,@pass)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_Id);
            cmd.Parameters.AddWithValue("@ape", user.Usr_Apellido);
            cmd.Parameters.AddWithValue("@nom", user.Usr_Nombre);
            cmd.Parameters.AddWithValue("@email", user.Usr_Email);
            cmd.Parameters.AddWithValue("@usu", user.Usr_UserName);
            cmd.Parameters.AddWithValue("@pass", user.Usr_Password);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }//fin-insertarUsuario

        public static void insert_auditoria(Historial_Login hl)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            
            cmd.CommandText = "HistorialLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@hlog", hl.HLog_Fecha_Hora);
            cmd.Parameters.AddWithValue("@id", hl.Usr_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        
        /*Realizamos una consulta:*/
        //Una vez guardado en el registro en la base de datos. Carga los datos en grilla.
        public static DataTable listar_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descrip as 'Rol', ";
            cmd.CommandText += " usr_apellido as 'Apellido', usr_nombre as 'Nombre', ";
            cmd.CommandText += " usr_username as 'Usuario', usr_password as 'Contraseña', ";
            cmd.CommandText += " usr_email as 'Email', ";
            cmd.CommandText += " usr_id as 'Id Usuario' ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id=U.rol_id)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }//fin-listar_usuarios


        //metodo buscar por nombre o por apellido
        public static DataTable search_usuarios(string nom, string ape)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            
            cmd.CommandText += " usr_id as 'Id Usuario', ";
            cmd.CommandText += " rol_descrip as 'Rol', ";
            cmd.CommandText += " usr_apellido as 'Apellido', usr_nombre as 'Nombre', ";
            cmd.CommandText += " usr_username as 'Usuario', usr_password as 'Contraseña', ";
            cmd.CommandText += " usr_email as 'Email' ";
            

            cmd.CommandText += " FROM Usuario as U";

            
            cmd.CommandText += " inner join Roles as r ON U.rol_id=r.rol_id";
           
            cmd.CommandText += " WHERE";
            cmd.CommandText += " usr_nombre LIKE @nom";
            cmd.CommandText += " AND";
            cmd.CommandText += " usr_apellido LIKE @ape";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            
            cmd.Parameters.AddWithValue("@nom", "%" +nom + "%");
            cmd.Parameters.AddWithValue("@ape", "%" + ape + "%");

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //metodo modificar
        public static void update_usuario(Usuario oUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"update Usuario
                                set rol_id=@rol, usr_apellido=@ape, usr_nombre=@nom, 
                                    usr_username=@user, usr_password=@pass, usr_email=@email
                                where usr_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", oUsuario.Usr_Id);
            cmd.Parameters.AddWithValue("@rol", oUsuario.Rol_Id);
            cmd.Parameters.AddWithValue("@ape", oUsuario.Usr_Apellido);
            cmd.Parameters.AddWithValue("@nom", oUsuario.Usr_Nombre);
            cmd.Parameters.AddWithValue("@user", oUsuario.Usr_UserName);
            cmd.Parameters.AddWithValue("@pass", oUsuario.Usr_Password);
            cmd.Parameters.AddWithValue("@email", oUsuario.Usr_Email);
           
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //metodo eliminar
        public static void deleteUsuario(Usuario oUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Usuario 
                                where usr_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            //parametros
            cmd.Parameters.AddWithValue("@id", oUsuario.Usr_Id);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }//Fin-UsuarioModel
}
