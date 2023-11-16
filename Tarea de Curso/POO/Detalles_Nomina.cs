using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Curso.POO
{
    [Serializable]
    public class Detalles_Nomina
    {
        public int id_nomina { get; set; }
        public int id_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public decimal salario_ordinario { get; set; }
        public decimal antiguedad { get; set; }
        public decimal pago_riesgo_laboral { get; set; }
        public decimal pago_nocturnidad { get; set; }
        public decimal horas_extras { get; set; }
        public decimal salario_extraordinario { get; set; }
        public decimal salario_bruto { get; set; }
        public decimal INSS_laboral { get; set; }
        public decimal IR { get; set; }
        public decimal salario_neto { get; set; }
        public decimal INSS_patronal { get; set; }
    }
}