
namespace ProyectoFinalMoanso
{
    partial class Cotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizacion));
            this.GridCotizacion = new System.Windows.Forms.DataGridView();
            this.gbCotizacion = new System.Windows.Forms.GroupBox();
            this.ckdisp = new System.Windows.Forms.CheckBox();
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.dtRegCot = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCotizacion)).BeginInit();
            this.gbCotizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridCotizacion
            // 
            this.GridCotizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCotizacion.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.GridCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCotizacion.Location = new System.Drawing.Point(440, 22);
            this.GridCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.GridCotizacion.Name = "GridCotizacion";
            this.GridCotizacion.RowHeadersWidth = 51;
            this.GridCotizacion.RowTemplate.Height = 24;
            this.GridCotizacion.Size = new System.Drawing.Size(399, 340);
            this.GridCotizacion.TabIndex = 1;
            this.GridCotizacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCotizacion_CellContentClick);
            // 
            // gbCotizacion
            // 
            this.gbCotizacion.BackColor = System.Drawing.Color.Transparent;
            this.gbCotizacion.Controls.Add(this.ckdisp);
            this.gbCotizacion.Controls.Add(this.ckEstado);
            this.gbCotizacion.Controls.Add(this.dtRegCot);
            this.gbCotizacion.Controls.Add(this.label6);
            this.gbCotizacion.Controls.Add(this.txtValor);
            this.gbCotizacion.Controls.Add(this.btnLimpiar);
            this.gbCotizacion.Controls.Add(this.btnCrear);
            this.gbCotizacion.Controls.Add(this.label4);
            this.gbCotizacion.Controls.Add(this.txtCodigo);
            this.gbCotizacion.Controls.Add(this.label1);
            this.gbCotizacion.Controls.Add(this.btnBuscar);
            this.gbCotizacion.Controls.Add(this.txtCant);
            this.gbCotizacion.Controls.Add(this.label2);
            this.gbCotizacion.Controls.Add(this.label5);
            this.gbCotizacion.Controls.Add(this.label3);
            this.gbCotizacion.Controls.Add(this.txtMarca);
            this.gbCotizacion.Controls.Add(this.txtTipo);
            this.gbCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCotizacion.Location = new System.Drawing.Point(15, 17);
            this.gbCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.gbCotizacion.Name = "gbCotizacion";
            this.gbCotizacion.Padding = new System.Windows.Forms.Padding(2);
            this.gbCotizacion.Size = new System.Drawing.Size(409, 396);
            this.gbCotizacion.TabIndex = 20;
            this.gbCotizacion.TabStop = false;
            this.gbCotizacion.Text = "Búsqueda Moto";
            this.gbCotizacion.Enter += new System.EventHandler(this.gbCliente_Enter);
            // 
            // ckdisp
            // 
            this.ckdisp.AutoSize = true;
            this.ckdisp.Enabled = false;
            this.ckdisp.Location = new System.Drawing.Point(26, 235);
            this.ckdisp.Margin = new System.Windows.Forms.Padding(2);
            this.ckdisp.Name = "ckdisp";
            this.ckdisp.Size = new System.Drawing.Size(114, 20);
            this.ckdisp.TabIndex = 31;
            this.ckdisp.Text = "Disponibilidad";
            this.ckdisp.UseVisualStyleBackColor = true;
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Location = new System.Drawing.Point(210, 266);
            this.ckEstado.Margin = new System.Windows.Forms.Padding(2);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(135, 20);
            this.ckEstado.TabIndex = 29;
            this.ckEstado.Text = "Estado Cotización";
            this.ckEstado.UseVisualStyleBackColor = true;
            this.ckEstado.CheckedChanged += new System.EventHandler(this.ckEstado_CheckedChanged);
            // 
            // dtRegCot
            // 
            this.dtRegCot.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtRegCot.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtRegCot.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtRegCot.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtRegCot.Location = new System.Drawing.Point(44, 296);
            this.dtRegCot.Margin = new System.Windows.Forms.Padding(2);
            this.dtRegCot.Name = "dtRegCot";
            this.dtRegCot.Size = new System.Drawing.Size(301, 22);
            this.dtRegCot.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Fecha Cotizacion";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(133, 191);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(124, 22);
            this.txtValor.TabIndex = 26;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(270, 97);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 33);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Location = new System.Drawing.Point(133, 341);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(121, 33);
            this.btnCrear.TabIndex = 18;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Marca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(133, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(124, 22);
            this.txtCodigo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo Moto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(270, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 33);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCant
            // 
            this.txtCant.Enabled = false;
            this.txtCant.Location = new System.Drawing.Point(133, 72);
            this.txtCant.Margin = new System.Windows.Forms.Padding(2);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(124, 22);
            this.txtCant.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant. Disponible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Tipo Moto";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(133, 152);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(124, 22);
            this.txtMarca.TabIndex = 8;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(133, 111);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(124, 22);
            this.txtTipo.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(664, 380);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 33);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.Location = new System.Drawing.Point(468, 380);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(121, 33);
            this.btnDeshabilitar.TabIndex = 23;
            this.btnDeshabilitar.Text = "DESHABILITAR";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 431);
            this.Controls.Add(this.gbCotizacion);
            this.Controls.Add(this.GridCotizacion);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizacion";
            ((System.ComponentModel.ISupportInitialize)(this.GridCotizacion)).EndInit();
            this.gbCotizacion.ResumeLayout(false);
            this.gbCotizacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCotizacion;
        private System.Windows.Forms.GroupBox gbCotizacion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtRegCot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckEstado;
        private System.Windows.Forms.CheckBox ckdisp;
    }
}