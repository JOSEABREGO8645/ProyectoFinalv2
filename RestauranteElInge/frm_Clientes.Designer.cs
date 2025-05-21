namespace RestauranteElInge
{
    partial class frm_Clientes
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
            this.cbox_estadoCliente = new System.Windows.Forms.ComboBox();
            this.txt_UsuarioCliente = new System.Windows.Forms.TextBox();
            this.txt_nitCliente = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_nombreEmpleado = new System.Windows.Forms.Label();
            this.lbl_codigoEmpleado = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbox_categoriaCliente = new System.Windows.Forms.ComboBox();
            this.txt_TelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_estadoCliente
            // 
            this.cbox_estadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_estadoCliente.FormattingEnabled = true;
            this.cbox_estadoCliente.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbox_estadoCliente.Location = new System.Drawing.Point(328, 154);
            this.cbox_estadoCliente.Name = "cbox_estadoCliente";
            this.cbox_estadoCliente.Size = new System.Drawing.Size(306, 28);
            this.cbox_estadoCliente.TabIndex = 31;
            // 
            // txt_UsuarioCliente
            // 
            this.txt_UsuarioCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UsuarioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioCliente.Location = new System.Drawing.Point(328, 40);
            this.txt_UsuarioCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UsuarioCliente.Name = "txt_UsuarioCliente";
            this.txt_UsuarioCliente.Size = new System.Drawing.Size(306, 26);
            this.txt_UsuarioCliente.TabIndex = 29;
            // 
            // txt_nitCliente
            // 
            this.txt_nitCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nitCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nitCliente.Location = new System.Drawing.Point(4, 156);
            this.txt_nitCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nitCliente.Name = "txt_nitCliente";
            this.txt_nitCliente.Size = new System.Drawing.Size(251, 26);
            this.txt_nitCliente.TabIndex = 28;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreCliente.Location = new System.Drawing.Point(4, 104);
            this.txt_NombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(251, 26);
            this.txt_NombreCliente.TabIndex = 27;
            // 
            // lbl_nombreEmpleado
            // 
            this.lbl_nombreEmpleado.AutoSize = true;
            this.lbl_nombreEmpleado.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEmpleado.Location = new System.Drawing.Point(324, 16);
            this.lbl_nombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombreEmpleado.Name = "lbl_nombreEmpleado";
            this.lbl_nombreEmpleado.Size = new System.Drawing.Size(73, 22);
            this.lbl_nombreEmpleado.TabIndex = 26;
            this.lbl_nombreEmpleado.Text = "Usuario";
            // 
            // lbl_codigoEmpleado
            // 
            this.lbl_codigoEmpleado.AutoSize = true;
            this.lbl_codigoEmpleado.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoEmpleado.Location = new System.Drawing.Point(3, 80);
            this.lbl_codigoEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigoEmpleado.Name = "lbl_codigoEmpleado";
            this.lbl_codigoEmpleado.Size = new System.Drawing.Size(82, 22);
            this.lbl_codigoEmpleado.TabIndex = 25;
            this.lbl_codigoEmpleado.Text = "Nombre:";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(868, 602);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(106, 37);
            this.btn_salir.TabIndex = 56;
            this.btn_salir.Text = "CERRAR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(29, 330);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(945, 267);
            this.dgvClientes.TabIndex = 55;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.cbox_categoriaCliente);
            this.groupBox1.Controls.Add(this.txt_TelefonoCliente);
            this.groupBox1.Controls.Add(this.cbox_estadoCliente);
            this.groupBox1.Controls.Add(this.txt_UsuarioCliente);
            this.groupBox1.Controls.Add(this.txt_nitCliente);
            this.groupBox1.Controls.Add(this.txt_NombreCliente);
            this.groupBox1.Controls.Add(this.lbl_nombreEmpleado);
            this.groupBox1.Controls.Add(this.lbl_codigoEmpleado);
            this.groupBox1.Controls.Add(this.txtCodigoCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(945, 259);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(758, 143);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(135, 37);
            this.btn_eliminar.TabIndex = 60;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(758, 91);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(135, 37);
            this.btn_editar.TabIndex = 59;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(758, 195);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(135, 37);
            this.btn_limpiar.TabIndex = 58;
            this.btn_limpiar.Text = "LImpiar ";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(758, 40);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(135, 37);
            this.btn_guardar.TabIndex = 57;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cbox_categoriaCliente
            // 
            this.cbox_categoriaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_categoriaCliente.FormattingEnabled = true;
            this.cbox_categoriaCliente.Items.AddRange(new object[] {
            "Nuevo",
            "Ocasional",
            "Frecuente",
            "Exclusivo"});
            this.cbox_categoriaCliente.Location = new System.Drawing.Point(328, 101);
            this.cbox_categoriaCliente.Name = "cbox_categoriaCliente";
            this.cbox_categoriaCliente.Size = new System.Drawing.Size(306, 28);
            this.cbox_categoriaCliente.TabIndex = 55;
            // 
            // txt_TelefonoCliente
            // 
            this.txt_TelefonoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelefonoCliente.Location = new System.Drawing.Point(4, 208);
            this.txt_TelefonoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TelefonoCliente.Name = "txt_TelefonoCliente";
            this.txt_TelefonoCliente.Size = new System.Drawing.Size(251, 26);
            this.txt_TelefonoCliente.TabIndex = 54;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(4, 40);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(251, 26);
            this.txtCodigoCliente.TabIndex = 18;
            this.txtCodigoCliente.TextChanged += new System.EventHandler(this.txtCodigoCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de cliente::";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(836, 10);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(43, 16);
            this.lbl_Fecha.TabIndex = 53;
            this.lbl_Fecha.Text = "-- -- -- ";
            this.lbl_Fecha.Click += new System.EventHandler(this.lbl_Fecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "CLIENTES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(745, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Fecha actual:";
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Clientes";
            this.Text = "frm_Clientes";
            this.Load += new System.EventHandler(this.frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbox_estadoCliente;
        private System.Windows.Forms.TextBox txt_UsuarioCliente;
        private System.Windows.Forms.TextBox txt_nitCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label lbl_nombreEmpleado;
        private System.Windows.Forms.Label lbl_codigoEmpleado;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TelefonoCliente;
        private System.Windows.Forms.ComboBox cbox_categoriaCliente;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
    }
}