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
    public partial class Mostrar_Nominas : Form
    {
        public Mostrar_Nominas()
        {
            InitializeComponent();
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

        private void Mostrar_Nominas_Load(object sender, EventArgs e)
        {
            bindingSourceNominas.DataSource = NominaN.CargarNominas();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatGridNominas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                DataGridNominas.ClearSelection();
                DataGridNominas.Rows[e.RowIndex].Selected = true;
                int idNomina = Convert.ToInt32(DataGridNominas.Rows[e.RowIndex].Cells[0].Value);

                Opciones_Nomina Form = new Opciones_Nomina(idNomina);
                Form.Location = DataGridNominas.PointToClient(Cursor.Position);
                Form.ShowDialog(this);
                Form.Dispose();

                bindingSourceNominas.DataSource = NominaN.CargarNominas();
            }
        }
    }
}