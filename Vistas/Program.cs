using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClasesBase;
namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static Usuario userValido = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CargaSistema cargar = new CargaSistema();
            cargar.ShowDialog();
            // Application.Run(new FrmLogin());
            userValido = new Usuario();
            //codigo agregado
           /* FrmLogin login = new FrmLogin();
            login.ShowDialog();

            //Evaluar el resultado de la validacion de usuario
            //del fLogin
            if (login.DialogResult == DialogResult.OK)
            {
                Application.Run(new FrmMenuPrincipal());
            }
           */
            FrmLogin login;
            FrmMenuPrincipal principal;
            do
            {
                login = new FrmLogin();
                login.ShowDialog();
                principal = new FrmMenuPrincipal();
                if (login.DialogResult == DialogResult.OK)
                {

                    Application.Run(principal);
                }
            } while (login.DialogResult == DialogResult.No);
            ///
        }
    }
}
