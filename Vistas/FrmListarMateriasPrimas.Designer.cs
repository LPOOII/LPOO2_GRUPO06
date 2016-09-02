namespace Vistas
{
    partial class FrmListarMateriasPrimas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarMateriasPrimas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnSalirListarStock = new System.Windows.Forms.Button();
            this.btnListarStock = new System.Windows.Forms.Button();
            this.rbStockDebajo = new System.Windows.Forms.RadioButton();
            this.rbStockMinimo = new System.Windows.Forms.RadioButton();
            this.dataGridViewListasStocks = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListasStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnMostrarTodo);
            this.groupBox1.Controls.Add(this.btnSalirListarStock);
            this.groupBox1.Controls.Add(this.btnListarStock);
            this.groupBox1.Controls.Add(this.rbStockDebajo);
            this.groupBox1.Controls.Add(this.rbStockMinimo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 129);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes de Stock de Materia Prima";
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.Location = new System.Drawing.Point(126, 104);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(107, 25);
            this.btnMostrarTodo.TabIndex = 4;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnSalirListarStock
            // 
            this.btnSalirListarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirListarStock.Image = global::Vistas.Properties.Resources.imgSalir;
            this.btnSalirListarStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirListarStock.Location = new System.Drawing.Point(280, 104);
            this.btnSalirListarStock.Name = "btnSalirListarStock";
            this.btnSalirListarStock.Size = new System.Drawing.Size(68, 25);
            this.btnSalirListarStock.TabIndex = 3;
            this.btnSalirListarStock.Text = "Salir";
            this.btnSalirListarStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirListarStock.UseVisualStyleBackColor = true;
            this.btnSalirListarStock.Click += new System.EventHandler(this.btnSalirListarStock_Click);
            // 
            // btnListarStock
            // 
            this.btnListarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarStock.Location = new System.Drawing.Point(289, 53);
            this.btnListarStock.Name = "btnListarStock";
            this.btnListarStock.Size = new System.Drawing.Size(107, 25);
            this.btnListarStock.TabIndex = 2;
            this.btnListarStock.Text = "Listar Stock";
            this.btnListarStock.UseVisualStyleBackColor = true;
            this.btnListarStock.Click += new System.EventHandler(this.btnListarStock_Click);
            // 
            // rbStockDebajo
            // 
            this.rbStockDebajo.AutoSize = true;
            this.rbStockDebajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStockDebajo.Location = new System.Drawing.Point(12, 68);
            this.rbStockDebajo.Name = "rbStockDebajo";
            this.rbStockDebajo.Size = new System.Drawing.Size(260, 20);
            this.rbStockDebajo.TabIndex = 1;
            this.rbStockDebajo.TabStop = true;
            this.rbStockDebajo.Text = "Por Debajo del Stock Punto del Pedido";
            this.rbStockDebajo.UseVisualStyleBackColor = true;
            // 
            // rbStockMinimo
            // 
            this.rbStockMinimo.AutoSize = true;
            this.rbStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStockMinimo.Location = new System.Drawing.Point(12, 42);
            this.rbStockMinimo.Name = "rbStockMinimo";
            this.rbStockMinimo.Size = new System.Drawing.Size(200, 20);
            this.rbStockMinimo.TabIndex = 0;
            this.rbStockMinimo.TabStop = true;
            this.rbStockMinimo.Text = "Por Debajo del Stock Minimo";
            this.rbStockMinimo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListasStocks
            // 
            this.dataGridViewListasStocks.AllowUserToAddRows = false;
            this.dataGridViewListasStocks.AllowUserToDeleteRows = false;
            this.dataGridViewListasStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListasStocks.Location = new System.Drawing.Point(74, 186);
            this.dataGridViewListasStocks.MultiSelect = false;
            this.dataGridViewListasStocks.Name = "dataGridViewListasStocks";
            this.dataGridViewListasStocks.ReadOnly = true;
            this.dataGridViewListasStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListasStocks.Size = new System.Drawing.Size(570, 205);
            this.dataGridViewListasStocks.TabIndex = 7;
            // 
            // FrmListarMateriasPrimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewListasStocks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarMateriasPrimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Stocks MateriasPrimas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListasStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalirListarStock;
        private System.Windows.Forms.Button btnListarStock;
        private System.Windows.Forms.RadioButton rbStockDebajo;
        private System.Windows.Forms.RadioButton rbStockMinimo;
        private System.Windows.Forms.DataGridView dataGridViewListasStocks;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}