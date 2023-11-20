namespace Trabalho
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarAssinaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosDaSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.picture_capa = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listbox_sinopse = new System.Windows.Forms.ListBox();
            this.lbl_categorias = new System.Windows.Forms.Label();
            this.listbox_categorias = new System.Windows.Forms.ListBox();
            this.radiobtn_capacomum = new System.Windows.Forms.RadioButton();
            this.radiobtn_capadura = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart_popularidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.checkbox_queroesselivro = new System.Windows.Forms.CheckBox();
            this.listbox_capitulos = new System.Windows.Forms.ListBox();
            this.lbl_capitulos = new System.Windows.Forms.Label();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_capa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_popularidade)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNovoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.editarAssinaturaToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // criarNovoToolStripMenuItem
            // 
            this.criarNovoToolStripMenuItem.Name = "criarNovoToolStripMenuItem";
            this.criarNovoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.criarNovoToolStripMenuItem.Text = "Criar Novo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // editarAssinaturaToolStripMenuItem
            // 
            this.editarAssinaturaToolStripMenuItem.Name = "editarAssinaturaToolStripMenuItem";
            this.editarAssinaturaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editarAssinaturaToolStripMenuItem.Text = "Editar Assinatura";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosDaSemanaToolStripMenuItem,
            this.meusLivrosToolStripMenuItem,
            this.entregaToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // livrosDaSemanaToolStripMenuItem
            // 
            this.livrosDaSemanaToolStripMenuItem.Name = "livrosDaSemanaToolStripMenuItem";
            this.livrosDaSemanaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.livrosDaSemanaToolStripMenuItem.Text = "Livros da Semana";
            // 
            // meusLivrosToolStripMenuItem
            // 
            this.meusLivrosToolStripMenuItem.Name = "meusLivrosToolStripMenuItem";
            this.meusLivrosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.meusLivrosToolStripMenuItem.Text = "Meus Livros";
            // 
            // entregaToolStripMenuItem
            // 
            this.entregaToolStripMenuItem.Name = "entregaToolStripMenuItem";
            this.entregaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.entregaToolStripMenuItem.Text = "Entrega";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            // 
            // picture_capa
            // 
            this.picture_capa.Image = ((System.Drawing.Image)(resources.GetObject("picture_capa.Image")));
            this.picture_capa.Location = new System.Drawing.Point(25, 27);
            this.picture_capa.Name = "picture_capa";
            this.picture_capa.Size = new System.Drawing.Size(158, 227);
            this.picture_capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_capa.TabIndex = 1;
            this.picture_capa.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(212, 24);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(342, 37);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "FOCO E DISCIPLINA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "SINOPSE: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listbox_sinopse
            // 
            this.listbox_sinopse.FormattingEnabled = true;
            this.listbox_sinopse.Items.AddRange(new object[] {
            "Como o foco e disciplina influência na vida de uma pessoa,",
            "muitas pessoas pensam e pensam que ter muito foco as ",
            "ajudariam a conquistar as melhores coisas da vida, o quanto ",
            "disso é verdade?"});
            this.listbox_sinopse.Location = new System.Drawing.Point(260, 78);
            this.listbox_sinopse.Name = "listbox_sinopse";
            this.listbox_sinopse.Size = new System.Drawing.Size(294, 82);
            this.listbox_sinopse.TabIndex = 5;
            // 
            // lbl_categorias
            // 
            this.lbl_categorias.AutoSize = true;
            this.lbl_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categorias.Location = new System.Drawing.Point(189, 193);
            this.lbl_categorias.Name = "lbl_categorias";
            this.lbl_categorias.Size = new System.Drawing.Size(96, 15);
            this.lbl_categorias.TabIndex = 6;
            this.lbl_categorias.Text = "CATEGORIAS:";
            // 
            // listbox_categorias
            // 
            this.listbox_categorias.FormattingEnabled = true;
            this.listbox_categorias.Items.AddRange(new object[] {
            "Ação, Mistério, Aventura, Suspense"});
            this.listbox_categorias.Location = new System.Drawing.Point(284, 193);
            this.listbox_categorias.Name = "listbox_categorias";
            this.listbox_categorias.Size = new System.Drawing.Size(248, 17);
            this.listbox_categorias.TabIndex = 7;
            // 
            // radiobtn_capacomum
            // 
            this.radiobtn_capacomum.AutoSize = true;
            this.radiobtn_capacomum.Checked = true;
            this.radiobtn_capacomum.Location = new System.Drawing.Point(578, 76);
            this.radiobtn_capacomum.Name = "radiobtn_capacomum";
            this.radiobtn_capacomum.Size = new System.Drawing.Size(88, 17);
            this.radiobtn_capacomum.TabIndex = 8;
            this.radiobtn_capacomum.TabStop = true;
            this.radiobtn_capacomum.Text = "Capa Comum";
            this.radiobtn_capacomum.UseVisualStyleBackColor = true;
            // 
            // radiobtn_capadura
            // 
            this.radiobtn_capadura.AutoSize = true;
            this.radiobtn_capadura.Location = new System.Drawing.Point(578, 99);
            this.radiobtn_capadura.Name = "radiobtn_capadura";
            this.radiobtn_capadura.Size = new System.Drawing.Size(129, 17);
            this.radiobtn_capadura.TabIndex = 9;
            this.radiobtn_capadura.Text = "Capa Dura (+R$ 4,99)";
            this.radiobtn_capadura.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(25, 288);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 10;
            // 
            // chart_popularidade
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_popularidade.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_popularidade.Legends.Add(legend2);
            this.chart_popularidade.Location = new System.Drawing.Point(538, 171);
            this.chart_popularidade.Name = "chart_popularidade";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_popularidade.Series.Add(series2);
            this.chart_popularidade.Size = new System.Drawing.Size(232, 198);
            this.chart_popularidade.TabIndex = 11;
            this.chart_popularidade.Text = "chart1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_anterior
            // 
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.Location = new System.Drawing.Point(284, 394);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(240, 44);
            this.btn_anterior.TabIndex = 12;
            this.btn_anterior.Text = "<-- Ver Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            // 
            // checkbox_queroesselivro
            // 
            this.checkbox_queroesselivro.AutoSize = true;
            this.checkbox_queroesselivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_queroesselivro.Location = new System.Drawing.Point(284, 345);
            this.checkbox_queroesselivro.Name = "checkbox_queroesselivro";
            this.checkbox_queroesselivro.Size = new System.Drawing.Size(170, 24);
            this.checkbox_queroesselivro.TabIndex = 13;
            this.checkbox_queroesselivro.Text = "Quero Esse Livro!";
            this.checkbox_queroesselivro.UseVisualStyleBackColor = true;
            // 
            // listbox_capitulos
            // 
            this.listbox_capitulos.FormattingEnabled = true;
            this.listbox_capitulos.Items.AddRange(new object[] {
            "Capítulo 1: Preparando o ciclo de sofrimento",
            "Capítulo 2: Alex o Insuportável, Mia a Apaixonada ",
            "e Arthur o Vidente",
            "Capítulo 3: Desastre natural",
            "Capítulo 4: O Fim mutável? E a mudança drástica!",
            "EXTRA: Alex o rei do mundo"});
            this.listbox_capitulos.Location = new System.Drawing.Point(284, 230);
            this.listbox_capitulos.Name = "listbox_capitulos";
            this.listbox_capitulos.Size = new System.Drawing.Size(248, 95);
            this.listbox_capitulos.TabIndex = 15;
            // 
            // lbl_capitulos
            // 
            this.lbl_capitulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capitulos.Location = new System.Drawing.Point(189, 230);
            this.lbl_capitulos.Name = "lbl_capitulos";
            this.lbl_capitulos.Size = new System.Drawing.Size(111, 17);
            this.lbl_capitulos.TabIndex = 14;
            this.lbl_capitulos.Text = "CAPÍTULOS:";
            // 
            // btn_proximo
            // 
            this.btn_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximo.Location = new System.Drawing.Point(538, 394);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(232, 44);
            this.btn_proximo.TabIndex = 16;
            this.btn_proximo.Text = "Ver Próximo ->";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Popularidade:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.listbox_capitulos);
            this.Controls.Add(this.lbl_capitulos);
            this.Controls.Add(this.checkbox_queroesselivro);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.chart_popularidade);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.radiobtn_capadura);
            this.Controls.Add(this.radiobtn_capacomum);
            this.Controls.Add(this.listbox_categorias);
            this.Controls.Add(this.lbl_categorias);
            this.Controls.Add(this.listbox_sinopse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.picture_capa);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_capa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_popularidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarAssinaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosDaSemanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.PictureBox picture_capa;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbox_sinopse;
        private System.Windows.Forms.Label lbl_categorias;
        private System.Windows.Forms.ListBox listbox_categorias;
        private System.Windows.Forms.RadioButton radiobtn_capacomum;
        private System.Windows.Forms.RadioButton radiobtn_capadura;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_popularidade;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.CheckBox checkbox_queroesselivro;
        private System.Windows.Forms.ListBox listbox_capitulos;
        private System.Windows.Forms.Label lbl_capitulos;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Label label5;
    }
}