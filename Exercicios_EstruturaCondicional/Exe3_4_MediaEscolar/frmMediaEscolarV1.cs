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
    public partial class frmMediaEscolarV1 : Form
    {
        public frmMediaEscolarV1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void medias(float Nota1, float Nota2, float Nota3, float Nota4) 
        {

            float media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            if (media >= 5)
                lblMediaFinal.Text = "Você foi aprovado:" + "\r\nMedia Final: " + media.ToString("N1");
            else
                lblMediaFinal.Text = "Você foi reprovado:" + "\r\nMedia Final: " + media.ToString("N1");
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {

            if (txtNota1.Text != string.Empty && txtNota4.Text != string.Empty && txtNota3.Text != string.Empty && txtNota4.Text != string.Empty)
            {
                float Nota1 = float.Parse(txtNota1.Text);
                float Nota2 = float.Parse(txtNota2.Text);
                float Nota3 = float.Parse(txtNota3.Text);
                float Nota4 = float.Parse(txtNota4.Text);

                medias(Nota1, Nota2, Nota3, Nota4);
            }
            else
                MessageBox.Show("Por favor preencha todos os campos!!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            
        }
    }
}
