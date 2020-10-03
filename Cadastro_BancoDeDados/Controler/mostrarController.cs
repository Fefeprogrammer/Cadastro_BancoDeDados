using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cadastro_BancoDeDados.Model;

namespace Cadastro_BancoDeDados.Controler
{
    class mostrarController
    {
        public string mensagem = "";
        private bool mostrar = false;
        public SqlDataReader dr;

        public void Mostrar(bool mostrar)
        {
            this.mostrar = mostrar;
            if (mostrar == true)
            {
                Visualizar vi = new Visualizar();
                this.dr = vi.dados;
            }
        }
    }
}
