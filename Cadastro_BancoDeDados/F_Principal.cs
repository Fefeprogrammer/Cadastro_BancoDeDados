using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_BancoDeDados.Controler;

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

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'myDataBaseDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.myDataBaseDataSet.Alunos);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.alunosTableAdapter.FillBy(this.myDataBaseDataSet.Alunos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_matriculados_Click(object sender, EventArgs e)
        {
            /*mostrar.Mostrar(true);
            MessageBox.Show(mostrar.dr.ToString());*/

            /* mostrarController mostrar = new mostrarController();
             dataGridView1.DataSource = mostrar.dr;
             dataGridView1.te*/

            try
            {
                this.alunosTableAdapter.FillBy(this.myDataBaseDataSet.Alunos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
