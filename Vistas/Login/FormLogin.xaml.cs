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
using System.Collections;
using ClasesBase;
using Vistas.Login;

namespace Vistas.Login
{
    /// <summary>
    /// Lógica de interacción para FormLogin.xaml
    /// </summary>
    public partial class FormLogin : UserControl
    {
        /// <summary>
        /// variables de control de login
        /// </summary>
        bool isLogged = false;        
        private ArrayList usuarios = new ArrayList();
        public FormLogin()
        {
            InitializeComponent();
            usuarios.Add(new Usuario("admin", "1111", 1));
            usuarios.Add(new Usuario("mozo", "2222", 2));
            usuarios.Add(new Usuario("cajero", "3333", 3));
            usuarios.Add(new Usuario("repositor", "4444", 4));
            usuarios.Add(new Usuario("pastelero", "5555", 5));
            usuarios.Add(new Usuario("comprador", "6666", 6));
            usuarios.Add(new Usuario("vendedor", "7777", 7));
        }

        /// <summary>
        /// getter para vereficar si usuario esta logeado
        /// </summary>
        public bool isLogeado
        {
            get { return isLogged; }        
        }

        /// <summary>
        /// Author Paulo
        /// metodo encargado del login de usuario
        /// </summary>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            login();
        }

        /// <summary>
        /// metodo de login de usuarios
        /// </summary>
        private void login()
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Usr_UserName == txtUser.Text && usuario.Usr_Password == txtPassword.Password)
                {
                    this.isLogged = true;
                    var myWindow = Window.GetWindow(this);
                    LoginWindow.UsuarioLogeado = usuario;
                    myWindow.Close();
                    break;
                }
            }
            if (!isLogged)
            {
                MessageBox.Show("Password y/o usuario incorrecto");
            }

        }

        /// <summary>
        /// metodo para ejecutar el login presionando la tecla enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                login();
            }
        }
        
    }
}
