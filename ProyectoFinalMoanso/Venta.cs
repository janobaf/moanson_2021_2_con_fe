using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace ProyectoFinalMoanso
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
            listarVentas();
        }
        public void listarVentas()
        {
            GridVenta.DataSource = logVenta.Instancia.ListarVentas();
        }

        private void limpiar()
        {
            txtCodigo.Text = " ";
            txtCot.Text = " ";
            txtCliente.Text = "";
            txtTVenta.Text = " ";
            txtHora.Text = " ";
            ckEstado.Checked = false;

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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            entVenta ven = new entVenta();
            bool aux_clienteid = logVenta.Instancia.Verificar_cliente(Convert.ToInt32(txtCliente.Text));
            bool aux_cotizacionid = logVenta.Instancia.VerificarCotizacion(Convert.ToInt32(txtCot.Text));
            if (aux_clienteid == true && aux_cotizacionid == true)
            {
                ven.CotizacionID = Convert.ToInt32(txtCot.Text);
                ven.ClienteID = Convert.ToInt32(txtCliente.Text);
                ven.Tipoventa = txtTVenta.Text;
                ven.Hora = Convert.ToInt32(txtHora.Text);
                ven.Fcventa = dtRegCot.Value;
                ven.estVenta = ckEstado.Checked;
                logVenta.Instancia.InsertarVenta(ven);
            }
            else
            {
                MessageBox.Show("clienteid o cotizacion id no existe", "error de ids");
            }
            listarVentas();
            limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            entVenta ven = new entVenta();
            ven.VentaID = Convert.ToInt32(txtCodigo.Text);
            logVenta.Instancia.EliminarVenta(ven);

            listarVentas();
            limpiar();
        }

        private void GridVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridVenta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GridVenta.Enabled = true;

            DataGridViewRow filaActual = GridVenta.Rows[e.RowIndex];
            txtCodigo.Text = filaActual.Cells[4].Value.ToString();

            listarVentas();
        }
    }
}
