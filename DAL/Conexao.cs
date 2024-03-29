﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMicroondas.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection(); // conexao com banco de dados
        public Conexao()
        {
            this.con.ConnectionString = @"Data Source=DESKTOP-L6VNCFI;Initial Catalog=Login;Integrated Security=True;User ID=sa;Password=123456";
        }

        public SqlConnection conectar()
        {
            if (this.con.State == System.Data.ConnectionState.Closed) // se conexao estiver fechado, posso abrir
            {
                this.con.Open(); // metodo abrir
            } 
            return con; // retornar a conexao

        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open) // se conexao estiver aberto, posso fechar
            {
                con.Close(); // fazer a conexao
            }

        }
    }

}
