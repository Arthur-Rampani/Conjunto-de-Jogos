namespace jogooficial
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPapagaio FormularioTeste = new frmPapagaio();
            FormularioTeste.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmJurosSimples FormularioTeste = new frmJurosSimples();
            FormularioTeste.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAcerteoNumero FormularioTeste = new frmAcerteoNumero();
            FormularioTeste.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmJurosCompostos FormularioTeste = new frmJurosCompostos();
            FormularioTeste.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmFrasesMotivacionais FormularioTeste = new frmFrasesMotivacionais();
            FormularioTeste.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMarmota FormularioTeste = new frmMarmota();
            FormularioTeste.ShowDialog();
        }

        private void Jogo1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
