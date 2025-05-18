using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Mesas
    {
        Conexion conexion = new Conexion();
        public DataTable mtdConsultaMesas()
        {
            string QueryConsultaMesas = "Select * from tbl_Mesas";
            //squl adapter es solo para consultar datos
            SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultaMesas, conexion.MtdAbrirConexion());
            DataTable dtMesas = new DataTable();
            sqlAdap.Fill(dtMesas);
            conexion.MtdCerrarConexion();
            return dtMesas;
            
        }

        public void mtd_agregar_Mesas(int NumeroMesa, int CantidadSillas, string Ubicacion, string TipoMesa, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QueryAgregarMesas = "Insert into tbl_Mesas (NumeroMesa ,CantidadSillas ,Ubicacion ,TipoMesa,Estado,UsuarioSistema,FechaSistema) Values (@NumeroMesa ,@CantidadSillas ,@Ubicacion ,@TipoMesa,@Estado,@UsuarioSistema,@FechaSistema)";
                //para modificar datos se usa:
                SqlCommand CommAgregarMesas = new SqlCommand(QueryAgregarMesas, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommAgregarMesas.Parameters.AddWithValue("@NumeroMesa", NumeroMesa);
                CommAgregarMesas.Parameters.AddWithValue("@CantidadSillas", CantidadSillas);
                CommAgregarMesas.Parameters.AddWithValue("@Ubicacion", Ubicacion);
                CommAgregarMesas.Parameters.AddWithValue("@TipoMesa", TipoMesa);
                CommAgregarMesas.Parameters.AddWithValue("@Estado", Estado);
                CommAgregarMesas.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommAgregarMesas.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommAgregarMesas.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void mtd_Actualizar_Mesas(int CodigoMesa, int NumeroMesa, int CantidadSillas, string Ubicacion, string TipoMesa, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            try
            {
                //primero se instancia pero ya está arriba
                //luego creamos un query
                string QueryActualizarMesas = "Update tbl_Mesas set NumeroMesa = @NumeroMesa, CantidadSillas = @CantidadSillas,Ubicacion = @Ubicacion,TipoMesa = @TipoMesa,Estado = @Estado,UsuarioSistema = @UsuarioSistema,FechaSistema = @FechaSistema where CodigoMesa=@CodigoMesa";
                //para modificar datos se usa:
                SqlCommand CommActualizarMesas = new SqlCommand(QueryActualizarMesas, conexion.MtdAbrirConexion());
                //por esta calle enviar los parametros
                //@Nombre es la cjita en donde se guarda Nombre y Nombre es el tipo de dato es la que viene llea que va entre los parentesis de arriba
                CommActualizarMesas.Parameters.AddWithValue("@CodigoMesa", CodigoMesa);
                CommActualizarMesas.Parameters.AddWithValue("@NumeroMesa", NumeroMesa);
                CommActualizarMesas.Parameters.AddWithValue("@CantidadSillas", CantidadSillas);
                CommActualizarMesas.Parameters.AddWithValue("@Ubicacion", Ubicacion);
                CommActualizarMesas.Parameters.AddWithValue("@TipoMesa", TipoMesa);
                CommActualizarMesas.Parameters.AddWithValue("@Estado", Estado);
                CommActualizarMesas.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
                CommActualizarMesas.Parameters.AddWithValue("@FechaSistema", FechaSistema);
                //con esta instrucción se le dice que aqui quedaron los datos y que ya no necesita mas
                CommActualizarMesas.ExecuteNonQuery();
                //luego se cierra la conexipon
                conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void mtd_Eliminar_Mesas(int CodigoMesa)
        {
            try
            {
                string QueryEliminarMesa = "Delete tbl_Mesas where CodigoMesa=@CodigoMesa";

            SqlCommand CommEliinarMesa = new SqlCommand(QueryEliminarMesa, conexion.MtdAbrirConexion());

            CommEliinarMesa.Parameters.AddWithValue("@CodigoMesa", CodigoMesa);
            CommEliinarMesa.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
