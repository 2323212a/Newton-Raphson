using System;
using System.Windows.Forms;

namespace Newton_Raphson
{
    public partial class Tabla : Form
    {
        private readonly string funcionOriginal;
        private readonly double x0;
        private readonly double errorTolerado;

        private Label labelFuncion;
        private Label labelX0;
        private Label labelError;

        public Tabla(string funcion, double x0, double errorTolerado)
        {
            InitializeComponent();
            this.funcionOriginal = funcion;
            this.x0 = x0;
            this.errorTolerado = errorTolerado;

            AgregarEtiquetasInformativas();
            InicializarTabla();
            EjecutarMetodo();
        }

        private void AgregarEtiquetasInformativas()
        {
            // Etiqueta de Función
            labelFuncion = new Label
            {
                Text = $"Función: {funcionOriginal}",
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10),
                Location = new System.Drawing.Point(30, 5)
            };

            // Etiqueta de X₀
            labelX0 = new Label
            {
                Text = $"X₀: {x0}",
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10),
                Location = new System.Drawing.Point(200, 5)
            };

            // Etiqueta de Error
            labelError = new Label
            {
                Text = $"Error tolerado: {errorTolerado}%",
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10),
                Location = new System.Drawing.Point(400, 5)
            };

            // Agregar al formulario
            this.Controls.Add(labelFuncion);
            this.Controls.Add(labelX0);
            this.Controls.Add(labelError);
        }

        private void InicializarTabla()
        {
            // Limpiar columnas y preparar encabezados
            dataGridNewton.Columns.Clear();

            dataGridNewton.Columns.Add("Iteracion", "i");
            dataGridNewton.Columns.Add("Xi", "Xi");
            dataGridNewton.Columns.Add("fx", "f(Xi)");
            dataGridNewton.Columns.Add("fpx", "f'(Xi)");
            dataGridNewton.Columns.Add("Xi1", "Xi+1");
            dataGridNewton.Columns.Add("fx1", "f(Xi+1)");
            dataGridNewton.Columns.Add("Error", "Error");

            dataGridNewton.Rows.Clear();
        }

        private void EjecutarMetodo()
        {
            try
            {
                var resultados = NewtonRaphsonSolver.Ejecutar(funcionOriginal, x0, errorTolerado);

                foreach (var r in resultados)
                {
                    dataGridNewton.Rows.Add(
                        r.Iteracion,
                        r.Xi.ToString("F6"),
                        r.Fxi.ToString("F6"),
                        r.Fpxi.ToString("F6"),
                        r.Xi1.ToString("F6"),
                        r.Fx1.ToString("F6"),
                        r.Error.ToString("F6")
                    );
                }

                if (resultados.Count > 0)
                {
                    var final = resultados[resultados.Count - 1];

                    MessageBox.Show(
                        string.Format(
                            "Raíz aproximada encontrada:\n\nXi ≈ {0:F6}\nError ≈ {1:F6}%",
                            final.Xi1,
                            final.Error
                        ),
                        "Resultado final",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el cálculo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
