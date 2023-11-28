using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LoginForm : Form
    {

        // Form overrides dispose to clean up the component list.
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

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            btnAcceder = new Button();
            btnAcceder.Click += AccederButton_Click;
            btnCancelar = new Button();
            btnCancelar.Click += CancelarButton_Click;
            txtbUsuario = new TextBox();
            txtbPassword = new TextBox();
            lbUsuario = new Label();
            lbPassword = new Label();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(219, 180);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(153, 47);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(409, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 47);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtbUsuario
            // 
            txtbUsuario.Location = new Point(318, 61);
            txtbUsuario.Name = "txtbUsuario";
            txtbUsuario.Size = new Size(244, 27);
            txtbUsuario.TabIndex = 2;
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(318, 123);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.PasswordChar = '*';
            txtbPassword.Size = new Size(244, 27);
            txtbPassword.TabIndex = 3;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(230, 68);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(59, 20);
            lbUsuario.TabIndex = 4;
            lbUsuario.Text = "Usuario";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(219, 126);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 272);
            Controls.Add(lbPassword);
            Controls.Add(lbUsuario);
            Controls.Add(txtbPassword);
            Controls.Add(txtbUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAcceder);
            Name = "LoginForm";
            Text = "SESION";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Button btnAcceder;
        internal Button btnCancelar;
        internal TextBox txtbUsuario;
        internal TextBox txtbPassword;
        internal Label lbUsuario;
        internal Label lbPassword;
    }
}