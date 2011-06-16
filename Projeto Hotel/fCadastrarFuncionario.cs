using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Projeto_Hotel
{
    public partial class fCadastrarFuncionario : Form
    {
        const string STRING_CONEXAO = @"Data Source = BRUNO-PC\SQLEXPRESS; Initial Catalog = banco_hotel; Integrated Security = SSPI";

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
                    SqlCommand comandoInclusao = new SqlCommand();
                    comandoInclusao.CommandText = "INSERT INTO funcionarios VALUES (@nome, @cpf, @rg, @data_nasc, @sexo, @data_admissao, @telefone, @email, @usuario, @senha)";
                    comandoInclusao.Connection = conexao;

                    SqlParameter parametros;
                    parametros = new SqlParameter("@nome", SqlDbType.VarChar, 100, "nome");
                    parametros.Value = tbNome.Text;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@cpf", SqlDbType.VarChar, 11, "cpf");
                    parametros.Value = Regex.Replace(mtbCpf.Text, @"[^\d]", "");
                    comandoInclusao.Parameters.Add(parametros);
                    
                    parametros = new SqlParameter("@rg", SqlDbType.VarChar, 9, "rg");
                    parametros.Value = Regex.Replace(mtbRg.Text, @"[^\d^x]", "");
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@data_nasc", SqlDbType.Date);
                    parametros.SourceColumn = "data_nasc";
                    parametros.Value = Convert.ToDateTime(mtbDataNascimento.Text).ToString("yyyy-MM-dd");
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@sexo", SqlDbType.VarChar, 1, "sexo");
                    parametros.Value = rbSexoM.Checked ? 'M' : 'F';
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@data_admissao", SqlDbType.Date);
                    parametros.Value = Convert.ToDateTime(mtbDataAdmissao.Text).ToString("yyyy-MM-dd");
                    parametros.SourceColumn ="data_admissao";
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@telefone", SqlDbType.VarChar, 15, "telefone");
                    parametros.Value = Regex.Replace(mtbTelefone.Text, @"[^\d]", "");
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@email", SqlDbType.VarChar, 100, "email");
                    parametros.Value = tbEmail.Text;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@usuario", SqlDbType.VarChar, 30, "usuario");
                    parametros.Value = tbUsuario.Text;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@senha", SqlDbType.VarChar, 20, "senha");
                    parametros.Value = tbSenha.Text;
                    comandoInclusao.Parameters.Add(parametros);

                    comandoInclusao.ExecuteNonQuery();
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
