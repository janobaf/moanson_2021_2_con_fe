﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalMoanso
{
    public partial class MenuCores : Form
    {
        public MenuCores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cotizacion().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "¿Desea salir de la aplicación?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do something  
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new MenuInicio().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Venta().Show();
            this.Hide();
        }
    }
}
