using System;
using System.Collections;
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
    public partial class frmFrasesMotivacionais : Form
    {
        int numerosAleatorios;
        public frmFrasesMotivacionais()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("A única maneira de fazer um excelente trabalho é amar o que você faz.");
            lista.Add("O sucesso é a soma de pequenos esforços repetidos dia após dia.");
            lista.Add("Não espere por oportunidades extraordinárias. Agarre ocasiões comuns e as torne grandes.");
            lista.Add("Acredite em si mesmo e todo o resto virá naturalmente.");
            lista.Add("O único lugar onde o sucesso vem antes do trabalho é no dicionário.");
            lista.Add("Nunca é tarde demais para ser o que você poderia ter sido.");
            lista.Add("Se você pode sonhar, você pode realizar.");
            lista.Add("O futuro pertence àqueles que acreditam na beleza de seus sonhos.");
            lista.Add("Faça o que você pode, com o que você tem, onde você está.");
            lista.Add("A maior glória em viver não está em nunca cair, mas em levantar-se cada vez que caímos.");
            lista.Add("O sucesso não é a chave para a felicidade. A felicidade é a chave para o sucesso.");
            lista.Add("Você não encontra a felicidade. Você a cria.");
            lista.Add("Não conte os dias, faça os dias contarem.");
            lista.Add("A vida é 10% o que acontece com você e 90% como você reage a isso.");
            lista.Add("A jornada de mil milhas começa com um passo.");


            Random aleatorio = new Random();
            int numerosAleatorios = aleatorio.Next(0, lista.Count());
            label1.Text = lista[numerosAleatorios];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
