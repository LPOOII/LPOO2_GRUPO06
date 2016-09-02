using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;
using ClasesBase.Model;
namespace Vistas
{
    public partial class FrmListarPedidos : Form
    {
        public FrmListarPedidos()
        {
            InitializeComponent();
        }

        public void traer_lista_clientes()
        {
            cmbCliente.DataSource = ListarPedidoModel.traer_cliente(); 
            cmbCliente.DisplayMember = "Nombre_Cliente";
            cmbCliente.ValueMember = "Codigo_Cliente";

        }

        private void FrmListarPedidos_Load(object sender, EventArgs e)
        {
            traer_lista_clientes();
            dgvListarPedidos.DataSource = ListarPedidoModel.traer_cliente();
        }

       
        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            dgvListarPedidos.DataSource = ListarPedidoModel.listar_pedidos(dtpEmision.Value, dtpEntrega.Value, Convert.ToInt32(cmbCliente.SelectedValue));
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            dgvListarPedidos.DataSource = ListarPedidoModel.traer_cliente();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
