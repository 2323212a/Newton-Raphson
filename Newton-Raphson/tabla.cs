using System;
using System.Windows.Forms;
using NCalc; // Asegúrate de haberlo instalado por NuGet

namespace Newton_Raphson
{
    public partial class Tabla : Form
    {
        private string funcionOriginal;
        private double x0;
        private double errorTolerado;

        public Tabla(string funcion, double x0, double errorTolerado)
        {
            InitializeComponent(); // siempre va primero

            this.funcionOriginal = NormalizarFuncion(funcion);
            this.x0 = x0;
            this.errorTolerado = errorTolerado;

            InicializarTabla(); // asegurarte de que se llame aquí
            EjecutarNewtonRaphson();
        }

        // ✅ Normaliza potencias Unicode (x⁴ → x^4)
        private string NormalizarFuncion(string funcion)
        {
            return funcion
                .Replace("⁴", "^4")
                .Replace("³", "^3")
                .Replace("²", "^2")
                .Replace("¹", "^1")
                .Replace("⁰", "^0")
                .Replace("–", "-")
                .Replace("−", "-");
        }

        // ✅ Inicializa columnas del DataGrid
        private void InicializarTabla()
        {
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

        // ✅ Método Newton-Raphson principal
        private void EjecutarNewtonRaphson()
        {
            int i = 0;
            double xi = x0;
            double error = 100;

            while (error > errorTolerado && i < 100)
            {
                double fx = EvaluarFuncion(funcionOriginal, xi);
                string derivada = DerivarFuncion(funcionOriginal);
                double fpx = EvaluarFuncion(derivada, xi);

                if (fpx == 0)
                {
                    MessageBox.Show("La derivada se hizo cero en la iteración " + i + ". No se puede continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }

                double xi1 = xi - (fx / fpx);
                double fx1 = EvaluarFuncion(funcionOriginal, xi1);
                error = Math.Abs((xi1 - xi) / xi1) * 100;

                dataGridNewton.Rows.Add(
                    i,
                    xi.ToString("F6"),
                    fx.ToString("F6"),
                    fpx.ToString("F6"),
                    xi1.ToString("F6"),
                    fx1.ToString("F6"),
                    error.ToString("F6")
                );

                xi = xi1;
                i++;
            }

            if (i >= 100)
            {
                MessageBox.Show("El método no converge después de 100 iteraciones.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ✅ Evaluación segura usando NCalc con parámetro
        private double EvaluarFuncion(string funcion, double x)
        {
            try
            {
                var expr = new Expression(funcion);
                expr.Parameters["x"] = x;
                return Convert.ToDouble(expr.Evaluate());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al evaluar la función:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        // ✅ Derivada manual básica para polinomios
        private string DerivarFuncion(string funcion)
        {
            string derivada = "";
            funcion = funcion.Replace(" ", "").Replace("-", "+-");
            var terminos = funcion.Split('+');

            foreach (var term in terminos)
            {
                if (string.IsNullOrWhiteSpace(term)) continue;

                if (term.Contains("x^"))
                {
                    var partes = term.Split(new[] { "x^" }, StringSplitOptions.None);
                    if (!double.TryParse(partes[0], out double coef)) coef = 1;
                    if (!int.TryParse(partes[1], out int exp)) continue;

                    double nuevoCoef = coef * exp;
                    int nuevoExp = exp - 1;

                    if (nuevoExp == 1)
                        derivada += $"{nuevoCoef}*x+";
                    else if (nuevoExp == 0)
                        derivada += $"{nuevoCoef}+";
                    else
                        derivada += $"{nuevoCoef}*x^{nuevoExp}+";
                }
                else if (term.Contains("x"))
                {
                    string coefStr = term.Replace("x", "");
                    double coef = string.IsNullOrEmpty(coefStr) || coefStr == "+" ? 1 :
                                  coefStr == "-" ? -1 : double.Parse(coefStr);
                    derivada += $"{coef}+";
                }
            }

            if (derivada.EndsWith("+"))
                derivada = derivada.Substring(0, derivada.Length - 1);

            return derivada;
        }

        private void dataGridNewton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
