namespace ControlesAdicionales
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabClientesPedidos = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.MaskedTextBox();
            this.txtNif = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pbClientes = new System.Windows.Forms.ProgressBar();
            this.nudCliente = new System.Windows.Forms.NumericUpDown();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.lbPedidos = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPedidosApellidos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPedidosNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPedidosNif = new System.Windows.Forms.TextBox();
            this.nudPedido = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pbPedidos = new System.Windows.Forms.ProgressBar();
            this.lbBicicletas = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMaximizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMinimizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLimpiar = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabClientesPedidos.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCliente)).BeginInit();
            this.tabPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabClientesPedidos
            // 
            this.tabClientesPedidos.Controls.Add(this.tabClientes);
            this.tabClientesPedidos.Controls.Add(this.tabPedidos);
            this.tabClientesPedidos.Location = new System.Drawing.Point(0, 27);
            this.tabClientesPedidos.Name = "tabClientesPedidos";
            this.tabClientesPedidos.SelectedIndex = 0;
            this.tabClientesPedidos.Size = new System.Drawing.Size(941, 512);
            this.tabClientesPedidos.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tabClientesPedidos, "Manage Clientes");
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.label7);
            this.tabClientes.Controls.Add(this.txtCodigoPostal);
            this.tabClientes.Controls.Add(this.txtNif);
            this.tabClientes.Controls.Add(this.txtDireccion);
            this.tabClientes.Controls.Add(this.label6);
            this.tabClientes.Controls.Add(this.label5);
            this.tabClientes.Controls.Add(this.label4);
            this.tabClientes.Controls.Add(this.label3);
            this.tabClientes.Controls.Add(this.txtApellidos);
            this.tabClientes.Controls.Add(this.label2);
            this.tabClientes.Controls.Add(this.label1);
            this.tabClientes.Controls.Add(this.txtNombre);
            this.tabClientes.Controls.Add(this.pbClientes);
            this.tabClientes.Controls.Add(this.nudCliente);
            this.tabClientes.Controls.Add(this.txtFechaNacimiento);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(933, 486);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.ToolTipText = "Manage Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Codigo postal";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(541, 314);
            this.txtCodigoPostal.Mask = "00000";
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(53, 20);
            this.txtCodigoPostal.TabIndex = 6;
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtCodigoPostal, "Código postal del cliente");
            this.txtCodigoPostal.ValidatingType = typeof(System.DateTime);
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(512, 242);
            this.txtNif.Mask = "00000000-L";
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(82, 20);
            this.txtNif.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtNif, "NIF del cliente");
            this.txtNif.ValidatingType = typeof(System.DateTime);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(434, 279);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(160, 20);
            this.txtDireccion.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDireccion, "Dirección del cliente");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(434, 169);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(160, 20);
            this.txtApellidos.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtApellidos, "Apellidos del cliente");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(434, 134);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNombre, "Nombre del cliente");
            // 
            // pbClientes
            // 
            this.pbClientes.Location = new System.Drawing.Point(0, 463);
            this.pbClientes.Maximum = 126;
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(933, 23);
            this.pbClientes.TabIndex = 5;
            // 
            // nudCliente
            // 
            this.nudCliente.Location = new System.Drawing.Point(541, 99);
            this.nudCliente.Name = "nudCliente";
            this.nudCliente.Size = new System.Drawing.Size(53, 20);
            this.nudCliente.TabIndex = 0;
            this.toolTip1.SetToolTip(this.nudCliente, "Id del cliente");
            this.nudCliente.ValueChanged += new System.EventHandler(this.nudCliente_ValueChanged);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(512, 205);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(82, 20);
            this.txtFechaNacimiento.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtFechaNacimiento, "Fecha de nacimiento del cliente");
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // tabPedidos
            // 
            this.tabPedidos.Controls.Add(this.lbPedidos);
            this.tabPedidos.Controls.Add(this.label12);
            this.tabPedidos.Controls.Add(this.label13);
            this.tabPedidos.Controls.Add(this.txtPedidosApellidos);
            this.tabPedidos.Controls.Add(this.label9);
            this.tabPedidos.Controls.Add(this.txtPedidosNombre);
            this.tabPedidos.Controls.Add(this.label10);
            this.tabPedidos.Controls.Add(this.label11);
            this.tabPedidos.Controls.Add(this.txtPedidosNif);
            this.tabPedidos.Controls.Add(this.nudPedido);
            this.tabPedidos.Controls.Add(this.label8);
            this.tabPedidos.Controls.Add(this.linkLabel1);
            this.tabPedidos.Controls.Add(this.pbPedidos);
            this.tabPedidos.Controls.Add(this.lbBicicletas);
            this.tabPedidos.Location = new System.Drawing.Point(4, 22);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(933, 486);
            this.tabPedidos.TabIndex = 1;
            this.tabPedidos.Text = "Pedidos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // lbPedidos
            // 
            this.lbPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedidos.FormattingEnabled = true;
            this.lbPedidos.ItemHeight = 20;
            this.lbPedidos.Location = new System.Drawing.Point(563, 238);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(160, 64);
            this.lbPedidos.TabIndex = 5;
            this.toolTip1.SetToolTip(this.lbPedidos, "Pedidos de los clientes");
            this.lbPedidos.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbPedidos_DragDrop);
            this.lbPedidos.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbPedidos_DragEnter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(434, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Apellidos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(434, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Pedido";
            // 
            // txtPedidosApellidos
            // 
            this.txtPedidosApellidos.Location = new System.Drawing.Point(563, 203);
            this.txtPedidosApellidos.Name = "txtPedidosApellidos";
            this.txtPedidosApellidos.Size = new System.Drawing.Size(160, 20);
            this.txtPedidosApellidos.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtPedidosApellidos, "Apellidos del cliente");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(434, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nombre";
            // 
            // txtPedidosNombre
            // 
            this.txtPedidosNombre.Location = new System.Drawing.Point(563, 165);
            this.txtPedidosNombre.Name = "txtPedidosNombre";
            this.txtPedidosNombre.Size = new System.Drawing.Size(160, 20);
            this.txtPedidosNombre.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPedidosNombre, "Nombre del cliente");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(434, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nif";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(434, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Pedido";
            // 
            // txtPedidosNif
            // 
            this.txtPedidosNif.Location = new System.Drawing.Point(563, 130);
            this.txtPedidosNif.Name = "txtPedidosNif";
            this.txtPedidosNif.Size = new System.Drawing.Size(160, 20);
            this.txtPedidosNif.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPedidosNif, "NIF del cliente");
            this.txtPedidosNif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPedidosNif_KeyDown);
            // 
            // nudPedido
            // 
            this.nudPedido.Location = new System.Drawing.Point(670, 95);
            this.nudPedido.Name = "nudPedido";
            this.nudPedido.Size = new System.Drawing.Size(53, 20);
            this.nudPedido.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nudPedido, "Id del pedido");
            this.nudPedido.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bicicletas";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(165, 336);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Descripcion productos";
            this.toolTip1.SetToolTip(this.linkLabel1, "Página web bicicletas");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pbPedidos
            // 
            this.pbPedidos.Location = new System.Drawing.Point(0, 463);
            this.pbPedidos.Name = "pbPedidos";
            this.pbPedidos.Size = new System.Drawing.Size(933, 23);
            this.pbPedidos.TabIndex = 6;
            // 
            // lbBicicletas
            // 
            this.lbBicicletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBicicletas.FormattingEnabled = true;
            this.lbBicicletas.ItemHeight = 20;
            this.lbBicicletas.Items.AddRange(new object[] {
            "Bici1",
            "Bici2",
            "Bici3",
            "Bici4",
            "Bici5"});
            this.lbBicicletas.Location = new System.Drawing.Point(168, 96);
            this.lbBicicletas.Name = "lbBicicletas";
            this.lbBicicletas.Size = new System.Drawing.Size(198, 184);
            this.lbBicicletas.TabIndex = 6;
            this.toolTip1.SetToolTip(this.lbBicicletas, "Lista de bicicletas");
            this.lbBicicletas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbBicicletas_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMaximizar,
            this.mnuNormal,
            this.mnuMinimizar,
            this.mnuSalir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 92);
            // 
            // mnuMaximizar
            // 
            this.mnuMaximizar.Name = "mnuMaximizar";
            this.mnuMaximizar.Size = new System.Drawing.Size(129, 22);
            this.mnuMaximizar.Text = "Maximizar";
            this.mnuMaximizar.Click += new System.EventHandler(this.mnuMaximizar_Click);
            // 
            // mnuNormal
            // 
            this.mnuNormal.Name = "mnuNormal";
            this.mnuNormal.Size = new System.Drawing.Size(129, 22);
            this.mnuNormal.Text = "Normal";
            this.mnuNormal.Click += new System.EventHandler(this.mnuNormal_Click);
            // 
            // mnuMinimizar
            // 
            this.mnuMinimizar.Name = "mnuMinimizar";
            this.mnuMinimizar.Size = new System.Drawing.Size(129, 22);
            this.mnuMinimizar.Text = "Minimizar";
            this.mnuMinimizar.Click += new System.EventHandler(this.mnuMinimizar_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(129, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.mnuGuardar,
            this.mnuLimpiar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColor,
            this.mnuFuente});
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.personalizarToolStripMenuItem.Text = "Personalizar";
            this.personalizarToolStripMenuItem.ToolTipText = "Cambiar fuente y color";
            // 
            // mnuColor
            // 
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(110, 22);
            this.mnuColor.Text = "Color";
            this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
            // 
            // mnuFuente
            // 
            this.mnuFuente.Name = "mnuFuente";
            this.mnuFuente.Size = new System.Drawing.Size(180, 22);
            this.mnuFuente.Text = "Fuente";
            this.mnuFuente.Click += new System.EventHandler(this.mnuFuente_Click);
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Name = "mnuGuardar";
            this.mnuGuardar.Size = new System.Drawing.Size(61, 20);
            this.mnuGuardar.Text = "Guardar";
            this.mnuGuardar.ToolTipText = "Guardar cliente o pedido";
            this.mnuGuardar.Click += new System.EventHandler(this.mnuGuardar_Click);
            // 
            // mnuLimpiar
            // 
            this.mnuLimpiar.Name = "mnuLimpiar";
            this.mnuLimpiar.Size = new System.Drawing.Size(59, 20);
            this.mnuLimpiar.Text = "Limpiar";
            this.mnuLimpiar.ToolTipText = "Limpiar fromulario";
            this.mnuLimpiar.Click += new System.EventHandler(this.mnuLimpiar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 538);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabClientesPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión pedidos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmPrincipal_DragOver);
            this.tabClientesPedidos.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCliente)).EndInit();
            this.tabPedidos.ResumeLayout(false);
            this.tabPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabClientesPedidos;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMaximizar;
        private System.Windows.Forms.ToolStripMenuItem mnuNormal;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lbBicicletas;
        private System.Windows.Forms.NumericUpDown nudCliente;
        private System.Windows.Forms.ProgressBar pbClientes;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolStripMenuItem mnuMinimizar;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuFuente;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardar;
        private System.Windows.Forms.ToolStripMenuItem mnuLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCodigoPostal;
        private System.Windows.Forms.MaskedTextBox txtNif;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbPedidos;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPedidosApellidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPedidosNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPedidosNif;
        private System.Windows.Forms.NumericUpDown nudPedido;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbPedidos;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

