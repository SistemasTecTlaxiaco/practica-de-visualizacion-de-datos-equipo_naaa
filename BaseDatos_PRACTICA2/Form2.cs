using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaseDatos_PRACTICA2
{
    public partial class Form2 : Form
    {
        private MySqlConnection conect;
        private string idSeleccionado = "";

        public Form2(MySqlConnection conect)
        {
            InitializeComponent();
            this.conect = conect;
        }
        private void CargarDatos(

            string nombre = "", string apellidoP = "", string apellidoM = "",
            string puesto = "", string departamento = "", string edad = "",
            string email = "", string telefono = "")
        {
            try
            {
                List<string> condiciones = new List<string>();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conect;

                if (!string.IsNullOrEmpty(nombre))
                {
                    condiciones.Add("Nombre LIKE @nombre");
                    comando.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                }
                if (!string.IsNullOrEmpty(apellidoP))
                {
                    condiciones.Add("ApellidoP LIKE @apellidoP");
                    comando.Parameters.AddWithValue("@apellidoP", "%" + apellidoP + "%");
                }
                if (!string.IsNullOrEmpty(apellidoM))
                {
                    condiciones.Add("ApellidoM LIKE @apellidoM");
                    comando.Parameters.AddWithValue("@apellidoM", "%" + apellidoM + "%");
                }
                if (!string.IsNullOrEmpty(puesto))
                {
                    condiciones.Add("Puesto LIKE @puesto");
                    comando.Parameters.AddWithValue("@puesto", "%" + puesto + "%");
                }
                if (!string.IsNullOrEmpty(departamento))
                {
                    condiciones.Add("Departamento LIKE @departamento");
                    comando.Parameters.AddWithValue("@departamento", "%" + departamento + "%");
                }
                if (!string.IsNullOrEmpty(edad))
                {
                    condiciones.Add("Edad LIKE @edad");
                    comando.Parameters.AddWithValue("@edad", "%" + edad + "%");
                }
                if (!string.IsNullOrEmpty(email))
                {
                    condiciones.Add("email LIKE @email");
                    comando.Parameters.AddWithValue("@email", "%" + email + "%");
                }
                if (!string.IsNullOrEmpty(telefono))
                {
                    condiciones.Add("telefono LIKE @telefono");
                    comando.Parameters.AddWithValue("@telefono", "%" + telefono + "%");
                }

                string where = condiciones.Count > 0 ? "WHERE " + string.Join(" AND ", condiciones) : "";

                comando.CommandText = $@"
                         SELECT id_trabajador, Nombre, ApellidoP, ApellidoM, Puesto, Departamento, Edad, email, telefono
                         FROM trabajadores
                        {where}";

                MySqlDataReader reader = comando.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["id_trabajador"].ToString(),
                        reader["Nombre"].ToString(),
                        reader["ApellidoP"].ToString(),
                        reader["ApellidoM"].ToString(),
                        reader["Puesto"].ToString(),
                        reader["Departamento"].ToString(),
                        reader["Edad"].ToString(),
                        reader["email"].ToString(),
                        reader["telefono"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            string apellidoP = textBoxAp1.Text.Trim();
            string apellidoM = textBoxAp2.Text.Trim();
            string puesto = textBoxPuesto.Text.Trim();
            string departamento = textBoxDep.Text.Trim();
            string edad = textBoxEdad.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string telefono = textBoxTel.Text.Trim();

            CargarDatos(nombre, apellidoP, apellidoM, puesto, departamento, edad, email, telefono);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsetar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            string apellidoP = textBoxAp1.Text.Trim();
            string apellidoM = textBoxAp2.Text.Trim();
            string puesto = textBoxPuesto.Text.Trim();
            string departamento = textBoxDep.Text.Trim();
            string edad = textBoxEdad.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string telefono = textBoxTel.Text.Trim();

            CargarDatos(nombre, apellidoP, apellidoM, puesto, departamento, edad, email, telefono);
            //Console.WriteLine("Registro insertado correctamente");
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxAp1.Clear();
            textBoxAp2.Clear();
            textBoxPuesto.Clear();
            textBoxDep.Clear();
            textBoxEdad.Clear();
            textBoxEmail.Clear();
            textBoxTel.Clear();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idSeleccionado))
            {
                DialogResult resultado = MessageBox.Show(
                    "No hay ninguna fila seleccionada.\n¿Deseas eliminar *todos* los registros?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM trabajadores";

                        using (MySqlCommand comando = new MySqlCommand(query, conect))
                        {
                            comando.ExecuteNonQuery();
                        }

                        MessageBox.Show("Todos los registros fueron eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar todos los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar el registro seleccionado?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM trabajadores WHERE id_trabajador = @id";

                        using (MySqlCommand comando = new MySqlCommand(query, conect))
                        {
                            comando.Parameters.AddWithValue("@id", idSeleccionado);
                            comando.ExecuteNonQuery();
                        }

                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idSeleccionado = "";
                        LimpiarCampos();
                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                idSeleccionado = fila.Cells[0].Value.ToString();
                textBoxNombre.Text = fila.Cells[1].Value.ToString();
                textBoxAp1.Text = fila.Cells[2].Value.ToString();
                textBoxAp2.Text = fila.Cells[3].Value.ToString();
                textBoxPuesto.Text = fila.Cells[4].Value.ToString();
                textBoxDep.Text = fila.Cells[5].Value.ToString();
                textBoxEdad.Text = fila.Cells[6].Value.ToString();
                textBoxEmail.Text = fila.Cells[7].Value.ToString();
                textBoxTel.Text = fila.Cells[8].Value.ToString();
            }
        }

        private void btnEditar_Click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idSeleccionado))
            {
                MessageBox.Show("Selecciona un registro primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
            UPDATE trabajadores SET
                Nombre = @nombre,
                ApellidoP = @apellidoP,
                ApellidoM = @apellidoM,
                Puesto = @puesto,
                Departamento = @departamento,
                Edad = @edad,
                email = @correo,
                telefono = @telefono
            WHERE id_trabajador = @id";

                using (MySqlCommand comando = new MySqlCommand(query, conect))
                {
                    comando.Parameters.AddWithValue("@id", idSeleccionado);
                    comando.Parameters.AddWithValue("@nombre", textBoxNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@apellidoP", textBoxAp1.Text.Trim());
                    comando.Parameters.AddWithValue("@apellidoM", textBoxAp2.Text.Trim());
                    comando.Parameters.AddWithValue("@puesto", textBoxPuesto.Text.Trim());
                    comando.Parameters.AddWithValue("@departamento", textBoxDep.Text.Trim());
                    comando.Parameters.AddWithValue("@edad", textBoxEdad.Text.Trim());
                    comando.Parameters.AddWithValue("@correo", textBoxEmail.Text.Trim());
                    comando.Parameters.AddWithValue("@telefono", textBoxTel.Text.Trim());

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarDatos(); // Recargar datos en el DataGridView
                        idSeleccionado = "";
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }



