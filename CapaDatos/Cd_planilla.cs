using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Cd_planilla
    {
        Conexion conexion = new Conexion();
        public DataTable mtdConsultaPlanilla()
        {
            string QueryConsultaPlanilla = "SELECT * FROM tbl_PlanPlanillas";
            //squl adapter es solo para consultar datos
            SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultaPlanilla, conexion.MtdAbrirConexion());
            DataTable dtPlanillas = new DataTable();
            sqlAdap.Fill(dtPlanillas);
            conexion.MtdCerrarConexion();
            return dtPlanillas;
        }

        public void mtd_agregar_Planilla(int CodigoEmpleado, DateTime FechaPago, decimal Salario, decimal Bono, decimal HorasExtras, decimal MontoTotal,string Estado,string UsuarioSistema,DateTime FechaSistema)
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QueryAgregarPlanilla = "insert into tbl_PlanPlanillas (CodigoEmpleado,FechaPago,Salario,Bono,HorasExtras,MontoTotal,Estado,UsuarioSistema,FechaSistema) Values ( @CodigoEmpleado,@FechaPago,@Salario,@Bono,@HorasExtras,@MontoTotal,@Estado, @UsuarioSistema,@FechaSistema)";
                //para modificar datos se usa:
                SqlCommand CommAgregarPlanilla = new SqlCommand(QueryAgregarPlanilla, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommAgregarPlanilla.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
                CommAgregarPlanilla.Parameters.AddWithValue("@FechaPago", FechaPago);
                CommAgregarPlanilla.Parameters.AddWithValue("@Salario", Salario);
                CommAgregarPlanilla.Parameters.AddWithValue("@Bono", Bono);
                CommAgregarPlanilla.Parameters.AddWithValue("@HorasExtras", HorasExtras);
                CommAgregarPlanilla.Parameters.AddWithValue("@MontoTotal", MontoTotal);
                CommAgregarPlanilla.Parameters.AddWithValue("@Estado", Estado);
                CommAgregarPlanilla.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommAgregarPlanilla.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommAgregarPlanilla.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void mtd_Actualizar_Planilla(int CodigoPagoPlanilla, int CodigoEmpleado, DateTime FechaPago, decimal Salario, decimal Bono, decimal HorasExtras, decimal MontoTotal, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QueryActualizarPlanilla = "Update tbl_PlanPlanillas set CodigoEmpleado = @CodigoEmpleado,FechaPago = @FechaPago,Salario = @Salario,Bono = @Bono,HorasExtras = @HorasExtras ,MontoTotal = @MontoTotal,Estado = @Estado,UsuarioSistema = @UsuarioSistema,FechaSistema = @FechaSistema where CodigoPagoPlanilla=@CodigoPagoPlanilla";
                //para modificar datos se usa:
                SqlCommand CommActualizarPlanilla = new SqlCommand(QueryActualizarPlanilla, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommActualizarPlanilla.Parameters.AddWithValue("@CodigoPagoPlanilla", CodigoPagoPlanilla);  
                CommActualizarPlanilla.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
                CommActualizarPlanilla.Parameters.AddWithValue("@FechaPago", FechaPago);
                CommActualizarPlanilla.Parameters.AddWithValue("@Salario", Salario);
                CommActualizarPlanilla.Parameters.AddWithValue("@Bono", Bono);
                CommActualizarPlanilla.Parameters.AddWithValue("@HorasExtras", HorasExtras);
                CommActualizarPlanilla.Parameters.AddWithValue("@MontoTotal", MontoTotal);
                CommActualizarPlanilla.Parameters.AddWithValue("@Estado", Estado);
                CommActualizarPlanilla.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommActualizarPlanilla.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommActualizarPlanilla.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void mtd_Eliminar_Planilla(int CodigoPagoPlanilla)
        {
            try
            {
                string QueryEliminarPlanilla = "Delete tbl_PlanPlanillas where CodigoPagoPlanilla=@CodigoPagoPlanilla";

                SqlCommand CommEliminarPlanilla = new SqlCommand(QueryEliminarPlanilla, conexion.MtdAbrirConexion());

                CommEliminarPlanilla.Parameters.AddWithValue("@CodigoPagoPlanilla", CodigoPagoPlanilla);
                CommEliminarPlanilla.ExecuteNonQuery();
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
