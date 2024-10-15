using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogooficial
{
    public partial class frmJurosSimples : Form
    {
        public frmJurosSimples()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float montante;
            float valorinicial = Convert.ToSingle(txtBoxValorInicial.Text);
            float jurosmensal = Convert.ToSingle(txtBoxJurosMensal.Text) / 100;
            int quantidademeses = Convert.ToInt32(txtBoxQuantidadeMeses.Text);
            montante = valorinicial * jurosmensal * quantidademeses + valorinicial;
            txtBoxValorJuros.Text = montante.ToString("R$ 0.00");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtBoxValorInicial.Clear();
            txtBoxJurosMensal.Clear();
            txtBoxQuantidadeMeses.Clear();
            txtBoxValorJuros.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
