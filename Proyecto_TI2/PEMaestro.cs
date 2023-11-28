using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{

    public partial class PEMAESTRO
    {

        // Cadena de conexión a la base de datos SQL Server
        private string conn = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True";

        public PEMAESTRO()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtbBusqueda.Text.Trim();

            // Consulta SQL para buscar en la tabla Profesores
            string consulta = "SELECT * FROM Profesores WHERE Nombre LIKE '%' + @textoBusqueda + '%'";

            // Crear la conexión y el adaptador de datos
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@textoBusqueda", textoBusqueda);
                    using (var adaptador = new SqlDataAdapter(comando))
                    {
                        var tablaResultados = new DataTable();
                        adaptador.Fill(tablaResultados);

                        // Mostrar los resultados en el DataGridView
                        Resultados.DataSource = tablaResultados;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Resultados.SelectedRows.Count > 0)
            {
                // Obtener el valor de ProfesorID de la fila seleccionada
                int profesorID = Convert.ToInt32(Resultados.SelectedRows[0].Cells["ProfesorID"].Value);

                // Eliminar la fila correspondiente en la tabla Profesores
                EliminarProfesor(profesorID);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

        private void EliminarProfesor(int profesorID)
        {
            // Consulta SQL para eliminar la fila correspondiente en Profesores
            string consulta = "DELETE FROM Profesores WHERE ProfesorID = @ProfesorID";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@ProfesorID", profesorID);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Fila eliminada de Profesores.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar de Profesores: " + ex.Message);
                    }
                }
            }
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}