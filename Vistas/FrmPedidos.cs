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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }
        //Loads
        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            cargarCmbCliente();
            //dgvProductosTerminados.DataSource = PedidoModel.traerProductosTerminados();
            cargarGrillaProductosTerminados();
            create_GridView();
            cmbCliente.Text = "Seleccionar";
            btnModificarCantidad.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //cargar los clientes
        private void cargarCmbCliente()
        {
            cmbCliente.DataSource = PedidoModel.traerClientes();
            cmbCliente.DisplayMember = "cli_nombre";
            cmbCliente.ValueMember = "cli_id";
        }


        //Lista todo los productos terminados en la grilla
        private void cargarGrillaProductosTerminados()
        {
            dgvProductosTerminados.DataSource = PedidoModel.traerProductosTerminados();
        }
        //Agregar productos terminados
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (validarCantidad())
            {
                agregarPedido();
            }
            else
            {
                MessageBox.Show("la cantidad no puede ser 0!", "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Pre-Agregado
        private void agregarPedido()
        {
            btnModificarCantidad.Enabled = true;
            btnEliminar.Enabled = true;


            int total = 0;

            bool errorCantidad = false;

            int actual = Convert.ToInt32(dgvProductosTerminados.CurrentRow.Cells[0].Value.ToString());

            Articulo art = ArticuloModel.traer_id(Convert.ToInt32(dgvProductosTerminados.CurrentRow.Cells[0].Value.ToString()));


            //btnEliminar.Enabled = true;
            if (dgvProductoPedido.RowCount == 1)
            {
                if (art.Art_Stock_Actual >= numericUpDownCantidad.Value)
                {
                    dgvProductoPedido.Rows.Add(dgvProductosTerminados.CurrentRow.Cells[0].Value.ToString(),
                    dgvProductosTerminados.CurrentRow.Cells[1].Value.ToString(),
                    dgvProductosTerminados.CurrentRow.Cells[2].Value.ToString(),
                    numericUpDownCantidad.Value,
                    Convert.ToInt32(dgvProductosTerminados.CurrentRow.Cells[2].Value.ToString()) * numericUpDownCantidad.Value);

                }
                else
                {
                    errorCantidad = true;
                }
            }
            else
            {
                bool encontrado = false;
                //Recorremos el el 2do gridview de Modificar o Cancelar cantidad pedido
                foreach (DataGridViewRow row in dgvProductoPedido.Rows)
                {
                    int nolose = Convert.ToInt32(row.Cells[0].Value);
                    if (nolose == actual)
                    {
                        if (art.Art_Stock_Actual >= (numericUpDownCantidad.Value + Convert.ToInt32(row.Cells[3].Value)))
                        {
                            row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) + numericUpDownCantidad.Value;
                            row.Cells[4].Value = Convert.ToInt32(row.Cells[3].Value) * Convert.ToInt32(row.Cells[2].Value);
                            encontrado = true;
                            break;
                        }
                        else
                        {
                            errorCantidad = true;
                        }
                    }

                }

                if (encontrado == false)
                {   //

                    if (art.Art_Stock_Actual >= numericUpDownCantidad.Value)
                    {
                        dgvProductoPedido.Rows.Add(dgvProductosTerminados.CurrentRow.Cells[0].Value.ToString(),
                        dgvProductosTerminados.CurrentRow.Cells[1].Value.ToString(),
                        dgvProductosTerminados.CurrentRow.Cells[2].Value.ToString(), numericUpDownCantidad.Value,
                        Convert.ToInt32(dgvProductosTerminados.CurrentRow.Cells[2].Value.ToString()) * numericUpDownCantidad.Value);
                    }
                    else
                    {
                        errorCantidad = true;
                    }

                }

            }
            //calculamos el total
            foreach (DataGridViewRow row in dgvProductoPedido.Rows)
            {
                total = Convert.ToInt32(row.Cells[4].Value) + total;
            }



            if (errorCantidad == true)
            {

                MessageBox.Show("La cantidad del articulo para pedido  no debe ser superior al stock actual del mismo.");

            }


            txtTotalPedido.Text = Convert.ToString(total);
        }

        private void create_GridView()
        {
            /*vamos a crear las columnas del gridView con los nonbre que vamos a insertar
              para que se llene la tabla Itmes_Orden_Compra*/

            // Create an unbound DataGridView by declaring a column count.
            dgvProductoPedido.ColumnCount = 5;
            dgvProductoPedido.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            dgvProductoPedido.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.

            dgvProductoPedido.Columns[0].Name = "ID";
            dgvProductoPedido.Columns[1].Name = "Descripcion";
            dgvProductoPedido.Columns[2].Name = "Precio";
            dgvProductoPedido.Columns[3].Name = "Cantidad";
            dgvProductoPedido.Columns[4].Name = "Importe";
        }
        //Guardamos el Pedido
        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                guardarPedido();
            }
            else
            {
                MessageBox.Show("Completar campos!", "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Pre-Guardado
        private void guardarPedido()
        {

            if (dtpFechaEmision.Value > dtpFechaEntrega.Value || dtpFechaEntrega.Value < dtpFechaEmision.Value)
            {
                MessageBox.Show("Error, por favor verifica la fecha de entrega y emision.");
            }
            else
            {
                //bool insertFlag = true;
                //foreach (DataGridViewRow row in dgvProductoPedido.Rows)
                //{
                //    if (row.Cells[0].Value != null)
                //    {
                //        Articulo art = ArticuloModel.traer_id(Convert.ToInt32(row.Cells[0].Value));
                //        if (art.Art_Stock_Actual < Convert.ToInt32(row.Cells[3].Value))
                //        {
                //            insertFlag = false;
                //        }
                //    }
                //}
                //if (insertFlag)
                //{
                Pedido unPedido = new Pedido();
                unPedido.Cli_id = (int)cmbCliente.SelectedValue;
                unPedido.Ped_fecha_emision = dtpFechaEmision.Value;
                unPedido.Ped_fecha_entrega = dtpFechaEntrega.Value;
                unPedido.Ped_facturado = false;
                PedidoModel.insertarPedido(unPedido);

                foreach (DataGridViewRow row in dgvProductoPedido.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        Items_Pedido unItems = new Items_Pedido();
                        //treamos el ultimos registro de pedido
                        Pedido lastPedido = PedidoModel.traerUltimoPedidoInsertado();
                        unItems.Ped_id = Convert.ToInt32(lastPedido.Ped_id);
                        unItems.Art_id = Convert.ToInt32(row.Cells[0].Value);
                        unItems.Precio = Convert.ToInt32(row.Cells[2].Value);
                        unItems.Cantidad = Convert.ToInt32(row.Cells[3].Value);
                        unItems.Importe = Convert.ToInt32(row.Cells[4].Value);
                        //Traeomos el stock actual de articulos
                        Articulo art = ArticuloModel.traer_id(Convert.ToInt32(row.Cells[0].Value));
                        int desc = Convert.ToInt32(art.Art_Stock_Actual) - Convert.ToInt32(row.Cells[3].Value);
                        art.Art_Stock_Actual = desc;
                        //actulizamos el articulos
                        ArticuloModel.update_Articulo(art);
                        //guardamos items pedidos
                        PedidoModel.insertarItemsPedido(unItems);
                    }
                }
               // dgvProductoPedido.DataSource = new DataTable();
                numericCantidadModificar.Value = 0;
                numericUpDownCantidad.Value = 0;
                txtArticuloDescripcion.Text = null;
                txtTotalPedido.Text = null;
                btnModificarCantidad.Enabled = false;
                btnEliminar.Enabled = false;
                dgvProductosTerminados.DataSource = PedidoModel.traerProductosTerminados();
                MessageBox.Show("Guardo Satisfactoriamente!", "Guardar Items_Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("No tiene suficiente stock!", "Por favor revisar la cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
        }
        //Cancelar la cantidad del pedido
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (MessageBox.Show("Estas seguro de Cancelar Producto?", "Cancelar",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                 == DialogResult.Yes)
            {
                int fila = dgvProductoPedido.CurrentRow.Index;
                dgvProductoPedido.Rows.RemoveAt(fila);
                foreach (DataGridViewRow row in dgvProductoPedido.Rows)
                {
                    total = Convert.ToInt32(row.Cells[4].Value) + total;
                }

                if (total == 0)
                {
                    btnModificarCantidad.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                txtTotalPedido.Text = Convert.ToString(total);
            }
        }
        //Modificar la cantidad del pedido
        private void btnModificarCantidad_Click(object sender, EventArgs e)
        {
            int cantidadToUpdate = Convert.ToInt32(numericCantidadModificar.Value);
            int cantidadToModify = Convert.ToInt32(dgvProductoPedido.CurrentRow.Cells["Cantidad"].Value);

            if (cantidadToModify > cantidadToUpdate)
            {

                dgvProductoPedido.CurrentRow.Cells["Cantidad"].Value = cantidadToModify - cantidadToUpdate;
            }
            else
            {
                MessageBox.Show("La cantidad para restar no debe ser igual o mayor a la cantidad actual");
            }
            //calculamos el total
            int total = 0;
            Articulo art = null;
            foreach (DataGridViewRow row in dgvProductoPedido.Rows)
            {
                if(row.Cells[0].Value != null){
                    art = new Articulo();
                    art = ArticuloModel.traer_id(Convert.ToInt32(row.Cells[0].Value));
                    int calc = Convert.ToInt32(row.Cells[3].Value) * Convert.ToInt32(art.Art_Precio);
                    row.Cells[4].Value = calc;
                    total = total + calc;
                }               
            }
            txtTotalPedido.Text = Convert.ToString(total);
        }
        //Buscar  Articulos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtArticuloDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar algun valor, para la busqueda \n" +
                                  "En Descripcion");

                cargarGrillaProductosTerminados();
            }
            else
            {
                dgvProductosTerminados.DataSource = PedidoModel.buscarProducto(txtArticuloDescripcion.Text);
                dgvProductosTerminados.Refresh();
                //esto no es necesario//txtArticuloDescripcion.Text = "";
            }
        }

        private void dgvProductoPedido_CurrentCellChanged(object sender, EventArgs e)
        {
            btnModificarCantidad.Enabled = true;
            btnEliminar.Enabled = true;
        }

        //validar campos vacios
        private bool validarCampos()
        {
            bool valido = false;
            if ((!cmbCliente.Text.Equals("Seleccionar")) && (dgvProductoPedido.RowCount > 1))
            {
                valido = true;
            }
            return valido;
        }

        //validar campo cantidad
        private bool validarCantidad()
        {
            bool valido = false;
            if (numericUpDownCantidad.Value != 0)
            {
                valido = true;
            }
            return valido;
        }

        //Salir
        private void btnSalirPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        



    }
}
