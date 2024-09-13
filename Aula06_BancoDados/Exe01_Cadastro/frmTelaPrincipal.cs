using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe01_Cadastro
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslHoras.Text = DateTime.Now.ToString("HH:mm");
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {

            if(frmLogin.nivelAcesso == "Operador")
            {
                usuariosToolStripMenuItem.Visible = false;
            }

            tssUsuario.Text = "Usuários: " + frmLogin.usuarioConectado + " | " + frmLogin.nivelAcesso;

            string mHost = System.Net.Dns.GetHostName();

            tsslNomePC.Text = "Nome do Host: " + mHost;

            System.Net.IPHostEntry mIps = System.Net.Dns.GetHostEntry(mHost);

            foreach(System.Net.IPAddress mIP in mIps.AddressList)
            {
                tsslData.Text = "IP: " + mIP;
            }

            tsslData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFornecedores fornecedores = null;
                foreach (Form frm in this.MdiChildren)
                {

                    // verifica se tem formu~lários na tela e mostra
                    if(frm is frmFornecedores)
                    {
                        fornecedores = (frmFornecedores)frm;
                        break;
                    }
                }


                // se não está instalado o formulário e instaciado agora
                if (fornecedores == null)
                {
                    fornecedores = new frmFornecedores();
                    fornecedores.MdiParent = this;
                    fornecedores.Show();
                }
            }

            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProdutos produtos = null;
                foreach (Form frm in this.MdiChildren)
                {

                    // verifica se tem formu~lários na tela e mostra
                    if (frm is frmFornecedores)
                    {
                        produtos = (frmProdutos)frm;
                        break;
                    }
                }


                // se não está instalado o formulário e instaciado agora
                if (produtos == null)
                {
                    produtos = new frmProdutos();
                    produtos.MdiParent = this;
                    produtos.Show();
                }

                produtos.Focus();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuarios usuarios = null;
                foreach (Form frm in this.MdiChildren)
                {

                    // verifica se tem formulários na tela e mostra
                    if (frm is frmUsuarios)
                    {
                        usuarios = (frmUsuarios)frm;
                        break;
                    }
                }


                // se não está instalado o formulário e instaciado agora
                if (usuarios == null)
                {
                    usuarios = new frmUsuarios();
                    usuarios.MdiParent = this;
                    usuarios.Show();
                }

                usuarios.Focus();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaFornecedores consultafornecedores = null;
                foreach (Form frm in this.MdiChildren)
                {

                    // verifica se tem formulários na tela e mostra
                    if (frm is frmFornecedores)
                    {
                        consultafornecedores = (frmConsultaFornecedores)frm;
                        break;
                    }
                }


                // se não está instalado o formulário e instaciado agora
                if (consultafornecedores == null)
                {
                    consultafornecedores = new frmConsultaFornecedores();
                    consultafornecedores.MdiParent = this;
                    consultafornecedores.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaProdutos consultaprodutos = null;
                foreach (Form frm in this.MdiChildren)
                {

                    // verifica se tem formulários na tela e mostra
                    if (frm is frmFornecedores)
                    {
                        consultaprodutos = (frmConsultaProdutos)frm;
                        break;
                    }
                }


                // se não está instalado o formulário e instaciado agora
                if (consultaprodutos == null)
                {
                    consultaprodutos = new frmConsultaProdutos();
                    consultaprodutos.MdiParent = this;
                    consultaprodutos.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void entradaNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmNotasEntrada notasentrada = null;
                foreach (Form frm in this.MdiChildren)
                {

                    // verifica se tem formulários na tela e mostra
                    if (frm is frmFornecedores)
                    {
                        notasentrada = (frmNotasEntrada)frm;
                        break;
                    }
                }


                // se não está instalado o formulário e instaciado agora
                if (notasentrada == null)
                {
                    notasentrada = new frmNotasEntrada();
                    notasentrada.MdiParent = this;
                    notasentrada.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
