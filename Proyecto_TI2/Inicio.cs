using Proyecto_TI2;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class Inicio
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void btnAlumno_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is PAlumno)
                {
                    form.BringToFront(); // Muestra el formulario si está abierto
                    return; // Sale del procedimiento si ya está abierto
                }
            }

            // Si el formulario no está abierto, crea una nueva instancia y lo muestra
            var formularioPAlumno = new PAlumno();
            formularioPAlumno.Show();
        }

        private void btnMaestro_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is PMaestro)
                {
                    form.BringToFront(); // Muestra el formulario si está abierto
                    return; // Sale del procedimiento si ya está abierto
                }
            }

            // Si el formulario no está abierto, crea una nueva instancia y lo muestra
            var formularioPMaestro = new PMaestro();
            formularioPMaestro.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Crear una lista de los formularios abiertos
            List<Form> formsAbiertos = new List<Form>(Application.OpenForms.Count);
            formsAbiertos.AddRange(Application.OpenForms.Cast<Form>());

            // Cerrar los formularios de la lista
            foreach (Form form in formsAbiertos)
            {
                form.Close();
            }

            // Salir de la aplicación
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is PEALUMNO)
                {
                    form.BringToFront(); // Muestra el formulario si está abierto
                    return; // Sale del procedimiento si ya está abierto
                }
            }

            // Si el formulario no está abierto, crea una nueva instancia y lo muestra
            var formularioPEALUMNO = new PEALUMNO();
            formularioPEALUMNO.Show();
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is PEMAESTRO)
                {
                    form.BringToFront(); // Muestra el formulario si está abierto
                    return; // Sale del procedimiento si ya está abierto
                }
            }

            // Si el formulario no está abierto, crea una nueva instancia y lo muestra
            var formularioPEMAESTRO = new PEMAESTRO();
            formularioPEMAESTRO.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            // Verifica si el formulario ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is CLASES)
                {
                    form.BringToFront(); // Muestra el formulario si está abierto
                    return; // Sale del procedimiento si ya está abierto
                }
            }

            // Si el formulario no está abierto, crea una nueva instancia y lo muestra
            var formularioclases = new CLASES();
            formularioclases.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is INSCRIPCION)
                {
                    form.BringToFront(); // Muestra el formulario si está abierto
                    return; // Sale del procedimiento si ya está abierto
                }
            }

            // Si el formulario no está abierto, crea una nueva instancia y lo muestra
            var formularioins = new INSCRIPCION();
            formularioins.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is NOTAS)
                {
                    form.BringToFront(); // Muestra el formulario si está abierto
                    return; // Sale del procedimiento si ya está abierto
                }
            }

            // Si el formulario no está abierto, crea una nueva instancia y lo muestra
            var formularioNOT = new NOTAS();
            formularioNOT.Show();
        }
    }
}