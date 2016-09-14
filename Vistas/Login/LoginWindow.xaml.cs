 using System;
using System.ComponentModel;
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
using System.Collections;
using ClasesBase;

namespace Vistas
{
    
    /// <summary> 
    /// Lógica de interacción para MainWindow.xaml
    /// Author Paulo
    /// </summary>
    public partial class LoginWindow : Window
    {
        /// <summary>
        /// variable que almacena datos de usuario logeado
        /// </summary>
        private static Usuario usuarioLogeado;

        public static Usuario UsuarioLogeado
        {
            get { return LoginWindow.usuarioLogeado; }
            set { LoginWindow.usuarioLogeado = value; }
        }
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Author Raul
        /// Sumary enrrutado de un metodo para cualquier boton
        /// </summary>
        private void mostrar(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.OriginalSource;
            // btn: tenemos disponiblidad de todos los metodos
            formLogin.txtPassword.Password += btn.Content.ToString();
        }

         /// <summary>
         /// Author Paulo
         /// metodo encargado de cerrar la ventana
         /// </summary>
        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }



        /// <summary>
        /// Author Paulo
        /// metodo encargado de abrir ventana de aplicacion luego del login exitoso
        /// </summary>
        private void windows_closed(object sender, CancelEventArgs e)
        {
            if (formLogin.isLogeado)
            {   // instacia al MainWindow
                MainWindow main = new MainWindow();
                //llama al formulario una vez logueado
                main.Show();
            }
        }

        
    }
}
