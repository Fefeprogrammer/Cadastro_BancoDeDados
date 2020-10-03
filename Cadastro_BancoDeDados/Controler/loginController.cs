using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_BancoDeDados.Model;
using Cadastro_BancoDeDados.Classes;

namespace Cadastro_BancoDeDados.Controler
{
    class loginController
    {
        public bool tem;
        public string mensagem;

        public bool Entrar(string usuario, string senha)
        {
            Login login = new Login();
            tem = login.VerificarLogin(usuario, senha);
            if (!login.mensagem.Equals(""))
            {
                this.mensagem = login.mensagem;
            }
            return tem;
        }
    }
}
