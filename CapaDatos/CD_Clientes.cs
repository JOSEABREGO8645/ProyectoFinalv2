using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Clientes
    {
        Conexion conexion = new Conexion();
        public DataTable mtdConsultaClientes()
        {
            string QueryConsultaClientes = "Select * from tbl_clientes";
            //squl adapter es solo para consultar datos
            SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultaClientes, conexion.MtdAbrirConexion());
            DataTable dtClientes = new DataTable();
            sqlAdap.Fill(dtClientes);
            conexion.MtdCerrarConexion();
            return dtClientes;

        }


        public void mtd_agregar_Cliente(String Nombre , String Nit , String Telefono , String Categoria , String Estado , String UsuarioSistema , DateTime FechaSistema )
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QueryAgregarCliente = "Insert into tbl_clientes (Nombre ,Nit ,Telefono ,Categoria ,Estado ,UsuarioSistema ,FechaSistema ) Values ( @Nombre ,@Nit ,@Telefono ,@Categoria ,@Estado ,@UsuarioSistema ,@FechaSistema )";
                //para modificar datos se usa:
                SqlCommand CommAgregarCliente = new SqlCommand(QueryAgregarCliente, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommAgregarCliente.Parameters.AddWithValue("@Nombre", Nombre);
                CommAgregarCliente.Parameters.AddWithValue("@Nit", Nit);
                CommAgregarCliente.Parameters.AddWithValue("@Telefono", Telefono);
                CommAgregarCliente.Parameters.AddWithValue("@Categoria", Categoria);
                CommAgregarCliente.Parameters.AddWithValue("@Estado", Estado);
                CommAgregarCliente.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommAgregarCliente.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommAgregarCliente.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void mtd_Actualizar_Cliente(int CodigoCliente, String Nombre, String Nit, String Telefono, String Categoria, String Estado, String UsuarioSistema, DateTime FechaSistema)
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QueryActualizarCliente = "Update tbl_clientes set Nombre = @Nombre ,Nit = @Nit,Telefono = @Telefono,Categoria = @Categoria,Estado = @Estado ,UsuarioSistema = @UsuarioSistema,FechaSistema = @FechaSistema where CodigoCliente=@CodigoCliente";
                //para modificar datos se usa:
                SqlCommand CommActualizarCliente = new SqlCommand(QueryActualizarCliente, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommActualizarCliente.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
                CommActualizarCliente.Parameters.AddWithValue("@Nombre", Nombre);
                CommActualizarCliente.Parameters.AddWithValue("@Nit", Nit);
                CommActualizarCliente.Parameters.AddWithValue("@Telefono", Telefono);
                CommActualizarCliente.Parameters.AddWithValue("@Categoria", Categoria);
                CommActualizarCliente.Parameters.AddWithValue("@Estado", Estado);
                CommActualizarCliente.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommActualizarCliente.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommActualizarCliente.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void mtd_Eliminar_Cliente(int CodigoCliente)
        {
            try
            {
                string QueryEliminarCliente = "Delete tbl_clientes where CodigoCliente=@CodigoCliente";

                SqlCommand CommEliinarCliente = new SqlCommand(QueryEliminarCliente, conexion.MtdAbrirConexion());

                CommEliinarCliente.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
                CommEliinarCliente.ExecuteNonQuery();
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
