using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            

            if (id == 1)
            {
                string img = "teste";
                string titulo = "Foco e Disciplina";
                string[] sinopse = { "Como o foco e disciplina influência na vida de uma pessoa,", "muitas pessoas pensam e pensam que ter muito foco as ", " ajudariam a conquistar as melhores coisas da vida, o quanto ", "disso é verdade?" };
                string[] categoria = { "Ação, Mistério, Aventura, Suspense" };
                string[] capitulo = { "Capítulo 1: Preparando o ciclo de sofrimento", "Capítulo 2: Alex o Insuportável, Mia a Apaixonada ", "ne Arthur o Vidente", "Capítulo 3: Desastre natural", "Capítulo 4: O Fim mutável? E a mudança drástica!", "EXTRA: Alex o rei do mundo" };

                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);


            }

            if (id == 2)
            {
                string img = "t";
                string titulo = "";
                string[] sinopse = { "" };
                string[] categoria = { "" };
                string[] capitulo = { "" };


                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 3)
            {
                string img = "t";
                string titulo = "";
                string[] sinopse = { "" };
                string[] categoria = { "" };
                string[] capitulo = { "" };


                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 4)
            {
                string img = "t";
                string titulo = "";
                string[] sinopse = { "" };
                string[] categoria = { "" };
                string[] capitulo = { "" };


                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 5 )
            {
                string img = "t";
                string titulo = "";
                string[] sinopse = { "" };
                string[] categoria = { "" };
                string[] capitulo = { "" };


                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 6)
            {
                string img = "t";
                string titulo = "";
                string[] sinopse = { "" };
                string[] categoria = { "" };
                string[] capitulo = { "" };


                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 7)
            {
                string img = "t";
                string titulo = "";
                string[] sinopse = { "" };
                string[] categoria = { "" };
                string[] capitulo = { "" };


                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 8
                )
            {
                string img = "t";
                string titulo = "";
                string[] sinopse = { "" };
                string[] categoria = { "" };
                string[] capitulo = { "" };


                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 9)
            {
                string img = "t";
                string titulo = "";
                string[] sinopse = { "" };
                string[] categoria = { "" };
                string[] capitulo = { "" };


                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 10)
            {
                string img = "t";
                string titulo = "";
                string[] sinopse = { "" };
                string[] categoria = { "" };
                string[] capitulo = { "" };


                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);

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
