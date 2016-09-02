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
    public partial class FrmOrdenesCompra : Form
    {
        public FrmOrdenesCompra()
        {
            InitializeComponent();
        }

        public void traer_ListaComboOrdenCompra()
        {
            DataTable tablaOrden = CompraOrdenadasModel.traer_proveedor();
           
            tablaOrden.Columns.Add("datos_orden", typeof(string), "prov_id+ ' - '+ prov_nombre");
            cmbCompra.DataSource = tablaOrden;
            cmbCompra.DisplayMember = "datos_orden";
            cmbCompra.ValueMember = "prov_id";
            
        }

        private void FrmOrdenesCompra_Load(object sender, EventArgs e)
        {
            traer_ListaComboOrdenCompra();
            dgvOrdenCompra.DataSource = CompraOrdenadasModel.traer_todo_orden_compra();

        }

        private void cmbCompra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvOrdenCompra.DataSource = CompraOrdenadasModel.traer_OrdenCompra_where(Convert.ToInt32(cmbCompra.SelectedValue));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvOrdenCompra.DataSource = CompraOrdenadasModel.traer_todo_orden_compra();
        }



    }
}
