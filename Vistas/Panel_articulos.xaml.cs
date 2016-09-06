using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Panel_articulos.xaml
    /// </summary>
    public partial class Panel_articulos : Window
    {
        public Panel_articulos()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// metodo para cargar items en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lista_articulos(object sender, RoutedEventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            //var grid = sender as DataGrid;
            //grid.ItemsSource = lista;
        }

        /// <summary>
        /// metodo para cargar combo box de familias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void load_familia(object sender, RoutedEventArgs e) 
        {
            List<String> familias = new List<String>();
            familias.Add("Selecciona un valor");
            familias.Add("Materias primas");
            familias.Add("Productos terminados");
            familias.Add("Servicios");
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = familias;
            comboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// metodo para cargar combo box de unidades de medida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void load_unidades(object sender, RoutedEventArgs e)
        {
            List<String> unidades = new List<String>();
            unidades.Add("Selecciona un valor");
            unidades.Add("Kilogramos");
            unidades.Add("Gramos");
            unidades.Add("Miligramos");
            unidades.Add("Litros");
            unidades.Add("Unidades");
            unidades.Add("Docenas");
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = unidades;
            comboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// metodo para guardar en el datagridview el articulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarBtn_Click(object sender, RoutedEventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo.Art_Id = 1;
            articulo.Art_Descrip = descripcion.Text;
            articulo.Fam_Id = 1;
            articulo.Um_Id = 1;
            articulo.Art_Costo = Convert.ToInt32(costo.Text);
            articulo.Art_Stock_Min = Convert.ToInt32(minimo.Text);
            articulo.Art_Stock_Max = Convert.ToInt32(maximo.Text);
            articulo.Art_Precio = Convert.ToInt32(precio.Text);
            articulo.Art_Stock_Reposicion = Convert.ToInt32(reposicion.Text);
            articulo.Art_Stock_Actual = Convert.ToInt32(actual.Text);
            articulo.Art_Maneja_Stock = true;
            articulo.Art_Margen_Beneficio = 10;
            dataGridArticulos.Items.Add(articulo);
            MessageBox.Show(articulo.ToString());
        }

    }
}
