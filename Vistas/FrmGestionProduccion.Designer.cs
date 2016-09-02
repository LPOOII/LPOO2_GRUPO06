namespace Vistas
{
    partial class FrmGestionProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionProduccion));
            this.dgvItemsOtrosCostos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarProductoTerminado = new System.Windows.Forms.Button();
            this.dgvItemsMateriaPrima = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbArticulo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProductoTerminado = new System.Windows.Forms.ComboBox();
            this.nudProCantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImporteMateriaP = new System.Windows.Forms.Label();
            this.lblImporteCosto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsOtrosCostos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsMateriaPrima)).BeginInit();
            this.gbArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItemsOtrosCostos
            // 
            this.dgvItemsOtrosCostos.AllowUserToDeleteRows = false;
            this.dgvItemsOtrosCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsOtrosCostos.Location = new System.Drawing.Point(13, 19);
            this.dgvItemsOtrosCostos.Name = "dgvItemsOtrosCostos";
            this.dgvItemsOtrosCostos.ReadOnly = true;
            this.dgvItemsOtrosCostos.Size = new System.Drawing.Size(472, 150);
            this.dgvItemsOtrosCostos.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblImporteCosto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvItemsOtrosCostos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 242);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otros Costos";
            // 
            // btnAgregarProductoTerminado
            // 
            this.btnAgregarProductoTerminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductoTerminado.Image = global::Vistas.Properties.Resources.imgGuardar;
            this.btnAgregarProductoTerminado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductoTerminado.Location = new System.Drawing.Point(265, 101);
            this.btnAgregarProductoTerminado.Name = "btnAgregarProductoTerminado";
            this.btnAgregarProductoTerminado.Size = new System.Drawing.Size(80, 23);
            this.btnAgregarProductoTerminado.TabIndex = 6;
            this.btnAgregarProductoTerminado.Text = "Guardar";
            this.btnAgregarProductoTerminado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductoTerminado.UseVisualStyleBackColor = true;
            this.btnAgregarProductoTerminado.Click += new System.EventHandler(this.btnAgregarProductoTerminado_Click);
            // 
            // dgvItemsMateriaPrima
            // 
            this.dgvItemsMateriaPrima.AllowUserToDeleteRows = false;
            this.dgvItemsMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsMateriaPrima.Location = new System.Drawing.Point(13, 19);
            this.dgvItemsMateriaPrima.Name = "dgvItemsMateriaPrima";
            this.dgvItemsMateriaPrima.ReadOnly = true;
            this.dgvItemsMateriaPrima.Size = new System.Drawing.Size(472, 150);
            this.dgvItemsMateriaPrima.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Vistas.Properties.Resources.imgSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(372, 102);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbArticulo
            // 
            this.gbArticulo.BackColor = System.Drawing.Color.Transparent;
            this.gbArticulo.Controls.Add(this.lblImporteMateriaP);
            this.gbArticulo.Controls.Add(this.label3);
            this.gbArticulo.Controls.Add(this.dgvItemsMateriaPrima);
            this.gbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArticulo.Location = new System.Drawing.Point(61, 145);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Size = new System.Drawing.Size(498, 218);
            this.gbArticulo.TabIndex = 20;
            this.gbArticulo.TabStop = false;
            this.gbArticulo.Text = "Materia Prima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Producto:";
            // 
            // cmbProductoTerminado
            // 
            this.cmbProductoTerminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductoTerminado.FormattingEnabled = true;
            this.cmbProductoTerminado.Location = new System.Drawing.Point(103, 67);
            this.cmbProductoTerminado.Name = "cmbProductoTerminado";
            this.cmbProductoTerminado.Size = new System.Drawing.Size(121, 21);
            this.cmbProductoTerminado.TabIndex = 2;
            this.cmbProductoTerminado.SelectionChangeCommitted += new System.EventHandler(this.cmbProductoTerminado_SelectionChangeCommitted);
            // 
            // nudProCantidad
            // 
            this.nudProCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProCantidad.Location = new System.Drawing.Point(102, 105);
            this.nudProCantidad.Name = "nudProCantidad";
            this.nudProCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudProCantidad.TabIndex = 3;
            this.nudProCantidad.ValueChanged += new System.EventHandler(this.nudProCantidad_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(103, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(209, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbProductoTerminado);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gbArticulo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.nudProCantidad);
            this.groupBox2.Controls.Add(this.btnAgregarProductoTerminado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 607);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Producción de Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Importe Total:";
            // 
            // lblImporteMateriaP
            // 
            this.lblImporteMateriaP.AutoSize = true;
            this.lblImporteMateriaP.Location = new System.Drawing.Point(462, 174);
            this.lblImporteMateriaP.Name = "lblImporteMateriaP";
            this.lblImporteMateriaP.Size = new System.Drawing.Size(14, 15);
            this.lblImporteMateriaP.TabIndex = 24;
            this.lblImporteMateriaP.Text = "0";
            // 
            // lblImporteCosto
            // 
            this.lblImporteCosto.AutoSize = true;
            this.lblImporteCosto.Location = new System.Drawing.Point(449, 180);
            this.lblImporteCosto.Name = "lblImporteCosto";
            this.lblImporteCosto.Size = new System.Drawing.Size(14, 15);
            this.lblImporteCosto.TabIndex = 26;
            this.lblImporteCosto.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Importe Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Costo Total de Producción:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(312, 211);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "0";
            // 
            // FrmGestionProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 645);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Produccion de Productos";
            this.Load += new System.EventHandler(this.FrmGestionProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsOtrosCostos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsMateriaPrima)).EndInit();
            this.gbArticulo.ResumeLayout(false);
            this.gbArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItemsOtrosCostos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarProductoTerminado;
        private System.Windows.Forms.DataGridView dgvItemsMateriaPrima;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductoTerminado;
        private System.Windows.Forms.NumericUpDown nudProCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblImporteCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblImporteMateriaP;
        private System.Windows.Forms.Label label3;
    }
}