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
    /// Lógica de interacción para Panel_cliente.xaml
    /// </summary>
    public partial class Panel_cliente : Window
    {
        public Panel_cliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cli_Id = 1;
            cliente.Cli_Nombre = nombreApellido.Text;
            cliente.Cli_Domicilio = domicilio.Text;
            cliente.Cli_Departamento = departamento.Text;
            cliente.Cli_Codigo_Postal = codigoPostal.Text;
            cliente.Cli_Email = email.Text;
            cliente.Cli_Telefono = telefono.Text;
            cliente.Cli_Fecha_Nac = fechaNacimiento.SelectedDate.Value.Date;
            dataGridClientes.Items.Add(cliente);
            nombreApellido.Text = "";
            domicilio.Text = "";
            departamento.Text = "";
            email.Text = "";
            codigoPostal.Text = "";
            telefono.Text = "";
            fechaNacimiento.SelectedDate = null;
        }
    }
}
