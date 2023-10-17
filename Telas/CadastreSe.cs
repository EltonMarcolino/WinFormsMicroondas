using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsMicroondas.Telas
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbConfirmaSenha.Text);
            if (controle.tem) // bem sucedido
            {
                MessageBox.Show(mensagem ,"Cadastro",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem); // mensagem de erro!
            }
        }
    }
}
