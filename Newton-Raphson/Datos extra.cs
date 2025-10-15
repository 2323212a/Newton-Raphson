using System;
using System.Windows.Forms;

namespace Newton_Raphson
{
    public partial class Datos_extra : Form
    {
        private readonly string funcion;

        public Datos_extra(string funcion)
        {
            InitializeComponent();
            this.funcion = funcion;

            btnEditar.Enabled = false;
            btnSiguiente.Enabled = false;
        }

        private void btninsertarxo_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtX0.Text.Trim(), out double x0))
            {
                MessageBox.Show("Ingrese un valor numérico válido para X₀.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtError.Text.Trim(), out double error) || error <= 0)
            {
                MessageBox.Show("Ingrese un valor positivo para el error tolerado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            panelDatosExtra.Controls.Clear();

            var lblX0 = new Label
            {
                Text = $"X₀ = {x0}",
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10),
                Location = new System.Drawing.Point(10, 10)
            };

            var lblError = new Label
            {
                Text = $"Error tolerado = {error}",
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10),
                Location = new System.Drawing.Point(10, 35)
            };

            panelDatosExtra.Controls.Add(lblX0);
            panelDatosExtra.Controls.Add(lblError);

            txtX0.Enabled = false;
            txtError.Enabled = false;
            btnInsertarX0.Enabled = false;
            btnEditar.Enabled = true;
            btnSiguiente.Enabled = true;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtX0.Enabled = true;
            txtError.Enabled = true;
            btnInsertarX0.Enabled = true;
            btnEditar.Enabled = false;
            btnSiguiente.Enabled = false;
        }

        private void btnerror_Click(object sender, EventArgs e)
        {
            txtX0.Clear();
            txtError.Clear();
            txtX0.Enabled = true;
            txtError.Enabled = true;
            btnInsertarX0.Enabled = true;
            btnEditar.Enabled = false;
            btnSiguiente.Enabled = false;
            panelDatosExtra.Controls.Clear();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtX0.Text.Trim(), out double x0))
            {
                MessageBox.Show("X₀ inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtError.Text.Trim(), out double error) || error <= 0)
            {
                MessageBox.Show("Error tolerado inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tabla tablaForm = new Tabla(funcion, x0, error);
            tablaForm.Show();
            this.Hide();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
