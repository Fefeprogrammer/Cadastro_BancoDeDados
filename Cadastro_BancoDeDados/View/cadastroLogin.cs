using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_BancoDeDados.Model;
using Cadastro_BancoDeDados.Classes;

namespace Cadastro_BancoDeDados.View
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;

            cadastroLogin cadastro = new cadastroLogin(usuario, senha);
        }
    }
}
