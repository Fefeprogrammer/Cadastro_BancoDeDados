using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_BancoDeDados.Classes
{
    class Cadastrar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public Cadastrar(string nome, string sobreNome, int idade, string endereco)
        {
            cmd.CommandText = "INSERT INTO Alunos(nome, sobrenome, idade, endereco) VALUES(@nome, @sobrenome, @idade, @endereco)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sobrenome", sobreNome);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue("@endereco", endereco);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch(SqlException e)
            {
                this.mensagem = "Erro: " + e;
            }
        }
    }
}
