namespace Calculadora
{
    public partial class FrmTeladeSplash : Form
    {
        int tempo = 0;
        public FrmTeladeSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (pgbTempo.Value == 10)
            {
                trmTempo.Enabled = false;
                this.Hide();
                FrmCalculadora FormularioTeste = new FrmCalculadora();
                FormularioTeste.ShowDialog();
            }

            else
            {
                pgbTempo.Value = pgbTempo.Value + 1;
            }

        }

        private void pgbTempo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
