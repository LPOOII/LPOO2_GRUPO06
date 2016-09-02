namespace Vistas
{
    partial class FrmABMStockyArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMStockyArticulo));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStockActualArt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStockRepArt = new System.Windows.Forms.TextBox();
            this.txtPrecioArt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockMax = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostoArt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarArt = new System.Windows.Forms.Button();
            this.rBtnStockY = new System.Windows.Forms.RadioButton();
            this.rBtnStockN = new System.Windows.Forms.RadioButton();
            this.dataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.cmbFamiliaID = new System.Windows.Forms.ComboBox();
            this.cmbUnidadID = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodoArticulos = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMargenBeneficio = new System.Windows.Forms.TextBox();
            this.gboxArticulo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxBusqueda = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBuscarFamilia = new System.Windows.Forms.ComboBox();
            this.txtBuscarArtDescrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrdenDescripCod = new System.Windows.Forms.Button();
            this.rdoDescripcion = new System.Windows.Forms.RadioButton();
            this.rdoCodigo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).BeginInit();
            this.gboxArticulo.SuspendLayout();
            this.gboxBusqueda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Id Unidad Medida:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Id Familia:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Vistas.Properties.Resources.limpiar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(205, 494);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnSalirArt_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnSalirArt_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Maneja Stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Stock Actual:";
            // 
            // txtStockActualArt
            // 
            this.txtStockActualArt.Location = new System.Drawing.Point(153, 403);
            this.txtStockActualArt.Name = "txtStockActualArt";
            this.txtStockActualArt.Size = new System.Drawing.Size(98, 20);
            this.txtStockActualArt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Stock Reposición:";
            // 
            // txtStockRepArt
            // 
            this.txtStockRepArt.Location = new System.Drawing.Point(153, 368);
            this.txtStockRepArt.Name = "txtStockRepArt";
            this.txtStockRepArt.Size = new System.Drawing.Size(98, 20);
            this.txtStockRepArt.TabIndex = 10;
            // 
            // txtPrecioArt
            // 
            this.txtPrecioArt.Location = new System.Drawing.Point(153, 296);
            this.txtPrecioArt.Name = "txtPrecioArt";
            this.txtPrecioArt.Size = new System.Drawing.Size(167, 20);
            this.txtPrecioArt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Precio:";
            // 
            // txtStockMax
            // 
            this.txtStockMax.Location = new System.Drawing.Point(153, 261);
            this.txtStockMax.Name = "txtStockMax";
            this.txtStockMax.Size = new System.Drawing.Size(166, 20);
            this.txtStockMax.TabIndex = 7;
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(153, 226);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(166, 20);
            this.txtStockMin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Stock Maximo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Sotck Minimo:";
            // 
            // txtCostoArt
            // 
            this.txtCostoArt.Location = new System.Drawing.Point(153, 191);
            this.txtCostoArt.Name = "txtCostoArt";
            this.txtCostoArt.Size = new System.Drawing.Size(166, 20);
            this.txtCostoArt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Costo: ";
            // 
            // txtDescripArt
            // 
            this.txtDescripArt.Location = new System.Drawing.Point(153, 84);
            this.txtDescripArt.Name = "txtDescripArt";
            this.txtDescripArt.Size = new System.Drawing.Size(166, 20);
            this.txtDescripArt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Descripción:";
            // 
            // btnGuardarArt
            // 
            this.btnGuardarArt.Image = global::Vistas.Properties.Resources.imgGuardar;
            this.btnGuardarArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarArt.Location = new System.Drawing.Point(93, 494);
            this.btnGuardarArt.Name = "btnGuardarArt";
            this.btnGuardarArt.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarArt.TabIndex = 14;
            this.btnGuardarArt.Text = "Guardar";
            this.btnGuardarArt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarArt.UseVisualStyleBackColor = true;
            this.btnGuardarArt.Click += new System.EventHandler(this.btnGuardarArt_Click);
            this.btnGuardarArt.MouseLeave += new System.EventHandler(this.btnGuardarArt_MouseLeave);
            this.btnGuardarArt.MouseHover += new System.EventHandler(this.btnGuardarArt_MouseHover);
            // 
            // rBtnStockY
            // 
            this.rBtnStockY.AutoSize = true;
            this.rBtnStockY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnStockY.Location = new System.Drawing.Point(153, 451);
            this.rBtnStockY.Name = "rBtnStockY";
            this.rBtnStockY.Size = new System.Drawing.Size(36, 19);
            this.rBtnStockY.TabIndex = 12;
            this.rBtnStockY.TabStop = true;
            this.rBtnStockY.Text = "Si";
            this.rBtnStockY.UseVisualStyleBackColor = true;
            // 
            // rBtnStockN
            // 
            this.rBtnStockN.AutoSize = true;
            this.rBtnStockN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnStockN.Location = new System.Drawing.Point(225, 451);
            this.rBtnStockN.Name = "rBtnStockN";
            this.rBtnStockN.Size = new System.Drawing.Size(41, 19);
            this.rBtnStockN.TabIndex = 13;
            this.rBtnStockN.TabStop = true;
            this.rBtnStockN.Text = "No";
            this.rBtnStockN.UseVisualStyleBackColor = true;
            // 
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.AllowUserToAddRows = false;
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulos.Location = new System.Drawing.Point(420, 225);
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.ReadOnly = true;
            this.dataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticulos.Size = new System.Drawing.Size(579, 287);
            this.dataGridViewArticulos.TabIndex = 26;
            this.dataGridViewArticulos.CurrentCellChanged += new System.EventHandler(this.dataGridViewArticulos_CurrentCellChanged);
            // 
            // cmbFamiliaID
            // 
            this.cmbFamiliaID.FormattingEnabled = true;
            this.cmbFamiliaID.Location = new System.Drawing.Point(153, 119);
            this.cmbFamiliaID.Name = "cmbFamiliaID";
            this.cmbFamiliaID.Size = new System.Drawing.Size(166, 21);
            this.cmbFamiliaID.TabIndex = 3;
            this.cmbFamiliaID.SelectedIndexChanged += new System.EventHandler(this.cmbFamiliaID_SelectedIndexChanged);
            // 
            // cmbUnidadID
            // 
            this.cmbUnidadID.FormattingEnabled = true;
            this.cmbUnidadID.Location = new System.Drawing.Point(153, 155);
            this.cmbUnidadID.Name = "cmbUnidadID";
            this.cmbUnidadID.Size = new System.Drawing.Size(166, 21);
            this.cmbUnidadID.TabIndex = 4;
            // 
            // btnMostrarTodoArticulos
            // 
            this.btnMostrarTodoArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodoArticulos.Location = new System.Drawing.Point(420, 169);
            this.btnMostrarTodoArticulos.Name = "btnMostrarTodoArticulos";
            this.btnMostrarTodoArticulos.Size = new System.Drawing.Size(97, 23);
            this.btnMostrarTodoArticulos.TabIndex = 22;
            this.btnMostrarTodoArticulos.Text = "Mostrar Todo";
            this.btnMostrarTodoArticulos.UseVisualStyleBackColor = true;
            this.btnMostrarTodoArticulos.Click += new System.EventHandler(this.btnMostrarTodoArticulos_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.Image = global::Vistas.Properties.Resources.imgModificar;
            this.btnModificarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarArticulo.Location = new System.Drawing.Point(579, 169);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(84, 23);
            this.btnModificarArticulo.TabIndex = 23;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Image = global::Vistas.Properties.Resources.imgCancelar;
            this.btnEliminarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(716, 169);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(79, 23);
            this.btnEliminarArticulo.TabIndex = 24;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "Id:";
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(151, 49);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.ReadOnly = true;
            this.txtIdArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtIdArticulo.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 16);
            this.label15.TabIndex = 66;
            this.label15.Text = "Margen Beneficio";
            // 
            // txtMargenBeneficio
            // 
            this.txtMargenBeneficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargenBeneficio.Location = new System.Drawing.Point(153, 331);
            this.txtMargenBeneficio.Name = "txtMargenBeneficio";
            this.txtMargenBeneficio.ReadOnly = true;
            this.txtMargenBeneficio.Size = new System.Drawing.Size(98, 22);
            this.txtMargenBeneficio.TabIndex = 9;
            // 
            // gboxArticulo
            // 
            this.gboxArticulo.BackColor = System.Drawing.Color.Transparent;
            this.gboxArticulo.Controls.Add(this.label13);
            this.gboxArticulo.Controls.Add(this.txtIdArticulo);
            this.gboxArticulo.Controls.Add(this.txtMargenBeneficio);
            this.gboxArticulo.Controls.Add(this.label2);
            this.gboxArticulo.Controls.Add(this.label15);
            this.gboxArticulo.Controls.Add(this.txtDescripArt);
            this.gboxArticulo.Controls.Add(this.label3);
            this.gboxArticulo.Controls.Add(this.label14);
            this.gboxArticulo.Controls.Add(this.txtCostoArt);
            this.gboxArticulo.Controls.Add(this.label4);
            this.gboxArticulo.Controls.Add(this.label5);
            this.gboxArticulo.Controls.Add(this.txtStockMin);
            this.gboxArticulo.Controls.Add(this.txtStockMax);
            this.gboxArticulo.Controls.Add(this.cmbUnidadID);
            this.gboxArticulo.Controls.Add(this.label7);
            this.gboxArticulo.Controls.Add(this.cmbFamiliaID);
            this.gboxArticulo.Controls.Add(this.txtPrecioArt);
            this.gboxArticulo.Controls.Add(this.txtStockRepArt);
            this.gboxArticulo.Controls.Add(this.label8);
            this.gboxArticulo.Controls.Add(this.txtStockActualArt);
            this.gboxArticulo.Controls.Add(this.label9);
            this.gboxArticulo.Controls.Add(this.label10);
            this.gboxArticulo.Controls.Add(this.btnGuardarArt);
            this.gboxArticulo.Controls.Add(this.rBtnStockN);
            this.gboxArticulo.Controls.Add(this.btnCancelar);
            this.gboxArticulo.Controls.Add(this.rBtnStockY);
            this.gboxArticulo.Controls.Add(this.label11);
            this.gboxArticulo.Controls.Add(this.label12);
            this.gboxArticulo.Location = new System.Drawing.Point(12, 4);
            this.gboxArticulo.Name = "gboxArticulo";
            this.gboxArticulo.Size = new System.Drawing.Size(367, 540);
            this.gboxArticulo.TabIndex = 68;
            this.gboxArticulo.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 18);
            this.label13.TabIndex = 67;
            this.label13.Text = "Datos de Stock y Articulo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Yellow;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(417, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(430, 16);
            this.label16.TabIndex = 69;
            this.label16.Text = "*Para Modificar y Eliminar  seleccione un registro de la tabla.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Yellow;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(417, 523);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(397, 16);
            this.label17.TabIndex = 70;
            this.label17.Text = "*Para Agregar un Nuevo Articulo, hacer Click en Limpiar.";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Vistas.Properties.Resources.imgSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(853, 169);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gboxBusqueda
            // 
            this.gboxBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gboxBusqueda.Controls.Add(this.label6);
            this.gboxBusqueda.Controls.Add(this.cmbBuscarFamilia);
            this.gboxBusqueda.Controls.Add(this.txtBuscarArtDescrip);
            this.gboxBusqueda.Controls.Add(this.label1);
            this.gboxBusqueda.Controls.Add(this.btnBuscarArticulo);
            this.gboxBusqueda.Location = new System.Drawing.Point(420, 5);
            this.gboxBusqueda.Name = "gboxBusqueda";
            this.gboxBusqueda.Size = new System.Drawing.Size(579, 63);
            this.gboxBusqueda.TabIndex = 72;
            this.gboxBusqueda.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Familia:";
            // 
            // cmbBuscarFamilia
            // 
            this.cmbBuscarFamilia.FormattingEnabled = true;
            this.cmbBuscarFamilia.Location = new System.Drawing.Point(421, 22);
            this.cmbBuscarFamilia.Name = "cmbBuscarFamilia";
            this.cmbBuscarFamilia.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarFamilia.TabIndex = 18;
            // 
            // txtBuscarArtDescrip
            // 
            this.txtBuscarArtDescrip.Location = new System.Drawing.Point(216, 23);
            this.txtBuscarArtDescrip.Name = "txtBuscarArtDescrip";
            this.txtBuscarArtDescrip.Size = new System.Drawing.Size(118, 20);
            this.txtBuscarArtDescrip.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre:";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArticulo.Image = global::Vistas.Properties.Resources.buscar;
            this.btnBuscarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(27, 22);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(75, 26);
            this.btnBuscarArticulo.TabIndex = 16;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnOrdenDescripCod);
            this.groupBox1.Controls.Add(this.rdoDescripcion);
            this.groupBox1.Controls.Add(this.rdoCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(420, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 64);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // btnOrdenDescripCod
            // 
            this.btnOrdenDescripCod.Image = global::Vistas.Properties.Resources.buscar;
            this.btnOrdenDescripCod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenDescripCod.Location = new System.Drawing.Point(27, 20);
            this.btnOrdenDescripCod.Name = "btnOrdenDescripCod";
            this.btnOrdenDescripCod.Size = new System.Drawing.Size(70, 23);
            this.btnOrdenDescripCod.TabIndex = 19;
            this.btnOrdenDescripCod.Text = "Buscar";
            this.btnOrdenDescripCod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrdenDescripCod.UseVisualStyleBackColor = true;
            this.btnOrdenDescripCod.Click += new System.EventHandler(this.btnOrdenDescripCod_Click);
            // 
            // rdoDescripcion
            // 
            this.rdoDescripcion.AutoSize = true;
            this.rdoDescripcion.Location = new System.Drawing.Point(317, 20);
            this.rdoDescripcion.Name = "rdoDescripcion";
            this.rdoDescripcion.Size = new System.Drawing.Size(90, 19);
            this.rdoDescripcion.TabIndex = 21;
            this.rdoDescripcion.TabStop = true;
            this.rdoDescripcion.Text = "Descripcion";
            this.rdoDescripcion.UseVisualStyleBackColor = true;
            // 
            // rdoCodigo
            // 
            this.rdoCodigo.AutoSize = true;
            this.rdoCodigo.Location = new System.Drawing.Point(196, 19);
            this.rdoCodigo.Name = "rdoCodigo";
            this.rdoCodigo.Size = new System.Drawing.Size(64, 19);
            this.rdoCodigo.TabIndex = 20;
            this.rdoCodigo.TabStop = true;
            this.rdoCodigo.Text = "Codigo";
            this.rdoCodigo.UseVisualStyleBackColor = true;
            // 
            // FrmABMStockyArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxBusqueda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gboxArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnMostrarTodoArticulos);
            this.Controls.Add(this.dataGridViewArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABMStockyArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Stock y Articulo";
            this.Load += new System.EventHandler(this.FrmGestionStockArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).EndInit();
            this.gboxArticulo.ResumeLayout(false);
            this.gboxArticulo.PerformLayout();
            this.gboxBusqueda.ResumeLayout(false);
            this.gboxBusqueda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarArt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStockActualArt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStockRepArt;
        private System.Windows.Forms.TextBox txtPrecioArt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockMax;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostoArt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtnStockY;
        private System.Windows.Forms.RadioButton rBtnStockN;
        private System.Windows.Forms.DataGridView dataGridViewArticulos;
        private System.Windows.Forms.ComboBox cmbFamiliaID;
        private System.Windows.Forms.ComboBox cmbUnidadID;
        private System.Windows.Forms.Button btnMostrarTodoArticulos;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMargenBeneficio;
        private System.Windows.Forms.GroupBox gboxArticulo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gboxBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBuscarFamilia;
        private System.Windows.Forms.TextBox txtBuscarArtDescrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrdenDescripCod;
        private System.Windows.Forms.RadioButton rdoDescripcion;
        private System.Windows.Forms.RadioButton rdoCodigo;
        private System.Windows.Forms.Label label13;
    }
}