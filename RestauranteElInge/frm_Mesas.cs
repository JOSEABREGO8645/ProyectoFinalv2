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
    public partial class frm_Mesas : Form
    {
        CD_Mesas cd_mesas = new CD_Mesas();
        public frm_Mesas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Fecha_Click(object sender, EventArgs e)
        {
            
        }

        public void MtdConsultarMesas()
        {

            DataTable dtMesas = cd_mesas.mtdConsultaMesas();
            dgvMesas.DataSource = dtMesas;
        }
        private void frm_Mesas_Load(object sender, EventArgs e)
        {
            MtdConsultarMesas();
            dgvMesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void MtdLimpiarCampos()
        {
            txtCodigoMesa.Text = "";
            txt_NumeroMesa.Text = "";
            cbox_cantidadSillas.Text = "";
            cboxUbicación.Text = "";
            cbox_TipoMesa.Text = "";
            txt_UsuarioSistema.Text = "";
            cbox_Estado.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int NumeroMesa = int.Parse(txt_NumeroMesa.Text);
                int CantidadSillas = int.Parse(cbox_cantidadSillas.Text);
                string Ubicacion = cboxUbicación.Text;
                string TipoMesa = cbox_TipoMesa.Text;
                string Estado = cbox_Estado.Text;
                string UsuarioSistema = txt_UsuarioSistema.Text;
                DateTime FechaSistema = DateTime.Now;

                cd_mesas.mtd_agregar_Mesas(NumeroMesa, CantidadSillas, Ubicacion, TipoMesa, Estado, UsuarioSistema, FechaSistema);

                MessageBox.Show("La mesa se agregó correctamente", "Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarMesas();              
                MtdLimpiarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoMesa = int.Parse(txtCodigoMesa.Text);
                int NumeroMesa = int.Parse(txt_NumeroMesa.Text);
                int CantidadSillas = int.Parse(cbox_cantidadSillas.Text);
                string Ubicacion = cboxUbicación.Text;
                string TipoMesa = cbox_TipoMesa.Text;
                string Estado = cbox_Estado.Text;
                string UsuarioSistema = txt_UsuarioSistema.Text;
                DateTime FechaSistema = DateTime.Now;

                cd_mesas.mtd_Actualizar_Mesas(CodigoMesa,NumeroMesa, CantidadSillas, Ubicacion, TipoMesa, Estado, UsuarioSistema, FechaSistema);
                MessageBox.Show("La mesa se actualizó correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarMesas();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void dgvMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMesas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoMesa.Text = dgvMesas.SelectedCells[0].Value.ToString();
            txt_NumeroMesa.Text = dgvMesas.SelectedCells[1].Value.ToString();
            cbox_cantidadSillas.Text = dgvMesas.SelectedCells[2].Value.ToString();
            cboxUbicación.Text = dgvMesas.SelectedCells[3].Value.ToString();
            cbox_TipoMesa.Text = dgvMesas.SelectedCells[4].Value.ToString();
            cbox_Estado.Text = dgvMesas.SelectedCells[5].Value.ToString();
            txt_UsuarioSistema.Text = dgvMesas.SelectedCells[6].Value.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoMesa = int.Parse(txtCodigoMesa.Text);

                cd_mesas.mtd_Eliminar_Mesas(CodigoMesa);
                MtdConsultarMesas();
                MessageBox.Show("Se eliminó la mesa Correctamente.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdLimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
    }

