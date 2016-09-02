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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }
        //Loads
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            combo_pedido();
            combo_forma_pago();
            cmbPedidos.Text = "Seleccionar";
            cmbFormaPago.Text = "Seleccionar";
            lblImporteFactura.Text = "0";
        }

        private void combo_pedido()
        {
            cmbPedidos.DisplayMember = "ped_id";
            cmbPedidos.ValueMember = "ped_id";
            cmbPedidos.DataSource = VentasModel.listar_pedido();
        }

        private void combo_forma_pago()
        {
            cmbFormaPago.DisplayMember = "fp_descrip";
            cmbFormaPago.ValueMember = "fp_id";
            cmbFormaPago.DataSource = VentasModel.traer_Form_Pago();
        }
        //Cuando se haga click en combo Pedido se mostrara los datos del cliente
        private void cmbPedidos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id_pedido = Convert.ToInt32(cmbPedidos.SelectedValue);
            //traemos importe total de Items_Pedido con todo sus datos
            decimal importeTotal = VentasModel.get_ImporteTotal(id_pedido);
            lblImporteFactura.Text = "$ " + importeTotal.ToString();

            //traemos cliente con todo sus datos
            Cliente cliente = VentasModel.traer_Cliente(id_pedido);
            lblCliente.Text = cliente.Cli_Nombre.ToString();
            lblTelefono.Text = Convert.ToString(cliente.Cli_Telefono);
            lblEmail.Text = Convert.ToString(cliente.Cli_Email);

            //traemos el ultimo nro de factura para mostrar
            
            if (VentasModel.get_id_Factura() == null)
            {
                Factura x = new Factura();
                x.Fac_numero = 0;
                Factura nroFactura = x;
                lblNroFactura.Text = Convert.ToString(nroFactura.Fac_numero + 1);
               
            }
            else
            {
                Factura nroFactura = VentasModel.get_id_Factura();
                lblNroFactura.Text = Convert.ToString(nroFactura.Fac_numero + 1);
            }

            //gridview: mostramos el o los pedido que realizado el cliente
            dgvArticuloPedido.DataSource = VentasModel.traer_Articulo_pedido((int)cmbPedidos.SelectedValue);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                //llama al metodo guardar
                guardarFactura();
                //recargar el comboBox de pedido
                combo_pedido();
                //limpiamos los campos una ves guardado
                limpiarCampos();
                MessageBox.Show("Guardo exitosamente\nla Factura!", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completar Campos!", "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Guardar Factura
        private void guardarFactura()
        {

            int id_pedido = Convert.ToInt32(cmbPedidos.SelectedValue);
            //traemos el pedido con todo sus datos
            Pedido pedido = VentasModel.traer_pedido(id_pedido);
            pedido.Ped_facturado = true;

            //Actualizamos pedidoFacturado
            VentasModel.update_Pedido(pedido, id_pedido);

            //traemos el cliente con todo sus datos 
            Cliente oClietne = VentasModel.traer_Cliente((int)cmbPedidos.SelectedValue);
            Factura factura = new Factura();
            if (VentasModel.get_id_Factura() == null)
            {
                Factura x = new Factura();
                x.Fac_numero = 0;

                //factura , primer vuelta

                factura.Ped_id = Convert.ToInt32(cmbPedidos.SelectedValue);
                factura.Cli_id = oClietne.Cli_Id;
                factura.Fac_numero = x.Fac_numero + 1;
                factura.Fac_fecha = DateTime.Now;
                factura.Fp_id = Convert.ToInt32(cmbFormaPago.SelectedValue);
            }
            else
            {
                //traemos el ultimo nro de factura
                Factura nroFactura = VentasModel.get_id_Factura();
                //factura

                factura.Ped_id = Convert.ToInt32(cmbPedidos.SelectedValue);
                factura.Cli_id = oClietne.Cli_Id;
                factura.Fac_numero = nroFactura.Fac_numero + 1;
                factura.Fac_fecha = DateTime.Now;
                factura.Fp_id = Convert.ToInt32(cmbFormaPago.SelectedValue);
            }



            //guardar factura
            VentasModel.insert_Factura(factura);
            //MessageBox.Show("Guardo exitosamente\nla Factura!", "Guardar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //instaciamos el objeto itemsFactura
            Items_Factura items_Factura = new Items_Factura();
            foreach (DataGridViewRow unaFila in dgvArticuloPedido.Rows)
            {
                //traer el ultimo registro de factura su id 
                Factura unaFactura = VentasModel.get_id_Factura();

                //importe acumulado
                decimal total = VentasModel.get_ImporteTotal((int)cmbPedidos.SelectedValue);
                lblImporteFactura.Text = Convert.ToDecimal(total).ToString();

                items_Factura.Fac_id = unaFactura.Fac_id;
                items_Factura.Art_id = Convert.ToInt32(unaFila.Cells[0].Value.ToString());
                items_Factura.Precio = Convert.ToInt32(unaFila.Cells[2].Value.ToString());
                items_Factura.Cantidad = Convert.ToInt32(unaFila.Cells[3].Value.ToString());
                items_Factura.Importe = items_Factura.Precio * items_Factura.Cantidad;

                //guardamos insert_Items_Factura
                VentasModel.insert_Items_Factura(items_Factura);
                //MessageBox.Show("Guardo satisfactoriamente\nla Items_Factura!", "Guardar Items_Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //id de Articulo traido del gridview
                int id = Convert.ToInt32(unaFila.Cells[0].Value.ToString());
                //traemos el articulo con todo sus datos
                Articulo article = ArticuloModel.traer_id(id);

                //instaciamos un nuevo articulo
                Articulo articulo = new Articulo();
                articulo.Art_Stock_Actual = article.Art_Stock_Actual - items_Factura.Cantidad;
                //actualizamos el stock actual de articulos
                VentasModel.update_Articulo_Pedido(articulo, id);

            }//end-foreach
        }

        //Validar campos vacios
        private bool validar()
        {

            bool campoVacio = false;
            if (!cmbPedidos.Text.Equals("Seleccionar") && !cmbFormaPago.Text.Equals("Seleccionar"))
            {
                campoVacio = true;
            }

            return campoVacio;
        }

        //Limpiar los comboBox y labels
        private void limpiarCampos()
        {
            lblNroFactura.Text = "0";
            lblImporteFactura.Text = "0";
            cmbFormaPago.Text = "Seleccionar";
            cmbPedidos.Text = "Seleccionar";
            dgvArticuloPedido.DataSource = null;
            //datos del cliente
            lblCliente.Text = "cliente";
            lblTelefono.Text = "000-000-000";
            lblEmail.Text = "cliente@gmail.com";
        }
    }
}
