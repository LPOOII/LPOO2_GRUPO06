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

namespace Vistas.Ventas
{
    /// <summary>
    /// Lógica de interacción para Pedidos.xaml
    /// </summary>
    public partial class Pedidos : Window
    {
        public Pedidos()
        {
            InitializeComponent();
            btnConfirmarPedido.IsEnabled = false;
        }

        private static List<Gen> listaPedido = new List<Gen>();

        public static List<Gen> ListaPedido
        {
            get { return Pedidos.listaPedido; }
            set { Pedidos.listaPedido = value; }
        }
        
        private void Agregar_Pedido(object sender, RoutedEventArgs e)
        {
            Gen unPedido = new Gen();
            unPedido.Cant = Convert.ToInt32(txtCantidad.Text);
            unPedido.Descrip = cmbArticle.SelectedValue.ToString();           
            listView.Items.Add(unPedido);

            listaPedido.Add(unPedido);
            btnConfirmarPedido.IsEnabled = true;
           
        }

        
        private void btnConfirmarPedido_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Confirmar Pedido?", "Pregunta", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                VistaPreviaPedidoImpresion vPI = new VistaPreviaPedidoImpresion();
                vPI.listView2 = null;

                vPI.Listaimpresion = null;

                vPI.NroPedido = 999999;
                vPI.Fecha = dpFecha.SelectedDate.Value;
                vPI.NroMesa = Convert.ToInt32(txtNroMesa.Text);
                vPI.Cliente = txtCliente.Text;
                vPI.Mozo = "Juan Diaz";
                vPI.Listaimpresion = listaPedido;
                vPI.Show();
                listView.Items.Clear();
                listaPedido = new List<Gen>();
                limpieza();
            }
            
        }

        public void limpieza()
        {
            txtNroMesa.Text = "";
            txtCliente.Text = "";
            txtCantidad.Text = "";
            cmbArticle.Text = "";
            dpFecha.Text = "";
        }
    }
}
