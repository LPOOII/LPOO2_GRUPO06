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
    public partial class FrmListarProductosTerminados : Form
    {
        public FrmListarProductosTerminados()
        {
            InitializeComponent();
        }

        private void btnMostrarProductosTerminados_Click(object sender, EventArgs e)
        {
            dgvProductosTerminados.DataSource = ListarProductosTerminadosModel.listar_producto_terminado();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
