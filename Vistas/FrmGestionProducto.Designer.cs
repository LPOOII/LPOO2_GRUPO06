namespace Vistas
{
    partial class FrmGestionProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionProducto));
            this.cmbProductoTerminado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbArticulo = new System.Windows.Forms.GroupBox();
            this.dgvItemsMateriaPrima = new System.Windows.Forms.DataGridView();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.btnAgregarMateriaPrima = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.cmbArticuloId = new System.Windows.Forms.ComboBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAgregarProductoTerminado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDescripcionOc = new System.Windows.Forms.ComboBox();
            this.btnAgregarOtrosCostos = new System.Windows.Forms.Button();
            this.dgvItemsOtrosCostos = new System.Windows.Forms.DataGridView();
            this.txtImporteOc = new System.Windows.Forms.TextBox();
            this.nupdOtrosCostos = new System.Windows.Forms.NumericUpDown();
            this.txtOtrosCostos = new System.Windows.Forms.TextBox();
            this.cmbOcId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsOtrosCostos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdOtrosCostos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProductoTerminado
            // 
            this.cmbProductoTerminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductoTerminado.FormattingEnabled = true;
            this.cmbProductoTerminado.Location = new System.Drawing.Point(143, 34);
            this.cmbProductoTerminado.Name = "cmbProductoTerminado";
            this.cmbProductoTerminado.Size = new System.Drawing.Size(121, 21);
            this.cmbProductoTerminado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto Terminado";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Vistas.Properties.Resources.imgSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(537, 27);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbArticulo
            // 
            this.gbArticulo.BackColor = System.Drawing.Color.Transparent;
            this.gbArticulo.Controls.Add(this.dgvItemsMateriaPrima);
            this.gbArticulo.Controls.Add(this.cmbDescripcion);
            this.gbArticulo.Controls.Add(this.btnAgregarMateriaPrima);
            this.gbArticulo.Controls.Add(this.txtImporte);
            this.gbArticulo.Controls.Add(this.numericUpDownCantidad);
            this.gbArticulo.Controls.Add(this.txtCosto);
            this.gbArticulo.Controls.Add(this.cmbArticuloId);
            this.gbArticulo.Controls.Add(this.lblImporte);
            this.gbArticulo.Controls.Add(this.lblCantidad);
            this.gbArticulo.Controls.Add(this.lblCosto);
            this.gbArticulo.Controls.Add(this.lblDescripcion);
            this.gbArticulo.Controls.Add(this.lblId);
            this.gbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArticulo.Location = new System.Drawing.Point(39, 89);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Size = new System.Drawing.Size(756, 250);
            this.gbArticulo.TabIndex = 13;
            this.gbArticulo.TabStop = false;
            this.gbArticulo.Text = "Materia Prima";
            // 
            // dgvItemsMateriaPrima
            // 
            this.dgvItemsMateriaPrima.AllowUserToDeleteRows = false;
            this.dgvItemsMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsMateriaPrima.Location = new System.Drawing.Point(282, 19);
            this.dgvItemsMateriaPrima.Name = "dgvItemsMateriaPrima";
            this.dgvItemsMateriaPrima.ReadOnly = true;
            this.dgvItemsMateriaPrima.Size = new System.Drawing.Size(452, 189);
            this.dgvItemsMateriaPrima.TabIndex = 19;
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(109, 29);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(121, 21);
            this.cmbDescripcion.TabIndex = 2;
            this.cmbDescripcion.SelectionChangeCommitted += new System.EventHandler(this.cmbDescripcion_SelectionChangeCommitted);
            // 
            // btnAgregarMateriaPrima
            // 
            this.btnAgregarMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateriaPrima.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarMateriaPrima.Image")));
            this.btnAgregarMateriaPrima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMateriaPrima.Location = new System.Drawing.Point(88, 199);
            this.btnAgregarMateriaPrima.Name = "btnAgregarMateriaPrima";
            this.btnAgregarMateriaPrima.Size = new System.Drawing.Size(142, 23);
            this.btnAgregarMateriaPrima.TabIndex = 7;
            this.btnAgregarMateriaPrima.Text = "Agregar Materias Primas";
            this.btnAgregarMateriaPrima.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarMateriaPrima.UseVisualStyleBackColor = true;
            this.btnAgregarMateriaPrima.Click += new System.EventHandler(this.btnAgregarMateriaPrima_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(109, 163);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(120, 20);
            this.txtImporte.TabIndex = 6;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCantidad.Location = new System.Drawing.Point(109, 130);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCantidad.TabIndex = 5;
            this.numericUpDownCantidad.ValueChanged += new System.EventHandler(this.numericUpDownCantidad_ValueChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(109, 97);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(121, 20);
            this.txtCosto.TabIndex = 4;
            // 
            // cmbArticuloId
            // 
            this.cmbArticuloId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticuloId.FormattingEnabled = true;
            this.cmbArticuloId.Location = new System.Drawing.Point(109, 63);
            this.cmbArticuloId.Name = "cmbArticuloId";
            this.cmbArticuloId.Size = new System.Drawing.Size(121, 21);
            this.cmbArticuloId.TabIndex = 3;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(33, 164);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "Importe:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(33, 131);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(33, 98);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(37, 13);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Costo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(33, 32);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(33, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // btnAgregarProductoTerminado
            // 
            this.btnAgregarProductoTerminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductoTerminado.Image = global::Vistas.Properties.Resources.imgGuardar;
            this.btnAgregarProductoTerminado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductoTerminado.Location = new System.Drawing.Point(429, 27);
            this.btnAgregarProductoTerminado.Name = "btnAgregarProductoTerminado";
            this.btnAgregarProductoTerminado.Size = new System.Drawing.Size(81, 23);
            this.btnAgregarProductoTerminado.TabIndex = 16;
            this.btnAgregarProductoTerminado.Text = "Guardar";
            this.btnAgregarProductoTerminado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductoTerminado.UseVisualStyleBackColor = true;
            this.btnAgregarProductoTerminado.Click += new System.EventHandler(this.btnAgregarProductoTerminado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbDescripcionOc);
            this.groupBox1.Controls.Add(this.btnAgregarOtrosCostos);
            this.groupBox1.Controls.Add(this.dgvItemsOtrosCostos);
            this.groupBox1.Controls.Add(this.txtImporteOc);
            this.groupBox1.Controls.Add(this.nupdOtrosCostos);
            this.groupBox1.Controls.Add(this.txtOtrosCostos);
            this.groupBox1.Controls.Add(this.cmbOcId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 237);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otros Costos";
            // 
            // cmbDescripcionOc
            // 
            this.cmbDescripcionOc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDescripcionOc.FormattingEnabled = true;
            this.cmbDescripcionOc.Location = new System.Drawing.Point(109, 29);
            this.cmbDescripcionOc.Name = "cmbDescripcionOc";
            this.cmbDescripcionOc.Size = new System.Drawing.Size(121, 21);
            this.cmbDescripcionOc.TabIndex = 8;
            this.cmbDescripcionOc.SelectionChangeCommitted += new System.EventHandler(this.cmbDescripcionOc_SelectionChangeCommitted);
            // 
            // btnAgregarOtrosCostos
            // 
            this.btnAgregarOtrosCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOtrosCostos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarOtrosCostos.Image")));
            this.btnAgregarOtrosCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarOtrosCostos.Location = new System.Drawing.Point(88, 205);
            this.btnAgregarOtrosCostos.Name = "btnAgregarOtrosCostos";
            this.btnAgregarOtrosCostos.Size = new System.Drawing.Size(128, 23);
            this.btnAgregarOtrosCostos.TabIndex = 13;
            this.btnAgregarOtrosCostos.Text = "Agregar Otros Costos";
            this.btnAgregarOtrosCostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarOtrosCostos.UseVisualStyleBackColor = true;
            this.btnAgregarOtrosCostos.Click += new System.EventHandler(this.btnAgregarOtrosCostos_Click);
            // 
            // dgvItemsOtrosCostos
            // 
            this.dgvItemsOtrosCostos.AllowUserToDeleteRows = false;
            this.dgvItemsOtrosCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsOtrosCostos.Location = new System.Drawing.Point(282, 19);
            this.dgvItemsOtrosCostos.Name = "dgvItemsOtrosCostos";
            this.dgvItemsOtrosCostos.ReadOnly = true;
            this.dgvItemsOtrosCostos.Size = new System.Drawing.Size(452, 177);
            this.dgvItemsOtrosCostos.TabIndex = 15;
            // 
            // txtImporteOc
            // 
            this.txtImporteOc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteOc.Location = new System.Drawing.Point(109, 163);
            this.txtImporteOc.Name = "txtImporteOc";
            this.txtImporteOc.Size = new System.Drawing.Size(120, 20);
            this.txtImporteOc.TabIndex = 12;
            // 
            // nupdOtrosCostos
            // 
            this.nupdOtrosCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdOtrosCostos.Location = new System.Drawing.Point(109, 130);
            this.nupdOtrosCostos.Name = "nupdOtrosCostos";
            this.nupdOtrosCostos.Size = new System.Drawing.Size(120, 20);
            this.nupdOtrosCostos.TabIndex = 11;
            this.nupdOtrosCostos.ValueChanged += new System.EventHandler(this.nupdOtrosCostos_ValueChanged);
            // 
            // txtOtrosCostos
            // 
            this.txtOtrosCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtrosCostos.Location = new System.Drawing.Point(109, 97);
            this.txtOtrosCostos.Name = "txtOtrosCostos";
            this.txtOtrosCostos.Size = new System.Drawing.Size(121, 20);
            this.txtOtrosCostos.TabIndex = 10;
            // 
            // cmbOcId
            // 
            this.cmbOcId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOcId.FormattingEnabled = true;
            this.cmbOcId.Location = new System.Drawing.Point(109, 63);
            this.cmbOcId.Name = "cmbOcId";
            this.cmbOcId.Size = new System.Drawing.Size(121, 21);
            this.cmbOcId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Importe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Costo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbProductoTerminado);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnAgregarProductoTerminado);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 66);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto Terminado";
            // 
            // FrmGestionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Productos";
            this.Load += new System.EventHandler(this.FrmGestionProducto_Load);
            this.gbArticulo.ResumeLayout(false);
            this.gbArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsOtrosCostos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdOtrosCostos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductoTerminado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbArticulo;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.Button btnAgregarMateriaPrima;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.ComboBox cmbArticuloId;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAgregarProductoTerminado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDescripcionOc;
        private System.Windows.Forms.Button btnAgregarOtrosCostos;
        private System.Windows.Forms.TextBox txtImporteOc;
        private System.Windows.Forms.NumericUpDown nupdOtrosCostos;
        private System.Windows.Forms.TextBox txtOtrosCostos;
        private System.Windows.Forms.ComboBox cmbOcId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvItemsOtrosCostos;
        private System.Windows.Forms.DataGridView dgvItemsMateriaPrima;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}