using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Newton_Raphson
{
    public partial class Form1 : Form
    {
        private string funcionPotenciaCuarta = null;

        public Form1()
        {
            InitializeComponent();
            Panelpreedicion.Visible = false;
            btnEditar.Enabled = false;
            btnsiguiente.Enabled = false;
        }

        private void btninsertar_Click_1(object sender, EventArgs e)
        {
            // Obtener coeficientes con su índice de grado
            var coeficientes = new Dictionary<int, string>
            {
                { 4, textBox1.Text.Trim() },
                { 3, textBox2.Text.Trim() },
                { 2, textBox3.Text.Trim() },
                { 1, textBox4.Text.Trim() },
                { 0, textBox5.Text.Trim() }
            };

            bool hayAlMenosUnCoeficiente = false;
            List<string> partesFuncion = new List<string>();

            foreach (var kvp in coeficientes)
            {
                int grado = kvp.Key;
                string coef = kvp.Value;

                if (!string.IsNullOrWhiteSpace(coef))
                {
                    hayAlMenosUnCoeficiente = true;

                    if (!double.TryParse(coef, out double valorNumerico))
                    {
                        MessageBox.Show($"Coeficiente inválido en x^{grado}. Asegúrate de ingresar números válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string termino = ConstruirTermino(valorNumerico, grado, partesFuncion.Count == 0);
                    if (!string.IsNullOrEmpty(termino))
                        partesFuncion.Add(termino);
                }
            }

            if (!hayAlMenosUnCoeficiente)
            {
                MessageBox.Show("Ingrese al menos un coeficiente válido para la función de potencia cuarta.");
                return;
            }

            funcionPotenciaCuarta = string.Join(" ", partesFuncion);

            // Mostrar la función
            Panelpreedicion.Controls.Clear();
            var lblFuncion = new Label
            {
                Text = funcionPotenciaCuarta,
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 12)
            };
            Panelpreedicion.Controls.Add(lblFuncion);
            Panelpreedicion.Visible = true;

            // Desactivar textboxes
            BloquearTextBoxes();

            // Activar botones
            btnEditar.Enabled = true;
            btnsiguiente.Enabled = true;
        }

        // Construcción de términos con potencias unicode y sin "+" inicial
        private string ConstruirTermino(double coef, int grado, bool esPrimerTermino)
        {
            if (coef == 0) return string.Empty;

            string signo = coef > 0 ? (esPrimerTermino ? "" : "+") : "-";
            double valorAbs = Math.Abs(coef);

            string coefStr = (valorAbs == 1 && grado != 0) ? "" : valorAbs.ToString();

            string potenciaUnicode = "";

            switch (grado)
            {
                case 4:
                    potenciaUnicode = "x⁴";
                    break;
                case 3:
                    potenciaUnicode = "x³";
                    break;
                case 2:
                    potenciaUnicode = "x²";
                    break;
                case 1:
                    potenciaUnicode = "x";
                    break;
                case 0:
                    potenciaUnicode = "";
                    break;
                default:
                    potenciaUnicode = $"x^{grado}";
                    break;
            }


            return $"{signo} {coefStr}{potenciaUnicode}".Trim();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DesbloquearTextBoxes();
            textBox1.Focus();
        }

        private void btnborrar_Click_1(object sender, EventArgs e)
        {
            funcionPotenciaCuarta = null;
            Panelpreedicion.Controls.Clear();
            Panelpreedicion.Visible = false;

            // Limpiar textboxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            // Desbloquear para edición
            DesbloquearTextBoxes();

            // Desactivar botones
            btnEditar.Enabled = false;
            btnsiguiente.Enabled = false;
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(funcionPotenciaCuarta))
            {
                MessageBox.Show("Debe ingresar una función válida antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Datos_extra siguiente = new Datos_extra(funcionPotenciaCuarta);
            siguiente.Show();


        }

        // Métodos de bloqueo/desbloqueo
        private void BloquearTextBoxes()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void DesbloquearTextBoxes()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }
    }
}
