namespace Vistas
{
    partial class FrmABMProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMProveedor));
            this.gbProv = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtDpto = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProveedor = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrdenarbyNombre = new System.Windows.Forms.Button();
            this.txtBuscarDpto = new System.Windows.Forms.TextBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMostrarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gbProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProv
            // 
            this.gbProv.BackColor = System.Drawing.Color.Transparent;
            this.gbProv.Controls.Add(this.button2);
            this.gbProv.Controls.Add(this.btnGuardarProveedor);
            this.gbProv.Controls.Add(this.label8);
            this.gbProv.Controls.Add(this.txtEmail);
            this.gbProv.Controls.Add(this.txtTelefono);
            this.gbProv.Controls.Add(this.txtCodPostal);
            this.gbProv.Controls.Add(this.txtDpto);
            this.gbProv.Controls.Add(this.txtDomicilio);
            this.gbProv.Controls.Add(this.txtNombre);
            this.gbProv.Controls.Add(this.txtId);
            this.gbProv.Controls.Add(this.label7);
            this.gbProv.Controls.Add(this.label6);
            this.gbProv.Controls.Add(this.label5);
            this.gbProv.Controls.Add(this.label4);
            this.gbProv.Controls.Add(this.label3);
            this.gbProv.Controls.Add(this.label2);
            this.gbProv.Controls.Add(this.label1);
            this.gbProv.Location = new System.Drawing.Point(25, 11);
            this.gbProv.Name = "gbProv";
            this.gbProv.Size = new System.Drawing.Size(285, 394);
            this.gbProv.TabIndex = 0;
            this.gbProv.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = global::Vistas.Properties.Resources.limpiar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(185, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Image = global::Vistas.Properties.Resources.imgGuardar;
            this.btnGuardarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProveedor.Location = new System.Drawing.Point(69, 328);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProveedor.TabIndex = 8;
            this.btnGuardarProveedor.Text = "Guardar";
            this.btnGuardarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Datos Proveedor";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(113, 233);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(113, 199);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(139, 20);
            this.txtCodPostal.TabIndex = 5;
            // 
            // txtDpto
            // 
            this.txtDpto.Location = new System.Drawing.Point(113, 165);
            this.txtDpto.Name = "txtDpto";
            this.txtDpto.Size = new System.Drawing.Size(139, 20);
            this.txtDpto.TabIndex = 4;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(113, 131);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(139, 20);
            this.txtDomicilio.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 63);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(66, 20);
            this.txtId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Domicilio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // dataGridViewProveedor
            // 
            this.dataGridViewProveedor.AllowUserToAddRows = false;
            this.dataGridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedor.Location = new System.Drawing.Point(330, 156);
            this.dataGridViewProveedor.Name = "dataGridViewProveedor";
            this.dataGridViewProveedor.ReadOnly = true;
            this.dataGridViewProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProveedor.Size = new System.Drawing.Size(542, 224);
            this.dataGridViewProveedor.TabIndex = 18;
            this.dataGridViewProveedor.CurrentCellChanged += new System.EventHandler(this.dataGridViewProveedor_CurrentCellChanged);
            // 
            // button3
            // 
            this.button3.Image = global::Vistas.Properties.Resources.buscar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(6, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Buscar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnOrdenarbyNombre);
            this.groupBox2.Controls.Add(this.txtBuscarDpto);
            this.groupBox2.Controls.Add(this.txtBuscarNombre);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(330, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnOrdenarbyNombre
            // 
            this.btnOrdenarbyNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarbyNombre.Location = new System.Drawing.Point(190, 46);
            this.btnOrdenarbyNombre.Name = "btnOrdenarbyNombre";
            this.btnOrdenarbyNombre.Size = new System.Drawing.Size(111, 23);
            this.btnOrdenarbyNombre.TabIndex = 13;
            this.btnOrdenarbyNombre.Text = "Ordenar por Nombre";
            this.btnOrdenarbyNombre.UseVisualStyleBackColor = true;
            this.btnOrdenarbyNombre.Click += new System.EventHandler(this.btnOrdenarbyNombre_Click);
            // 
            // txtBuscarDpto
            // 
            this.txtBuscarDpto.Location = new System.Drawing.Point(347, 17);
            this.txtBuscarDpto.Name = "txtBuscarDpto";
            this.txtBuscarDpto.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarDpto.TabIndex = 12;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(146, 17);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarNombre.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Departamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre:";
            // 
            // btnMostrarProveedor
            // 
            this.btnMostrarProveedor.Location = new System.Drawing.Point(336, 102);
            this.btnMostrarProveedor.Name = "btnMostrarProveedor";
            this.btnMostrarProveedor.Size = new System.Drawing.Size(89, 23);
            this.btnMostrarProveedor.TabIndex = 14;
            this.btnMostrarProveedor.Text = "Mostrar Todo";
            this.btnMostrarProveedor.UseVisualStyleBackColor = true;
            this.btnMostrarProveedor.Click += new System.EventHandler(this.btnMostrarProveedor_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Image = global::Vistas.Properties.Resources.imgCancelar;
            this.btnEliminarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(584, 102);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(72, 23);
            this.btnEliminarProveedor.TabIndex = 16;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Image = global::Vistas.Properties.Resources.imgModificar;
            this.btnModificarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProveedor.Location = new System.Drawing.Point(467, 102);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProveedor.TabIndex = 15;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(335, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(430, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "*Para Modificar y Eliminar  seleccione un registro de la tabla.";
            // 
            // button1
            // 
            this.button1.Image = global::Vistas.Properties.Resources.imgSalir;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(701, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(335, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(418, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "*Para Agregar un Nuevo Proveedor, hacer Click en Limpiar.";
            // 
            // FrmABMProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 418);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnMostrarProveedor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewProveedor);
            this.Controls.Add(this.gbProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABMProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestionCompra";
            this.Load += new System.EventHandler(this.FrmABMProveedor_Load);
            this.gbProv.ResumeLayout(false);
            this.gbProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtDpto;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProveedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarDpto;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMostrarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOrdenarbyNombre;
    }
}