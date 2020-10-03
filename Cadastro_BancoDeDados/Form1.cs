using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_BancoDeDados.Classes;
using Cadastro_BancoDeDados.Controler;
using Cadastro_BancoDeDados.View;

namespace Cadastro_BancoDeDados
{
    public partial class F_Login : Form
    {
       
        public F_Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;

            loginController login = new loginController();
            F_Principal principal = new F_Principal();

            login.Entrar(usuario, senha);

            
                if (login.tem == true)
                {
                    principal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario e/ou senha incorretos");
                }
            
           

            
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            F_Login login_tela = new F_Login();
            login_tela.Close();
            Application.Exit();
        }

        private void tb_senha_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }
    }
}
