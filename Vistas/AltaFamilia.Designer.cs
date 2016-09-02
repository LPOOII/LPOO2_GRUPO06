namespace Vistas
{
    partial class AltaFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaFamilia));
            this.txtFamiliaDescripcion = new System.Windows.Forms.TextBox();
            this.lblFamiliaDescripcion = new System.Windows.Forms.Label();
            this.btnAltaFamilia = new System.Windows.Forms.Button();
            this.btnCancelarFamilia = new System.Windows.Forms.Button();
            this.dgvFamilia = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFamiliaDescripcion
            // 
            this.txtFamiliaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamiliaDescripcion.Location = new System.Drawing.Point(129, 45);
            this.txtFamiliaDescripcion.Name = "txtFamiliaDescripcion";
            this.txtFamiliaDescripcion.Size = new System.Drawing.Size(158, 22);
            this.txtFamiliaDescripcion.TabIndex = 1;
            // 
            // lblFamiliaDescripcion
            // 
            this.lblFamiliaDescripcion.AutoSize = true;
            this.lblFamiliaDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblFamiliaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamiliaDescripcion.Location = new System.Drawing.Point(49, 51);
            this.lblFamiliaDescripcion.Name = "lblFamiliaDescripcion";
            this.lblFamiliaDescripcion.Size = new System.Drawing.Size(83, 16);
            this.lblFamiliaDescripcion.TabIndex = 3;
            this.lblFamiliaDescripcion.Text = "Descripción:";
            // 
            // btnAltaFamilia
            // 
            this.btnAltaFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaFamilia.Image = global::Vistas.Properties.Resources.imgGuardar;
            this.btnAltaFamilia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaFamilia.Location = new System.Drawing.Point(69, 105);
            this.btnAltaFamilia.Name = "btnAltaFamilia";
            this.btnAltaFamilia.Size = new System.Drawing.Size(80, 23);
            this.btnAltaFamilia.TabIndex = 3;
            this.btnAltaFamilia.Text = "Guardar";
            this.btnAltaFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaFamilia.UseVisualStyleBackColor = true;
            this.btnAltaFamilia.Click += new System.EventHandler(this.btnAltaFamilia_Click);
            this.btnAltaFamilia.MouseLeave += new System.EventHandler(this.btnAltaFamilia_MouseLeave);
            this.btnAltaFamilia.MouseHover += new System.EventHandler(this.btnAltaFamilia_MouseHover);
            // 
            // btnCancelarFamilia
            // 
            this.btnCancelarFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFamilia.Image = global::Vistas.Properties.Resources.imgSalir;
            this.btnCancelarFamilia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarFamilia.Location = new System.Drawing.Point(368, 105);
            this.btnCancelarFamilia.Name = "btnCancelarFamilia";
            this.btnCancelarFamilia.Size = new System.Drawing.Size(60, 23);
            this.btnCancelarFamilia.TabIndex = 6;
            this.btnCancelarFamilia.Text = "Salir";
            this.btnCancelarFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarFamilia.UseVisualStyleBackColor = true;
            this.btnCancelarFamilia.Click += new System.EventHandler(this.btnCancelarFamilia_Click);
            this.btnCancelarFamilia.MouseLeave += new System.EventHandler(this.btnCancelarFamilia_MouseLeave);
            this.btnCancelarFamilia.MouseHover += new System.EventHandler(this.btnCancelarFamilia_MouseHover);
            // 
            // dgvFamilia
            // 
            this.dgvFamilia.AllowUserToAddRows = false;
            this.dgvFamilia.AllowUserToDeleteRows = false;
            this.dgvFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilia.Location = new System.Drawing.Point(52, 150);
            this.dgvFamilia.Name = "dgvFamilia";
            this.dgvFamilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamilia.Size = new System.Drawing.Size(416, 150);
            this.dgvFamilia.TabIndex = 8;
            this.dgvFamilia.CurrentCellChanged += new System.EventHandler(this.dgvFamilia_CurrentCellChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(172, 104);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(270, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(314, 45);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 74);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alta Familia";
            // 
            // AltaFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvFamilia);
            this.Controls.Add(this.btnCancelarFamilia);
            this.Controls.Add(this.btnAltaFamilia);
            this.Controls.Add(this.txtFamiliaDescripcion);
            this.Controls.Add(this.lblFamiliaDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaFamilia";
            this.Load += new System.EventHandler(this.AltaFamilia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFamiliaDescripcion;
        private System.Windows.Forms.Label lblFamiliaDescripcion;
        private System.Windows.Forms.Button btnAltaFamilia;
        private System.Windows.Forms.Button btnCancelarFamilia;
        private System.Windows.Forms.DataGridView dgvFamilia;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}