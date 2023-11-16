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
    public partial class Agregar_Empleado : Form
    {
        int idEmpleado = 0;
        public Agregar_Empleado(int id_empleado)
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

        private void Agregar_Empleado_Load(object sender, EventArgs e)
        {
            ComboSexo.SelectedIndex = 0;
            ComboEstadoCivil.SelectedIndex = 0;
            TextIdEmpleado.Text = (EmpleadoN.CargarEmpleados().Count + 1).ToString();
            if (idEmpleado != 0)
            {
                this.Text = "Editar empleado";
                this.label16.Text = "Editar empleado";
                CheckActivo.Enabled = true;

                Empleado E = EmpleadoN.CargarEmpleados().Where(x => x.id_empleado == idEmpleado).FirstOrDefault();

                TextIdEmpleado.Text = E.id_empleado.ToString();
                TextCedula.Text = E.num_cedula.ToString();
                TextINSS.Text = E.num_INSS.ToString();
                TextRUC.Text = E.num_RUC.ToString();
                TextNombre.Text = E.nombre.ToString();
                TextApellidos.Text = E.apellidos.ToString();
                DateTimeNacimiento.Value = E.fecha_nacimiento;
                int Sexo = ComboSexo.FindString(E.sexo.ToString());
                ComboSexo.SelectedIndex = Sexo;
                int EstadoCivil = ComboEstadoCivil.FindString(E.estado_civil.ToString());
                ComboEstadoCivil.SelectedIndex = EstadoCivil;
                TextTelefono.Text = E.telefono.ToString();
                TextCelular.Text = E.celular.ToString();
                TextDireccion.Text = E.direccion.ToString();
                TextSalarioOrdinario.Text = E.salario_ordinario.ToString("N2");
                DateTimeContratacion.Value = E.fecha_contratacion;
                CheckActivo.Checked = E.activo;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_empleado = Convert.ToInt32(TextIdEmpleado.Text.ToString());
                string num_cedula = TextCedula.Text.ToString();
                string num_INSS = TextINSS.Text.ToString();
                string num_RUC = TextRUC.Text.ToString();
                string nombre = TextNombre.Text.ToUpper().ToString();
                string apellidos = TextApellidos.Text.ToUpper().ToString();
                DateTime fecha_nacimiento = Convert.ToDateTime(DateTimeNacimiento.Value.ToString("d"));
                string sexo = ComboSexo.Text.ToUpper().ToString();
                string estado_civil = ComboEstadoCivil.Text.ToUpper().ToString();
                string telefono = TextTelefono.Text.ToString();
                string celular = TextCelular.Text.ToString();
                string direccion = TextDireccion.Text.ToUpper().ToString();
                decimal salario_ordinario = Convert.ToDecimal(TextSalarioOrdinario.Text.ToString());
                DateTime fecha_contratacion = Convert.ToDateTime(DateTimeContratacion.Value.ToString("d"));
                bool activo = CheckActivo.Checked;

                List<Empleado> Empleados = EmpleadoN.CargarEmpleados();

                if (idEmpleado == 0)
                {
                    Empleados.Add(new Empleado
                    {
                        id_empleado = id_empleado,
                        num_cedula = num_cedula,
                        num_INSS = num_INSS,
                        num_RUC = num_RUC,
                        nombre = nombre,
                        apellidos = apellidos,
                        fecha_nacimiento = fecha_nacimiento,
                        sexo = sexo,
                        estado_civil = estado_civil,
                        telefono = telefono,
                        celular = celular,
                        direccion = direccion,
                        salario_ordinario = salario_ordinario,
                        fecha_contratacion = fecha_contratacion,
                        activo = true
                    });

                    bool OK = EmpleadoN.GuardarEmpleado(Empleados);

                    if (OK)
                    {
                        MessageBox.Show("El empleado se guardó exitosamente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se guardó el empleado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Empleado E = Empleados.Where(x => x.id_empleado == idEmpleado).FirstOrDefault();

                    if (E != null)
                    {
                        E.id_empleado = id_empleado;
                        E.num_cedula = num_cedula;
                        E.num_INSS = num_INSS;
                        E.num_RUC = num_RUC;
                        E.nombre = nombre;
                        E.apellidos = apellidos;
                        E.fecha_nacimiento = fecha_nacimiento;
                        E.sexo = sexo;
                        E.estado_civil = estado_civil;
                        E.telefono = telefono;
                        E.celular = celular;
                        E.direccion = direccion;
                        E.salario_ordinario = salario_ordinario;
                        E.fecha_contratacion = fecha_contratacion;
                        E.activo = activo;
                    }

                    bool OK = EmpleadoN.GuardarEmpleado(Empleados);

                    if (OK)
                    {
                        MessageBox.Show("El empleado se editó exitosamente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se editó el empleado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckActivo.Checked)
            {
                CheckActivo.Text = "Activo";
            }
            else
            {
                CheckActivo.Text = "Inactivo";
            }
        }
    }
}