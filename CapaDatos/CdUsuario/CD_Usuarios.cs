using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

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
        public void mtd_agregar_usuario(int CodigoEmpleado, string NombreUsuario, string Contrasenia, string rol, string Estado, string UsuarioSistema, DateTime FechaSistema)
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
                CommAgregarUsuarios.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
                CommAgregarUsuarios.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                CommAgregarUsuarios.Parameters.AddWithValue("@Contrasenia", Contrasenia);
                CommAgregarUsuarios.Parameters.AddWithValue("@Rol", rol);
                CommAgregarUsuarios.Parameters.AddWithValue("@Estado", Estado);
                CommAgregarUsuarios.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommAgregarUsuarios.Parameters.AddWithValue("@FechaSistema", FechaSistema);
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

        public void mtd_Actualizar_Usuario(int CodigoUsuario, int CodigoEmpleado, string NombreUsuario, string Contrasenia, string rol, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QueryActualizarUsuario = "Update tbl_Usuarios set CodigoEmpleado = @CodigoEmpleado,NombreUsuario = @NombreUsuario,Contrasenia = @Contrasenia,Rol = @Rol,Estado = @Estado,UsuarioSistema = @UsuarioSistema, FechaSistema = @FechaSistema where CodigoUsuario=@CodigoUsuario";
                //para modificar datos se usa:
                SqlCommand CommActualizarUsuario = new SqlCommand(QueryActualizarUsuario, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommActualizarUsuario.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
                CommActualizarUsuario.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
                CommActualizarUsuario.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                CommActualizarUsuario.Parameters.AddWithValue("@Contrasenia", Contrasenia);
                CommActualizarUsuario.Parameters.AddWithValue("@Rol", rol);
                CommActualizarUsuario.Parameters.AddWithValue("@Estado", Estado);
                CommActualizarUsuario.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommActualizarUsuario.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommActualizarUsuario.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void mtd_Eliminar_Usuario(int CodigoUsuario)
        {
            try
            {
                string QueryEliminarUsuario = "Delete tbl_Usuarios where CodigoUsuario=@CodigoUsuario";

                SqlCommand CommEliinarUsuario = new SqlCommand(QueryEliminarUsuario, conexion.MtdAbrirConexion());

                CommEliinarUsuario.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
                CommEliinarUsuario.ExecuteNonQuery();
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }
      
    }
}
