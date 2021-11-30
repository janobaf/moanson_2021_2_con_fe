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
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            listarCliente();
            gbCliente.Enabled = false;
            txtCodigo.Enabled = false;

        }
        private void LimpiarVariable()
        {
            txtNombre.Text = " ";
            txtApellidos.Text = " ";
            txtCelular.Text = " ";
            txtDNI.Text = " ";
            ckEstado.Checked = false;
            ckCivil.Checked = false;
            txtCodigo.Text = " ";
        }
        public void listarCliente()
        {
            GridCliente.DataSource = logCliente.Instancia.ListarCliente();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            gbCliente.Enabled = true;
            btnNuevo.Visible = true;
            LimpiarVariable();
            btnModificar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Nombre = txtNombre.Text.Trim();
                c.DNI = int.Parse(txtDNI.Text.Trim());
                c.Apellidos = txtApellidos.Text.Trim();
                c.Celular = int.Parse(txtCelular.Text.Trim());
                c.EstadoCivil = ckCivil.Checked;
                c.Fnacimiento = dtNacimiento.Value;
                c.estCliente = ckEstado.Checked;

                logCliente.Instancia.insertacliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariable();
            gbCliente.Enabled = false;
            listarCliente();
        }
        private void MantenedorCliente_Load(object sender, EventArgs e)
        {

        }

        private void GridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbCliente.Enabled = false;
            DataGridViewRow filaActual = GridCliente.Rows[e.RowIndex];
            txtNombre.Text = filaActual.Cells[0].Value.ToString();
            txtDNI.Text = filaActual.Cells[1].Value.ToString();
            txtApellidos.Text = filaActual.Cells[2].Value.ToString();
            txtCelular.Text = filaActual.Cells[3].Value.ToString();
            ckCivil.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
            dtNacimiento.Text = filaActual.Cells[5].Value.ToString();
            ckEstado.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
            txtCodigo.Text = filaActual.Cells[7].Value.ToString(); 
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Nombre = txtNombre.Text.Trim();
                c.DNI = int.Parse(txtDNI.Text.Trim());
                c.Apellidos = txtApellidos.Text.Trim();
                c.Celular = int.Parse(txtCelular.Text.Trim());
                c.EstadoCivil = ckCivil.Checked;
                c.Fnacimiento = dtNacimiento.Value;
                c.estCliente = ckEstado.Checked;
                c.ClienteID = int.Parse(txtCodigo.Text.Trim());
                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbCliente.Enabled = false;
            listarCliente();
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.ClienteID = int.Parse(txtCodigo.Text.Trim());
                ckEstado.Checked = false;
                c.estCliente = ckEstado.Checked;
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbCliente.Enabled = false;
            listarCliente();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbCliente.Enabled = true;
            btnModificar.Visible = true;
            btnNuevo.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string message = "¿Desea salir del Mantenedor?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new MenuMantenedor().Show();
                this.Hide();
            }
            else
            {
                // Do something  
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
