using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Tarea_de_Curso.POO;

namespace Tarea_de_Curso.Negocio
{
    public class UsuarioN
    {
        public static string CarpetaProyecto = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))).Replace("\\", "/");
        static string rutaArchivo = $"{CarpetaProyecto}/Usuario.dat";
        public static bool GuardarUsuario(List<Usuario> Usuarios)
        {
            try
            {
                using (FileStream stream = new FileStream(rutaArchivo, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, Usuarios);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al guardar usuarios en el archivo: " + ex.Message);
            }
        }

        public static List<Usuario> CargarUsuarios()
        {
            List<Usuario> objetos = new List<Usuario>();

            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("El archivo no existe.");
                return objetos;
            }

            try
            {
                using (FileStream stream = new FileStream(rutaArchivo, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    objetos = (List<Usuario>)formatter.Deserialize(stream);
                }

                return objetos;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al cargar usuarios desde el archivo: " + ex.Message);
            }
        }
    }
}