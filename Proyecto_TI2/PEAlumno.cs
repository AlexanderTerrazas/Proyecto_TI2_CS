using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{

    public partial class PEALUMNO
    {

        // Cadena de conexión a la base de datos SQL Server
        private string conn = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True";

        public PEALUMNO()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string busqueda = txtbBusqueda.Text.Trim();

            if (!string.IsNullOrEmpty(busqueda))
            {
                BuscarEnBD(busqueda);
            }
            else
            {
                MessageBox.Show("Ingresa un término de búsqueda.");
            }
        }

        private void BuscarEnBD(string terminoBusqueda)
        {
            // Consulta SQL para buscar en la tabla Estudiantes por el nombre
            string consulta = "SELECT * FROM Estudiantes WHERE Nombre LIKE @Nombre";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", "%" + terminoBusqueda + "%");
                    var tablaResultados = new DataTable();

                    try
                    {
                        conexion.Open();
                        var adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tablaResultados);

                        // Mostrar los resultados en el DataGridView
                        Resultados.DataSource = tablaResultados;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (Resultados.SelectedRows.Count > 0)
            {
                // Obtener el valor de EstudianteID de la fila seleccionada
                int estudianteID = Convert.ToInt32(Resultados.SelectedRows[0].Cells["EstudianteID"].Value);

                // Eliminar la fila correspondiente en la tabla Matricula
                EliminarMatricula(estudianteID);

                // Eliminar la fila de la tabla Estudiantes
                EliminarEstudiante(estudianteID);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

        private void EliminarMatricula(int estudianteID)
        {
            // Consulta SQL para eliminar la fila correspondiente en Matricula
            string consulta = "DELETE FROM Matricula WHERE EstudianteID = @EstudianteID";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@EstudianteID", estudianteID);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Fila eliminada de Matricula.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar de Matricula: " + ex.Message);
                    }
                }
            }
        }

        private void EliminarEstudiante(int estudianteID)
        {
            // Consulta SQL para eliminar la fila correspondiente en Estudiantes
            string consulta = "DELETE FROM Estudiantes WHERE EstudianteID = @EstudianteID";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@EstudianteID", estudianteID);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Fila eliminada de Estudiantes.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar de Estudiantes: " + ex.Message);
                    }
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarDatos()
        {
            // Limpiar el contenido del TextBox
            txtbBusqueda.Text = string.Empty;

            // Limpiar el contenido del DataGridView
            Resultados.DataSource = null;
            Resultados.Rows.Clear();
            Resultados.Columns.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}