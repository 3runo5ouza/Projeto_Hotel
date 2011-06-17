using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Hotel
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        Dictionary<string, string> usuariosSenhas = new Dictionary<string, string>();
        const string STRING_CONEXAO = @"Data Source=.\SQLEXPRESS;Initial Catalog = banco_hotel;Integrated Security=True;";
        public bool senhaCorreta = false;
        private string codigoUsuario = "";

        public string getCodigoUsuario()
        {
            return codigoUsuario;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {            
            SqlConnection conexao = new SqlConnection(STRING_CONEXAO);
            SqlDataReader reader = null;
            conexao.Open();

            // Não serão utilizados SqlParameters, pois o comando sql ocorre sem interfência do usuário
            SqlCommand comando = new SqlCommand("SELECT usuario, senha FROM funcionarios", conexao);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                usuariosSenhas.Add(reader["usuario"].ToString(), reader["senha"].ToString());
            }
            reader.Close();
            conexao.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                login();
            }
        }

        private void login()
        {

            if (usuariosSenhas.ContainsKey(tbUsuario.Text))
            {
                if (usuariosSenhas[tbUsuario.Text] == tbSenha.Text)
                {
                    this.Close();
                    senhaCorreta = true;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Senha Errada");
                }
            }
            else
            {
                MessageBox.Show("Este usuário não existe.");
            }
        }
        
    }
}
