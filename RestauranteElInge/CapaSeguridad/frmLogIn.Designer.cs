namespace CapaSeguridad
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.btn_acceder = new System.Windows.Forms.Button();
            this.pictureBoxLogoInicio = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ErrorMessage = new System.Windows.Forms.Label();
            this.Pnl_InicioSesion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_InicioSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Mont", 14F, System.Drawing.FontStyle.Bold);
            this.txt_usuario.ForeColor = System.Drawing.Color.Gray;
            this.txt_usuario.Location = new System.Drawing.Point(411, 162);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(292, 26);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.Text = "Usuario";
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txt_Contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contrasenia.Font = new System.Drawing.Font("Mont", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Contrasenia.ForeColor = System.Drawing.Color.Gray;
            this.txt_Contrasenia.Location = new System.Drawing.Point(411, 206);
            this.txt_Contrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(292, 26);
            this.txt_Contrasenia.TabIndex = 1;
            this.txt_Contrasenia.Text = "Contraseña";
            this.txt_Contrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Contrasenia.Enter += new System.EventHandler(this.txt_Contrasenia_Enter);
            this.txt_Contrasenia.Leave += new System.EventHandler(this.txt_Contrasenia_Leave);
            // 
            // btn_acceder
            // 
            this.btn_acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btn_acceder.FlatAppearance.BorderSize = 0;
            this.btn_acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btn_acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btn_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceder.Font = new System.Drawing.Font("Mont Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acceder.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_acceder.Location = new System.Drawing.Point(498, 264);
            this.btn_acceder.Name = "btn_acceder";
            this.btn_acceder.Size = new System.Drawing.Size(115, 34);
            this.btn_acceder.TabIndex = 3;
            this.btn_acceder.Text = "ACCEDER";
            this.btn_acceder.UseVisualStyleBackColor = false;
            this.btn_acceder.Click += new System.EventHandler(this.btn_acceder_Click);
            // 
            // pictureBoxLogoInicio
            // 
            this.pictureBoxLogoInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoInicio.Image")));
            this.pictureBoxLogoInicio.Location = new System.Drawing.Point(26, 72);
            this.pictureBoxLogoInicio.Name = "pictureBoxLogoInicio";
            this.pictureBoxLogoInicio.Size = new System.Drawing.Size(310, 197);
            this.pictureBoxLogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoInicio.TabIndex = 10;
            this.pictureBoxLogoInicio.TabStop = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(744, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.TabIndex = 11;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(707, 3);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Minimizar.TabIndex = 12;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ErrorMessage
            // 
            this.lbl_ErrorMessage.AutoSize = true;
            this.lbl_ErrorMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ErrorMessage.Font = new System.Drawing.Font("Mont", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorMessage.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ErrorMessage.Image")));
            this.lbl_ErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ErrorMessage.Location = new System.Drawing.Point(435, 243);
            this.lbl_ErrorMessage.Name = "lbl_ErrorMessage";
            this.lbl_ErrorMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ErrorMessage.Size = new System.Drawing.Size(39, 18);
            this.lbl_ErrorMessage.TabIndex = 14;
            this.lbl_ErrorMessage.Text = "Error";
            this.lbl_ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ErrorMessage.Visible = false;
            // 
            // Pnl_InicioSesion
            // 
            this.Pnl_InicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.Pnl_InicioSesion.Controls.Add(this.label1);
            this.Pnl_InicioSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_InicioSesion.Font = new System.Drawing.Font("Mont Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_InicioSesion.Location = new System.Drawing.Point(0, 0);
            this.Pnl_InicioSesion.Name = "Pnl_InicioSesion";
            this.Pnl_InicioSesion.Size = new System.Drawing.Size(780, 35);
            this.Pnl_InicioSesion.TabIndex = 15;
            this.Pnl_InicioSesion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_InicioSesion_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mont Bold", 15.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(312, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btn_Minimizar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.Pnl_InicioSesion);
            this.Controls.Add(this.lbl_ErrorMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.pictureBoxLogoInicio);
            this.Controls.Add(this.btn_acceder);
            this.Controls.Add(this.txt_Contrasenia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(780, 330);
            this.MinimumSize = new System.Drawing.Size(780, 330);
            this.Name = "frmLogIn";
            this.Text = "frmLogIn";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogIn_MouseDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_InicioSesion.ResumeLayout(false);
            this.Pnl_InicioSesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.Button btn_acceder;
        private System.Windows.Forms.PictureBox pictureBoxLogoInicio;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ErrorMessage;
        private System.Windows.Forms.Panel Pnl_InicioSesion;
        private System.Windows.Forms.Label label1;
    }
}