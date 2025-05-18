namespace RestauranteElInge
{
    partial class frm_Mesas
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
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbox_Estado = new System.Windows.Forms.ComboBox();
            this.txt_UsuarioSistema = new System.Windows.Forms.TextBox();
            this.txt_NumeroMesa = new System.Windows.Forms.TextBox();
            this.lbl_nombreEmpleado = new System.Windows.Forms.Label();
            this.lbl_codigoEmpleado = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_TipoMesa = new System.Windows.Forms.ComboBox();
            this.cbox_cantidadSillas = new System.Windows.Forms.ComboBox();
            this.cboxUbicación = new System.Windows.Forms.ComboBox();
            this.txtCodigoMesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(735, 80);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(135, 37);
            this.btn_editar.TabIndex = 53;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(735, 29);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(135, 37);
            this.btn_guardar.TabIndex = 51;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbox_Estado
            // 
            this.cbox_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Estado.FormattingEnabled = true;
            this.cbox_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbox_Estado.Location = new System.Drawing.Point(328, 154);
            this.cbox_Estado.Name = "cbox_Estado";
            this.cbox_Estado.Size = new System.Drawing.Size(306, 28);
            this.cbox_Estado.TabIndex = 31;
            // 
            // txt_UsuarioSistema
            // 
            this.txt_UsuarioSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UsuarioSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioSistema.Location = new System.Drawing.Point(328, 104);
            this.txt_UsuarioSistema.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UsuarioSistema.Name = "txt_UsuarioSistema";
            this.txt_UsuarioSistema.Size = new System.Drawing.Size(306, 26);
            this.txt_UsuarioSistema.TabIndex = 30;
            // 
            // txt_NumeroMesa
            // 
            this.txt_NumeroMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NumeroMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumeroMesa.Location = new System.Drawing.Point(4, 104);
            this.txt_NumeroMesa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NumeroMesa.Name = "txt_NumeroMesa";
            this.txt_NumeroMesa.Size = new System.Drawing.Size(251, 26);
            this.txt_NumeroMesa.TabIndex = 27;
            // 
            // lbl_nombreEmpleado
            // 
            this.lbl_nombreEmpleado.AutoSize = true;
            this.lbl_nombreEmpleado.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEmpleado.Location = new System.Drawing.Point(324, 16);
            this.lbl_nombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombreEmpleado.Name = "lbl_nombreEmpleado";
            this.lbl_nombreEmpleado.Size = new System.Drawing.Size(122, 22);
            this.lbl_nombreEmpleado.TabIndex = 26;
            this.lbl_nombreEmpleado.Text = "Tipo de mesa:";
            // 
            // lbl_codigoEmpleado
            // 
            this.lbl_codigoEmpleado.AutoSize = true;
            this.lbl_codigoEmpleado.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoEmpleado.Location = new System.Drawing.Point(3, 80);
            this.lbl_codigoEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigoEmpleado.Name = "lbl_codigoEmpleado";
            this.lbl_codigoEmpleado.Size = new System.Drawing.Size(130, 22);
            this.lbl_codigoEmpleado.TabIndex = 25;
            this.lbl_codigoEmpleado.Text = "Numero Mesa:";
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
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(735, 184);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(135, 37);
            this.btn_limpiar.TabIndex = 52;
            this.btn_limpiar.Text = "LImpiar ";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // dgvMesas
            // 
            this.dgvMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Location = new System.Drawing.Point(29, 330);
            this.dgvMesas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersWidth = 51;
            this.dgvMesas.RowTemplate.Height = 24;
            this.dgvMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesas.Size = new System.Drawing.Size(945, 267);
            this.dgvMesas.TabIndex = 55;
            this.dgvMesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_CellClick_1);
            this.dgvMesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ubicación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad de sillas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario en sistema:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.cbox_TipoMesa);
            this.groupBox1.Controls.Add(this.cbox_cantidadSillas);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.cbox_Estado);
            this.groupBox1.Controls.Add(this.txt_UsuarioSistema);
            this.groupBox1.Controls.Add(this.txt_NumeroMesa);
            this.groupBox1.Controls.Add(this.lbl_nombreEmpleado);
            this.groupBox1.Controls.Add(this.lbl_codigoEmpleado);
            this.groupBox1.Controls.Add(this.cboxUbicación);
            this.groupBox1.Controls.Add(this.txtCodigoMesa);
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
            // cbox_TipoMesa
            // 
            this.cbox_TipoMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_TipoMesa.FormattingEnabled = true;
            this.cbox_TipoMesa.Items.AddRange(new object[] {
            "Interior",
            "Exterior",
            "Juegos",
            "Privadas"});
            this.cbox_TipoMesa.Location = new System.Drawing.Point(328, 38);
            this.cbox_TipoMesa.Name = "cbox_TipoMesa";
            this.cbox_TipoMesa.Size = new System.Drawing.Size(251, 28);
            this.cbox_TipoMesa.TabIndex = 55;
            // 
            // cbox_cantidadSillas
            // 
            this.cbox_cantidadSillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_cantidadSillas.FormattingEnabled = true;
            this.cbox_cantidadSillas.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.cbox_cantidadSillas.Location = new System.Drawing.Point(4, 154);
            this.cbox_cantidadSillas.Name = "cbox_cantidadSillas";
            this.cbox_cantidadSillas.Size = new System.Drawing.Size(251, 28);
            this.cbox_cantidadSillas.TabIndex = 54;
            // 
            // cboxUbicación
            // 
            this.cboxUbicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUbicación.FormattingEnabled = true;
            this.cboxUbicación.Items.AddRange(new object[] {
            "--",
            "--",
            "--",
            "--"});
            this.cboxUbicación.Location = new System.Drawing.Point(4, 209);
            this.cboxUbicación.Name = "cboxUbicación";
            this.cboxUbicación.Size = new System.Drawing.Size(251, 28);
            this.cboxUbicación.TabIndex = 23;
            // 
            // txtCodigoMesa
            // 
            this.txtCodigoMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMesa.Location = new System.Drawing.Point(4, 40);
            this.txtCodigoMesa.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoMesa.Name = "txtCodigoMesa";
            this.txtCodigoMesa.Size = new System.Drawing.Size(251, 26);
            this.txtCodigoMesa.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Mesa:";
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
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "MESAS";
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
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(735, 132);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(135, 37);
            this.btn_eliminar.TabIndex = 56;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // frm_Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 642);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "frm_Mesas";
            this.Text = "frm_Mesas";
            this.Load += new System.EventHandler(this.frm_Mesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbox_Estado;
        private System.Windows.Forms.TextBox txt_UsuarioSistema;
        private System.Windows.Forms.TextBox txt_NumeroMesa;
        private System.Windows.Forms.Label lbl_nombreEmpleado;
        private System.Windows.Forms.Label lbl_codigoEmpleado;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxUbicación;
        private System.Windows.Forms.TextBox txtCodigoMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbox_cantidadSillas;
        private System.Windows.Forms.ComboBox cbox_TipoMesa;
        private System.Windows.Forms.Button btn_eliminar;
    }
}