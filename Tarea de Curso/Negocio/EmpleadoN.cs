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
    public class EmpleadoN
    {
        public static string CarpetaProyecto = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))).Replace("\\", "/");
        static string rutaArchivo = $"{CarpetaProyecto}/Empleado.dat";
        static string rutaArchivoIngresos = $"{CarpetaProyecto}/Ingreso.dat";

        public static bool GuardarEmpleado(List<Empleado> Empleados)
        {
            try
            {
                using (FileStream stream = new FileStream(rutaArchivo, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, Empleados);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al guardar empleados en el archivo: " + ex.Message);
            }
        }

        public static List<Empleado> CargarEmpleados()
        {
            List<Empleado> objetos = new List<Empleado>();

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
                    objetos = (List<Empleado>)formatter.Deserialize(stream);
                }

                return objetos;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al cargar empleados desde el archivo: " + ex.Message);
            }
        }

        public static bool GuardarIngresoEmpleado(List<Ingreso> Ingresos)
        {
            try
            {
                using (FileStream stream = new FileStream(rutaArchivoIngresos, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, Ingresos);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al guardar ingresos en el archivo: " + ex.Message);
            }
        }

        public static List<Ingreso> CargarIngresosEmpleados()
        {
            List<Ingreso> objetos = new List<Ingreso>();

            if (!File.Exists(rutaArchivoIngresos))
            {
                Console.WriteLine("El archivo no existe.");
                return objetos;
            }

            try
            {
                using (FileStream stream = new FileStream(rutaArchivoIngresos, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    objetos = (List<Ingreso>)formatter.Deserialize(stream);
                }

                return objetos;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al cargar ingresos desde el archivo: " + ex.Message);
            }
        }
    }
}