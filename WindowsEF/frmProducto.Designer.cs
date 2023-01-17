namespace WindowsEF
{
    partial class frmProducto
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
            this.lblBuscarPorId = new System.Windows.Forms.Label();
            this.lblMsjEliminar = new System.Windows.Forms.Label();
            this.lblMsjModificar = new System.Windows.Forms.Label();
            this.lblMsjInsertar = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grdProducto = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtLineaProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPorId
            // 
            this.lblBuscarPorId.AutoSize = true;
            this.lblBuscarPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorId.Location = new System.Drawing.Point(688, 306);
            this.lblBuscarPorId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarPorId.Name = "lblBuscarPorId";
            this.lblBuscarPorId.Size = new System.Drawing.Size(0, 16);
            this.lblBuscarPorId.TabIndex = 25;
            // 
            // lblMsjEliminar
            // 
            this.lblMsjEliminar.AutoSize = true;
            this.lblMsjEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjEliminar.Location = new System.Drawing.Point(809, 225);
            this.lblMsjEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsjEliminar.Name = "lblMsjEliminar";
            this.lblMsjEliminar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjEliminar.TabIndex = 24;
            // 
            // lblMsjModificar
            // 
            this.lblMsjModificar.AutoSize = true;
            this.lblMsjModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjModificar.Location = new System.Drawing.Point(809, 184);
            this.lblMsjModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsjModificar.Name = "lblMsjModificar";
            this.lblMsjModificar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjModificar.TabIndex = 23;
            // 
            // lblMsjInsertar
            // 
            this.lblMsjInsertar.AutoSize = true;
            this.lblMsjInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjInsertar.Location = new System.Drawing.Point(809, 146);
            this.lblMsjInsertar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsjInsertar.Name = "lblMsjInsertar";
            this.lblMsjInsertar.Size = new System.Drawing.Size(0, 16);
            this.lblMsjInsertar.TabIndex = 22;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(691, 181);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 28);
            this.btModificar.TabIndex = 21;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(691, 219);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(691, 257);
            this.btnBuscarPorId.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(165, 28);
            this.btnBuscarPorId.TabIndex = 19;
            this.btnBuscarPorId.Text = "Buscar por ID";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(121, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 22);
            this.txtNombre.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(26, 83);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(121, 33);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(169, 22);
            this.txtId.TabIndex = 16;
            // 
            // grdProducto
            // 
            this.grdProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducto.Location = new System.Drawing.Point(29, 140);
            this.grdProducto.Margin = new System.Windows.Forms.Padding(4);
            this.grdProducto.Name = "grdProducto";
            this.grdProducto.Size = new System.Drawing.Size(631, 256);
            this.grdProducto.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(26, 36);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(691, 140);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 28);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtLineaProducto
            // 
            this.txtLineaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineaProducto.Location = new System.Drawing.Point(442, 76);
            this.txtLineaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtLineaProducto.Name = "txtLineaProducto";
            this.txtLineaProducto.Size = new System.Drawing.Size(169, 22);
            this.txtLineaProducto.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Linea Producto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(442, 30);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(169, 22);
            this.txtPrecio.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Precio:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(774, 31);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(169, 21);
            this.cboCategoria.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Categoria:";
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtLineaProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.grdProducto);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnInsertar);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarPorId;
        private System.Windows.Forms.Label lblMsjEliminar;
        private System.Windows.Forms.Label lblMsjModificar;
        private System.Windows.Forms.Label lblMsjInsertar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView grdProducto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtLineaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label3;
    }
}