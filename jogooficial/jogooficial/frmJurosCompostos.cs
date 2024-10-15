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
    public partial class frmJurosCompostos : Form
    {
        public frmJurosCompostos()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float montante;
            float valorinicial = Convert.ToSingle(txtBoxValorInicial.Text);
            float jurosmensal = Convert.ToSingle(txtBoxJurosMensal.Text) / 100;
            int quantidademeses = Convert.ToInt32(txtBoxQuantidadeMeses.Text);

            // Fórmula de Juros Compostos: M = P * (1 + i)^n
            montante = valorinicial * (float)Math.Pow((1 + jurosmensal), quantidademeses);

            txtBoxValorJuros.Text = montante.ToString("R$ 0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxValorInicial.Clear();
            txtBoxJurosMensal.Clear();
            txtBoxQuantidadeMeses.Clear();
            txtBoxValorJuros.Clear();
        }
    }
}
