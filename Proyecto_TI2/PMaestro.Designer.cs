using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PMaestro : Form
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
            txtbNombreM = new TextBox();
            txtbApellidoM = new TextBox();
            txtbCorreoM = new TextBox();
            Label4 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            btnRegistroM = new Button();
            btnRegistroM.Click += new EventHandler(btnRegistroM_Click);
            Button3 = new Button();
            SuspendLayout();
            // 
            // txtbNombreM
            // 
            txtbNombreM.Location = new Point(174, 12);
            txtbNombreM.Name = "txtbNombreM";
            txtbNombreM.Size = new Size(332, 27);
            txtbNombreM.TabIndex = 18;
            // 
            // txtbApellidoM
            // 
            txtbApellidoM.Location = new Point(174, 54);
            txtbApellidoM.Name = "txtbApellidoM";
            txtbApellidoM.Size = new Size(332, 27);
            txtbApellidoM.TabIndex = 17;
            // 
            // txtbCorreoM
            // 
            txtbCorreoM.Location = new Point(174, 101);
            txtbCorreoM.Name = "txtbCorreoM";
            txtbCorreoM.Size = new Size(332, 27);
            txtbCorreoM.TabIndex = 16;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(105, 104);
            Label4.Name = "Label4";
            Label4.Size = new Size(52, 20);
            Label4.TabIndex = 15;
            Label4.Text = "E-mail";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(10, 61);
            Label2.Name = "Label2";
            Label2.Size = new Size(149, 20);
            Label2.TabIndex = 13;
            Label2.Text = "Apellido del Maestro";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(10, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(147, 20);
            Label1.TabIndex = 12;
            Label1.Text = "Nombre del Maestro";
            // 
            // Button1
            // 
            Button1.Location = new Point(10, 149);
            Button1.Name = "Button1";
            Button1.Size = new Size(245, 62);
            Button1.TabIndex = 19;
            Button1.Text = "REGRESAR";
            Button1.UseVisualStyleBackColor = true;
            // 
            // btnRegistroM
            // 
            btnRegistroM.Location = new Point(261, 149);
            btnRegistroM.Name = "btnRegistroM";
            btnRegistroM.Size = new Size(245, 62);
            btnRegistroM.TabIndex = 20;
            btnRegistroM.Text = "REGISTRAR MAESTRO";
            btnRegistroM.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(483, 269);
            Button3.Name = "Button3";
            Button3.Size = new Size(94, 29);
            Button3.TabIndex = 21;
            Button3.Text = "Button3";
            Button3.UseVisualStyleBackColor = true;
            // 
            // PMaestro
            // 
            AutoScaleDimensions = new SizeF(8f, 20f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 227);
            Controls.Add(Button3);
            Controls.Add(btnRegistroM);
            Controls.Add(Button1);
            Controls.Add(txtbNombreM);
            Controls.Add(txtbApellidoM);
            Controls.Add(txtbCorreoM);
            Controls.Add(Label4);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Name = "PMaestro";
            Text = "REGISTRO DE MAESTROS";
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox txtbNombreM;
        internal TextBox txtbApellidoM;
        internal TextBox txtbCorreoM;
        internal Label Label4;
        internal Label Label2;
        internal Label Label1;
        internal Button Button1;
        internal Button btnRegistroM;
        internal Button Button3;
    }
}