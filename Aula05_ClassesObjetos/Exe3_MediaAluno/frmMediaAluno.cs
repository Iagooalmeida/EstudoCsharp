using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_MediaAluno
{
    public partial class frmMediaAluno : Form
    {
        int numLinha = 0;
        Aluno aluno;
        Nota nota;
        public frmMediaAluno()
        {
            InitializeComponent();
        }

        public void CarregarGrid(string nome, string curso, double notaMensal, double notaBimestral, double mediaFinal)
        {
            dgvMediaFinal.Rows.Add();
            dgvMediaFinal[0, numLinha].Value = nome;
            dgvMediaFinal[1, numLinha].Value = curso;
            dgvMediaFinal[2, numLinha].Value = notaMensal;
            dgvMediaFinal[3, numLinha].Value = notaBimestral;
            dgvMediaFinal[4, numLinha].Value = mediaFinal;
            numLinha++;
        }

        public double Mediafinal(double notaMensal, double notaBimestral)
        {
            double mediafinal = (notaMensal + notaBimestral) / 2;
            return mediafinal;
        }

        private void btnCriarAlunos_Click(object sender, EventArgs e)
        {
            aluno = new Aluno(txtNomeAluno.Text, txtCurso.Text);
            dgvMediaFinal.Rows.Add();
            dgvMediaFinal[0, numLinha].Value = txtNomeAluno.Text;
            dgvMediaFinal[1, numLinha].Value = txtCurso.Text;
            numLinha++;
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            nota = new Nota(aluno, Convert.ToDouble(txtNotaMensal.Text), Convert.ToDouble(txtBimenstral.Text));
            CarregarGrid(aluno.Nome, aluno.Curso, nota.NotaMensal, nota.NotaBimestral, Mediafinal(nota.NotaMensal, nota.NotaBimestral));
        }
    }
}
