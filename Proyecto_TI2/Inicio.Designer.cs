using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Inicio : Form
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
            btnAlumno = new Button();
            btnAlumno.Click += new EventHandler(btnAlumno_Click);
            btnMaestro = new Button();
            btnMaestro.Click += new EventHandler(btnMaestro_Click);
            btnSalir = new Button();
            btnSalir.Click += new EventHandler(btnSalir_Click);
            btnEliminarA = new Button();
            btnEliminarA.Click += new EventHandler(Button1_Click);
            btnEliminarM = new Button();
            btnEliminarM.Click += new EventHandler(btnEliminarM_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click_1);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            SuspendLayout();
            // 
            // btnAlumno
            // 
            btnAlumno.Location = new Point(11, 15);
            btnAlumno.Name = "btnAlumno";
            btnAlumno.Size = new Size(228, 112);
            btnAlumno.TabIndex = 0;
            btnAlumno.Text = "REGISTRAR ALUMNO";
            btnAlumno.UseVisualStyleBackColor = true;
            // 
            // btnMaestro
            // 
            btnMaestro.Location = new Point(11, 133);
            btnMaestro.Name = "btnMaestro";
            btnMaestro.Size = new Size(228, 112);
            btnMaestro.TabIndex = 1;
            btnMaestro.Text = "REGISTRAR MAESTRO";
            btnMaestro.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(518, 251);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(228, 112);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminarA
            // 
            btnEliminarA.Location = new Point(262, 15);
            btnEliminarA.Name = "btnEliminarA";
            btnEliminarA.Size = new Size(228, 112);
            btnEliminarA.TabIndex = 3;
            btnEliminarA.Text = "ELIMINAR ALUMNO";
            btnEliminarA.UseVisualStyleBackColor = true;
            // 
            // btnEliminarM
            // 
            btnEliminarM.Location = new Point(262, 133);
            btnEliminarM.Name = "btnEliminarM";
            btnEliminarM.Size = new Size(228, 112);
            btnEliminarM.TabIndex = 4;
            btnEliminarM.Text = "ELIMINAR MAESTRO";
            btnEliminarM.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Location = new Point(11, 251);
            Button1.Name = "Button1";
            Button1.Size = new Size(228, 112);
            Button1.TabIndex = 5;
            Button1.Text = "REGISTRO DE CLASES";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(262, 251);
            Button2.Name = "Button2";
            Button2.Size = new Size(228, 112);
            Button2.TabIndex = 6;
            Button2.Text = "INSCRIPCION A CLASES";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(518, 15);
            Button3.Name = "Button3";
            Button3.Size = new Size(228, 112);
            Button3.TabIndex = 7;
            Button3.Text = "NOTAS";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8f, 20f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 379);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(btnEliminarM);
            Controls.Add(btnEliminarA);
            Controls.Add(btnSalir);
            Controls.Add(btnMaestro);
            Controls.Add(btnAlumno);
            Name = "Inicio";
            Text = "INICIO";
            ResumeLayout(false);
        }

        internal Button btnAlumno;
        internal Button btnMaestro;
        internal Button btnSalir;
        internal Button btnEliminarA;
        internal Button btnEliminarM;
        internal Button Button1;
        internal Button Button2;
        internal Button Button3;
    }
}