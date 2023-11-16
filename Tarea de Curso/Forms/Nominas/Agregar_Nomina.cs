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

namespace Tarea_de_Curso.Forms.Nominas
{
    public partial class Agregar_Nomina : Form
    {
        int idUsuario = 0, idNomina = 0;
        public Agregar_Nomina(int id_usuario, int id_nomina)
        {
            InitializeComponent();
            idUsuario = id_usuario;
            idNomina = id_nomina;
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

        private void Agregar_Nomina_Load(object sender, EventArgs e)
        {
            if (idNomina != 0)
            {
                BtnAceptar.Enabled = false;
                label1.Text = "Ver nómina";
                bindingSourceNomina.DataSource = NominaN.CargarDetallesNominas().Where(x => x.id_nomina == idNomina);
            }
            else
            {
                bindingSourceNomina.DataSource = NominaN.CrearNomina();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            List<Nomina> Nominas = NominaN.CargarNominas();
            List<Detalles_Nomina> Detalles_Nominas = NominaN.CargarDetallesNominas();
            Usuario U = UsuarioN.CargarUsuarios().Where(x => x.id_usuario == idUsuario).FirstOrDefault();

            foreach (var n in Nominas)
            {
                if ((n.fecha_registro.Month == DateTime.Now.Month && n.fecha_registro.Year == DateTime.Now.Year) && n.activo == true)
                {
                    MessageBox.Show("Una nómina ya fue realizada en este mes! \n\nNota: Si quiere realizar otra nómina debe desactivar la anterior", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            Nominas.Add(new Nomina 
            { 
                id_nomina = (Nominas.Count + 1),
                id_usuario = idUsuario,
                nombre_usuario = $"{U.apellidos}, {U.nombres}".ToUpper(),
                fecha_registro = Convert.ToDateTime(DateTime.Now.ToString("d")),
                activo = true
            });

            foreach (var Detalle in NominaN.CrearNomina())
            {
                Detalles_Nominas.Add(new Detalles_Nomina
                {
                    id_nomina = Detalle.id_nomina,
                    id_empleado = Detalle.id_empleado,
                    nombre_empleado = Detalle.nombre_empleado,
                    salario_ordinario = Detalle.salario_ordinario,
                    antiguedad = Detalle.antiguedad,
                    pago_riesgo_laboral = Detalle.pago_riesgo_laboral,
                    pago_nocturnidad = Detalle.pago_nocturnidad,
                    horas_extras = Detalle.horas_extras,
                    salario_extraordinario = Detalle.salario_extraordinario,
                    salario_bruto = Detalle.salario_bruto,
                    INSS_laboral = Detalle.INSS_laboral,
                    IR = Detalle.IR,
                    salario_neto = Detalle.salario_neto,
                    INSS_patronal = Detalle.INSS_patronal
                });
            }

            bool OK = NominaN.GuardarNomina(Nominas, Detalles_Nominas);

            if (OK)
            {
                MessageBox.Show("La nómina y sus detalles fueron guardados exitosamente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se guardó la nómina ni sus detalles!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}