
namespace Tarea_de_Curso.Forms.Empleados
{
    partial class Listar_Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataGridEmpleados = new System.Windows.Forms.DataGridView();
            this.bindingSourceEmpleado = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridEmpleados
            // 
            this.DataGridEmpleados.AllowUserToAddRows = false;
            this.DataGridEmpleados.AllowUserToDeleteRows = false;
            this.DataGridEmpleados.AutoGenerateColumns = false;
            this.DataGridEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.DataGridEmpleados.DataSource = this.bindingSourceEmpleado;
            this.DataGridEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridEmpleados.Location = new System.Drawing.Point(0, 0);
            this.DataGridEmpleados.Name = "DataGridEmpleados";
            this.DataGridEmpleados.ReadOnly = true;
            this.DataGridEmpleados.RowHeadersWidth = 62;
            this.DataGridEmpleados.RowTemplate.Height = 28;
            this.DataGridEmpleados.Size = new System.Drawing.Size(1056, 500);
            this.DataGridEmpleados.TabIndex = 0;
            this.DataGridEmpleados.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridEmpleados_CellMouseDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_empleado";
            this.Column1.HeaderText = "ID del Empleado";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "num_cedula";
            this.Column2.HeaderText = "Número de Cédula";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 117;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "num_INSS";
            this.Column3.HeaderText = "Número de INSS";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 117;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "num_RUC";
            this.Column4.HeaderText = "Número de RUC";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 117;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nombre";
            this.Column5.HeaderText = "Nombre";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 101;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "apellidos";
            this.Column6.HeaderText = "Apellidos";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 109;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "fecha_nacimiento";
            this.Column7.HeaderText = "Fecha de Nacimiento";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 179;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sexo";
            this.Column8.HeaderText = "Sexo";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 81;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "estado_civil";
            this.Column9.HeaderText = "Estado Civil";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 117;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "direccion";
            this.Column10.HeaderText = "Dirección";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 111;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "telefono";
            this.Column11.HeaderText = "Teléfono";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 107;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "celular";
            this.Column12.HeaderText = "Celular";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 94;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "salario_ordinario";
            this.Column13.HeaderText = "Salario Ordinario";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 149;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "fecha_contratacion";
            this.Column14.HeaderText = "Fecha de Contratación";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 189;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "activo";
            this.Column15.HeaderText = "Activo";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column15.Width = 88;
            // 
            // Listar_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 500);
            this.Controls.Add(this.DataGridEmpleados);
            this.Name = "Listar_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de empleados";
            this.Load += new System.EventHandler(this.Listar_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridEmpleados;
        private System.Windows.Forms.BindingSource bindingSourceEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column15;
    }
}