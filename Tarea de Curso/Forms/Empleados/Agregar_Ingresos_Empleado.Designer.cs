
namespace Tarea_de_Curso.Forms.Empleados
{
    partial class Agregar_Ingresos_Empleado
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
            this.label2 = new System.Windows.Forms.Label();
            this.TextEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboTipoIngreso = new System.Windows.Forms.ComboBox();
            this.TextCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextDinero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(143)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 56);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Ingresos a Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleado:";
            // 
            // TextEmpleado
            // 
            this.TextEmpleado.BackColor = System.Drawing.Color.White;
            this.TextEmpleado.Location = new System.Drawing.Point(132, 78);
            this.TextEmpleado.Name = "TextEmpleado";
            this.TextEmpleado.ReadOnly = true;
            this.TextEmpleado.Size = new System.Drawing.Size(308, 26);
            this.TextEmpleado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Ingreso:";
            // 
            // ComboTipoIngreso
            // 
            this.ComboTipoIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoIngreso.FormattingEnabled = true;
            this.ComboTipoIngreso.Items.AddRange(new object[] {
            "PAGO POR RIESGO LABORAL",
            "PAGO POR NOCTURNIDAD",
            "HORAS EXTRAS"});
            this.ComboTipoIngreso.Location = new System.Drawing.Point(154, 121);
            this.ComboTipoIngreso.Name = "ComboTipoIngreso";
            this.ComboTipoIngreso.Size = new System.Drawing.Size(286, 28);
            this.ComboTipoIngreso.TabIndex = 7;
            this.ComboTipoIngreso.SelectedIndexChanged += new System.EventHandler(this.ComboTipoIngreso_SelectedIndexChanged);
            // 
            // TextCantidad
            // 
            this.TextCantidad.BackColor = System.Drawing.Color.White;
            this.TextCantidad.Location = new System.Drawing.Point(132, 166);
            this.TextCantidad.Name = "TextCantidad";
            this.TextCantidad.Size = new System.Drawing.Size(308, 26);
            this.TextCantidad.TabIndex = 9;
            this.TextCantidad.TextChanged += new System.EventHandler(this.TextCantidad_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // TextDinero
            // 
            this.TextDinero.BackColor = System.Drawing.Color.White;
            this.TextDinero.Location = new System.Drawing.Point(132, 207);
            this.TextDinero.Name = "TextDinero";
            this.TextDinero.ReadOnly = true;
            this.TextDinero.Size = new System.Drawing.Size(308, 26);
            this.TextDinero.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dinero:";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(131, 258);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Padding = new System.Windows.Forms.Padding(5);
            this.BtnAceptar.Size = new System.Drawing.Size(98, 40);
            this.BtnAceptar.TabIndex = 12;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(254, 258);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Size = new System.Drawing.Size(98, 40);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar\r\n";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Agregar_Ingresos_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 312);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TextDinero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboTipoIngreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Ingresos_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar ingresos a empleado";
            this.Load += new System.EventHandler(this.Agregar_Ingresos_Empleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboTipoIngreso;
        private System.Windows.Forms.TextBox TextCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextDinero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}