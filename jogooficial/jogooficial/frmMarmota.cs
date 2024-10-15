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
    public partial class frmMarmota : Form
    {
        int contador = 0;
        Random random = new Random();
        public frmMarmota()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //fazendo com a posição aleatória

            contador = contador + 1;
            labelPontuaçãoNúmero.Text = contador.ToString();

            //Posso fazer uma lista também
            //posições pré-definidas
            //List<Point> listaPosicoes = new List<Point>();
            //listaPosicoes.Add(new Point(100, 200));
            //listaPosicoes.Add(new Point(150, 300));
            //listaPosicoes.Add(new Point(250, 350));
            //Ramdom random2 = new Random();
            //int posicaoAleatoria = random2.Next(0, 3);
            //pictureBox1.Location = listaPosicoes[posicaoAleatoria];
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pgbTempo_Click(object sender, EventArgs e)
        {

        }

        private void tmrTempo_Tick_1(object sender, EventArgs e)
        {
            pgbTempo.Value = pgbTempo.Value - 1;
            if (pgbTempo.Value == 0)
            {
                tmrTempo.Enabled = false;
                btnSair.Visible = true;
                btnResetar.Visible = true;
            }
            if (pgbTempo.Value == 0)
            {
                MessageBox.Show($"Você acertou a marmota {contador} vezes!");
            }
        }

        private void frmTime_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pgbTempo.Value = 100;
            tmrTempo.Enabled = true;
            contador = 0;
            labelPontuaçãoNúmero.Text = contador.ToString();
            btnSair.Visible = false;
            btnResetar.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = random.Next(12, 649); //Posição mínima e máxima de eixo x
            int y = random.Next(26, 343); //Posição mínima e máxima de eixo y
          
            tmrTempo.Enabled = true;
            btnSair.Visible = false;
            btnResetar.Visible = false;
            btnIniciar.Visible = false;
        }

        private void trmMarmota_Tick(object sender, EventArgs e)
        {
            int x = random.Next(12, 649); //Posição mínima e máxima de eixo x
            int y = random.Next(26, 343); //Posição mínima e máxima de eixo y
            pictureBoxMarmota.Location = new Point(x, y);
        }
    }
}