namespace Proyecto_Programacios_lV_Grupo6
{
    partial class Ventana_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nombre = new System.Windows.Forms.Label();
            this.Primer_Apellido = new System.Windows.Forms.Label();
            this.Segundo_Apellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrimer_Apellido = new System.Windows.Forms.TextBox();
            this.txtSegundo_Apellido = new System.Windows.Forms.TextBox();
            this.Celular = new System.Windows.Forms.Label();
            this.Correo_Electronico = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCorreo_Electronico = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(47, 89);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // Primer_Apellido
            // 
            this.Primer_Apellido.AutoSize = true;
            this.Primer_Apellido.Location = new System.Drawing.Point(47, 131);
            this.Primer_Apellido.Name = "Primer_Apellido";
            this.Primer_Apellido.Size = new System.Drawing.Size(99, 16);
            this.Primer_Apellido.TabIndex = 1;
            this.Primer_Apellido.Text = "Primer Apellido";
            // 
            // Segundo_Apellido
            // 
            this.Segundo_Apellido.AutoSize = true;
            this.Segundo_Apellido.Location = new System.Drawing.Point(47, 177);
            this.Segundo_Apellido.Name = "Segundo_Apellido";
            this.Segundo_Apellido.Size = new System.Drawing.Size(115, 16);
            this.Segundo_Apellido.TabIndex = 2;
            this.Segundo_Apellido.Text = "Segundo Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtPrimer_Apellido
            // 
            this.txtPrimer_Apellido.Location = new System.Drawing.Point(168, 131);
            this.txtPrimer_Apellido.Name = "txtPrimer_Apellido";
            this.txtPrimer_Apellido.Size = new System.Drawing.Size(150, 22);
            this.txtPrimer_Apellido.TabIndex = 4;
            // 
            // txtSegundo_Apellido
            // 
            this.txtSegundo_Apellido.Location = new System.Drawing.Point(168, 171);
            this.txtSegundo_Apellido.Name = "txtSegundo_Apellido";
            this.txtSegundo_Apellido.Size = new System.Drawing.Size(150, 22);
            this.txtSegundo_Apellido.TabIndex = 5;
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Location = new System.Drawing.Point(47, 221);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(49, 16);
            this.Celular.TabIndex = 6;
            this.Celular.Text = "Celular";
            // 
            // Correo_Electronico
            // 
            this.Correo_Electronico.AutoSize = true;
            this.Correo_Electronico.Location = new System.Drawing.Point(47, 261);
            this.Correo_Electronico.Name = "Correo_Electronico";
            this.Correo_Electronico.Size = new System.Drawing.Size(118, 16);
            this.Correo_Electronico.TabIndex = 7;
            this.Correo_Electronico.Text = "Correo Electrónico";
            this.Correo_Electronico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(168, 215);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(150, 22);
            this.txtCelular.TabIndex = 8;
            // 
            // txtCorreo_Electronico
            // 
            this.txtCorreo_Electronico.Location = new System.Drawing.Point(168, 255);
            this.txtCorreo_Electronico.Name = "txtCorreo_Electronico";
            this.txtCorreo_Electronico.Size = new System.Drawing.Size(150, 22);
            this.txtCorreo_Electronico.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(168, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 26);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 239);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(56, 52);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 16);
            this.Id.TabIndex = 12;
            this.Id.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(168, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 22);
            this.txtId.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(168, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 26);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(168, 392);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 26);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Ventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCorreo_Electronico);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.Correo_Electronico);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.txtSegundo_Apellido);
            this.Controls.Add(this.txtPrimer_Apellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Segundo_Apellido);
            this.Controls.Add(this.Primer_Apellido);
            this.Controls.Add(this.Nombre);
            this.Name = "Ventana_Principal";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Ventana_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Primer_Apellido;
        private System.Windows.Forms.Label Segundo_Apellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrimer_Apellido;
        private System.Windows.Forms.TextBox txtSegundo_Apellido;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.Label Correo_Electronico;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCorreo_Electronico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
    }
}

