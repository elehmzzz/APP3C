using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3C.clases
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                //trim quita espacios al inicio y al final
                float valor1 = float.Parse(txtValor1.Text.Trim());
                float valor2 = float.Parse(txtValor2.Text.Trim());

                float resultado = valor1 + valor2;
                lblResultado.Text = $"el resultado es: {resultado}";
            }
            catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void txtValor1_Leave(object sender, EventArgs e)
        {
            string valor1 = txtValor1.Text.Trim();
            if (valor1.Length == 0) {
                MessageBox.Show($"Esta caja no puede quedar vacia");
                txtValor1.Focus();
            }
        }

    }
}
