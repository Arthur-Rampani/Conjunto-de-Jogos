namespace jogooficial
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPapagaio = new Button();
            btnJurosSimples = new Button();
            btnJurosCompostos = new Button();
            btnAcerteoNumero = new Button();
            btnFrasesMotivacionais = new Button();
            btnMarmota = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnPapagaio
            // 
            btnPapagaio.BackColor = Color.Lime;
            btnPapagaio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPapagaio.Location = new Point(31, 43);
            btnPapagaio.Margin = new Padding(3, 2, 3, 2);
            btnPapagaio.Name = "btnPapagaio";
            btnPapagaio.Size = new Size(185, 90);
            btnPapagaio.TabIndex = 0;
            btnPapagaio.Text = "Papagaio";
            btnPapagaio.UseVisualStyleBackColor = false;
            btnPapagaio.Click += button1_Click;
            // 
            // btnJurosSimples
            // 
            btnJurosSimples.BackColor = Color.FromArgb(255, 255, 128);
            btnJurosSimples.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJurosSimples.Location = new Point(259, 43);
            btnJurosSimples.Margin = new Padding(3, 2, 3, 2);
            btnJurosSimples.Name = "btnJurosSimples";
            btnJurosSimples.Size = new Size(185, 90);
            btnJurosSimples.TabIndex = 1;
            btnJurosSimples.Text = "Juros Simples";
            btnJurosSimples.UseVisualStyleBackColor = false;
            btnJurosSimples.Click += button2_Click;
            // 
            // btnJurosCompostos
            // 
            btnJurosCompostos.BackColor = Color.FromArgb(255, 192, 128);
            btnJurosCompostos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJurosCompostos.Location = new Point(474, 43);
            btnJurosCompostos.Margin = new Padding(3, 2, 3, 2);
            btnJurosCompostos.Name = "btnJurosCompostos";
            btnJurosCompostos.Size = new Size(185, 90);
            btnJurosCompostos.TabIndex = 2;
            btnJurosCompostos.Text = "Juros Compostos";
            btnJurosCompostos.UseVisualStyleBackColor = false;
            btnJurosCompostos.Click += button3_Click;
            // 
            // btnAcerteoNumero
            // 
            btnAcerteoNumero.BackColor = Color.Blue;
            btnAcerteoNumero.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcerteoNumero.ForeColor = SystemColors.ControlLightLight;
            btnAcerteoNumero.Location = new Point(31, 175);
            btnAcerteoNumero.Margin = new Padding(3, 2, 3, 2);
            btnAcerteoNumero.Name = "btnAcerteoNumero";
            btnAcerteoNumero.Size = new Size(185, 90);
            btnAcerteoNumero.TabIndex = 3;
            btnAcerteoNumero.Text = "Acerte o Número";
            btnAcerteoNumero.UseVisualStyleBackColor = false;
            btnAcerteoNumero.Click += button4_Click;
            // 
            // btnFrasesMotivacionais
            // 
            btnFrasesMotivacionais.BackColor = Color.Fuchsia;
            btnFrasesMotivacionais.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFrasesMotivacionais.ForeColor = SystemColors.ButtonHighlight;
            btnFrasesMotivacionais.Location = new Point(259, 175);
            btnFrasesMotivacionais.Margin = new Padding(3, 2, 3, 2);
            btnFrasesMotivacionais.Name = "btnFrasesMotivacionais";
            btnFrasesMotivacionais.Size = new Size(185, 90);
            btnFrasesMotivacionais.TabIndex = 4;
            btnFrasesMotivacionais.Text = "Frases Motivacionais";
            btnFrasesMotivacionais.UseVisualStyleBackColor = false;
            btnFrasesMotivacionais.Click += button5_Click;
            // 
            // btnMarmota
            // 
            btnMarmota.BackColor = Color.FromArgb(128, 64, 0);
            btnMarmota.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarmota.ForeColor = SystemColors.ButtonHighlight;
            btnMarmota.Location = new Point(474, 175);
            btnMarmota.Margin = new Padding(3, 2, 3, 2);
            btnMarmota.Name = "btnMarmota";
            btnMarmota.Size = new Size(185, 90);
            btnMarmota.TabIndex = 5;
            btnMarmota.Text = "Marmota";
            btnMarmota.UseVisualStyleBackColor = false;
            btnMarmota.Click += button6_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(311, 287);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(88, 39);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(700, 338);
            Controls.Add(btnSair);
            Controls.Add(btnMarmota);
            Controls.Add(btnFrasesMotivacionais);
            Controls.Add(btnAcerteoNumero);
            Controls.Add(btnJurosCompostos);
            Controls.Add(btnJurosSimples);
            Controls.Add(btnPapagaio);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaInicial";
            Text = "Menu";
            FormClosed += Jogo1_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPapagaio;
        private Button btnJurosSimples;
        private Button btnJurosCompostos;
        private Button btnAcerteoNumero;
        private Button btnFrasesMotivacionais;
        private Button btnMarmota;
        private Button btnSair;
    }
}
