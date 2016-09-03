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
    /**
     * @Author Paulo
     * Lógica de interacción para MainWindow.xaml
     **/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /**
         * @Author Raul
         * @Sumary enrrutado de un metodo para cualquier boton
         **/
        private void mostrar(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.OriginalSource;
            // btn: tenemos disponiblidad de todos los metodos
            txtPassword.Password += btn.Content.ToString();

        }
    }
}
