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

    public partial class frmConsultaFornecedores : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        DataTable dtFornecedores;

        string SQLString;

        frmNotasEntrada notasEntrada;

        public frmConsultaFornecedores()
        {
            InitializeComponent();
        }

        public frmConsultaFornecedores(frmNotasEntrada ne)
        {
            InitializeComponent();

            notasEntrada = ne;

            btnSelecionar.Visible = true;
        }

        public void ConsultarFornecedores()
        {
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                if (rbnId.Checked)
                {
                    SQLString = "Select id, nome, cnpj from fornecedores where id = @id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtConsulta.Text);
                }

                if (rbnNome.Checked)
                {
                    SQLString = "Select id, nome, cnpj from fornecedores where nome like @nome";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@nome", txtConsulta.Text + "%");
                }

                if (rbnCnpj.Checked)
                {
                    SQLString = "Select id, nome, cnpj from fornecedores where cnpj like @cnpj";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@cnpj", txtConsulta.Text + "%");
                }

                if (rbnTodos.Checked)
                {
                    SQLString = "Select id, nome, cnpj from fornecedores order by nome;";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                }

                SQLConexao.Open();

                SQLDa = new MySqlDataAdapter(SQLComando);

                dtFornecedores = new DataTable();

                SQLDa.Fill(dtFornecedores);
                dgvFornecedores.DataSource = dtFornecedores;
            }
            catch(Exception ex)
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

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (!txtConsulta.Text.Equals(String.Empty))
            {
                ConsultarFornecedores();
            }
        }


        private void rbnTodos_CheckedChanged(object sender, EventArgs e)
        {
            ConsultarFornecedores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dtFornecedores.Rows.Count > 0)
            {
                notasEntrada.txtIdFornecedor.Text = Convert.ToString(dgvFornecedores[0, dgvFornecedores.CurrentRow.Index].Value);
                notasEntrada.txtNomeFornecedor.Text = Convert.ToString(dgvFornecedores[1, dgvFornecedores.CurrentRow.Index].Value);
                Close();
            }
            else
            {
                MessageBox.Show("Seleciona um registro");
            }
        }
    }
}
