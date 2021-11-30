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
    public partial class MantenedorMotor : Form
    {
        public MantenedorMotor()
        {
            InitializeComponent();
            listarMotor();
            gbMotor.Enabled = false;
            txtCodigo.Enabled = false;
        }
        private void LimpiarVariable()
        {
            txtNombre.Text = " ";
            txtPotencia.Text = " ";
            ckEstado.Checked = false;
            txtCodigo.Text = " ";
        }
        public void listarMotor()
        {
            GridMotor.DataSource = logMotor.Instancia.ListarMotor();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            gbMotor.Enabled = true;
            btnNuevo.Visible = true;
            LimpiarVariable();
            btnCancelar.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                entMotor c = new entMotor();
                c.Nombre = txtNombre.Text.Trim();
                c.Potencia = double.Parse(txtPotencia.Text.Trim());
                c.estMotor = ckEstado.Checked;

                logMotor.Instancia.insertaMotor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariable();
            gbMotor.Enabled = false;
            listarMotor();
        }

        private void GridMotor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbMotor.Enabled = false;
            DataGridViewRow filaActual = GridMotor.Rows[e.RowIndex];
            txtNombre.Text = filaActual.Cells[0].Value.ToString();
            txtPotencia.Text = filaActual.Cells[1].Value.ToString();
            ckEstado.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
            txtCodigo.Text = filaActual.Cells[3].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMotor c = new entMotor();
                c.Nombre = txtNombre.Text.Trim();
                c.Potencia = double.Parse(txtPotencia.Text.Trim());
                c.estMotor = ckEstado.Checked;
                c.MotormotoID = int.Parse(txtCodigo.Text.Trim());
                logMotor.Instancia.EditaMotor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbMotor.Enabled = false;
            listarMotor();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMotor c = new entMotor();
                c.MotormotoID = int.Parse(txtCodigo.Text.Trim());
                ckEstado.Checked = false;
                c.estMotor = ckEstado.Checked;
                logMotor.Instancia.DeshabilitarMotor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();
            gbMotor.Enabled = false;
            listarMotor();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbMotor.Enabled = true;
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
    }
}
