﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace CapaSeguridad
{
    public partial class frmLogIn : Form
    {
        
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "Usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.White;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.Silver;
            }
        }

        private void txt_Contrasenia_Enter(object sender, EventArgs e)
        {
            if (txt_Contrasenia.Text == "Contraseña")
            {
                txt_Contrasenia.Text = "";
                txt_Contrasenia.ForeColor = Color.White;
                txt_Contrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contrasenia_Leave(object sender, EventArgs e)
        {
            if (txt_Contrasenia.Text == "")
            {
                txt_Contrasenia.Text = "Contraseña";
                txt_Contrasenia.ForeColor = Color.Silver;
                txt_Contrasenia.UseSystemPasswordChar = false;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        // Se importa la siguiente libreria para agregar logica de redimencionar el forms login
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text != "Username" && txt_usuario.TextLength > 2)
            {
                if (txt_Contrasenia.Text != "Password")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txt_usuario.Text, txt_Contrasenia.Text);
                    if (validLogin == true)
                    {
                         MenuInicial = new panel_MenuInicial();
                        MessageBox.Show("Bienvenido " + UserCache.NombreUsuario + ", " + UserCache.Rol);
                        MenuInicial.Show();

                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrecta.");
                        txt_Contrasenia.Text = "Password";
                        txt_Contrasenia.UseSystemPasswordChar = false;
                        txt_Contrasenia.Focus();
                    }
                }
                else msgError("Please enter password.");
            }
            else msgError("Please enter username.");
        }
    }
}
