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
    public partial class FrmListarVentas : Form
    {
        public FrmListarVentas()
        {
            InitializeComponent();
        }


       

        public void traer_lista_clientes()
        {
            cmbCliente.DataSource = ListarVentaModel.traer_cliente();
            cmbCliente.DisplayMember = "Nombre_Cliente";
            cmbCliente.ValueMember = "Codigo_Cliente";

        }
        private void FrmListarVentas_Load(object sender, EventArgs e)
        {
            dgvListarPedidos.DataSource = ListarVentaModel.traer_cliente();
            traer_lista_clientes();
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            dgvListarPedidos.DataSource = ListarVentaModel.traer_cliente();
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            dgvListarPedidos.DataSource = ListarVentaModel.listar_ventas(dtpEmision.Value, dtpEntrega.Value, Convert.ToInt32(cmbCliente.SelectedValue));
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
