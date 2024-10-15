namespace jogooficial
{
    partial class frmJurosSimples
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // txtBoxValorInicial
            // 
            txtBoxValorInicial.Location = new Point(13, 26);
            txtBoxValorInicial.Margin = new Padding(3, 2, 3, 2);
            txtBoxValorInicial.Name = "txtBoxValorInicial";
            txtBoxValorInicial.Size = new Size(212, 23);
            txtBoxValorInicial.TabIndex = 0;
            txtBoxValorInicial.TextChanged += textBox1_TextChanged;
            // 
            // txtBoxJurosMensal
            // 
            txtBoxJurosMensal.Location = new Point(13, 77);
            txtBoxJurosMensal.Margin = new Padding(3, 2, 3, 2);
            txtBoxJurosMensal.Name = "txtBoxJurosMensal";
            txtBoxJurosMensal.Size = new Size(212, 23);
            txtBoxJurosMensal.TabIndex = 1;
            txtBoxJurosMensal.TextChanged += textBox2_TextChanged;
            // 
            // txtBoxQuantidadeMeses
            // 
            txtBoxQuantidadeMeses.Location = new Point(13, 126);
            txtBoxQuantidadeMeses.Margin = new Padding(3, 2, 3, 2);
            txtBoxQuantidadeMeses.Name = "txtBoxQuantidadeMeses";
            txtBoxQuantidadeMeses.Size = new Size(212, 23);
            txtBoxQuantidadeMeses.TabIndex = 2;
            txtBoxQuantidadeMeses.TextChanged += textBox3_TextChanged;
            // 
            // txtBoxValorJuros
            // 
            txtBoxValorJuros.Location = new Point(13, 254);
            txtBoxValorJuros.Margin = new Padding(3, 2, 3, 2);
            txtBoxValorJuros.Name = "txtBoxValorJuros";
            txtBoxValorJuros.Size = new Size(232, 23);
            txtBoxValorJuros.TabIndex = 3;
            txtBoxValorJuros.TextAlign = HorizontalAlignment.Center;
            txtBoxValorJuros.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "VALOR INICIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 60);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 5;
            label2.Text = "JUROS MENSAL (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 109);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 6;
            label3.Text = "QUANTIDADE DE MESES";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(192, 192, 0);
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(20, 166);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(193, 36);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Blue;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(20, 206);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(193, 34);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += button2_Click_1;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(12, 295);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(81, 31);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button3_Click;
            // 
            // frmJurosSimples
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 337);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxValorJuros);
            Controls.Add(txtBoxQuantidadeMeses);
            Controls.Add(txtBoxJurosMensal);
            Controls.Add(txtBoxValorInicial);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmJurosSimples";
            Text = "Juros Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxValorInicial;
        private TextBox txtBoxJurosMensal;
        private TextBox txtBoxQuantidadeMeses;
        private TextBox txtBoxValorJuros;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private Button btnLimpar;
        private Button btnSair;
    }
}