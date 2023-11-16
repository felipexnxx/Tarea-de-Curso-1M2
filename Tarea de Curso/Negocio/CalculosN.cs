using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Curso.Negocio
{
    public class CalculosN
    {
        public static decimal PagoRiesgoLaboral_Nocturnidad(decimal SalarioEmpleado)
        {
            return SalarioEmpleado * (decimal)0.2;
        }

        public static decimal HorasExtras(decimal SalarioEmpleado, int CantidadHoras)
        {
            return (((SalarioEmpleado / 30) / 8) * CantidadHoras) * 2;
        }

        public static decimal Antiguedad(decimal SalarioEmpleado, int AñosTrabajados)
        {
            decimal Antiguedad = 0;
            if (AñosTrabajados == 0)
            {
                Antiguedad = 0;
            }
            else if (AñosTrabajados >= 1 && AñosTrabajados <= 5)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.05;
            }
            else if (AñosTrabajados >= 6 && AñosTrabajados <= 10)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.1;
            }
            else if (AñosTrabajados >= 11 && AñosTrabajados <= 15)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.15;
            }
            else if (AñosTrabajados >= 16 && AñosTrabajados <= 20)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.2;
            }
            else if (AñosTrabajados >= 21 && AñosTrabajados <= 25)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.25;
            }
            else if (AñosTrabajados >= 26 && AñosTrabajados <= 30)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.3;
            }
            else if (AñosTrabajados >= 31 && AñosTrabajados <= 35)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.35;
            }
            else if (AñosTrabajados >= 36 && AñosTrabajados <= 40)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.4;
            }
            else if (AñosTrabajados >= 41 && AñosTrabajados <= 45)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.45;

            }
            else if (AñosTrabajados >= 46 && AñosTrabajados <= 50)
            {
                Antiguedad = SalarioEmpleado * (decimal)0.5;
            }

            return Antiguedad;
        }

        public static decimal INSSLaboral(decimal SalarioEmpleado)
        {
            return SalarioEmpleado * (decimal)0.07;
        }

        public static decimal IR(decimal SalarioEmpleado)
        {
            decimal IR = 0, SalarioAnual = SalarioEmpleado * 12;

            if (SalarioAnual >= (decimal)0.01 && SalarioAnual <= (decimal)100000)
            {
                IR = 0;
            }
            else if (SalarioAnual >= (decimal)100000.01 && SalarioAnual <= (decimal)200000)
            {
                SalarioAnual -= 100000;
                IR = SalarioAnual * (decimal)0.15;
            }
            else if (SalarioAnual >= (decimal)200000.01 && SalarioAnual <= (decimal)350000)
            {
                SalarioAnual -= 200000;
                IR = SalarioAnual * (decimal)0.2;
                IR += 15000;
            }
            else if (SalarioAnual >= (decimal)350000.01 && SalarioAnual <= (decimal)500000)
            {
                SalarioAnual -= 350000;
                IR = SalarioAnual * (decimal)0.25;
                IR += 45000;
            }
            else if (SalarioAnual >= (decimal)500000.01)
            {
                SalarioAnual -= 500000;
                IR = SalarioAnual * (decimal)0.3;
                IR += 82500;
            }

            IR /= 12;
            return IR;
        }

        public static decimal INSSPatronal(decimal SalarioEmpleado)
        {
            return SalarioEmpleado * (decimal)0.215;
        }
    }
}