using MySql.Data.MySqlClient;

namespace BaseDatos_PRACTICA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Acceder_Click(object sender, EventArgs e)
        {
    
            try
            {
                string user = textoUsuario.Text.Trim();
                string password = textoContrasena.Text.Trim();

                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
                {
                    labelConexion.Text = "Por favor ingresa usuario y contraseña.";
                    return;
                }

                string server = "localhost";
                string user1 = "root";
                string database = "empleados";

                // Cadena de conexión con los datos ingresados
                string cadenaConexion = $"server={server};port=3307;database={database};user={user1};password={password};";

                // Se crea una instancia de la conexión utilizando la cadena generada
                MySqlConnection myConnection = new MySqlConnection(cadenaConexion);

                // Se intenta abrir la conexión con la base de datos
                myConnection.Open();

                labelConexion.Text = "Conexión exitosa.";

                // Ocultar la interfaz actual
                this.Hide();

                // Mostrar el form 2
                Form2 formulario2 = new Form2(myConnection);
                formulario2.ShowDialog();

                // Al cerrar form 2 se cierra todo
                myConnection.Close();
                this.Close();
            }
            catch (Exception error)
            {
                // Si ocurre un error, se captura aquí
                labelConexion.Text = "Error de conexión: " + error.Message;
            }
        }


    }
}

