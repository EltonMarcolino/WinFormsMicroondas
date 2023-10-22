using System;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsMicroondas
{
    public partial class Form1 : Form
    {
        private const int TempoPadraoSegundos = 30;
        private const int PotenciaPadrao = 10;
        private int tempoRestante = TempoPadraoSegundos;
        private bool emAndamento = false;
        private bool pausado = false;
        private System.Timers.Timer timer;
        private System.Windows.Forms.Timer descongelamentoTimer;
        private int tempoDescongelamento;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void ConfigurarMicroondas(int tempoSegundos, int potencia)
        {
            // Verificar se a potência está dentro dos limites permitidos (1 a 10, por exemplo)
            if (potencia < 1)
            {
                potencia = 1;
            }
            else if (potencia > 10)
            {
                potencia = 10;
            }

            // Certificar-se de que o tempo esteja dentro dos limites
            if (tempoSegundos < 0)
            {
                tempoSegundos = 0;
            }

            // Exibir a potência e o tempo na interface do usuário
            textBoxPotencia.Text = potencia.ToString();
            textBoxTempo.Text = string.Format("{0:00}:{1:00}", tempoSegundos / 60, tempoSegundos % 60);

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
            timer = new System.Timers.Timer { Interval = 10000, Enabled = false };
            timer.Elapsed += Timer_Elapsed; // Alterei para o evento Elapsed

            // Inicie o temporizador quando o aquecimento for iniciado
            IniciarAquecimento();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Aquecimento interrompido devido a intervalo de 10 segundos entre estouros de milho.", "Aviso");
        }

        // Método para iniciar o aquecimento
        private void IniciarAquecimento()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 10000; // Defina o intervalo em milissegundos (10 segundos)
            timer.AutoReset = false; // Impede que o temporizador continue a disparar após o primeiro estouro
            timer.Elapsed += TimerElapsed; // Defina o manipulador de eventos para o temporizador
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Lógica para interromper o aquecimento, por exemplo, parar o micro-ondas ou exibir uma mensagem
            MessageBox.Show("Aquecimento interrompido devido a intervalo de 10 segundos entre estouros de milho.", "Aviso");
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
                Thread.Sleep(tempoSegundos / 2 * 1000); // Aguarde metade do tempo em milissegundos
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
                Thread.Sleep(tempoSegundos / 2 * 1000); // Aguarde metade do tempo em milissegundos
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
                // Exibir instruções em um MessageBox
                string instrucoes = "Alimento: Feijão congelado\nTempo: 8 minutos\nPotência: 9\n\nInstruções:\nDeixe o recipiente destampado e, em casos de plástico, tenha cuidado ao retirar o recipiente, pois o mesmo pode perder resistência em altas temperaturas.";
                MessageBox.Show(instrucoes, "Instruções para Cozimento de Feijão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Configurar o micro-ondas
                ConfigurarMicroondas(tempoSegundos, potencia);

                // Iniciar o aquecimento
                IniciarAquecimento(PotenciaPadrao, tempoSegundos);
            }
            else
            {
                // Mensagem de precaução
                MessageBox.Show("Deixe o recipiente destampado e, em casos de plástico, tenha cuidado ao retirar o recipiente, pois o mesmo pode perder resistência em altas temperaturas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool VerificarRecipienteSeguro()
        {
            // Suponhamos que você queira verificar se o recipiente é de material adequado (não plástico) e suporta altas temperaturas.
            bool recipienteSeguro = true;

            // Se o recipiente for de plástico, não é seguro.
            string materialRecipiente = "plástico"; 

            if (materialRecipiente.Equals("plástico"))
            {
                recipienteSeguro = false;
            }
            return recipienteSeguro;
        }

        private bool VerificarCarnePronta()
        {
            double temperaturaInternaDaCarne = LerTemperaturaInternaDaCarne(); // Implemente essa função

            double limiteDeTemperatura = 4.0; // Exemplo: 4 graus Celsius

            if (temperaturaInternaDaCarne <= limiteDeTemperatura)
            {
                // A carne está pronto para o descongelamento
                return true;
            }
            else
            {
                MessageBox.Show("O frango não está pronto para o descongelamento. Certifique-se de que a temperatura interna do frango seja igual ou inferior a " + limiteDeTemperatura + " graus Celsius.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            double LerTemperaturaInternaDaCarne()
            {
                Random random = new Random();
                double temperatura = random.Next(0, 10); // Simula uma temperatura entre 0 e 10 graus Celsius
                return temperatura;
            }
        }

        private void IniciarDescongelamento()
        {
            // Defina o tempo de descongelamento em segundos (por exemplo, 10 minutos)
            tempoDescongelamento = 10 * 60; // 10 minutos em segundos

            // Defina a potência para o descongelamento (por exemplo, 4)
            int potencia = 4;

            ConfigurarMicroondas(tempoDescongelamento, potencia);
            tempoRestante = tempoDescongelamento;
            descongelamentoTimer = new System.Windows.Forms.Timer();
            descongelamentoTimer.Interval = 1000; // Intervalo de 1 segundo
            descongelamentoTimer.Tick += TimerTick;
            descongelamentoTimer.Start();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            tempoRestante--;

            if (tempoRestante <= 0)
            {
                // O descongelamento foi concluído
                descongelamentoTimer.Stop();
                MessageBox.Show("O descongelamento foi concluído.", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tempoRestante == tempoDescongelamento / 2)
            {
                VirarFrango();
            }

            // Atualize a exibição do tempo restante
            textBoxTempo.Text = string.Format("{0:00}:{1:00}", tempoRestante / 60, tempoRestante % 60);
        }

        private void VirarCarne()
        {
            MessageBox.Show("É hora de virar o carne. Abra o micro-ondas com cuidado e vire o carne no prato.", "Instruções para Descongelamento de carne", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Após exibir a mensagem, você pode pausar o aquecimento ou aguardar um tempo para que o usuário possa virar o carne manualmente.

            // Exemplo: Pausar o aquecimento
            pausado = true;

            // Aguardar até que o usuário confirme que o frango foi virado
            if (MessageBox.Show("Após virar o carne, clique em OK para continuar o aquecimento.", "Instruções para Descongelamento de Carne", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                // Continuar o aquecimento
                pausado = false;
                // Você pode ajustar o tempo restante com base no tempo que passou enquanto o carne estava sendo virado.
                // tempoRestante = ...; // Tempo restante em segundos
            }
            else
            {
                MessageBox.Show("Usuário cancelou o processo, você pode lidar com isso conforme necessário.");
            }
        }

        private bool VerificarFrangoPronto()
        {
            double temperaturaInternaDoFrango = LerTemperaturaInternaDoFrango(); // Implemente essa função

            // Defina um limite de temperatura para considerar o frango pronto para o descongelamento
            double limiteDeTemperatura = 4.0; // Exemplo: 4 graus Celsius

            if (temperaturaInternaDoFrango <= limiteDeTemperatura)
            {
                // O frango está pronto para o descongelamento
                return true;
            }
            else
            {
                // O frango não está pronto, exiba uma mensagem de precaução
                MessageBox.Show("O frango não está pronto para o descongelamento. Certifique-se de que a temperatura interna do frango seja igual ou inferior a " + limiteDeTemperatura + " graus Celsius.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            double LerTemperaturaInternaDoFrango()
            {
                // Simule a leitura da temperatura do frango (substitua isso pela lógica real)
                Random random = new Random();
                double temperatura = random.Next(0, 10); // Simula uma temperatura entre 0 e 10 graus Celsius
                return temperatura;
            }
        }

        private void VirarFrango()
        {
            MessageBox.Show("É hora de virar o frango. Abra o micro-ondas com cuidado e vire o frango no prato.", "Instruções para Descongelamento de Frango", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Após exibir a mensagem, você pode pausar o aquecimento ou aguardar um tempo para que o usuário possa virar o frango manualmente.

            // Exemplo: Pausar o aquecimento
            pausado = true;

            // Aguardar até que o usuário confirme que o frango foi virado
            if (MessageBox.Show("Após virar o frango, clique em OK para continuar o aquecimento.", "Instruções para Descongelamento de Frango", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                // Continuar o aquecimento
                pausado = false;
                // Você pode ajustar o tempo restante com base no tempo que passou enquanto o frango estava sendo virado.
                // tempoRestante = ...; // Tempo restante em segundos
            }
            else
            {
                MessageBox.Show("Usuário cancelou o processo, você pode lidar com isso conforme necessário.");
            }
        }
    }
}
