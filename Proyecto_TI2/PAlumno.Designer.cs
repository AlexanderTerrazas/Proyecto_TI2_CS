using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PAlumno : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            txtbCorreo = new TextBox();
            txtbApellidoA = new TextBox();
            txtbNombreA = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnRegistroA = new Button();
            btnRegistroA.Click += new EventHandler(btnRegistroA_Click);
            ListBoxCurso = new ListBox();
            ListBoxPeriodo = new ListBox();
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            btnCerrar = new Button();
            btnCerrar.Click += new EventHandler(btnCerrar_Click);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(19, 38);
            Label1.Name = "Label1";
            Label1.Size = new Size(145, 20);
            Label1.TabIndex = 0;
            Label1.Text = "Nombre del Alumno";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(19, 80);
            Label2.Name = "Label2";
            Label2.Size = new Size(147, 20);
            Label2.TabIndex = 1;
            Label2.Text = "Apellido del Alumno";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(19, 124);
            Label3.Name = "Label3";
            Label3.Size = new Size(149, 20);
            Label3.TabIndex = 2;
            Label3.Text = "Fecha de Nacimiento";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(19, 165);
            Label4.Name = "Label4";
            Label4.Size = new Size(52, 20);
            Label4.TabIndex = 3;
            Label4.Text = "E-mail";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(19, 202);
            Label5.Name = "Label5";
            Label5.Size = new Size(139, 20);
            Label5.TabIndex = 4;
            Label5.Text = "Periodo Academico";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(301, 202);
            Label6.Name = "Label6";
            Label6.Size = new Size(46, 20);
            Label6.TabIndex = 5;
            Label6.Text = "Curso";
            // 
            // txtbCorreo
            // 
            txtbCorreo.Location = new Point(183, 158);
            txtbCorreo.Name = "txtbCorreo";
            txtbCorreo.Size = new Size(332, 27);
            txtbCorreo.TabIndex = 8;
            // 
            // txtbApellidoA
            // 
            txtbApellidoA.Location = new Point(183, 73);
            txtbApellidoA.Name = "txtbApellidoA";
            txtbApellidoA.Size = new Size(332, 27);
            txtbApellidoA.TabIndex = 9;
            // 
            // txtbNombreA
            // 
            txtbNombreA.Location = new Point(183, 31);
            txtbNombreA.Name = "txtbNombreA";
            txtbNombreA.Size = new Size(332, 27);
            txtbNombreA.TabIndex = 10;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(183, 117);
            dtpFechaNacimiento.MaxDate = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            dtpFechaNacimiento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(332, 27);
            dtpFechaNacimiento.TabIndex = 11;
            dtpFechaNacimiento.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnRegistroA
            // 
            btnRegistroA.Location = new Point(183, 248);
            btnRegistroA.Name = "btnRegistroA";
            btnRegistroA.Size = new Size(332, 52);
            btnRegistroA.TabIndex = 12;
            btnRegistroA.Text = "REGISTRAR ALUMNO";
            btnRegistroA.UseVisualStyleBackColor = true;
            // 
            // ListBoxCurso
            // 
            ListBoxCurso.FormattingEnabled = true;
            ListBoxCurso.ItemHeight = 20;
            ListBoxCurso.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            ListBoxCurso.Location = new Point(373, 198);
            ListBoxCurso.Name = "ListBoxCurso";
            ListBoxCurso.Size = new Size(142, 24);
            ListBoxCurso.TabIndex = 7;
            // 
            // ListBoxPeriodo
            // 
            ListBoxPeriodo.FormattingEnabled = true;
            ListBoxPeriodo.ItemHeight = 20;
            ListBoxPeriodo.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            ListBoxPeriodo.Location = new Point(183, 198);
            ListBoxPeriodo.Name = "ListBoxPeriodo";
            ListBoxPeriodo.Size = new Size(89, 24);
            ListBoxPeriodo.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(19, 248);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(158, 52);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(189, 334);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(158, 31);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // PAlumno
            // 
            AutoScaleDimensions = new SizeF(8f, 20f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 377);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistroA);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtbNombreA);
            Controls.Add(txtbApellidoA);
            Controls.Add(txtbCorreo);
            Controls.Add(ListBoxCurso);
            Controls.Add(ListBoxPeriodo);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "PAlumno";
            Text = "REGISTRO DE ALUMNOS";
            Load += new EventHandler(PAlumno_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        private TextBox txtbCorreo;
        internal ListBox ListBox1;
        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal TextBox TextBox3;
        internal DateTimePicker dtpFechaNacimiento;
        internal Button btnRegistroA;
        internal ListBox ListBoxCurso;
        internal ListBox ListBoxPeriodo;
        private TextBox txtbApellidoA;
        private TextBox txtbNombreA;
        internal Button btnLimpiar;
        internal Button btnCerrar;
    }
}