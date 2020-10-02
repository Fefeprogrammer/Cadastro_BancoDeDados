using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cadastro_BancoDeDados.Classes;

namespace Cadastro_BancoDeDados.Model
{
    class cadastroLogin
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        string mensagem = "";

        public cadastroLogin(string usuario, string senha)
        {
            cmd.CommandText = "INSERT INTO Login(usuario, senha) VALUES(@usuario, @senha)";

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Cadastrado com sucesso";

            }catch(SqlException e)
            {
                this.mensagem = "Erro: "+ e;
            }
        }
    }
}
