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
    public partial class MantenedorMoto : Form
    {
        public MantenedorMoto()
        {
            InitializeComponent();
            listarMoto();
            LlenarDatosMarca();
            LlenarDatosTipo();
            gbMoto.Enabled = false;
            txtCodigo.Enabled = false;
        }
        private void LimpiarVariable()
        {
            txtCantDispo.Text = " ";
            ckDispo.Checked = false;
            ckEstado.Checked = false;
            cboMarca.ResetText();
            cboTipo.ResetText();
            txtCodigo.Text = " ";
        }
        public void listarMoto()
        {
            GridMoto.DataSource = logMoto.Instancia.ListarMoto();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            gbMoto.Enabled = true;
            btnNuevo.Visible = true;
            LimpiarVariable();
            btnCancelar.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                entMoto c = new entMoto();
                c.Disponibilidad = ckDispo.Checked;
                c.Cantdispomoto = int.Parse(txtCantDispo.Text.Trim());
                c.estMoto = ckEstado.Checked;
                c.MarcamotoID = Convert.ToInt32(cboMarca.SelectedValue);
                c.TipomotoID = Convert.ToInt32(cboTipo.SelectedValue);

                logMoto.Instancia.insertaMoto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariable();
            gbMoto.Enabled = false;
            listarMoto();
        }

        private void GridMoto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbMoto.Enabled = false;
            DataGridViewRow filaActual = GridMoto.Rows[e.RowIndex];
            ckDispo.Checked = Convert.ToBoolean(filaActual.Cells[0].Value);
            txtCantDispo.Text = filaActual.Cells[1].Value.ToString();
            ckEstado.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
            txtCodigo.Text = filaActual.Cells[3].Value.ToString();
            cboMarca.Text = filaActual.Cells[4].Value.ToString();
            cboTipo.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMoto c = new entMoto();
                c.Disponibilidad = ckDispo.Checked;
                c.Cantdispomoto = int.Parse(txtCantDispo.Text.Trim());
                c.estMoto = ckEstado.Checked;
                c.MotoID = int.Parse(txtCodigo.Text.Trim());
                c.MarcamotoID = Convert.ToInt32(cboMarca.SelectedValue);
                c.TipomotoID = Convert.ToInt32(cboTipo.SelectedValue);
                logMoto.Instancia.EditaMoto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbMoto.Enabled = false;
            listarMoto();
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMoto c = new entMoto();
                c.MotoID = int.Parse(txtCodigo.Text.Trim());
                ckEstado.Checked = false;
                c.estMoto = ckEstado.Checked;
                logMoto.Instancia.DeshabilitarMoto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbMoto.Enabled = false;
            listarMoto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbMoto.Enabled = true;
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

        private void LlenarDatosMarca()
        {
            cboMarca.DataSource = logMarca.Instancia.ListarMarca();
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember = "MarcamotoID";
        }
        private void LlenarDatosTipo()
        {
            cboTipo.DataSource = logTipoMoto.Instancia.ListarTipoMoto();
            cboTipo.DisplayMember = "Nombre";
            cboTipo.ValueMember = "TipomotoID";
        }
    }
}
