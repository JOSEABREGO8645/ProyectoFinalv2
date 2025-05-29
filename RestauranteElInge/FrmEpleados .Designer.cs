using System.Drawing;
using System.Windows.Forms;

namespace RestauranteElInge
{
    partial class FrmEpleados
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblgneric = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editarEmpleado = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardarEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_codigoEmpleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calisto MT", 14.25F);
            this.lblNombre.Location = new System.Drawing.Point(65, 132);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 22);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(51, 83);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(0, 13);
            this.lblCargo.TabIndex = 2;
            // 
            // lblgneric
            // 
            this.lblgneric.AutoSize = true;
            this.lblgneric.Font = new System.Drawing.Font("Calisto MT", 14.25F);
            this.lblgneric.Location = new System.Drawing.Point(65, 226);
            this.lblgneric.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgneric.Name = "lblgneric";
            this.lblgneric.Size = new System.Drawing.Size(65, 22);
            this.lblgneric.TabIndex = 3;
            this.lblgneric.Text = "Salario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calisto MT", 14.25F);
            this.lblFecha.Location = new System.Drawing.Point(439, 129);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 22);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Calisto MT", 14.25F);
            this.lblEstado.Location = new System.Drawing.Point(438, 181);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(65, 22);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpFecha.Location = new System.Drawing.Point(522, 123);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(233, 26);
            this.dtpFecha.TabIndex = 9;
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Suspendido",
            "Despedido"});
            this.cboEstado.Location = new System.Drawing.Point(522, 175);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(233, 28);
            this.cboEstado.TabIndex = 10;
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Gerente",
            "Cocinero",
            "Mesero",
            "Cajero",
            "Bodeguero"});
            this.cboCargo.Location = new System.Drawing.Point(173, 175);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(233, 28);
            this.cboCargo.TabIndex = 11;
            this.cboCargo.SelectedIndexChanged += new System.EventHandler(this.cboCargo_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(173, 128);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 26);
            this.txtNombre.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F);
            this.label2.Location = new System.Drawing.Point(65, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cargo";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(906, 632);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(106, 37);
            this.btn_salir.TabIndex = 57;
            this.btn_salir.Text = "CERRAR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(838, 211);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(135, 37);
            this.btn_eliminar.TabIndex = 62;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editarEmpleado
            // 
            this.btn_editarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarEmpleado.Location = new System.Drawing.Point(838, 159);
            this.btn_editarEmpleado.Name = "btn_editarEmpleado";
            this.btn_editarEmpleado.Size = new System.Drawing.Size(135, 37);
            this.btn_editarEmpleado.TabIndex = 61;
            this.btn_editarEmpleado.Text = "Editar";
            this.btn_editarEmpleado.UseVisualStyleBackColor = true;
            this.btn_editarEmpleado.Click += new System.EventHandler(this.btn_editarEmpleado_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(838, 263);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(135, 37);
            this.btn_limpiar.TabIndex = 60;
            this.btn_limpiar.Text = "LImpiar ";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardarEmpleado
            // 
            this.btn_guardarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarEmpleado.Location = new System.Drawing.Point(838, 108);
            this.btn_guardarEmpleado.Name = "btn_guardarEmpleado";
            this.btn_guardarEmpleado.Size = new System.Drawing.Size(135, 37);
            this.btn_guardarEmpleado.TabIndex = 59;
            this.btn_guardarEmpleado.Text = "Guardar";
            this.btn_guardarEmpleado.UseVisualStyleBackColor = true;
            this.btn_guardarEmpleado.Click += new System.EventHandler(this.btn_guardarEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "GESTION DE EMPLEADOS";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(912, 30);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(31, 13);
            this.lbl_Fecha.TabIndex = 64;
            this.lbl_Fecha.Text = "-- -- --";
            // 
            // dgv_Empleados
            // 
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Location = new System.Drawing.Point(35, 309);
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleados.Size = new System.Drawing.Size(938, 296);
            this.dgv_Empleados.TabIndex = 65;
            this.dgv_Empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empleados_CellClick);
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Salario.Location = new System.Drawing.Point(168, 228);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(47, 20);
            this.lbl_Salario.TabIndex = 66;
            this.lbl_Salario.Text = "-- -- --";
            this.lbl_Salario.Click += new System.EventHandler(this.lbl_Salario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F);
            this.label3.Location = new System.Drawing.Point(439, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "Codigo de Empleado";
            // 
            // lbl_codigoEmpleado
            // 
            this.lbl_codigoEmpleado.AutoSize = true;
            this.lbl_codigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_codigoEmpleado.Location = new System.Drawing.Point(623, 228);
            this.lbl_codigoEmpleado.Name = "lbl_codigoEmpleado";
            this.lbl_codigoEmpleado.Size = new System.Drawing.Size(47, 20);
            this.lbl_codigoEmpleado.TabIndex = 68;
            this.lbl_codigoEmpleado.Text = "-- -- --";
            // 
            // FrmEpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.lbl_codigoEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Salario);
            this.Controls.Add(this.dgv_Empleados);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editarEmpleado);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardarEmpleado);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblgneric);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEpleados";
            this.Load += new System.EventHandler(this.FrmEpleados_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblNombre;
        private Label lblCargo;
        private Label lblgneric;
        private Label lblFecha;
        private Label lblEstado;
        private DateTimePicker dtpFecha;
        private ComboBox cboEstado;
        private ComboBox cboCargo;
        private TextBox txtNombre;
        private Label label2;
        private Button btn_salir;
        private Button btn_eliminar;
        private Button btn_editarEmpleado;
        private Button btn_limpiar;
        private Button btn_guardarEmpleado;
        private Label label1;
        private Label lbl_Fecha;
        private DataGridView dgv_Empleados;
        private Label lbl_Salario;
        private Label label3;
        private Label lbl_codigoEmpleado;
    }
}