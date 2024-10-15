using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmTemperatura : Form
    {
        double valor1 = 0;
        string operacao = "";
        public FrmTemperatura()
        {
            InitializeComponent();
        }

        private void FrmTemperatura_Load(object sender, EventArgs e)
        {

        }

        private void BttConverter_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(txtBoxCelsius.Text);
            double resultado = celsius * 1.8 + 32;
            txtBoxFahrenheit.Text = Convert.ToString(resultado);
        }

        private void BttLimpar_Click(object sender, EventArgs e)
        {
            txtBoxCelsius.Clear();
            txtBoxFahrenheit.Clear();
        }
    }
}

