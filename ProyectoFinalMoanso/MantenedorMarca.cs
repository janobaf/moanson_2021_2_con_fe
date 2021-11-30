using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace ProyectoFinalMoanso
{
    public partial class MantenedorMarca : Form
    {
        public MantenedorMarca()
        {
            InitializeComponent();
            listarMarca();
            gbMarca.Enabled = false;
            txtCodigo.Enabled = false;
        }
        private void LimpiarVariable()
        {
            txtNombre.Text = " ";
            txtCategoria.Text = " ";
            ckEstado.Checked = false;
            txtCodigo.Text = " ";
        }
        public void listarMarca()
        {
            GridMarca.DataSource = logMarca.Instancia.ListarMarca();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            gbMarca.Enabled = true;
            btnNuevo.Visible = true;
            LimpiarVariable();
            btnCancelar.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca c = new entMarca();
                c.Nombre = txtNombre.Text.Trim();
                c.Categoria = txtCategoria.Text.Trim();
                c.estMarca = ckEstado.Checked;

                logMarca.Instancia.insertaMarca(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariable();
            gbMarca.Enabled = false;
            listarMarca();
        }

        private void GridMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbMarca.Enabled = false;
            DataGridViewRow filaActual = GridMarca.Rows[e.RowIndex];
            txtNombre.Text = filaActual.Cells[0].Value.ToString();
            txtCategoria.Text = filaActual.Cells[1].Value.ToString();
            ckEstado.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
            txtCodigo.Text = filaActual.Cells[3].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca c = new entMarca();
                c.Nombre = txtNombre.Text.Trim();
                c.Categoria = txtCategoria.Text.Trim();
                c.estMarca = ckEstado.Checked;
                c.MarcamotoID = int.Parse(txtCodigo.Text.Trim());
                logMarca.Instancia.EditaMarca(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbMarca.Enabled = false;
            listarMarca();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca c = new entMarca();
                c.MarcamotoID = int.Parse(txtCodigo.Text.Trim());
                ckEstado.Checked = false;
                c.estMarca = ckEstado.Checked;
                logMarca.Instancia.DeshabilitarMarca(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbMarca.Enabled = false;
            listarMarca();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbMarca.Enabled = true;
            btnModificar.Visible = true;
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

        private void MantenedorMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
