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
    public partial class FrmListarMateriasPrimas : Form
    {
        public FrmListarMateriasPrimas()
        {
            InitializeComponent();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            dataGridViewListasStocks.DataSource = ListarMateriaPrimaModel.listar_materia_prima();
        }

        private void btnSalirListarStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarStock_Click(object sender, EventArgs e)
        {
            if (rbStockMinimo.Checked)
            {
                dataGridViewListasStocks.DataSource = ListarMateriaPrimaModel.listar_stock_minimo();
            }
            if (rbStockDebajo.Checked)
            {
               
                dataGridViewListasStocks.DataSource = ListarMateriaPrimaModel.listar_stock_punto_pedido();
            }
        }


    }
}
