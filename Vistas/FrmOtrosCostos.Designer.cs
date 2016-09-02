namespace Vistas
{
    partial class FrmOtrosCostos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtrosCostos));
            this.btnBuscarOtrosCostos = new System.Windows.Forms.Button();
            this.cmbBuscarUnidadID = new System.Windows.Forms.ComboBox();
            this.btnSalirOtrosCostos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUnidadID = new System.Windows.Forms.ComboBox();
            this.txtOtrosCostosId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarOtrosCostos = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOtrosCostos = new System.Windows.Forms.DataGridView();
            this.btnEliminarOtrosCostos = new System.Windows.Forms.Button();
            this.btnModificarOtrosCostos = new System.Windows.Forms.Button();
            this.btnMostrarOtrosCostos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtrosCostos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarOtrosCostos
            // 
            this.btnBuscarOtrosCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarOtrosCostos.Image = global::Vistas.Properties.Resources.buscar;
            this.btnBuscarOtrosCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOtrosCostos.Location = new System.Drawing.Point(594, 23);
            this.btnBuscarOtrosCostos.Name = "btnBuscarOtrosCostos";
            this.btnBuscarOtrosCostos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarOtrosCostos.TabIndex = 51;
            this.btnBuscarOtrosCostos.Text = "Buscar";
            this.btnBuscarOtrosCostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOtrosCostos.UseVisualStyleBackColor = true;
            this.btnBuscarOtrosCostos.Click += new System.EventHandler(this.btnBuscarOtrosCostos_Click);
            // 
            // cmbBuscarUnidadID
            // 
            this.cmbBuscarUnidadID.FormattingEnabled = true;
            this.cmbBuscarUnidadID.Location = new System.Drawing.Point(465, 24);
            this.cmbBuscarUnidadID.Name = "cmbBuscarUnidadID";
            this.cmbBuscarUnidadID.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarUnidadID.TabIndex = 59;
            // 
            // btnSalirOtrosCostos
            // 
            this.btnSalirOtrosCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirOtrosCostos.Image = global::Vistas.Properties.Resources.imgSalir;
            this.btnSalirOtrosCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirOtrosCostos.Location = new System.Drawing.Point(776, 64);
            this.btnSalirOtrosCostos.Name = "btnSalirOtrosCostos";
            this.btnSalirOtrosCostos.Size = new System.Drawing.Size(63, 23);
            this.btnSalirOtrosCostos.TabIndex = 58;
            this.btnSalirOtrosCostos.Text = "Salir";
            this.btnSalirOtrosCostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirOtrosCostos.UseVisualStyleBackColor = true;
            this.btnSalirOtrosCostos.Click += new System.EventHandler(this.btnSalirOtrosCostos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbUnidadID);
            this.groupBox1.Controls.Add(this.txtOtrosCostosId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardarOtrosCostos);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 302);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Otros Costos";
            // 
            // cmbUnidadID
            // 
            this.cmbUnidadID.FormattingEnabled = true;
            this.cmbUnidadID.Location = new System.Drawing.Point(131, 122);
            this.cmbUnidadID.Name = "cmbUnidadID";
            this.cmbUnidadID.Size = new System.Drawing.Size(121, 26);
            this.cmbUnidadID.TabIndex = 15;
            // 
            // txtOtrosCostosId
            // 
            this.txtOtrosCostosId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtrosCostosId.Location = new System.Drawing.Point(130, 50);
            this.txtOtrosCostosId.Name = "txtOtrosCostosId";
            this.txtOtrosCostosId.Size = new System.Drawing.Size(90, 22);
            this.txtOtrosCostosId.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "ID";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::Vistas.Properties.Resources.limpiar;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(188, 240);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            this.btnLimpiar.MouseLeave += new System.EventHandler(this.btnLimpiar_MouseLeave);
            this.btnLimpiar.MouseHover += new System.EventHandler(this.btnLimpiar_MouseHover);
            // 
            // btnGuardarOtrosCostos
            // 
            this.btnGuardarOtrosCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarOtrosCostos.Image = global::Vistas.Properties.Resources.imgGuardar;
            this.btnGuardarOtrosCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarOtrosCostos.Location = new System.Drawing.Point(32, 240);
            this.btnGuardarOtrosCostos.Name = "btnGuardarOtrosCostos";
            this.btnGuardarOtrosCostos.Size = new System.Drawing.Size(91, 23);
            this.btnGuardarOtrosCostos.TabIndex = 7;
            this.btnGuardarOtrosCostos.Text = "Guardar";
            this.btnGuardarOtrosCostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarOtrosCostos.UseVisualStyleBackColor = true;
            this.btnGuardarOtrosCostos.Click += new System.EventHandler(this.btnGuardarOtrosCostos_Click);
            this.btnGuardarOtrosCostos.MouseLeave += new System.EventHandler(this.btnGuardarOtrosCostos_MouseLeave);
            this.btnGuardarOtrosCostos.MouseHover += new System.EventHandler(this.btnGuardarOtrosCostos_MouseHover);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(130, 195);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(140, 22);
            this.txtObservacion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Observaciones";
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(130, 158);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(140, 22);
            this.txtCosto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidad Medida";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(130, 84);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(140, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // dataGridViewOtrosCostos
            // 
            this.dataGridViewOtrosCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOtrosCostos.Location = new System.Drawing.Point(353, 120);
            this.dataGridViewOtrosCostos.MultiSelect = false;
            this.dataGridViewOtrosCostos.Name = "dataGridViewOtrosCostos";
            this.dataGridViewOtrosCostos.ReadOnly = true;
            this.dataGridViewOtrosCostos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOtrosCostos.Size = new System.Drawing.Size(502, 161);
            this.dataGridViewOtrosCostos.TabIndex = 56;
            this.dataGridViewOtrosCostos.CurrentCellChanged += new System.EventHandler(this.dataGridViewOtrosCostos_CurrentCellChanged);
            // 
            // btnEliminarOtrosCostos
            // 
            this.btnEliminarOtrosCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarOtrosCostos.Image = global::Vistas.Properties.Resources.imgCancelar;
            this.btnEliminarOtrosCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarOtrosCostos.Location = new System.Drawing.Point(645, 64);
            this.btnEliminarOtrosCostos.Name = "btnEliminarOtrosCostos";
            this.btnEliminarOtrosCostos.Size = new System.Drawing.Size(80, 23);
            this.btnEliminarOtrosCostos.TabIndex = 54;
            this.btnEliminarOtrosCostos.Text = "Eliminar";
            this.btnEliminarOtrosCostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarOtrosCostos.UseVisualStyleBackColor = true;
            this.btnEliminarOtrosCostos.Click += new System.EventHandler(this.btnEliminarOtrosCostos_Click);
            // 
            // btnModificarOtrosCostos
            // 
            this.btnModificarOtrosCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarOtrosCostos.Image = global::Vistas.Properties.Resources.imgModificar;
            this.btnModificarOtrosCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarOtrosCostos.Location = new System.Drawing.Point(514, 64);
            this.btnModificarOtrosCostos.Name = "btnModificarOtrosCostos";
            this.btnModificarOtrosCostos.Size = new System.Drawing.Size(84, 23);
            this.btnModificarOtrosCostos.TabIndex = 53;
            this.btnModificarOtrosCostos.Text = "Modificar";
            this.btnModificarOtrosCostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarOtrosCostos.UseVisualStyleBackColor = true;
            this.btnModificarOtrosCostos.Click += new System.EventHandler(this.btnModificarOtrosCostos_Click);
            // 
            // btnMostrarOtrosCostos
            // 
            this.btnMostrarOtrosCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarOtrosCostos.Location = new System.Drawing.Point(358, 64);
            this.btnMostrarOtrosCostos.Name = "btnMostrarOtrosCostos";
            this.btnMostrarOtrosCostos.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarOtrosCostos.TabIndex = 52;
            this.btnMostrarOtrosCostos.Text = "Mostrar Todo";
            this.btnMostrarOtrosCostos.UseVisualStyleBackColor = true;
            this.btnMostrarOtrosCostos.Click += new System.EventHandler(this.btnMostrarOtrosCostos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Unidad Medida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "*Para Modificar y Eliminar  seleccione un registro de la tabla.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(358, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(399, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "*Para Agregar un Nuevo Usuario, hacer Click en Limpiar.";
            // 
            // FrmOtrosCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 344);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarOtrosCostos);
            this.Controls.Add(this.cmbBuscarUnidadID);
            this.Controls.Add(this.btnSalirOtrosCostos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewOtrosCostos);
            this.Controls.Add(this.btnEliminarOtrosCostos);
            this.Controls.Add(this.btnModificarOtrosCostos);
            this.Controls.Add(this.btnMostrarOtrosCostos);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOtrosCostos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otros Costos";
            this.Load += new System.EventHandler(this.FrmOtrosCostos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtrosCostos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarOtrosCostos;
        private System.Windows.Forms.ComboBox cmbBuscarUnidadID;
        private System.Windows.Forms.Button btnSalirOtrosCostos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbUnidadID;
        private System.Windows.Forms.TextBox txtOtrosCostosId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarOtrosCostos;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOtrosCostos;
        private System.Windows.Forms.Button btnEliminarOtrosCostos;
        private System.Windows.Forms.Button btnModificarOtrosCostos;
        private System.Windows.Forms.Button btnMostrarOtrosCostos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
    }
}