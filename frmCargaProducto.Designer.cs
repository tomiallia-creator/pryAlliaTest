namespace pryAlliaTest
{
    partial class frmCargaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProducto));
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pCarga = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pProducto = new System.Windows.Forms.Panel();
            this.lblAdicional = new System.Windows.Forms.Label();
            this.rbtnEquipo = new System.Windows.Forms.RadioButton();
            this.rbtnRepuesto = new System.Windows.Forms.RadioButton();
            this.btnFinal = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbInstalacion = new System.Windows.Forms.CheckBox();
            this.cbEnvio = new System.Windows.Forms.CheckBox();
            this.cbGarantía = new System.Windows.Forms.CheckBox();
            this.cmbProductosRegistrados = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.pCarga.SuspendLayout();
            this.pProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFondo
            // 
            this.picFondo.Image = global::pryAlliaTest.Properties.Resources.fondo2;
            this.picFondo.Location = new System.Drawing.Point(-12, -13);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(568, 542);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblNombre.Location = new System.Drawing.Point(3, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 27);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // pCarga
            // 
            this.pCarga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pCarga.Controls.Add(this.btnSiguiente);
            this.pCarga.Controls.Add(this.cmbProductos);
            this.pCarga.Controls.Add(this.lblLista);
            this.pCarga.Controls.Add(this.btnRegistrar);
            this.pCarga.Controls.Add(this.txtNombre);
            this.pCarga.Controls.Add(this.lblNombre);
            this.pCarga.Location = new System.Drawing.Point(47, 26);
            this.pCarga.Name = "pCarga";
            this.pCarga.Size = new System.Drawing.Size(451, 171);
            this.pCarga.TabIndex = 3;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.btnSiguiente.Location = new System.Drawing.Point(301, 123);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(131, 33);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(209, 70);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(223, 34);
            this.cmbProductos.TabIndex = 6;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblLista.Location = new System.Drawing.Point(3, 72);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(184, 27);
            this.lblLista.TabIndex = 5;
            this.lblLista.Text = "Lista de Productos ";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.btnRegistrar.Location = new System.Drawing.Point(301, 14);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 33);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtNombre.Location = new System.Drawing.Point(112, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 33);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // pProducto
            // 
            this.pProducto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pProducto.Controls.Add(this.lblProducto);
            this.pProducto.Controls.Add(this.cmbProductosRegistrados);
            this.pProducto.Controls.Add(this.cbGarantía);
            this.pProducto.Controls.Add(this.cbEnvio);
            this.pProducto.Controls.Add(this.cbInstalacion);
            this.pProducto.Controls.Add(this.lblAdicional);
            this.pProducto.Controls.Add(this.rbtnEquipo);
            this.pProducto.Controls.Add(this.rbtnRepuesto);
            this.pProducto.Controls.Add(this.btnFinal);
            this.pProducto.Controls.Add(this.lblTipo);
            this.pProducto.Location = new System.Drawing.Point(47, 26);
            this.pProducto.Name = "pProducto";
            this.pProducto.Size = new System.Drawing.Size(451, 289);
            this.pProducto.TabIndex = 9;
            this.pProducto.Visible = false;
            // 
            // lblAdicional
            // 
            this.lblAdicional.AutoSize = true;
            this.lblAdicional.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblAdicional.Location = new System.Drawing.Point(6, 132);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(100, 27);
            this.lblAdicional.TabIndex = 11;
            this.lblAdicional.Text = "Adicional";
            // 
            // rbtnEquipo
            // 
            this.rbtnEquipo.AutoSize = true;
            this.rbtnEquipo.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.rbtnEquipo.Location = new System.Drawing.Point(209, 77);
            this.rbtnEquipo.Name = "rbtnEquipo";
            this.rbtnEquipo.Size = new System.Drawing.Size(94, 31);
            this.rbtnEquipo.TabIndex = 10;
            this.rbtnEquipo.TabStop = true;
            this.rbtnEquipo.Text = "Equipo";
            this.rbtnEquipo.UseVisualStyleBackColor = true;
            // 
            // rbtnRepuesto
            // 
            this.rbtnRepuesto.AutoSize = true;
            this.rbtnRepuesto.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.rbtnRepuesto.Location = new System.Drawing.Point(80, 77);
            this.rbtnRepuesto.Name = "rbtnRepuesto";
            this.rbtnRepuesto.Size = new System.Drawing.Size(123, 31);
            this.rbtnRepuesto.TabIndex = 9;
            this.rbtnRepuesto.TabStop = true;
            this.rbtnRepuesto.Text = "Respuesto";
            this.rbtnRepuesto.UseVisualStyleBackColor = true;
            // 
            // btnFinal
            // 
            this.btnFinal.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.btnFinal.Location = new System.Drawing.Point(301, 241);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(131, 33);
            this.btnFinal.TabIndex = 8;
            this.btnFinal.Text = "Finalizar";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblTipo.Location = new System.Drawing.Point(6, 79);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(53, 27);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // cbInstalacion
            // 
            this.cbInstalacion.AutoSize = true;
            this.cbInstalacion.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.cbInstalacion.Location = new System.Drawing.Point(112, 132);
            this.cbInstalacion.Name = "cbInstalacion";
            this.cbInstalacion.Size = new System.Drawing.Size(120, 30);
            this.cbInstalacion.TabIndex = 12;
            this.cbInstalacion.Text = "Instalación";
            this.cbInstalacion.UseVisualStyleBackColor = true;
            // 
            // cbEnvio
            // 
            this.cbEnvio.AutoSize = true;
            this.cbEnvio.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.cbEnvio.Location = new System.Drawing.Point(112, 168);
            this.cbEnvio.Name = "cbEnvio";
            this.cbEnvio.Size = new System.Drawing.Size(80, 30);
            this.cbEnvio.TabIndex = 13;
            this.cbEnvio.Text = "Envío";
            this.cbEnvio.UseVisualStyleBackColor = true;
            // 
            // cbGarantía
            // 
            this.cbGarantía.AutoSize = true;
            this.cbGarantía.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.cbGarantía.Location = new System.Drawing.Point(112, 204);
            this.cbGarantía.Name = "cbGarantía";
            this.cbGarantía.Size = new System.Drawing.Size(101, 30);
            this.cbGarantía.TabIndex = 14;
            this.cbGarantía.Text = "Garantía";
            this.cbGarantía.UseVisualStyleBackColor = true;
            // 
            // cmbProductosRegistrados
            // 
            this.cmbProductosRegistrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductosRegistrados.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cmbProductosRegistrados.FormattingEnabled = true;
            this.cmbProductosRegistrados.Location = new System.Drawing.Point(112, 18);
            this.cmbProductosRegistrados.Name = "cmbProductosRegistrados";
            this.cmbProductosRegistrados.Size = new System.Drawing.Size(194, 34);
            this.cmbProductosRegistrados.TabIndex = 9;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblProducto.Location = new System.Drawing.Point(6, 25);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(94, 27);
            this.lblProducto.TabIndex = 15;
            this.lblProducto.Text = "Producto";
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 234);
            this.Controls.Add(this.pCarga);
            this.Controls.Add(this.pProducto);
            this.Controls.Add(this.picFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Productos - Carga de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.pCarga.ResumeLayout(false);
            this.pCarga.PerformLayout();
            this.pProducto.ResumeLayout(false);
            this.pProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pCarga;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel pProducto;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblAdicional;
        private System.Windows.Forms.RadioButton rbtnEquipo;
        private System.Windows.Forms.RadioButton rbtnRepuesto;
        private System.Windows.Forms.CheckBox cbInstalacion;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProductosRegistrados;
        private System.Windows.Forms.CheckBox cbGarantía;
        private System.Windows.Forms.CheckBox cbEnvio;
    }
}