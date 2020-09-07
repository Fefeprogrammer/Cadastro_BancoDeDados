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

            Login login = new Login(usuario, senha);
            F_Principal principal = new F_Principal();
           

            if(login.getConectado() == true)
            {
                principal.ShowDialog();
                
            }
            else
            {
                MessageBox.Show(login.getErro());
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            F_Login login_tela = new F_Login();
            login_tela.Close();
            Application.Exit();
        }
    }
}
