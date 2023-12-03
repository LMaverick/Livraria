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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Trabalho
{
    public partial class Principal : Form
    {
        int id = 1;
        int setembro = 0;
        int outubro = 0;
        int novembro = 0;
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
                string[] sinopse = { "Como o foco e disciplina influência na vida de uma pessoa,", "muitas pessoas pensam e pensam que ter muito foco as ", "ajudariam a conquistar as melhores coisas da vida, o quanto ", "disso é verdade?" };
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
                checkBox1.Checked = false;

                Double[] Setembro = {33 };
                Double[] Outubro = {33 };
                Double[] Novembro = {33 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;


            }

            if (id == 2)
            {

                string titulo = "CAVERNA DO DRAGÃO";
                string[] sinopse = { "Seis jovens entre 10 e 18 anos, entram em um parque de ", "diversões chamado Caverna do Dragão. Quando fazem um ", "passeio em uma espécie de trem fantasma, são catapultados para ", "um mundo paralelo, cheio de monstros, demônios e magos. " };
                string[] categoria = { "Ação, Aventura, Magia, Exploração" };
                string[] capitulo = { "Capítulo 1: A Queda no Abismo Interdimensional",    "Capítulo 2: Encontros nas Terras Desconhecidas", "Capítulo 3: Desafios na Cidade dos Elfos", "Capítulo 4: Confronto com o Mestre dos Pesadelos" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 45};
                Double[] Outubro = {34 };
                Double[] Novembro = { 23};
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 3)
            {

                string titulo = "É assim que acaba - Colleen Hoover ";
                string[] sinopse = { "Em É assim que acaba, Colleen Hoover nos apresenta Lily, ", "uma jovem que se mudou de uma cidadezinha do Maine ", "para Boston, se formou em marketing e abriu a própria","floricultura. " };
                string[] categoria = { "Drama, Romance, BestSellers" };
                string[] capitulo = { "Capítulo 1: O Encontro Inesperado", "Capítulo 2: Laços que se Desfazem", "Capítulo 3: Entre Páginas e Promessas", "Capítulo 4: O Adeus Necessário" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = {10 };
                Double[] Outubro = {20 };
                Double[] Novembro = {30 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 4)
            {

                string titulo = "Entre as chamas sob a água";
                string[] sinopse = { "Fala do seu mais recente romance, “Entre as Chamas, Sob  ", "a Água, romance histórico que retrata a  ", "brutalidade da Guerra de Canudos" };
                string[] categoria = { "Histórico, Drama, Romance, Guerra" };
                string[] capitulo = { "Capítulo 1: A Inexplorada Profundidade", "Capítulo 2: Mistérios nas Correntezas", "Capítulo 3: Confronto nas Cavernas Aquáticas", "Capítulo 4: O Segredo do Fogo Submerso" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = {44 };
                Double[] Outubro = { 32};
                Double[] Novembro = { 32};
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 5 )
            {
 
                string titulo = "Eu Sei O Que Vocês Fizeram no Verão Passado";
                string[] sinopse = { "Um ano após atropelar um pescador e jogar o seu corpo na ", "água, quatro amigos se reúnem quando Julie  ", "recebe uma carta assustadora dizendo-lhe que ","seu crime foi visto. " };
                string[] categoria = { "Mistério, Assassinato, Drama" };
                string[] capitulo = {"Capítulo 1: O Pacto Silencioso",    "Capítulo 2: Sombras à Beira-Mar",    "Capítulo 3: Rastros na Noite de Verão",    "Capítulo 4: Segredos Revelados no Crepúsculo"};

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = {45 };
                Double[] Outubro = { 33};
                Double[] Novembro = { 22};
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 6)
            {

                string titulo = "Harry Potter e o Prisioneiro de Azkaban";
                string[] sinopse = { "É o início do terceiro ano na escola de bruxaria Hogwarts.", "Harry, Ron e Hermione têm muito o que aprender. " };
                string[] categoria = { "Magia, Drama, Aventura" };
                string[] capitulo = {"Capítulo 1: A Fuga Misteriosa",    "Capítulo 2: A Profecia Esquecida",    "Capítulo 3: No Rastro do Patrono",    "Capítulo 4: O Enigma do Mapa do Maroto" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 5};
                Double[] Outubro = {55 };
                Double[] Novembro = { 30};
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 7)
            {
                
                string titulo = "Medo imortal ";
                string[] sinopse = { "São contos que evocam o sobrenatural, apresentam ", "monstros ,descrevem atos de psicopatas, dão o ", "testemunho de todo tipo imaginável de atrocidades ", "concebidas pela mente humana." };
                string[] categoria = { "Terror, Suspense, Psicologico" };
                string[] capitulo = {  "Capítulo 1: Sombras do Além",    "Capítulo 2: Pacto com o Desconhecido",    "Capítulo 3: No Limiar da Eternidade",    "Capítulo 4: O Suspiro do Invisível" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                checkBox1.Checked = false;

                Double[] Setembro = { 5};
                Double[] Outubro = {77 };
                Double[] Novembro = { 56};
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 8
                )
            {
                
                string titulo = "O gato que amava livros";
                string[] sinopse = { "O gato deve encontrar um verdadeiro amante dos livros para", "acompanhá-lo em uma missão." };
                string[] categoria = { "Aventura, Relaxante, Místico" };
                string[] capitulo = { "Capítulo 1: O Mistério da Biblioteca Vazia",    "Capítulo 2: A Descoberta do Livro Encantado",    "Capítulo 3: Aventuras nas Páginas Mágicas",    "Capítulo 4: O Gato e o Fim do Conto" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = {23 };
                Double[] Outubro = {53 };
                Double[] Novembro = {75 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 9)
            {
                
                string titulo = "Percy jackson e os olimpianos";
                string[] sinopse = { "Um artefato precioso foi roubado do Monte Olimpo e Percy ", "é o principal suspeito. " };
                string[] categoria = { "Mágico, Aventura, Ação" };
                string[] capitulo = { "Capítulo 1: O Ladrão de Raios",    "Capítulo 2: A Maldição do Titã",    "Capítulo 3: A Batalha do Labirinto",    "Capítulo 4: O Último Olimpiano" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = {23 };
                Double[] Outubro = {43 };
                Double[] Novembro = {22 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 10)
            {
                
                string titulo = "Todas as suas (im)perfeições";
                string[] sinopse = { "Todas as suas (im)perfeições fala sobre um casamento ", "conturbado e uma promessa esquecida que pode ser capaz ", "de salvá-lo. " };
                string[] categoria = { "Romance, Aventura, Relaxante" };
                string[] capitulo = { "Capítulo 1: Entre Linhas e Imperfeições",    "Capítulo 2: Retratos da Vida Desigual",    "Capítulo 3: Na Dança das (Im)perfeições",    "Capítulo 4: Os Tons Invisíveis do Amor" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 12 };
                Double[] Outubro = { 50 };
                Double[] Novembro = { 40 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;
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


            if (id == 1)
            {
                string titulo = "Foco e Disciplina";
                string[] sinopse = { "Como o foco e disciplina influência na vida de uma pessoa,", "muitas pessoas pensam e pensam que ter muito foco as ", "ajudariam a conquistar as melhores coisas da vida, o quanto ", "disso é verdade?" };
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
                checkBox1.Checked = false;

                Double[] Setembro = { 33 };
                Double[] Outubro = { 33 };
                Double[] Novembro = { 33 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;


            }

            if (id == 2)
            {

                string titulo = "CAVERNA DO DRAGÃO";
                string[] sinopse = { "Seis jovens entre 10 e 18 anos, entram em um parque de ", "diversões chamado Caverna do Dragão. Quando fazem um ", "passeio em uma espécie de trem fantasma, são catapultados para ", "um mundo paralelo, cheio de monstros, demônios e magos. " };
                string[] categoria = { "Ação, Aventura, Magia, Exploração" };
                string[] capitulo = { "Capítulo 1: A Queda no Abismo Interdimensional", "Capítulo 2: Encontros nas Terras Desconhecidas", "Capítulo 3: Desafios na Cidade dos Elfos", "Capítulo 4: Confronto com o Mestre dos Pesadelos" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 45 };
                Double[] Outubro = { 34 };
                Double[] Novembro = { 23 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 3)
            {

                string titulo = "É assim que acaba - Colleen Hoover ";
                string[] sinopse = { "Em É assim que acaba, Colleen Hoover nos apresenta Lily, ", "uma jovem que se mudou de uma cidadezinha do Maine ", "para Boston, se formou em marketing e abriu a própria", "floricultura. " };
                string[] categoria = { "Drama, Romance, BestSellers" };
                string[] capitulo = { "Capítulo 1: O Encontro Inesperado", "Capítulo 2: Laços que se Desfazem", "Capítulo 3: Entre Páginas e Promessas", "Capítulo 4: O Adeus Necessário" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 10 };
                Double[] Outubro = { 20 };
                Double[] Novembro = { 30 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 4)
            {

                string titulo = "Entre as chamas sob a água";
                string[] sinopse = { "Fala do seu mais recente romance, “Entre as Chamas, Sob  ", "a Água, romance histórico que retrata a  ", "brutalidade da Guerra de Canudos" };
                string[] categoria = { "Histórico, Drama, Romance, Guerra" };
                string[] capitulo = { "Capítulo 1: A Inexplorada Profundidade", "Capítulo 2: Mistérios nas Correntezas", "Capítulo 3: Confronto nas Cavernas Aquáticas", "Capítulo 4: O Segredo do Fogo Submerso" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 44 };
                Double[] Outubro = { 32 };
                Double[] Novembro = { 32 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 5)
            {

                string titulo = "Eu Sei O Que Vocês Fizeram no Verão Passado";
                string[] sinopse = { "Um ano após atropelar um pescador e jogar o seu corpo na ", "água, quatro amigos se reúnem quando Julie  ", "recebe uma carta assustadora dizendo-lhe que ", "seu crime foi visto. " };
                string[] categoria = { "Mistério, Assassinato, Drama" };
                string[] capitulo = { "Capítulo 1: O Pacto Silencioso", "Capítulo 2: Sombras à Beira-Mar", "Capítulo 3: Rastros na Noite de Verão", "Capítulo 4: Segredos Revelados no Crepúsculo" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 45 };
                Double[] Outubro = { 33 };
                Double[] Novembro = { 22 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 6)
            {

                string titulo = "Harry Potter e o Prisioneiro de Azkaban";
                string[] sinopse = { "É o início do terceiro ano na escola de bruxaria Hogwarts.", "Harry, Ron e Hermione têm muito o que aprender. " };
                string[] categoria = { "Magia, Drama, Aventura" };
                string[] capitulo = { "Capítulo 1: A Fuga Misteriosa", "Capítulo 2: A Profecia Esquecida", "Capítulo 3: No Rastro do Patrono", "Capítulo 4: O Enigma do Mapa do Maroto" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 5 };
                Double[] Outubro = { 55 };
                Double[] Novembro = { 30 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 7)
            {

                string titulo = "Medo imortal ";
                string[] sinopse = { "São contos que evocam o sobrenatural, apresentam ", "monstros ,descrevem atos de psicopatas, dão o ", "testemunho de todo tipo imaginável de atrocidades ", "concebidas pela mente humana." };
                string[] categoria = { "Terror, Suspense, Psicologico" };
                string[] capitulo = { "Capítulo 1: Sombras do Além", "Capítulo 2: Pacto com o Desconhecido", "Capítulo 3: No Limiar da Eternidade", "Capítulo 4: O Suspiro do Invisível" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                checkBox1.Checked = false;

                Double[] Setembro = { 5 };
                Double[] Outubro = { 77 };
                Double[] Novembro = { 56 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;
                txt_capitulo.Items.AddRange(capitulo);

            }
            if (id == 8
                )
            {

                string titulo = "O gato que amava livros";
                string[] sinopse = { "O gato deve encontrar um verdadeiro amante dos livros para", "acompanhá-lo em uma missão." };
                string[] categoria = { "Aventura, Relaxante, Místico" };
                string[] capitulo = { "Capítulo 1: O Mistério da Biblioteca Vazia", "Capítulo 2: A Descoberta do Livro Encantado", "Capítulo 3: Aventuras nas Páginas Mágicas", "Capítulo 4: O Gato e o Fim do Conto" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 23 };
                Double[] Outubro = { 53 };
                Double[] Novembro = { 75 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 9)
            {

                string titulo = "Percy jackson e os olimpianos";
                string[] sinopse = { "Um artefato precioso foi roubado do Monte Olimpo e Percy ", "é o principal suspeito. " };
                string[] categoria = { "Mágico, Aventura, Ação" };
                string[] capitulo = { "Capítulo 1: O Ladrão de Raios", "Capítulo 2: A Maldição do Titã", "Capítulo 3: A Batalha do Labirinto", "Capítulo 4: O Último Olimpiano" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 23 };
                Double[] Outubro = { 43 };
                Double[] Novembro = { 22 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;

            }
            if (id == 10)
            {

                string titulo = "Todas as suas (im)perfeições";
                string[] sinopse = { "Todas as suas (im)perfeições fala sobre um casamento ", "conturbado e uma promessa esquecida que pode ser capaz ", "de salvá-lo. " };
                string[] categoria = { "Romance, Aventura, Relaxante" };
                string[] capitulo = { "Capítulo 1: Entre Linhas e Imperfeições", "Capítulo 2: Retratos da Vida Desigual", "Capítulo 3: Na Dança das (Im)perfeições", "Capítulo 4: Os Tons Invisíveis do Amor" };

                pictureBox1.Image = imageList1.Images[id];
                txt_titulo.Text = titulo;
                txt_sinopse.Items.Clear();
                txt_sinopse.Items.AddRange(sinopse);
                txt_categoria.Items.Clear();
                txt_categoria.Items.AddRange(categoria);
                txt_capitulo.Items.Clear();
                txt_capitulo.Items.AddRange(capitulo);
                checkBox1.Checked = false;

                Double[] Setembro = { 12 };
                Double[] Outubro = { 50 };
                Double[] Novembro = { 40 };
                chart1.Series[0].Points[0].YValues = Setembro;
                chart1.Series[0].Points[1].YValues = Outubro;
                chart1.Series[0].Points[2].YValues = Novembro;
            }







        }

        private void queroolivro(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                MessageBox.Show("Livro Solicitado, Meus Parabéns pela aquisição!");

                DataTable dt = new DataTable();

                if (dataGridView1.DataSource != null)
                {
                    dt = (DataTable)dataGridView1.DataSource;
                }
                else
                {
                   
                    dt.Columns.Add("Titulo");
                    dt.Columns.Add("Solicitado");
                    
                }

                DataRow linha = dt.NewRow();
                

                    linha["Titulo"] = txt_titulo.Text;
                    linha["Solicitado"] = "Sim";

                    dt.Rows.Add(linha);

                    dataGridView1.DataSource = dt;
                
            }
            else { MessageBox.Show("Certeza que encontrará livros incriveis"); }
        }
    }



       
}

