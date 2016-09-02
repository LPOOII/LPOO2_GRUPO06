namespace Vistas
{
    partial class FrmCompraRealizada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompraRealizada));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.dateTimeFechaCompra2 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCompra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFechaCompra1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarCompra = new System.Windows.Forms.Button();
            this.dataGridViewCompraRealizada = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompraRealizada)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.rbSi);
            this.groupBox1.Controls.Add(this.dateTimeFechaCompra2);
            this.groupBox1.Controls.Add(this.btnBuscarCompra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimeFechaCompra1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 126);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(133, 42);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 14;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(80, 42);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(34, 17);
            this.rbSi.TabIndex = 13;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaCompra2
            // 
            this.dateTimeFechaCompra2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaCompra2.Location = new System.Drawing.Point(221, 77);
            this.dateTimeFechaCompra2.Name = "dateTimeFechaCompra2";
            this.dateTimeFechaCompra2.Size = new System.Drawing.Size(89, 20);
            this.dateTimeFechaCompra2.TabIndex = 8;
            // 
            // btnBuscarCompra
            // 
            this.btnBuscarCompra.Image = global::Vistas.Properties.Resources.buscar;
            this.btnBuscarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCompra.Location = new System.Drawing.Point(330, 42);
            this.btnBuscarCompra.Name = "btnBuscarCompra";
            this.btnBuscarCompra.Size = new System.Drawing.Size(70, 34);
            this.btnBuscarCompra.TabIndex = 6;
            this.btnBuscarCompra.Text = "Buscar";
            this.btnBuscarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCompra.UseVisualStyleBackColor = true;
            this.btnBuscarCompra.Click += new System.EventHandler(this.btnBuscarCompra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pagada:";
            // 
            // dateTimeFechaCompra1
            // 
            this.dateTimeFechaCompra1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFechaCompra1.Location = new System.Drawing.Point(66, 77);
            this.dateTimeFechaCompra1.Name = "dateTimeFechaCompra1";
            this.dateTimeFechaCompra1.Size = new System.Drawing.Size(79, 20);
            this.dateTimeFechaCompra1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hasta:";
            // 
            // btnMostrarCompra
            // 
            this.btnMostrarCompra.Location = new System.Drawing.Point(38, 397);
            this.btnMostrarCompra.Name = "btnMostrarCompra";
            this.btnMostrarCompra.Size = new System.Drawing.Size(84, 23);
            this.btnMostrarCompra.TabIndex = 16;
            this.btnMostrarCompra.Text = "Mostrar Todo";
            this.btnMostrarCompra.UseVisualStyleBackColor = true;
            this.btnMostrarCompra.Click += new System.EventHandler(this.btnMostrarCompra_Click);
            // 
            // dataGridViewCompraRealizada
            // 
            this.dataGridViewCompraRealizada.AllowUserToAddRows = false;
            this.dataGridViewCompraRealizada.AllowUserToDeleteRows = false;
            this.dataGridViewCompraRealizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompraRealizada.Location = new System.Drawing.Point(38, 191);
            this.dataGridViewCompraRealizada.Name = "dataGridViewCompraRealizada";
            this.dataGridViewCompraRealizada.ReadOnly = true;
            this.dataGridViewCompraRealizada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompraRealizada.Size = new System.Drawing.Size(440, 179);
            this.dataGridViewCompraRealizada.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "COMPRAS REALIZADAS";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Vistas.Properties.Resources.imgSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(403, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(57, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmCompraRealizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 440);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMostrarCompra);
            this.Controls.Add(this.dataGridViewCompraRealizada);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompraRealizada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras Realizadas";
            this.Load += new System.EventHandler(this.FrmCompraRealizada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompraRealizada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCompra2;
        private System.Windows.Forms.Button btnBuscarCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCompra1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrarCompra;
        private System.Windows.Forms.DataGridView dataGridViewCompraRealizada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;

    }
}