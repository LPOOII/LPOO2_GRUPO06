using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using ClasesBase;


namespace ClasesBase
{
    public class OrdenCompraModel
    {
        //Este metodo listarProveedor trae todo los roles de la tabla roles.
        public static DataTable listarProveedor()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM proveedor";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }//fin-listarProveedor

        

        //El metodo insertarOrdenCompra nos permite guardar un regsitro
        //a la base de datos pasteleriaDB.
        public static void insertarOrdenCompra(Orden_Compra ordenCompra)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Orden_Compra(prov_id,oc_fecha,pagada) values(@prov,@fecha,@pag)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@prov", ordenCompra.Prov_Id);
            cmd.Parameters.AddWithValue("@fecha", ordenCompra.Oc_fecha);
            cmd.Parameters.AddWithValue("@pag", ordenCompra.Pagada);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }//fin-insertarOredenCompra


       


        //Este metodo listarArticulos trae todo los articulos de la tabla Articulos.
        public static DataTable listarArticulo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM articulo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }//fin-listarArticulo

        
       


        //Este metodo listarItemsOrdenCompra trae todos los items de orden de compra.
        public static DataTable listarItemsOrdenCompra()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT";
            cmd.CommandText += " item_oc_id as 'Id', ";
            cmd.CommandText += " costo as 'Costo', ";
            cmd.CommandText += " cantidad as 'Cantidad', ";
            cmd.CommandText += " importe as 'Importe', ";
            cmd.CommandText += " art_descrip as 'Articulo', ";
            cmd.CommandText += " OC.oc_id as 'Id Compra'";
            cmd.CommandText += " FROM Items_Orden_Compra as IC";

            cmd.CommandText += " LEFT JOIN Articulo as A ON (A.art_id=IC.art_id)";
            cmd.CommandText += " LEFT JOIN Orden_Compra as OC ON (OC.oc_id=IC.oc_id)";          

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }//fin-listarProveedor

        
        //trae el ultimo id de orden de compra
        public static int getIdenty()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT TOP 1 * FROM Orden_Compra  ORDER BY oc_id DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            int id = (int)cmd.ExecuteScalar();
            return id;
        }

        public static SqlConnection cn()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            return cnn;
        }
        //actualiza un articulo
        public static void actualizar_stock(Articulo article)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Articulo
                                set art_descrip=@descrip, art_costo=@costo, art_margen_beneficio=@margBen,
                                    art_precio=@precio, art_stock_min=@stkmin, art_stock_max=@stkmax,
                                    art_stock_reposicion=@stkrep, art_stock_actual=@stkactual, 
                                    art_maneja_stock=@manjstk, fam_id=@fam, um_id=@unMed
                                where art_id=@artId";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@artId", article.Art_Id);
            cmd.Parameters.AddWithValue("@descrip", article.Art_Descrip);
            cmd.Parameters.AddWithValue("@costo", article.Art_Costo);
            cmd.Parameters.AddWithValue("@margBen", article.Art_Margen_Beneficio);
            cmd.Parameters.AddWithValue("@precio", article.Art_Precio);
            cmd.Parameters.AddWithValue("@stkmin", article.Art_Stock_Min);
            cmd.Parameters.AddWithValue("@stkmax", article.Art_Stock_Max);
            cmd.Parameters.AddWithValue("@stkrep", article.Art_Stock_Reposicion);
            cmd.Parameters.AddWithValue("@stkactual", article.Art_Stock_Actual);
            cmd.Parameters.AddWithValue("@manjstk", article.Art_Maneja_Stock);
            // comentado para trabajar en el tp3
            //cmd.Parameters.AddWithValue("@fam", article.Fam_Id);
            //cmd.Parameters.AddWithValue("@unMed", article.Um_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
           
        }
    }
}
