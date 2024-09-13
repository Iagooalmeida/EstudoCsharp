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
    public partial class frmLogin : Form
    {
        public static string nivelAcesso;
        public static string usuarioConectado;

        MySqlConnection  SQLConexao;
        MySqlCommand SqlComando;
        MySqlDataReader SQDr;

        string SQLString;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtLogin.Text.Equals(string.Empty) && !txtSenha.Text.Equals(string.Empty))
                {
                    string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                    SQLConexao = new MySqlConnection(stringConexao);

                    SQLString = "select * from usuarios where login = @login and senha = @senha";

                    SqlComando = new MySqlCommand(SQLString, SQLConexao);
                    SqlComando.Parameters.AddWithValue("@login", txtLogin.Text);
                    SqlComando.Parameters.AddWithValue("@senha", txtSenha.Text);

                    SQLConexao.Open();

                    SQDr = SqlComando.ExecuteReader();

                    if (SQDr.Read())
                    {
                        usuarioConectado = Convert.ToString(SQDr["login"]);
                        nivelAcesso = Convert.ToString(SQDr["nivelacesso"]);

                        frmTelaPrincipal p = new frmTelaPrincipal();

                        //esconde o form login
                        this.Hide();

                        //mostrar o form da tela principal
                        p.Show();
                    }
                    else
                    {
                        MessageBox.Show("usuarios e senhas incorretos", "Aviso importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatórios", "Aviso importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
