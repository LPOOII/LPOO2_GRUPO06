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
    public partial class FrmCompraRealizada : Form
    {
        public FrmCompraRealizada()
        {
            InitializeComponent();
        }

        private void btnMostrarCompra_Click(object sender, EventArgs e)
        {
            dataGridViewCompraRealizada.DataSource = CompraRealizadaModel.listaComprasRealizadas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCompraRealizada_Load(object sender, EventArgs e)
        {
            //carga y permite traer a todos los Items de orden de compra
            rbSi.Checked = true;
            dataGridViewCompraRealizada.DataSource = CompraRealizadaModel.listaComprasRealizadas();
        }

        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            if (rbSi.Checked)
            {
                dataGridViewCompraRealizada.DataSource = CompraRealizadaModel.buscarFecha(dateTimeFechaCompra1.Value, dateTimeFechaCompra2.Value, 1);
            }
            else if (rbNo.Checked)
            {
                dataGridViewCompraRealizada.DataSource = CompraRealizadaModel.buscarFecha(dateTimeFechaCompra1.Value, dateTimeFechaCompra2.Value, 0);
            }        
        }



       

    }
}
