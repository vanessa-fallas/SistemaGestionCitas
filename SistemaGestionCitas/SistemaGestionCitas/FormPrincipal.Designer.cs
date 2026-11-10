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
            this.pnlServicios = new System.Windows.Forms.Panel();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.ColNombreServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.txtBuscarServicio = new System.Windows.Forms.TextBox();
            this.lblTotalServicios = new System.Windows.Forms.Label();
            this.lblBuscarServicio = new System.Windows.Forms.Label();
            this.lblTituloServicios = new System.Windows.Forms.Label();
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
            this.pnlAgregarServicio = new System.Windows.Forms.Panel();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.btnCancelarServicio = new System.Windows.Forms.Button();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnGuardarServicio = new System.Windows.Forms.Button();
            this.lblPrecioServicio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlAgregarServicios = new System.Windows.Forms.Panel();
            this.txtDServicio = new System.Windows.Forms.TextBox();
            this.txtNServicio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkDisponibilidad = new System.Windows.Forms.CheckBox();
            this.lblEstadoServicio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPServicio = new System.Windows.Forms.TextBox();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblTituloAgregarServicio = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlInicio.SuspendLayout();
            this.pnlServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlClientes.SuspendLayout();
            this.pnlAgregarServicio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAgregarServicios.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClientesToolStripMenuItem,
            this.regristrarServiciosToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.pacientesToolStripMenuItem.Text = "Clientes y Servicios";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // registrarClientesToolStripMenuItem
            // 
            this.registrarClientesToolStripMenuItem.Name = "registrarClientesToolStripMenuItem";
            this.registrarClientesToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.registrarClientesToolStripMenuItem.Text = "Registrar Clientes";
            this.registrarClientesToolStripMenuItem.Click += new System.EventHandler(this.registrarClientesToolStripMenuItem_Click);
            // 
            // regristrarServiciosToolStripMenuItem
            // 
            this.regristrarServiciosToolStripMenuItem.Name = "regristrarServiciosToolStripMenuItem";
            this.regristrarServiciosToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.regristrarServiciosToolStripMenuItem.Text = "Servicios Disponibles";
            this.regristrarServiciosToolStripMenuItem.Click += new System.EventHandler(this.regristrarServiciosToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCitaToolStripMenuItem,
            this.consultarCitasToolStripMenuItem,
            this.modificarOCancelarCitaToolStripMenuItem,
            this.cancelarCitasToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // registrarCitaToolStripMenuItem
            // 
            this.registrarCitaToolStripMenuItem.Name = "registrarCitaToolStripMenuItem";
            this.registrarCitaToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.registrarCitaToolStripMenuItem.Text = "Registrar Cita";
            this.registrarCitaToolStripMenuItem.Click += new System.EventHandler(this.registrarCitaToolStripMenuItem_Click);
            // 
            // consultarCitasToolStripMenuItem
            // 
            this.consultarCitasToolStripMenuItem.Name = "consultarCitasToolStripMenuItem";
            this.consultarCitasToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.consultarCitasToolStripMenuItem.Text = "Consultar Citas";
            // 
            // modificarOCancelarCitaToolStripMenuItem
            // 
            this.modificarOCancelarCitaToolStripMenuItem.Name = "modificarOCancelarCitaToolStripMenuItem";
            this.modificarOCancelarCitaToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.modificarOCancelarCitaToolStripMenuItem.Text = "Modificar Citas";
            // 
            // cancelarCitasToolStripMenuItem
            // 
            this.cancelarCitasToolStripMenuItem.Name = "cancelarCitasToolStripMenuItem";
            this.cancelarCitasToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.cancelarCitasToolStripMenuItem.Text = "Cancelar Citas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(31, 24);
            this.toolStripMenuItem1.Text = "  ";
            // 
            // pnlInicio
            // 
            this.pnlInicio.Controls.Add(this.lblSeleccion);
            this.pnlInicio.Controls.Add(this.lblBienvenida);
            this.pnlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInicio.Location = new System.Drawing.Point(0, 28);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(1067, 526);
            this.pnlInicio.TabIndex = 1;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(426, 32);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(205, 16);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Seleccione una opción del  menú";
            this.lblSeleccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(372, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(318, 32);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido al Sistema";
            // 
            // pnlServicios
            // 
            this.pnlServicios.Controls.Add(this.dgvServicios);
            this.pnlServicios.Controls.Add(this.btnActualizarLista);
            this.pnlServicios.Controls.Add(this.btnAgregarServicio);
            this.pnlServicios.Controls.Add(this.lblDisponibles);
            this.pnlServicios.Controls.Add(this.txtBuscarServicio);
            this.pnlServicios.Controls.Add(this.lblTotalServicios);
            this.pnlServicios.Controls.Add(this.lblBuscarServicio);
            this.pnlServicios.Controls.Add(this.lblTituloServicios);
            this.pnlServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServicios.Location = new System.Drawing.Point(0, 28);
            this.pnlServicios.Name = "pnlServicios";
            this.pnlServicios.Size = new System.Drawing.Size(1067, 526);
            this.pnlServicios.TabIndex = 4;
            this.pnlServicios.Visible = false;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombreServicio,
            this.colPrecio,
            this.colDuracion,
            this.colEstado});
            this.dgvServicios.Location = new System.Drawing.Point(40, 235);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(852, 268);
            this.dgvServicios.TabIndex = 12;
            // 
            // ColNombreServicio
            // 
            this.ColNombreServicio.HeaderText = "Nombre";
            this.ColNombreServicio.MinimumWidth = 6;
            this.ColNombreServicio.Name = "ColNombreServicio";
            this.ColNombreServicio.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colDuracion
            // 
            this.colDuracion.HeaderText = "Duración";
            this.colDuracion.MinimumWidth = 6;
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActualizarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarLista.Location = new System.Drawing.Point(429, 141);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(137, 31);
            this.btnActualizarLista.TabIndex = 7;
            this.btnActualizarLista.Text = "Actualizar";
            this.btnActualizarLista.UseVisualStyleBackColor = false;
            this.btnActualizarLista.Click += new System.EventHandler(this.btnActualizarLista_Click);
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.Location = new System.Drawing.Point(40, 189);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(225, 31);
            this.btnAgregarServicio.TabIndex = 10;
            this.btnAgregarServicio.Text = "Agregar Servicio";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibles.Location = new System.Drawing.Point(167, 73);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(130, 20);
            this.lblDisponibles.TabIndex = 3;
            this.lblDisponibles.Text = "Disponibles: 0";
            // 
            // txtBuscarServicio
            // 
            this.txtBuscarServicio.Location = new System.Drawing.Point(40, 146);
            this.txtBuscarServicio.Name = "txtBuscarServicio";
            this.txtBuscarServicio.Size = new System.Drawing.Size(365, 22);
            this.txtBuscarServicio.TabIndex = 2;
            // 
            // lblTotalServicios
            // 
            this.lblTotalServicios.AutoSize = true;
            this.lblTotalServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalServicios.Location = new System.Drawing.Point(36, 73);
            this.lblTotalServicios.Name = "lblTotalServicios";
            this.lblTotalServicios.Size = new System.Drawing.Size(73, 20);
            this.lblTotalServicios.TabIndex = 1;
            this.lblTotalServicios.Text = "Total: 0";
            // 
            // lblBuscarServicio
            // 
            this.lblBuscarServicio.AutoSize = true;
            this.lblBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarServicio.Location = new System.Drawing.Point(36, 111);
            this.lblBuscarServicio.Name = "lblBuscarServicio";
            this.lblBuscarServicio.Size = new System.Drawing.Size(248, 20);
            this.lblBuscarServicio.TabIndex = 11;
            this.lblBuscarServicio.Text = "Buscar servicio por nombre:";
            // 
            // lblTituloServicios
            // 
            this.lblTituloServicios.AutoSize = true;
            this.lblTituloServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloServicios.Location = new System.Drawing.Point(386, 0);
            this.lblTituloServicios.Name = "lblTituloServicios";
            this.lblTituloServicios.Size = new System.Drawing.Size(295, 32);
            this.lblTituloServicios.TabIndex = 0;
            this.lblTituloServicios.Text = "Gestion de Servicios";
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.Location = new System.Drawing.Point(386, 0);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(290, 32);
            this.lblTituloClientes.TabIndex = 0;
            this.lblTituloClientes.Text = "Registro de Clientes";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(36, 73);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(73, 20);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(126, 71);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(226, 22);
            this.txtCedula.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(36, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(165, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(230, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(336, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(36, 148);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(87, 20);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(140, 146);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(176, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(41, 189);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 31);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(180, 189);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 31);
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
            this.dgvClientes.Location = new System.Drawing.Point(40, 254);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(817, 249);
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
            this.pnlClientes.Location = new System.Drawing.Point(0, 28);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(1067, 526);
            this.pnlClientes.TabIndex = 3;
            this.pnlClientes.Visible = false;
            this.pnlClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientes_Paint);
            // 
            // pnlAgregarServicio
            // 
            this.pnlAgregarServicio.Controls.Add(this.txtDuracion);
            this.pnlAgregarServicio.Controls.Add(this.txtNombreServicio);
            this.pnlAgregarServicio.Controls.Add(this.btnCancelarServicio);
            this.pnlAgregarServicio.Controls.Add(this.chkDisponible);
            this.pnlAgregarServicio.Controls.Add(this.lblEstado);
            this.pnlAgregarServicio.Controls.Add(this.btnGuardarServicio);
            this.pnlAgregarServicio.Controls.Add(this.lblPrecioServicio);
            this.pnlAgregarServicio.Controls.Add(this.txtPrecio);
            this.pnlAgregarServicio.Location = new System.Drawing.Point(0, 0);
            this.pnlAgregarServicio.Name = "pnlAgregarServicio";
            this.pnlAgregarServicio.Size = new System.Drawing.Size(200, 100);
            this.pnlAgregarServicio.TabIndex = 0;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(244, 166);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(365, 22);
            this.txtDuracion.TabIndex = 16;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(244, 71);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(365, 22);
            this.txtNombreServicio.TabIndex = 15;
            // 
            // btnCancelarServicio
            // 
            this.btnCancelarServicio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarServicio.Location = new System.Drawing.Point(244, 300);
            this.btnCancelarServicio.Name = "btnCancelarServicio";
            this.btnCancelarServicio.Size = new System.Drawing.Size(161, 31);
            this.btnCancelarServicio.TabIndex = 14;
            this.btnCancelarServicio.Text = "Cancelar";
            this.btnCancelarServicio.UseVisualStyleBackColor = false;
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.Location = new System.Drawing.Point(41, 254);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(94, 20);
            this.chkDisponible.TabIndex = 13;
            this.chkDisponible.Text = "Disponible";
            this.chkDisponible.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(36, 212);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(170, 20);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado del servicio";
            // 
            // btnGuardarServicio
            // 
            this.btnGuardarServicio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarServicio.Location = new System.Drawing.Point(40, 300);
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(161, 31);
            this.btnGuardarServicio.TabIndex = 10;
            this.btnGuardarServicio.Text = "Guardar";
            this.btnGuardarServicio.UseVisualStyleBackColor = false;
            // 
            // lblPrecioServicio
            // 
            this.lblPrecioServicio.AutoSize = true;
            this.lblPrecioServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioServicio.Location = new System.Drawing.Point(36, 123);
            this.lblPrecioServicio.Name = "lblPrecioServicio";
            this.lblPrecioServicio.Size = new System.Drawing.Size(69, 20);
            this.lblPrecioServicio.TabIndex = 3;
            this.lblPrecioServicio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(140, 123);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(365, 22);
            this.txtPrecio.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 22);
            this.textBox1.TabIndex = 16;
            // 
            // pnlAgregarServicios
            // 
            this.pnlAgregarServicios.Controls.Add(this.txtDServicio);
            this.pnlAgregarServicios.Controls.Add(this.txtNServicio);
            this.pnlAgregarServicios.Controls.Add(this.btnCancelar);
            this.pnlAgregarServicios.Controls.Add(this.chkDisponibilidad);
            this.pnlAgregarServicios.Controls.Add(this.lblEstadoServicio);
            this.pnlAgregarServicios.Controls.Add(this.btnGuardar);
            this.pnlAgregarServicios.Controls.Add(this.lblPrecio);
            this.pnlAgregarServicios.Controls.Add(this.txtPServicio);
            this.pnlAgregarServicios.Controls.Add(this.lblNombreServicio);
            this.pnlAgregarServicios.Controls.Add(this.lblDuracion);
            this.pnlAgregarServicios.Controls.Add(this.lblTituloAgregarServicio);
            this.pnlAgregarServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAgregarServicios.Location = new System.Drawing.Point(0, 28);
            this.pnlAgregarServicios.Name = "pnlAgregarServicios";
            this.pnlAgregarServicios.Size = new System.Drawing.Size(1067, 526);
            this.pnlAgregarServicios.TabIndex = 16;
            this.pnlAgregarServicios.Visible = false;
            // 
            // txtDServicio
            // 
            this.txtDServicio.Location = new System.Drawing.Point(244, 166);
            this.txtDServicio.Name = "txtDServicio";
            this.txtDServicio.Size = new System.Drawing.Size(365, 22);
            this.txtDServicio.TabIndex = 16;
            // 
            // txtNServicio
            // 
            this.txtNServicio.Location = new System.Drawing.Point(244, 71);
            this.txtNServicio.Name = "txtNServicio";
            this.txtNServicio.Size = new System.Drawing.Size(365, 22);
            this.txtNServicio.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(244, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 31);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // chkDisponibilidad
            // 
            this.chkDisponibilidad.AutoSize = true;
            this.chkDisponibilidad.Checked = true;
            this.chkDisponibilidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisponibilidad.Location = new System.Drawing.Point(41, 254);
            this.chkDisponibilidad.Name = "chkDisponibilidad";
            this.chkDisponibilidad.Size = new System.Drawing.Size(94, 20);
            this.chkDisponibilidad.TabIndex = 13;
            this.chkDisponibilidad.Text = "Disponible";
            this.chkDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // lblEstadoServicio
            // 
            this.lblEstadoServicio.AutoSize = true;
            this.lblEstadoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoServicio.Location = new System.Drawing.Point(36, 212);
            this.lblEstadoServicio.Name = "lblEstadoServicio";
            this.lblEstadoServicio.Size = new System.Drawing.Size(170, 20);
            this.lblEstadoServicio.TabIndex = 12;
            this.lblEstadoServicio.Text = "Estado del servicio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(40, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 31);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(36, 123);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(69, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPServicio
            // 
            this.txtPServicio.Location = new System.Drawing.Point(126, 121);
            this.txtPServicio.Name = "txtPServicio";
            this.txtPServicio.Size = new System.Drawing.Size(365, 22);
            this.txtPServicio.TabIndex = 2;
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.Location = new System.Drawing.Point(36, 73);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(183, 20);
            this.lblNombreServicio.TabIndex = 1;
            this.lblNombreServicio.Text = "Nombre del servicio:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(36, 166);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(189, 20);
            this.lblDuracion.TabIndex = 11;
            this.lblDuracion.Text = "Duración en minutos:";
            // 
            // lblTituloAgregarServicio
            // 
            this.lblTituloAgregarServicio.AutoSize = true;
            this.lblTituloAgregarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregarServicio.Location = new System.Drawing.Point(34, 19);
            this.lblTituloAgregarServicio.Name = "lblTituloAgregarServicio";
            this.lblTituloAgregarServicio.Size = new System.Drawing.Size(326, 32);
            this.lblTituloAgregarServicio.TabIndex = 0;
            this.lblTituloAgregarServicio.Text = "Agregar nuevo servicio";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlAgregarServicios);
            this.Controls.Add(this.pnlServicios);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Citas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            this.pnlServicios.ResumeLayout(false);
            this.pnlServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            this.pnlAgregarServicio.ResumeLayout(false);
            this.pnlAgregarServicio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAgregarServicios.ResumeLayout(false);
            this.pnlAgregarServicios.PerformLayout();
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
        private System.Windows.Forms.Panel pnlServicios;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.TextBox txtBuscarServicio;
        private System.Windows.Forms.Label lblTotalServicios;
        private System.Windows.Forms.Label lblTituloServicios;
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
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Label lblBuscarServicio;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Panel pnlAgregarServicio;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Button btnCancelarServicio;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnGuardarServicio;
        private System.Windows.Forms.Label lblPrecioServicio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlAgregarServicios;
        private System.Windows.Forms.TextBox txtDServicio;
        private System.Windows.Forms.TextBox txtNServicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkDisponibilidad;
        private System.Windows.Forms.Label lblEstadoServicio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPServicio;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblTituloAgregarServicio;
    }
}

