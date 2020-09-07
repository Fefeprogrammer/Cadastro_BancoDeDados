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
    public partial class F_Cadastro : Form
    {
        public F_Cadastro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_nome1.Text = null;
            tb_sobreNome.Text = null;
            tb_email.Text = null;
            tb_idade.Text = null;
            tb_endereco.Text = null;
        }

        private void tb_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Cadastro cadastro = new F_Cadastro();
            cadastro.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tb_nome1.Text;
            string sobreNome = tb_sobreNome.Text;
            int idade = Convert.ToInt32(tb_idade.Text);
            string endereco = tb_endereco.Text;

            if(nome != null && sobreNome != null && idade != null && endereco != null)
            {

                Cadastrar cadastro = new Cadastrar(nome, sobreNome, idade, endereco);
                MessageBox.Show(cadastro.mensagem);
            }
            else
            {
                MessageBox.Show("Preencha o formulario");
            }
        }
    }
}
