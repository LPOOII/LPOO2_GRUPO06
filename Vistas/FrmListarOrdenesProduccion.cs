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
    public partial class FrmListarOrdenesProduccion : Form
    {
        public FrmListarOrdenesProduccion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvOrdenProduccion.DataSource = ListarOrdenProduccionModel.orden_produccion_fecha(dtpFechaDesde.Value, dtpFechaHasta.Value); 
        }

        private void FrmListarOrdenesProduccion_Load(object sender, EventArgs e)
        {
            dgvOrdenProduccion.DataSource = ListarOrdenProduccionModel.traer_orden_produccion();
        }

    }
}
