using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Empleados
    {
        public decimal mtd_SalarioEmpleado(string Cargo)

        {
            if (Cargo == "Gerente")
            {
                return 25000;
            }
            else if (Cargo == "Cocinero")
            {
                return 15000;
            }
            else if (Cargo == "Mesero")
            {
                return 6000;
            }
            else if (Cargo == "Cajero")
            {
                return 7000;
            }
            else if (Cargo == "Bodeguero")
            {
                return 7500;
            }
            else
            {
                return 0;
            }

        }
    }
}
