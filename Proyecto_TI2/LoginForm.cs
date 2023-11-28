using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{

    public partial class LoginForm
    {

        // Cadena de conexión a la base de datos SQL Server
        private string Conn = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void AccederButton_Click(object sender, EventArgs e)
        {
            string usuario = txtbUsuario.Text;
            string password = txtbPassword.Text;

            if (ValidarCredenciales(usuario, password))
            {
                Inicio inicioForm = new Inicio();
                inicioForm.Show();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }
        }

        private bool ValidarCredenciales(string usuario, string password)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @usuario AND Contraseña = @password";
            using (var connection = new SqlConnection(Conn))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            txtbUsuario.Text = "";
            txtbPassword.Text = "";
        }
    }
}