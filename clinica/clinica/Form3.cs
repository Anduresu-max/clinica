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
using System.IO;

namespace clinica
{
    public partial class Form3 : Form
    {
        private SQLiteConnection conn;
        private const string databaseName = "clinica_dental.sqlite";

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databasePath = Path.Combine(desktopPath, databaseName);

            if (!File.Exists(databasePath))
            {
                conn = new SQLiteConnection($"Data Source={databasePath};Version=3");
                conn.Open();

                // Create table "datos_generales"
                string createDatosGeneralesTableQuery = "CREATE TABLE IF NOT EXISTS datos_generales (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "nombre_paciente TEXT," +
                    "numero_identidad INTEGER," +
                    "telefono INTEGER," +
                    "edad INTEGER," +
                    "direccion TEXT," +
                    "genero_comboBox TEXT," +
                    "procedencia TEXT," +
                    "fecha_de_nacimiento DATE," +
                    "nombre_del_representante TEXT," +
                    "parentezco TEXT," +
                    "num_expediente INTEGER," +
                    "fecha_cita DATE" +
                    ")";
                ExecuteNonQuery(createDatosGeneralesTableQuery);

                // Create table "Historial_clinica"
                string createHistorialClinicaTableQuery = "CREATE TABLE IF NOT EXISTS Historial_clinica (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "nombre_paciente TEXT," +
                    "numero_identidad INTEGER," +
                    "hospitalizado TEXT," +
                    "porque TEXT," +
                    "tratamiento_por_enfermedad TEXT," +
                    "enfermedad TEXT," +
                    "alergias_comboBox TEXT," +
                    "medicamentos TEXT," +
                    "fuma_comboBox TEXT," +
                    "fuma_cuanto INTEGER," +
                    "alchol_conboBox TEXT," +
                    "alchol_cuanto INTEGER," +
                    "embarazo_comboBox TEXT," +
                    "cuantos_meses INTEGER TEXT," +
                    "checkbox_cardiacos INTEGER," +
                    "checkbox_presion_alta INTEGER," +
                    "checkbox_presion_baja INTEGER," +
                    "checkbox_venereas INTEGER," +
                    "checkbox_hepatitis INTEGER," +
                    "checkbox_ulceras INTEGER," +
                    "checkbox_dolor_de_cabeza INTEGER," +
                    "checkbox_sida INTEGER," +
                    "checkbox_epilepsia INTEGER," +
                    "checkbox_artritis INTEGER," +
                    "checkbox_diabetes INTEGER," +
                    "checkbox_alteraciones_nerviosas INTEGER," +
                    "checkbox_sinusitis INTEGER," +
                    "checkbox_otras INTEGER," +
                    "observaciones TEXT," +
                    "comboBox_informe_medico TEXT," +
                    "FOREIGN KEY (nombre_paciente) REFERENCES datos_generales(nombre_paciente)" +
                    ")";
                ExecuteNonQuery(createHistorialClinicaTableQuery);

                // Create table "Historial_clinica_dental"
                string createHistorialClinicaDentalTableQuery = "CREATE TABLE IF NOT EXISTS Historial_clinica_dental (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "nombre_paciente TEXT," +
                    "numero_identidad INTEGER," +
                    "dificultad_hablar TEXT," +
                    "masticar TEXT," +
                    "abrir_boca TEXT," +
                    "tragar TEXT," +
                    "sangra_encias TEXT," +
                    "movibilidad_diente TEXT," +
                    "pus TEXT," +
                    "donde TEXT," +
                    "cepillado INTEGER," +
                    "checkbox_buena INTEGER," +
                    "checkbox_regular INTEGER," +
                    "checkbox_mala INTEGER," +
                    "FOREIGN KEY (nombre_paciente) REFERENCES datos_generales(nombre_paciente)" +
                    ")";
                ExecuteNonQuery(createHistorialClinicaDentalTableQuery);

                // Create table "Diagnostico"
                string createDiagnosticoTableQuery = "CREATE TABLE IF NOT EXISTS Diagnostico (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "nombre_paciente TEXT," +
                    "numero_identidad INTEGER," +
                    "diagnostico_dental TEXT," +
                    "tratamiento_propuesto TEXT," +
                    "FOREIGN KEY (nombre_paciente) REFERENCES datos_generales(nombre_paciente)" +
                    ")";
                ExecuteNonQuery(createDiagnosticoTableQuery);
            }
            else
            {
                conn = new SQLiteConnection($"Data Source={databasePath};Version=3");
                conn.Open();
            }
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn?.Close();
        }

        private void ExecuteNonQuery(string query)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregara_base_Click(object sender, EventArgs e)
        {
            // Obtener el estado de los CheckBoxes
            int checkbox_cardiacos = this.checkbox_cardiacos.Checked ? 1 : 0;
            int checkbox_presion_alta = checkBox_sanginea_alta.Checked ? 1 : 0;
            int checkbox_presion_baja = checkBox_sanginea_baja.Checked ? 1 : 0;
            int checkbox_venereas = checkBox_venereas.Checked ? 1 : 0;
            int checkBox_hepa = checkBox_hepatitis.Checked ? 1 : 0;
            long numero_identidad;
            long.TryParse(N_identidad.Text, out numero_identidad);
            long telefon;
            long.TryParse(telefono.Text, out telefon);

            // Consulta SQL para insertar los datos en la tabla "datos_generales"
            string insertDatosGeneralesQuery = "INSERT INTO datos_generales (" +
                "nombre_paciente, numero_identidad, telefono, edad, direccion, genero_comboBox, procedencia, " +
                "fecha_de_nacimiento, nombre_del_representante, parentezco, num_expediente , fecha_cita) " +
                "VALUES (@nombre_paciente, @numero_identidad, @telefono, @edad, @direccion, @genero, @procedencia, " +
                "@fecha_de_nacimiento, @nombre_del_representante, @parentezco, @num_expediente , @fecha_cita)";

            using (SQLiteCommand commandDatosGenerales = new SQLiteCommand(insertDatosGeneralesQuery, conn))
            {
                // Set the parameter values
                commandDatosGenerales.Parameters.AddWithValue("@nombre_paciente", nombre.Text);
                commandDatosGenerales.Parameters.AddWithValue("@numero_identidad", numero_identidad);
                commandDatosGenerales.Parameters.AddWithValue("@telefono", telefon);
                commandDatosGenerales.Parameters.AddWithValue("@edad", Convert.ToInt32(edad.Text));
                commandDatosGenerales.Parameters.AddWithValue("@direccion", barrio.Text);
                commandDatosGenerales.Parameters.AddWithValue("@genero", comboBoxGenero.Text);
                commandDatosGenerales.Parameters.AddWithValue("@procedencia", procedencia.Text);
                commandDatosGenerales.Parameters.AddWithValue("@fecha_de_nacimiento", dateTimePicker1.Value.Date);
                commandDatosGenerales.Parameters.AddWithValue("@nombre_del_representante", string.IsNullOrEmpty(Nom_representante.Text) ? null : Nom_representante.Text);
                commandDatosGenerales.Parameters.AddWithValue("@parentezco", string.IsNullOrEmpty(parentezco.Text) ? null : parentezco.Text);
                commandDatosGenerales.Parameters.AddWithValue("@num_expediente", Convert.ToInt32(num_expediente.Text));
                commandDatosGenerales.Parameters.AddWithValue("@fecha_cita", dateTime_cita.Value.Date);

                // Execute the command
                commandDatosGenerales.ExecuteNonQuery();
            }

            //consulta sql para iserta los datos en la tabla 
            string insertHistorialClinicaQuery = "INSERT INTO Historial_clinica (" +
               "nombre_paciente, numero_identidad, hospitalizado, porque, tratamiento_por_enfermedad, enfermedad, " +
               "alergias_comboBox, medicamentos, fuma_comboBox, fuma_cuanto, alchol_conboBox, alchol_cuanto, " +
               "embarazo_comboBox, cuantos_meses, checkbox_cardiacos, checkbox_presion_alta, checkbox_presion_baja, " +
               "checkbox_venereas, checkbox_hepatitis, checkbox_ulceras, checkbox_dolor_de_cabeza, checkbox_sida, " +
               "checkbox_epilepsia, checkbox_artritis, checkbox_diabetes, checkbox_alteraciones_nerviosas, checkbox_sinusitis, " +
               "checkbox_otras, observaciones, comboBox_informe_medico) " +
               "VALUES (@nombre_paciente, @numero_identidad, @hospitalizado, @porque, @tratamiento_por_enfermedad, @enfermedad, " +
               "@alergias_comboBox, @medicamentos, @fuma_comboBox, @fuma_cuanto, @alchol_conboBox, @alchol_cuanto, " +
               "@embarazo_comboBox, @cuantos_meses, @checkbox_cardiacos, @checkbox_presion_alta, @checkbox_presion_baja, " +
               "@checkbox_venereas, @checkbox_hepatitis, @checkbox_ulceras, @checkbox_dolor_de_cabeza, @checkbox_sida, " +
               "@checkbox_epilepsia, @checkbox_artritis, @checkbox_diabetes, @checkbox_alteraciones_nerviosas, @checkbox_sinusitis, " +
               "@checkbox_otras, @observaciones, @comboBox_informe_medico)";
            int? fumaCuantoValue = string.IsNullOrEmpty(cuantos_fuma.Text) ? (int?)null : Convert.ToInt32(cuantos_fuma.Text);
            int? alcholcuantoValue = string.IsNullOrEmpty(alchol_cuanto.Text) ? (int?)null : Convert.ToInt32(alchol_cuanto.Text);
            int? embarazocuantoValue = string.IsNullOrEmpty(embarazo_cuanto.Text) ? (int?)null : Convert.ToInt32(embarazo_cuanto.Text);
            using (SQLiteCommand commandHistorialClinica = new SQLiteCommand(insertHistorialClinicaQuery, conn))
            {
                commandHistorialClinica.Parameters.AddWithValue("@nombre_paciente", nombre.Text);
                commandHistorialClinica.Parameters.AddWithValue("@numero_identidad", numero_identidad);
                commandHistorialClinica.Parameters.AddWithValue("@hospitalizado", comboBoxHospitalizado.Text);
                commandHistorialClinica.Parameters.AddWithValue("@porque", string.IsNullOrEmpty(porque.Text) ? DBNull.Value : (object)porque.Text);
                commandHistorialClinica.Parameters.AddWithValue("@tratamiento_por_enfermedad", string.IsNullOrEmpty(tratamiento.Text) ? DBNull.Value : (object)tratamiento.Text);
                commandHistorialClinica.Parameters.AddWithValue("@enfermedad", string.IsNullOrEmpty(Enfermedad.Text) ? DBNull.Value : (object)Enfermedad.Text);
                commandHistorialClinica.Parameters.AddWithValue("@alergias_comboBox", string.IsNullOrEmpty(comboBox_alegias.Text) ? DBNull.Value : (object)comboBox_alegias.Text);
                commandHistorialClinica.Parameters.AddWithValue("@medicamentos", string.IsNullOrEmpty(medicamentos.Text) ? DBNull.Value : (object)medicamentos.Text);
                commandHistorialClinica.Parameters.AddWithValue("@fuma_comboBox", string.IsNullOrEmpty(comboBox_fuma.Text) ? DBNull.Value : (object)comboBox_fuma.Text);
                commandHistorialClinica.Parameters.AddWithValue("@fuma_cuanto", fumaCuantoValue != null ? (object)fumaCuantoValue : DBNull.Value);
                commandHistorialClinica.Parameters.AddWithValue("@alchol_conboBox", string.IsNullOrEmpty(comboBox_alchol.Text) ? DBNull.Value : (object)comboBox_alchol.Text);
                commandHistorialClinica.Parameters.AddWithValue("@alchol_cuanto", alcholcuantoValue != null ? (object)alcholcuantoValue : DBNull.Value);
                commandHistorialClinica.Parameters.AddWithValue("@embarazo_comboBox", string.IsNullOrEmpty(comboBox_embarazo.Text) ? DBNull.Value : (object)comboBox_embarazo.Text);
                commandHistorialClinica.Parameters.AddWithValue("@cuantos_meses", embarazocuantoValue != null ? (object)embarazocuantoValue : DBNull.Value);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_cardiacos", checkbox_cardiacos);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_presion_alta", checkbox_presion_alta);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_presion_baja", checkbox_presion_baja);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_venereas", checkbox_venereas);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_hepatitis", checkBox_hepa);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_ulceras", checkBox_ulceras.Checked ? 1 : 0);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_dolor_de_cabeza", checkBox_dolor_cabeza.Checked ? 1 : 0);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_sida", checkBox_sida.Checked ? 1 : 0);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_epilepsia", checkBox_epilepsia.Checked ? 1 : 0);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_artritis", checkBox_artritis.Checked ? 1 : 0);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_diabetes", checkBox_diabetes.Checked ? 1 : 0);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_alteraciones_nerviosas", checkBox_alteraciones.Checked ? 1 : 0);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_sinusitis", checkBox_sinusitis.Checked ? 1 : 0);
                commandHistorialClinica.Parameters.AddWithValue("@checkbox_otras", checkBox_otras.Checked ? 1 : 0);
                commandHistorialClinica.Parameters.AddWithValue("@observaciones", observaciones.Text);
                commandHistorialClinica.Parameters.AddWithValue("@comboBox_informe_medico", comboBox_informe_medico.Text);

                // Execute the command
                commandHistorialClinica.ExecuteNonQuery();
            }


            // Guardar datos en la tabla "Historial_clinica_dental"
            string insertHistorialClinicaDentalQuery = "INSERT INTO Historial_clinica_dental (" +
                "nombre_paciente, numero_identidad, dificultad_hablar, masticar, abrir_boca, tragar, " +
                "sangra_encias, movibilidad_diente, pus, donde, cepillado, checkbox_buena, checkbox_regular, checkbox_mala) " +
                "VALUES (@nombre_paciente, @numero_identidad, @dificultad_hablar, @masticar, @abrir_boca, @tragar, " +
                "@sangra_encias, @movibilidad_diente, @pus, @donde, @cepillado, @checkbox_buena, @checkbox_regular, @checkbox_mala)";
            using (SQLiteCommand commandHistorialClinicaDental = new SQLiteCommand(insertHistorialClinicaDentalQuery, conn))
            {
                commandHistorialClinicaDental.Parameters.AddWithValue("@nombre_paciente", nombre.Text);
                commandHistorialClinicaDental.Parameters.AddWithValue("@numero_identidad", numero_identidad);
                commandHistorialClinicaDental.Parameters.AddWithValue("@dificultad_hablar", comboBox_dificultad_hablar.Text);
                commandHistorialClinicaDental.Parameters.AddWithValue("@masticar", comboBox_masticar.Text);
                commandHistorialClinicaDental.Parameters.AddWithValue("@abrir_boca", comboBox_abrir_boca.Text);
                commandHistorialClinicaDental.Parameters.AddWithValue("@tragar", comboBox_alimentos.Text);
                commandHistorialClinicaDental.Parameters.AddWithValue("@sangra_encias", comboBox_encias.Text);
                commandHistorialClinicaDental.Parameters.AddWithValue("@movibilidad_diente", comboBox_movilidad_diente.Text);
                commandHistorialClinicaDental.Parameters.AddWithValue("@pus", comboBox_pus.Text);
                commandHistorialClinicaDental.Parameters.AddWithValue("@donde", pus_donde.Text);
                commandHistorialClinicaDental.Parameters.AddWithValue("@cepillado", Convert.ToInt32(cepilla_dientes.Text));
                commandHistorialClinicaDental.Parameters.AddWithValue("@checkbox_buena", checkBox_buena.Checked ? 1 : 0);
                commandHistorialClinicaDental.Parameters.AddWithValue("@checkbox_regular", checkBox_regular.Checked ? 1 : 0);
                commandHistorialClinicaDental.Parameters.AddWithValue("@checkbox_mala", checkBox_mala.Checked ? 1 : 0);

                // Execute the command
                commandHistorialClinicaDental.ExecuteNonQuery();
            }

            // Guardar datos en la tabla "Diagnostico"
            string insertDiagnosticoQuery = "INSERT INTO Diagnostico (" +
                "nombre_paciente, numero_identidad, diagnostico_dental, tratamiento_propuesto) " +
                "VALUES (@nombre_paciente, @numero_identidad, @diagnostico_dental, @tratamiento_propuesto)";
            // Ejecutar las consultas para guardar datos en todas las tablas
            using (SQLiteCommand commandDiagnostico = new SQLiteCommand(insertDiagnosticoQuery, conn))
            {
                commandDiagnostico.Parameters.AddWithValue("@nombre_paciente", nombre.Text);
                commandDiagnostico.Parameters.AddWithValue("@numero_identidad", numero_identidad);
                commandDiagnostico.Parameters.AddWithValue("@diagnostico_dental", diagnostico.Text);
                commandDiagnostico.Parameters.AddWithValue("@tratamiento_propuesto", tratamiento.Text);

                // Execute the command
                commandDiagnostico.ExecuteNonQuery();
            }



            MessageBox.Show("Datos guardados correctamente en todas las tablas.");

            conn.Close();
        }
    }
}