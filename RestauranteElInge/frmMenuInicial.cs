
using CapaSeguridad;
using CapaSeguridadUserCache;    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestauranteElInge
{
    public partial class panel_MenuInicial : Form
    {

        public panel_MenuInicial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            customizeDesing();
            lbl_nombreUsuario.Text = UserCache.NombreUsuario ?? "usuario no identidficado";
            lbl_RolUsuario.Text = UserCache.Rol ?? "usuario no identidficado";
            lbl_Estado.Text = UserCache.Estado ?? "usuario no identidficado";

        }
        #region BarraLateral
        private void customizeDesing()
        {
            //OCULTA LOS PANELES DEL MENU
            panel_clientes_mesas.Visible = false;
            panel_empleados.Visible = false;
            panel_menus_inventario.Visible = false;
            panel_ordenes.Visible = false;
            panel_pagos.Visible = false;
        }
        private void hideSubmenu()
        {
            //OCULTA LOS PANELES DEL SUBMENU
            if (panel_clientes_mesas.Visible == true)
                panel_clientes_mesas.Visible = false;

            if (panel_empleados.Visible == true)
                panel_empleados.Visible = false;

            if (panel_menus_inventario.Visible == true)
                panel_menus_inventario.Visible = false;

            if (panel_ordenes.Visible == true)
                panel_ordenes.Visible = false;

            if (panel_pagos.Visible == true)
                panel_pagos.Visible = false;



        }
        private void showSubmenu(Panel subMenu)
        {
            //MUESTRA LOS PANENELES DEL MENU
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            { 
                subMenu.Visible = false;
            }

        }
#region 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                DialogResult result = MessageBox.Show(
                    "Si cierra la ventana actual \n\nLos datos que no esten guardados se eliminaran.",
                    "¿Desea continuar?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    activeForm.Close();
                    activeForm = null;
                }
            }
            else
            {
                MessageBox.Show("No hay formularios abiertos","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Lateral_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

       
        #region EmpleadosMenu
        private void btn_PrincipalEmpleados_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_empleados);
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            if (activeForm != null && activeForm.Text != "frmUsuarios")
            {
                //si la comprobacion es correcta pregunta si se quiere pasar a otro formulario
                DialogResult result = MessageBox.Show(
                    "Esta seguro que desea cambiar de ventana \n\nLos datos que no esten guardados se perderán.",
                    "¿Desea continuar?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                // si el resultado es si cambia
                if (result == DialogResult.Yes)
                {
                    OpenChildForm(new FrmEpleados(lbl_nombreUsuario.Text));
                }
            }
            //si la comprobación es incorrecta simplemente lo habre
            else
            {
                OpenChildForm(new FrmEpleados(lbl_nombreUsuario.Text));
            }
            hideSubmenu();
            hideSubmenu();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {

            // comprueba si el form esta activo y es  diferente de el que intento abrir
            if (activeForm != null && activeForm.Text != "frmUsuarios")
            {
                //si la comprobacion es correcta pregunta si se quiere pasar a otro formulario
                DialogResult result = MessageBox.Show(
                    "Esta seguro que desea cambiar de ventana \n\nLos datos que no esten guardados se perderán.",
                    "¿Desea continuar?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                // si el resultado es si cambia
                if (result == DialogResult.Yes)
                {
                    OpenChildForm(new frmUsuarios(lbl_nombreUsuario.Text));
                }
            }
            //si la comprobación es incorrecta simplemente lo habre
            else
            {
                OpenChildForm(new frmUsuarios(lbl_nombreUsuario.Text));
            }
            hideSubmenu();
        }

        private void btn_PlanPlanillas_Click(object sender, EventArgs e)
        {
            if (activeForm != null && activeForm.Text != "frm_Planillas")
            {
                DialogResult result = MessageBox.Show(
                    "Esta seguro que desea cambiar de ventana \n\nLos datos que no esten guardados se perderán.",
                    "¿Desea continuar?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    OpenChildForm(new frm_Planillas(lbl_nombreUsuario.Text));
                }
            }
            else
            {
                OpenChildForm(new frm_Planillas(lbl_nombreUsuario.Text));
            }


            hideSubmenu();
            hideSubmenu();
        }
        #endregion
        #region ClientesMesasMenu
        private void btn_PrincipalClientesMesas_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_clientes_mesas);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            if (activeForm != null &&  activeForm.Text != "frm_Clientes")
            {
                DialogResult result = MessageBox.Show(
                    "Esta seguro que desea cambiar de ventana \n\nLos datos que no esten guardados se perderán.",
                    "¿Desea continuar?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    OpenChildForm(new frm_Clientes(lbl_nombreUsuario.Text));
                }
            }
            else
            {
                OpenChildForm(new frm_Clientes(lbl_nombreUsuario.Text));
            }
            hideSubmenu();
        }

        private void btn_mesas_Click(object sender, EventArgs e)
        {
            if (activeForm != null && activeForm.Text != "frm_Mesas")
            {
                DialogResult result = MessageBox.Show(
                    "Esta seguro que desea cambiar de ventana \n\nLos datos que no esten guardados se perderán.",
                    "¿Desea continuar?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    OpenChildForm(new frm_Mesas(lbl_nombreUsuario.Text));
                }
            }
            else
            {
                OpenChildForm(new frm_Mesas(lbl_nombreUsuario.Text));
            }
            
           
            hideSubmenu();
        }
        #endregion
        #region InventarioMenu
        private void btn_PrincipalMenuInventario_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_menus_inventario);
        }

        private void btn_menus_Click(object sender, EventArgs e)
        {
            //abrir form
            hideSubmenu();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            //abrir form
            hideSubmenu();
        }
        #endregion
        #region OrdenesMenu
        private void button7_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_ordenes);
        }
        private void btn_encabezadoOrdenes_Click(object sender, EventArgs e)
        {
            //abrir form
            hideSubmenu();
        }

        private void btn_detalleOdenes_Click(object sender, EventArgs e)
        {
            //abrir form
            hideSubmenu();
        }

        private void btn_pagoOrdenes_Click(object sender, EventArgs e)
        {
            //abrir form
            hideSubmenu();
        }
        private void btn_PrincipalPagos_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_pagos);
        }
        #endregion
        #endregion

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            //PARA ABRIR LOS FORMULARIOS HIJO EN EL PANEL
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_contenedor_de_formularios.Controls.Add(childForm);
            panel_contenedor_de_formularios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            childForm.FormClosed += (s, e) => {activeForm = null; };

        }

        private void btn_cerrarSistema_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Se cerrará la sesión", "Advertencia",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                //cerrar el formulario
                this.Close();
            }
        }

        private void panel_contenedor_de_formularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
            foreach (Control control in Menu_Lateral.Controls)
            {
                if (control is Button btn)
                {
                    btn.Tag = btn.Text;
                }
            }

           
        }
        #region ComportamientoDeLABarraLateral
        //lineas para contraer el menu lateral
        private const int anchoExpandido = 210;
        private const int anchoColapsado = 60;
        private bool menuExpandido = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ContraerMenuLateral();
        }
        private void ContraerMenuLateral()
        {
            if (menuExpandido)
            {
                Menu_Lateral.Width = anchoColapsado;
                Pnl_logo.Width = anchoColapsado;
                //HACER EL LOGO MAS PEQUEÑO AL CONTRAER
                pictureBoxLogo.Size = new Size(60, 60);
                pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
                //MANTENER EL LOGO EN EL CENTRO
                pictureBoxLogo.Location = new Point( (Pnl_logo.Width - pictureBoxLogo.Width) / 2, (Pnl_logo.Height - pictureBoxLogo.Height) / 2);

                foreach (Control control in  Menu_Lateral.Controls)
                {
                    if (control is Button btn)
                    {
                        btn.Text = "";
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    }
                }
                menuExpandido = false;
            }
            else
            {
                //lineas para expandir
                Menu_Lateral.Width = anchoExpandido;
                Pnl_logo.Width = anchoExpandido;

                pictureBoxLogo.Size = new Size(76, 130);
                pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxLogo.Location = new Point((Pnl_logo.Width - pictureBoxLogo.Width) / 2,(Pnl_logo.Height - pictureBoxLogo.Height) / 2);
                foreach (Control control in Menu_Lateral.Controls)
                {
                    if (control is Button btn)
                    {
                        btn.Text = btn.Tag?.ToString();
                        btn.ImageAlign = ContentAlignment.MiddleLeft;
                        btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    }
                }
                menuExpandido = true;;

            }
        }

        #endregion

        private void pictureBoxLogoInicio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxtTitle_Click(object sender, EventArgs e)
        {

        }


        private void lbl_nombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}