namespace WindowsEF
{
    partial class frmCategoria
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.grdCategoria = new System.Windows.Forms.DataGridView();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.lblMsjInsertar = new System.Windows.Forms.Label();
            this.lblMsjModificar = new System.Windows.Forms.Label();
            this.lblMsjEliminar = new System.Windows.Forms.Label();
            this.lblBuscarPorId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(36, 28);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(131, 25);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(169, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(131, 71);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(36, 75);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(338, 15);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 28);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // grdCategoria
            // 
            this.grdCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategoria.Location = new System.Drawing.Point(39, 132);
            this.grdCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.grdCategoria.Name = "grdCategoria";
            this.grdCategoria.Size = new System.Drawing.Size(261, 256);
            this.grdCategoria.TabIndex = 2;
            this.grdCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategoria_CellDoubleClick);
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(338, 132);
            this.btnBuscarPorId.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(165, 28);
            this.btnBuscarPorId.TabIndex = 6;
            this.btnBuscarPorId.Text = "Buscar por ID";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(338, 94);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(338, 56);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 28);
            this.btModificar.TabIndex = 8;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // lblMsjInsertar
            // 
            this.lblMsjInsertar.AutoSize = true;
            this.lblMsjInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjInsertar.Location = new System.Drawing.Point(456, 21);
            this.lblMsjInsertar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsjInsertar.Name = "lblMsjInsertar";
            this.lblMsjInsertar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjInsertar.TabIndex = 9;
            // 
            // lblMsjModificar
            // 
            this.lblMsjModificar.AutoSize = true;
            this.lblMsjModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjModificar.Location = new System.Drawing.Point(456, 59);
            this.lblMsjModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsjModificar.Name = "lblMsjModificar";
            this.lblMsjModificar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjModificar.TabIndex = 10;
            // 
            // lblMsjEliminar
            // 
            this.lblMsjEliminar.AutoSize = true;
            this.lblMsjEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjEliminar.Location = new System.Drawing.Point(456, 100);
            this.lblMsjEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsjEliminar.Name = "lblMsjEliminar";
            this.lblMsjEliminar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjEliminar.TabIndex = 11;
            // 
            // lblBuscarPorId
            // 
            this.lblBuscarPorId.AutoSize = true;
            this.lblBuscarPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorId.Location = new System.Drawing.Point(335, 181);
            this.lblBuscarPorId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarPorId.Name = "lblBuscarPorId";
            this.lblBuscarPorId.Size = new System.Drawing.Size(0, 16);
            this.lblBuscarPorId.TabIndex = 12;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 423);
            this.Controls.Add(this.lblBuscarPorId);
            this.Controls.Add(this.lblMsjEliminar);
            this.Controls.Add(this.lblMsjModificar);
            this.Controls.Add(this.lblMsjInsertar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarPorId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.grdCategoria);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnInsertar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView grdCategoria;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label lblMsjInsertar;
        private System.Windows.Forms.Label lblMsjModificar;
        private System.Windows.Forms.Label lblMsjEliminar;
        private System.Windows.Forms.Label lblBuscarPorId;
    }
}

