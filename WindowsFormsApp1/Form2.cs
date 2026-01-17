using System;
using System.Windows.Forms;

namespace ControlPorcino
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvCrianza.Rows.Clear();
        }

        private void btnGuardarCrianza_Click(object sender, EventArgs e)
        {
            string sexo = rbMacho.Checked ? "Macho" : "Hembra";
            string salud = rbSaludable.Checked ? "Saludable" : "Enfermo";

            MessageBox.Show(
            "Registro guardado correctamente",
            "Éxito",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

            dgvCrianza.Rows.Add(
                txtIDCrianza.Text,
                dtpCrianza.Value.ToShortDateString(),
                sexo,
                salud,
                txtObservaciones.Text
            );

            Limpiar();
        }

        private void Limpiar()
        {
            txtIDCrianza.Clear();
            txtObservaciones.Clear();
            rbMacho.Checked = false;
            rbHembra.Checked = false;
            rbSaludable.Checked = false;
            rbEnfermo.Checked = false;
        }

        private void btnVolverCrianza_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        
        private void label2_Click(object sender, EventArgs e) { }
        private void lblSexo_Click(object sender, EventArgs e) { }
        private void rbMacho_CheckedChanged(object sender, EventArgs e) { }
        private void rbHembra_CheckedChanged(object sender, EventArgs e) { }
        private void rbEnfermo_CheckedChanged(object sender, EventArgs e) { }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
