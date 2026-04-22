namespace pryAlliaTest
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pInicial = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.pInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestíon de Productos ";
            // 
            // pInicial
            // 
            this.pInicial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pInicial.Controls.Add(this.btnIniciar);
            this.pInicial.Controls.Add(this.lblTitulo);
            this.pInicial.Location = new System.Drawing.Point(92, 89);
            this.pInicial.Name = "pInicial";
            this.pInicial.Size = new System.Drawing.Size(203, 100);
            this.pInicial.TabIndex = 2;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.btnIniciar.Location = new System.Drawing.Point(14, 47);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(175, 37);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // picFondo
            // 
            this.picFondo.Enabled = false;
            this.picFondo.Image = global::pryAlliaTest.Properties.Resources.fondo;
            this.picFondo.Location = new System.Drawing.Point(0, 0);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(404, 326);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 323);
            this.Controls.Add(this.pInicial);
            this.Controls.Add(this.picFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestíon de Productos - Inicio";
            this.pInicial.ResumeLayout(false);
            this.pInicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pInicial;
        private System.Windows.Forms.Button btnIniciar;
    }
}