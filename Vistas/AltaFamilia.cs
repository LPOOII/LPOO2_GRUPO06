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
    public partial class AltaFamilia : Form
    {
        public AltaFamilia()
        {
            InitializeComponent();
        }
        //boton cancelar 
        private void btnCancelarFamilia_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
      

        private void btnAltaFamilia_MouseHover(object sender, EventArgs e)
        {
            btnAltaFamilia.ForeColor = Color.Red;
        }

        private void btnAltaFamilia_MouseLeave(object sender, EventArgs e)
        {
            btnAltaFamilia.ForeColor = Color.Black;
        }

        private void btnCancelarFamilia_MouseHover(object sender, EventArgs e)
        {
            btnCancelarFamilia.ForeColor = Color.Red;
        }

        private void btnCancelarFamilia_MouseLeave(object sender, EventArgs e)
        {
            btnCancelarFamilia.ForeColor = Color.Black;
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            dgvFamilia.DataSource = FamiliaModel.traer_familia();
            btnModificar.Enabled = false;
            btnAltaFamilia.Enabled = true;
            btnEliminar.Enabled = false;
            txtFamiliaDescripcion.Text = "";
            txtID.Text = "";
            txtID.Enabled = false;
        }

        private void dgvFamilia_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvFamilia.CurrentRow != null)
            {
                txtFamiliaDescripcion.Text = dgvFamilia.CurrentRow.Cells["fam_descrip"].Value.ToString();
                txtID.Text = dgvFamilia.CurrentRow.Cells["fam_id"].Value.ToString();
                btnModificar.Enabled = true;
                btnAltaFamilia.Enabled = false;
                btnEliminar.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            txtFamiliaDescripcion.Text = "";
            txtID.Text = "";
            btnAltaFamilia.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //boton Alta de familia
        private void btnAltaFamilia_Click(object sender, EventArgs e)
        {
            Familia unaFamilia = new Familia();
            unaFamilia.Fam_Descrip = txtFamiliaDescripcion.Text;

            FamiliaModel.insertar_familia(unaFamilia);
            dgvFamilia.DataSource = FamiliaModel.traer_familia();

            clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Familia unaFamilia = new Familia();
            unaFamilia.Fam_Descrip = txtFamiliaDescripcion.Text;
            unaFamilia.Fam_Id = Convert.ToInt32(txtID.Text);
            FamiliaModel.update_familia(unaFamilia);
            dgvFamilia.DataSource = FamiliaModel.traer_familia();
            clear();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Familia unaFamilia = new Familia();
            unaFamilia.Fam_Descrip = txtFamiliaDescripcion.Text;
            unaFamilia.Fam_Id = Convert.ToInt32(txtID.Text);
            FamiliaModel.delete_familia(unaFamilia);
            dgvFamilia.DataSource = FamiliaModel.traer_familia();
            clear();
        }


    }
}
