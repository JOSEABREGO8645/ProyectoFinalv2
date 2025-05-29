using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class CL_Planilla
    {
        CD_Empleados cd_empleados = new CD_Empleados();


        public decimal mtdSalarioEnPlanilla(string codigoEmpleado)
        {
            // Lógica para obtener el salario del empleado en planilla

            // Consulta los empleados por código
            DataTable dtEmpleados = cd_empleados.mtdConsultaEmpleadosPorCoigo(codigoEmpleado);
            // Verifica si se encontró el empleado
            if (dtEmpleados.Rows.Count > 0)
            {
                return Convert.ToDecimal(dtEmpleados.Rows[0]["Salario"]);
            }
            return 0;
        }

        public decimal mtdSalarioBono(decimal salario)
        {
            return salario * 0.10m;
        }

        public decimal mtdSalarioTotal(decimal salario, decimal bono)
        {
            return salario + bono;
        }

        public decimal mtdSalarioTotal(decimal salario, decimal bono, decimal horasExtras)
        {
            return salario + bono + (horasExtras * 15);
        }

    }
}
