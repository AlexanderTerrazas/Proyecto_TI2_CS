using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Login
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class INSCRIPCION : Form
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
            btnBuscarA = new Button();
            txtBusqueda = new TextBox();
            DataGridView1 = new DataGridView();
            DataGridView2 = new DataGridView();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            btnRegresar = new Button();
            btnRegresar.Click += new EventHandler(btnRegresar_Click);
            btnAgregar = new Button();
            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            Label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarA
            // 
            btnBuscarA.Location = new Point(24, 17);
            btnBuscarA.Name = "btnBuscarA";
            btnBuscarA.Size = new Size(103, 52);
            btnBuscarA.TabIndex = 0;
            btnBuscarA.Text = "BUSCAR " + Constants.vbCrLf + "ALUMNO";
            btnBuscarA.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(136, 30);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(344, 27);
            txtBusqueda.TabIndex = 1;
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(133, 67);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 29;
            DataGridView1.Size = new Size(890, 140);
            DataGridView1.TabIndex = 2;
            // 
            // DataGridView2
            // 
            DataGridView2.AllowUserToAddRows = false;
            DataGridView2.AllowUserToDeleteRows = false;
            DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView2.Location = new Point(133, 213);
            DataGridView2.Name = "DataGridView2";
            DataGridView2.ReadOnly = true;
            DataGridView2.RowHeadersWidth = 51;
            DataGridView2.RowTemplate.Height = 29;
            DataGridView2.Size = new Size(890, 140);
            DataGridView2.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(21, 213);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 52);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "ACTUALIZAR" + Constants.vbCrLf + "TABLA";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(488, 383);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(159, 45);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(133, 383);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(159, 45);
            btnRegresar.TabIndex = 18;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(864, 383);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 45);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(190, 363);
            Label4.Name = "Label4";
            Label4.Size = new Size(0, 20);
            Label4.TabIndex = 16;
            // 
            // INSCRIPCION
            // 
            AutoScaleDimensions = new SizeF(8f, 20f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(Label4);
            Controls.Add(btnActualizar);
            Controls.Add(DataGridView2);
            Controls.Add(DataGridView1);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscarA);
            Name = "INSCRIPCION";
            Text = "CARGA DE MATERIAS";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Button btnBuscarA;
        internal TextBox txtBusqueda;
        internal DataGridView DataGridView1;
        internal DataGridView DataGridView2;
        internal Button btnActualizar;
        internal Button btnLimpiar;
        internal Button btnRegresar;
        internal Button btnAgregar;
        internal Label Label4;
    }
}