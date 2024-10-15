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
    public partial class FrmCentimetroePolegada : Form
    {
        public FrmCentimetroePolegada()
        {
            InitializeComponent();
        }

        private void Converter_Click(object sender, EventArgs e)
        {
            double centimetro = Convert.ToDouble(txtBoxCentimetro.Text);
            double resultado = centimetro / 2.54;
            txtBoxPolegada.Text = Convert.ToString(resultado);
        }

        private void BttLimpar_Click(object sender, EventArgs e)
        {
            txtBoxCentimetro.Clear();
            txtBoxPolegada.Clear();
        }
    }
}
