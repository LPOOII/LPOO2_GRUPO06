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
using ClasesBase;
using Vistas.Login;

namespace Vistas.Login
{
    /// <summary>
    /// Lógica de interacción para FormLogin.xaml
    /// </summary>
    public partial class FormLogin : UserControl
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public String Username
        {
            get { return txtUser.Text; }
        }

        public String Password
        {
            get { return txtPassword.Password; }
        }
    }
}
