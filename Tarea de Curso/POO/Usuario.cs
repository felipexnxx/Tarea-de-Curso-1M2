﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Curso.POO
{
    [Serializable]
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
    }
}