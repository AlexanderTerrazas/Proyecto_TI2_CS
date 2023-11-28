using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PEMAESTRO : Form
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
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            btnRegresar = new Button();
            btnRegresar.Click += new EventHandler(btnRegresar_Click);
            btnEliminar = new Button();
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            Resultados = new DataGridView();
            txtbBusqueda = new TextBox();
            btnBuscar = new Button();
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            ((System.ComponentModel.ISupportInitialize)Resultados).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(207, 268);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(159, 45);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 268);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(159, 45);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(401, 268);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(159, 45);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Resultados
            // 
            Resultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Resultados.Location = new Point(12, 61);
            Resultados.Name = "Resultados";
            Resultados.RowHeadersWidth = 51;
            Resultados.RowTemplate.Height = 29;
            Resultados.Size = new Size(548, 189);
            Resultados.TabIndex = 8;
            // 
            // txtbBusqueda
            // 
            txtbBusqueda.Location = new Point(193, 19);
            txtbBusqueda.Name = "txtbBusqueda";
            txtbBusqueda.Size = new Size(367, 27);
            txtbBusqueda.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(159, 45);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // PEMAESTRO
            // 
            AutoScaleDimensions = new SizeF(8f, 20f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 323);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(Resultados);
            Controls.Add(txtbBusqueda);
            Controls.Add(btnBuscar);
            Name = "PEMAESTRO";
            Text = "ELIMINACION DE MAESTROS";
            ((System.ComponentModel.ISupportInitialize)Resultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Button btnLimpiar;
        internal Button btnRegresar;
        internal Button btnEliminar;
        internal DataGridView Resultados;
        internal TextBox txtbBusqueda;
        internal Button btnBuscar;
    }
}