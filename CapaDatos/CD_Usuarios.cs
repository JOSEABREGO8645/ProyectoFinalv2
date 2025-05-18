using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        Conexion conexion = new Conexion();
        public DataTable mtdConsultaUsuarios()
        {
            string QueryConsultaClientes = "Select * from tbl_Usuarios";
            //squl adapter es solo para consultar datos
            SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultaClientes, conexion.MtdAbrirConexion());
            DataTable dtClientes = new DataTable();
            sqlAdap.Fill(dtClientes);

            return dtClientes;
            conexion.MtdCerrarConexion();
        }

        
        //pendiente
        public void mtd_agregar_usuario(string Nombre, string Contrasenia, string rol, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QueryAgregarUsuarios = "insert into tbl_Usuarios (CodigoEmpleado,NombreUsuario,Contrasenia,Rol,Estado,UsuarioSistema, FechaSistema) values (@CodigoEmpleado,@NombreUsuario,@Contrasenia,@Rol,@Estado,@UsuarioSistema,@FechaSistema)";
                //para modificar datos se usa:
                SqlCommand CommAgregarUsuarios = new SqlCommand(QueryAgregarUsuarios, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommAgregarUsuarios.Parameters.AddWithValue("@Nombre", Nombre);
                CommAgregarUsuarios.Parameters.AddWithValue("@Contrasenia", Contrasenia);
                CommAgregarUsuarios.Parameters.AddWithValue("@rol", rol);
                CommAgregarUsuarios.Parameters.AddWithValue("@Estado", Estado);
                CommAgregarUsuarios.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommAgregarUsuarios.Parameters.AddWithValue("@FechaAuditoria", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommAgregarUsuarios.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
