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
    public partial class fCadastrarCliente : Form
    {
        private string stringConexao;
        private SqlDataReader lerCpf;
        private SqlDataAdapter adaptador;
        private DataSet dados;

        private string formatoData = "MM'-'dd'-'yyyy";

        public fCadastrarCliente(fPrincipal principal)
        {
            InitializeComponent();
            stringConexao = principal.stringConexao;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    string cpf = msbCpf.Text.Replace(".", "").Replace("-", "").Replace(" ","");
                    string rg = msbRg.Text.Replace(".", "").Replace("-", "").Replace(" ", "");
                    char sexo;
                    if(rbFeminino.Checked)
                        sexo='F';
                    else
                        sexo='M';

                    dados = new DataSet();
                    adaptador = new SqlDataAdapter();
                    adaptador.Fill(dados, "Tabela");
                    SqlCommand comandoInserir = new SqlCommand("INSERT INTO CLIENTES (nome,cpf,rg,data_nasc,sexo,profissao,email,estado_civil) VALUES('" + tbNome.Text + "','" + cpf + "','" + rg + "','" + msbDataNascimento.Text + "','" + sexo + "','" + tbProfissao + "','" + tbEmail + "','" + cmbEstadoCivil.SelectedItem + "')", conexao);

                    
                    conexao.Open();
                    SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTES WHERE cpf = '" + cpf + "'", conexao);
                    lerCpf = comando.ExecuteReader();
                    if (lerCpf.HasRows) // Verifica se foi encontrado o CPF no banco, pois se ele for, haverá linhas no SQLDataReader lerCpf
                    {
                        //
                    }
                    else
                        MessageBox.Show("Impossível adicionar, o cliente já está cadastrado!\n\nFavor verificar.");

                }
                catch
                { }
                finally
                {
                    if (conexao != null)
                        conexao.Close();

                }
            }

        }

       

       
    }
}