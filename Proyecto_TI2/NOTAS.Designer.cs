using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Login
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class NOTAS : Form
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
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            DataGridView1 = new DataGridView();
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            btnRegresar = new Button();
            btnRegresar.Click += new EventHandler(btnRegresar_Click);
            btnAgregar = new Button();
            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            Label4 = new Label();
            btnActualizar = new Button();
            btnActualizar.Click += new EventHandler(btnActualizar_Click);
            DataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView2).BeginInit();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(140, 31);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(442, 27);
            txtBusqueda.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(10, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(117, 54);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(137, 87);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 29;
            DataGridView1.Size = new Size(890, 182);
            DataGridView1.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(494, 579);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(159, 45);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(139, 579);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(159, 45);
            btnRegresar.TabIndex = 24;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(870, 579);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 45);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(196, 559);
            Label4.Name = "Label4";
            Label4.Size = new Size(0, 20);
            Label4.TabIndex = 22;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(25, 285);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 52);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "ACTUALIZAR" + Constants.vbCrLf + "TABLA";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // DataGridView2
            // 
            DataGridView2.AllowUserToAddRows = false;
            DataGridView2.AllowUserToDeleteRows = false;
            DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView2.Location = new Point(137, 285);
            DataGridView2.Name = "DataGridView2";
            DataGridView2.ReadOnly = true;
            DataGridView2.RowHeadersWidth = 51;
            DataGridView2.RowTemplate.Height = 29;
            DataGridView2.Size = new Size(890, 271);
            DataGridView2.TabIndex = 20;
            // 
            // NOTAS
            // 
            AutoScaleDimensions = new SizeF(8f, 20f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 655);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(Label4);
            Controls.Add(btnActualizar);
            Controls.Add(DataGridView2);
            Controls.Add(DataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Name = "NOTAS";
            Text = "REGISTRO DE NOTAS";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox txtBusqueda;
        internal Button btnBuscar;
        internal DataGridView DataGridView1;
        internal Button btnLimpiar;
        internal Button btnRegresar;
        internal Button btnAgregar;
        internal Label Label4;
        internal Button btnActualizar;
        internal DataGridView DataGridView2;
    }
}