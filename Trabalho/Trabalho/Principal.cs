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
                string titulo = "Foco e Disciplinaaa";
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
                string img = "teste";
                string titulo = "O café da praia";

               
            }

            if (id == 3)
            {
                string img = "teste";
                string titulo = "Não quero ser como você";

               
            }

            if (id == 4)
            {
                string img = "teste";
                string titulo = "Medo imortal ";


               
            }

            if (id == 5)
            {
                string img = "teste";
                string titulo = "Harry Potter e o Prisioneiro de Azkaban";


                
            }

            if (id == 6)
            {
                string img = "teste";
                string titulo = "Eu Sei O Que Vocês Fizeram no Verão Passado";

                
            }

            if (id == 7)
            {
                string img = "teste";
                string titulo = "Entre as chamas sob a água";


                
            }

            if (id == 8)
            {
                string img = "teste";
                string titulo = "É assim que acaba - Colleen Hoover ";


               
            }

            if (id == 9)
            {
                string img = "teste";
                string titulo = "CAVERNA DO DRAGÃO";


                
            }

            if (id == 10)
            {
                string img = "teste";
                string titulo = "O gato que amava livros";

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
