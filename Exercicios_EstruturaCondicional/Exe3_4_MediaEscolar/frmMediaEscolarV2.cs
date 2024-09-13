using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_MediaEscolar
{
    public partial class frmMediaEscolarV2 : Form
    {
        public frmMediaEscolarV2()
        {
            InitializeComponent();
        }

        private void Entrada()
        {
            if (txtNota1.Text != string.Empty && txtNota2.Text != string.Empty && txtNota3.Text != string.Empty && txtNota4.Text != string.Empty)
            {
                try
                {
                    float Nota1 = float.Parse(txtNota1.Text);
                    float Nota2 = float.Parse(txtNota2.Text);
                    float Nota3 = float.Parse(txtNota3.Text);
                    float Nota4 = float.Parse(txtNota4.Text);

                    Media(Nota1, Nota2, Nota3, Nota4);
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite apenas numeros e virgula", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Preencha todos os campos", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);        
        }

        private void Media(float Nota1, float Nota2, float Nota3, float Nota4)
        {
            float media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            
            if (media >= 7)
            {
                lblMediaFinal.Text = "Você foi aprovado!!" + "\r\n" + "Media Final é: " + media.ToString("N1");
            }
            else
            {
                lblMediaFinal.Text = "Informe a nota do exame adcional!!";

                if (txtExame.Text != string.Empty)
                {
                    float exame = float.Parse(txtExame.Text);
                    media = (media + exame) / 2;
                    if (media >= 5)
                    {
                        lblMediaFinal.Text = "Você foi aprovado!!" + "\r\n" + "Media Final é: " + media.ToString("N1");
                    }
                    else
                        lblMediaFinal.Text = "Você foi Reprovado!!" + "\r\n" + "Media Final é: " + media.ToString("N1");
                }
                else
                {
                    txtExame.Enabled = true;
                    MessageBox.Show("Informe a Nota de recuperação no campo exame", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtExame.Focus();
                }               
            }
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            Entrada();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            txtNota4.Text = string.Empty;
            txtExame.Clear();
            lblMediaFinal.Text = "";
            txtNota1.Focus();
            txtExame.Enabled = false;
        }
    }
}
