using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_de_Curso.Negocio;

namespace Tarea_de_Curso.Forms.Empleados
{
    public partial class Listar_Empleados : Form
    {
        public Listar_Empleados()
        {
            InitializeComponent();
        }

        private void Listar_Empleados_Load(object sender, EventArgs e)
        {
            bindingSourceEmpleado.DataSource = EmpleadoN.CargarEmpleados();
        }

        private void DataGridEmpleados_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                DataGridEmpleados.ClearSelection();
                DataGridEmpleados.Rows[e.RowIndex].Selected = true;
                int idEmpleado = Convert.ToInt32(DataGridEmpleados.Rows[e.RowIndex].Cells[0].Value);

                Opciones_Empleado Form = new Opciones_Empleado(idEmpleado);
                Form.Location = DataGridEmpleados.PointToClient(Cursor.Position);
                Form.ShowDialog(this);
                Form.Dispose();

                bindingSourceEmpleado.DataSource = EmpleadoN.CargarEmpleados();
            }
        }
    }
}