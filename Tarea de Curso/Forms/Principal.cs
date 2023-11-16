using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_de_Curso.Forms
{
    public partial class Principal : Form
    {
        int idUsuario;
        public Principal(int id_usuario)
        {
            InitializeComponent();
            idUsuario = id_usuario;
        }

        private bool ExisteFormulario(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name && child.Text == form.Text)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados.Agregar_Empleado Form = new Empleados.Agregar_Empleado(0);
            if (ExisteFormulario(Form))
                return;
            Form.MdiParent = this;
            Form.Show();
        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados.Listar_Empleados Form = new Empleados.Listar_Empleados();
            if (ExisteFormulario(Form))
                return;
            Form.MdiParent = this;
            Form.Show();
        }

        private void agregarNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nominas.Agregar_Nomina Form = new Nominas.Agregar_Nomina(idUsuario, 0);
            if (ExisteFormulario(Form))
                return;
            Form.MdiParent = this;
            Form.Show();
        }

        private void mostrarNóminasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nominas.Mostrar_Nominas Form = new Nominas.Mostrar_Nominas();
            if (ExisteFormulario(Form))
                return;
            Form.MdiParent = this;
            Form.Show();
        }
    }
}