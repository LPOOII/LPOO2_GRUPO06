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

using System.Data.SqlClient;

namespace Vistas
{
    public partial class FrmGestionProducto : Form
    {
        public FrmGestionProducto()
        {
            InitializeComponent();
        }
        //traemos los datos para mostrarlo en el combo de productos terminados
        public void traer_lista_productos()
        {
            cmbProductoTerminado.DataSource = GestionProductoModel.traer_articulos();
            cmbProductoTerminado.DisplayMember = "art_descrip";//
            cmbProductoTerminado.ValueMember = "art_id";//

        }
        //traemos los datos para mostrarlo en el combo de materia prima
        private void traerListaMateriaPrima()
        {
            cmbArticuloId.DataSource = GestionProductoModel.traer_articulos_todo();
            cmbArticuloId.DisplayMember = "art_id";
            cmbArticuloId.ValueMember = "art_id";

            cmbDescripcion.DataSource = cmbArticuloId.DataSource;
            cmbDescripcion.DisplayMember = "art_descrip";            
            cmbDescripcion.ValueMember = "art_costo";

           
        }
        //traemos los datos para mostrarlo en el combo de otros costos {}{}{}{}
        private void traerListaOtrosCostos()
        {
            cmbOcId.DataSource = GestionProductoModel.traer_otroscostos_todo();
            cmbOcId.DisplayMember = "oc_id";
            cmbOcId.ValueMember = "oc_id";

            cmbDescripcionOc.DataSource = cmbOcId.DataSource;
            cmbDescripcionOc.DisplayMember = "oc_descrip";
            cmbDescripcionOc.ValueMember = "oc_costo";

          
        }

        private void FrmGestionProducto_Load(object sender, EventArgs e)
        {
            //cargamos automaticamente los combos productos, materia prima y otros costos y 2 datagrid
            traer_lista_productos();
            traerListaMateriaPrima();
            cmbArticuloId.Enabled = false;

            dgvItemsMateriaPrima.AllowUserToAddRows = false;
            dgvItemsOtrosCostos.AllowUserToAddRows = false;
            create_GridView1();
            traerListaOtrosCostos();
            cmbOcId.Enabled = false;
            create_GridView2();
            cmbProductoTerminado.Text = "Seleccionar";
        }
        //de acuerdo algun cambio del combo descripcion se actualizara el contendio del costo
        private void cmbDescripcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCosto.Text = Convert.ToString(cmbDescripcion.SelectedValue);
            txtCosto.Refresh();
        }
        //carga una cantidad
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
        //primer datagrid creado
        private void create_GridView1()
        {
            dgvItemsMateriaPrima.ColumnCount = 4;
            dgvItemsMateriaPrima.ColumnHeadersVisible = true;
           
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvItemsMateriaPrima.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dgvItemsMateriaPrima.Columns[0].Name = "Costo";
            dgvItemsMateriaPrima.Columns[1].Name = "Cantidad";
            dgvItemsMateriaPrima.Columns[2].Name = "Importe";
            dgvItemsMateriaPrima.Columns[3].Name = "Articulo";
        }
        //segundo datagrid creado
        private void create_GridView2()
        {
            dgvItemsOtrosCostos.ColumnCount = 4;
            dgvItemsOtrosCostos.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvItemsOtrosCostos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dgvItemsOtrosCostos.Columns[0].Name = "Costo";
            dgvItemsOtrosCostos.Columns[1].Name = "Cantidad";
            dgvItemsOtrosCostos.Columns[2].Name = "Importe";
            dgvItemsOtrosCostos.Columns[3].Name = "Otros Costos";
        }
        //variable para el calculo total de materias primas
        decimal total_materia_prima = 0;
       
        //boton q agrega materia prima
       
        private void btnAgregarMateriaPrima_Click(object sender, EventArgs e)
        {
            //decimal total_materia_prima = 0;
            if (cmbArticuloId.Text != string.Empty && txtCosto.Text != string.Empty
                  && numericUpDownCantidad.Value != 0 && txtImporte.Text != string.Empty)
            {
                //cargamos al datagrid datasource materias primas
                dgvItemsMateriaPrima.Rows.Add(txtCosto.Text, numericUpDownCantidad.Value
                    , txtImporte.Text, cmbArticuloId.Text);


               
                //se va calculando o sumando el total de materia prima
                total_materia_prima = total_materia_prima + Convert.ToDecimal(txtImporte.Text);
                MessageBox.Show("total materia prima: " + total_materia_prima);

                numericUpDownCantidad.Value = 0;
                txtCosto.Text = "";
                
            }
            else
            {
                MessageBox.Show("Completar todos los campos!",
                    "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        //variable para el calculo total de otros costos
        decimal total_otros_costos = 0;
       
        //boton q agrega otros costos
        private void btnAgregarOtrosCostos_Click(object sender, EventArgs e)
        {
            if (cmbOcId.Text != string.Empty && txtOtrosCostos.Text != string.Empty
                  && nupdOtrosCostos.Value != 0 && txtImporteOc.Text != string.Empty)
            {
                //cargamos al datagrid datasource otros costos
                dgvItemsOtrosCostos.Rows.Add(txtOtrosCostos.Text, nupdOtrosCostos.Value
                    , txtImporteOc.Text, cmbOcId.Text);

                

                //se va calculando o sumando el total de otros costos
                total_otros_costos = total_otros_costos + Convert.ToDecimal(txtImporteOc.Text);
                MessageBox.Show("total otros costos: " + total_otros_costos);
                nupdOtrosCostos.Value = 0;
                txtOtrosCostos.Text = "";
            }
            else
            {
                MessageBox.Show("Completar todos los campos!",
                    "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //carga un producto
        public void cargar_producto()
        {
            Producto unProducto = new Producto();
            unProducto.Total_Materia_Prima = total_materia_prima;
            unProducto.Total_Otros_Costos = total_otros_costos;
            unProducto.Costo_Final = total_materia_prima + total_otros_costos;
            unProducto.Art_Id = Convert.ToInt32(cmbProductoTerminado.SelectedValue);
            MessageBox.Show("total materia prima: "+ total_materia_prima);
            MessageBox.Show("total otros costos: " + total_otros_costos);
            MessageBox.Show("costo total: " + unProducto.Costo_Final);
            //se carga un producto a la BD
            GestionProductoModel.insertar_producto(unProducto); //
        }

        //carga items de materia prima
        public void cargar_items_materia_prima()
        {
            SqlConnection cnn = GestionProductoModel.cn();
            SqlCommand cmd = new SqlCommand();
            //carga los items materia prima a la BD
            
            cmd.CommandText = "ProductoAgregarItemsMateriaPrima";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cnn.Open();
            //se recorre el datagrid items de materia prima
            foreach (DataGridViewRow row in dgvItemsMateriaPrima.Rows)
            {
                cmd.Parameters.Clear();               
                cmd.Parameters.AddWithValue("@cost", Convert.ToDecimal(row.Cells["Costo"].Value));
                cmd.Parameters.AddWithValue("@cant", Convert.ToDecimal(row.Cells["Cantidad"].Value));
                cmd.Parameters.AddWithValue("@imp", Convert.ToDecimal(row.Cells["Importe"].Value));
                cmd.Parameters.AddWithValue("@art", Convert.ToInt32(row.Cells["Articulo"].Value));
                cmd.Parameters.AddWithValue("@pro", GestionProductoModel.getIdenty());                
                cmd.ExecuteNonQuery();
            }
            cnn.Close();
        }
        //carga items de otros costos
        public void cargar_items_otros_costos()
        {
            SqlConnection cnn = GestionProductoModel.cn();
            SqlCommand cmd = new SqlCommand();
            //carga los items de otros costos a la BD
          
            cmd.CommandText = "ProductoAgregarItemsOtrosCostos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cnn.Open();
            //se recorre el datagrid items de otros costos
            foreach (DataGridViewRow row in dgvItemsOtrosCostos.Rows)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cost", Convert.ToDecimal(row.Cells["Costo"].Value));
                cmd.Parameters.AddWithValue("@cant", Convert.ToDecimal(row.Cells["Cantidad"].Value));
                cmd.Parameters.AddWithValue("@imp", Convert.ToDecimal(row.Cells["Importe"].Value));
                cmd.Parameters.AddWithValue("@oc", Convert.ToInt32(row.Cells["Otros Costos"].Value));
                cmd.Parameters.AddWithValue("@pro", GestionProductoModel.getIdenty());
                cmd.ExecuteNonQuery();
            }
            cnn.Close();
        }
        //actualiza un producto
        public void actualizar_producto()
        {
            Articulo unArticulo = new Articulo();
            //trae el respectivo articulo a actualizar
            Articulo artID = GestionProductoModel.traer_articulo_id(Convert.ToInt32(cmbProductoTerminado.SelectedValue));
            //se le van asignando los datos
            unArticulo.Art_Id = artID.Art_Id;
            unArticulo.Art_Descrip = artID.Art_Descrip;
            unArticulo.Fam_Id = artID.Fam_Id;
            unArticulo.Um_Id = artID.Um_Id;
            decimal totalcostofinal = total_materia_prima + total_otros_costos;
            unArticulo.Art_Costo = totalcostofinal;///*****
            unArticulo.Art_Stock_Min = artID.Art_Stock_Min;
            unArticulo.Art_Stock_Max = artID.Art_Stock_Max;

            MessageBox.Show("total costo: "+ totalcostofinal);
            unArticulo.Art_Margen_Beneficio = artID.Art_Margen_Beneficio; //
            MessageBox.Show("margen de beneficio: "+ unArticulo.Art_Margen_Beneficio);

            unArticulo.Art_Precio = totalcostofinal * (1+ artID.Art_Margen_Beneficio/100);///****
                                                                                          
            unArticulo.Art_Stock_Reposicion = artID.Art_Stock_Reposicion;
            unArticulo.Art_Stock_Actual = artID.Art_Stock_Actual;
            unArticulo.Art_Maneja_Stock = artID.Art_Maneja_Stock;
            MessageBox.Show("precio de venta: "+unArticulo.Art_Precio);
            //finalmente se actualiza dicho articulo
            GestionProductoModel.update_producto(unArticulo); //******

        }
        //boton agrega un producto terminado
        private void btnAgregarProductoTerminado_Click(object sender, EventArgs e)
        {
            if (cmbProductoTerminado.Text.Equals("Seleccionar"))
            {
                MessageBox.Show("recuerde, debe seleccionar un item del combo producto terminado ....");
            }
            else
            {
                
                
                    if (MessageBox.Show("Quiere registrar, el producto terminado?", "Gestion Producto Terminado",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {

                        //se invocan a las demas operaciones antes mencionadas para un codigo mas prolijo
                        MessageBox.Show("Id Producto Terminado: " + cmbProductoTerminado.SelectedValue);
                        cargar_producto();

                        cargar_items_materia_prima();
                        cargar_items_otros_costos();
                        actualizar_producto();

                        //esto es lo nuevo q se agrego revisar si da error al agregar a la bd;
                        total_materia_prima = 0;
                        total_otros_costos = 0;

                        dgvItemsMateriaPrima.DataSource = "";
                        dgvItemsMateriaPrima.DataSource = null;
                        dgvItemsMateriaPrima.Rows.Clear();

                        dgvItemsOtrosCostos.DataSource = "";
                        dgvItemsOtrosCostos.DataSource = null;
                        dgvItemsOtrosCostos.Rows.Clear();
                        cmbProductoTerminado.Text = "Seleccionar";
                       
                    }
                 
               
            }
            
            
        }
        //de acuerdo a un cambio del combo descripcion, se actualizara el costo
        private void cmbDescripcionOc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtOtrosCostos.Text = Convert.ToString(cmbDescripcionOc.SelectedValue);
            txtOtrosCostos.Refresh();
        }
        //se valida los campos
        private void nupdOtrosCostos_ValueChanged(object sender, EventArgs e)
        {
            if (cmbOcId.Text != string.Empty && txtOtrosCostos.Text != string.Empty)
            {
                decimal p = Convert.ToDecimal(txtOtrosCostos.Text);
                txtImporteOc.Text = (Convert.ToDecimal(nupdOtrosCostos.Value) * p).ToString();
            }
            else
            {
                nupdOtrosCostos.Value = 0;
                MessageBox.Show("debe elegir al menos una opcion del combo descripcion");

            }
        }
        //boton salir 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
