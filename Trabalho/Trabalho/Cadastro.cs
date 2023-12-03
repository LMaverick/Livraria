using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Net;//HttpWebRequest, HttpWebResponse
using System.IO;//StreamReader

//Os imports abaixo são para trabalhar com json - classe JObject
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Trabalho
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            openFileDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
		{
			//login dados
			string nome = txt_nome.Text;
			string email = txt_email.Text;
            string senha = txt_senha.Text;
            string dtnasc	= dateTimePicker1.Text;

            //endereço pra estrega
            string cep = txt_cep.Text;
            string endereco = txt_endereco.Text;
            string bairro = txt_bairro.Text;
            string cidade = txt_cidade.Text;
            string numero = txt_numcasa.Text;
            string uf = txt_uf.Text;
            string telefone = maskedTextBox1.Text;

			//assinatura
			string plano = comboBox1.Text;
			string cobranca	= checkBox3.Checked ? "sim" : "não"; 
			string fretegratis = checkBox1.Checked ? "sim" : "não";
			string fretepago = checkBox2.Checked ? "sim" : "não";

			string sql = $"insert into clientes(" +
					 "nome, email, senha, dtnasc, cep, endereco, bairro, cidade, numero, uf, telefone, plano,cobranca,fretegratis, fretepago" +
					 "values(" +
					 $"'{nome}', '{email}', '{senha}', '{dtnasc}', '{cep}', '{endereco}', '{bairro}', '{cidade}', '{numero}', '{uf}', '{telefone}', '{plano}', '{cobranca}', '{fretegratis}', '{fretepago}'";

			MySqlConnection con = null;
			MySqlCommand cmd = null;
			try
			{
				con = new MySqlConnection("server='localhost';uid='root';pwd='';database='livraria';useAffectedRows=true");
				cmd = new MySqlCommand(sql, con);
				con.Open();
				int qtdLinhasAfetadas = cmd.ExecuteNonQuery();
				if (qtdLinhasAfetadas >= 0)
				{
					MessageBox.Show("Dados inseridos com sucesso!");
				}
				else
				{
					throw new Exception();
				}
			}catch(Exception ex)
			{
				MessageBox.Show("Logue no site e faça o plano na amazon para logar aqui!");
			}
			finally
			{
				con.Close();
				con.Dispose();
				cmd.Dispose();
			}
		

        }

        private void button1_Click(object sender, EventArgs e)
        {

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txt_cep.Text + "/json/?ra=123&senha=uni9");
            myReq.ContentType = "application/json";
            myReq.Method = "GET";
            var myResp = (HttpWebResponse)myReq.GetResponse();

            using (var streamReader = new StreamReader(myResp.GetResponseStream()))
            {
                var resultQR = streamReader.ReadToEnd();
                string jsonStringsign = resultQR;
                JObject meuJson = JObject.Parse(jsonStringsign);

                txt_endereco.Text = meuJson.Root["logradouro"].ToString();
                txt_bairro.Text = meuJson.Root["bairro"].ToString();
                txt_cidade.Text = meuJson.Root["localidade"].ToString();
                txt_uf.Text = meuJson.Root["uf"].ToString();

            }
        }
    }
}
