namespace RestauranteElInge
{
    partial class frmUsuarios
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
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.cboxEstadoUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nombre_empleado = new System.Windows.Forms.Label();
            this.btn_EditarUsuario = new System.Windows.Forms.Button();
            this.btn_limpiarCampos = new System.Windows.Forms.Button();
            this.btn_guardarUsuario = new System.Windows.Forms.Button();
            this.cbox_rolUsuario = new System.Windows.Forms.ComboBox();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_contrasenia_usuario = new System.Windows.Forms.TextBox();
            this.txt_CodigoEmpleado = new System.Windows.Forms.TextBox();
            this.lbl_nombreEmpleado = new System.Windows.Forms.Label();
            this.lbl_codigoEmpleado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_eliminarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(36, 508);
            this.dgv_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersWidth = 51;
            this.dgv_usuarios.RowTemplate.Height = 24;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(936, 119);
            this.dgv_usuarios.TabIndex = 49;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            this.dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellContentClick);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(850, 40);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(43, 16);
            this.lbl_Fecha.TabIndex = 47;
            this.lbl_Fecha.Text = "-- -- -- ";
            this.lbl_Fecha.Click += new System.EventHandler(this.lbl_Fecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "ADMINISTACION DE USUARIOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUsuario.Location = new System.Drawing.Point(0, 104);
            this.txtCodigoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.ReadOnly = true;
            this.txtCodigoUsuario.Size = new System.Drawing.Size(251, 26);
            this.txtCodigoUsuario.TabIndex = 18;
            // 
            // cboxEstadoUsuario
            // 
            this.cboxEstadoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEstadoUsuario.FormattingEnabled = true;
            this.cboxEstadoUsuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstadoUsuario.Location = new System.Drawing.Point(0, 165);
            this.cboxEstadoUsuario.Name = "cboxEstadoUsuario";
            this.cboxEstadoUsuario.Size = new System.Drawing.Size(251, 28);
            this.cboxEstadoUsuario.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_eliminarUsuario);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_nombre_empleado);
            this.groupBox1.Controls.Add(this.btn_EditarUsuario);
            this.groupBox1.Controls.Add(this.btn_limpiarCampos);
            this.groupBox1.Controls.Add(this.btn_guardarUsuario);
            this.groupBox1.Controls.Add(this.cbox_rolUsuario);
            this.groupBox1.Controls.Add(this.txt_NombreUsuario);
            this.groupBox1.Controls.Add(this.txt_contrasenia_usuario);
            this.groupBox1.Controls.Add(this.txt_CodigoEmpleado);
            this.groupBox1.Controls.Add(this.lbl_nombreEmpleado);
            this.groupBox1.Controls.Add(this.lbl_codigoEmpleado);
            this.groupBox1.Controls.Add(this.cboxEstadoUsuario);
            this.groupBox1.Controls.Add(this.txtCodigoUsuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(936, 262);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_nombre_empleado
            // 
            this.lbl_nombre_empleado.AutoSize = true;
            this.lbl_nombre_empleado.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_empleado.Location = new System.Drawing.Point(313, 40);
            this.lbl_nombre_empleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre_empleado.Name = "lbl_nombre_empleado";
            this.lbl_nombre_empleado.Size = new System.Drawing.Size(78, 22);
            this.lbl_nombre_empleado.TabIndex = 54;
            this.lbl_nombre_empleado.Text = "-- -- -- -- ";
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarUsuario.Location = new System.Drawing.Point(735, 93);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Size = new System.Drawing.Size(135, 37);
            this.btn_EditarUsuario.TabIndex = 53;
            this.btn_EditarUsuario.Text = "Editar";
            this.btn_EditarUsuario.UseVisualStyleBackColor = true;
            this.btn_EditarUsuario.Click += new System.EventHandler(this.btn_EditarUsuario_Click);
            // 
            // btn_limpiarCampos
            // 
            this.btn_limpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiarCampos.Location = new System.Drawing.Point(735, 195);
            this.btn_limpiarCampos.Name = "btn_limpiarCampos";
            this.btn_limpiarCampos.Size = new System.Drawing.Size(135, 37);
            this.btn_limpiarCampos.TabIndex = 52;
            this.btn_limpiarCampos.Text = "LImpiar ";
            this.btn_limpiarCampos.UseVisualStyleBackColor = true;
            this.btn_limpiarCampos.Click += new System.EventHandler(this.btn_limpiarCampos_Click);
            // 
            // btn_guardarUsuario
            // 
            this.btn_guardarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarUsuario.Location = new System.Drawing.Point(735, 40);
            this.btn_guardarUsuario.Name = "btn_guardarUsuario";
            this.btn_guardarUsuario.Size = new System.Drawing.Size(135, 37);
            this.btn_guardarUsuario.TabIndex = 51;
            this.btn_guardarUsuario.Text = "Guardar";
            this.btn_guardarUsuario.UseVisualStyleBackColor = true;
            this.btn_guardarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbox_rolUsuario
            // 
            this.cbox_rolUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_rolUsuario.FormattingEnabled = true;
            this.cbox_rolUsuario.Items.AddRange(new object[] {
            "Admin",
            "Cocina",
            "Mesa",
            "Caja",
            "Bodega"});
            this.cbox_rolUsuario.Location = new System.Drawing.Point(0, 227);
            this.cbox_rolUsuario.Name = "cbox_rolUsuario";
            this.cbox_rolUsuario.Size = new System.Drawing.Size(247, 28);
            this.cbox_rolUsuario.TabIndex = 31;
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreUsuario.Location = new System.Drawing.Point(313, 104);
            this.txt_NombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(302, 26);
            this.txt_NombreUsuario.TabIndex = 29;
            // 
            // txt_contrasenia_usuario
            // 
            this.txt_contrasenia_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contrasenia_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasenia_usuario.Location = new System.Drawing.Point(313, 168);
            this.txt_contrasenia_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contrasenia_usuario.Name = "txt_contrasenia_usuario";
            this.txt_contrasenia_usuario.Size = new System.Drawing.Size(298, 26);
            this.txt_contrasenia_usuario.TabIndex = 28;
            // 
            // txt_CodigoEmpleado
            // 
            this.txt_CodigoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoEmpleado.Location = new System.Drawing.Point(0, 40);
            this.txt_CodigoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CodigoEmpleado.Name = "txt_CodigoEmpleado";
            this.txt_CodigoEmpleado.ReadOnly = true;
            this.txt_CodigoEmpleado.Size = new System.Drawing.Size(251, 26);
            this.txt_CodigoEmpleado.TabIndex = 27;
            // 
            // lbl_nombreEmpleado
            // 
            this.lbl_nombreEmpleado.AutoSize = true;
            this.lbl_nombreEmpleado.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEmpleado.Location = new System.Drawing.Point(313, 80);
            this.lbl_nombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombreEmpleado.Name = "lbl_nombreEmpleado";
            this.lbl_nombreEmpleado.Size = new System.Drawing.Size(150, 22);
            this.lbl_nombreEmpleado.TabIndex = 26;
            this.lbl_nombreEmpleado.Text = "Nombre Usuario ";
            // 
            // lbl_codigoEmpleado
            // 
            this.lbl_codigoEmpleado.AutoSize = true;
            this.lbl_codigoEmpleado.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoEmpleado.Location = new System.Drawing.Point(-4, 16);
            this.lbl_codigoEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigoEmpleado.Name = "lbl_codigoEmpleado";
            this.lbl_codigoEmpleado.Size = new System.Drawing.Size(160, 22);
            this.lbl_codigoEmpleado.TabIndex = 25;
            this.lbl_codigoEmpleado.Text = "Codigo Empleado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-4, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(759, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Fecha actual:";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(882, 632);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(106, 37);
            this.btn_salir.TabIndex = 50;
            this.btn_salir.Text = "CERRAR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dgv_Empleados
            // 
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Location = new System.Drawing.Point(36, 348);
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleados.Size = new System.Drawing.Size(936, 128);
            this.dgv_Empleados.TabIndex = 66;
            this.dgv_Empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empleados_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Selecciona un empleado para asignar su usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 479);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 67;
            this.label5.Text = "Usuarios:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(309, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 22);
            this.label9.TabIndex = 55;
            this.label9.Text = "Nombre del empleado:";
            // 
            // btn_eliminarUsuario
            // 
            this.btn_eliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarUsuario.Location = new System.Drawing.Point(735, 144);
            this.btn_eliminarUsuario.Name = "btn_eliminarUsuario";
            this.btn_eliminarUsuario.Size = new System.Drawing.Size(135, 37);
            this.btn_eliminarUsuario.TabIndex = 57;
            this.btn_eliminarUsuario.Text = "Eliminar";
            this.btn_eliminarUsuario.UseVisualStyleBackColor = true;
            this.btn_eliminarUsuario.Click += new System.EventHandler(this.btn_eliminarUsuario_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Empleados);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1014, 681);
            this.Name = "frmUsuarios";
            this.Text = "zz";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.ComboBox cboxEstadoUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_nombreEmpleado;
        private System.Windows.Forms.Label lbl_codigoEmpleado;
        private System.Windows.Forms.ComboBox cbox_rolUsuario;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.TextBox txt_contrasenia_usuario;
        private System.Windows.Forms.TextBox txt_CodigoEmpleado;
        private System.Windows.Forms.Button btn_limpiarCampos;
        private System.Windows.Forms.Button btn_guardarUsuario;
        private System.Windows.Forms.Button btn_EditarUsuario;
        private System.Windows.Forms.Label lbl_nombre_empleado;
        private System.Windows.Forms.DataGridView dgv_Empleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_eliminarUsuario;
    }
}