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
    public partial class frmConsultaProdutos : Form
    {

        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        DataTable dtProdutos;

        string SQLString;

        frmNotasEntrada notasEntrada;

        public frmConsultaProdutos()
        {
            InitializeComponent();
        }

        public frmConsultaProdutos(frmNotasEntrada ne)
        {
            InitializeComponent();

            notasEntrada = ne;

            btnSelecionar.Visible = true;
        }

        public void ConsultarProduto()
        {
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                if (rbnId.Checked)
                {
                    SQLString = "Select id, descricao, precocusto, precovenda from produtos where id = @id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtConsulta.Text);
                }

                if (rbnDescricao.Checked)
                {
                    SQLString = "Select id, descricao, precocusto, precovenda from produtos where descricao like @descricao";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@descricao", txtConsulta.Text + "%");
                }

                if (rbnTodos.Checked)
                {
                    SQLString = "Select id, descricao, precocusto, precovenda from produtos order by descricao;";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                }

                SQLConexao.Open();

                SQLDa = new MySqlDataAdapter(SQLComando);

                dtProdutos = new DataTable();

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

        private void rbnTodos_CheckedChanged(object sender, EventArgs e)
        {
            ConsultarProduto();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (!txtConsulta.Text.Equals(String.Empty))
            {
                ConsultarProduto();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dtProdutos.Rows.Count > 0)
            {
                notasEntrada.txtIdProduto.Text = Convert.ToString(dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value);
                notasEntrada.txtDescricaoProduto.Text = Convert.ToString(dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value);
                Close();
            }
            else
            {
                MessageBox.Show("Seleciona um registro");
            }
        }
    }
}
