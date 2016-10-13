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
    /// Lógica de interacción para VistaPreviaPedidoImpresion.xaml
    /// </summary>
    public partial class VistaPreviaPedidoImpresion : Window
    {
        private int nroPedido;

        public int NroPedido
        {
            get { return nroPedido; }
            set { nroPedido = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private int nroMesa;

        public int NroMesa
        {
            get { return nroMesa; }
            set { nroMesa = value; }
        }

        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private string mozo;

        public string Mozo
        {
            get { return mozo; }
            set { mozo = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private List<Gen> listaimpresion;

        public List<Gen> Listaimpresion
        {
            get { return listaimpresion; }
            set { listaimpresion = value; }
        }

        

        public VistaPreviaPedidoImpresion()
        {
            InitializeComponent();
            this.DataContext = this;
        }

       

        
    }
}
