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
        bool isLogged = false;
        public static Usuario usuarioLogeado;
        private ArrayList usuarios = new ArrayList();

        public LoginWindow()
        {
            InitializeComponent();
            usuarios.Add(new Usuario("1111", "1111", 1));
            usuarios.Add(new Usuario("2222", "2222", 2));
            usuarios.Add(new Usuario("3333", "3333", 3));
        }

        /// <summary>
        /// Author Raul
        /// Sumary enrrutado de un metodo para cualquier boton
        /// </summary>
        private void mostrar(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.OriginalSource;
            // btn: tenemos disponiblidad de todos los metodos
            txtPassword.Password += btn.Content.ToString();

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
         /// metodo encargado del login de usuario
         /// </summary>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            login();
        }

        private void login() 
        {
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.Usr_UserName == txtUser.Text && usuario.Usr_Password == txtPassword.Password)
                {
                    this.isLogged = true;
                    usuarioLogeado = usuario;
                    this.Close();
                    break;
                }                
            }
            if (!isLogged)
            {
                MessageBox.Show("Password y/o usuario incorrecto");
            }
            
        }

         /// <summary>
         /// Author Paulo
         /// metodo encargado de abrir ventana de aplicacion luego del login exitoso
         /// </summary>
        private void windows_closed(object sender, CancelEventArgs e) 
        {
            if (isLogged)
            {
                MainWindow main = new MainWindow();
                main.Show();
            }
        }

        private void Enter(object sender, KeyEventArgs e) 
        { 
         if(e.Key == Key.Enter)
         {
             login();
         }
        }
    }
}
