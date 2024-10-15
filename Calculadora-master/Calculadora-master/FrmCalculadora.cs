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
    public partial class FrmCalculadora : Form
    {
        float valor1 = 0;
        string operacao = "";
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void Btt1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "1";
        }

        private void Btt2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "2";
        }

        private void Btt3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void Btt4_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "4";
        }

        private void Btt5_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "5";
        }

        private void Btt6_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "6";
        }

        private void Btt7_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "7";
        }

        private void Btt8_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void Btt9_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "9";
        }

        private void Btt0_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "0";
        }

        private void BttAdição_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "adição";
            txtVisor.Text = "";
        }

        private void BttSubtração_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "subtração";
            txtVisor.Text = "";
        }

        private void BttMultiplicação_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "multiplicação";
            txtVisor.Text = "";
        }

        private void BttDivisão_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "divisão";
            txtVisor.Text = "";
        }

        private void BttIgual_Click_1(object sender, EventArgs e)
        {
            if (this.operacao == "adição")
            {
                float resultado = valor1 + Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = Convert.ToString(resultado);
            }

            if (this.operacao == "subtração")
            {
                float resultado = valor1 - Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = Convert.ToString(resultado);
            }

            if (this.operacao == "multiplicação")
            {
                float resultado = valor1 * Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = Convert.ToString(resultado);
            }

            if (this.operacao == "divisão")
            {
                float resultado = valor1 / Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = Convert.ToString(resultado);
            }
        }

        private void BttCLS_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
        }

        private void celsiusParaFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTemperatura FormularioTeste = new FrmTemperatura();
            FormularioTeste.ShowDialog();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void centímetroParaPolegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentimetroePolegada FormularioTeste = new FrmCentimetroePolegada();
            FormularioTeste.ShowDialog();
        }
    }
}
