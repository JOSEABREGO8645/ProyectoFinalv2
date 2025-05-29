using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Empleados
    {
        Conexion conexion = new Conexion();
        public DataTable mtdConsultaEmpleados()
        {
            string QueryConsultaEmpleados = "SELECT * FROM tbl_Empleados";
            //squl adapter es solo para consultar datos
            SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultaEmpleados, conexion.MtdAbrirConexion());
            DataTable dtEmpleados = new DataTable();
            sqlAdap.Fill(dtEmpleados);
            conexion.MtdCerrarConexion();
            return dtEmpleados;
        }

        public void mtd_agregar_Empleados(String Nombre, String Cargo, float Salario, DateTime FechaContratacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QueryAgregarEmpleado = "Insert into tbl_Empleados (Nombre,Cargo,Salario,FechaContratacion,Estado,UsuarioSistema,FechaSistema) Values (@Nombre,@Cargo,@Salario,@FechaContratacion,@Estado,@UsuarioSistema,@FechaSistema)";
                //para modificar datos se usa:
                SqlCommand CommAgregarEmpleado = new SqlCommand(QueryAgregarEmpleado, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommAgregarEmpleado.Parameters.AddWithValue("@Nombre", Nombre);
                CommAgregarEmpleado.Parameters.AddWithValue("@Cargo", Cargo);
                CommAgregarEmpleado.Parameters.AddWithValue("@Salario", Salario);
                CommAgregarEmpleado.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
                CommAgregarEmpleado.Parameters.AddWithValue("@Estado", Estado);
                CommAgregarEmpleado.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommAgregarEmpleado.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommAgregarEmpleado.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void mtd_editar_Empleados(int CodigoEmpleado, String Nombre, String Cargo, float Salario, DateTime FechaContratacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QuerEditarEmpleado = "Update tbl_Empleados SET Nombre = @Nombre,Cargo = @Cargo,Salario = @Salario,FechaContratacion = @FechaContratacion,Estado = @Estado,UsuarioSistema = @UsuarioSistema,FechaSistema =  @FechaSistema where CodigoEmpleado=@CodigoEmpleado";
                //para modificar datos se usa:
                SqlCommand CommEditarEmpleado = new SqlCommand(QuerEditarEmpleado, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommEditarEmpleado.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
                CommEditarEmpleado.Parameters.AddWithValue("@Nombre", Nombre);
                CommEditarEmpleado.Parameters.AddWithValue("@Cargo", Cargo);
                CommEditarEmpleado.Parameters.AddWithValue("@Salario", Salario);
                CommEditarEmpleado.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
                CommEditarEmpleado.Parameters.AddWithValue("@Estado", Estado);
                CommEditarEmpleado.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommEditarEmpleado.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommEditarEmpleado.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void mtd_EliminarEmpleado(int CodigoEmpleado)
        {
            try
            {
                string QueryEliminarEmpleado = "Delete tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";

                SqlCommand CommEliinarEmpleado = new SqlCommand(QueryEliminarEmpleado, conexion.MtdAbrirConexion());

                CommEliinarEmpleado.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
                CommEliinarEmpleado.ExecuteNonQuery();
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable mtdConsultaEmpleadosPorCoigo(string CodigoEmpleado)
        {
            string QueryConsultaEmpleadosPorCodigo = "SELECT * FROM tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand command = new SqlCommand(QueryConsultaEmpleadosPorCodigo, conexion.MtdAbrirConexion());
            command.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            SqlDataAdapter sqlAdap = new SqlDataAdapter(command);
            DataTable dtEmpleados = new DataTable();

            sqlAdap.Fill(dtEmpleados);
            
            conexion.MtdCerrarConexion();
            return dtEmpleados ;


        }

        
    }
}
