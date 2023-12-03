using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data;
using MySql.Data.MySqlClient;

namespace Trabalho
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void criarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cadastro().Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cadastro().Show();
        }

        private void editarAssinaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cadastro().Show();
        }

        private void livrosDaSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você está visualizando os livros da semana!");
        }

        private void meusLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Infelizmente Você ainda não tem livros comprados! Aproveite e escolha algum agora");
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nenhum livro em rota de entrega no momento");
        }
    }
}
