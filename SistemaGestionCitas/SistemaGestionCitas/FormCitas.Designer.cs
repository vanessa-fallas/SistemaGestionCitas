namespace SistemaGestionCitas
{
    partial class FormCitas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInicioGestionCitas = new System.Windows.Forms.Panel();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblGestionCitas = new System.Windows.Forms.Label();
            this.pnlRegistrarCita = new System.Windows.Forms.Panel();
            this.btnRegistrarCIta = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTituloRegistro = new System.Windows.Forms.Label();
            this.pnlConsultarCitas = new System.Windows.Forms.Panel();
            this.dgvConsultaCitas = new System.Windows.Forms.DataGridView();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultaBuscar = new System.Windows.Forms.Button();
            this.dtpConsultaFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbConsultaServicio = new System.Windows.Forms.ComboBox();
            this.cmbConsultaCliente = new System.Windows.Forms.ComboBox();
            this.lblConsultaFecha = new System.Windows.Forms.Label();
            this.lblConsultaServicio = new System.Windows.Forms.Label();
            this.lblConsultaCliente = new System.Windows.Forms.Label();
            this.lblTituloConsulta = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlInicioGestionCitas.SuspendLayout();
            this.pnlRegistrarCita.SuspendLayout();
            this.pnlConsultarCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCitaToolStripMenuItem,
            this.consultarCitasToolStripMenuItem,
            this.modificarCitaToolStripMenuItem,
            this.cancelarCitaToolStripMenuItem,
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarCitaToolStripMenuItem
            // 
            this.registrarCitaToolStripMenuItem.Name = "registrarCitaToolStripMenuItem";
            this.registrarCitaToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.registrarCitaToolStripMenuItem.Text = "Registrar Cita";
            this.registrarCitaToolStripMenuItem.Click += new System.EventHandler(this.registrarCitaToolStripMenuItem_Click);
            // 
            // consultarCitasToolStripMenuItem
            // 
            this.consultarCitasToolStripMenuItem.Name = "consultarCitasToolStripMenuItem";
            this.consultarCitasToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.consultarCitasToolStripMenuItem.Text = "Consultar Citas";
            this.consultarCitasToolStripMenuItem.Click += new System.EventHandler(this.consultarCitasToolStripMenuItem_Click);
            // 
            // modificarCitaToolStripMenuItem
            // 
            this.modificarCitaToolStripMenuItem.Name = "modificarCitaToolStripMenuItem";
            this.modificarCitaToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.modificarCitaToolStripMenuItem.Text = "Modificar Cita";
            // 
            // cancelarCitaToolStripMenuItem
            // 
            this.cancelarCitaToolStripMenuItem.Name = "cancelarCitaToolStripMenuItem";
            this.cancelarCitaToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.cancelarCitaToolStripMenuItem.Text = "Cancelar Cita";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // pnlInicioGestionCitas
            // 
            this.pnlInicioGestionCitas.Controls.Add(this.lblSeleccion);
            this.pnlInicioGestionCitas.Controls.Add(this.lblGestionCitas);
            this.pnlInicioGestionCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInicioGestionCitas.Location = new System.Drawing.Point(0, 28);
            this.pnlInicioGestionCitas.Name = "pnlInicioGestionCitas";
            this.pnlInicioGestionCitas.Size = new System.Drawing.Size(1067, 526);
            this.pnlInicioGestionCitas.TabIndex = 1;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(400, 42);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(205, 16);
            this.lblSeleccion.TabIndex = 2;
            this.lblSeleccion.Text = "Seleccione una opción del  menú";
            // 
            // lblGestionCitas
            // 
            this.lblGestionCitas.AutoSize = true;
            this.lblGestionCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionCitas.Location = new System.Drawing.Point(316, 10);
            this.lblGestionCitas.Name = "lblGestionCitas";
            this.lblGestionCitas.Size = new System.Drawing.Size(400, 32);
            this.lblGestionCitas.TabIndex = 0;
            this.lblGestionCitas.Text = "Sistema de Gestión de Citas";
            // 
            // pnlRegistrarCita
            // 
            this.pnlRegistrarCita.Controls.Add(this.btnRegistrarCIta);
            this.pnlRegistrarCita.Controls.Add(this.dtpHora);
            this.pnlRegistrarCita.Controls.Add(this.dtpFecha);
            this.pnlRegistrarCita.Controls.Add(this.cmbServicio);
            this.pnlRegistrarCita.Controls.Add(this.cmbCliente);
            this.pnlRegistrarCita.Controls.Add(this.lblHora);
            this.pnlRegistrarCita.Controls.Add(this.lblFecha);
            this.pnlRegistrarCita.Controls.Add(this.lblServicio);
            this.pnlRegistrarCita.Controls.Add(this.lblCliente);
            this.pnlRegistrarCita.Controls.Add(this.lblTituloRegistro);
            this.pnlRegistrarCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarCita.Location = new System.Drawing.Point(0, 28);
            this.pnlRegistrarCita.Name = "pnlRegistrarCita";
            this.pnlRegistrarCita.Size = new System.Drawing.Size(1067, 526);
            this.pnlRegistrarCita.TabIndex = 2;
            this.pnlRegistrarCita.Visible = false;
            // 
            // btnRegistrarCIta
            // 
            this.btnRegistrarCIta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrarCIta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCIta.Location = new System.Drawing.Point(88, 377);
            this.btnRegistrarCIta.Name = "btnRegistrarCIta";
            this.btnRegistrarCIta.Size = new System.Drawing.Size(119, 36);
            this.btnRegistrarCIta.TabIndex = 9;
            this.btnRegistrarCIta.Text = "Registrar ";
            this.btnRegistrarCIta.UseVisualStyleBackColor = false;
            this.btnRegistrarCIta.Click += new System.EventHandler(this.btnRegistrarCIta_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(309, 316);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(108, 22);
            this.dtpHora.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(88, 316);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(140, 22);
            this.dtpFecha.TabIndex = 7;
            // 
            // cmbServicio
            // 
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(88, 214);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(474, 24);
            this.cmbServicio.TabIndex = 6;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(88, 129);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(474, 24);
            this.cmbCliente.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(305, 270);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(53, 22);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(84, 270);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 22);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(84, 176);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(82, 22);
            this.lblServicio.TabIndex = 2;
            this.lblServicio.Text = "Servicio";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(84, 93);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 22);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTituloRegistro
            // 
            this.lblTituloRegistro.AutoSize = true;
            this.lblTituloRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegistro.Location = new System.Drawing.Point(397, 10);
            this.lblTituloRegistro.Name = "lblTituloRegistro";
            this.lblTituloRegistro.Size = new System.Drawing.Size(233, 32);
            this.lblTituloRegistro.TabIndex = 0;
            this.lblTituloRegistro.Text = "Registro de Cita";
            // 
            // pnlConsultarCitas
            // 
            this.pnlConsultarCitas.Controls.Add(this.dgvConsultaCitas);
            this.pnlConsultarCitas.Controls.Add(this.btnConsultaBuscar);
            this.pnlConsultarCitas.Controls.Add(this.dtpConsultaFecha);
            this.pnlConsultarCitas.Controls.Add(this.cmbConsultaServicio);
            this.pnlConsultarCitas.Controls.Add(this.cmbConsultaCliente);
            this.pnlConsultarCitas.Controls.Add(this.lblConsultaFecha);
            this.pnlConsultarCitas.Controls.Add(this.lblConsultaServicio);
            this.pnlConsultarCitas.Controls.Add(this.lblConsultaCliente);
            this.pnlConsultarCitas.Controls.Add(this.lblTituloConsulta);
            this.pnlConsultarCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsultarCitas.Location = new System.Drawing.Point(0, 28);
            this.pnlConsultarCitas.Name = "pnlConsultarCitas";
            this.pnlConsultarCitas.Size = new System.Drawing.Size(1067, 526);
            this.pnlConsultarCitas.TabIndex = 3;
            this.pnlConsultarCitas.Visible = false;
            // 
            // dgvConsultaCitas
            // 
            this.dgvConsultaCitas.AllowUserToAddRows = false;
            this.dgvConsultaCitas.AllowUserToDeleteRows = false;
            this.dgvConsultaCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCliente,
            this.colServicio,
            this.colFecha,
            this.colHora});
            this.dgvConsultaCitas.Location = new System.Drawing.Point(88, 214);
            this.dgvConsultaCitas.MultiSelect = false;
            this.dgvConsultaCitas.Name = "dgvConsultaCitas";
            this.dgvConsultaCitas.ReadOnly = true;
            this.dgvConsultaCitas.RowHeadersWidth = 51;
            this.dgvConsultaCitas.RowTemplate.Height = 24;
            this.dgvConsultaCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaCitas.Size = new System.Drawing.Size(864, 300);
            this.dgvConsultaCitas.TabIndex = 10;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colServicio
            // 
            this.colServicio.HeaderText = "Servicio";
            this.colServicio.MinimumWidth = 6;
            this.colServicio.Name = "colServicio";
            this.colServicio.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colHora
            // 
            this.colHora.HeaderText = "Hora";
            this.colHora.MinimumWidth = 6;
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            // 
            // btnConsultaBuscar
            // 
            this.btnConsultaBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaBuscar.Location = new System.Drawing.Point(88, 162);
            this.btnConsultaBuscar.Name = "btnConsultaBuscar";
            this.btnConsultaBuscar.Size = new System.Drawing.Size(119, 36);
            this.btnConsultaBuscar.TabIndex = 9;
            this.btnConsultaBuscar.Text = "Buscar ";
            this.btnConsultaBuscar.UseVisualStyleBackColor = false;
            this.btnConsultaBuscar.Click += new System.EventHandler(this.btnConsultaBuscar_Click);
            // 
            // dtpConsultaFecha
            // 
            this.dtpConsultaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConsultaFecha.Location = new System.Drawing.Point(812, 120);
            this.dtpConsultaFecha.Name = "dtpConsultaFecha";
            this.dtpConsultaFecha.ShowCheckBox = true;
            this.dtpConsultaFecha.Size = new System.Drawing.Size(140, 22);
            this.dtpConsultaFecha.TabIndex = 7;
            // 
            // cmbConsultaServicio
            // 
            this.cmbConsultaServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultaServicio.FormattingEnabled = true;
            this.cmbConsultaServicio.Location = new System.Drawing.Point(452, 118);
            this.cmbConsultaServicio.Name = "cmbConsultaServicio";
            this.cmbConsultaServicio.Size = new System.Drawing.Size(290, 24);
            this.cmbConsultaServicio.TabIndex = 6;
            // 
            // cmbConsultaCliente
            // 
            this.cmbConsultaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultaCliente.FormattingEnabled = true;
            this.cmbConsultaCliente.Location = new System.Drawing.Point(88, 118);
            this.cmbConsultaCliente.Name = "cmbConsultaCliente";
            this.cmbConsultaCliente.Size = new System.Drawing.Size(290, 24);
            this.cmbConsultaCliente.TabIndex = 5;
            // 
            // lblConsultaFecha
            // 
            this.lblConsultaFecha.AutoSize = true;
            this.lblConsultaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaFecha.Location = new System.Drawing.Point(808, 82);
            this.lblConsultaFecha.Name = "lblConsultaFecha";
            this.lblConsultaFecha.Size = new System.Drawing.Size(65, 22);
            this.lblConsultaFecha.TabIndex = 3;
            this.lblConsultaFecha.Text = "Fecha";
            // 
            // lblConsultaServicio
            // 
            this.lblConsultaServicio.AutoSize = true;
            this.lblConsultaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaServicio.Location = new System.Drawing.Point(448, 82);
            this.lblConsultaServicio.Name = "lblConsultaServicio";
            this.lblConsultaServicio.Size = new System.Drawing.Size(82, 22);
            this.lblConsultaServicio.TabIndex = 2;
            this.lblConsultaServicio.Text = "Servicio";
            // 
            // lblConsultaCliente
            // 
            this.lblConsultaCliente.AutoSize = true;
            this.lblConsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaCliente.Location = new System.Drawing.Point(84, 82);
            this.lblConsultaCliente.Name = "lblConsultaCliente";
            this.lblConsultaCliente.Size = new System.Drawing.Size(73, 22);
            this.lblConsultaCliente.TabIndex = 1;
            this.lblConsultaCliente.Text = "Cliente";
            // 
            // lblTituloConsulta
            // 
            this.lblTituloConsulta.AutoSize = true;
            this.lblTituloConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsulta.Location = new System.Drawing.Point(407, 10);
            this.lblTituloConsulta.Name = "lblTituloConsulta";
            this.lblTituloConsulta.Size = new System.Drawing.Size(223, 32);
            this.lblTituloConsulta.TabIndex = 0;
            this.lblTituloConsulta.Text = "Consultar Citas";
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlConsultarCitas);
            this.Controls.Add(this.pnlRegistrarCita);
            this.Controls.Add(this.pnlInicioGestionCitas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCitas";
            this.Text = "Citas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlInicioGestionCitas.ResumeLayout(false);
            this.pnlInicioGestionCitas.PerformLayout();
            this.pnlRegistrarCita.ResumeLayout(false);
            this.pnlRegistrarCita.PerformLayout();
            this.pnlConsultarCitas.ResumeLayout(false);
            this.pnlConsultarCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.Panel pnlInicioGestionCitas;
        private System.Windows.Forms.Label lblGestionCitas;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Panel pnlRegistrarCita;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTituloRegistro;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button btnRegistrarCIta;
        private System.Windows.Forms.Panel pnlConsultarCitas;
        private System.Windows.Forms.Button btnConsultaBuscar;
        private System.Windows.Forms.DateTimePicker dtpConsultaFecha;
        private System.Windows.Forms.ComboBox cmbConsultaServicio;
        private System.Windows.Forms.ComboBox cmbConsultaCliente;
        private System.Windows.Forms.Label lblConsultaFecha;
        private System.Windows.Forms.Label lblConsultaServicio;
        private System.Windows.Forms.Label lblConsultaCliente;
        private System.Windows.Forms.Label lblTituloConsulta;
        private System.Windows.Forms.DataGridView dgvConsultaCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
    }
}