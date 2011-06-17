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
    public partial class fCadastrarQuarto : Form
    {
        const string STRING_CONEXAO = @"Data Source = BRUNO-PC\SQLEXPRESS; Initial Catalog = banco_hotel; Integrated Security = SSPI";

        public fCadastrarQuarto()
        {
            InitializeComponent();
        }

        private void fCadastrarQuarto_Load(object sender, EventArgs e)
        {

        }

        private void bOk_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(STRING_CONEXAO))
            {
                try
                {
                    conexao.Open();
                    SqlCommand comandoInclusao = new SqlCommand();
                    comandoInclusao.CommandText =
                        "INSERT INTO quartos VALUES(@numero, @andar, @valor, @tipo_cama, @internet, @frigobar, @tv, @hidro)";
                    comandoInclusao.Connection = conexao;

                    SqlParameter parametros;
                    parametros = new SqlParameter("@numero", SqlDbType.Int, 5, "numero");
                    parametros.Value = tbNumero.Text;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@andar", SqlDbType.Int, 5, "andar");
                    parametros.Value = tbAndar.Text;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@valor", SqlDbType.Decimal, 8, "valor");
                    parametros.Value = tbValor.Text;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@tipo_cama", SqlDbType.VarChar, 10, "tipo_cama");
                    parametros.Value = cbTipoCama.SelectedText;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@internet", SqlDbType.Bit, 1, "internet");
                    parametros.Value = cBoxInternet.Checked ? 1 : 0;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@frigobar", SqlDbType.Bit, 1, "frigobar");
                    parametros.Value = cBoxFrigobar.Checked ? 1 : 0;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@tv", SqlDbType.Bit, 1, "tv");
                    parametros.Value = cBoxTv.Checked ? 1 : 0;
                    comandoInclusao.Parameters.Add(parametros);

                    parametros = new SqlParameter("@hidro", SqlDbType.Bit, 1, "hidro");
                    parametros.Value = cBoxHidro.Checked ? 1 : 0;
                    comandoInclusao.Parameters.Add(parametros);

                    comandoInclusao.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conexao != null)
                        conexao.Close();
                    this.Close();
                }

            }
        }

        private void tbAndar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && !(e.KeyChar == 8)) || (e.Equals(Keys.Control)))
            {
                e.Handled = true;
            } 
        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(tbValor.Text.Contains(","))
            {
                if ((!char.IsNumber(e.KeyChar) && !(e.KeyChar == 8)) || (e.Equals(Keys.Control)))
                {
                    e.Handled = true;
                } 
            }
            
            if ((!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == 8)) || (e.Equals(Keys.Control)))
            {
                e.Handled = true;
            } 
        }
    }
}
        

