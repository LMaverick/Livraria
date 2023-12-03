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
                string titulo = "Foco e Disciplina";
                string[] sinopse = { "Como o foco e disciplina influência na vida de uma pessoa,", "muitas pessoas pensam e pensam que ter muito foco as ", " ajudariam a conquistar as melhores coisas da vida, o quanto ", "disso é verdade?" };
                string[] categoria = { "Ação, Mistério, Aventura, Suspense" };
                string[] capitulo = { "Capítulo 1: Preparando o ciclo de sofrimento", "Capítulo 2: Alex o Insuportável, Mia a Apaixonada ", "ne Arthur o Vidente", "Capítulo 3: Desastre natural", "Capítulo 4: O Fim mutável? E a mudança drástica!", "EXTRA: Alex o rei do mundo" };

                pictureBox1.Image = imageList1.Images[id];
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

                string titulo = "CAVERNA DO DRAGÃO";
                string[] sinopse = { "Seis jovens entre 10 e 18 anos, entram em um parque de diversões chamado Caverna do Dragão. Quando fazem um passeio em uma espécie de trem fantasma, são catapultados para um mundo paralelo, cheio de monstros, demônios e mágos. " };
                string[] categoria = { "Ação, Aventura, Magia, Exploração" };
                string[] capitulo = { "" };

                pictureBox1.Image = imageList1.Images[id];
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

                string titulo = "É assim que acaba - Colleen Hoover ";
                string[] sinopse = { "Em É assim que acaba, Colleen Hoover nos apresenta Lily, uma jovem que se mudou de uma cidadezinha do Maine para Boston, se formou em marketing e abriu a própria floricultura. " };
                string[] categoria = { "Drama, Romance, BestSellers" };
                string[] capitulo = { "" };

                pictureBox1.Image = imageList1.Images[id];
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

                string titulo = "Entre as chamas sob a água";
                string[] sinopse = { "Fala do seu mais recente romance, “Entre as Chamas, Sob a Água\", romance histórico que retrata a brutalidade da Guerra de Canudos" };
                string[] categoria = { "Histórico, Drama, Romance, Guerra" };
                string[] capitulo = { "" };

                pictureBox1.Image = imageList1.Images[id];
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
 
                string titulo = "Eu Sei O Que Vocês Fizeram no Verão Passado";
                string[] sinopse = { "Um ano após atropelar um pescador e jogar o seu corpo na água, quatro amigos se reúnem quando Julie recebe uma carta assustadora dizendo-lhe que seu crime foi visto. " };
                string[] categoria = { "Mistério, Assassinato, Drama" };
                string[] capitulo = { "" };

                pictureBox1.Image = imageList1.Images[id];
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

                string titulo = "Harry Potter e o Prisioneiro de Azkaban";
                string[] sinopse = { "É o início do terceiro ano na escola de bruxaria Hogwarts. Harry, Ron e Hermione têm muito o que aprender. " };
                string[] categoria = { "Magia, Drama, Aventura" };
                string[] capitulo = { "" };

                pictureBox1.Image = imageList1.Images[id];
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
                
                string titulo = "Medo imortal ";
                string[] sinopse = { "São contos que evocam o sobrenatural, apresentam monstros, descrevem atos de psicopatas, dão o testemunho de todo tipo imaginável de atrocidades concebidas pela mente humana." };
                string[] categoria = { "Terror, Suspense, Psicologico" };
                string[] capitulo = { "" };

                pictureBox1.Image = imageList1.Images[id];
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
                
                string titulo = "O gato que amava livros";
                string[] sinopse = { "O gato deve encontrar um verdadeiro amante dos livros para acompanhá-lo em uma missão." };
                string[] categoria = { "Aventura, Relaxante, Místico" };
                string[] capitulo = { "" };

                pictureBox1.Image = imageList1.Images[id];
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
                
                string titulo = "Percy jackson e os olimpianos";
                string[] sinopse = { "Um artefato precioso foi roubado do Monte Olimpo e Percy é o principal suspeito. " };
                string[] categoria = { "Mágico, Aventura, Ação" };
                string[] capitulo = { "" };

                pictureBox1.Image = imageList1.Images[id];
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
                
                string titulo = "Todas as suas (im)perfeições";
                string[] sinopse = { "Todas as suas (im)perfeições fala sobre um casamento conturbado e uma promessa esquecida que pode ser capaz de salvá-lo. " };
                string[] categoria = { "Romance, Aventura, Relaxante" };
                string[] capitulo = { "" };

                pictureBox1.Image = imageList1.Images[id];
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
