using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmABMProveedor : Form
    {
        public FrmABMProveedor()
        {
            InitializeComponent();
        }

        private void btnMostrarProveedor_Click(object sender, EventArgs e)
        {
            dataGridViewProveedor.DataSource = GestionComprasModel.listarProveedor();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor oProveedor = new Proveedor();
            oProveedor.Prov_Nombre = txtNombre.Text;
            oProveedor.Prov_Domicilio = txtDomicilio.Text;
            oProveedor.Prov_Departamento = txtDpto.Text;
            oProveedor.Prov_Codigo_Postal = txtCodPostal.Text;
            oProveedor.Prov_Telefono = txtTelefono.Text;
            oProveedor.Prov_Email = txtEmail.Text;

            GestionComprasModel.ingresarProveedor(oProveedor);
            MessageBox.Show("Se guardo exitosamente!");
            BorrarCampos(gbProv);
            
            dataGridViewProveedor.DataSource = GestionComprasModel.listarProveedor();
            
        }

        public void BorrarCampos(GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
            }
            btnGuardarProveedor.Enabled = true;
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Eliminar?", "Borrar Proveedor",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                Proveedor oProveedor = new Proveedor();
                oProveedor.Prov_Id = Convert.ToInt32(txtId.Text);
                oProveedor.Prov_Nombre = txtNombre.Text;
                oProveedor.Prov_Domicilio = txtDomicilio.Text;
                oProveedor.Prov_Departamento = txtDpto.Text;
                oProveedor.Prov_Codigo_Postal = txtCodPostal.Text;
                oProveedor.Prov_Telefono = txtTelefono.Text;
                oProveedor.Prov_Email = txtEmail.Text;

                GestionComprasModel.eliminarProveedor(oProveedor);
                dataGridViewProveedor.DataSource = GestionComprasModel.listarProveedor();
            }
        }

        private void dataGridViewProveedor_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewProveedor.CurrentRow != null)
            {
                txtId.Text = dataGridViewProveedor.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dataGridViewProveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDomicilio.Text = dataGridViewProveedor.CurrentRow.Cells["Domicilio"].Value.ToString();
                txtDpto.Text = dataGridViewProveedor.CurrentRow.Cells["Departamento"].Value.ToString();
                txtCodPostal.Text = dataGridViewProveedor.CurrentRow.Cells["Codigo Postal"].Value.ToString();
                txtTelefono.Text = dataGridViewProveedor.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEmail.Text = dataGridViewProveedor.CurrentRow.Cells["Email"].Value.ToString();

                btnModificarProveedor.Enabled = true;
                btnEliminarProveedor.Enabled = true;
                btnGuardarProveedor.Enabled = false;
            }
            else
            {
                BorrarCampos(gbProv);
                btnModificarProveedor.Enabled = false;
                btnEliminarProveedor.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BorrarCampos(gbProv);
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor oProveedor = new Proveedor();
            oProveedor.Prov_Id = Convert.ToInt32(txtId.Text);
            oProveedor.Prov_Nombre = txtNombre.Text;
            oProveedor.Prov_Domicilio = txtDomicilio.Text;
            oProveedor.Prov_Departamento = txtDpto.Text;
            oProveedor.Prov_Codigo_Postal = txtCodPostal.Text;
            oProveedor.Prov_Telefono = txtTelefono.Text;
            oProveedor.Prov_Email = txtEmail.Text;

            GestionComprasModel.modificarProveedor(oProveedor);
            MessageBox.Show("Se modifico exitosamente!");
            dataGridViewProveedor.DataSource = GestionComprasModel.listarProveedor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!txtBuscarNombre.Text.Equals("") || !txtBuscarDpto.Text.Equals(""))
            {
                dataGridViewProveedor.DataSource = GestionComprasModel.buscarProveedor(txtBuscarNombre.Text, txtBuscarDpto.Text);
            }
            else
            {
                MessageBox.Show("Ingrese alguna letra: Nombre ó Departamento");
            }
        }

        private void FrmABMProveedor_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            btnEliminarProveedor.Enabled = false;
            btnModificarProveedor.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrdenarbyNombre_Click(object sender, EventArgs e)
        {
            dataGridViewProveedor.DataSource = GestionComprasModel.traer_proveedor_orden_nombre();
        }
    }
}
