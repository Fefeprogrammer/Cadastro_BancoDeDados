using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cadastro_BancoDeDados.Classes;

namespace Cadastro_BancoDeDados.Model
{
    class Visualizar
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        //public string[] dados = new string[4];
        public SqlDataReader dados;


        public void Buscas(string nome, string sobrenome, string idade, string endereco)
        {
            con.Conectar();
            cmd.CommandText = "SELECT * FROM Alunos WHERE nome = @nome and sobrenome = @sobrenome and idade = @idade and endereco = @endereco";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue("@endereco", endereco);

            try
            {
                cmd.Connection = con.Conectar();
                dados = cmd.ExecuteReader();
            }catch(SqlException e)
            {
                this.mensagem = "Erro: " + e;
            }

           
        }
    }
}
