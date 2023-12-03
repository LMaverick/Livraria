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
        int id = 1;
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

        private void btn_ant_Click(object sender, EventArgs e)
        {
            if (id < 1)
            {
                id = 10;
            }
            else
            {
                id--;
            }
            
            if(id == 1)
            {
                string img = "teste";
                string titulo = "Foco e Disciplinaaa";
                string sinopse = "teste";
                string categoria = "teste";
                string capitulo = "teste";

                txt_titulo.Text = titulo;
                txt_sinopse.Text = sinopse;
                txt_categoria.Text = categoria;
                txt_capitulo.Text = capitulo;
            }
            if (id == 10)
            {
                string img = "teste";
                string titulo = "Disciplinaaa";
                string sinopse = "teste";
                string categoria = "teste";
                string capitulo = "teste";

                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.Add(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.Add(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.Add(capitulo);


            }
            if (id == 0)
            {
                string img = "testeaf";
                string titulo = "Foco";
                string sinopse = "testeaf";
                string categoria = "testeaf";
                string capitulo = "testeaf";

                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.Add(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.Add(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.Add(capitulo);
            }




        }

        private void btn_prox_Click(object sender, EventArgs e)
        {
            if (id > 10)
            {
                id = 1;
            }
            else
            {
                id++;
            }
        }
    }
}
