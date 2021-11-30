using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace ProyectoFinalMoanso
{
    public partial class Cotizacion : Form
    {
        public Cotizacion()
        {
            InitializeComponent();
            listarCotizacion();
        }
        private void LimpiarVariable()
        {
            txtCant.Text = " ";
            txtTipo.Text = " ";
            txtMarca.Text = " ";
            txtValor.Text = " ";
            ckEstado.Checked = false;
            ckdisp.Checked = false;
            txtCodigo.Text = " ";
        }
        public void listarCotizacion()
        {
            GridCotizacion.DataSource = logCotizacion.Instancia.ListarCotizacion();
        }

        private void GridCotizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string message = "¿Desea voler al Menú?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new MenuCores().Show();
                this.Hide();
            }
            else
            {
                // Do something  
            }
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            int idProducto = Convert.ToInt32(txtCodigo.Text); // se obtiene el valor de una celda 
            entMoto Prod = logMoto.Instancia.BuscaridMoto(idProducto);
            if (Prod != null && (Prod.estMoto == true))
            {

                txtCant.Text = Convert.ToString(Prod.Cantdispomoto);
                txtTipo.Text = Convert.ToString(Prod.TipomotoID);
                txtMarca.Text = Convert.ToString(Prod.MarcamotoID);
                ckdisp.Checked = Convert.ToBoolean(Prod.Disponibilidad);

            }
            else
                MessageBox.Show("La moto no existe o esta inhabilitada, verifique.", "Producto: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariable();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                entCotizacion c = new entCotizacion();
                c.Fccotizacion = dtRegCot.Value;
                c.Valor = int.Parse(txtValor.Text.Trim());
                c.MotoID = int.Parse(txtCodigo.Text.Trim());
                c.estCotizacion = ckEstado.Checked;

                logCotizacion.Instancia.insertaCotizacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            listarCotizacion();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {

        }
    }
}
