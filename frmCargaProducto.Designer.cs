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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pCarga = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pProducto = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.rbtnRepuesto = new System.Windows.Forms.RadioButton();
            this.rbtnEquipo = new System.Windows.Forms.RadioButton();
            this.lblAdicional = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pCarga.SuspendLayout();
            this.pProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryAlliaTest.Properties.Resources.fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.pCarga.Controls.Add(this.button1);
            this.pCarga.Controls.Add(this.textBox1);
            this.pCarga.Controls.Add(this.lblNombre);
            this.pCarga.Location = new System.Drawing.Point(125, 27);
            this.pCarga.Name = "pCarga";
            this.pCarga.Size = new System.Drawing.Size(472, 171);
            this.pCarga.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(112, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 33);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.button1.Location = new System.Drawing.Point(301, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
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
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Items.AddRange(new object[] {
            "Electrónica",
            "",
            "Herramientas",
            "Electrodomésticos"});
            this.cmbProductos.Location = new System.Drawing.Point(209, 70);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(223, 34);
            this.cmbProductos.TabIndex = 6;
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
            // 
            // pProducto
            // 
            this.pProducto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pProducto.Controls.Add(this.checkedListBox1);
            this.pProducto.Controls.Add(this.lblAdicional);
            this.pProducto.Controls.Add(this.rbtnEquipo);
            this.pProducto.Controls.Add(this.rbtnRepuesto);
            this.pProducto.Controls.Add(this.button2);
            this.pProducto.Controls.Add(this.comboBox1);
            this.pProducto.Controls.Add(this.lblTipo);
            this.pProducto.Controls.Add(this.lblProducto);
            this.pProducto.Location = new System.Drawing.Point(125, 222);
            this.pProducto.Name = "pProducto";
            this.pProducto.Size = new System.Drawing.Size(472, 209);
            this.pProducto.TabIndex = 9;
            this.pProducto.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.button2.Location = new System.Drawing.Point(301, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Electrónica",
            "",
            "Herramientas",
            "Electrodomésticos"});
            this.comboBox1.Location = new System.Drawing.Point(109, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 34);
            this.comboBox1.TabIndex = 6;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblTipo.Location = new System.Drawing.Point(3, 70);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(53, 27);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblProducto.Location = new System.Drawing.Point(3, 18);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(94, 27);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // rbtnRepuesto
            // 
            this.rbtnRepuesto.AutoSize = true;
            this.rbtnRepuesto.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.rbtnRepuesto.Location = new System.Drawing.Point(80, 68);
            this.rbtnRepuesto.Name = "rbtnRepuesto";
            this.rbtnRepuesto.Size = new System.Drawing.Size(123, 31);
            this.rbtnRepuesto.TabIndex = 9;
            this.rbtnRepuesto.TabStop = true;
            this.rbtnRepuesto.Text = "Respuesto";
            this.rbtnRepuesto.UseVisualStyleBackColor = true;
            // 
            // rbtnEquipo
            // 
            this.rbtnEquipo.AutoSize = true;
            this.rbtnEquipo.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.rbtnEquipo.Location = new System.Drawing.Point(209, 68);
            this.rbtnEquipo.Name = "rbtnEquipo";
            this.rbtnEquipo.Size = new System.Drawing.Size(94, 31);
            this.rbtnEquipo.TabIndex = 10;
            this.rbtnEquipo.TabStop = true;
            this.rbtnEquipo.Text = "Equipo";
            this.rbtnEquipo.UseVisualStyleBackColor = true;
            // 
            // lblAdicional
            // 
            this.lblAdicional.AutoSize = true;
            this.lblAdicional.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lblAdicional.Location = new System.Drawing.Point(3, 127);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(100, 27);
            this.lblAdicional.TabIndex = 11;
            this.lblAdicional.Text = "Adicional";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Instalacíon",
            "Envío",
            "Garantía"});
            this.checkedListBox1.Location = new System.Drawing.Point(109, 127);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(161, 70);
            this.checkedListBox1.TabIndex = 12;
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 473);
            this.Controls.Add(this.pProducto);
            this.Controls.Add(this.pCarga);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCargaProducto";
            this.Text = "frmCargaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pCarga.ResumeLayout(false);
            this.pCarga.PerformLayout();
            this.pProducto.ResumeLayout(false);
            this.pProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pCarga;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel pProducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblAdicional;
        private System.Windows.Forms.RadioButton rbtnEquipo;
        private System.Windows.Forms.RadioButton rbtnRepuesto;
    }
}