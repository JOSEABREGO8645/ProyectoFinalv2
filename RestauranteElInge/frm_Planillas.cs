using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using System.Net.NetworkInformation;

namespace RestauranteElInge
{
    public partial class frm_Planillas : Form
    {
        public string usuarioSistema;
        CD_Empleados cd_empleados = new CD_Empleados();
        Cd_planilla cd_planilla = new Cd_planilla();
        CL_Planilla cl_planilla = new CL_Planilla();

        public frm_Planillas(string usuario)
        {
            usuarioSistema = usuario;
            InitializeComponent();
        }

        private void lbl_codigoEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigoEmpleado_TextChanged(object sender, EventArgs e)
        {

            string codigoEmpleado = txt_codigoEmpleado.Text.Trim();
            //revisa si el codigoEmpleado no esta vacio

            //si es diferenqe de  vacio, entonces consulta los empleados por codigo
            if (codigoEmpleado != null && codigoEmpleado != "")
            {
                //verifica que el codigoEmpleado sea un numero entero
                DataTable dtEmpleados = cd_empleados.mtdConsultaEmpleadosPorCoigo(codigoEmpleado);


                if (dtEmpleados.Rows.Count > 0)
                {
                    //si se encuentra el empleado, entonces se asignan los valores a los textbox
                    DataRow row = dtEmpleados.Rows[0];
                    //asignar los valores a los textbox

                    lbl_nombreEmpleado.Text = dtEmpleados.Rows[0]["Nombre"].ToString();
                    lbl_cargo.Text = dtEmpleados.Rows[0]["Cargo"].ToString();
                    decimal salario = Convert.ToDecimal(row["Salario"]);
                    lbl_salario.Text = salario.ToString(); 
                    //calcular el bono y el total
                    decimal bono = cl_planilla.mtdSalarioBono(salario);

                    int horasExtras = 0; // define las horas extras
                    if (txt_HorasExtras != null)
                    {
                        int.TryParse(txt_HorasExtras.Text, out horasExtras);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido para las horas extras.");
                }

                }
                else
                {
                    //limpiar los textbox si no se encuentra el empleado
                    lbl_nombreEmpleado.Text = "";
                    lbl_cargo.Text = "";
                    lbl_salario.Text = "";
                    
                    MessageBox.Show("No se encontró el empleado con el código proporcionado.");

                }
            }
        
        public void MtdConsultarEmpleados()
        {
            DataTable dtEmpleados = cd_empleados.mtdConsultaEmpleados();
        }

        private void txt_HorasExtras_TextChanged(object sender, EventArgs e)
        {
            string codigoEmpleado = txt_codigoEmpleado.Text.Trim();
            string horasExtrasText = txt_HorasExtras.Text.Trim();


            if (codigoEmpleado != null && codigoEmpleado != "")
            {
               
                DataTable dtEmpleados = cd_empleados.mtdConsultaEmpleadosPorCoigo(codigoEmpleado);


                if (dtEmpleados.Rows.Count > 0)
                {
                   
                    DataRow row = dtEmpleados.Rows[0];
                     decimal salario = Convert.ToDecimal(row["Salario"]);
                    decimal bono = cl_planilla.mtdSalarioBono(salario);

                    decimal horasExtras ;

                    if (!decimal.TryParse(horasExtrasText, out horasExtras))
                    {
                        MessageBox.Show("Por favor, ingrese un número válido para las horas extras.");
                        return;

                    }

                    decimal TotalhoarasExtras = horasExtras * 15; 
                    lbl_HorasExtra.Text = TotalhoarasExtras.ToString();

                    decimal total = cl_planilla.mtdSalarioTotal(salario, bono, horasExtras);
                    lbl_bono.Text = bono.ToString();
                    lbl_montoTotal.Text = total.ToString();

                }
                else
                {
                   
                    return;
                }
            }
        }

        public void MtdConsultarPlanillas()
        {
            DataTable dtPlanillas = cd_planilla.mtdConsultaPlanilla();
            dgvPlanillas.DataSource = dtPlanillas;
        }
        private void frm_Planillas_Load(object sender, EventArgs e)
        {
            MtdConsultarPlanillas();
            dgvPlanillas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void btn_guardarPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoEmpleado = int.Parse(txt_codigoEmpleado.Text);
                DateTime FechaPago = dtpFechaPago.Value;
                decimal Salario = decimal.Parse(lbl_salario.Text);
                decimal Bono = decimal.Parse(lbl_bono.Text);
                decimal HorasExtras = decimal.Parse(lbl_HorasExtra.Text);
                decimal MontoTotal = decimal.Parse(lbl_montoTotal.Text);
                string Estado = cbox_estadoEmpleadoPlanilla.Text;
                string UsuarioSistema = usuarioSistema;
                DateTime FechaSistema = DateTime.Now;
                

                cd_planilla.mtd_agregar_Planilla(CodigoEmpleado, FechaPago, Salario, Bono, HorasExtras, MontoTotal, Estado, UsuarioSistema, FechaSistema);

                MessageBox.Show("La planilla se agregó correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarPlanillas();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editarPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoPagoPlanilla = int.Parse(lbl_codigoPlanilla.Text);
                int CodigoEmpleado = int.Parse(txt_codigoEmpleado.Text);
                DateTime FechaPago = dtpFechaPago.Value;
                decimal Salario = decimal.Parse(lbl_salario.Text);
                decimal Bono = decimal.Parse(lbl_bono.Text);
                decimal HorasExtras = decimal.Parse(lbl_HorasExtra.Text);
                decimal MontoTotal = decimal.Parse(lbl_montoTotal.Text);
                string Estado = cbox_estadoEmpleadoPlanilla.Text;
                string UsuarioSistema = usuarioSistema;
                DateTime FechaSistema = DateTime.Now;


                cd_planilla.mtd_Actualizar_Planilla(CodigoPagoPlanilla,CodigoEmpleado, FechaPago, Salario, Bono, HorasExtras, MontoTotal, Estado, UsuarioSistema, FechaSistema);

                MessageBox.Show("La planilla se actualizó correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarPlanillas();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btn_eliminarPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoPlanilla = int.Parse(lbl_codigoPlanilla.Text);

                cd_planilla.mtd_Eliminar_Planilla(codigoPlanilla);
                MtdConsultarPlanillas();
                MessageBox.Show("Se eliminó la planilla Correctamente.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdLimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void MtdLimpiarCampos()
        {
            txt_codigoEmpleado.Text = "";
            dtpFechaPago.Text = "";
            lbl_salario.Text = "";
            lbl_bono.Text = "";
            lbl_HorasExtra.Text = "";
            lbl_montoTotal.Text = "";
            cbox_estadoEmpleadoPlanilla.Text = "";
        }
        private void dgvPlanillas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvPlanillas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_codigoPlanilla.Text = dgvPlanillas.SelectedCells[0].Value.ToString(); 
            txt_codigoEmpleado.Text = dgvPlanillas.SelectedCells[1].Value.ToString();
            if (DateTime.TryParse(dgvPlanillas.SelectedCells[2].Value.ToString(), out DateTime fechaPago)) //CODIGO PARA PARSEAR LA FECHA PAGO
            {
                dtpFechaPago.Value = fechaPago;
            }
            else
            {
                dtpFechaPago.Value = DateTime.Now; 
            }
            lbl_salario.Text = dgvPlanillas.SelectedCells[3].Value.ToString();
            lbl_bono.Text = dgvPlanillas.SelectedCells[4].Value.ToString();
            lbl_HorasExtra.Text = dgvPlanillas.SelectedCells[5].Value.ToString();
            lbl_montoTotal.Text = dgvPlanillas.SelectedCells[6].Value.ToString();
            cbox_estadoEmpleadoPlanilla.Text = dgvPlanillas.SelectedCells[7].Value.ToString();
        }
    }
}
