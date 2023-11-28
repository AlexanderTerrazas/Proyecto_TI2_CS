using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{

    public partial class NOTAS
    {
        // Cadena de conexión a la base de datos SQL Server
        private string conn = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True";
        public NOTAS()
        {
            InitializeComponent();
            btnBuscar.Click += btnBuscar_Click;
            btnActualizar.Click += btnActualizar_Click;
        }
        private void BuscarEnBaseDeDatos(string searchTerm)
        {
            string query = "SELECT * FROM Materias WHERE NombreMateria LIKE @searchTerm";

            var dt = new DataTable();

            using (var connection = new SqlConnection(conn))
            {
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // Usamos '%' para buscar coincidencias parciales

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
                            MessageBox.Show("No se encontraron resultados para el término de búsqueda.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBusqueda.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                BuscarEnBaseDeDatos(searchTerm);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un término de búsqueda.");
            }
        }
        private void InitializeDataGridView2()
        {
            // Define las columnas manualmente
            DataGridView2.AutoGenerateColumns = false;

            // Agrega las columnas necesarias (ClaseID, EstudianteID, Nombre, Apellido, Valor)
            // Ajusta los nombres de las columnas y los tipos de datos según tu estructura
            DataGridView2.Columns.Add("ClaseID", "ClaseID");
            DataGridView2.Columns.Add("EstudianteID", "EstudianteID");
            DataGridView2.Columns.Add("Nombre", "Nombre");
            DataGridView2.Columns.Add("Apellido", "Apellido");

            // Columna VALOR editable
            var valorColumn = new DataGridViewTextBoxColumn();
            valorColumn.DataPropertyName = "VALOR"; // Asigna el nombre de la columna en tu DataTable
            valorColumn.HeaderText = "VALOR";
            DataGridView2.Columns.Add(valorColumn);

            // Establece la columna VALOR como editable
            DataGridView2.Columns["VALOR"].ReadOnly = false;
        }
        private void ActualizarDataGridView2(int materiaID)
        {
            // Obtener los valores de ClaseID relacionados con el MateriaID
            var clasesIDs = new List<int>();

            // Consulta para obtener los ClaseID relacionados con el MateriaID en la tabla Clases
            string queryClases = "SELECT ClaseID FROM Clases WHERE MateriaID = @materiaID";

            using (var connection = new SqlConnection(conn))
            {
                using (var cmdClases = new SqlCommand(queryClases, connection))
                {
                    cmdClases.Parameters.AddWithValue("@materiaID", materiaID);

                    try
                    {
                        connection.Open();
                        using (var reader = cmdClases.ExecuteReader())
                        {
                            while (reader.Read())
                                clasesIDs.Add(Convert.ToInt32(reader["ClaseID"]));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los ClaseID: " + ex.Message);
                    }
                }
            }

            // Obtener los EstudianteID relacionados con los ClaseID en la tabla Inscripciones
            var estudiantesIDs = new List<int>();

            foreach (int claseID in clasesIDs)
            {
                string queryInscripciones = "SELECT EstudianteID FROM Inscripciones WHERE ClaseID = @claseID";

                using (var connection = new SqlConnection(conn))
                {
                    using (var cmdInscripciones = new SqlCommand(queryInscripciones, connection))
                    {
                        cmdInscripciones.Parameters.AddWithValue("@claseID", claseID);

                        try
                        {
                            connection.Open();
                            using (var reader = cmdInscripciones.ExecuteReader())
                            {
                                while (reader.Read())
                                    estudiantesIDs.Add(Convert.ToInt32(reader["EstudianteID"]));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al obtener los EstudianteID: " + ex.Message);
                        }
                    }
                }
            }

            // Obtener los datos de Estudiantes relacionados con los EstudianteID
            var dt = new DataTable();

            // Agregar las columnas ClaseID y EstudianteID al DataTable
            dt.Columns.Add("ClaseID", typeof(int));
            dt.Columns.Add("EstudianteID", typeof(int));
            dt.Columns.Add("Nombre", typeof(string)); // Supongamos que obtienes la columna Nombre
            dt.Columns.Add("Apellido", typeof(string)); // Supongamos que obtienes la columna Apellido

            if (estudiantesIDs.Count > 0)
            {
                string queryEstudiantes = "SELECT Estudiantes.Nombre, Estudiantes.Apellido FROM Estudiantes WHERE EstudianteID IN (" + string.Join(",", estudiantesIDs) + ")";

                using (var connection = new SqlConnection(conn))
                {
                    using (var cmdEstudiantes = new SqlCommand(queryEstudiantes, connection))
                    {
                        try
                        {
                            connection.Open();
                            var adapter = new SqlDataAdapter(cmdEstudiantes);
                            adapter.Fill(dt);

                            // Agregar columna 'VALOR'
                            dt.Columns.Add("VALOR", typeof(string));

                            if (dt.Rows.Count > 0)
                            {
                                DataGridView2.AutoGenerateColumns = true;
                                DataGridView2.DataSource = dt;

                                // Establecer la columna VALOR como editable
                                DataGridView2.Columns["VALOR"].ReadOnly = false;

                                // Asignar valores a las columnas ClaseID, EstudianteID, Nombre, Apellido
                                foreach (DataGridViewRow row in DataGridView2.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        // Obtener los valores del DataRow actual
                                        int claseID = Convert.ToInt32(row.Cells["ClaseID"].Value);
                                        int estudianteID = Convert.ToInt32(row.Cells["EstudianteID"].Value);
                                        string nombre = row.Cells["Nombre"].Value.ToString();
                                        string apellido = row.Cells["Apellido"].Value.ToString();

                                        // Asignar los valores a las columnas correspondientes
                                        row.Cells["ClaseID"].Value = claseID;
                                        row.Cells["EstudianteID"].Value = estudianteID;
                                        row.Cells["Nombre"].Value = nombre;
                                        row.Cells["Apellido"].Value = apellido;
                                    }
                                }

                                // Permitir la edición de las celdas en la columna "VALOR"
                                int valorColumnIndex = DataGridView2.Columns["VALOR"].Index;

                                if (valorColumnIndex != -1)
                                {
                                    foreach (DataGridViewRow row in DataGridView2.Rows)
                                    {
                                        if (!row.IsNewRow)
                                        {
                                            row.Cells[valorColumnIndex].ReadOnly = false;
                                        }
                                    }
                                }
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
                MessageBox.Show("No hay EstudianteID relacionados con los ClaseID encontrados.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                int materiaID = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["MateriaID"].Value);
                ActualizarDataGridView2(materiaID);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila en el DataGridView1.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimpiarControles()
        {
            // Limpiar el contenido de los DataGridView
            DataGridView1.DataSource = null;
            DataGridView2.DataSource = null;

            txtBusqueda.Text = string.Empty;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Recorrer el DataGridView2 para obtener los valores a insertar en la tabla Notas
            foreach (DataGridViewRow row in DataGridView2.Rows)
            {
                // Verifica si la fila no es la fila de nuevo ingreso y si tiene valores en las celdas requeridas
                if (!row.IsNewRow && row.Cells["ClaseIDColumn"].Value is not null && row.Cells["EstudianteIDColumn"].Value is not null && row.Cells["VALOR"].Value is not null)
                {
                    int claseID = Convert.ToInt32(row.Cells["ClaseIDColumn"].Value);
                    int estudianteID = Convert.ToInt32(row.Cells["EstudianteIDColumn"].Value);
                    string valorNota = row.Cells["VALOR"].Value.ToString();

                    int ultimoID = ObtenerUltimoIDNot();
                    // Aquí realizas la inserción en la tabla Notas usando los valores obtenidos
                    InsertarNota(claseID, estudianteID, valorNota, ultimoID);
                }
            }
            MessageBox.Show("Datos agregados a la tabla Notas correctamente.");
        }

        private void InsertarNota(int claseID, int estudianteID, string valorNota, int ultimoID)
        {
            string query = "INSERT INTO Notas (NotaID, ClaseID, EstudianteID, Valor) VALUES (♦notaid@ClaseID, @EstudianteID, @Valor)";

            using (var connection = new SqlConnection(conn))
            {
                using (var cmd = new SqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@notaid", ultimoID);
                    cmd.Parameters.AddWithValue("@ClaseID", claseID);
                    cmd.Parameters.AddWithValue("@EstudianteID", estudianteID);
                    cmd.Parameters.AddWithValue("@Valor", valorNota);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar la nueva nota: " + ex.Message);
                    }
                }
            }
        }
        private int ObtenerUltimoIDNot()
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
    }
}