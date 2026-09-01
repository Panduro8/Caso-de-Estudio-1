using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Eventos que se generaron accidentalmente (puedes dejarlos vacíos)
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }



        private void btnMostrarResumen_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa el nombre del estudiante.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> actividades = new List<string>();
            if (chkDeportes.Checked) actividades.Add("Deportes");
            if (chkMusica.Checked) actividades.Add("Música");
            if (chkArte.Checked) actividades.Add("Arte");
            if (chkProgramacion.Checked) actividades.Add("Programación");
            if (chkLectura.Checked) actividades.Add("Lectura");

            if (actividades.Count == 0)
            {
                MessageBox.Show("Selecciona al menos una actividad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string modalidad = "";
            if (rdoPresencial.Checked) modalidad = "Presencial";
            else if (rdoHibrida.Checked) modalidad = "Híbrida";
            else if (rdoEnLinea.Checked) modalidad = "En línea";

            if (string.IsNullOrEmpty(modalidad))
            {
                MessageBox.Show("Selecciona una modalidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resumen = "RESUMEN DE PREFERENCIAS\r\n";
            resumen += "-------------------------\r\n";
            resumen += $"Nombre: {txtNombre.Text}\r\n";
            resumen += $"Actividades: {string.Join(", ", actividades)}\r\n";
            resumen += $"Modalidad: {modalidad}\r\n";

            txtResumen.Text = resumen;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtResumen.Clear();

            chkDeportes.Checked = false;
            chkMusica.Checked = false;
            chkArte.Checked = false;
            chkProgramacion.Checked = false;
            chkLectura.Checked = false;

            rdoPresencial.Checked = false;
            rdoHibrida.Checked = false;
            rdoEnLinea.Checked = false;
        }
    }
}