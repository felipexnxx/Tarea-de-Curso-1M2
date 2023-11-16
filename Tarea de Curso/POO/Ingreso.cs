using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Curso.POO
{
    [Serializable]
    public class Ingreso
    {
        public int id_ingreso { get; set; }
        public int id_empleado { get; set; }
        public string tipo_ingreso { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
    }
}