using System;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using WinFormsMicroondas.Telas;

namespace WinFormsMicroondas
{
    public partial class Form1 : Form
    {
        private const int TempoPadraoSegundos = 30;
        private const int PotenciaPadrao = 10;
        private int tempoRestante = TempoPadraoSegundos;
        private bool emAndamento = false;
        private bool pausado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConfigurarMicroondas(int tempoSegundos, int potencia)
        {
            // Implemente a lógica de configuração do micro-ondas aqui
            // Isso pode envolver o ajuste da potência e do tempo do micro-ondas
        }

        private void IniciarAquecimento(int potencia, int tempoSegundos)
        {
            emAndamento = true;
            pausado = false;

            if (potencia <= 0)
            {
                potencia = PotenciaPadrao;
            }

            if (tempoSegundos <= 0)
            {
                tempoSegundos = TempoPadraoSegundos;
            }

            ConfigurarMicroondas(tempoSegundos, potencia);

            while (tempoSegundos > 0)
            {
                Thread.Sleep(1000); // Aguarda 1 segundo
                tempoSegundos--;
                textBoxTempo.Text = string.Format("{0:00}:{1:00}", tempoSegundos / 60, tempoSegundos % 60);
            }

            emAndamento = false;
            MessageBox.Show("Aquecimento concluído.");
        }

        private void IniciarAquecimentoPadrao()
        {
            IniciarAquecimento(PotenciaPadrao, TempoPadraoSegundos);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!emAndamento)
            {
                IniciarAquecimentoPadrao();
            }
            else if (pausado)
            {
                emAndamento = true;
                pausado = false;
                IniciarAquecimento(PotenciaPadrao, tempoRestante);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (emAndamento)
            {
                pausado = !pausado;
                tempoRestante = TempoPadraoSegundos - (TempoPadraoSegundos - tempoRestante);
            }
            else
            {
                textBoxTempo.Text = "00:00";
                tempoRestante = 0;
            }
        }

        private void btnPipoca_Click(object sender, EventArgs e)
        {
            // Configure o Timer com um intervalo de 10 segundos e defina a lógica para interromper o aquecimento
            timer = new Timer { Interval = 10000, Enabled = false };
            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                // Coloque aqui a lógica para interromper o aquecimento, por exemplo:
                // Parar o aquecimento ou exibir uma mensagem
                MessageBox.Show("Aquecimento interrompido devido a intervalo de 10 segundos entre estouros de milho.", "Aviso");
            };

            // Inicie o temporizador quando o aquecimento for iniciado
            IniciarAquecimento();
        }

        // Método para iniciar o aquecimento
        private void IniciarAquecimento()
        {
            // Coloque aqui a lógica para iniciar o aquecimento
            // Quando um estouro de milho ocorrer, inicie o temporizador com: timer.Start();
        }

        private void btnLeite_Click(object sender, EventArgs e)
        {
            // Configuração do aquecimento de leite
            int tempoSegundos = 5 * 60; // 5 minutos em segundos
            int potencia = 5;

            // Verificar se o leite está em um recipiente adequado e seguro
            bool recipienteSeguro = VerificarRecipienteSeguro();

            if (recipienteSeguro)
            {
                // Configurar o micro-ondas
                ConfigurarMicroondas(tempoSegundos, potencia);

                // Inicie o aquecimento
                IniciarAquecimento();
            }
            else
            {
                // Exiba uma mensagem de precaução
                MessageBox.Show("Cuidado com aquecimento de líquidos. O choque térmico aliado ao movimento do recipiente pode causar fervura imediata, causando risco de queimaduras.", "Aviso");
            }
        }

        private void btnCarnes_Click(object sender, EventArgs e)
        {
            // Configuração do descongelamento de carne de boi
            int tempoSegundos = 14 * 60; // 14 minutos em segundos
            int potencia = 4;

            // Verificar se a carne está pronta para o descongelamento
            bool carnePronta = VerificarCarnePronta();

            if (carnePronta)
            {
                // Configurar o micro-ondas
                ConfigurarMicroondas(tempoSegundos, potencia);

                // Inicie o descongelamento
                IniciarDescongelamento();

                // Aguarde a metade do tempo e vire a carne
                System.Threading.Thread.Sleep(tempoSegundos / 2 * 1000); // Aguarde metade do tempo em milissegundos
                VirarCarne(); // Chame a função para virar a carne
            }
            else
            {
                // Exiba uma mensagem de precaução
                MessageBox.Show("Certifique-se de que a carne está pronta para o descongelamento e siga as instruções de virar a carne na metade do tempo.", "Aviso");
            }
        }

        private void btnFrango_Click(object sender, EventArgs e)
        {
            // Configuração do descongelamento de frango
            int tempoSegundos = 8 * 60; // 8 minutos em segundos
            int potencia = 7;

            // Verificar se o frango está pronto para o descongelamento
            bool frangoPronto = VerificarFrangoPronto();

            if (frangoPronto)
            {
                // Configurar o micro-ondas
                ConfigurarMicroondas(tempoSegundos, potencia);

                // Inicie o descongelamento
                IniciarDescongelamento();

                // Aguarde a metade do tempo e vire o frango
                System.Threading.Thread.Sleep(tempoSegundos / 2 * 1000); // Aguarde metade do tempo em milissegundos
                VirarFrango(); // Chame a função para virar o frango
            }
            else
            {
                // Exiba uma mensagem de precaução
                MessageBox.Show("Certifique-se de que o frango está pronto para o descongelamento e siga as instruções de virar o frango na metade do tempo.", "Aviso");
            }
        }

        private void btnFeijao_Click(object sender, EventArgs e)
        {
            int tempoSegundos = 8 * 60; // 8 minutos em segundos
            int potencia = 9;

            if (VerificarRecipienteSeguro())
            {
                if (IniciarAquecimento(tempoSegundos, potencia))
                {
                    // Aquecimento interrompido ou cancelado
                    MessageBox.Show("Aquecimento interrompido ou cancelado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Aquecimento concluído
                    MessageBox.Show("Aquecimento concluído.", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mensagem de precaução
                MessageBox.Show("Deixe o recipiente destampado e, em casos de plástico, tenha cuidado ao retirar o recipiente, pois o mesmo pode perder resistência em altas temperaturas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



    }

}
