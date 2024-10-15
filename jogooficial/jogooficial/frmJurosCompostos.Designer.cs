namespace jogooficial
{
    partial class frmJurosCompostos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxValorInicial = new TextBox();
            txtBoxJurosMensal = new TextBox();
            txtBoxQuantidadeMeses = new TextBox();
            txtBoxValorJuros = new TextBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSair = new Button();
            SuspendLayout();
            // 
            // txtBoxValorInicial
            // 
            txtBoxValorInicial.Location = new Point(4, 37);
            txtBoxValorInicial.Name = "txtBoxValorInicial";
            txtBoxValorInicial.Size = new Size(194, 23);
            txtBoxValorInicial.TabIndex = 0;
            // 
            // txtBoxJurosMensal
            // 
            txtBoxJurosMensal.Location = new Point(4, 90);
            txtBoxJurosMensal.Name = "txtBoxJurosMensal";
            txtBoxJurosMensal.Size = new Size(194, 23);
            txtBoxJurosMensal.TabIndex = 1;
            // 
            // txtBoxQuantidadeMeses
            // 
            txtBoxQuantidadeMeses.Location = new Point(4, 144);
            txtBoxQuantidadeMeses.Name = "txtBoxQuantidadeMeses";
            txtBoxQuantidadeMeses.Size = new Size(194, 23);
            txtBoxQuantidadeMeses.TabIndex = 2;
            // 
            // txtBoxValorJuros
            // 
            txtBoxValorJuros.Location = new Point(4, 277);
            txtBoxValorJuros.Name = "txtBoxValorJuros";
            txtBoxValorJuros.Size = new Size(210, 23);
            txtBoxValorJuros.TabIndex = 4;
            txtBoxValorJuros.TextAlign = HorizontalAlignment.Center;
            txtBoxValorJuros.TextChanged += textBox5_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(192, 192, 0);
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(17, 186);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(172, 34);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Blue;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(17, 226);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(172, 32);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 19);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 7;
            label1.Text = "VALOR INICIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 72);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 8;
            label2.Text = "JUROS MENSAL (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 126);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 9;
            label3.Text = "QUANTIDADE DE MESES";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(17, 320);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(88, 31);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button3_Click;
            // 
            // frmJurosCompostos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 387);
            Controls.Add(btnSair);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(txtBoxValorJuros);
            Controls.Add(txtBoxQuantidadeMeses);
            Controls.Add(txtBoxJurosMensal);
            Controls.Add(txtBoxValorInicial);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmJurosCompostos";
            Text = "Juros Compostos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxValorInicial;
        private TextBox txtBoxJurosMensal;
        private TextBox txtBoxQuantidadeMeses;
        private TextBox txtBoxValorJuros;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSair;
    }
}