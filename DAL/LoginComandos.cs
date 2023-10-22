using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMicroondas.DAL
{
    class LoginComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand(); // importar a instancia
        Conexao con = new Conexao(); // importar a conexao
        SqlDataReader dr; // variavel
        public bool vereficarLogin(String login, String senha)
        {
            // vereficação se tem no banco de dados
            cmd.CommandText = "select * from logins where email = @login and senha = @senha"; // escrever o comando
            cmd.Parameters.AddWithValue("@login", login);// sera passado o login e colocado na linha
            cmd.Parameters.AddWithValue("@senha", senha); // sera passado o senha e colocado na linha

            try
            {
                cmd.Connection = con.conectar(); // faz a conexao
                dr = cmd.ExecuteReader(); // quando pega informação do banco de dados para guardar
                if (dr.HasRows) // se estiver linhas no banco de dados, vai receber
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException) // se der erro no banco de dados
            {
                this.mensagem = "Erro com os Dados!";
            }
            return tem; // retornar nada
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            if (senha.Equals(confSenha)) // vereficar senha, se é igual confitmar senha
            {
                cmd.CommandText = "insert into logins values (@email, @senha);";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    Console.Write("Passou da conexão");
                    cmd.ExecuteNonQuery();
                    Console.Write("Executou query");
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro no Banco de Dados!!!";
                }
            }
            else
            {
                this.mensagem = "Senhas não Confirmdo!";
            }

            return mensagem;
        }


    }
}
