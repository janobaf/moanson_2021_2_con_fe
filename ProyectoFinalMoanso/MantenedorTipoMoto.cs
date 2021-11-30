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
    public partial class MantenedorTipoMoto : Form
    {
        public MantenedorTipoMoto()
        {
            InitializeComponent();
            listarTipoMoto();
            LlenarDatosMotor();
            gbTipo.Enabled = false;
            txtCodigo.Enabled = false;
        }
        private void LimpiarVariable()
        {
            txtVeloMax.Text = " ";
            txtPesoMax.Text = " ";
            ckEstado.Checked = false;
            txtCodigo.Text = " ";
        }
        public void listarTipoMoto()
        {
            GridTipo.DataSource = logTipoMoto.Instancia.ListarTipoMoto();
        }
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            gbTipo.Enabled = true;
            btnNuevo.Visible = true;
            LimpiarVariable();
            btnCancelar.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoMoto c = new entTipoMoto();
                c.Nombre = txtNombre.Text.Trim();
                c.Velomaxima = double.Parse(txtVeloMax.Text.Trim());
                c.Pesomaximo = double.Parse(txtPesoMax.Text.Trim());
                c.estTipoMoto = ckEstado.Checked;
                c.TipomotoID = Convert.ToInt32(cboMotor.SelectedValue);

                logTipoMoto.Instancia.insertaTipoMoto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariable();
            gbTipo.Enabled = false;
            listarTipoMoto();
        }

        private void GridTipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbTipo.Enabled = false;
            DataGridViewRow filaActual = GridTipo.Rows[e.RowIndex];
            txtNombre.Text = filaActual.Cells[0].Value.ToString();
            txtVeloMax.Text = filaActual.Cells[1].Value.ToString();
            txtPesoMax.Text = filaActual.Cells[2].Value.ToString();
            cboMotor.Text = filaActual.Cells[3].Value.ToString();
            ckEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
            txtCodigo.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoMoto c = new entTipoMoto();
                c.Nombre = txtNombre.Text.Trim();
                c.Velomaxima = double.Parse(txtVeloMax.Text.Trim());
                c.Pesomaximo = double.Parse(txtPesoMax.Text.Trim());
                c.estTipoMoto = ckEstado.Checked;
                c.TipomotoID = int.Parse(txtCodigo.Text.Trim());
                c.MotormotoID = Convert.ToInt32(cboMotor.SelectedValue);
                logTipoMoto.Instancia.EditaTipoMoto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbTipo.Enabled = false;
            listarTipoMoto();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoMoto c = new entTipoMoto();
                c.TipomotoID = int.Parse(txtCodigo.Text.Trim());
                ckEstado.Checked = false;
                c.estTipoMoto = ckEstado.Checked;
                logTipoMoto.Instancia.DeshabilitarTipoMoto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbTipo.Enabled = false;
            listarTipoMoto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbTipo.Enabled = true;
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

        private void LlenarDatosMotor()
        {
            cboMotor.DataSource = logMotor.Instancia.ListarMotor();
            cboMotor.DisplayMember = "Nombre";
            cboMotor.ValueMember = "MotormotoID";
        }
    }
}
