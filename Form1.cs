namespace WinFormsMicroondas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }

            // Verifica se a tecla Enter foi pressionada
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Valida e formata o texto da caixa de texto
                string[] tempo = textBoxTempo.Text.Split(':');
                if (tempo.Length == 2)
                {
                    if (int.TryParse(tempo[0], out int minutos) && int.TryParse(tempo[1], out int segundos))
                    {
                        if (minutos >= 0 && minutos <= 2 && segundos >= 0 && segundos <= 59)
                        {
                            // Formata o tempo como "mm:ss"
                            textBoxTempo.Text = string.Format("{0:00}:{1:00}", minutos, segundos);
                        }
                        else
                        {
                            MessageBox.Show("Tempo fora do intervalo permitido (1 segundo a 2 minutos).");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tempo inv�lido.");
                    }
                }
                else
                {
                    MessageBox.Show("Tempo inv�lido. Use o formato mm:ss.");
                }
            }

        }

        private void potencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada do caractere
            }

        }

        private void textBoxPotencia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPotencia.Text))
            {
                textBoxPotencia.Text = "10";
            }

            ValidarValor();
        }

        // Observe que esta valida��o deve ser feita em resposta a um evento, como um bot�o de valida��o ou uma perda de foco (Leave) do TextBox.

        private void ValidarValor()
        {
            if (int.TryParse(textBoxPotencia.Text, out int valor)) // Verifica se o valor � um n�mero inteiro
            {
                if (valor < 1 || valor > 10)
                {
                    // O valor n�o est� no intervalo v�lido
                    MessageBox.Show("O valor deve estar no intervalo de 1 a 10.");
                }
            }
            else
            {
                // O valor n�o � um n�mero v�lido
                MessageBox.Show("O valor n�o � um n�mero v�lido.");
            }
        }

    }
}