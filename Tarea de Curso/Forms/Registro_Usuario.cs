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
    public partial class Registro_Usuario : Form
    {
        public Registro_Usuario()
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
        }

        private void TxtNombres_Enter(object sender, EventArgs e)
        {
            if (TxtNombres.Text == "Ingrese su nombre")
            {
                TxtNombres.Clear();
                TxtNombres.ForeColor = Color.Black;
            }
            else if (String.IsNullOrEmpty(TxtNombres.Text))
            {
                TxtNombres.Text = "Ingrese su nombre";
                TxtNombres.ForeColor = Color.DarkGray;
            }
        }

        private void TxtNombres_Leave(object sender, EventArgs e)
        {
            if (TxtNombres.Text == "Ingrese su nombre")
            {
                TxtNombres.Clear();
                TxtNombres.ForeColor = Color.Black;
            }
            else if (String.IsNullOrEmpty(TxtNombres.Text))
            {
                TxtNombres.Text = "Ingrese su nombre";
                TxtNombres.ForeColor = Color.DarkGray;
            }
        }

        private void TxtApellidos_Enter(object sender, EventArgs e)
        {
            if (TxtApellidos.Text == "Ingrese sus apellidos")
            {
                TxtApellidos.Clear();
                TxtApellidos.ForeColor = Color.Black;
            }
            else if (String.IsNullOrEmpty(TxtApellidos.Text))
            {
                TxtApellidos.Text = "Ingrese sus apellidos";
                TxtApellidos.ForeColor = Color.DarkGray;
            }
        }

        private void TxtApellidos_Leave(object sender, EventArgs e)
        {
            if (TxtApellidos.Text == "Ingrese sus apellidos")
            {
                TxtApellidos.Clear();
                TxtApellidos.ForeColor = Color.Black;
            }
            else if (String.IsNullOrEmpty(TxtApellidos.Text))
            {
                TxtApellidos.Text = "Ingrese sus apellidos";
                TxtApellidos.ForeColor = Color.DarkGray;
            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Ingrese su usuario")
            {
                TxtUsuario.Clear();
                TxtUsuario.ForeColor = Color.Black;
            }
            else if (String.IsNullOrEmpty(TxtUsuario.Text))
            {
                TxtUsuario.Text = "Ingrese su usuario";
                TxtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Ingrese su usuario")
            {
                TxtUsuario.Clear();
                TxtUsuario.ForeColor = Color.Black;
            }
            else if (String.IsNullOrEmpty(TxtUsuario.Text))
            {
                TxtUsuario.Text = "Ingrese su usuario";
                TxtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "Ingrese su contraseña")
            {
                TxtContraseña.Clear();
                TxtContraseña.ForeColor = Color.Black;
                TxtContraseña.UseSystemPasswordChar = true;
            }
            else if (String.IsNullOrEmpty(TxtContraseña.Text))
            {
                TxtContraseña.Text = "Ingrese su contraseña";
                TxtContraseña.ForeColor = Color.DarkGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "Ingrese su contraseña")
            {
                TxtContraseña.Clear();
                TxtContraseña.ForeColor = Color.Black;
                TxtContraseña.UseSystemPasswordChar = true;
            }
            else if (String.IsNullOrEmpty(TxtContraseña.Text))
            {
                TxtContraseña.Text = "Ingrese su contraseña";
                TxtContraseña.ForeColor = Color.DarkGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = TxtNombres.Text;
                string Apellidos = TxtApellidos.Text;
                string Usuario = TxtUsuario.Text.ToUpper();
                string Contraseña = TxtContraseña.Text;

                List<POO.Usuario> Usuarios = UsuarioN.CargarUsuarios();

                Usuarios.Add(new POO.Usuario 
                {
                    id_usuario = (Usuarios.Count + 1),
                    nombres = Nombre,
                    apellidos = Apellidos,
                    usuario = Usuario,
                    contraseña = Contraseña
                });

                bool OK = UsuarioN.GuardarUsuario(Usuarios);

                if (OK)
                {
                    MessageBox.Show("El usuario se guardó exitosamente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se guardó el usuario!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}