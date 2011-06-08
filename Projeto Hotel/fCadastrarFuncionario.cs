using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Projeto_Hotel
{
    public partial class fCadastrarFuncionario : Form
    {
        //const string STRING_CONEXAO = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\banco_hotel.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        const string STRING_CONEXAO = @"Data Source=.\SQLEXPRESS; Initial Catalog = BANCO_HOTEL; Integrated Security=True;";

        public fCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {

            using (SqlConnection conexao = new SqlConnection(STRING_CONEXAO))
            {
                try
                {
                    conexao.Open();
                    SqlCommand comIncluiFuncionario = new SqlCommand();
                    comIncluiFuncionario.CommandText = "INSERT INTO funcionarios VALUES (@nome, @cpf, @rg, @data_nasc, @sexo, @data_admissao, @telefone, @email, @usuario, @senha)";
                    comIncluiFuncionario.Connection = conexao;

                    SqlParameter parametros;
                    parametros = new SqlParameter("@nome", SqlDbType.VarChar, 100, "nome");
                    parametros.Value = tbNome.Text;
                    comIncluiFuncionario.Parameters.Add(parametros);

                    // O CPF é utilizado como chave estrangeira na tabela de endereço do funcionário, por isso está sendo armazenada
                    string cpf = Regex.Replace(mtbCpf.Text, @"[^\d]", ""); // Tradução do Regex: O que não for número deve ser modificado para vazio - retirado

                    parametros = new SqlParameter("@cpf", SqlDbType.VarChar, 11, "cpf");
                    parametros.Value = cpf;
                    comIncluiFuncionario.Parameters.Add(parametros);
                    
                    parametros = new SqlParameter("@rg", SqlDbType.VarChar, 9, "rg");
                    parametros.Value = Regex.Replace(mtbRg.Text, @"[^\d^x]", "");
                    comIncluiFuncionario.Parameters.Add(parametros);

                    parametros = new SqlParameter("@data_nasc", SqlDbType.Date);
                    parametros.SourceColumn = "data_nasc";
                    parametros.Value = Convert.ToDateTime(mtbDataNascimento.Text).ToString("yyyy-MM-dd");
                    comIncluiFuncionario.Parameters.Add(parametros);

                    parametros = new SqlParameter("@sexo", SqlDbType.VarChar, 1, "sexo");
                    parametros.Value = rbSexoM.Checked ? 'M' : 'F';
                    comIncluiFuncionario.Parameters.Add(parametros);

                    parametros = new SqlParameter("@data_admissao", SqlDbType.Date);
                    parametros.Value = Convert.ToDateTime(mtbDataAdmissao.Text).ToString("yyyy-MM-dd");
                    parametros.SourceColumn ="data_admissao";
                    comIncluiFuncionario.Parameters.Add(parametros);

                    parametros = new SqlParameter("@telefone", SqlDbType.VarChar, 15, "telefone");
                    parametros.Value = Regex.Replace(mtbTelefone.Text, @"[^\d]", "");
                    comIncluiFuncionario.Parameters.Add(parametros);

                    parametros = new SqlParameter("@email", SqlDbType.VarChar, 100, "email");
                    parametros.Value = tbEmail.Text;
                    comIncluiFuncionario.Parameters.Add(parametros);

                    parametros = new SqlParameter("@usuario", SqlDbType.VarChar, 30, "usuario");
                    parametros.Value = tbUsuario.Text;
                    comIncluiFuncionario.Parameters.Add(parametros);

                    parametros = new SqlParameter("@senha", SqlDbType.VarChar, 20, "senha");
                    parametros.Value = tbSenha.Text;
                    comIncluiFuncionario.Parameters.Add(parametros);

                    comIncluiFuncionario.ExecuteNonQuery();

                    // Incluir info do endereço do funcionário
                    SqlCommand comIncluiEndereco = new SqlCommand();
                    comIncluiEndereco.CommandText = "INSERT INTO endereco_funcionarios VALUES(@id_funcionarios, @rua, @numero, @complemento, @bairro, @cidade, @cep, @estado, @pais)";
                    comIncluiEndereco.Connection = conexao;

                    parametros = new SqlParameter("@id_funcionarios", SqlDbType.VarChar, 11, "id_funcionarios");
                    parametros.Value = cpf;
                    comIncluiEndereco.Parameters.Add(parametros);

                    parametros = new SqlParameter("@rua", SqlDbType.VarChar, 100, "rua");
                    parametros.Value = tbRua.Text;
                    comIncluiEndereco.Parameters.Add(parametros);

                    parametros = new SqlParameter("@numero", SqlDbType.VarChar, 8, "numero");
                    parametros.Value = tbNumero.Text;
                    comIncluiEndereco.Parameters.Add(parametros);

                    parametros = new SqlParameter("@complemento", SqlDbType.VarChar, 100, "complemento");
                    parametros.Value = tbComplemento.Text;
                    comIncluiEndereco.Parameters.Add(parametros);

                    parametros = new SqlParameter("@bairro", SqlDbType.VarChar, 30, "bairro");
                    parametros.Value = tbBairro.Text;
                    comIncluiEndereco.Parameters.Add(parametros);

                    parametros = new SqlParameter("@cidade", SqlDbType.VarChar, 80, "ciidade");
                    parametros.Value = tbCidade.Text;
                    comIncluiEndereco.Parameters.Add(parametros);

                    parametros = new SqlParameter("@cep", SqlDbType.VarChar, 8, "cep");
                    parametros.Value = tbCep.Text;
                    comIncluiEndereco.Parameters.Add(parametros);

                    parametros = new SqlParameter("@estado", SqlDbType.VarChar, 20, "estado");
                    parametros.Value = tbEstado.Text;
                    comIncluiEndereco.Parameters.Add(parametros);

                    parametros = new SqlParameter("@pais", SqlDbType.VarChar, 30, "pais");
                    parametros.Value = tbPais.Text;
                    comIncluiEndereco.Parameters.Add(parametros);

                    comIncluiEndereco.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if(conexao != null)
                        conexao.Close();
                    this.Close();
                }
            }

        }

    }
}
