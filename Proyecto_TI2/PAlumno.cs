using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{

    public partial class PAlumno
    {
        // Cadena de conexión a la base de datos SQL Server
        private string conn = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True";

        public PAlumno()
        {
            InitializeComponent();
        }
        private void btnRegistroA_Click(object sender, EventArgs e)
        {

            int nuevoIDA = NuevoIDEstudiante();
            if (InsertarEstudiante(nuevoIDA))
            {
                // Si la inserción en la tabla Estudiantes fue exitosa, insertar en Matricula
                int nuevoIDM = NuevoIDMatricula();
                if (nuevoIDM > 0)
                {
                    InsertarMatricula(nuevoIDA, nuevoIDM);
                }
                else
                {
                    MessageBox.Show("No se pudo obtener un nuevo ID para Matricula.");
                }
            }
            else
            {
                MessageBox.Show("La inserción en la tabla Estudiantes falló.");
            }
        }
        private void LimpiarCampos()
        {
            // Limpiar los TextBox
            txtbNombreA.Text = "";
            txtbApellidoA.Text = "";
            txtbCorreo.Text = "";

            // Limpiar las selecciones de los ListBox
            ListBoxCurso.ClearSelected();
            ListBoxPeriodo.ClearSelected();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        // Función para obtener el nuevo ID incrementado
        private int NuevoIDEstudiante()
        {
            int nuevoIDAlumn = 0;

            // Consulta SQL para obtener el último EstudianteID
            string consulta = "SELECT MAX(EstudianteID) FROM Estudiantes";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    // Ejecutar la consulta y obtener el último EstudianteID
                    var resultado = comando.ExecuteScalar();
                    if (!ReferenceEquals(resultado, DBNull.Value))
                    {
                        nuevoIDAlumn = Convert.ToInt32(resultado) + 1;
                    }
                    else
                    {
                        nuevoIDAlumn = 1;
                    } // Si no hay registros, comenzar desde 1
                }
            }

            return nuevoIDAlumn;
        }
        // Función para obtener el nuevo ID incrementado para la matrícula
        private int NuevoIDMatricula()
        {
            int nuevoID = 0;

            // Consulta SQL para obtener el último MatriculaID
            string consulta = "SELECT MAX(MatriculaID) FROM Matricula";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    // Ejecutar la consulta y obtener el último MatriculaID
                    var resultado = comando.ExecuteScalar();
                    if (!ReferenceEquals(resultado, DBNull.Value))
                    {
                        nuevoID = Convert.ToInt32(resultado) + 1;
                    }
                    else
                    {
                        nuevoID = 1;
                    } // Si no hay registros, comenzar desde 1
                }
            }

            return nuevoID;
        }

        // Función para insertar datos en la tabla Estudiantes
        private bool InsertarEstudiante(int nuevoIDA)
        {
            // Consulta SQL para insertar datos en la tabla Estudiantes
            string consulta = "INSERT INTO Estudiantes (EstudianteID, Nombre, Apellido, FechaNacimiento, CorreoElectronico) VALUES (@EstudianteID, @Nombre, @Apellido, @FechaNacimiento, @CorreoElectronico)";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@EstudianteID", nuevoIDA);
                    comando.Parameters.AddWithValue("@Nombre", txtbNombreA.Text);
                    comando.Parameters.AddWithValue("@Apellido", txtbApellidoA.Text);
                    comando.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    comando.Parameters.AddWithValue("@CorreoElectronico", txtbCorreo.Text);
                    conexion.Open();

                    // Ejecutar la consulta para insertar los datos
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados correctamente.");
                }
            }
            return true;
        }
        // Función para insertar datos en la tabla Matricula
        private void InsertarMatricula(int nuevoIDA, int nuevoIDM)
        {
            // Obtener los valores seleccionados de los ListBox
            string curso = ListBoxCurso.SelectedItem.ToString();
            if (ListBoxCurso.SelectedItem is not null)
            {
            }
            // Resto de tu lógica aquí...
            else
            {
                MessageBox.Show("Debes seleccionar un Curso.");
            }
            string periodo = ListBoxPeriodo.SelectedItem.ToString();
            if (ListBoxPeriodo.SelectedItem is not null)
            {
            }
            // Resto de tu lógica aquí...
            else
            {
                MessageBox.Show("Debes seleccionar un período.");
            }


            // Consulta SQL para insertar datos en la tabla Matricula
            string consulta = "INSERT INTO Matricula (MatriculaID, EstudianteID, CursoID, PeriodoID) VALUES (@MatriculaID, @EstudianteID, @Curso, @Periodo)";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@MatriculaID", nuevoIDM);
                    comando.Parameters.AddWithValue("@EstudianteID", nuevoIDA);
                    comando.Parameters.AddWithValue("@Periodo", periodo);
                    comando.Parameters.AddWithValue("@Curso", curso);
                    conexion.Open();

                    // Ejecutar la consulta para insertar los datos
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados correctamente en Matricula.");
                }
            }
        }

        private void PAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}