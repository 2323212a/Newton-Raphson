using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newton_Raphson
{
    public partial class Datos_extra : Form
    {
       
            private string funcion;
        private readonly string funcionRecibida;

        public Datos_extra(string funcion)
            {
                InitializeComponent();
                this.funcion = funcion;

                // Puedes mostrarla en un label, por ejemplo
                // labelFuncion.Text = funcion;
            }
          private void btninsertarxo_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtXi.Text.Trim(), out double x0))
            {
                MessageBox.Show("Ingrese un valor numérico válido para X₀.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtError.Text.Trim(), out double error) || error <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico positivo para el error tolerado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bloquea los TextBox y botones como antes
            txtXi.Enabled = false;
            txtError.Enabled = false;
            btninsertarxo.Enabled = false;
            btneditar.Enabled = true;
            btnSiguiente.Enabled = true;

            // Limpia el panel y agrega etiquetas con los valores actuales
            paneldatosextra.Controls.Clear();

            Label lblXi = new Label
            {
                Text = $"X₀ = {x0}",
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10)
            };

            Label lblError = new Label
            {
                Text = $"Error tolerado = {error}",
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10),
                Top = lblXi.Bottom + 5 // un poco de separación vertical
            };

            paneldatosextra.Controls.Add(lblXi);
            paneldatosextra.Controls.Add(lblError);

            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnerror_Click(object sender, EventArgs e)
        {
            txtXi.Clear();
            txtError.Clear();

            txtXi.Enabled = true;
            txtError.Enabled = true;

            btninsertarxo.Enabled = true;
            btneditar.Enabled = false;
            btnSiguiente.Enabled = false;
        }

        private void txtXi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtError_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtXi.Enabled = true;
            txtError.Enabled = true;

            btninsertarxo.Enabled = true;  // habilitar guardar
            btneditar.Enabled = false;      // deshabilitar editar
            btnSiguiente.Enabled = false;   // deshabilitar siguiente
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Validar que txtXi no esté vacío y contenga un número válido
            if (string.IsNullOrWhiteSpace(txtXi.Text) || !double.TryParse(txtXi.Text.Trim(), out double x0))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para X₀.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que txtError no esté vacío y contenga un número positivo
            if (string.IsNullOrWhiteSpace(txtError.Text) || !double.TryParse(txtError.Text.Trim(), out double error) || error <= 0)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico positivo para el error tolerado.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Continuar si todo está validado
            Tabla tablaForm = new Tabla(funcionRecibida, x0, error);
            tablaForm.Show();
            this.Hide(); // o this.Close(); si quieres cerrarlo en lugar de ocultarlo
        }

        private void paneldatosextra_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
