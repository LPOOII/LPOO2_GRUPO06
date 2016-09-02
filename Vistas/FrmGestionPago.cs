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
    public partial class FrmGestionPago : Form
    {
        public FrmGestionPago()
        {
            InitializeComponent();
        }

        public void traer_ListaComboOrdenCompra()
        {
            DataTable tablaOrden = GestionPagoModel.traer_OrdenCompra();
            tablaOrden.Columns.Add("datos_orden", typeof(string), "oc_id+ ' - '+ pagada + ' - '+ prov_nombre");
            cmbOrden.DataSource = tablaOrden;
            cmbOrden.DisplayMember = "datos_orden";
            cmbOrden.ValueMember = "oc_id";
            
        }
        //loads
        private void FrmGestionPago_Load(object sender, EventArgs e)
        {
            traer_ListaComboOrdenCompra();
            txtImporte.Enabled = false;
            dgvPago.DataSource = GestionPagoModel.TraerTodo();
        }

        private void cmbOrden_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtImporte.Text = Convert.ToString(GestionPagoModel.total_importe(Convert.ToInt32(cmbOrden.SelectedValue)));
        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestionPago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere Pagar, La Orden De Compra?", "Orden de Pago",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {

                Orden_Pago unaOrdenPago = new Orden_Pago();
                unaOrdenPago.Op_Importe = Convert.ToDecimal(txtImporte.Text);
                unaOrdenPago.Op_Fecha = dtpFechaOrden.Value;
                unaOrdenPago.Oc_Id = Convert.ToInt32(cmbOrden.SelectedValue);
                unaOrdenPago.Prov_Id = GestionPagoModel.parametro(Convert.ToInt32(cmbOrden.SelectedValue));
                
                GestionPagoModel.insertar_pago(unaOrdenPago);
                Orden_Compra unaCompra = GestionPagoModel.TraerOrden_where(Convert.ToInt32(cmbOrden.SelectedValue));
                unaCompra.Pagada = true;
                GestionPagoModel.update_orden_compra(unaCompra);
                
                traer_ListaComboOrdenCompra();
                txtImporte.Text = "";                
                
                MessageBox.Show("fecha: " + dtpFechaOrden.Value);
                dgvPago.DataSource = GestionPagoModel.TraerTodo();
                MessageBox.Show("Se realizo la Orden de Pago Exitosamente !!!");

            }
        }

       

        


        

    }
}
