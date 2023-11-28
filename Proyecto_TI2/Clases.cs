using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{

    public partial class CLASES
    {
        // Cadena de conexión a la base de datos SQL Server
        private string conn = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True";



        private void TuFormulario_Load(object sender, EventArgs e)
        {

        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }


        private void MostrarMaestros()
        {
            string consulta = "SELECT ProfesorID, Nombre, Apellido FROM Profesores";

            using (var conexion = new SqlConnection(conn))
            {
                using (var adaptador = new SqlDataAdapter(consulta, conexion))
                {
                    var tablaMaestros = new DataTable();

                    try
                    {
                        conexion.Open();
                        adaptador.Fill(tablaMaestros);
                        ResultadosP.DataSource = tablaMaestros;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al mostrar maestros: " + ex.Message);
                    }
                }
            }
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            MostrarMaestros();
        }
        private void MostrarMaterias()
        {
            string consulta = "SELECT MateriaID, NombreMateria FROM Materias";

            using (var conexion = new SqlConnection(conn))
            {
                using (var adaptador = new SqlDataAdapter(consulta, conexion))
                {
                    var tablaMaterias = new DataTable();

                    try
                    {
                        conexion.Open();
                        adaptador.Fill(tablaMaterias);
                        ResultadosM.DataSource = tablaMaterias;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al mostrar materias: " + ex.Message);
                    }
                }
            }
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            MostrarMaterias();
        }

        private int ObtenerUltimoIDClase()
        {
            int ultimoID = 0;
            string consulta = "SELECT MAX(ClaseID) FROM Clases";

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
                        MessageBox.Show("Error al obtener el último ID de clase: " + ex.Message);
                    }
                }
            }

            return ultimoID;
        }

        private bool InsertarClase(int ultimoID)
        {
            int profesorID = Convert.ToInt32(ResultadosP.CurrentRow.Cells["ProfesorID"].Value);
            int materiaID = Convert.ToInt32(ResultadosM.CurrentRow.Cells["MateriaID"].Value);
            string Curso = ComboBox1.SelectedItem.ToString();

            string consulta = "INSERT INTO Clases (ClaseID, CursoID, ProfesorID, MateriaID) VALUES (@ClaseID, @curso, @ProfesorID, @MateriaID)";

            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@ClaseID", ultimoID);
                    comando.Parameters.AddWithValue("@ProfesorID", profesorID);
                    comando.Parameters.AddWithValue("@MateriaID", materiaID);
                    comando.Parameters.AddWithValue("@curso", Curso);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Clase agregada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar la clase: " + ex.Message);
                    }
                }
            }

            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int ultimoIDClase = ObtenerUltimoIDClase();

            if (ResultadosP.CurrentRow is not null && ResultadosM.CurrentRow is not null && ComboBox1.SelectedItem is not null)
            {
                InsertarClase(ultimoIDClase);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un profesor, una materia y un curso.");
            }
        }
        private void LimpiarControles()
        {
            // Limpiar el contenido de los DataGridView
            ResultadosP.DataSource = null;
            ResultadosM.DataSource = null;

            // Limpiar la selección del ComboBox y establecer el índice en -1
            ComboBox1.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
