using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Exe01_Cadastro
{
    public partial class frmFornecedores : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        MySqlDataReader SQLDr;
        string SQLString;

        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void MostraFornecedores()
        {           
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                SQLString = "Select id, nome, cnpj from fornecedores order by nome";

                //MessageBox.Show(SQLString);

                SQLDa = new MySqlDataAdapter(SQLString, SQLConexao);

                DataTable dtFornecedores = new DataTable();

                SQLDa.Fill(dtFornecedores);

                dgvFornecedores.DataSource = dtFornecedores;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {   //Conexão com o banco
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                //Comando Sql
                SQLString = "insert into fornecedores(nome, cnpj) values " + "(@nome, @cnpj)";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@nome", txtNome.Text);
                SQLComando.Parameters.AddWithValue("@cnpj", txtCnjp.Text);

                //abrir Conexão com o banco
                SQLConexao.Open();

                //Execultar comando SQL
                SQLComando.ExecuteNonQuery();

                // mostrar o ID registro inserido ///
                if(SQLComando.LastInsertedId != 0)
                {
                    SQLComando.Parameters.Add(new MySqlParameter("ultimoId", SQLComando.LastInsertedId));
                    txtID.Text = Convert.ToString(SQLComando.Parameters["@ultimoId"].Value);
                }


                MessageBox.Show("Fornecedor cadastrado com sucesso");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }

            MostraFornecedores();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtIdConsulta.Text.Equals(string.Empty))
                MostraFornecedores();
            else
            {
                try
                {   //Conexão com o banco
                    string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                    SQLConexao = new MySqlConnection(stringConexao);

                    //Comando Sql
                    SQLString = "select id, nome, cnpj from fornecedores where id =@id";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtIdConsulta.Text);
             

                    //abrir Conexão com o banco
                    SQLConexao.Open();

                    //Execultar comando SQL
                    SQLDr = SQLComando.ExecuteReader();

                    while (SQLDr.Read())
                    {
                        txtID.Text = Convert.ToString(SQLDr["id"]);
                        txtNome.Text = Convert.ToString(SQLDr["nome"]);
                        txtCnjp.Text = Convert.ToString(SQLDr["cnpj"]);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    SQLConexao.Close();
                    SQLConexao = null;
                    SQLComando = null;
                }
            }
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            txtID.Text = Convert.ToString(dgvFornecedores[0, e.RowIndex].Value);
            txtNome.Text = Convert.ToString(dgvFornecedores[1, e.RowIndex].Value);
            txtCnjp.Text = Convert.ToString(dgvFornecedores[2, e.RowIndex].Value);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {   //Conexão com o banco
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                //Comando Sql
                SQLString = "update fornecedores set nome = @nome, cnpj = @cnpj where id =@id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtID.Text);
                SQLComando.Parameters.AddWithValue("@nome", txtNome.Text);
                SQLComando.Parameters.AddWithValue("@cnpj", txtCnjp.Text);

                //abrir Conexão com o banco
                SQLConexao.Open();

                //Execultar comando SQL
                SQLComando.ExecuteNonQuery();


                MessageBox.Show("Fornecedor alterado com sucesso");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }

            MostraFornecedores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {   //Conexão com o banco
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                //Comando Sql
                SQLString = "delete from fornecedores where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtID.Text);
                SQLComando.Parameters.AddWithValue("@nome", txtNome.Text);
                SQLComando.Parameters.AddWithValue("@cnpj", txtCnjp.Text);

                //abrir Conexão com o banco
                SQLConexao.Open();

                //Execultar comando SQL
                SQLComando.ExecuteNonQuery();


                MessageBox.Show("Fornecedor excluido com sucesso");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }

            MostraFornecedores();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCnjp.Text = string.Empty;
            txtIdConsulta.Text = string.Empty;

            dgvFornecedores.ClearSelection();
            txtNome.Focus();

            MostraFornecedores();
        }
    }
    
}
