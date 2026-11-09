namespace SistemaGestionCitas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regristrarServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOCancelarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClientesToolStripMenuItem,
            this.regristrarServiciosToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.pacientesToolStripMenuItem.Text = "Clientes y Servicios";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // registrarClientesToolStripMenuItem
            // 
            this.registrarClientesToolStripMenuItem.Name = "registrarClientesToolStripMenuItem";
            this.registrarClientesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.registrarClientesToolStripMenuItem.Text = "Registrar Clientes";
            this.registrarClientesToolStripMenuItem.Click += new System.EventHandler(this.registrarClientesToolStripMenuItem_Click);
            // 
            // regristrarServiciosToolStripMenuItem
            // 
            this.regristrarServiciosToolStripMenuItem.Name = "regristrarServiciosToolStripMenuItem";
            this.regristrarServiciosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.regristrarServiciosToolStripMenuItem.Text = "Servicios Disponibles";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCitaToolStripMenuItem,
            this.consultarCitasToolStripMenuItem,
            this.modificarOCancelarCitaToolStripMenuItem,
            this.cancelarCitasToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // registrarCitaToolStripMenuItem
            // 
            this.registrarCitaToolStripMenuItem.Name = "registrarCitaToolStripMenuItem";
            this.registrarCitaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.registrarCitaToolStripMenuItem.Text = "Registrar Cita";
            this.registrarCitaToolStripMenuItem.Click += new System.EventHandler(this.registrarCitaToolStripMenuItem_Click);
            // 
            // consultarCitasToolStripMenuItem
            // 
            this.consultarCitasToolStripMenuItem.Name = "consultarCitasToolStripMenuItem";
            this.consultarCitasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.consultarCitasToolStripMenuItem.Text = "Consultar Citas";
            // 
            // modificarOCancelarCitaToolStripMenuItem
            // 
            this.modificarOCancelarCitaToolStripMenuItem.Name = "modificarOCancelarCitaToolStripMenuItem";
            this.modificarOCancelarCitaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.modificarOCancelarCitaToolStripMenuItem.Text = "Modificar Citas";
            // 
            // cancelarCitasToolStripMenuItem
            // 
            this.cancelarCitasToolStripMenuItem.Name = "cancelarCitasToolStripMenuItem";
            this.cancelarCitasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cancelarCitasToolStripMenuItem.Text = "Cancelar Citas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem1.Text = "  ";
            // 
            // pnlInicio
            // 
            this.pnlInicio.Controls.Add(this.lblSeleccion);
            this.pnlInicio.Controls.Add(this.lblBienvenida);
            this.pnlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInicio.Location = new System.Drawing.Point(0, 24);
            this.pnlInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(800, 426);
            this.pnlInicio.TabIndex = 1;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(320, 26);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(165, 13);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Seleccione una opción del  menú";
            this.lblSeleccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(279, 0);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(250, 26);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido al Sistema";
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.Location = new System.Drawing.Point(290, 0);
            this.lblTituloClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(228, 26);
            this.lblTituloClientes.TabIndex = 0;
            this.lblTituloClientes.Text = "Registro de Clientes";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(27, 59);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(63, 17);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(94, 58);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(170, 20);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(27, 90);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(141, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(27, 120);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(77, 17);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(105, 119);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(133, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(31, 154);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 25);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(135, 154);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 25);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCedula,
            this.colNombre,
            this.colTelefono});
            this.dgvClientes.Location = new System.Drawing.Point(30, 206);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(613, 202);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // colCedula
            // 
            this.colCedula.HeaderText = "Cédula";
            this.colCedula.MinimumWidth = 6;
            this.colCedula.Name = "colCedula";
            this.colCedula.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre Completo";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.MinimumWidth = 6;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.dgvClientes);
            this.pnlClientes.Controls.Add(this.btnLimpiar);
            this.pnlClientes.Controls.Add(this.btnRegistrar);
            this.pnlClientes.Controls.Add(this.txtTelefono);
            this.pnlClientes.Controls.Add(this.lblTelefono);
            this.pnlClientes.Controls.Add(this.txtNombre);
            this.pnlClientes.Controls.Add(this.lblNombre);
            this.pnlClientes.Controls.Add(this.txtCedula);
            this.pnlClientes.Controls.Add(this.lblCedula);
            this.pnlClientes.Controls.Add(this.lblTituloClientes);
            this.pnlClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClientes.Location = new System.Drawing.Point(0, 24);
            this.pnlClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(800, 426);
            this.pnlClientes.TabIndex = 3;
            this.pnlClientes.Visible = false;
            this.pnlClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientes_Paint);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Citas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regristrarServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOCancelarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.Panel pnlClientes;
    }
}

