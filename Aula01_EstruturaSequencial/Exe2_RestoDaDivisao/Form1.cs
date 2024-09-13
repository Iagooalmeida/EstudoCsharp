using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2_RestoDaDivisao
{
    public partial class frmRestoDaDivisao : Form
    {
        public frmRestoDaDivisao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txtPrimeiroValor.Text);
            int divisor = Convert.ToInt32(txtSegundoValor.Text);
            int resto = dividendo % divisor;
            txtResultado.Text = resto.ToString();
        }
    }
}
