namespace Vistas
{
    partial class FrmOrdendeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdendeCompra));
            this.gbArticulo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.cmbArticuloId = new System.Windows.Forms.ComboBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gbOrdenCompra = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.dataGridViewItemsCompras = new System.Windows.Forms.DataGridView();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.gbArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.gbOrdenCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // gbArticulo
            // 
            this.gbArticulo.BackColor = System.Drawing.Color.Transparent;
            this.gbArticulo.Controls.Add(this.pictureBox1);
            this.gbArticulo.Controls.Add(this.cmbDescripcion);
            this.gbArticulo.Controls.Add(this.btnAgregar);
            this.gbArticulo.Controls.Add(this.txtImporte);
            this.gbArticulo.Controls.Add(this.numericUpDownCantidad);
            this.gbArticulo.Controls.Add(this.txtCosto);
            this.gbArticulo.Controls.Add(this.cmbArticuloId);
            this.gbArticulo.Controls.Add(this.lblImporte);
            this.gbArticulo.Controls.Add(this.lblCantidad);
            this.gbArticulo.Controls.Add(this.lblCosto);
            this.gbArticulo.Controls.Add(this.lblDescripcion);
            this.gbArticulo.Controls.Add(this.lblId);
            this.gbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArticulo.Location = new System.Drawing.Point(550, 30);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Size = new System.Drawing.Size(248, 354);
            this.gbArticulo.TabIndex = 6;
            this.gbArticulo.TabStop = false;
            this.gbArticulo.Text = "Articulo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(99, 25);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(121, 23);
            this.cmbDescripcion.TabIndex = 2;
            this.cmbDescripcion.SelectionChangeCommitted += new System.EventHandler(this.cmbDescripcion_SelectionChangeCommitted);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Vistas.Properties.Resources.Add;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(99, 202);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(99, 159);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(120, 21);
            this.txtImporte.TabIndex = 6;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(99, 126);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownCantidad.TabIndex = 5;
            this.numericUpDownCantidad.ValueChanged += new System.EventHandler(this.numericUpDownCantidad_ValueChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(99, 93);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(121, 21);
            this.txtCosto.TabIndex = 4;
            // 
            // cmbArticuloId
            // 
            this.cmbArticuloId.FormattingEnabled = true;
            this.cmbArticuloId.Location = new System.Drawing.Point(99, 59);
            this.cmbArticuloId.Name = "cmbArticuloId";
            this.cmbArticuloId.Size = new System.Drawing.Size(121, 23);
            this.cmbArticuloId.TabIndex = 3;
            this.cmbArticuloId.SelectionChangeCommitted += new System.EventHandler(this.cmbArticuloId_SelectionChangeCommitted);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(23, 160);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(52, 15);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "Importe:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(23, 127);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(59, 15);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(23, 94);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(41, 15);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Costo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(23, 28);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 61);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // gbOrdenCompra
            // 
            this.gbOrdenCompra.BackColor = System.Drawing.Color.Transparent;
            this.gbOrdenCompra.Controls.Add(this.btnSalir);
            this.gbOrdenCompra.Controls.Add(this.btnAgregarProveedor);
            this.gbOrdenCompra.Controls.Add(this.dataGridViewItemsCompras);
            this.gbOrdenCompra.Controls.Add(this.cmbProveedor);
            this.gbOrdenCompra.Controls.Add(this.lblProveedor);
            this.gbOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrdenCompra.Location = new System.Drawing.Point(12, 30);
            this.gbOrdenCompra.Name = "gbOrdenCompra";
            this.gbOrdenCompra.Size = new System.Drawing.Size(517, 354);
            this.gbOrdenCompra.TabIndex = 5;
            this.gbOrdenCompra.TabStop = false;
            this.gbOrdenCompra.Text = "Orden de Compra";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Vistas.Properties.Resources.imgSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(420, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.Image = global::Vistas.Properties.Resources.Add;
            this.btnAgregarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(263, 24);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(153, 23);
            this.btnAgregarProveedor.TabIndex = 8;
            this.btnAgregarProveedor.Text = "Agregar Orden de Compra";
            this.btnAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // dataGridViewItemsCompras
            // 
            this.dataGridViewItemsCompras.AllowUserToDeleteRows = false;
            this.dataGridViewItemsCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemsCompras.Location = new System.Drawing.Point(28, 79);
            this.dataGridViewItemsCompras.MultiSelect = false;
            this.dataGridViewItemsCompras.Name = "dataGridViewItemsCompras";
            this.dataGridViewItemsCompras.ReadOnly = true;
            this.dataGridViewItemsCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItemsCompras.Size = new System.Drawing.Size(459, 249);
            this.dataGridViewItemsCompras.TabIndex = 6;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(111, 24);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 23);
            this.cmbProveedor.TabIndex = 1;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(25, 32);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(66, 15);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // FrmOrdendeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 412);
            this.Controls.Add(this.gbArticulo);
            this.Controls.Add(this.gbOrdenCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdendeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Compra";
            this.Load += new System.EventHandler(this.FrmOrdendeCompra_Load);
            this.gbArticulo.ResumeLayout(false);
            this.gbArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.gbOrdenCompra.ResumeLayout(false);
            this.gbOrdenCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbArticulo;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.ComboBox cmbArticuloId;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gbOrdenCompra;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DataGridView dataGridViewItemsCompras;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}