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

namespace Tarea_de_Curso.Forms
{
    public partial class Inicio_Sesion : Form
    {
        int contador = 3;
        public Inicio_Sesion()
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Clear();
                TxtUsuario.ForeColor = Color.Black;
            }
            else if (String.IsNullOrEmpty(TxtUsuario.Text))
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "Contraseña")
            {
                TxtContraseña.Clear();
                TxtContraseña.ForeColor = Color.Black;
                TxtContraseña.UseSystemPasswordChar = true;
            }
            else if (String.IsNullOrEmpty(TxtContraseña.Text))
            {
                TxtContraseña.Text = "Contraseña";
                TxtContraseña.ForeColor = Color.DarkGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Clear();
                TxtUsuario.ForeColor = Color.Black;
            }
            else if (String.IsNullOrEmpty(TxtUsuario.Text))
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "Contraseña")
            {
                TxtContraseña.Clear();
                TxtContraseña.ForeColor = Color.Black;
                TxtContraseña.UseSystemPasswordChar = true;
            }
            else if (String.IsNullOrEmpty(TxtContraseña.Text))
            {
                TxtContraseña.Text = "Contraseña";
                TxtContraseña.ForeColor = Color.DarkGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void LinkLblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro_Usuario Form = new Registro_Usuario();
            this.Visible = false;
            Form.ShowDialog(this);
            Form.Dispose();
            this.Visible = true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            bool OK = false;
            string nombre = "";
            int id_usuario = 0;
            foreach (var n in UsuarioN.CargarUsuarios())
            {
                if (TxtUsuario.Text.ToUpper() == n.usuario && TxtContraseña.Text == n.contraseña)
                {
                    OK = true;
                    nombre = $"{n.apellidos}, {n.nombres}";
                    id_usuario = n.id_usuario;
                }
            }

            if (OK)
            {
                MessageBox.Show($"Se ingresó sesión exitosamente! \nBienvenido {nombre}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Principal Form = new Principal(id_usuario);
                this.Visible = false;
                Form.ShowDialog(this);
                Form.Dispose();
                this.Close();
            }
            else
            {
                contador--;
                if (contador > 0)
                {
                    MessageBox.Show($"Usuario o contraseña erroneos, tiene {contador} intento(s) más!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show($"El sistema se cerrará en este momento!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                TxtContraseña.Focus();
            }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BtnIngresar_Click(null, null);
            }
        }
    }
}