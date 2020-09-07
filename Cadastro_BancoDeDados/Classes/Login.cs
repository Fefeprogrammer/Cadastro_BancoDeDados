using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_BancoDeDados.Classes
{
    class Login
    {
        private string usuario = "admin";
        private string senha = "admin";
        private bool conectado;
        private string erro;

        public Login(string usuario, string senha)
        {
            setConectado(false);

            if(this.getUsuario() == usuario)
            {
                setConectado(true);
            }
            else
            {
                setConectado(false);
                this.erro = "Usuario e/ou senha incorretos. Tente novamente";
            }
        }

        public string getUsuario()
        {
            return this.usuario;
        }

        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public string getSenha()
        {
            return this.senha;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public bool getConectado()
        {
            return this.conectado;
        }

        public void setConectado(bool conectado)
        {
            this.conectado = conectado;
        }

        public string getErro()
        {
            return this.erro;
        }

    }
}
