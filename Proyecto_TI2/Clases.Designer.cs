using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CLASES : Form
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
            ResultadosP = new DataGridView();
            btnMaestros = new Button();
            btnMaestros.Click += new EventHandler(btnMaestros_Click);
            btnMaterias = new Button();
            btnMaterias.Click += new EventHandler(btnMaterias_Click);
            ResultadosM = new DataGridView();
            Label4 = new Label();
            Label4.Click += new EventHandler(Label4_Click);
            ComboBox1 = new ComboBox();
            Button1 = new Button();
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            btnRegresar = new Button();
            btnRegresar.Click += new EventHandler(btnRegresar_Click);
            btnAgregar = new Button();
            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            ((System.ComponentModel.ISupportInitialize)ResultadosP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResultadosM).BeginInit();
            SuspendLayout();
            // 
            // ResultadosP
            // 
            ResultadosP.AllowUserToAddRows = false;
            ResultadosP.AllowUserToDeleteRows = false;
            ResultadosP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultadosP.Location = new Point(163, 38);
            ResultadosP.Name = "ResultadosP";
            ResultadosP.ReadOnly = true;
            ResultadosP.RowHeadersWidth = 51;
            ResultadosP.RowTemplate.Height = 29;
            ResultadosP.Size = new Size(304, 114);
            ResultadosP.TabIndex = 6;
            // 
            // btnMaestros
            // 
            btnMaestros.Location = new Point(33, 38);
            btnMaestros.Name = "btnMaestros";
            btnMaestros.Size = new Size(124, 44);
            btnMaestros.TabIndex = 7;
            btnMaestros.Text = "MAESTROS";
            btnMaestros.UseVisualStyleBackColor = true;
            // 
            // btnMaterias
            // 
            btnMaterias.Location = new Point(33, 158);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(124, 44);
            btnMaterias.TabIndex = 8;
            btnMaterias.Text = "MATERIAS";
            btnMaterias.UseVisualStyleBackColor = true;
            // 
            // ResultadosM
            // 
            ResultadosM.AllowUserToAddRows = false;
            ResultadosM.AllowUserToDeleteRows = false;
            ResultadosM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultadosM.Location = new Point(163, 158);
            ResultadosM.Name = "ResultadosM";
            ResultadosM.ReadOnly = true;
            ResultadosM.RowHeadersWidth = 51;
            ResultadosM.RowTemplate.Height = 29;
            ResultadosM.Size = new Size(304, 112);
            ResultadosM.TabIndex = 9;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(68, 309);
            Label4.Name = "Label4";
            Label4.Size = new Size(0, 20);
            Label4.TabIndex = 10;
            // 
            // ComboBox1
            // 
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            ComboBox1.Location = new Point(163, 276);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(130, 28);
            ComboBox1.TabIndex = 11;
            // 
            // Button1
            // 
            Button1.Location = new Point(33, 276);
            Button1.Name = "Button1";
            Button1.Size = new Size(124, 30);
            Button1.TabIndex = 12;
            Button1.Text = "CURSO";
            Button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(206, 329);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(159, 45);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(11, 329);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(159, 45);
            btnRegresar.TabIndex = 14;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(400, 329);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 45);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // CLASES
            // 
            AutoScaleDimensions = new SizeF(8f, 20f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 389);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(Button1);
            Controls.Add(ComboBox1);
            Controls.Add(Label4);
            Controls.Add(ResultadosM);
            Controls.Add(btnMaterias);
            Controls.Add(btnMaestros);
            Controls.Add(ResultadosP);
            Name = "CLASES";
            Text = "ASIGNACION DE CLASES";
            ((System.ComponentModel.ISupportInitialize)ResultadosP).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResultadosM).EndInit();
            Load += new EventHandler(TuFormulario_Load);
            ResumeLayout(false);
            PerformLayout();
        }
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal DataGridView ResultadosP;
        internal Button btnMaestros;
        internal Button btnMaterias;
        internal DataGridView ResultadosM;
        internal Label Label4;
        internal ComboBox ComboBox1;
        internal Button Button1;
        internal Button btnLimpiar;
        internal Button btnRegresar;
        internal Button btnAgregar;
    }
}