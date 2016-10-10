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
using Vistas.Articulos;

namespace Vistas
{
    /// <summary>
    /// Author Paulo
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if(LoginWindow.UsuarioLogeado.Rol_Id != 1){
                Articulos.Visibility = Visibility.Collapsed;
                Usuarios.Visibility = Visibility.Collapsed;
            }
        }

        /// <summary>
        /// Author Paulo
        /// boton en el menu encargado de cerrar la aplicacion
        /// </summary>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Cerrar aplicación?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                this.Close();
            }
            
        }

        

        private void Panel_categorias(object sender, RoutedEventArgs e)
        {
            Panel_categorias categorias = new Panel_categorias();
            categorias.Show();
        }

        private void Familias(object sender, RoutedEventArgs e)
        {
            Familias familias = new Familias();
            familias.Show();
        }

        private void Unidades_medida(object sender, RoutedEventArgs e)
        {
            Unidades_medida unidades = new Unidades_medida();
            unidades.Show();
        }

        private void Panel_clientes(object sender, RoutedEventArgs e)
        {
            Panel_cliente clientes = new Panel_cliente();
            clientes.Show();
        }

        private void Mesas(object sender, RoutedEventArgs e)
        {
            VentaMesas mesas = new VentaMesas();
            mesas.Show();
        }

        private void ABM(object sender, RoutedEventArgs e)
        {
            abm_articulos abmArt = new abm_articulos();
            abmArt.Show();
        }

        private void Lista_articulos(object sender, RoutedEventArgs e)
        {
            ListadoDeArticulos listaArt = new ListadoDeArticulos();
            listaArt.Show();
        }

    }
}
