namespace jogooficial
{
    partial class frmMarmota
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
            components = new System.ComponentModel.Container();
            pictureBoxMarmota = new PictureBox();
            labelPontuaçãoNúmero = new Label();
            pgbTempo = new ProgressBar();
            tmrTempo = new System.Windows.Forms.Timer(components);
            btnSair = new Button();
            btnResetar = new Button();
            labelPontuação = new Label();
            btnIniciar = new Button();
            trmMarmota = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMarmota).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMarmota
            // 
            pictureBoxMarmota.Image = Properties.Resources.png_clipart_cute_groundhog_cartoon_groundhog_animal_removebg_preview;
            pictureBoxMarmota.Location = new Point(324, 285);
            pictureBoxMarmota.Name = "pictureBoxMarmota";
            pictureBoxMarmota.Size = new Size(140, 95);
            pictureBoxMarmota.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMarmota.TabIndex = 0;
            pictureBoxMarmota.TabStop = false;
            pictureBoxMarmota.Click += pictureBox1_Click;
            pictureBoxMarmota.MouseClick += pictureBox1_MouseClick;
            // 
            // labelPontuaçãoNúmero
            // 
            labelPontuaçãoNúmero.AutoSize = true;
            labelPontuaçãoNúmero.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPontuaçãoNúmero.Location = new Point(700, 71);
            labelPontuaçãoNúmero.Name = "labelPontuaçãoNúmero";
            labelPontuaçãoNúmero.Size = new Size(23, 25);
            labelPontuaçãoNúmero.TabIndex = 1;
            labelPontuaçãoNúmero.Text = "0";
            labelPontuaçãoNúmero.Click += label1_Click;
            // 
            // pgbTempo
            // 
            pgbTempo.Location = new Point(0, -2);
            pgbTempo.Name = "pgbTempo";
            pgbTempo.Size = new Size(803, 22);
            pgbTempo.TabIndex = 3;
            pgbTempo.Value = 100;
            pgbTempo.Click += pgbTempo_Click;
            // 
            // tmrTempo
            // 
            tmrTempo.Interval = 200;
            tmrTempo.Tick += tmrTempo_Tick_1;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.ForeColor = SystemColors.ButtonHighlight;
            btnSair.Location = new Point(604, 403);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(90, 35);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button1_Click;
            // 
            // btnResetar
            // 
            btnResetar.BackColor = Color.Lime;
            btnResetar.Location = new Point(700, 403);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(88, 35);
            btnResetar.TabIndex = 5;
            btnResetar.Text = "Resetar";
            btnResetar.UseVisualStyleBackColor = false;
            btnResetar.Click += button2_Click;
            // 
            // labelPontuação
            // 
            labelPontuação.AutoSize = true;
            labelPontuação.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPontuação.Location = new Point(659, 36);
            labelPontuação.Name = "labelPontuação";
            labelPontuação.Size = new Size(107, 25);
            labelPontuação.TabIndex = 6;
            labelPontuação.Text = "Pontuação";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(334, 221);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(121, 27);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += button3_Click;
            // 
            // trmMarmota
            // 
            trmMarmota.Interval = 1000;
            trmMarmota.Tick += trmMarmota_Tick;
            // 
            // frmMarmota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciar);
            Controls.Add(labelPontuação);
            Controls.Add(btnResetar);
            Controls.Add(btnSair);
            Controls.Add(pgbTempo);
            Controls.Add(labelPontuaçãoNúmero);
            Controls.Add(pictureBoxMarmota);
            Name = "frmMarmota";
            Text = "Jogo da Marmota";
            Load += frmTime_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMarmota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMarmota;
        private Label labelPontuaçãoNúmero;
        private ProgressBar pgbTempo;
        private System.Windows.Forms.Timer tmrTempo;
        private Button btnSair;
        private Button btnResetar;
        private Label labelPontuação;
        private Button btnIniciar;
        private System.Windows.Forms.Timer trmMarmota;
    }
}