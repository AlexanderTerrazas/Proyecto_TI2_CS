using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{

    public partial class PMaestro
    {
        // Cadena de conexión a la base de datos SQL Server
        private string conn = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True";

        public PMaestro()
        {
            InitializeComponent();
        }
        private void btnRegistroM_Click(object sender, EventArgs e)
        {



            string nombre = txtbNombreM.Text;
            string apellido = txtbApellidoM.Text;
            string correo = txtbCorreoM.Text;

            // Variable para almacenar el nuevo ID
            int nuevoID = ObtenerNuevoID();

            // Insertar los datos en la tabla Profesores
            InsertarDatos(nuevoID, nombre, apellido, correo);
        }

        // Función para obtener el nuevo ID incrementado
        private int ObtenerNuevoID()
        {
            int nuevoID = 0;

            // Consulta SQL para obtener el último ProfesorID
            string consulta = "SELECT MAX(ProfesorID) FROM Profesores";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    // Ejecutar la consulta y obtener el último ProfesorID
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

        // Función para insertar datos en la tabla Profesores
        private void InsertarDatos(int id, string nombre, string apellido, string correo)
        {
            // Consulta SQL para insertar datos en la tabla Profesores
            string consulta = "INSERT INTO Profesores (ProfesorID, Nombre, Apellido, CorreoElectronico) VALUES (@ProfesorID, @Nombre, @Apellido, @Correo)";

            // Crear la conexión y el comando SQL
            using (var conexion = new SqlConnection(conn))
            {
                using (var comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@ProfesorID", id);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellido", apellido);
                    comando.Parameters.AddWithValue("@Correo", correo);
                    conexion.Open();

                    // Ejecutar la consulta para insertar los datos
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados correctamente.");
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}