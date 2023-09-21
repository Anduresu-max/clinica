using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Globalization;
using System.Diagnostics.Eventing.Reader;

namespace clinica
{
    public partial class Buscar : Form
    {
        private SQLiteConnection conn;
        private const string databaseName = "clinica_dental.sqlite";
        private string databasePath;



        public Buscar()
        {
            InitializeComponent();

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
        private void Buscar_Load(object sender, EventArgs e)
        {

            databasePath = @"C:\Users\andre\OneDrive\Desktop\" + databaseName;
            string connectionString = "Data Source=" + databasePath + ";Version=3;";

            conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();
                Console.WriteLine("Conexion establecida con exito");
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error al abrir la conexion:" + ex.Message);
            }

        }
        private void Buscar_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            MostrarDatosGenerales();
            MostrarHistorialClinicaGeneral();
            MostrarHistorialClinicaDental();
            MostrarDiagnostico();

        }

        private void MostrarDatosGenerales()
        {
            string query = "SELECT * FROM datos_generales WHERE nombre_paciente LIKE @nombre_paciente";

            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                string nombrepaciente = txtBuscarNombre.Text.Trim();
                cmd.Parameters.AddWithValue("@nombre_paciente", "%" + nombrepaciente + "%");

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    nombre.Clear();
                    N_identidad.Clear();
                    procedencia.Clear();
                    Nom_representante.Clear();
                    edad.Clear();
                    comboBox_genero.SelectedIndex = -1;
                    telefono.Clear();
                    barrio.Clear();
                    parentezco.Clear();
                    dateTimePicker1.Value = dateTimePicker1.MinDate;
                    num_expediente.Clear();

                    if (reader.Read())
                    {
                        // Mostrar los datos generales en los campos del formulario
                        nombre.Text = reader["nombre_paciente"].ToString();
                        N_identidad.Text = reader["numero_identidad"].ToString();
                        telefono.Text = reader["telefono"].ToString();
                        edad.Text = reader["edad"].ToString();
                        barrio.Text = reader["direccion"].ToString();
                        comboBox_genero.SelectedItem = reader["genero_comboBox"].ToString();
                        procedencia.Text = reader["procedencia"].ToString();
                        dateTimePicker1.Value = DateTime.Parse(reader["fecha_de_nacimiento"].ToString());
                        Nom_representante.Text = reader["nombre_del_representante"].ToString();
                        parentezco.Text = reader["parentezco"].ToString();
                        num_expediente.Text = reader["num_expediente"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("no se encontraron datos para el paciente especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
        private void MostrarHistorialClinicaGeneral()
        {
            comboBoxHospitalizado.Text = "";
            porque.Text = "";
            tratamiento.Text = "";
            Enfermedad.Text = "";
            comboBox_alegias.Text = "";
            medicamentos.Text = "";
            comboBox_fuma.Text = "";
            cuantos_fuma.Text = "";
            comboBox_alchol.Text = "";
            alchol_cuanto.Text = "";
            comboBox_embarazo.Text = "";
            embarazo_cuanto.Text = "";
            checkbox_cardiacos.Checked = false;
            checkbox_presion_alta.Checked = false;
            checkbox_presion_baja.Checked = false;
            checkbox_venereas.Checked = false;
            checkBox_hepa.Checked = false;
            checkBox_ulceras.Checked = false;
            checkBox_dolor_cabeza.Checked = false;
            checkBox_sida.Checked = false;
            checkBox_epilepsia.Checked = false;
            checkBox_artritis.Checked = false;
            checkBox_diabetes.Checked = false;
            checkBox_alteraciones.Checked = false;
            checkBox_sinusitis.Checked = false;
            checkBox_otras.Checked = false;
            observaciones.Text = "";
            comboBox_informe_medico.Text = "";

            string nombrePaciente = nombre.Text;
            string query = "SELECT * FROM Historial_clinica WHERE nombre_paciente = @nombre_paciente";

            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre_paciente", nombrePaciente);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Mostrar los datos en los controles
                        comboBoxHospitalizado.Text = reader["hospitalizado"].ToString();
                        porque.Text = reader["porque"].ToString();
                        tratamiento.Text = reader["tratamiento_por_enfermedad"].ToString();
                        Enfermedad.Text = reader["enfermedad"].ToString();
                        comboBox_alegias.Text = reader["alergias_comboBox"].ToString();
                        medicamentos.Text = reader["medicamentos"].ToString();
                        comboBox_fuma.Text = reader["fuma_comboBox"].ToString();
                        cuantos_fuma.Text = reader["fuma_cuanto"].ToString();
                        comboBox_alchol.Text = reader["alchol_conboBox"].ToString();
                        alchol_cuanto.Text = reader["alchol_cuanto"].ToString();
                        comboBox_embarazo.Text = reader["embarazo_comboBox"].ToString();
                        embarazo_cuanto.Text = reader["cuantos_meses"].ToString();

                        checkbox_cardiacos.Checked = Convert.ToBoolean(reader["checkbox_cardiacos"]);
                        checkbox_presion_alta.Checked = Convert.ToBoolean(reader["checkbox_presion_alta"]);
                        checkbox_presion_baja.Checked = Convert.ToBoolean(reader["checkbox_presion_baja"]);
                        checkbox_venereas.Checked = Convert.ToBoolean(reader["checkbox_venereas"]);
                        checkBox_hepa.Checked = Convert.ToBoolean(reader["checkbox_hepatitis"]);
                        checkBox_ulceras.Checked = Convert.ToBoolean(reader["checkbox_ulceras"]);
                        checkBox_dolor_cabeza.Checked = Convert.ToBoolean(reader["checkbox_dolor_de_cabeza"]);
                        checkBox_sida.Checked = Convert.ToBoolean(reader["checkbox_sida"]);
                        checkBox_epilepsia.Checked = Convert.ToBoolean(reader["checkbox_epilepsia"]);
                        checkBox_artritis.Checked = Convert.ToBoolean(reader["checkbox_artritis"]);
                        checkBox_diabetes.Checked = Convert.ToBoolean(reader["checkbox_diabetes"]);
                        checkBox_alteraciones.Checked = Convert.ToBoolean(reader["checkbox_alteraciones_nerviosas"]);
                        checkBox_sinusitis.Checked = Convert.ToBoolean(reader["checkbox_sinusitis"]);
                        checkBox_otras.Checked = Convert.ToBoolean(reader["checkbox_otras"]);

                        observaciones.Text = reader["observaciones"].ToString();
                        comboBox_informe_medico.Text = reader["comboBox_informe_medico"].ToString();
                    }
                }
            }
        }
        private void MostrarHistorialClinicaDental()
        {
            comboBox_dificultad_hablar.Text = "";
            comboBox_masticar.Text = "";
            comboBox_abrir_boca.Text = "";
            comboBox_alimentos.Text = "";
            comboBox_encias.Text = "";
            comboBox_movilidad_diente.Text = "";
            comboBox_pus.Text = "";
            pus_donde.Text = "";
            cepilla_dientes.Text = "";
            checkBox_buena.Checked = false;
            checkBox_regular.Checked = false;
            checkBox_mala.Checked = false;

            string nombrePaciente = nombre.Text;

            // Consulta SQL para seleccionar los datos de la tabla Historial_clinica_dental
            string query = "SELECT * FROM Historial_clinica_dental WHERE nombre_paciente = @nombre_paciente";

            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre_paciente", nombrePaciente);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        comboBox_dificultad_hablar.Text = reader["dificultad_hablar"].ToString();
                        comboBox_masticar.Text = reader["masticar"].ToString();
                        comboBox_abrir_boca.Text = reader["abrir_boca"].ToString();
                        comboBox_alimentos.Text = reader["tragar"].ToString();
                        comboBox_encias.Text = reader["sangra_encias"].ToString();
                        comboBox_movilidad_diente.Text = reader["movibilidad_diente"].ToString();
                        comboBox_pus.Text = reader["pus"].ToString();
                        pus_donde.Text = reader["donde"].ToString();
                        cepilla_dientes.Text = reader["cepillado"].ToString();
                        checkBox_buena.Checked = Convert.ToBoolean(reader["checkbox_buena"]);
                        checkBox_regular.Checked = Convert.ToBoolean(reader["checkbox_regular"]);
                        checkBox_mala.Checked = Convert.ToBoolean(reader["checkbox_mala"]);
                    }
                }
            }
        }
        // Función para mostrar los datos de la tabla "Diagnostico"
        private void MostrarDiagnostico()
        {
            // Limpiar los controles antes de mostrar los nuevos datos
            diagnostico.Text = "";
            tratamientotxt.Text = "";

            string nombrePaciente = nombre.Text;

            // Consulta SQL para seleccionar los datos de la tabla Diagnostico
            string query = "SELECT * FROM Diagnostico WHERE nombre_paciente = @nombre_paciente";

            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre_paciente", nombrePaciente);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Mostrar los datos en los controles
                        diagnostico.Text = reader["diagnostico_dental"].ToString();
                        tratamientotxt.Text = reader["tratamiento_propuesto"].ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportes reportes = new reportes();
            reportes.Show();
            this.Close();

        }

        private void Informes_Click(object sender, EventArgs e)
        {
            reportes reportes = new reportes();
            reportes.Show();
            this.Close();

        }
    }
}
