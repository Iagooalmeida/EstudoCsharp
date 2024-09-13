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
    public partial class frmNotasEntrada : Form
    {

        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataReader SQLDr;
        DataTable dtfornecedores;
        string SQLString;

        int numLinha = 0;

        double totalNota = 0;
        double totalProduto = 0;


        public frmNotasEntrada()
        {
            InitializeComponent();
        }

        private void txtIdFornecedor_Leave(object sender, EventArgs e)
        {
            if (!txtIdFornecedor.Text.Equals(String.Empty))
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                SQLString = "select nome from fornecedores where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtIdFornecedor.Text);

                SQLConexao.Open();

                SQLDr = SQLComando.ExecuteReader();

                if (SQLDr.Read())
                {
                    txtNomeFornecedor.Text = Convert.ToString(SQLDr["nome"]);
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                    txtIdFornecedor.Focus();
                }
            }
        }

        private void txtIdProduto_Leave(object sender, EventArgs e)
        {
            if (!txtIdProduto.Text.Equals(String.Empty))
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                SQLString = "select descricao from produtos where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtIdProduto.Text);

                SQLConexao.Open();

                SQLDr = SQLComando.ExecuteReader();

                if (SQLDr.Read())
                {
                    txtDescricaoProduto.Text = Convert.ToString(SQLDr["descricao"]);
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                    txtIdFornecedor.Focus();
                }
            }
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            if (!txtIdFornecedor.Text.Equals(String.Empty) &&
                !txtIdProduto.Text.Equals(String.Empty) &&
                !txtDescricaoProduto.Text.Equals(String.Empty) &&
                !txtPrecoCustoProduto.Text.Equals(String.Empty) &&
                !txtQuantidadeProduto.Text.Equals(String.Empty))
            {
                dgvProdutos.Rows.Add();
                dgvProdutos[0, numLinha].Value = Convert.ToString(numLinha + 1);
                dgvProdutos[1, numLinha].Value = txtIdProduto.Text;
                dgvProdutos[2, numLinha].Value = txtDescricaoProduto.Text;
                dgvProdutos[3, numLinha].Value = txtQuantidadeProduto.Text;
                dgvProdutos[4, numLinha].Value = txtPrecoCustoProduto.Text;

                totalProduto = Convert.ToDouble(txtPrecoCustoProduto.Text) * Convert.ToDouble(txtQuantidadeProduto.Text);

                dgvProdutos[5, numLinha].Value = Convert.ToString(totalProduto);

                numLinha++;

                totalNota += totalProduto;

                txtTotalNota.Text = totalNota.ToString();

                LimparControlesProdutos();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!");
                txtIdProduto.Focus();
            }
        }


        private void LimparControlesProdutos()
        {
            txtIdProduto.Clear();
            txtDescricaoProduto.Clear();
            txtPrecoCustoProduto.Clear();
            txtQuantidadeProduto.Clear();

            txtIdProduto.Focus();
        }

        private void LimparTodosControles()
        {
            LimparControlesProdutos();
            txtIdFornecedor.Clear();
            txtNomeFornecedor.Clear();
            txtNumero.Clear();
            txtTotalNota.Clear();
            dtpEmissao.Value = DateTime.Now.Date;
            dtpEntrada.Value = DateTime.Now.Date;
            dgvProdutos.Rows.Clear();

            txtIdFornecedor.Focus();
        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            LimparTodosControles();
        }

        private void btnCancelarNotaEntrada_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar a entrada da nota?","Confirmação", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimparControlesProdutos();
            }
        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaFornecedores consultaFornecedores = new frmConsultaFornecedores(this);
                consultaFornecedores.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLocalizarProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaProdutos consultaProdutos = new frmConsultaProdutos(this);
                consultaProdutos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnInserirNotaEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                //Inserir dados na tabela notas entrada

                SQLString = "insert into notasentrada (idfornecedor, numero, dataemissao, dataentrada, valortotal) " +
                    "values (@idfornecedor, @numero, @dataemissao, @dataentrada, @valortotal)";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@idfornecedor", txtIdFornecedor.Text);
                SQLComando.Parameters.AddWithValue("@numero", txtNumero.Text);
                SQLComando.Parameters.AddWithValue("@dataemissao", dtpEmissao.Value); //Atenção com as datas
                SQLComando.Parameters.AddWithValue("@dataentrada", dtpEntrada.Value);
                SQLComando.Parameters.AddWithValue("@valortotal", Convert.ToDouble(txtTotalNota.Text)); //atenção com valores monetários

                SQLConexao.Open();

                SQLComando.ExecuteNonQuery();

                int idNota = 0;

                if (SQLComando.LastInsertedId != 0)
                {
                    SQLComando.Parameters.Add(new MySqlParameter("ultimoId", SQLComando.LastInsertedId));
                    idNota = Convert.ToInt32(SQLComando.Parameters["@ultimoId"].Value);
                }

                for (int i = 0; i < dgvProdutos.RowCount; i++)
                {
                    SQLString = "insert into produtosnotasentrada (idnotaentrada, idproduto, precocustocompra, quantidadecompra)" +
                        "values (@idnotaentrada, @idproduto, @precocustocompra, @quantidadecompra)";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@idnotaentrada", idNota);
                    SQLComando.Parameters.AddWithValue("@idproduto", dgvProdutos[1, i].Value);
                    SQLComando.Parameters.AddWithValue("@quantidadecompra", Convert.ToDouble(dgvProdutos[3, i].Value));
                    SQLComando.Parameters.AddWithValue("@precocustocompra", Convert.ToDouble(dgvProdutos[4, i].Value));

                    SQLComando.ExecuteNonQuery();

                    SQLString = "update produtos set estoque = estoque + @quantidade, precocusto = @precocusto, precovenda = @precocusto * 2 where id = @id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@quantidade", Convert.ToDouble(dgvProdutos[3, i].Value));
                    SQLComando.Parameters.AddWithValue("@precocusto", Convert.ToDouble(dgvProdutos[4, i].Value));
                    SQLComando.Parameters.AddWithValue("@id", Convert.ToDouble(dgvProdutos[1, i].Value));

                    SQLComando.ExecuteNonQuery();
                }

                MessageBox.Show("Nota entrada registrada com sucesso!");
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
}
