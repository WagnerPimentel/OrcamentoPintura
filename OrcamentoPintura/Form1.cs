namespace OrcamentoPintura
{
    public partial class Form1 : Form
    {
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = Convert.ToDouble(textBox1.Text);
                double largura = Convert.ToDouble(textBox2.Text);
                double precoPorMetroQuadrado = Convert.ToDouble(textBox3.Text);
                int numeroDeDemaos = Convert.ToInt32(textBox4.Text);

                if (altura <= 0 || largura <= 0 || precoPorMetroQuadrado <= 0 || numeroDeDemaos <= 0)
                {
                    MessageBox.Show("Por favor, insira valores maiores que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double areaTotal = altura * largura * numeroDeDemaos;

                double custoTotal = areaTotal * precoPorMetroQuadrado;

                label5.Text = "Resultado: R$ " + custoTotal.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}