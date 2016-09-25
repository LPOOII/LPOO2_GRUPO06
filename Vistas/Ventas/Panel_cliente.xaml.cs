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
using System.Text.RegularExpressions;

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
            // Inicializamos tabla de clientes en la vista.
            DataTable dtClientes = ClienteModel.list_clientes();
            dataGridClientes.ItemsSource = dtClientes.DefaultView;
        }

        /// <summary>
        /// Metodo para guardar cliente (Insertar o actualizar)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // bucle try catch, para evitar exceptions al dejar campos vacios o mal llenados
            try
            {
                // objeto cliente 
                Cliente cliente = new Cliente();
                cliente.Cli_Id = Convert.ToInt32(idCliente.Text);
                cliente.Cli_Nombre = nombreApellido.Text;
                cliente.Cli_Domicilio = domicilio.Text;
                cliente.Cli_Departamento = departamento.Text;
                cliente.Cli_Codigo_Postal = codigoPostal.Text;
                cliente.Cli_Email = email.Text;
                cliente.Cli_Telefono = telefono.Text;
                cliente.Cli_Fecha_Nac = fechaNacimiento.SelectedDate.Value.Date;
                // bucle if para determinar si se esta actualizando o agregando
                if (saveOrUpdate)
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Deseas guardar los cambios?", "Actualizar", System.Windows.MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        // operacion de actualizacion
                        ClienteModel.update_Cliente(cliente, cliente.Cli_Id);
                        MessageBox.Show("Datos actualizados");
                    }
                }
                else
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Deseas agregar nuevo cliente?", "Agregar", System.Windows.MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        // operacion de insersion
                        ClienteModel.insert_Cliente(cliente);
                        MessageBox.Show("Cliente agregado");
                    }
                }
            }
            catch (Exception ex)
            {
                if(ex is NullReferenceException || ex is InvalidOperationException)
                {
                    // exception por campos vacios o mal llenados
                    MessageBox.Show("Los campos no deben estar vacios");
                }                
            }
            // reestablecimiento de la variable para guardar o actualizar
            saveOrUpdate = false;
            // actualizacion del datagrid
            DataTable dtClientes = ClienteModel.list_clientes();
            dataGridClientes.ItemsSource = dtClientes.DefaultView;
            // limpieza de los campos
            idCliente.Text = "";
            nombreApellido.Text = "";
            domicilio.Text = "";
            departamento.Text = "";
            email.Text = "";
            codigoPostal.Text = "";
            telefono.Text = "";
            fechaNacimiento.SelectedDate = null;
        }

        /// <summary>
        /// Metodo para detectar si el texto cambio del input de cliente_id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void idCliente_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Bucle if para evitar busquedas con id valor a cero (0)
            if(idCliente.Text != "0"){
                // busqueda del cliente por id
                Cliente clienteEncontrado = TrabajarCliente.buscarCliente(idCliente.Text);
                if (clienteEncontrado != null)
                {
                    // carga de datos en los textbox
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
                    // limpieza de los campos en caso de nueva busqueda
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

        private void inputValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
