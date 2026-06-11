using PryCafeteria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3C.Cafeteria
{
    public partial class FrmCafeteria : Form
    {
        private List<Bebida> bebidas;

        public FrmCafeteria()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
        }

        private void rdbCaliente_CheckedChanged(object sender, EventArgs e)
        {
            actualizarCampos();
        }
        private void rdbFria_CheckedChanged(object sender, EventArgs e)
        {
            actualizarCampos();
        }
        private void rdbAlcohol_CheckedChanged(object sender, EventArgs e)
        {
            actualizarCampos();
        }
        private void rdbEnergetica_CheckedChanged(object sender, EventArgs e)
        {
            actualizarCampos();
        }
        private void rdbArtesanal_CheckedChanged(object sender, EventArgs e)
        {
            actualizarCampos();
        }
        private void FrmCafeteria_Load(object sender, EventArgs e)
        {
            lblExtra2.Visible = false;
            txtExtra2.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreBebida = txtNombreBebida.Text;
            float precio = float.Parse(txtPrecio.Text.Trim()); 
            string tamanio = cmbTamanio.SelectedItem.ToString();
            float extra;

            if (lblExtra2.Visible)
            {
                extra = float.Parse(txtExtra.Text.Trim());

            }
            else {
                string ingrediente = txtExtra.Text.Trim();

            }

            //elige el tipo de bebida
            if (rdbFria.Checked)
            {

                bebidas.Add(new BebidaCaliente(nombreBebida, tamanio, precio, extra));
            }
            else if (rdbCaliente.Checked)
            {
                int cantHielos = (int)extra;
                bebidas.Add(new BebidaFria(nombreBebida, tamanio, precio, cantHielos));
            }
            else
            {
                float extra2 = float.Parse(txtExtra2.Text.Trim());
                if (rdbAlcohol.Checked)
                {
                    //bebida es alcoholica
                    int tiempoAniejo = (int)extra2;
                    bebidas.Add(new BebidaAlcoholica(nombreBebida, tamanio, precio, extra, tiempoAniejo));
                }
                else if (rdbEnergetica.Checked)
                {
                    //bebida es energetica
                    bebidas.Add(new BebidaEnergetica(nombreBebida, tamanio, precio, extra, extra2));
                }
                else
                {
                    //bebida artesanal
                    string origen = Convert.ToString(extra2);
                    bebidas.Add(new BebidaArtesanal(nombreBebida, tamanio, precio, ingrediente, origen));
                }
            }

            if (bebidas[bebidas.Count - 1] is BebidaFria fria)
            {
                lsbLista.Items.Add(fria.listar());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaCaliente caliente)
            {
                lsbLista.Items.Add(caliente.listar());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaAlcoholica alcoholica)
            {
                lsbLista.Items.Add(alcoholica.listar());

            }
            else if (bebidas[bebidas.Count - 1] is BebidaEnergetica energetica)
            {
                lsbLista.Items.Add(energetica.listar());
            }
            else {
                BebidaArtesanal artesanal = (BebidaArtesanal)bebidas[bebidas.Count - 1];
                lsbLista.Items.Add(artesanal.listar());
            }


            MessageBox.Show($"Bebida agregada correctamente, tienes: {bebidas.Count} bebidas registradas");
            LimpiarCajas();

            lblCantidad.Text = bebidas.Count.ToString();
        }

        //metodo para limpiar las cajas
        private void LimpiarCajas() {
            txtNombreBebida.Clear();
            txtPrecio.Clear();
            txtExtra.Clear();
            cmbTamanio.SelectedIndex = 0;
            txtExtra2.Clear();
        }

        private void actualizarCampos() {
            lblExtra2.Visible = false;
            txtExtra2.Visible = false;
            if (rdbFria.Checked)
            {
                lblExtra.Text = "Cantidad de hielos:";
            }
            else if (rdbCaliente.Checked)
            {
                lblExtra.Text = "Temperatura:";
            }
            else {
                lblExtra2.Visible = true;
                txtExtra2.Visible = true;
                if (rdbAlcohol.Checked)
                {
                    lblExtra.Text = "Grados de alcohol:";
                    lblExtra2.Text = "Tiempo de añejamiento:";
                }
                else if (rdbEnergetica.Checked)
                {
                    lblExtra.Text = "Cantidad de azucar:";
                    lblExtra2.Text = "Cantidad de Taurina:";
                }
                else
                {
                    lblExtra.Text = "Ingrediente:";
                    lblExtra2.Text = "Origen:";
                }
            }

        }

    }
}
