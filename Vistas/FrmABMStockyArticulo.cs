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
    public partial class FrmABMStockyArticulo : Form
    {
        public FrmABMStockyArticulo()
        {
            InitializeComponent();
        }

        private void FrmGestionStockArticulos_Load(object sender, EventArgs e)
        {
            btnEliminarArticulo.Enabled = false;
            btnModificarArticulo.Enabled = false;
            //Llamo al metodo listarFamiliaCombo: cuando inicie se cargar la lista familias del combo.
            listarFamiliaCombo();
            
            //Llamo al metodo listarUnidadCombo: cuando inicie se cargar la lista unidades del combo.
            listarUnidadCombo();

            //Para que inicie el combo vacio: se puede usar cualquiera de las dos.

            
            
           //cmbBuscarFamilia.SelectedValue = 0;
            cmbBuscarFamilia.Text = "Seleccionar";
            txtMargenBeneficio.Enabled = false;
        }
        
        //Guardar Articulo
        private void btnGuardarArt_Click(object sender, EventArgs e)
        {
            
            //this.Close();
            if (validar())
            {
                isValid();
                BorrarCampos(gboxArticulo);
                dataGridViewArticulos.DataSource = ArticuloModel.list_Articulos();
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos!",
                 "Por Favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*BorrarCampos(gboxArticulo);
            dataGridViewArticulos.DataSource = ArticuloModel.list_Articulos();*/
        }

       

        //metodos de los eventos Mouse: hover y leave para el boton Ingresar
        private void btnGuardarArt_MouseHover(object sender, EventArgs e)
        {
            btnGuardarArt.ForeColor = Color.Red;
        }

        private void btnGuardarArt_MouseLeave(object sender, EventArgs e)
        {
            btnGuardarArt.ForeColor = Color.Black;
        }

        private void btnSalirArt_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.Red;
        }

        private void btnSalirArt_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.Black;
        }
        //--fin con los eventos Mouse:



       


      

        //Mostrar el combo de Familia
        //traer la lista del combo de familia de la clase ArticuloModel de la carpeta Model
        private void listarFamiliaCombo()
        {
            
            //DisplayMember:muestra la descripcion.
            cmbFamiliaID.DisplayMember = "fam_descrip";
            //ValueMember: va a madar el id de refencia.
            cmbFamiliaID.ValueMember = "fam_id";
            //combo 2 para realizar busqueda
            cmbBuscarFamilia.DisplayMember = "fam_descrip";
            cmbBuscarFamilia.ValueMember = "fam_id";

            
            //DataSource: permite recibir el dataTable que va hacer uso de ese recurso.
            cmbFamiliaID.DataSource = ArticuloModel.list_Familias();
            
            
            cmbBuscarFamilia.DataSource = ArticuloModel.list_Familias();

            

        }//fin-listarFamiliaCombo


        //Mostrar el combo de Unidad_Medida
        //traer la lista del combo de unidad de la clase ArticuloModel de la carpeta Model
        private void listarUnidadCombo()
        {
            //DisplayMember:muestra la descripcion.
            cmbUnidadID.DisplayMember = "um_descrip";
            //ValueMember: va a madar el id de refencia.
            cmbUnidadID.ValueMember = "um_id";
            //DataSource: permite recibir el dataTable que va hacer uso de ese recurso.
            cmbUnidadID.DataSource = ArticuloModel.list_Unidades();

        }//fin-listarUnidadCombo


        //Mostrar Todo
        /*Metodo btnMostrarTodoArticulos que permite traer a todos los articulos*/
        private void btnMostrarTodoArticulos_Click(object sender, EventArgs e)
        {
            dataGridViewArticulos.DataSource = ArticuloModel.list_Articulos();
            dataGridViewArticulos.Refresh();
        }//fin-btnMostrarTodoArticulos


        //Boton Modificar
        /*Los datos son cargados de la grilla a los texbox*/
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            txtMargenBeneficio.Enabled = false;
            //int id;
            decimal costo = Convert.ToDecimal(txtCostoArt.Text);
            decimal precio = Convert.ToDecimal(txtPrecioArt.Text) ;
            decimal margen = Convert.ToDecimal(txtMargenBeneficio.Text);

            if (precio > costo) {
                margen = precio - costo;
            }
            
            Articulo articulo = new Articulo();
            //id = articulo.Art_Id;
            articulo.Art_Id = Convert.ToInt32(txtIdArticulo.Text); ;
            articulo.Art_Descrip = txtDescripArt.Text;
            articulo.Fam_Id = (int)cmbFamiliaID.SelectedValue;
            articulo.Um_Id = (int)cmbUnidadID.SelectedValue;
            articulo.Art_Costo = decimal.Parse(txtCostoArt.Text);
            articulo.Art_Stock_Min = decimal.Parse(txtStockMin.Text);
            articulo.Art_Stock_Max = decimal.Parse(txtStockMax.Text);
            articulo.Art_Precio = decimal.Parse(txtPrecioArt.Text);
            articulo.Art_Stock_Reposicion = decimal.Parse(txtStockRepArt.Text);
            articulo.Art_Stock_Actual = decimal.Parse(txtStockActualArt.Text);
            articulo.Art_Margen_Beneficio = margen;

            if (rBtnStockY.Checked){
                articulo.Art_Maneja_Stock = true;
            }else if (rBtnStockN.Checked){
                articulo.Art_Maneja_Stock = false;
            }

            ArticuloModel.update_Articulo(articulo);
            MessageBox.Show("Se modifico exitosamente!");
            dataGridViewArticulos.DataSource = ArticuloModel.list_Articulos();

        }//fin--btnModificarArticulo


        //Boton Eliminar
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Eliminar Articulo?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                Articulo eArticle = new Articulo();

                //Captura de los datos de los texbox
                eArticle.Art_Id = Convert.ToInt32(txtIdArticulo.Text);
                eArticle.Art_Descrip = txtDescripArt.Text;
                eArticle.Fam_Id = (int)cmbFamiliaID.SelectedValue;
                eArticle.Um_Id = (int)cmbUnidadID.SelectedValue;
                eArticle.Art_Costo = decimal.Parse(txtCostoArt.Text);
                eArticle.Art_Stock_Min = decimal.Parse(txtStockMin.Text);
                eArticle.Art_Stock_Max = decimal.Parse(txtStockMax.Text);
                eArticle.Art_Precio = decimal.Parse(txtPrecioArt.Text);
                eArticle.Art_Stock_Reposicion = decimal.Parse(txtStockRepArt.Text);
                eArticle.Art_Stock_Actual = decimal.Parse(txtStockActualArt.Text);
                eArticle.Art_Margen_Beneficio = decimal.Parse(txtMargenBeneficio.Text);

                if (rBtnStockY.Checked){
                    eArticle.Art_Maneja_Stock = true;
                }else if (rBtnStockN.Checked){
                    eArticle.Art_Maneja_Stock = false;
                }

                ArticuloModel.delete_Articulo(eArticle);
                dataGridViewArticulos.DataSource = ArticuloModel.list_Articulos();
            }
            
        }//--btnEliminarArticulo

        //Datos de la Grilla
        /*Completa los datos a los textbox cuado se haga click en algun regitro*/
        private void dataGridViewArticulos_CurrentCellChanged(object sender, EventArgs e)
        {
            /*txtMargenBeneficio.Enabled = false;
            btnGuardarArt.Enabled = false;*/

            Articulo articulo = new Articulo();
            if (dataGridViewArticulos.CurrentRow != null)
            {
                txtDescripArt.Text = dataGridViewArticulos.CurrentRow.Cells["Descripcion"].Value.ToString();
                switch (dataGridViewArticulos.CurrentRow.Cells["Familia"].Value.ToString())
                {
                    case "Materias Primas": cmbFamiliaID.SelectedValue = 1; break;
                    case "Productos Terminados": cmbFamiliaID.SelectedValue = 2; break;
                    case "Servicios": cmbFamiliaID.SelectedValue = 3; break;
                }
                switch (dataGridViewArticulos.CurrentRow.Cells["Unidad de Medida"].Value.ToString())
                {
                    case "Gramos": cmbUnidadID.SelectedValue = 1; break;

                    case "Kilogramos": cmbUnidadID.SelectedValue = 2; break;
                    case "Litros": cmbUnidadID.SelectedValue = 3; break;
                    case "Unidades": cmbUnidadID.SelectedValue = 4; break;
                    case "Docenas": cmbUnidadID.SelectedValue = 5; break;
                    case "KWH": cmbUnidadID.SelectedValue = 6; break;
                    case "Otras Unidades": cmbUnidadID.SelectedValue = 7; break;

                }
                txtIdArticulo.Text = dataGridViewArticulos.CurrentRow.Cells["ID Articulo"].Value.ToString();
                txtCostoArt.Text = dataGridViewArticulos.CurrentRow.Cells["Costo"].Value.ToString();
                txtMargenBeneficio.Text = dataGridViewArticulos.CurrentRow.Cells["Margen Beneficio"].Value.ToString();
                txtPrecioArt.Text = dataGridViewArticulos.CurrentRow.Cells["Precio"].Value.ToString();
                txtStockMin.Text = dataGridViewArticulos.CurrentRow.Cells["Stock Minimo"].Value.ToString();
                txtStockMax.Text = dataGridViewArticulos.CurrentRow.Cells["Stock Maximo"].Value.ToString();
                txtStockRepArt.Text = dataGridViewArticulos.CurrentRow.Cells["Stock Reposicion"].Value.ToString();
                txtStockActualArt.Text = dataGridViewArticulos.CurrentRow.Cells["Stock Actual"].Value.ToString();
                string radio = dataGridViewArticulos.CurrentRow.Cells["Maneja Stock"].Value.ToString();

                switch (radio)
                {
                    case "False": rBtnStockN.Checked = false; break;
                    case "True": rBtnStockY.Checked = true; break;
                }


                //*
                switch (dataGridViewArticulos.CurrentRow.Cells["Familia"].Value.ToString())
                {
                    case "Materias Primas": rBtnStockN.Enabled = true;
                        rBtnStockY.Enabled = true; break;
                    case "Productos Terminados": rBtnStockN.Enabled = true;
                        rBtnStockY.Enabled = true; break;

                    case "Servicios": rBtnStockN.Enabled = false;
                        rBtnStockY.Enabled = false; break;
                }

                //
                txtMargenBeneficio.Enabled = false;
                btnGuardarArt.Enabled = false;
                btnModificarArticulo.Enabled = true;
                btnEliminarArticulo.Enabled = true;
            }//fin-if
            else
            {
                cleanTextbox();
            }
        }

        public void BorrarCampos(GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
            }

        }

        private void cmbFamiliaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int familia = Convert.ToInt32(cmbFamiliaID.SelectedValue);
            if (familia == 3)
            {
                string a = "0";
                txtCostoArt.Text = a;
                txtCostoArt.Enabled = false;
                txtStockMin.Enabled = false;
                txtStockMax.Enabled = false;
                txtStockActualArt.Enabled = false;
                txtMargenBeneficio.Enabled = false;
                txtStockRepArt.Enabled = false;
                 rBtnStockN.Enabled = false;
                 rBtnStockY.Enabled = false;
                //rBtnStockN.Checked = true;
                
                
            }
            else if (familia == 1 || familia == 2)
            {
                txtCostoArt.Enabled = true;
                txtStockMin.Enabled = true;
                txtStockMax.Enabled = true;
                txtStockActualArt.Enabled = true;
                txtMargenBeneficio.Enabled = true;
                txtStockRepArt.Enabled = true;
                //rBtnStockN.Enabled = true;
                //rBtnStockY.Enabled = true;
            }

        }

        private void cleanTextbox()
        {

            txtIdArticulo.Text = "";
            txtDescripArt.Text = "";
            cmbFamiliaID.SelectedValue = false;
            cmbUnidadID.SelectedValue = false;
            txtCostoArt.Text = "";
            txtStockMin.Text = "";
            txtStockMax.Text = "";
            txtPrecioArt.Text = "";
            txtStockRepArt.Text = "";
            txtStockActualArt.Text = "";
            txtMargenBeneficio.Text = "";
            rBtnStockN.Checked = false;
            rBtnStockY.Checked = false;
            btnEliminarArticulo.Enabled = false;
            btnModificarArticulo.Enabled = false;
            btnGuardarArt.Enabled = true;
            enableTexobx();
        }

        private void enableTexobx()
        {
            txtCostoArt.Enabled = true;
            txtStockMin.Enabled = true;
            txtStockMax.Enabled = true;
            txtStockActualArt.Enabled = true;
            txtMargenBeneficio.Enabled = true;
            txtStockRepArt.Enabled = true;
        }

        //***Limpiar***/     
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cleanTextbox();
        }

        private void isValid()
        {

            bool pasoTest1 = true, pasoTest2 = true;
            int costoServicio = int.Parse(txtCostoArt.Text);
            decimal costo = Convert.ToDecimal(txtCostoArt.Text);
            decimal precio = Convert.ToDecimal(txtPrecioArt.Text);
            

            Articulo articulo = new Articulo();
            if (txtStockMin.Text != string.Empty && txtStockMax.Text != string.Empty
                && txtPrecioArt.Text != string.Empty && txtStockRepArt.Text != string.Empty
                && txtStockActualArt.Text != string.Empty && txtCostoArt.Text != string.Empty)
            {
                articulo.Art_Costo = decimal.Parse(txtCostoArt.Text);
                articulo.Art_Stock_Min = decimal.Parse(txtStockMin.Text);
                articulo.Art_Stock_Max = decimal.Parse(txtStockMax.Text);
                articulo.Art_Precio = decimal.Parse(txtPrecioArt.Text);
                articulo.Art_Stock_Reposicion = decimal.Parse(txtStockRepArt.Text);
                articulo.Art_Stock_Actual = decimal.Parse(txtStockActualArt.Text);
            }

            //Captura de los datos de los texbox
            articulo.Art_Descrip = txtDescripArt.Text;
            articulo.Fam_Id = (int)cmbFamiliaID.SelectedValue;
            articulo.Um_Id = (int)cmbUnidadID.SelectedValue;



            if (precio > costo)
            {
                articulo.Art_Margen_Beneficio = precio - costo;
            }

            if (costoServicio == 0)
            {
                articulo.Art_Precio = decimal.Parse(txtPrecioArt.Text);
                articulo.Art_Margen_Beneficio = 0;
            }

            if (rBtnStockY.Checked)
            {
                articulo.Art_Maneja_Stock = true;
            }
            else if (rBtnStockN.Checked)
            {
                articulo.Art_Maneja_Stock = false;
            }

            if (precio <= costo)
            {
                MessageBox.Show("El Precio debe ser mayor que el Costo",
                    "Por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pasoTest1 = false;
            }
           



            if (pasoTest1 && pasoTest2 && validar())
            {
                //Se llama al metodo insertarUsuario y le pasamos el objeto articulo con los datos de los text box.
                ArticuloModel.insert_Articulo(articulo);
                MessageBox.Show("Se guardo exitosamente!", "Se dio de Alta un Articulo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridViewArticulos.DataSource = ArticuloModel.list_Articulos();
                cleanTextbox();
            }


        }//fin-isValid



        private bool validar()
        {
            decimal familia = Convert.ToDecimal(cmbFamiliaID.SelectedValue);
            decimal unidad = Convert.ToDecimal(cmbUnidadID.SelectedValue);

            bool vacio = false;
            if (familia == 3)
            {
                if (!txtDescripArt.Text.Equals("") && !txtPrecioArt.Text.Equals(""))
                {
                     vacio = true;
                }
            }
            else
            {
                if (!txtDescripArt.Text.Equals("") && !familia.Equals("") && !unidad.Equals("")
                && !txtCostoArt.Text.Equals("") && !txtStockMin.Text.Equals("") && !txtStockMax.Text.Equals("")
                && !txtPrecioArt.Text.Equals("") && !txtStockRepArt.Text.Equals("")
                && !txtStockActualArt.Text.Equals("") && rBtnStockY.Checked == true || rBtnStockN.Checked == true)
                {
                    vacio = true;
                }
            }
            
            return vacio;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            
            int f;
            if (cmbBuscarFamilia.Text.Equals("Seleccionar"))
            {
                f = 0;
            }
            else
            {
                f = (int)cmbBuscarFamilia.SelectedValue;

            }


            if (txtBuscarArtDescrip.Text.Equals("") && cmbBuscarFamilia.Text.Equals("Seleccionar"))
            {
                MessageBox.Show("Debe ingresar algun valor, para la busqueda \n" +
                                  "En Nombre o Seleccionar del Combo");
            }
            else
            {
                if (!txtBuscarArtDescrip.Text.Equals("") && cmbBuscarFamilia.Text.Equals("Seleccionar"))
                {
                    dataGridViewArticulos.DataSource = ArticuloModel.buscar_articulos(txtBuscarArtDescrip.Text, 0);
                    //**MessageBox.Show("busqueda exitosa nombre");
                    dataGridViewArticulos.Refresh();
                    txtBuscarArtDescrip.Text = "";
                    cmbBuscarFamilia.Text = "Seleccionar";

                }
                else
                {
                    if (!cmbBuscarFamilia.Text.Equals("Seleccionar"))
                    {
                        dataGridViewArticulos.DataSource = ArticuloModel.buscar_articulos(txtBuscarArtDescrip.Text, f);
                        //**MessageBox.Show("busqueda exitosa combo o combinada");
                        dataGridViewArticulos.Refresh();
                        txtBuscarArtDescrip.Text = "";
                        cmbBuscarFamilia.Text = "Seleccionar";
                    }

                }
                dataGridViewArticulos.Refresh();
            }

            
        }

        private void btnOrdenDescripCod_Click(object sender, EventArgs e)
        {
            if (rdoDescripcion.Checked)
            {
                dataGridViewArticulos.DataSource = ArticuloModel.traer_articulo_orden_descripcion();
                rdoDescripcion.Checked = false;
            }
            if (rdoCodigo.Checked)
            {
                dataGridViewArticulos.DataSource = ArticuloModel.traer_articulo_orden_nombre();
                rdoCodigo.Checked = false;
            }
            dataGridViewArticulos.Refresh();
        }

        


    }//fin-FrmABMStockyArticulo(Principal)
   }
