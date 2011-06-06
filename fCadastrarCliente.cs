using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


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
            string cpf = msbCpf.Text.Replace(".", "").Replace("-", "").Replace(" ","");
            string rg = msbRg.Text.Replace(".", "").Replace("-", "").Replace(" ", "");
                        
            if (Regex.IsMatch(cpf, @"[\d]{8}") )
            {

               


                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    try
                    {
                        char sexo;
                        if (rbFeminino.Checked)
                            sexo = 'F';
                        else
                            sexo = 'M';

                        dados = new DataSet();
                        adaptador = new SqlDataAdapter();
                        conexao.Open();
                        SqlCommand comandoSelecao = new SqlCommand("SELECT * FROM CLIENTES", conexao);
                        adaptador.SelectCommand = comandoSelecao;
                        adaptador.Fill(dados, "Clientes");


                        SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTES WHERE cpf = '" + cpf + "'", conexao);
                        lerCpf = comando.ExecuteReader();
                        if (!lerCpf.HasRows) // Verifica se foi encontrado o CPF no banco, pois se ele for, haverá linhas no SQLDataReader lerCpf
                        {
                            int controlaRegistro = dados.Tables["Clientes"].Rows.Count;
                            DataRow novoRegistro = dados.Tables["Clientes"].NewRow();
                            novoRegistro["Nome"] = tbNome.Text;
                            novoRegistro["CPF"] = cpf;
                            novoRegistro["RG"] = rg;
                            novoRegistro["Data_NasC"] = msbDataNascimento.Text;
                            novoRegistro["Sexo"] = sexo;
                            novoRegistro["Profissao"] = tbProfissao.Text;
                            novoRegistro["Email"] = tbEmail.Text;
                            novoRegistro["Estado_Civil"] = cmbEstadoCivil.SelectedItem.ToString();
                            dados.Tables["Clientes"].Rows.Add(novoRegistro);

                            comandoSelecao = new SqlCommand("SELECT * FROM ENDERECO_CLIENTES", conexao);
                            adaptador.SelectCommand = comandoSelecao;
                            conexao.Close();
                            conexao.Open();
                            adaptador.Fill(dados, "Endereco_Clientes");
                            novoRegistro = dados.Tables["Endereco_Clientes"].NewRow();
                            novoRegistro["Id_Cliente"] = cpf;
                            novoRegistro["Rua"] = cmbLogradouro.SelectedItem.ToString() + " " + tbEndereco.Text;
                            novoRegistro["Numero"] = tbNumero.Text;
                            novoRegistro["Complemento"] = tbComplemento.Text;
                            novoRegistro["Bairro"] = tbBairro.Text;
                            novoRegistro["Cidade"] = cmbCidade.Text;
                            novoRegistro["CEP"] = msbCep.Text;
                            novoRegistro["Estado"] = cmbEstado.Text;
                            novoRegistro["Pais"] = tbPais.Text;
                            dados.Tables["Endereco_Clientes"].Rows.Add(novoRegistro);

                            comandoSelecao = new SqlCommand("SELECT * FROM TELEFONES", conexao);
                            adaptador.SelectCommand = comandoSelecao;
                            adaptador.Fill(dados, "Telefones");
                            novoRegistro = dados.Tables["Telefones"].NewRow();
                            novoRegistro["Id_Cliente"] = cpf;
                            novoRegistro["Obrigatorio"] = msbTelefoneObrigatorio.Text;
                            novoRegistro["Opcional"] = msbTelefoneOpcional.Text;
                            dados.Tables["Telefones"].Rows.Add(novoRegistro);

                            SqlCommand comandoInclusao = new SqlCommand("INSERT INTO CLIENTES (cpf,nome,rg,data_nasc,sexo,profissao,email,estado_civil)VALUES(@CPF,@NOME,@RG,@DATA_NASC,@SEXO,@PROFISSAO,@EMAIL,@ESTADO_CIVIL)", conexao);
                            //Parâmetros do construtor: nome do parâmetro, tipo, tamanho, nome local (no DataSet)
                            comandoInclusao.Parameters.Add("@CPF", SqlDbType.VarChar, 11, "Cpf");
                            comandoInclusao.Parameters.Add("@NOME", SqlDbType.VarChar, 100, "Nome");
                            comandoInclusao.Parameters.Add("@RG", SqlDbType.VarChar, 10, "Rg");
                            comandoInclusao.Parameters.Add("@DATA_NASC", SqlDbType.VarChar, 10, "Data_Nasc");
                            comandoInclusao.Parameters.Add("@SEXO", SqlDbType.Char, 1, "Sexo");
                            comandoInclusao.Parameters.Add("@PROFISSAO", SqlDbType.VarChar, 50, "Profissao");
                            comandoInclusao.Parameters.Add("@EMAIL", SqlDbType.VarChar, 50, "Email");
                            comandoInclusao.Parameters.Add("@ESTADO_CIVIL", SqlDbType.VarChar, 15, "Estado_Civil");

                            adaptador.InsertCommand = comandoInclusao;

                            comandoInclusao = new SqlCommand("INSERT INTO ENDERECO_CLIENTES (id_cliente,rua,numero,complemento,bairro,cidade,cep,estado,pais) VALUES (@ID_CLIENTE,@RUA,@NUMERO,@COMPLEMENTO,@BAIRRO,@CIDADE,@CEP,@ESTADO,@PAIS)", conexao);
                            comandoInclusao.Parameters.Add("@ID_CLIENTE", SqlDbType.VarChar, 11, "Id_Cliente");
                            comandoInclusao.Parameters.Add("@RUA", SqlDbType.VarChar, 100, "Rua");
                            comandoInclusao.Parameters.Add("@NUMERO", SqlDbType.VarChar, 8, "Numero");
                            comandoInclusao.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar, 40, "Complemento");
                            comandoInclusao.Parameters.Add("@BAIRRO", SqlDbType.VarChar, 30, "Bairro");
                            comandoInclusao.Parameters.Add("@CIDADE", SqlDbType.VarChar, 80, "Cidade");
                            comandoInclusao.Parameters.Add("@CEP", SqlDbType.VarChar, 8, "Cep");
                            comandoInclusao.Parameters.Add("@ESTADO", SqlDbType.VarChar, 20, "Estado");
                            comandoInclusao.Parameters.Add("@PAIS", SqlDbType.VarChar, 30, "Pais");

                            adaptador.InsertCommand = comandoInclusao;

                            comandoInclusao = new SqlCommand("INSERT INTO TELEFONES (id_cliente,obrigatorio,opcional) VALUES (@ID_CLIENTE,@OBRIGATORIO,@OPCIONAL)", conexao);
                            //Parâmentros
                            comandoInclusao.Parameters.Add("@ID_CLIENTE", SqlDbType.VarChar, 11, "Id_Cliente");
                            comandoInclusao.Parameters.Add("@OBRIGATORIO", SqlDbType.VarChar, 15, "Obrigatorio");
                            comandoInclusao.Parameters.Add("@OPCIONAL", SqlDbType.VarChar, 15, "Opcional");

                            adaptador.InsertCommand = comandoInclusao;


                            adaptador.Update(dados, "Clientes");
                            adaptador.Update(dados, "Endereco_Clientes");
                            adaptador.Update(dados, "Telefones");





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
        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os dados não serão salvos, deseja fechar mesmo assim?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

       

       
    }
}