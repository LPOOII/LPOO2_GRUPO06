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
    public partial class AltaUnidaddMedida : Form
    {
        public AltaUnidaddMedida()
        {
            InitializeComponent();
        }

        private void btnCancelarUnidadMedida_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAltaUnidadMedida_Click(object sender, EventArgs e)
        {
            string mostrarDatos;
            Unidad_Medida unidadMedida = new Unidad_Medida();
            //capturamos los datos de los textbox
            unidadMedida.Um_Id = Convert.ToInt32(txtIdUnidadMedida.Text);
            unidadMedida.Um_Descrip = txtUnidadMedidaDescripcion.Text;
            unidadMedida.Um_Abrev = txtUnidadMedidaAbreviacion.Text;
            //mostramos los datos
            mostrarDatos="ALTA DE UNIDAD DE MEDIDAS\n"+
                         "\nId Unidad Medida: "+unidadMedida.Um_Id+"\n"+
                         "\nDescripcion: "+unidadMedida.Um_Descrip+"\n"+
                         "\nAbreviacion: " + unidadMedida.Um_Abrev;
            MessageBox.Show(mostrarDatos);
            this.Close();
        }

        private void btnAltaUnidadMedida_MouseHover(object sender, EventArgs e)
        {
            btnAltaUnidadMedida.ForeColor = Color.Red;
        }

        private void btnAltaUnidadMedida_MouseLeave(object sender, EventArgs e)
        {
            btnAltaUnidadMedida.ForeColor = Color.Black;
        }

        private void btnCancelarUnidadMedida_MouseHover(object sender, EventArgs e)
        {
            btnCancelarUnidadMedida.ForeColor = Color.Red;
        }

        private void btnCancelarUnidadMedida_MouseLeave(object sender, EventArgs e)
        {
            btnCancelarUnidadMedida.ForeColor = Color.Black;
        }
    }
}
