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
        CD_Usuarios cd_usuarios = new CD_Usuarios();
        public frmUsuarios()
        {
            InitializeComponent();
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
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MtdConsultarUsuarios();
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void lbl_Fecha_Click(object sender, EventArgs e)
        {

        }

        private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
