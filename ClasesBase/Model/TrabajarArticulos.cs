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
            //cmd.CommandText = "SELECT * FROM Articulo";
            cmd.CommandText = "SELECT * FROM ArticulosJoined";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ObservableCollection<Articulo> obCol = new ObservableCollection<Articulo>();
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                
                Familia familia = new Familia();
                familia.Fam_Id = (int)row["fam_id"];
                familia.Fam_Descrip = (string)row["fam_descrip"];
                Unidad_Medida unidad_Medida = new Unidad_Medida();
                unidad_Medida.Um_Id = (int)row["um_id"];
                unidad_Medida.Um_Abrev = (string)row["um_abrev"];
                unidad_Medida.Um_Descrip = (string)row["um_descrip"];
                Articulo articulo = new Articulo();
                articulo.Art_Id = (int)row["art_id"];
                articulo.Art_Descrip = (string)row["art_descrip"];
                articulo.Art_Costo = (decimal)row["art_costo"];
                articulo.Art_Margen_Beneficio = (decimal)row["art_margen_beneficio"];
                articulo.Art_Precio = (decimal)row["art_precio"];
                articulo.Art_Stock_Min = (decimal)row["art_stock_min"];
                articulo.Art_Stock_Max = (decimal)row["art_stock_max"];
                //
                articulo.Art_Stock_Actual = (decimal)row["art_stock_actual"];
                articulo.Art_Stock_Reposicion = (decimal)row["art_stock_reposicion"];

                //
                Categoria categoria = new Categoria();
                categoria.Cat_Id = (int)row["cat_id"];
                categoria.Cat_Descrip = (string)row["cat_descrip"];
                //

                articulo.Art_Maneja_Stock = (Boolean)row["art_maneja_stock"];
                articulo.Fam_Id = familia; 
                articulo.Um_Id = unidad_Medida;
                articulo.Cat_Id = categoria;
                obCol.Add(articulo);
            }
            return obCol;
        }


        public static ObservableCollection<Usuario> TraerUsuarios()
        {
            ObservableCollection<Usuario> listaUsuario = new ObservableCollection<Usuario>();

            listaUsuario.Add(new Usuario("juan", "123"));
            listaUsuario.Add(new Usuario("pedro", "456"));
            listaUsuario.Add(new Usuario("maria", "123"));
            listaUsuario.Add(new Usuario("laura", "678"));

            return listaUsuario;
        }

        public static ObservableCollection<Categoria> collectionCategorias()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Categoria";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ObservableCollection<Categoria> obCol = new ObservableCollection<Categoria>();
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Categoria category = new Categoria();
                category.Cat_Id = (int)row["cat_id"];
                category.Cat_Descrip = (string)row["cat_descrip"];
                obCol.Add(category);
            }
            return obCol;
        }

        public static ObservableCollection<Familia> collectionFamilias()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Familia";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ObservableCollection<Familia> obCol = new ObservableCollection<Familia>();
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                
                Familia family = new Familia();
                family.Fam_Id = (int)row["fam_id"];
                family.Fam_Descrip = (string)row["fam_descrip"];
                obCol.Add(family);
            }
            return obCol;
        }

        public static ObservableCollection<Unidad_Medida> collectionUnidadMedidas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Unidad_Medida";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ObservableCollection<Unidad_Medida> obCol = new ObservableCollection<Unidad_Medida>();
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Unidad_Medida unitMeasure = new Unidad_Medida();
                unitMeasure.Um_Id = (int)row["um_id"];
                unitMeasure.Um_Descrip = (string)row["um_descrip"];
                unitMeasure.Um_Abrev = (string)row["um_abrev"];
                obCol.Add(unitMeasure);
            }
            return obCol;
        }

        public static ObservableCollection<Categoria> collectionCategoria()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Categoria";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ObservableCollection<Categoria> obCol = new ObservableCollection<Categoria>();
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {                
                Categoria Category = new Categoria();
                Category.Cat_Id = (int)row["cat_id"];
                Category.Cat_Descrip = (string)row["cat_descrip"];              
                obCol.Add(Category);
            }
            return obCol;
        }
    }
}
