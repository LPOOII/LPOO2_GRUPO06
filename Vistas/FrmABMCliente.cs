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
    public partial class FrmABMCliente : Form
    {
        public FrmABMCliente()
        {
            InitializeComponent();
        }
       
        //loads
        private void FrmABMCliente_Load(object sender, EventArgs e)
        {
            txtClienteId.Enabled = false;
            btnModificarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
        }


        //Eventos del mousehover y mouseleave
        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardarCliente.ForeColor = Color.Red;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardarCliente.ForeColor = Color.Black;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.Red;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.Black;
        }
        //mostrar todo
        private void btnMostrarCliente_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = ClienteModel.list_clientes();
        }

        //Validar campos
        private bool validarCampo()
        {
            bool valido = false;
            if (!txtNombre.Text.Equals("") && !txtDomicilio.Text.Equals("") && !txtDepartamento.Text.Equals("")
                && !txtCodigoPostal.Text.Equals("") && !txtTelefono.Text.Equals("") && !txtEmail.Text.Equals("") && !dateTimeFecha.Text.Equals(""))
            {
                valido = true;
            }
            return valido;
        }
        //Guardar Cliente
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (validarCampo())
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Domicilio = txtDomicilio.Text;
                oCliente.Cli_Departamento = txtDepartamento.Text;
                oCliente.Cli_Codigo_Postal = txtCodigoPostal.Text;
                oCliente.Cli_Telefono = txtTelefono.Text;
                oCliente.Cli_Email = txtEmail.Text;
                oCliente.Cli_Fecha_Nac = dateTimeFecha.Value;
                //guardamos el cliente
                ClienteModel.insert_Cliente(oCliente);
                //recargamos el gridview
                dataGridViewClientes.DataSource = ClienteModel.list_clientes();
                //limpiar campos
                cleanTexbox();
                MessageBox.Show("Guardo Exitosamente!", "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completar campos!", "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //modificar
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtClienteId.Text);
            if (validarCampo())
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Domicilio = txtDomicilio.Text;
                oCliente.Cli_Departamento = txtDepartamento.Text;
                oCliente.Cli_Codigo_Postal = txtCodigoPostal.Text;
                oCliente.Cli_Telefono = txtTelefono.Text;
                oCliente.Cli_Email = txtEmail.Text;
                oCliente.Cli_Fecha_Nac = dateTimeFecha.Value;
                //guardamos el cliente
                ClienteModel.update_Cliente(oCliente, id);
                //recargamos el gridview
                dataGridViewClientes.DataSource = ClienteModel.list_clientes();
                //limpiar campos
                cleanTexbox();
                MessageBox.Show("Modifico Exitosamente!", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completar campos!", "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //eliminar
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtClienteId.Text);
            if (MessageBox.Show("Estas seguro de Eliminar?", "Eliminar Cliente",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClienteModel.dalete_Cliente(id);
                //recargamos el gridview
                dataGridViewClientes.DataSource = ClienteModel.list_clientes();
                //limpiar campos
                cleanTexbox();
            }
        }
        //buscar
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //buscamos pro nombre o domicilio
            if (!txtBuscarNombreClie.Text.Equals("") || !txtBuscarDomicilioClie.Text.Equals(""))
            {
                dataGridViewClientes.DataSource = ClienteModel.search_cliente(txtBuscarNombreClie.Text, txtBuscarDomicilioClie.Text);
            }
            else
            {
                MessageBox.Show("Ingrese: Nombre ó Domicilio", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Carga los datos del gridview  a los textBox
        private void dataGridViewClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow != null)
            {
                txtClienteId.Text = dataGridViewClientes.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dataGridViewClientes.CurrentRow.Cells["Cliente"].Value.ToString();
                txtDomicilio.Text = dataGridViewClientes.CurrentRow.Cells["Domicilio"].Value.ToString();
                txtDepartamento.Text = dataGridViewClientes.CurrentRow.Cells["Departamento"].Value.ToString();
                txtCodigoPostal.Text = dataGridViewClientes.CurrentRow.Cells["Codigo Postal"].Value.ToString();
                txtEmail.Text = dataGridViewClientes.CurrentRow.Cells["Email"].Value.ToString();
                txtTelefono.Text = dataGridViewClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                dateTimeFecha.Text = dataGridViewClientes.CurrentRow.Cells["Fecha Nacimiento"].Value.ToString();

                btnModificarCliente.Enabled = true;
                btnEliminarCliente.Enabled = true;
                btnGuardarCliente.Enabled = false;
            }
        }
        //limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanTexbox();
        }

        private void cleanTexbox()
        {
            txtClienteId.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtDepartamento.Text = "";
            txtCodigoPostal.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            dateTimeFecha.Text = "01/01/1980";

            btnModificarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
            btnGuardarCliente.Enabled = true;
        }
        //salir
        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        
        
    }
}
