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
    public partial class Opciones_Empleado : Form
    {
        int idEmpleado;
        public Opciones_Empleado(int id_empleado)
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditarEmpleado_Click(object sender, EventArgs e)
        {
            Agregar_Empleado Form = new Agregar_Empleado(idEmpleado);
            Form.ShowDialog(this);
            Form.Dispose();
            this.Close();
        }

        private void BtnAgregarIngreso_Click(object sender, EventArgs e)
        {
            Agregar_Ingresos_Empleado Form = new Agregar_Ingresos_Empleado(idEmpleado);
            Form.ShowDialog(this);
            Form.Dispose();
            this.Close();
        }

        private void BtnMostrarIngresos_Click(object sender, EventArgs e)
        {
            Mostrar_Ingresos_Empleado Form = new Mostrar_Ingresos_Empleado(idEmpleado);
            Form.ShowDialog(this);
            Form.Dispose();
            this.Close();
        }

        private void Opciones_Empleado_Load(object sender, EventArgs e)
        {
            if (EmpleadoN.CargarEmpleados().Where(x => x.id_empleado == idEmpleado).FirstOrDefault().activo == false)
            {
                BtnAgregarIngreso.Enabled = false;
                BtnMostrarIngresos.Enabled = false;
            }
        }
    }
}