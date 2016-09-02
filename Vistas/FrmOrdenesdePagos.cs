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
    public partial class FrmOrdenesdePagos : Form
    {
        public FrmOrdenesdePagos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvOrdenPago.DataSource = OrdenPagoRealizadaModel.orden_pago_fecha(dtpFechaDesde.Value,dtpFechaHasta.Value);
        }

        public void traer_lista_combo()
        {
            cmbProveedor.DataSource = OrdenPagoRealizadaModel.traer_Proveedor();
            cmbProveedor.DisplayMember = "prov_nombre";//"Nombre";
            cmbProveedor.ValueMember = "prov_id";//"Id_Proveedor";
        }

        private void FrmOrdenesdePagos_Load(object sender, EventArgs e)
        {
            traer_lista_combo();
            dgvOrdenPago.DataSource = OrdenPagoRealizadaModel.traer_Proveedor();
        }

        private void cmbProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvOrdenPago.DataSource = OrdenPagoRealizadaModel.traer_OrdenPago_where(Convert.ToInt32(cmbProveedor.SelectedValue));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
