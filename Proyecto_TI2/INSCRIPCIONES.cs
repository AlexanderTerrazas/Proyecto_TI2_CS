using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{

    public partial class INSCRIPCION
    {
        // Cadena de conexión a la base de datos SQL Server
        private string conn = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True";

        public INSCRIPCION()
        {
            InitializeComponent();
            btnBuscarA.Click += btnBuscarA_Click;
            btnActualizar.Click += btnActualizar_Click;
        }
        private void btnBuscarA_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBusqueda.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                int estudianteID = ObtenerEstudianteID(searchTerm);

                if (estudianteID != -1)
                {
                    string query = "SELECT Estudiantes.EstudianteID, Estudiantes.Nombre, Estudiantes.Apellido, Matricula.CursoID " + "FROM Estudiantes INNER JOIN Matricula ON Estudiantes.EstudianteID = Matricula.EstudianteID " + "WHERE Estudiantes.EstudianteID = @estudianteID";

                    var dt = new DataTable();

                    using (var connection = new SqlConnection(conn))
                    {
                        using (var cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@estudianteID", estudianteID);

                            try
                            {
                                connection.Open();
                                var adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);

                                if (dt.Rows.Count > 0)
                                {
                                    DataGridView1.DataSource = dt;
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron resultados en la tabla Matricula.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el estudiante en la tabla Estudiantes.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un término de búsqueda.");
            }
        }

        private int ObtenerEstudianteID(string searchTerm)
        {
            int estudianteID = -1;
            string query = "SELECT EstudianteID FROM Estudiantes WHERE Nombre = @searchTerm";

            using (var connection = new SqlConnection(conn))
            {
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", searchTerm);

                    try
                    {
                        connection.Open();
                        var result = cmd.ExecuteScalar();

                        if (result is not null && !(result is DBNull))
                        {
                            estudianteID = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el ID del estudiante: " + ex.Message);
                    }
                }
            }

            return estudianteID;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView1
            if (DataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el valor seleccionado de la columna CursoID en el DataGridView1
                int cursoID = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["CursoID"].Value);

                // Realiza la consulta para obtener los datos de Clases, Profesores y Materias
                string query = "SELECT Clases.ClaseID, Clases.CursoID, Profesores.Nombre, Materias.NombreMateria " + "FROM Clases " + "INNER JOIN Profesores ON Clases.ProfesorID = Profesores.ProfesorID " + "INNER JOIN Materias ON Clases.MateriaID = Materias.MateriaID " + "WHERE Clases.CursoID = @cursoID";

                // Crea un DataTable para almacenar los resultados
                var dt = new DataTable();

                // Conecta con la base de datos y ejecuta la consulta
                using (var connection = new SqlConnection(conn))
                {
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cursoID", cursoID);

                        try
                        {
                            connection.Open();
                            var adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            // Verifica si se encontraron resultados
                            if (dt.Rows.Count > 0)
                            {
                                DataGridView2.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron resultados para el CursoID seleccionado en la tabla Clases.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al obtener datos de la base de datos: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila en el DataGridView1.");
            }
        }

        private int ObtenerUltimoIDIns()
        {
            int ultimoID = 0;
            string consulta = "SELECT MAX(ClaseID) FROM Inscripciones";

            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    try
                    {
                        conexion.Open();
                        var resultado = comando.ExecuteScalar();

                        if (!ReferenceEquals(resultado, DBNull.Value))
                        {
                            ultimoID = Convert.ToInt32(resultado) + 1;
                        }
                        else
                        {
                            ultimoID = 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el último ID de Inscripciones: " + ex.Message);
                    }
                }
            }

            return ultimoID;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView1 y DataGridView2
            if (DataGridView1.SelectedRows.Count > 0 && DataGridView2.SelectedRows.Count > 0)
            {
                // Obtiene el valor seleccionado de las columnas EstudianteID y ClaseID
                int estudianteID = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["EstudianteID"].Value);
                int claseID = Convert.ToInt32(DataGridView2.SelectedRows[0].Cells["ClaseID"].Value);

                // Obtiene el último ID de Inscripciones
                int ultimoID = ObtenerUltimoIDIns();

                // Realiza la inserción en la tabla Inscripciones con el último ID
                InsertarInscripcion(estudianteID, claseID, ultimoID);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila en ambos DataGridViews.");
            }
        }

        private void InsertarInscripcion(int estudianteID, int claseID, int ultimoID)
        {
            // Consulta SQL para insertar datos en la tabla Inscripciones
            string consulta = "INSERT INTO Inscripciones (InscripcionID, EstudianteID, ClaseID) VALUES (@InscripcionID, @EstudianteID, @ClaseID)";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@InscripcionID", ultimoID);
                    comando.Parameters.AddWithValue("@EstudianteID", estudianteID);
                    comando.Parameters.AddWithValue("@ClaseID", claseID);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Inscripción agregada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar en la tabla Inscripciones: " + ex.Message);
                    }
                }
            }
        }
        private void LimpiarControles()
        {
            // Limpiar el contenido de los DataGridView
            DataGridView1.DataSource = null;
            DataGridView2.DataSource = null;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}