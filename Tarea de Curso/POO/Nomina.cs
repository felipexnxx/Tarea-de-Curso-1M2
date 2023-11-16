using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Curso.POO
{
    [Serializable]
    public class Nomina
    {
        public int id_nomina { get; set; }
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool activo { get; set; }
    }
}