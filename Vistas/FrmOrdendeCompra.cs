using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Data.SqlClient;
namespace Vistas
{
    public partial class FrmOrdendeCompra : Form
    {
        public FrmOrdendeCompra()
        {
            InitializeComponent();
        }

        //traer la lista del combo de proveedores: Model de la clase OrdenCompraModel
        private void traerListaComboProveedores()
        {
            //DisplayMember:muestra la descripcion.
            cmbProveedor.DisplayMember = "prov_nombre";
            //ValueMember: va a mandar el id de refencia.
            cmbProveedor.ValueMember = "prov_id";
            //DataSource: permite recibir el dataTable que va hacer uso de ese recurso.
            cmbProveedor.DataSource = OrdenCompraModel.listarProveedor();

        }

        //traer la lista del combo de proveedores: Model de la clase OrdenCompraModel
        private void traerListaComboArticulos()
        {        

            cmbArticuloId.DataSource = OrdenCompraModel.listarArticulo();
            cmbArticuloId.DisplayMember = "art_id";
            cmbArticuloId.ValueMember = "art_id";
       
            cmbDescripcion.DataSource = cmbArticuloId.DataSource;
            cmbDescripcion.DisplayMember = "art_descrip";          
            cmbDescripcion.ValueMember = "art_costo";

        }

        //load
        private void FrmOrdendeCompra_Load(object sender, EventArgs e)
        {
            
            cmbArticuloId.Enabled = false;
            dataGridViewItemsCompras.AllowUserToAddRows = false;           

            traerListaComboProveedores();
            
            traerListaComboArticulos();
                 
            create_GridView();
            cmbDescripcion.Text = "Seleccionar";
            cmbProveedor.Text = "Seleccionar";

            cmbArticuloId.Text = "Seleccionar";
        }


        //Crear Grilla
        private void create_GridView()
        {
            /*vamos a crear las columnas del gridView con los nombre que vamos a insertar
              para que se llene la tabla Itmes_Orden_Compra*/

            // Create an unbound DataGridView by declaring a column count.
            dataGridViewItemsCompras.ColumnCount = 4;
            dataGridViewItemsCompras.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridViewItemsCompras.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            
            dataGridViewItemsCompras.Columns[0].Name = "Costo";
            dataGridViewItemsCompras.Columns[1].Name = "Cantidad";
            dataGridViewItemsCompras.Columns[2].Name = "Importe";
            dataGridViewItemsCompras.Columns[3].Name = "Articulo";
        }
        
        //boton agrega items al datagrid
        private void btnAgregar_Click(object sender, EventArgs e)
        {                
              if (cmbArticuloId.Text != string.Empty && txtCosto.Text != string.Empty
                  && numericUpDownCantidad.Value != 0 && txtImporte.Text != string.Empty)
              {

                  dataGridViewItemsCompras.Rows.Add(txtCosto.Text, numericUpDownCantidad.Value
                      , txtImporte.Text, cmbArticuloId.Text);
                  
                  Articulo unArt = new Articulo();
                  Articulo ar = ArticuloModel.traer_id(Convert.ToInt32(cmbArticuloId.Text));
                  decimal cantidad = Convert.ToDecimal(numericUpDownCantidad.Value);
                  decimal costo = Convert.ToDecimal(txtCosto.Text);              

                  //Actualizando el articulo
                  unArt.Art_Id = ar.Art_Id;
                  unArt.Art_Descrip = ar.Art_Descrip;
                  unArt.Fam_Id = ar.Fam_Id;
                  unArt.Um_Id = ar.Um_Id;
                  unArt.Art_Costo = costo;
                  unArt.Art_Stock_Min = ar.Art_Stock_Min;
                  unArt.Art_Stock_Max = ar.Art_Stock_Max;
                  unArt.Art_Precio = ar.Art_Precio;
                  unArt.Art_Stock_Reposicion = ar.Art_Stock_Reposicion;
                  unArt.Art_Stock_Actual = ar.Art_Stock_Actual + cantidad;
                  unArt.Art_Margen_Beneficio = ar.Art_Margen_Beneficio;
                  //
                  unArt.Art_Maneja_Stock = ar.Art_Maneja_Stock;
                  //
                  OrdenCompraModel.actualizar_stock(unArt);

                  cmbDescripcion.Text = "Seleccionar";
                  numericUpDownCantidad.Value = 0;
                  txtCosto.Text = "";
                  cmbArticuloId.Text = "Seleccionar";
              }
              else
              {
                  MessageBox.Show("Completar todos los campos!",
                      "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
            

        }
        //modulo registra una orden de compra
        public void cargar_orden_compra()
        {
            Orden_Compra oOrdenCompra = new Orden_Compra();
            oOrdenCompra.Prov_Id = (int)cmbProveedor.SelectedValue;
            oOrdenCompra.Oc_fecha = DateTime.Today;
            oOrdenCompra.Pagada = false;

            OrdenCompraModel.insertarOrdenCompra(oOrdenCompra);
        }
        //carga items de orden de compra
        public void cargar_items_orden_compra()
        {
            SqlConnection cnn = OrdenCompraModel.cn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Items_Orden_Compra(costo,cantidad,importe,oc_id,art_id) values(@cost,@cant,@imp,@oc,@art)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            foreach (DataGridViewRow row in dataGridViewItemsCompras.Rows)
            {
                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@cost", Convert.ToDecimal(row.Cells["Costo"].Value));
                cmd.Parameters.AddWithValue("@cant", Convert.ToDecimal(row.Cells["Cantidad"].Value));
                cmd.Parameters.AddWithValue("@imp", Convert.ToDecimal(row.Cells["Importe"].Value));
                cmd.Parameters.AddWithValue("@art", Convert.ToInt32(row.Cells["Articulo"].Value));

                cmd.Parameters.AddWithValue("@oc", OrdenCompraModel.getIdenty());                               

                cmd.ExecuteNonQuery();
            }
            cnn.Close();
            
        }
        //boton que agrega al proveedor y orden de compra
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.Text.Equals("Seleccionar"))
            {
                MessageBox.Show("Intente de nuevo, debe seleccionar un item del combo proveedor");
            }
            else
            {
              
                
                    cargar_orden_compra();
                    cargar_items_orden_compra();
                    dataGridViewItemsCompras.DataSource = "";
                    dataGridViewItemsCompras.DataSource = null;
                    cmbProveedor.Text = "Seleccionar";
                    MessageBox.Show("Se guardo exitosamente!");
               
            }
           
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
           
            if (cmbArticuloId.Text != string.Empty && txtCosto.Text != string.Empty)
            {
                decimal p = Convert.ToDecimal(txtCosto.Text);
                txtImporte.Text = (Convert.ToDecimal(numericUpDownCantidad.Value) * p).ToString();
            }
            else
            {
                numericUpDownCantidad.Value = 0;
                MessageBox.Show("debe elegir al menos una opcion del combo descripcion");
                
            }
        }

       
        private void cmbDescripcion_SelectionChangeCommitted(object sender, EventArgs e)
        {

            txtCosto.Text = cmbDescripcion.SelectedValue.ToString();
            
            numericUpDownCantidad.Value = 0;
            txtImporte.Text = "";
            if (cmbArticuloId.Text.Equals("Seleccionar"))
            {
                cmbArticuloId.Text = Convert.ToString(cmbArticuloId.SelectedValue);
            }
        }

        private void cmbArticuloId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCosto.Text = cmbDescripcion.SelectedValue.ToString();
            txtCosto.Refresh();
        }
        //boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                        

    }
}
