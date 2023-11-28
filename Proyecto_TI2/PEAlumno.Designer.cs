using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PEALUMNO : Form
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
            btnBuscar = new Button();
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            txtbBusqueda = new TextBox();
            Resultados = new DataGridView();
            btnEliminar = new Button();
            btnEliminar.Click += new EventHandler(Button2_Click);
            btnRegresar = new Button();
            btnRegresar.Click += new EventHandler(Button3_Click);
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            ((System.ComponentModel.ISupportInitialize)Resultados).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(159, 45);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtbBusqueda
            // 
            txtbBusqueda.Location = new Point(193, 24);
            txtbBusqueda.Name = "txtbBusqueda";
            txtbBusqueda.Size = new Size(367, 27);
            txtbBusqueda.TabIndex = 1;
            // 
            // Resultados
            // 
            Resultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Resultados.Location = new Point(12, 66);
            Resultados.Name = "Resultados";
            Resultados.RowHeadersWidth = 51;
            Resultados.RowTemplate.Height = 29;
            Resultados.Size = new Size(548, 189);
            Resultados.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(401, 273);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(159, 45);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 273);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(159, 45);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(207, 273);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(159, 45);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // PEALUMNO
            // 
            AutoScaleDimensions = new SizeF(8f, 20f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 339);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(Resultados);
            Controls.Add(txtbBusqueda);
            Controls.Add(btnBuscar);
            Name = "PEALUMNO";
            Text = "ELIMINACION DE ALUMNOS";
            ((System.ComponentModel.ISupportInitialize)Resultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Button btnBuscar;
        internal TextBox txtbBusqueda;
        internal DataGridView Resultados;
        internal Button btnEliminar;
        internal Button btnRegresar;
        internal Button btnLimpiar;
    }
}