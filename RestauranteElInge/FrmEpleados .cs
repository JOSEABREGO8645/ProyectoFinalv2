using CapaDatos;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RestauranteElInge
{
    public partial class FrmEpleados : Form
    {
        CD_Empleados cd_empleados = new CD_Empleados();
        public string usuarioSistema;
        CL_Empleados cl_empleados = new CL_Empleados();
        public FrmEpleados(string usuario )
        {
            usuarioSistema = usuario;
            InitializeComponent();
        }
        public void MtdConsultarEmpleados()
        {
            DataTable dtEmpleados = cd_empleados.mtdConsultaEmpleados();
            dgv_Empleados.DataSource = dtEmpleados;
        }
        public void MtdLimpiarCampos()
        {
            txtNombre.Text = "";
            lblgneric.Text = "";
            cboCargo.Text = "";
            cboEstado.Text = "";
        }
        private void FrmEpleados_Load_1(object sender, EventArgs e)
        {
            MtdConsultarEmpleados();
            dgv_Empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btn_guardarEmpleado_Click(object sender, EventArgs e) {

            try
            {
                String Nombre = txtNombre.Text;
                String Cargo = cboCargo.Text;
                float Salario = float.Parse(lbl_Salario.Text);
                DateTime FechaContratacion = dtpFecha.Value;
                string Estado = cboEstado.Text;
                string UsuarioSistema = usuarioSistema;
                DateTime FechaSistema = DateTime.Now;

                cd_empleados.mtd_agregar_Empleados(Nombre, Cargo, Salario, FechaContratacion, Estado, UsuarioSistema, FechaSistema);

                MessageBox.Show("El empleado se agregó correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarEmpleados();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void lbl_Salario_Click(object sender, EventArgs e)
        {
            
        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Salario.Text = cl_empleados.mtd_SalarioEmpleado(cboCargo.Text).ToString();
        }

        private void btn_editarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoEmpleado = Convert.ToInt32(lbl_codigoEmpleado.Text);
                String Nombre = txtNombre.Text;
                String Cargo = cboCargo.Text;
                float Salario = float.Parse(lbl_Salario.Text);
                DateTime FechaContratacion = dtpFecha.Value;
                string Estado = cboEstado.Text;
                string UsuarioSistema = usuarioSistema;
                DateTime FechaSistema = DateTime.Now;

                cd_empleados.mtd_editar_Empleados(CodigoEmpleado, Nombre, Cargo, Salario, FechaContratacion, Estado, UsuarioSistema, FechaSistema);

                MessageBox.Show("El empleado se actualizó correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarEmpleados();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void dgv_Empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_codigoEmpleado.Text = dgv_Empleados.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgv_Empleados.SelectedCells[1].Value.ToString();
            cboCargo.Text = dgv_Empleados.SelectedCells[2].Value.ToString();
            lbl_Salario.Text = dgv_Empleados.SelectedCells[3].Value.ToString();
            dtpFecha.Text = dgv_Empleados.SelectedCells[4].Value.ToString();
            cboEstado.Text = dgv_Empleados.SelectedCells[5].Value.ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoEmpleado = int.Parse(lbl_codigoEmpleado.Text);

                cd_empleados.mtd_EliminarEmpleado(CodigoEmpleado);
                MtdConsultarEmpleados();
                MessageBox.Show("Se eliminó el empleado Correctamente.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdLimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}



