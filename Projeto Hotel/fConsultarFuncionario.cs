using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Hotel
{
    public partial class fConsultarFuncionario : Form
    {
        const string STRING_CONEXAO = @"Data Source=.\SQLEXPRESS;Initial Catalog = banco_hotel;Integrated Security=True;";

        DataSet ds = new DataSet();

        // Adaptador para SELECT na VIEW vw_funcion_endereco e UPDATE na tabela funcionarios
        SqlDataAdapter adaptador = new SqlDataAdapter();

        // Adaptador para UPDATE na tabela endereco_funcionarios
        SqlDataAdapter adapEnderecoFuncionario = new SqlDataAdapter();

        private void fConsultarFuncionario_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(STRING_CONEXAO);

            // Utiliza uma VIEW para criar um dataSet com os dados das tabelas funcionários e endereco_funcionário
            SqlCommand comandoSelecao = new SqlCommand("SELECT * FROM vw_funcion_endereco ORDER BY nome", conexao);
            adaptador.SelectCommand = comandoSelecao;
            adaptador.Fill(ds, "funcs");

            // Cria comando de UPDATE da tabela funcionarios
            SqlParameter parametro;
            SqlCommand comandoAlteracao = new SqlCommand("UPDATE funcionarios SET nome = @nome, rg = @rg," +
            "data_nasc = @data_nasc, sexo = @sexo, data_admissao = @data_admissao, telefone = @telefone, " +
            "email = @email, usuario = @usuario, senha = @senha WHERE cpf = @cpf", conexao);
            //FALTA UPDATE DO ENDERECO

            parametro = new SqlParameter("@nome", SqlDbType.VarChar, 100, "nome");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@rg", SqlDbType.VarChar, 12, "rg");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@data_nasc", SqlDbType.VarChar, 10, "data_nasc");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@sexo", SqlDbType.VarChar, 1, "sexo");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@data_admissao", SqlDbType.VarChar, 10, "data_admissao");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@telefone", SqlDbType.VarChar, 15, "telefone");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@email", SqlDbType.VarChar, 100, "email");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@usuario", SqlDbType.VarChar, 20, "usuario");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@senha", SqlDbType.VarChar, 20, "senha");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@cpf", SqlDbType.VarChar, 11, "cpf");
            parametro.SourceVersion = DataRowVersion.Original;
            comandoAlteracao.Parameters.Add(parametro);

            adaptador.UpdateCommand = comandoAlteracao;

            // Cria comando UPDATE na tabela endereco_funcionarios
            comandoAlteracao = new SqlCommand("UPDATE endereco_funcionarios SET rua = @rua, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, cep = @cep, estado = @estado, pais = @pais WHERE id_funcionarios = @id_funcionarios", conexao);

            parametro = new SqlParameter("@rua", SqlDbType.VarChar, 100, "rua");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@numero", SqlDbType.VarChar, 8, "numero");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@complemento", SqlDbType.VarChar, 100, "complemento");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@bairro", SqlDbType.VarChar, 100, "bairro");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);

            parametro = new SqlParameter("@nome", SqlDbType.VarChar, 100, "nome");
            parametro.SourceVersion = DataRowVersion.Current;
            comandoAlteracao.Parameters.Add(parametro);


            recarregaCombo(-1);
        }

        public void enableDisableTbs(bool opcao)
        {
            tbNome.Enabled = opcao;
            mtbCpf.Enabled = opcao;
            mtbRg.Enabled = opcao;
            rbSexoF.Enabled = opcao;
            rbSexoM.Enabled = opcao;
            mtbDataAdmissao.Enabled = opcao;
            mtbDataNascimento.Enabled = opcao;
            mtbTelefone.Enabled = opcao;
            tbEmail.Enabled = opcao;
            tbUsuario.Enabled = opcao;
            tbSenha.Enabled = opcao;
            tbRua.Enabled = opcao;
            tbNumero.Enabled = opcao;
            tbComplemento.Enabled = opcao;
            tbBairro.Enabled = opcao;
            tbCidade.Enabled = opcao;
            tbCep.Enabled = opcao;
            tbEstado.Enabled = opcao;
            tbPais.Enabled = opcao;
            bConfirmar.Enabled = opcao;
        }

        public void recarregaCombo(int indice)
        {
            enableDisableTbs(false);

            // Limpa e depois recarrega o combo
            cbConsulta.Items.Clear();
            foreach (DataRow linha in ds.Tables["funcs"].Rows)
            {
                cbConsulta.Items.Add(linha["nome"].ToString());
            }

            cbConsulta.SelectedIndex = indice;
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            int itemSelecionado = cbConsulta.SelectedIndex;
            MessageBox.Show(cbConsulta.SelectedIndex.ToString());
            DataRow registro = ds.Tables["funcs"].Rows[itemSelecionado];
            registro["nome"] = tbNome.Text;
            registro["rg"] = mtbRg.Text;
            registro["data_nasc"] = mtbDataNascimento.Text;
            registro["sexo"] = (rbSexoM.Checked) ? "M" : "F";
            registro["data_admissao"] = mtbDataAdmissao.Text;
            registro["telefone"] = mtbTelefone.Text;
            registro["email"] = tbEmail.Text;
            registro["usuario"] = tbUsuario.Text;
            registro["senha"] = tbSenha.Text;


            
            adaptador.Update(ds, "funcs");
            recarregaCombo(itemSelecionado);
        }

        public void carregaInformacoes()
        {
            // O comboBox cbConsulta é criado com o DataSet, por isso é possível utilizar seu índice como referência para o DataRow
            DataRow dr = ds.Tables["funcs"].Rows[cbConsulta.SelectedIndex];
            tbNome.Text = dr["nome"].ToString();
            mtbCpf.Text = dr["cpf"].ToString();
            mtbRg.Text = dr["rg"].ToString();
            mtbDataNascimento.Text = dr["data_nasc"].ToString();
            if (dr["sexo"].ToString() == "M")
            {
                rbSexoM.Checked = true;
            }
            else
            {
                rbSexoF.Checked = true;
            }
            mtbDataAdmissao.Text = dr["data_admissao"].ToString();
            mtbTelefone.Text = dr["telefone"].ToString();
            tbEmail.Text = dr["email"].ToString();
            tbUsuario.Text = dr["usuario"].ToString();
            tbSenha.Text = dr["senha"].ToString();
            tbRua.Text = dr["rua"].ToString();
            tbNumero.Text = dr["numero"].ToString();
            tbComplemento.Text = dr["complemento"].ToString();
            tbBairro.Text = dr["bairro"].ToString();
            tbCidade.Text = dr["cidade"].ToString();
            tbCep.Text = dr["cep"].ToString();
            tbEstado.Text = dr["estado"].ToString();
            tbPais.Text = dr["pais"].ToString();
        }
        private void bCarregar_Click(object sender, EventArgs e)
        {
            carregaInformacoes();
        }

        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaInformacoes();
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            enableDisableTbs(true);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public fConsultarFuncionario()
        {
            InitializeComponent();
        }

    }
}
