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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Raul 
        /// </summary>
        // enrrutado de un metodo para cualquier boton
        private void mostrar(object sender, RoutedEventArgs e)
        {

            //OriginalSource: trae el evento a su padre
            Button btn = (Button)e.OriginalSource;
            // btn: tenemos disponiblidad de todos los metodos
            txtPassword.Text += btn.Content.ToString();

        }
    }
}
