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
    public class NominaN
    {
        public static string CarpetaProyecto = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))).Replace("\\", "/");
        static string rutaArchivo = $"{CarpetaProyecto}/Nominas.dat";
        static string rutaArchivoDetalles = $"{CarpetaProyecto}/Detalles_Nominas.dat";


        public static List<Detalles_Nomina> CrearNomina()
        {
            try
            {
                List<Nomina> Nominas = NominaN.CargarNominas();
                List<Detalles_Nomina> Detalles_Nomina = new List<Detalles_Nomina>();
                List<Empleado> Empleados_Activos = EmpleadoN.CargarEmpleados().Where(x => x.activo == true).ToList();
                List<Ingreso> Ingresos_Mes = EmpleadoN.CargarIngresosEmpleados().Where(x => x.fecha.Year == DateTime.Now.Year && x.fecha.Month == DateTime.Now.Month).ToList();

                decimal Salario_Basico = 0;
                decimal Antiguedad = 0;
                int AñosTrabajados = 0;
                decimal Pago_Riesgo_Laboral = 0;
                decimal Pago_Nocturnidad = 0;
                decimal Horas_Extras = 0;
                decimal Salario_Extraordinario = 0;
                decimal Salario_Bruto = 0;
                decimal INSS_Laboral = 0;
                decimal IR = 0;
                decimal Salario_Neto = 0;
                decimal INSS_Patronal = 0;

                foreach (var Empleado in Empleados_Activos)
                {
                    Salario_Basico = Convert.ToDecimal(Empleado.salario_ordinario.ToString("N2"));

                    AñosTrabajados = DateTime.Now.Year - Empleado.fecha_contratacion.Year;
                    if (Empleado.fecha_contratacion > DateTime.Now.AddYears(-AñosTrabajados))
                    {
                        AñosTrabajados--;
                    }

                    Antiguedad = Convert.ToDecimal(CalculosN.Antiguedad(Salario_Basico, AñosTrabajados).ToString("N2"));

                    int PagosRiesgoTotales = Convert.ToInt32(Ingresos_Mes.Where(x => x.id_empleado == Empleado.id_empleado && x.tipo_ingreso == "PAGO POR RIESGO LABORAL").Sum(x => x.cantidad));
                    Pago_Riesgo_Laboral = Convert.ToDecimal((CalculosN.PagoRiesgoLaboral_Nocturnidad(Salario_Basico) * PagosRiesgoTotales).ToString("N2"));

                    int PagosNocturnidadTotales = Convert.ToInt32(Ingresos_Mes.Where(x => x.id_empleado == Empleado.id_empleado && x.tipo_ingreso == "PAGO POR NOCTURNIDAD").Sum(x => x.cantidad));
                    Pago_Nocturnidad = Convert.ToDecimal((CalculosN.PagoRiesgoLaboral_Nocturnidad(Salario_Basico) * PagosNocturnidadTotales).ToString("N2"));

                    int HorasExtrasTotales = Convert.ToInt32(Ingresos_Mes.Where(x => x.id_empleado == Empleado.id_empleado && x.tipo_ingreso == "HORAS EXTRAS").Sum(x => x.cantidad));
                    Horas_Extras = Convert.ToDecimal(CalculosN.HorasExtras(Salario_Basico, HorasExtrasTotales).ToString("N2"));

                    Salario_Extraordinario = Antiguedad + Pago_Riesgo_Laboral + Pago_Nocturnidad + Horas_Extras;

                    Salario_Bruto = Salario_Basico + Salario_Extraordinario;

                    INSS_Laboral = Convert.ToDecimal(CalculosN.INSSLaboral(Salario_Bruto).ToString("N2"));

                    IR = Convert.ToDecimal(CalculosN.IR(Salario_Bruto - INSS_Laboral).ToString("N2"));

                    Salario_Neto = Salario_Bruto - INSS_Laboral - IR;

                    INSS_Patronal = Convert.ToDecimal(CalculosN.INSSPatronal(Salario_Bruto).ToString("N2"));

                    Detalles_Nomina.Add(new Detalles_Nomina
                    {
                        id_nomina = (Nominas.Count + 1),
                        id_empleado = Empleado.id_empleado,
                        nombre_empleado = $"{Empleado.apellidos}, {Empleado.nombre}",
                        salario_ordinario = Salario_Basico,
                        antiguedad = Antiguedad,
                        pago_riesgo_laboral = Pago_Riesgo_Laboral,
                        pago_nocturnidad = Pago_Nocturnidad,
                        horas_extras = Horas_Extras,
                        salario_extraordinario = Salario_Extraordinario,
                        salario_bruto = Salario_Bruto,
                        INSS_laboral = INSS_Laboral,
                        IR = IR,
                        salario_neto = Salario_Neto,
                        INSS_patronal = INSS_Patronal
                    });
                }
                return Detalles_Nomina;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al crear nómina y detalle de nómina: " + ex.Message);
            }
        }

        public static bool GuardarNomina(List<Nomina> Nominas, List<Detalles_Nomina> Detalles_Nominas)
        {
            try
            {
                using (FileStream stream = new FileStream(rutaArchivo, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, Nominas);
                }

                using (FileStream stream = new FileStream(rutaArchivoDetalles, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, Detalles_Nominas);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al guardar nómina y detalle de nómina en el archivo: " + ex.Message);
            }
        }

        public static List<Nomina> CargarNominas()
        {
            List<Nomina> objetos = new List<Nomina>();

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
                    objetos = (List<Nomina>)formatter.Deserialize(stream);
                }

                return objetos;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al cargar nóminas desde el archivo: " + ex.Message);
            }
        }

        public static List<Detalles_Nomina> CargarDetallesNominas()
        {
            List<Detalles_Nomina> objetos = new List<Detalles_Nomina>();

            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("El archivo no existe.");
                return objetos;
            }

            try
            {
                using (FileStream stream = new FileStream(rutaArchivoDetalles, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    objetos = (List<Detalles_Nomina>)formatter.Deserialize(stream);
                }

                return objetos;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al cargar detalles de nóminas desde el archivo: " + ex.Message);
            }
        }

        public static bool Desactivar_Nomina(int id_nomina)
        {
            try
            {
                List<Nomina> Nominas = NominaN.CargarNominas();
                Nomina N = Nominas.Where(x => x.id_nomina == id_nomina).FirstOrDefault();

                if (N != null)
                {
                    N.activo = false;
                }

                using (FileStream stream = new FileStream(rutaArchivo, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, Nominas);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}