using System.Drawing;

namespace RestauranteElInge
{
    partial class panel_MenuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panel_MenuInicial));
            this.Pnl_logo = new System.Windows.Forms.Panel();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_RolUsuario = new System.Windows.Forms.Label();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.Menu_Lateral = new System.Windows.Forms.Panel();
            this.panel_pagos = new System.Windows.Forms.Panel();
            this.btn_pagoOrdenes = new System.Windows.Forms.Button();
            this.panel_ordenes = new System.Windows.Forms.Panel();
            this.btn_detalleOdenes = new System.Windows.Forms.Button();
            this.btn_encabezadoOrdenes = new System.Windows.Forms.Button();
            this.panel_menus_inventario = new System.Windows.Forms.Panel();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_menus = new System.Windows.Forms.Button();
            this.panel_clientes_mesas = new System.Windows.Forms.Panel();
            this.btn_mesas = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.panel_empleados = new System.Windows.Forms.Panel();
            this.btn_PlanPlanillas = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.panel_contenedor_de_formularios = new System.Windows.Forms.Panel();
            this.db_Restaurante_El_IngeDataSet1 = new RestauranteElInge.db_Restaurante_El_IngeDataSet();
            this.pictureBoxLogoInicio = new System.Windows.Forms.PictureBox();
            this.btn_cerrarSistema = new System.Windows.Forms.Button();
            this.btn_PrincipalPagos = new System.Windows.Forms.Button();
            this.btn_PrincipalOrdenes = new System.Windows.Forms.Button();
            this.btn_PrincipalMenuInventario = new System.Windows.Forms.Button();
            this.btn_PrincipalClientesMesas = new System.Windows.Forms.Button();
            this.btn_PrincipalEmpleados = new System.Windows.Forms.Button();
            this.btn_PrincipalInicio = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.Pnl_logo.SuspendLayout();
            this.Menu_Lateral.SuspendLayout();
            this.panel_pagos.SuspendLayout();
            this.panel_ordenes.SuspendLayout();
            this.panel_menus_inventario.SuspendLayout();
            this.panel_clientes_mesas.SuspendLayout();
            this.panel_empleados.SuspendLayout();
            this.panel_contenedor_de_formularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_Restaurante_El_IngeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_logo
            // 
            this.Pnl_logo.Controls.Add(this.lbl_Estado);
            this.Pnl_logo.Controls.Add(this.lbl_RolUsuario);
            this.Pnl_logo.Controls.Add(this.lbl_nombreUsuario);
            this.Pnl_logo.Controls.Add(this.pictureBoxLogo);
            this.Pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_logo.Name = "Pnl_logo";
            this.Pnl_logo.Size = new System.Drawing.Size(233, 130);
            this.Pnl_logo.TabIndex = 0;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Mont Bold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Estado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Estado.Location = new System.Drawing.Point(96, 89);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(96, 21);
            this.lbl_Estado.TabIndex = 3;
            this.lbl_Estado.Text = "USER STATE";
            // 
            // lbl_RolUsuario
            // 
            this.lbl_RolUsuario.AutoSize = true;
            this.lbl_RolUsuario.Font = new System.Drawing.Font("Mont Bold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_RolUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_RolUsuario.Location = new System.Drawing.Point(96, 52);
            this.lbl_RolUsuario.Name = "lbl_RolUsuario";
            this.lbl_RolUsuario.Size = new System.Drawing.Size(82, 21);
            this.lbl_RolUsuario.TabIndex = 2;
            this.lbl_RolUsuario.Text = "USER ROL";
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Mont Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(96, 19);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(48, 21);
            this.lbl_nombreUsuario.TabIndex = 1;
            this.lbl_nombreUsuario.Text = "USER";
            this.lbl_nombreUsuario.Click += new System.EventHandler(this.lbl_nombreUsuario_Click);
            // 
            // Menu_Lateral
            // 
            this.Menu_Lateral.AutoScroll = true;
            this.Menu_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Menu_Lateral.Controls.Add(this.btn_cerrarSistema);
            this.Menu_Lateral.Controls.Add(this.panel_pagos);
            this.Menu_Lateral.Controls.Add(this.btn_PrincipalPagos);
            this.Menu_Lateral.Controls.Add(this.panel_ordenes);
            this.Menu_Lateral.Controls.Add(this.btn_PrincipalOrdenes);
            this.Menu_Lateral.Controls.Add(this.panel_menus_inventario);
            this.Menu_Lateral.Controls.Add(this.btn_PrincipalMenuInventario);
            this.Menu_Lateral.Controls.Add(this.panel_clientes_mesas);
            this.Menu_Lateral.Controls.Add(this.btn_PrincipalClientesMesas);
            this.Menu_Lateral.Controls.Add(this.panel_empleados);
            this.Menu_Lateral.Controls.Add(this.btn_PrincipalEmpleados);
            this.Menu_Lateral.Controls.Add(this.btn_PrincipalInicio);
            this.Menu_Lateral.Controls.Add(this.Pnl_logo);
            this.Menu_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Lateral.Location = new System.Drawing.Point(0, 0);
            this.Menu_Lateral.Name = "Menu_Lateral";
            this.Menu_Lateral.Size = new System.Drawing.Size(250, 720);
            this.Menu_Lateral.TabIndex = 0;
            // 
            // panel_pagos
            // 
            this.panel_pagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(53)))));
            this.panel_pagos.Controls.Add(this.btn_pagoOrdenes);
            this.panel_pagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_pagos.Location = new System.Drawing.Point(0, 775);
            this.panel_pagos.Name = "panel_pagos";
            this.panel_pagos.Size = new System.Drawing.Size(233, 48);
            this.panel_pagos.TabIndex = 11;
            // 
            // btn_pagoOrdenes
            // 
            this.btn_pagoOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_pagoOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pagoOrdenes.FlatAppearance.BorderSize = 0;
            this.btn_pagoOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagoOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagoOrdenes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_pagoOrdenes.Location = new System.Drawing.Point(0, 0);
            this.btn_pagoOrdenes.Name = "btn_pagoOrdenes";
            this.btn_pagoOrdenes.Size = new System.Drawing.Size(233, 42);
            this.btn_pagoOrdenes.TabIndex = 0;
            this.btn_pagoOrdenes.Text = "Pago de ordenes";
            this.btn_pagoOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pagoOrdenes.UseVisualStyleBackColor = false;
            this.btn_pagoOrdenes.Click += new System.EventHandler(this.btn_pagoOrdenes_Click);
            // 
            // panel_ordenes
            // 
            this.panel_ordenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(53)))));
            this.panel_ordenes.Controls.Add(this.btn_detalleOdenes);
            this.panel_ordenes.Controls.Add(this.btn_encabezadoOrdenes);
            this.panel_ordenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ordenes.Location = new System.Drawing.Point(0, 659);
            this.panel_ordenes.Name = "panel_ordenes";
            this.panel_ordenes.Size = new System.Drawing.Size(233, 80);
            this.panel_ordenes.TabIndex = 9;
            // 
            // btn_detalleOdenes
            // 
            this.btn_detalleOdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_detalleOdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_detalleOdenes.FlatAppearance.BorderSize = 0;
            this.btn_detalleOdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detalleOdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalleOdenes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_detalleOdenes.Location = new System.Drawing.Point(0, 49);
            this.btn_detalleOdenes.Name = "btn_detalleOdenes";
            this.btn_detalleOdenes.Size = new System.Drawing.Size(233, 31);
            this.btn_detalleOdenes.TabIndex = 1;
            this.btn_detalleOdenes.Text = "Detalle de ordenes";
            this.btn_detalleOdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_detalleOdenes.UseVisualStyleBackColor = false;
            this.btn_detalleOdenes.Click += new System.EventHandler(this.btn_detalleOdenes_Click);
            // 
            // btn_encabezadoOrdenes
            // 
            this.btn_encabezadoOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_encabezadoOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_encabezadoOrdenes.FlatAppearance.BorderSize = 0;
            this.btn_encabezadoOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_encabezadoOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encabezadoOrdenes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_encabezadoOrdenes.Location = new System.Drawing.Point(0, 0);
            this.btn_encabezadoOrdenes.Name = "btn_encabezadoOrdenes";
            this.btn_encabezadoOrdenes.Size = new System.Drawing.Size(233, 49);
            this.btn_encabezadoOrdenes.TabIndex = 0;
            this.btn_encabezadoOrdenes.Text = "Encabezado de odenes";
            this.btn_encabezadoOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_encabezadoOrdenes.UseVisualStyleBackColor = false;
            this.btn_encabezadoOrdenes.Click += new System.EventHandler(this.btn_encabezadoOrdenes_Click);
            // 
            // panel_menus_inventario
            // 
            this.panel_menus_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(53)))));
            this.panel_menus_inventario.Controls.Add(this.btn_inventario);
            this.panel_menus_inventario.Controls.Add(this.btn_menus);
            this.panel_menus_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menus_inventario.Location = new System.Drawing.Point(0, 526);
            this.panel_menus_inventario.Name = "panel_menus_inventario";
            this.panel_menus_inventario.Size = new System.Drawing.Size(233, 97);
            this.panel_menus_inventario.TabIndex = 7;
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_inventario.Location = new System.Drawing.Point(0, 49);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(233, 48);
            this.btn_inventario.TabIndex = 1;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventario.UseVisualStyleBackColor = false;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_menus
            // 
            this.btn_menus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_menus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menus.FlatAppearance.BorderSize = 0;
            this.btn_menus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menus.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_menus.Location = new System.Drawing.Point(0, 0);
            this.btn_menus.Name = "btn_menus";
            this.btn_menus.Size = new System.Drawing.Size(233, 49);
            this.btn_menus.TabIndex = 0;
            this.btn_menus.Text = "Menus";
            this.btn_menus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menus.UseVisualStyleBackColor = false;
            this.btn_menus.Click += new System.EventHandler(this.btn_menus_Click);
            // 
            // panel_clientes_mesas
            // 
            this.panel_clientes_mesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(53)))));
            this.panel_clientes_mesas.Controls.Add(this.btn_mesas);
            this.panel_clientes_mesas.Controls.Add(this.btn_clientes);
            this.panel_clientes_mesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_clientes_mesas.Location = new System.Drawing.Point(0, 397);
            this.panel_clientes_mesas.Name = "panel_clientes_mesas";
            this.panel_clientes_mesas.Size = new System.Drawing.Size(233, 93);
            this.panel_clientes_mesas.TabIndex = 5;
            // 
            // btn_mesas
            // 
            this.btn_mesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_mesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mesas.FlatAppearance.BorderSize = 0;
            this.btn_mesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mesas.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mesas.Location = new System.Drawing.Point(0, 49);
            this.btn_mesas.Name = "btn_mesas";
            this.btn_mesas.Size = new System.Drawing.Size(233, 44);
            this.btn_mesas.TabIndex = 1;
            this.btn_mesas.Text = "Mesas";
            this.btn_mesas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mesas.UseVisualStyleBackColor = false;
            this.btn_mesas.Click += new System.EventHandler(this.btn_mesas_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clientes.Location = new System.Drawing.Point(0, 0);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(233, 49);
            this.btn_clientes.TabIndex = 0;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // panel_empleados
            // 
            this.panel_empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(53)))));
            this.panel_empleados.Controls.Add(this.btn_PlanPlanillas);
            this.panel_empleados.Controls.Add(this.btn_usuarios);
            this.panel_empleados.Controls.Add(this.btn_Empleados);
            this.panel_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_empleados.Location = new System.Drawing.Point(0, 226);
            this.panel_empleados.Name = "panel_empleados";
            this.panel_empleados.Size = new System.Drawing.Size(233, 135);
            this.panel_empleados.TabIndex = 3;
            // 
            // btn_PlanPlanillas
            // 
            this.btn_PlanPlanillas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_PlanPlanillas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PlanPlanillas.FlatAppearance.BorderSize = 0;
            this.btn_PlanPlanillas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_PlanPlanillas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_PlanPlanillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlanPlanillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlanPlanillas.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_PlanPlanillas.Location = new System.Drawing.Point(0, 95);
            this.btn_PlanPlanillas.Name = "btn_PlanPlanillas";
            this.btn_PlanPlanillas.Size = new System.Drawing.Size(233, 42);
            this.btn_PlanPlanillas.TabIndex = 2;
            this.btn_PlanPlanillas.Text = "Pago de Planillas";
            this.btn_PlanPlanillas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PlanPlanillas.UseVisualStyleBackColor = false;
            this.btn_PlanPlanillas.Click += new System.EventHandler(this.btn_PlanPlanillas_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_usuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 49);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(233, 46);
            this.btn_usuarios.TabIndex = 1;
            this.btn_usuarios.Text = "Usuarios del sistema";
            this.btn_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.btn_Empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Empleados.FlatAppearance.BorderSize = 0;
            this.btn_Empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Empleados.Location = new System.Drawing.Point(0, 0);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(233, 49);
            this.btn_Empleados.TabIndex = 0;
            this.btn_Empleados.Text = "Registro de Empelados";
            this.btn_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empleados.UseVisualStyleBackColor = false;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // panel_contenedor_de_formularios
            // 
            this.panel_contenedor_de_formularios.BackColor = System.Drawing.Color.White;
            this.panel_contenedor_de_formularios.Controls.Add(this.pictureBoxLogoInicio);
            this.panel_contenedor_de_formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor_de_formularios.Location = new System.Drawing.Point(250, 0);
            this.panel_contenedor_de_formularios.MinimumSize = new System.Drawing.Size(1014, 681);
            this.panel_contenedor_de_formularios.Name = "panel_contenedor_de_formularios";
            this.panel_contenedor_de_formularios.Size = new System.Drawing.Size(1030, 720);
            this.panel_contenedor_de_formularios.TabIndex = 1;
            this.panel_contenedor_de_formularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor_de_formularios_Paint);
            // 
            // db_Restaurante_El_IngeDataSet1
            // 
            this.db_Restaurante_El_IngeDataSet1.DataSetName = "db_Restaurante_El_IngeDataSet";
            this.db_Restaurante_El_IngeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBoxLogoInicio
            // 
            this.pictureBoxLogoInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoInicio.Image")));
            this.pictureBoxLogoInicio.Location = new System.Drawing.Point(383, 255);
            this.pictureBoxLogoInicio.Name = "pictureBoxLogoInicio";
            this.pictureBoxLogoInicio.Size = new System.Drawing.Size(415, 195);
            this.pictureBoxLogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoInicio.TabIndex = 1;
            this.pictureBoxLogoInicio.TabStop = false;
            this.pictureBoxLogoInicio.Click += new System.EventHandler(this.pictureBoxLogoInicio_Click);
            // 
            // btn_cerrarSistema
            // 
            this.btn_cerrarSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btn_cerrarSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cerrarSistema.FlatAppearance.BorderSize = 0;
            this.btn_cerrarSistema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cerrarSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cerrarSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSistema.Font = new System.Drawing.Font("Mont Bold", 13.25F, System.Drawing.FontStyle.Bold);
            this.btn_cerrarSistema.ForeColor = System.Drawing.Color.Snow;
            this.btn_cerrarSistema.Image = global::RestauranteElInge.Properties.Resources.logout_32dp;
            this.btn_cerrarSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrarSistema.Location = new System.Drawing.Point(0, 823);
            this.btn_cerrarSistema.Name = "btn_cerrarSistema";
            this.btn_cerrarSistema.Size = new System.Drawing.Size(233, 36);
            this.btn_cerrarSistema.TabIndex = 12;
            this.btn_cerrarSistema.Text = "CERRAR SESION";
            this.btn_cerrarSistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cerrarSistema.UseVisualStyleBackColor = false;
            this.btn_cerrarSistema.Click += new System.EventHandler(this.btn_cerrarSistema_Click);
            // 
            // btn_PrincipalPagos
            // 
            this.btn_PrincipalPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btn_PrincipalPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PrincipalPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PrincipalPagos.FlatAppearance.BorderSize = 0;
            this.btn_PrincipalPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrincipalPagos.Font = new System.Drawing.Font("Mont Bold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_PrincipalPagos.ForeColor = System.Drawing.Color.Snow;
            this.btn_PrincipalPagos.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrincipalPagos.Image")));
            this.btn_PrincipalPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrincipalPagos.Location = new System.Drawing.Point(0, 739);
            this.btn_PrincipalPagos.Name = "btn_PrincipalPagos";
            this.btn_PrincipalPagos.Size = new System.Drawing.Size(233, 36);
            this.btn_PrincipalPagos.TabIndex = 10;
            this.btn_PrincipalPagos.Text = "PAGOS";
            this.btn_PrincipalPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PrincipalPagos.UseVisualStyleBackColor = false;
            this.btn_PrincipalPagos.Click += new System.EventHandler(this.btn_PrincipalPagos_Click);
            // 
            // btn_PrincipalOrdenes
            // 
            this.btn_PrincipalOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btn_PrincipalOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PrincipalOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PrincipalOrdenes.FlatAppearance.BorderSize = 0;
            this.btn_PrincipalOrdenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrincipalOrdenes.Font = new System.Drawing.Font("Mont Bold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_PrincipalOrdenes.ForeColor = System.Drawing.Color.Snow;
            this.btn_PrincipalOrdenes.Image = global::RestauranteElInge.Properties.Resources.menu_book_32dp;
            this.btn_PrincipalOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrincipalOrdenes.Location = new System.Drawing.Point(0, 623);
            this.btn_PrincipalOrdenes.Name = "btn_PrincipalOrdenes";
            this.btn_PrincipalOrdenes.Size = new System.Drawing.Size(233, 36);
            this.btn_PrincipalOrdenes.TabIndex = 8;
            this.btn_PrincipalOrdenes.Text = "ORDENES";
            this.btn_PrincipalOrdenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PrincipalOrdenes.UseVisualStyleBackColor = false;
            this.btn_PrincipalOrdenes.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_PrincipalMenuInventario
            // 
            this.btn_PrincipalMenuInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btn_PrincipalMenuInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PrincipalMenuInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PrincipalMenuInventario.FlatAppearance.BorderSize = 0;
            this.btn_PrincipalMenuInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalMenuInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalMenuInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrincipalMenuInventario.Font = new System.Drawing.Font("Mont Bold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btn_PrincipalMenuInventario.ForeColor = System.Drawing.Color.Snow;
            this.btn_PrincipalMenuInventario.Image = global::RestauranteElInge.Properties.Resources.inventory_32dp;
            this.btn_PrincipalMenuInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrincipalMenuInventario.Location = new System.Drawing.Point(0, 490);
            this.btn_PrincipalMenuInventario.Name = "btn_PrincipalMenuInventario";
            this.btn_PrincipalMenuInventario.Size = new System.Drawing.Size(233, 36);
            this.btn_PrincipalMenuInventario.TabIndex = 6;
            this.btn_PrincipalMenuInventario.Text = "MENU E INVENTARIO";
            this.btn_PrincipalMenuInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PrincipalMenuInventario.UseVisualStyleBackColor = false;
            this.btn_PrincipalMenuInventario.Click += new System.EventHandler(this.btn_PrincipalMenuInventario_Click);
            // 
            // btn_PrincipalClientesMesas
            // 
            this.btn_PrincipalClientesMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btn_PrincipalClientesMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PrincipalClientesMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PrincipalClientesMesas.FlatAppearance.BorderSize = 0;
            this.btn_PrincipalClientesMesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalClientesMesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalClientesMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrincipalClientesMesas.Font = new System.Drawing.Font("Mont Bold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_PrincipalClientesMesas.ForeColor = System.Drawing.Color.Snow;
            this.btn_PrincipalClientesMesas.Image = global::RestauranteElInge.Properties.Resources.food_bank_32dp;
            this.btn_PrincipalClientesMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrincipalClientesMesas.Location = new System.Drawing.Point(0, 361);
            this.btn_PrincipalClientesMesas.Name = "btn_PrincipalClientesMesas";
            this.btn_PrincipalClientesMesas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_PrincipalClientesMesas.Size = new System.Drawing.Size(233, 36);
            this.btn_PrincipalClientesMesas.TabIndex = 4;
            this.btn_PrincipalClientesMesas.Text = "CLIENTES Y MESAS";
            this.btn_PrincipalClientesMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PrincipalClientesMesas.UseVisualStyleBackColor = false;
            this.btn_PrincipalClientesMesas.Click += new System.EventHandler(this.btn_PrincipalClientesMesas_Click);
            // 
            // btn_PrincipalEmpleados
            // 
            this.btn_PrincipalEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btn_PrincipalEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PrincipalEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PrincipalEmpleados.FlatAppearance.BorderSize = 0;
            this.btn_PrincipalEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_PrincipalEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrincipalEmpleados.Font = new System.Drawing.Font("Mont Bold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_PrincipalEmpleados.ForeColor = System.Drawing.Color.Snow;
            this.btn_PrincipalEmpleados.Image = global::RestauranteElInge.Properties.Resources.person_32dp;
            this.btn_PrincipalEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrincipalEmpleados.Location = new System.Drawing.Point(0, 190);
            this.btn_PrincipalEmpleados.Name = "btn_PrincipalEmpleados";
            this.btn_PrincipalEmpleados.Size = new System.Drawing.Size(233, 36);
            this.btn_PrincipalEmpleados.TabIndex = 2;
            this.btn_PrincipalEmpleados.Text = "EMPLEADOS";
            this.btn_PrincipalEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PrincipalEmpleados.UseVisualStyleBackColor = false;
            this.btn_PrincipalEmpleados.Click += new System.EventHandler(this.btn_PrincipalEmpleados_Click);
            // 
            // btn_PrincipalInicio
            // 
            this.btn_PrincipalInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btn_PrincipalInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PrincipalInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PrincipalInicio.FlatAppearance.BorderSize = 0;
            this.btn_PrincipalInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_PrincipalInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_PrincipalInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrincipalInicio.Font = new System.Drawing.Font("Mont Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrincipalInicio.ForeColor = System.Drawing.Color.Snow;
            this.btn_PrincipalInicio.Image = global::RestauranteElInge.Properties.Resources.home_32dp;
            this.btn_PrincipalInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrincipalInicio.Location = new System.Drawing.Point(0, 130);
            this.btn_PrincipalInicio.Name = "btn_PrincipalInicio";
            this.btn_PrincipalInicio.Size = new System.Drawing.Size(233, 60);
            this.btn_PrincipalInicio.TabIndex = 1;
            this.btn_PrincipalInicio.Text = "INICIO";
            this.btn_PrincipalInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrincipalInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PrincipalInicio.UseVisualStyleBackColor = false;
            this.btn_PrincipalInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(76, 130);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_MenuInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel_contenedor_de_formularios);
            this.Controls.Add(this.Menu_Lateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "panel_MenuInicial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            this.Pnl_logo.ResumeLayout(false);
            this.Pnl_logo.PerformLayout();
            this.Menu_Lateral.ResumeLayout(false);
            this.panel_pagos.ResumeLayout(false);
            this.panel_ordenes.ResumeLayout(false);
            this.panel_menus_inventario.ResumeLayout(false);
            this.panel_clientes_mesas.ResumeLayout(false);
            this.panel_empleados.ResumeLayout(false);
            this.panel_contenedor_de_formularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_Restaurante_El_IngeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_logo;
        private System.Windows.Forms.Panel Menu_Lateral;
        private System.Windows.Forms.Panel panel_empleados;
        private System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Button btn_PrincipalEmpleados;
        private System.Windows.Forms.Panel panel_menus_inventario;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_menus;
        private System.Windows.Forms.Button btn_PrincipalMenuInventario;
        private System.Windows.Forms.Panel panel_clientes_mesas;
        private System.Windows.Forms.Button btn_mesas;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_PrincipalClientesMesas;
        private System.Windows.Forms.Button btn_PlanPlanillas;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Panel panel_ordenes;
        private System.Windows.Forms.Button btn_detalleOdenes;
        private System.Windows.Forms.Button btn_encabezadoOrdenes;
        private System.Windows.Forms.Button btn_PrincipalOrdenes;
        private System.Windows.Forms.Panel panel_pagos;
        private System.Windows.Forms.Button btn_pagoOrdenes;
        private System.Windows.Forms.Button btn_PrincipalPagos;
        private System.Windows.Forms.Button btn_cerrarSistema;
        private System.Windows.Forms.Panel panel_contenedor_de_formularios;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogoInicio;
        private db_Restaurante_El_IngeDataSet db_Restaurante_El_IngeDataSet1;
        public System.Windows.Forms.Button btn_PrincipalInicio;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_RolUsuario;
    }
}

