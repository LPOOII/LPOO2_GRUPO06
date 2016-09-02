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
    public partial class FrmOtrosCostos : Form
    {
        public FrmOtrosCostos()
        {
            InitializeComponent();
        }

        private void FrmOtrosCostos_Load(object sender, EventArgs e)
        {
            listarUnidadCombo();
            cmbUnidadID.Text = "Seleccionar";
            cmbBuscarUnidadID.Text = "Seleccionar";
            txtOtrosCostosId.Enabled = false;
            btnModificarOtrosCostos.Enabled = false;
            btnEliminarOtrosCostos.Enabled = false;
        }
        //Mostrar Todo
        private void btnMostrarOtrosCostos_Click(object sender, EventArgs e)
        {
            dataGridViewOtrosCostos.DataSource = OtrosCostosModel.list_costos();
        }

        //Validar campos
        private bool validarCampo()
        {
            bool valido = false;
            if (!txtDescripcion.Text.Equals("") && !cmbUnidadID.Text.Equals("Seleccionar")
                && !txtCosto.Text.Equals("") && !txtObservacion.Text.Equals(""))
            {
                valido = true;
            }
            return valido;
        }
        //guardar otros costos
        private void btnGuardarOtrosCostos_Click(object sender, EventArgs e)
        {
            if (validarCampo())
            {
                Otros_Costos oCosto = new Otros_Costos();
                oCosto.Oc_descrip = txtDescripcion.Text;
                oCosto.Um_id = (int)cmbUnidadID.SelectedValue;
                oCosto.Oc_costo = Convert.ToInt32(txtCosto.Text);
                oCosto.Oc_observaciones = txtObservacion.Text;

                //guardamos costo
                OtrosCostosModel.insert_Costo(oCosto);
                //recargamos el gridview
                dataGridViewOtrosCostos.DataSource = OtrosCostosModel.list_costos();
                //limpiar campos
                cleanTexbox();
                MessageBox.Show("Guardo Exitosamente!", "Guardar Costo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completar campos!", "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Modificar Costo
        private void btnModificarOtrosCostos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOtrosCostosId.Text);
            if (validarCampo())
            {
                Otros_Costos oCosto = new Otros_Costos();
                oCosto.Oc_descrip = txtDescripcion.Text;
                oCosto.Um_id = (int)cmbUnidadID.SelectedValue;
                oCosto.Oc_costo = Convert.ToInt32(txtCosto.Text);
                oCosto.Oc_observaciones = txtObservacion.Text;
                //guardamos costo
                OtrosCostosModel.update_Costo(oCosto, id);

                //recargamos el gridview
                dataGridViewOtrosCostos.DataSource = OtrosCostosModel.list_costos();
                //limpiar campos
                cleanTexbox();
                MessageBox.Show("Modifico Exitosamente!", "Modificar Costo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completar campos!", "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //eliminar costos
        private void btnEliminarOtrosCostos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOtrosCostosId.Text);
            if (MessageBox.Show("Estas seguro de Eliminar?", "Eliminar Costo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                OtrosCostosModel.dalete_Costo(id);
                //recargamos el gridview
                dataGridViewOtrosCostos.DataSource = OtrosCostosModel.list_costos();
                //limpiar campos
                cleanTexbox();
            }
        }
        //Buscar Otros costo
        private void btnBuscarOtrosCostos_Click(object sender, EventArgs e)
        {
            if (cmbBuscarUnidadID.Text.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccione Unidad de Medida");
            }
            else
            {
                
                    dataGridViewOtrosCostos.DataSource = OtrosCostosModel.search_Otro_Costo((int)cmbBuscarUnidadID.SelectedValue);

                    dataGridViewOtrosCostos.Refresh();
                    cmbBuscarUnidadID.Text = "Seleccionar";

                

            }
        }

        //Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanTexbox();
        }

        //Limpia las Cajas de Textos
        private void cleanTexbox()
        {
            txtOtrosCostosId.Text = "";
            txtDescripcion.Text = "";
            cmbUnidadID.Text = "Seleccionar";
            txtCosto.Text = "";
            txtObservacion.Text = "";

            btnModificarOtrosCostos.Enabled = false;
            btnEliminarOtrosCostos.Enabled = false;
            btnGuardarOtrosCostos.Enabled = true;
        }

        private void listarUnidadCombo()
        {
            //DisplayMember:muestra la descripcion.
            cmbUnidadID.DisplayMember = "um_descrip";
            //ValueMember: va a madar el id de refencia.
            cmbUnidadID.ValueMember = "um_id";

            cmbBuscarUnidadID.DisplayMember = "um_descrip";
            cmbBuscarUnidadID.ValueMember = "um_id";
            //DataSource: permite recibir el dataTable que va hacer uso de ese recurso.
            cmbUnidadID.DataSource = OtrosCostosModel.list_Unidades();
            cmbBuscarUnidadID.DataSource = OtrosCostosModel.list_Unidades();

        }

        private void dataGridViewOtrosCostos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewOtrosCostos.CurrentRow != null)
            {
                txtOtrosCostosId.Text = dataGridViewOtrosCostos.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dataGridViewOtrosCostos.CurrentRow.Cells[1].Value.ToString();
                txtCosto.Text = dataGridViewOtrosCostos.CurrentRow.Cells[2].Value.ToString();
                switch (dataGridViewOtrosCostos.CurrentRow.Cells[4].Value.ToString())
                {
                    case "Gramos": cmbUnidadID.SelectedValue = 1; break;
                    case "Kilogramos": cmbUnidadID.SelectedValue = 2; break;
                    case "Litros": cmbUnidadID.SelectedValue = 3; break;
                    case "Unidades": cmbUnidadID.SelectedValue = 4; break;
                    case "Docenas": cmbUnidadID.SelectedValue = 5; break;
                    case "KWH": cmbUnidadID.SelectedValue = 6; break;
                    case "Otras Unidades": cmbUnidadID.SelectedValue = 7; break;
                }

                txtObservacion.Text = dataGridViewOtrosCostos.CurrentRow.Cells[5].Value.ToString();
                btnModificarOtrosCostos.Enabled = true;
                btnEliminarOtrosCostos.Enabled = true;
                btnGuardarOtrosCostos.Enabled = false;
            }
        }

        private void btnSalirOtrosCostos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            cleanTexbox();
        }

        //Eventos del mousehover y mouseleave
        private void btnGuardarOtrosCostos_MouseHover(object sender, EventArgs e)
        {
            btnGuardarOtrosCostos.ForeColor = Color.Red;
        }

        private void btnGuardarOtrosCostos_MouseLeave(object sender, EventArgs e)
        {
            btnGuardarOtrosCostos.ForeColor = Color.Black;
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.Red;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.ForeColor = Color.Black;
        }


    }
}
