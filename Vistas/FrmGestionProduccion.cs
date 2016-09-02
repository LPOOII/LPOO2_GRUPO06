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
    public partial class FrmGestionProduccion : Form
    {
        public FrmGestionProduccion()
        {
            InitializeComponent();
        }

       
        //traemos los datos para mostrarlo en el combo de productos terminados
        public void traer_lista_productos_terminados()
        {
            cmbProductoTerminado.DataSource = GestionProduccionModel.traer_productos_terminados();
            cmbProductoTerminado.DisplayMember = "art_descrip";
            cmbProductoTerminado.ValueMember = "pro_id"; 

        }

        //hacemos un load por default para iniciar el combo automaticamente
        private void FrmGestionProduccion_Load(object sender, EventArgs e)
        {
            traer_lista_productos_terminados();
            cmbProductoTerminado.Text = "Seleccionar";
           
        }

        //se crea una coleccion de tipo OP_Items_Materia_Prima
        private static List<OP_Items_Materia_Prima> list_OM = new List<OP_Items_Materia_Prima>();
        decimal total_materia_prima = 0;

        //boton agrega items de materia prima
        //private void btnAgregarMateriaPrima_Click(object sender, EventArgs e)
        //{
        //    if (Convert.ToDecimal(nudProCantidad.Value) != 0 && !cmbProductoTerminado.Text.Equals("Seleccionar"))
        //    {
        //        //refrescamos nuestra coleccion
        //        list_OM.Clear();
        //        //a la variable mat_prima se le asigna la lista de materias primas
        //        DataTable mat_prima = GestionProduccionModel.traer_materia_prima(Convert.ToInt32(cmbProductoTerminado.SelectedValue));
        //        // MessageBox.Show("valor del combo prod_terminado:  " + Convert.ToInt32(cmbProductoTerminado.SelectedValue));
        //        //recorremos la lista o datatable
        //        for (int i = 0; i < mat_prima.Rows.Count; i++)
        //        {
        //            OP_Items_Materia_Prima op_prima = new OP_Items_Materia_Prima();
        //            op_prima.Art_Id = Convert.ToInt32(mat_prima.Rows[i]["art_id"]);
        //            op_prima.Costo = Convert.ToDecimal(mat_prima.Rows[i]["costo"]) * Convert.ToDecimal(nudProCantidad.Value);
        //            op_prima.Cantidad = Convert.ToDecimal(mat_prima.Rows[i]["cantidad"]) * Convert.ToDecimal(nudProCantidad.Value);
        //            op_prima.Importe = Convert.ToDecimal(mat_prima.Rows[i]["importe"]) * Convert.ToDecimal(nudProCantidad.Value);
        //            total_materia_prima = total_materia_prima + op_prima.Importe;
        //            //cargamos datos a la coleccion de tipo op_items_materia_prima
        //            list_OM.Add(op_prima);
        //        }
        //        //MessageBox.Show("total materia prima: "+ total_materia_prima);
        //        dgvItemsMateriaPrima.DataSource = null;
        //        //asignamos la coleccion al datasource de itemsMateriaPrima
        //        dgvItemsMateriaPrima.DataSource = list_OM;
        //        dgvItemsMateriaPrima.Columns["op_item_mp_id"].Visible = false;
        //        dgvItemsMateriaPrima.Columns["Op_id"].Visible = false;
        //    }
        //    else
        //    {
        //        MessageBox.Show("La cantidad debe ser mayor a cero y debe Seleccionar un item del combo", "Items Materia Prima",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
            
        //}

        //se crea una coleccion de tipo OP_Items_Otros_Costos
        private static List<OP_Items_Otros_Costos> list_OC = new List<OP_Items_Otros_Costos>();
        decimal total_otros_costos = 0;
        //boton agrega items de otros costos
        //private void btnAgregarOtrosCostos_Click(object sender, EventArgs e)
        //{
        //    if (Convert.ToDecimal(nudProCantidad.Value) != 0 && !cmbProductoTerminado.Text.Equals("Seleccionar"))
        //    {
        //        list_OC.Clear();
        //        DataTable otros_cost = GestionProduccionModel.traer_otros_costos(Convert.ToInt32(cmbProductoTerminado.SelectedValue));
        //        //se recorre un datatable items otros costos
        //        for (int i = 0; i < otros_cost.Rows.Count; i++)
        //        {
        //            OP_Items_Otros_Costos op_ocostos = new OP_Items_Otros_Costos();
        //            //op_prima.Op_Id = //tiene q venir del general
        //            op_ocostos.Oc_Id = Convert.ToInt32(otros_cost.Rows[i]["oc_id"]);
        //            op_ocostos.Costo = Convert.ToDecimal(otros_cost.Rows[i]["costo"]) * Convert.ToDecimal(nudProCantidad.Value);
        //            op_ocostos.Cantidad = Convert.ToDecimal(otros_cost.Rows[i]["cantidad"]) * Convert.ToDecimal(nudProCantidad.Value);
        //            op_ocostos.Importe = Convert.ToDecimal(otros_cost.Rows[i]["importe"]) * Convert.ToDecimal(nudProCantidad.Value);
        //            total_otros_costos = total_otros_costos + op_ocostos.Importe;
        //            //cargamos el objeto op_costos a la coleccion
        //            list_OC.Add(op_ocostos);
        //        }
        //        //MessageBox.Show("total otros costos: " + total_otros_costos);
        //        dgvItemsOtrosCostos.DataSource = null;
        //        //asignamos al datagrid la coleccion listOc
        //        dgvItemsOtrosCostos.DataSource = list_OC;
        //        dgvItemsOtrosCostos.Columns["op_item_oc_id"].Visible = false;
        //        dgvItemsOtrosCostos.Columns["Op_id"].Visible = false;
        //    }
        //    else
        //    {
        //        MessageBox.Show("La cantidad debe ser mayor a cero y debe Seleccionar un item del combo","Items Materia Prima",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
           
        //}



        //carga una orden de produccion
        public void cargar_orden_produccion()
        {
            Orden_Produccion unaOrdenPro = new Orden_Produccion();
            unaOrdenPro.Op_Fecha = dtpFecha.Value;
            unaOrdenPro.Pro_Id = Convert.ToInt32(cmbProductoTerminado.SelectedValue);
            unaOrdenPro.Cantidad = Convert.ToDecimal(nudProCantidad.Value);
            unaOrdenPro.Total_Materia_Prima = total_materia_prima;
            unaOrdenPro.Total_Otros_Costos = total_otros_costos;
            unaOrdenPro.Costo_Final = total_materia_prima + total_otros_costos;

            //lblImporteMateriaP.Text=Convert.ToString(total_materia_prima);

            //lblImporteCosto.Text = Convert.ToString(total_otros_costos);

            //lblTotal.Text = Convert.ToString(total_materia_prima + total_otros_costos);

            //inserta una orden de produccion a la BD;
            GestionProduccionModel.insertar_produccion(unaOrdenPro); 
        }

        //carga los OP_Items_Materia_Prima 
        public void cargar_items_materia_prima()
        {
            OP_Items_Materia_Prima oimp = new OP_Items_Materia_Prima();
            //recorre una lista de materia prima
            foreach (OP_Items_Materia_Prima item in list_OM)
            {
                oimp.Op_Id = GestionProduccionModel.getIdenty();
                oimp.Art_Id = item.Art_Id;
                oimp.Costo = item.Costo;
                oimp.Cantidad = item.Cantidad;
                oimp.Importe = item.Importe;
                //inserta un orden de items de materia prima a la BD
                GestionProduccionModel.insertar_items_materia_prima(oimp);
            }
        }
        //carga los OP_Items_Otros_Costos 
        public void cargar_items_otros_costos()
        {
            OP_Items_Otros_Costos oioc = new OP_Items_Otros_Costos();
            //recorre una lista de otros costos
            foreach (OP_Items_Otros_Costos itemO in list_OC)
            {
                oioc.Op_Id = GestionProduccionModel.getIdenty();
                oioc.Oc_Id = itemO.Oc_Id;
                oioc.Costo = itemO.Costo;
                oioc.Cantidad = itemO.Cantidad;
                oioc.Importe = itemO.Importe;
                //inserta un orden de items de otros costos a la BD
                GestionProduccionModel.insertar_items_otros_costos(oioc);
            }
        }
        //actualiza un producto terminado
        public void actualizacion_de_produccion()
        {
            Articulo unArticulo = new Articulo();
            
            //MessageBox.Show("id del producto terminado: " + Convert.ToInt32(cmbProductoTerminado.SelectedValue));
            //traer un articulo de acuerdo al id de producto termninado
            unArticulo = GestionProduccionModel.traer_producto_terminado_obj(GestionProduccionModel.Obtener_art_id(Convert.ToInt32(cmbProductoTerminado.SelectedValue)));
            MessageBox.Show("id del articulo : " + unArticulo.Art_Id);
            MessageBox.Show("descripcion del articulo: " + unArticulo.Art_Descrip);
            MessageBox.Show("stock actual del articulo: " + unArticulo.Art_Stock_Actual);
            
            unArticulo.Art_Stock_Actual = unArticulo.Art_Stock_Actual + Convert.ToDecimal(nudProCantidad.Value);
            MessageBox.Show("Stock actualizado del articulo: "+ unArticulo.Art_Stock_Actual);
            //pasamos a actualizar el stock del producto terminado
            GestionProduccionModel.update_producto_terminado(unArticulo);

            //DataTable mp = GestionProduccionModel.traer_op_materia_prima();
            DataTable mp = GestionProduccionModel.traer_op_materia_prima(GestionProduccionModel.getIdenty());
            //recorremos un datatable de orden de produccion de materia prima
            for (int i = 0; i < mp.Rows.Count; i++)
            {
               Articulo oArticulo = GestionProduccionModel.traer_producto_terminado_obj(Convert.ToInt32(mp.Rows[i]["art_id"]));
           
               if (oArticulo.Art_Id == Convert.ToInt32(mp.Rows[i]["art_id"]))
               {
                   oArticulo.Art_Stock_Actual = oArticulo.Art_Stock_Actual - Convert.ToDecimal(mp.Rows[i]["cantidad"]);
                   //actualizo , consiste en disminuir el stock de un articulo de tipo materia prima)
                   GestionProduccionModel.update_producto_terminado(oArticulo);
                   //MessageBox.Show("se repiten los datos?? : = " + Convert.ToInt32(mp.Rows[i]["art_id"]));
               }

                
            }
            

        }
        //boton que que finalmente agrega un producto teminado a la orden de produccion
        private void btnAgregarProductoTerminado_Click(object sender, EventArgs e)
        {
            AgregarProductoTerminado();
        }

        private void AgregarProductoTerminado() 
        {
            if (Convert.ToDecimal(nudProCantidad.Value) != 0 && !cmbProductoTerminado.Text.Equals("Seleccionar"))
            {

                if (MessageBox.Show("Quiere Agregar, La Orden De Produccion?", "Orden de Produccion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (dgvItemsMateriaPrima.DataSource != null && dgvItemsOtrosCostos.DataSource != null)
                    {

                        //se invocan a todas la operaciones para un codigo mas prolijo
                        cargar_orden_produccion();
                        cargar_items_materia_prima();
                        cargar_items_otros_costos();
                        actualizacion_de_produccion();
                        MessageBox.Show("Orden de Produccion, registrada correctamente ..... !!!!");
                        //se hace un reset al datadrid
                        dgvItemsMateriaPrima.DataSource = "";
                        dgvItemsMateriaPrima.DataSource = null;
                        dgvItemsOtrosCostos.DataSource = "";
                        dgvItemsOtrosCostos.DataSource = null;
                        total_materia_prima = 0;
                        total_otros_costos = 0;
                        nudProCantidad.Value = 0;
                        cmbProductoTerminado.Text = "Seleccionar";

                    }
                    else
                    {
                        MessageBox.Show("Cargar los items materia prima y otros costos", "Items Materia Prima",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbProductoTerminado.Text = "Seleccionar";
                        nudProCantidad.Value = 0;
                    }


                }


            }
            else
            {
                MessageBox.Show("La Cantidad debe ser mayor a cero y debe Seleccionar un item del combo", "Items Materia Prima",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //boton para salir o cerrar formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AgregarMateriaPrima()
        {
            total_materia_prima = 0;
                //refrescamos nuestra coleccion
                list_OM.Clear();
                //a la variable mat_prima se le asigna la lista de materias primas
                DataTable mat_prima = GestionProduccionModel.traer_materia_prima(Convert.ToInt32(cmbProductoTerminado.SelectedValue));
                // MessageBox.Show("valor del combo prod_terminado:  " + Convert.ToInt32(cmbProductoTerminado.SelectedValue));
                //recorremos la lista o datatable
                for (int i = 0; i < mat_prima.Rows.Count; i++)
                {
                    OP_Items_Materia_Prima op_prima = new OP_Items_Materia_Prima();
                    op_prima.Art_Id = Convert.ToInt32(mat_prima.Rows[i]["art_id"]);
                    op_prima.Costo = Convert.ToDecimal(mat_prima.Rows[i]["costo"]);// *Convert.ToDecimal(nudProCantidad.Value);
                    op_prima.Cantidad = Convert.ToDecimal(mat_prima.Rows[i]["cantidad"]) * Convert.ToDecimal(nudProCantidad.Value);
                    op_prima.Importe = Convert.ToDecimal(mat_prima.Rows[i]["importe"]) * Convert.ToDecimal(nudProCantidad.Value);
                    total_materia_prima = total_materia_prima + op_prima.Importe;
                    //cargamos datos a la coleccion de tipo op_items_materia_prima
                    list_OM.Add(op_prima);
                }
                //MessageBox.Show("total materia prima: "+ total_materia_prima);
                dgvItemsMateriaPrima.DataSource = null;
                //asignamos la coleccion al datasource de itemsMateriaPrima
                dgvItemsMateriaPrima.DataSource = list_OM;
                dgvItemsMateriaPrima.Columns["op_item_mp_id"].Visible = false;
                dgvItemsMateriaPrima.Columns["Op_id"].Visible = false;
           
           
        }

        private void AgregarOtrosCostos() {

            total_otros_costos = 0;
                list_OC.Clear();
                DataTable otros_cost = GestionProduccionModel.traer_otros_costos(Convert.ToInt32(cmbProductoTerminado.SelectedValue));
                //se recorre un datatable items otros costos
                for (int i = 0; i < otros_cost.Rows.Count; i++)
                {
                    OP_Items_Otros_Costos op_ocostos = new OP_Items_Otros_Costos();
                    //op_prima.Op_Id = //tiene q venir del general
                    op_ocostos.Oc_Id = Convert.ToInt32(otros_cost.Rows[i]["oc_id"]);
                    op_ocostos.Costo = Convert.ToDecimal(otros_cost.Rows[i]["costo"]);// *Convert.ToDecimal(nudProCantidad.Value);
                    op_ocostos.Cantidad = Convert.ToDecimal(otros_cost.Rows[i]["cantidad"]) * Convert.ToDecimal(nudProCantidad.Value);
                    op_ocostos.Importe = Convert.ToDecimal(otros_cost.Rows[i]["importe"]) * Convert.ToDecimal(nudProCantidad.Value);
                    total_otros_costos = total_otros_costos + op_ocostos.Importe;
                    //cargamos el objeto op_costos a la coleccion
                    list_OC.Add(op_ocostos);
                }
                //MessageBox.Show("total otros costos: " + total_otros_costos);
                dgvItemsOtrosCostos.DataSource = null;
                //asignamos al datagrid la coleccion listOc
                dgvItemsOtrosCostos.DataSource = list_OC;
                dgvItemsOtrosCostos.Columns["op_item_oc_id"].Visible = false;
                dgvItemsOtrosCostos.Columns["Op_id"].Visible = false;
            }
           
        
        private void cmbProductoTerminado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (nudProCantidad.Value!=0)
            {
                AgregarMateriaPrima();
                AgregarOtrosCostos();
                Totales();
            }
            else
            {
                dgvItemsMateriaPrima.DataSource = null;
                dgvItemsOtrosCostos.DataSource = null;
            }
        }

        private void nudProCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (!cmbProductoTerminado.Text.Equals("Seleccionar"))
            {
                AgregarMateriaPrima();
                AgregarOtrosCostos();
                Totales();
            }
            else
            {                
                dgvItemsMateriaPrima.DataSource = null;
                dgvItemsOtrosCostos.DataSource = null;
            }
        }


        private void Totales(){
             Orden_Produccion unaOrdenPro = new Orden_Produccion();
            unaOrdenPro.Op_Fecha = dtpFecha.Value;
            unaOrdenPro.Pro_Id = Convert.ToInt32(cmbProductoTerminado.SelectedValue);
            unaOrdenPro.Cantidad = Convert.ToDecimal(nudProCantidad.Value);
            unaOrdenPro.Total_Materia_Prima = total_materia_prima;
            unaOrdenPro.Total_Otros_Costos = total_otros_costos;
            unaOrdenPro.Costo_Final = total_materia_prima + total_otros_costos;

            lblImporteMateriaP.Text=Convert.ToString(total_materia_prima);

            lblImporteCosto.Text = Convert.ToString(total_otros_costos);

            lblTotal.Text = Convert.ToString(total_materia_prima + total_otros_costos);
        }

    }
}
