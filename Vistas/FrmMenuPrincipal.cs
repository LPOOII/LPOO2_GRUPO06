using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();                   
                switch (Program.userValido.Rol_Id)
                {
                    case 2:
                        comprasToolStripMenuItem.Visible = false;
                        produccionToolStripMenuItem.Visible = false;
                        ventasToolStripMenuItem.Visible = false;
                        usuariosToolStripMenuItem.Visible = false;
                        ///MessageBox.Show("" + Program.userValido.Rol_Id);
                        break;
                    case 3:
                        stockYArticulosToolStripMenuItem.Visible = false;
                        //produccionToolStripMenuItem.Visible = false;
                        comprasToolStripMenuItem.Visible = false;
                        ventasToolStripMenuItem.Visible = false;
                        usuariosToolStripMenuItem.Visible = false;
                        break;
                    case 4:
                        stockYArticulosToolStripMenuItem.Visible = false;
                        produccionToolStripMenuItem.Visible = false;
                        
                        ventasToolStripMenuItem.Visible = false;
                        usuariosToolStripMenuItem.Visible = false;
                        break;
                    case 5:
                        stockYArticulosToolStripMenuItem.Visible = false;
                        produccionToolStripMenuItem.Visible = false;
                        comprasToolStripMenuItem.Visible = false;
                        
                        usuariosToolStripMenuItem.Visible = false;
                        break;
                    case 6:
                        stockYArticulosToolStripMenuItem.Visible = false;
                        produccionToolStripMenuItem.Visible = false;
                        
                        usuariosToolStripMenuItem.Visible = false;
                        break;
                    default:
                        break;
                }
            
           
        }
        private void aMBUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMUsuario oFrmABMUsuario = new FrmABMUsuario();

            oFrmABMUsuario.ShowDialog();
        }

        private void aMBClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMCliente oFrmABMClienteVentas = new FrmABMCliente();
            oFrmABMClienteVentas.ShowDialog();
        }

        /*****************/
       

       
       
       

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void aBMProveedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmABMProveedor oFrmABMProveedor = new FrmABMProveedor();
            oFrmABMProveedor.ShowDialog();
        }

        private void aBMStockyArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMStockyArticulo oFrmABMStockArticulos = new FrmABMStockyArticulo();
            oFrmABMStockArticulos.ShowDialog();
        }

        private void aBMProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionProduccion oFrmGestionProduccion = new FrmGestionProduccion();
            oFrmGestionProduccion.ShowDialog();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Quiere salir del Sistema?", "Sistema de Pasteleria",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void altaFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AltaFamilia oAltaFamilia = new AltaFamilia();
            oAltaFamilia.ShowDialog();
        }

        private void altaUnidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUnidaddMedida oAltaUnidadMedida = new AltaUnidaddMedida();
            oAltaUnidadMedida.ShowDialog();
        }

        private void cOMPRASREALIZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompraRealizada oFrmCompraRealizada = new FrmCompraRealizada();
            oFrmCompraRealizada.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdendeCompra oFrmOrdendeCompra = new FrmOrdendeCompra();

            oFrmOrdendeCompra.ShowDialog();
        }







        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Fenix Soft ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void listarMateriasPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarMateriasPrimas oFrmListarMateriasPrimas = new FrmListarMateriasPrimas();
            oFrmListarMateriasPrimas.ShowDialog();
        }

        private void listarProductosTerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarProductosTerminados oFrmListarProductosTerminados = new FrmListarProductosTerminados();
            oFrmListarProductosTerminados.ShowDialog();
        }

        

        private void listarOrdenesDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarOrdenesProduccion oFrmListarOrdenesProduccion = new FrmListarOrdenesProduccion();
            oFrmListarOrdenesProduccion.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos oFrmPedidos = new FrmPedidos();
            oFrmPedidos.ShowDialog();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVentas oFrmVentas = new FrmVentas();
            oFrmVentas.ShowDialog();
        }

        private void gestiónDePagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGestionPago oFrmGestionPago = new FrmGestionPago();
            oFrmGestionPago.ShowDialog();
        }

        private void gestiónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionProducto oFrmGestionProducto = new FrmGestionProducto();
            oFrmGestionProducto.ShowDialog();
        }

        private void listarOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenesCompra oFrmOrdenesCompra = new FrmOrdenesCompra();
            oFrmOrdenesCompra.ShowDialog();
        }

        private void listarOrdenesDePagoRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenesdePagos oFrmOrdenesdePagos = new FrmOrdenesdePagos();
            oFrmOrdenesdePagos.ShowDialog();
        }

        private void listarPedidosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarPedidos oFrmListarPedidos = new FrmListarPedidos();
            oFrmListarPedidos.ShowDialog();
        }

        private void listarVentasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarVentas oFrmListarVentas = new FrmListarVentas();
            oFrmListarVentas.ShowDialog();
        }

        private void aBMOtrosCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOtrosCostos oFrmOtrosCostos = new FrmOtrosCostos();
            oFrmOtrosCostos.ShowDialog();
        }

        private void acercaDeSistPateleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAyuda oFrmAyuda = new FrmAyuda();
            oFrmAyuda.ShowDialog();
        }

       

      

       

        

        
        


     }
}
