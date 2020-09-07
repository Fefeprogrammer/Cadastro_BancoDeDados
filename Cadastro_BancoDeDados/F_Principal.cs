using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_BancoDeDados
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_matricula_Click(object sender, EventArgs e)
        {
            F_Cadastro cadastro = new F_Cadastro();
            cadastro.ShowDialog();
        }
    }
}
