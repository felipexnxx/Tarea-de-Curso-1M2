
namespace Tarea_de_Curso.Forms.Empleados
{
    partial class Opciones_Empleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnEditarEmpleado = new System.Windows.Forms.Button();
            this.BtnAgregarIngreso = new System.Windows.Forms.Button();
            this.BtnMostrarIngresos = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(143)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 56);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.BtnEditarEmpleado);
            this.flowLayoutPanel1.Controls.Add(this.BtnAgregarIngreso);
            this.flowLayoutPanel1.Controls.Add(this.BtnMostrarIngresos);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 438);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // BtnEditarEmpleado
            // 
            this.BtnEditarEmpleado.Location = new System.Drawing.Point(5, 5);
            this.BtnEditarEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEditarEmpleado.Name = "BtnEditarEmpleado";
            this.BtnEditarEmpleado.Padding = new System.Windows.Forms.Padding(5);
            this.BtnEditarEmpleado.Size = new System.Drawing.Size(241, 44);
            this.BtnEditarEmpleado.TabIndex = 0;
            this.BtnEditarEmpleado.Text = "Editar Empleado";
            this.BtnEditarEmpleado.UseVisualStyleBackColor = true;
            this.BtnEditarEmpleado.Click += new System.EventHandler(this.BtnEditarEmpleado_Click);
            // 
            // BtnAgregarIngreso
            // 
            this.BtnAgregarIngreso.Location = new System.Drawing.Point(5, 59);
            this.BtnAgregarIngreso.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAgregarIngreso.Name = "BtnAgregarIngreso";
            this.BtnAgregarIngreso.Padding = new System.Windows.Forms.Padding(5);
            this.BtnAgregarIngreso.Size = new System.Drawing.Size(241, 44);
            this.BtnAgregarIngreso.TabIndex = 1;
            this.BtnAgregarIngreso.Text = "Agregar Ingreso";
            this.BtnAgregarIngreso.UseVisualStyleBackColor = true;
            this.BtnAgregarIngreso.Click += new System.EventHandler(this.BtnAgregarIngreso_Click);
            // 
            // BtnMostrarIngresos
            // 
            this.BtnMostrarIngresos.Location = new System.Drawing.Point(5, 113);
            this.BtnMostrarIngresos.Margin = new System.Windows.Forms.Padding(5);
            this.BtnMostrarIngresos.Name = "BtnMostrarIngresos";
            this.BtnMostrarIngresos.Padding = new System.Windows.Forms.Padding(5);
            this.BtnMostrarIngresos.Size = new System.Drawing.Size(241, 44);
            this.BtnMostrarIngresos.TabIndex = 2;
            this.BtnMostrarIngresos.Text = "Mostrar Ingresos";
            this.BtnMostrarIngresos.UseVisualStyleBackColor = true;
            this.BtnMostrarIngresos.Click += new System.EventHandler(this.BtnMostrarIngresos_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.BtnCancelar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 437);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(253, 57);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(5, 5);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Size = new System.Drawing.Size(241, 44);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Opciones_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 494);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opciones_Empleado";
            this.Text = "Menu de opciones de empleados";
            this.Load += new System.EventHandler(this.Opciones_Empleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnEditarEmpleado;
        private System.Windows.Forms.Button BtnAgregarIngreso;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnMostrarIngresos;
    }
}