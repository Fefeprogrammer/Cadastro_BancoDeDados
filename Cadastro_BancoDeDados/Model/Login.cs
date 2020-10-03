using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cadastro_BancoDeDados.Classes
{
    class Login
    {
        public bool tem = false;
        public string mensagem;
        SqlDataReader dr;
        Conexao conexao = new Conexao();

        SqlCommand cmd = new SqlCommand();

        public bool VerificarLogin(string usuario, string senha)
        {
            conexao.Conectar();
            cmd.CommandText = "SELECT usuario, senha FROM Login WHERE usuario = @usuario and senha = @senha";

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    this.tem = true;
                    this.mensagem = "Conectado com sucesso";
                }
            }catch(SqlException e)
            {
                this.mensagem = "Erro: " + e;
            }

            return tem;
        }
    }

}