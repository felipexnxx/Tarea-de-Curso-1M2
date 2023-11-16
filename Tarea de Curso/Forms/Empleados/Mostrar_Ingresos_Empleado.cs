using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_de_Curso.Negocio;
using Tarea_de_Curso.POO;

namespace Tarea_de_Curso.Forms.Empleados
{
    public partial class Mostrar_Ingresos_Empleado : Form
    {
        int idEmpleado = 0;
        public Mostrar_Ingresos_Empleado(int id_empleado)
        {
            InitializeComponent();
            idEmpleado = id_empleado;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Mostrar_Ingresos_Empleado_Load(object sender, EventArgs e)
        {
            Empleado E = EmpleadoN.CargarEmpleados().Where(x => x.id_empleado == idEmpleado).FirstOrDefault(); 

            DataTable ingresos = new DataTable();
            ingresos.Columns.Add("tipo_ingreso", typeof(string));
            ingresos.Columns.Add("cantidad", typeof(int));
            ingresos.Columns.Add("valor_monetario", typeof(decimal));
            ingresos.Columns.Add("fecha", typeof(DateTime));

            foreach (var n in EmpleadoN.CargarIngresosEmpleados().Where(x => x.id_empleado == idEmpleado))
            {
                if (n.tipo_ingreso == "PAGO POR RIESGO LABORAL" || n.tipo_ingreso == "PAGO POR NOCTURNIDAD")
                {
                    ingresos.Rows.Add(n.tipo_ingreso, n.cantidad, Convert.ToDecimal(CalculosN.PagoRiesgoLaboral_Nocturnidad(E.salario_ordinario).ToString("N2")), n.fecha);
                }
                else if (n.tipo_ingreso == "HORAS EXTRAS")
                {
                    ingresos.Rows.Add(n.tipo_ingreso, n.cantidad, Convert.ToDecimal(CalculosN.HorasExtras(E.salario_ordinario, n.cantidad).ToString("N2")), n.fecha);
                }
            }

            bindingSourceIngresos.DataSource = ingresos;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
