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
using System.Data;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Panel_cliente.xaml
    /// </summary>
    public partial class Panel_cliente : Window
    {
        bool saveOrUpdate = false;

        public Panel_cliente()
        {
            InitializeComponent();
            DataTable dtClientes = ClienteModel.list_clientes();
            dataGridClientes.ItemsSource = dtClientes.DefaultView;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Cli_Id = Convert.ToInt32(idCliente.Text);
                cliente.Cli_Nombre = nombreApellido.Text;
                cliente.Cli_Domicilio = domicilio.Text;
                cliente.Cli_Departamento = departamento.Text;
                cliente.Cli_Codigo_Postal = codigoPostal.Text;
                cliente.Cli_Email = email.Text;
                cliente.Cli_Telefono = telefono.Text;
                cliente.Cli_Fecha_Nac = fechaNacimiento.SelectedDate.Value.Date;
                if (saveOrUpdate)
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Deseas guardar los cambios?", "Actualizar", System.Windows.MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        ClienteModel.update_Cliente(cliente, cliente.Cli_Id);
                        MessageBox.Show("Datos actualizados");
                    }
                }
                else
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Deseas agregar nuevo cliente?", "Agregar", System.Windows.MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        ClienteModel.insert_Cliente(cliente);
                        MessageBox.Show("Cliente agregado");
                    }
                }
            }
            catch (Exception ex)
            {
                if(ex is NullReferenceException || ex is InvalidOperationException)
                {
                    MessageBox.Show("Los campos no deben estar vacios");
                }                
            }
            saveOrUpdate = false;
            DataTable dtClientes = ClienteModel.list_clientes();
            dataGridClientes.ItemsSource = dtClientes.DefaultView;
            idCliente.Text = "";
            nombreApellido.Text = "";
            domicilio.Text = "";
            departamento.Text = "";
            email.Text = "";
            codigoPostal.Text = "";
            telefono.Text = "";
            fechaNacimiento.SelectedDate = null;
        }

        private void idCliente_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(idCliente.Text != "0"){
                Cliente clienteEncontrado = TrabajarCliente.buscarCliente(idCliente.Text);
                if (clienteEncontrado != null)
                {
                    saveOrUpdate = true;
                    nombreApellido.Text = clienteEncontrado.Cli_Nombre;
                    domicilio.Text = clienteEncontrado.Cli_Domicilio;
                    departamento.Text = clienteEncontrado.Cli_Departamento;
                    email.Text = clienteEncontrado.Cli_Email;
                    codigoPostal.Text = clienteEncontrado.Cli_Codigo_Postal;
                    telefono.Text = clienteEncontrado.Cli_Telefono;
                    fechaNacimiento.SelectedDate = clienteEncontrado.Cli_Fecha_Nac;
                }
                else 
                {
                    saveOrUpdate = false;
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
    }
}
