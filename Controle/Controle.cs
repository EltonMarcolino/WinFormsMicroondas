using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WinFormsMicroondas.DAL;

namespace WinFormsMicroondas.Controle
{
    public class Controle
    {
      
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginComandos loginComandos = new LoginComandos();
            tem = loginComandos.vereficarLogin(login, senha); // receber o metodo vereficar
            if (!loginComandos.mensagem.Equals(""))
            {
                this.mensagem = loginComandos.mensagem;
            }

            return tem;
        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            LoginComandos loginComandos = new LoginComandos();
            this.mensagem = loginComandos.cadastrar(email, senha, confSenha);
            if(loginComandos.tem) // mensagem de sucesso
            {
                this.tem = true;
            }
            return mensagem; // retornar vazio
        }
    }
}
