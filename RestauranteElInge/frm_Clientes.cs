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

namespace RestauranteElInge
{
    public partial class frm_Clientes : Form
    {
        CD_Clientes cd_clientes = new CD_Clientes();
        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Fecha_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            MtdConsultarClientes();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void MtdConsultarClientes()
        {

            DataTable dtClientes = cd_clientes.mtdConsultaClientes();
            dgvClientes.DataSource = dtClientes;
        }
        public void MtdLimpiarCampos()
        {
            txt_NombreCliente.Text = "";
            txt_nitCliente.Text = "";
            txt_TelefonoCliente.Text = "";
            cbox_categoriaCliente.Text = "";
            cbox_estadoCliente.Text = "";
            txt_UsuarioCliente.Text = "";
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            try
            {
                string Nombre = txt_NombreCliente.Text;
                string Nit = txt_nitCliente.Text;
                string Telefono = txt_TelefonoCliente.Text;
                string Categoria = cbox_categoriaCliente.Text;
                string Estado = cbox_estadoCliente.Text;
                string UsuarioSistema = txt_UsuarioCliente.Text;
                DateTime FechaSistema = DateTime.Now;

                cd_clientes.mtd_agregar_Cliente(Nombre,  Nit,  Telefono,  Categoria,  Estado,  UsuarioSistema,  FechaSistema);

                MessageBox.Show("La mesa se agregó correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarClientes();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoCliente = int.Parse(txtCodigoCliente.Text);
                string Nombre = txt_NombreCliente.Text;
                string Nit = txt_nitCliente.Text;
                string Telefono = txt_TelefonoCliente.Text;
                string Categoria = cbox_categoriaCliente.Text;
                string Estado = cbox_estadoCliente.Text;
                string UsuarioSistema = txt_UsuarioCliente.Text;
                DateTime FechaSistema = DateTime.Now;

                cd_clientes.mtd_Actualizar_Cliente(CodigoCliente,Nombre, Nit, Telefono, Categoria, Estado, UsuarioSistema, FechaSistema);

                MessageBox.Show("El cliente se actualizó correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdConsultarClientes();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoCliente.Text = dgvClientes.SelectedCells[0].Value.ToString();
            txt_NombreCliente.Text = dgvClientes.SelectedCells[1].Value.ToString();
            txt_nitCliente.Text = dgvClientes.SelectedCells[2].Value.ToString();
            txt_TelefonoCliente.Text = dgvClientes.SelectedCells[3].Value.ToString();
            cbox_categoriaCliente.Text = dgvClientes.SelectedCells[4].Value.ToString();
            cbox_estadoCliente.Text = dgvClientes.SelectedCells[5].Value.ToString();
            txt_UsuarioCliente.Text = dgvClientes.SelectedCells[6].Value.ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoCliente = int.Parse(txtCodigoCliente.Text);

                cd_clientes.mtd_Eliminar_Cliente(CodigoCliente);
                MtdConsultarClientes();
                MessageBox.Show("Se eliminó el cliente Correctamente.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdLimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }
    }
}
