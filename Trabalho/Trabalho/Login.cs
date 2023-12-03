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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string nome = txtbox_usuario.Text;
            string senha = txtbox_senha.Text;
            string sql = $"select * from clientes where nome={nome} and senha='{senha}'";

            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            try
            {
                con = new MySqlConnection("server='localhost';uid='root';pwd='';database='livraria'");
                cmd = new MySqlCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    new Principal().Show();
                    Principal p = new Principal();
                    p.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario invalido!!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bem-vindo",nome);
                this.Hide();
                new Principal().Show();
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lbl_cadastrar_Click(object sender, EventArgs e)
        {
            new Cadastro().Show();
            this.Hide();
        }
    }
}
