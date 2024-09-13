using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Exe01_Cadastro
{
    public partial class frmProdutos : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        MySqlDataReader SQLDr;
        string SQLString;

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void MostraProdutos()
        {
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                SQLString = "Select id, descricao, precocusto, precovenda from Produtos order by descricao";

                SQLDa = new MySqlDataAdapter(SQLString, SQLConexao);

                DataTable dtProdutos = new DataTable();

                SQLDa.Fill(dtProdutos);

                dgvProdutos.DataSource = dtProdutos;
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
                SQLString = "insert into Produtos(descricao, precocusto, precovenda, estoque) values (@descricao, @precocusto, @precovenda, 0)";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@descricao",txtDescricao.Text);
                SQLComando.Parameters.AddWithValue("@precocusto", Convert.ToDouble(txtPrecoCusto.Text));
                SQLComando.Parameters.AddWithValue("@precovenda", Convert.ToDouble(txtPrecoVenda.Text));

                //abrir Conexão com o banco
                SQLConexao.Open();

                //Execultar comando SQL
                SQLComando.ExecuteNonQuery();

                // mostrar o ID registro inserido ///
                if (SQLComando.LastInsertedId != 0)
                {
                    SQLComando.Parameters.Add(new MySqlParameter("ultimoId", SQLComando.LastInsertedId));
                    txtID.Text = Convert.ToString(SQLComando.Parameters["@ultimoId"].Value);
                }


                MessageBox.Show("Produto cadastrado com sucesso");

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

            MostraProdutos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdConsulta.Text.Equals(string.Empty))
                MostraProdutos();
            else
            {
                try
                {   //Conexão com o banco
                    string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                    SQLConexao = new MySqlConnection(stringConexao);

                    //Comando Sql
                    SQLString = "select id, descricao, precocusto, precovenda from Produtos where id =@id";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtIdConsulta.Text);


                    //abrir Conexão com o banco
                    SQLConexao.Open();

                    //Execultar comando SQL
                    SQLDr = SQLComando.ExecuteReader();

                    while (SQLDr.Read())
                    {
                        txtID.Text = Convert.ToString(SQLDr["id"]);
                        txtDescricao.Text = Convert.ToString(SQLDr["descricao"]);
                        txtPrecoCusto.Text = Convert.ToString(SQLDr["precocusto"]);
                        txtPrecoVenda.Text = Convert.ToString(SQLDr["precovenda"]);
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

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            txtID.Text = Convert.ToString(dgvProdutos[0, e.RowIndex].Value);
            txtDescricao.Text = Convert.ToString(dgvProdutos[1, e.RowIndex].Value);
            txtPrecoCusto.Text = Convert.ToString(dgvProdutos[2, e.RowIndex].Value);
            txtPrecoVenda.Text = Convert.ToString(dgvProdutos[3, e.RowIndex].Value);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {   //Conexão com o banco
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                //Comando Sql
                SQLString = "update produtos set descricao = @descricao, precocusto = @precocusto, precovenda = @precovenda where id =@id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtID.Text);
                SQLComando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                SQLComando.Parameters.AddWithValue("@precocusto", txtPrecoCusto.Text);
                SQLComando.Parameters.AddWithValue("@precovenda", txtPrecoVenda.Text);

                //abrir Conexão com o banco
                SQLConexao.Open();

                //Execultar comando SQL
                SQLComando.ExecuteNonQuery();


                MessageBox.Show("Produto alterado com sucesso!");

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

            MostraProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {   //Conexão com o banco
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                //Comando Sql
                SQLString = "delete from produtos where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtID.Text);
                SQLComando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                SQLComando.Parameters.AddWithValue("@precocusto", txtPrecoCusto.Text);
                SQLComando.Parameters.AddWithValue("@precovenda", txtPrecoVenda.Text);

                //abrir Conexão com o banco
                SQLConexao.Open();

                //Execultar comando SQL
                SQLComando.ExecuteNonQuery();


                MessageBox.Show("Produto excluído com sucesso!!");

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

            MostraProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPrecoCusto.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            txtIdConsulta.Text = string.Empty;

            dgvProdutos.ClearSelection();
            txtDescricao.Focus();

            MostraProdutos();
        }
    }
}
