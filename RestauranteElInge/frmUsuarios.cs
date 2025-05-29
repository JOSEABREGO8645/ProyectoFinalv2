using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaLogica;

namespace RestauranteElInge
{
    public partial class frmUsuarios : Form
    {
        CD_Empleados cd_empleados = new CD_Empleados();
        public string usuarioSistema;
        CD_Usuarios cd_usuarios = new CD_Usuarios();
        public frmUsuarios(string usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void MtdConsultarUsuarios()
        {

            DataTable dtClientes = cd_usuarios.mtdConsultaUsuarios();
            dgv_usuarios.DataSource = dtClientes;
        }
        public void MtdConsultarEmpleados()
        {
            DataTable dtEmpleados = cd_empleados.mtdConsultaEmpleados();
            dgv_Empleados.DataSource = dtEmpleados;
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MtdConsultarUsuarios();
            dgv_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MtdConsultarEmpleados();
            dgv_Empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
        }

        private void lbl_Fecha_Click(object sender, EventArgs e)
        {

        }

        private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //NOTUSE
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_Empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CodigoEmpleado.Text = dgv_Empleados.SelectedCells[0].Value.ToString();
            lbl_nombre_empleado.Text = dgv_Empleados.SelectedCells[1].Value.ToString();

            //OBTENER EL CODIGO DEL EMPLEADO SELECCIONADO
            String codigoempleadoseleccionado = txt_CodigoEmpleado.Text;

            //busca y selecciona el usuario coorespondiente en dgv usuarios 
            foreach (DataGridViewRow fila in dgv_usuarios.Rows)
            {
                if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == codigoempleadoseleccionado)
                {
                    fila.Selected = true;
                    // Selecciona la primera celda de la fila
                    dgv_usuarios.CurrentCell = fila.Cells[0]; 

                    txtCodigoUsuario.Text = dgv_usuarios.SelectedCells[0].Value.ToString();
                    txt_CodigoEmpleado.Text = dgv_usuarios.SelectedCells[1].Value.ToString();
                    txt_NombreUsuario.Text = dgv_usuarios.SelectedCells[2].Value.ToString();
                    txt_contrasenia_usuario.Text = dgv_usuarios.SelectedCells[3].Value.ToString();
                    cbox_rolUsuario.Text = dgv_usuarios.SelectedCells[4].Value.ToString();
                    cboxEstadoUsuario.Text = dgv_usuarios.SelectedCells[5].Value.ToString();
                    usuarioSistema = dgv_usuarios.SelectedCells[6].Value.ToString();
                    break; //finaliza el foreach despues de encontrar el usuario correspondiente

                }
                 
            }


        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoUsuario.Text = dgv_usuarios.SelectedCells[0].Value.ToString();
            txt_CodigoEmpleado.Text = dgv_usuarios.SelectedCells[1].Value.ToString();
            txt_NombreUsuario.Text = dgv_usuarios.SelectedCells[2].Value.ToString();
            txt_contrasenia_usuario.Text = dgv_usuarios.SelectedCells[3].Value.ToString();
            cbox_rolUsuario.Text = dgv_usuarios.SelectedCells[4].Value.ToString();
            cboxEstadoUsuario.Text = dgv_usuarios.SelectedCells[5].Value.ToString();
            usuarioSistema = dgv_usuarios.SelectedCells[6].Value.ToString();

            String codigoempleadoseleccionado = txt_CodigoEmpleado.Text;

            foreach (DataGridViewRow fila in dgv_Empleados.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == codigoempleadoseleccionado)
                {
                    fila.Selected = true;
                    dgv_Empleados.CurrentCell = fila.Cells[0]; // Selecciona la primera celda de la fila
                    lbl_nombre_empleado.Text = fila.Cells[1].Value.ToString();
                    break; 

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)//guardar usuario
        {
            try
            {
                int CodigoEmpleado = int.Parse(txt_CodigoEmpleado.Text);
                string NombreUsuario = txt_NombreUsuario.Text;
                string Contrasenia = txt_contrasenia_usuario.Text;
                string Rol = cbox_rolUsuario.Text;
                string Estado = cboxEstadoUsuario.Text;
                string UsuarioSistema = usuarioSistema; 
                DateTime FechaSistema = DateTime.Now;
                cd_usuarios.mtd_agregar_usuario(CodigoEmpleado, NombreUsuario, Contrasenia, Rol, Estado, UsuarioSistema, FechaSistema);
                MessageBox.Show("El usuario se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btn_EditarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoUsuario = int.Parse(txtCodigoUsuario.Text);
                int CodigoEmpleado = int.Parse(txt_CodigoEmpleado.Text);
                string NombreUsuario = txt_NombreUsuario.Text;
                string Contrasenia = txt_contrasenia_usuario.Text;
                string Rol = cbox_rolUsuario.Text;
                string Estado = cboxEstadoUsuario.Text;
                string UsuarioSistema = usuarioSistema;
                DateTime FechaSistema = DateTime.Now;
                cd_usuarios.mtd_Actualizar_Usuario( CodigoUsuario,  CodigoEmpleado,  NombreUsuario,  Contrasenia, Rol,  Estado,  UsuarioSistema,  FechaSistema);
                MessageBox.Show("El usuario se actualizó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_eliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoUsuario = int.Parse(txtCodigoUsuario.Text);

                cd_usuarios.mtd_Eliminar_Usuario(CodigoUsuario);
                MtdConsultarUsuarios();
                MessageBox.Show("Se eliminó la mesa Correctamente.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdLimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void MtdLimpiarCampos()
        {
            lbl_nombre_empleado.Text = " ";
            txtCodigoUsuario.Text = " ";
            txt_CodigoEmpleado.Text = " ";
            txt_NombreUsuario.Text = " ";
            txt_contrasenia_usuario.Text = " ";
            cbox_rolUsuario.Text = " ";
            cboxEstadoUsuario.Text = " ";
            
        }

        private void btn_limpiarCampos_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }
    }
}
