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
    public partial class frmAcerteoNumero : Form
    {
        int numeroAleatorio;
        int contador = 0;
        public frmAcerteoNumero()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            int numeroEscolhido = Convert.ToInt32(numericUpDownNumeros.Value);
            if (numeroEscolhido == this.numeroAleatorio)
            {
                MessageBox.Show("Você acertou");
                contador = contador + 1;
                label2.Text = ($"{contador}");

            }
            if (numeroEscolhido > numeroAleatorio)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                contador = contador + 1;
                label2.Text = ($"{contador}");
            }
            if (numeroEscolhido < numeroAleatorio)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                contador = contador + 1;
                label2.Text = ($"{contador}");
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            numeroAleatorio = aleatorio.Next(0, 101);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            numeroAleatorio = aleatorio.Next(0, 101);
            contador = 0;
            label2.Text = contador.ToString();
        }
    }
}
