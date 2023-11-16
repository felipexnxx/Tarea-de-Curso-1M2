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
    public partial class Agregar_Ingresos_Empleado : Form
    {
        int idEmpleado = 0;
        Empleado E = new Empleado();
        decimal SalarioEmpleado = 0.00M;
        public Agregar_Ingresos_Empleado(int id_empleado)
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
        private void Agregar_Ingresos_Empleado_Load(object sender, EventArgs e)
        {
            E = EmpleadoN.CargarEmpleados().Where(x => x.id_empleado == idEmpleado).FirstOrDefault();
            TextEmpleado.Text = $"{E.apellidos}, {E.nombre}";
            SalarioEmpleado = E.salario_ordinario;
            ComboTipoIngreso.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int TipoIngreso = ComboTipoIngreso.SelectedIndex, Cantidad = 0;
            string DescripcionIngreso = ComboTipoIngreso.Text.ToString();
            if (TipoIngreso == 0 || TipoIngreso == 1)
            {
                Cantidad = 1;
            }
            else if (TipoIngreso == 2)
            {
                Cantidad = Convert.ToInt32(TextCantidad.Text);
            }

            List<Ingreso> Ingresos = EmpleadoN.CargarIngresosEmpleados();

            Ingresos.Add(new Ingreso 
            { 
                id_empleado = idEmpleado,
                tipo_ingreso = DescripcionIngreso,
                cantidad = Cantidad,
                fecha = Convert.ToDateTime(DateTime.Now.ToString("d"))
            });

            bool OK = EmpleadoN.GuardarIngresoEmpleado(Ingresos);

            if (OK)
            {
                MessageBox.Show("El ingreso se guardó exitosamente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se guardó el ingreso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboTipoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TipoIngreso = ComboTipoIngreso.SelectedIndex;
            if (TipoIngreso == 0 || TipoIngreso == 1)
            {
                TextCantidad.Clear();
                TextCantidad.Enabled = false;
                TextDinero.Text = CalculosN.PagoRiesgoLaboral_Nocturnidad(SalarioEmpleado).ToString("N2");
            }
            else if (TipoIngreso == 2)
            {
                TextCantidad.Clear();
                TextCantidad.Enabled = true;
                TextCantidad.Focus();
                TextDinero.Clear();
            }
        }

        private void TextCantidad_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextCantidad.Text, out int Cantidad) || String.IsNullOrEmpty(TextCantidad.Text))
            {
                if (String.IsNullOrEmpty(TextCantidad.Text))
                {
                    TextDinero.Clear();
                    return;
                }
                TextDinero.Text = CalculosN.HorasExtras(SalarioEmpleado, Cantidad).ToString("N2");
            }
            else
            {
                MessageBox.Show("Las horas solamente pueden ser valores numéricos!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCantidad.Text = TextCantidad.Text.Substring(0, TextCantidad.Text.Length - 1);
                TextCantidad.SelectionStart = TextCantidad.Text.Length;
            }
        }
    }
}