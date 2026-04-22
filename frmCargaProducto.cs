using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAlliaTest
{
    public partial class frmCargaProducto : Form
    {
        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cmbProductos.Items.Add((string)txtNombre.Text);
            cmbProductosRegistrados.Items.Add((string)txtNombre.Text);
            MessageBox.Show("Nombre de producto registrado con éxito");

            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pProducto.Visible = true;
            pCarga.Visible = false;

            this.Size = new Size(566, 389);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtNombre.Text != "")
            {
                cmbProductos.Items.Add(txtNombre.Text);
                cmbProductosRegistrados.Items.Add((string)txtNombre.Text);
                MessageBox.Show("Nombre de producto registrado con éxito", "Gestión de Productos");

                txtNombre.Text = "";
                txtNombre.Focus();
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
         //messagebox con todo el resumen 
        }
    }
}
