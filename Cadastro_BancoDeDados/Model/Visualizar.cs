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


        public Visualizar()
        {
            cmd.CommandText = "SELECT * FROM myDataBase";
        }
    }
}
