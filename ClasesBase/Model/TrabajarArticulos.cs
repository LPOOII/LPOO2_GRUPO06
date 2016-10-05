using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using ClasesBase;
using ClasesBase.Model;
using System.Collections.ObjectModel;

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

        public static ObservableCollection<Articulo> collectionArticulos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ArticulosJoined";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ObservableCollection<Articulo> obCol = new ObservableCollection<Articulo>();
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Articulo articulo = new Articulo();
                articulo.Art_Id = (int)row["art_id"];
                articulo.Art_Descrip = (string)row["art_descrip"];
                articulo.Art_Costo = (decimal)row["art_costo"];
                articulo.Art_Margen_Beneficio = (decimal)row["art_margen_beneficio"];
                articulo.Art_Precio = (decimal)row["art_precio"];
                articulo.Art_Stock_Min = (decimal)row["art_stock_min"];
                articulo.Art_Stock_Max = (decimal)row["art_stock_max"];
                articulo.Art_Maneja_Stock = (Boolean)row["art_maneja_stock"];
                articulo.Familia = (Familia)row["fam_id"];
                articulo.Unidad_Medida = (Unidad_Medida)row["um_id"];
                obCol.Add(articulo);
            }
            return obCol;
        }

    }
}
