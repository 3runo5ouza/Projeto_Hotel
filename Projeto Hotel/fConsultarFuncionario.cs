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
        public fConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void fConsultarFuncionario_Load(object sender, EventArgs e)
        {
            recarregaCombo();
            enableDisableTbs(false);
        }
        
        //const string STRING_CONEXAO = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\banco_hotel.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        const string STRING_CONEXAO = @"Data Source=.\SQLEXPRESS;Initial Catalog = banco_hotel;Integrated Security=True;";
        
        DataSet ds = new DataSet();

        public void recarregaCombo()
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlConnection conexao = new SqlConnection(STRING_CONEXAO);
            SqlCommand comando = new SqlCommand("SELECT * FROM vw_funcion_endereco ORDER BY nome", conexao);
            adaptador.SelectCommand = comando;
            adaptador.Fill(ds, "funcs");

            // Tabela Endereco
            comando = new SqlCommand("SELECT * FROM endereco_funcionarios", conexao);
            adaptador.SelectCommand = comando;
            adaptador.Fill(ds, "endereco");

            ds.Tables["endereco"].Columns["id_funcionarios"].AllowDBNull = false;
            ds.Tables["endereco"].Columns["id_funcionarios"].Unique = true;
            ds.Tables["endereco"].PrimaryKey = new DataColumn[] { ds.Tables["endereco"].Columns["id_funcionarios"] };



            cbConsulta.Items.Clear();

            foreach (DataRow linha in ds.Tables["funcs"].Rows)
            {
                cbConsulta.Items.Add(linha["nome"].ToString());
            }
        }

        private void bCarregar_Click(object sender, EventArgs e)
        {
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

        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            bCarregar_Click(null, null);
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
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            enableDisableTbs(true);
        }


    }
}
