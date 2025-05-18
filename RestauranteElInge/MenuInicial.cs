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
        #region BarraLateral
        public panel_MenuInicial()
        {
            InitializeComponent();
            customizeDesing();
        }
        
        private void customizeDesing()
        {
            panel_clientes_mesas.Visible = false;
            panel_empleados.Visible = false;
            panel_menus_inventario.Visible = false;
            panel_ordenes.Visible = false;
            panel_pagos.Visible = false;
        }
        private void hideSubmenu()
        {
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
#region nosequehacenRegion
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
            //abrir form
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
                    OpenChildForm(new frmUsuarios());
                }
            }
            //si la comprobación es incorrecta simplemente lo habre
            else
            {
                OpenChildForm(new frmUsuarios());
            }
            hideSubmenu();
        }

        private void btn_PlanPlanillas_Click(object sender, EventArgs e)
        {
            //abrir form
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
                    OpenChildForm(new frm_Clientes());
                }
            }
            else
            {
                OpenChildForm(new frm_Clientes());
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
                    OpenChildForm(new frm_Mesas());
                }
            }
            else
            {
                OpenChildForm(new frm_Mesas());
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
            this.Close();
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

                pictureBoxLogo.Size = new Size(60, 60);
                pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxLogo.Location = new Point(
                    (Pnl_logo.Width - pictureBoxLogo.Width) / 2,
                    (Pnl_logo.Height - pictureBoxLogo.Height) / 2);

                foreach (Control control in  Menu_Lateral.Controls)
                {
                    if (control is Button btn)
                    {
                        btn.Text = "";
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                    }
                }
                menuExpandido = false;
            }
            else
            {
                //lineas para expandir
                Menu_Lateral.Width = anchoExpandido;
                Pnl_logo.Width = anchoExpandido;

                pictureBoxLogo.Size = new Size(238, 78);
                pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxLogo.Location = new Point(
    (Pnl_logo.Width - pictureBoxLogo.Width) / 2,
    (Pnl_logo.Height - pictureBoxLogo.Height) / 2);
                foreach (Control control in Menu_Lateral.Controls)
                {
                    if (control is Button btn)
                    {
                        btn.Text = btn.Tag?.ToString();
                        btn.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                }
                menuExpandido = true;;

            }
        }

        #endregion

    }
}