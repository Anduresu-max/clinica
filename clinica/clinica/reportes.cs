using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace clinica
{
    public partial class reportes : Form
    {

        public reportes()
        {
            InitializeComponent();
        }

        private void reportes_Load(object sender, EventArgs e)
        {
            MostrarTodosLosDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre ingresado por el usuario para la búsqueda
            string nombreBuscar = txtBuscarNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombreBuscar))
            {
                // Si el TextBox de búsqueda está vacío, mostrar todos los datos
                MostrarTodosLosDatos();
            }
            else
            {
                // Realizar la búsqueda en la base de datos y mostrar los resultados
                RealizarBusqueda(nombreBuscar);
            }
        }
        private void MostrarTodosLosDatos()
        {
            // Conectar con la base de datos SQLite
            string databasePath = @"C:\Users\andre\OneDrive\Desktop\clinica_dental.sqlite";
            string connectionString = "Data Source=" + databasePath + ";Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Ejecutar la consulta SQL para obtener todos los datos de la tabla "datos_generales"
                string query = "SELECT Nombre_paciente, Numero_identidad, Fecha_cita FROM datos_generales";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Crear un adaptador para leer los datos
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        // Llenar un DataTable con los resultados de la consulta
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar el DataTable como fuente de datos del DataGridView
                        dataGridViewBuscar.DataSource = dataTable;
                    }
                }
            }
        }
        private void RealizarBusqueda(string nombreBuscar)
        {
            // Conectar con la base de datos SQLite
            string databasePath = @"C:\Users\andre\OneDrive\Desktop\clinica_dental.sqlite";
            string connectionString = "Data Source=" + databasePath + ";Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Ejecutar la consulta SQL para buscar el nombre ingresado
                string query = "SELECT Nombre_paciente, Numero_identidad, Fecha_cita FROM datos_generales WHERE Nombre_paciente LIKE @nombreBuscar";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Usar el parámetro para la búsqueda
                    cmd.Parameters.AddWithValue("@nombreBuscar", "%" + nombreBuscar + "%");

                    // Crear un adaptador para leer los datos
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        // Llenar un DataTable con los resultados de la consulta
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar el DataTable como fuente de datos del DataGridView
                        dataGridViewBuscar.DataSource = dataTable;
                    }
                }
            }
        }
        private void cargarTodosLosDatos()
        {
            // Conexión a la base de datos
            string databasePath = @"C:\Users\andre\OneDrive\Desktop\" + "clinica_dental.sqlite";
            string connectionString = "Data Source=" + databasePath + ";Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Consulta SQL para obtener todos los registros de la tabla "datos_generales"
                    string query = "SELECT nombre_paciente, numero_identidad, fecha_cita FROM datos_generales";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Mostrar los datos en el DataGridView
                            dataGridViewBuscar.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            cargarTodosLosDatos();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void reportes_Load_1(object sender, EventArgs e)
        {

        }

        private void regresar_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}