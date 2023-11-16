using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Curso.POO
{
    [Serializable]
    public class Empleado
    {
        public int id_empleado { get; set; }
        public string num_cedula { get; set; }
        public string num_INSS { get; set; }
        public string num_RUC { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public DateTime fecha_contratacion { get; set; }
        public decimal salario_ordinario { get; set; }
        public bool activo { get; set; }
    }
}