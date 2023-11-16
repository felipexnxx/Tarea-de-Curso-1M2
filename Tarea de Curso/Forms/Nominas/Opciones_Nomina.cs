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

namespace Tarea_de_Curso.Forms.Nominas
{
    public partial class Opciones_Nomina : Form
    {
        int idNomina = 0;
        public Opciones_Nomina(int id_nomina)
        {
            InitializeComponent();
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

        private void BtnVerNomina_Click(object sender, EventArgs e)
        {
            Nominas.Agregar_Nomina Form = new Nominas.Agregar_Nomina(0, idNomina);
            Form.ShowDialog(this);
            Form.Dispose();
            this.Close();
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            bool OK = NominaN.Desactivar_Nomina(idNomina);

            if (OK)
            {
                MessageBox.Show("La nómina se desactivó exitosamente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se desactivó la nómina!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Opciones_Nomina_Load(object sender, EventArgs e)
        {
            if (NominaN.CargarNominas().Where(x => x.id_nomina == idNomina).FirstOrDefault().activo == false)
            {
                BtnDesactivar.Enabled = false;
            }
        }
    }
}