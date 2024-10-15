namespace jogooficial
{
    partial class frmPapagaio
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
            txtBoxTexto = new TextBox();
            label1 = new Label();
            btnPapagaio = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxTexto
            // 
            txtBoxTexto.Location = new Point(290, 102);
            txtBoxTexto.Margin = new Padding(3, 2, 3, 2);
            txtBoxTexto.Name = "txtBoxTexto";
            txtBoxTexto.Size = new Size(238, 23);
            txtBoxTexto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 58);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 2;
            label1.Text = "Digite alguma coisa";
            label1.Click += label1_Click;
            // 
            // btnPapagaio
            // 
            btnPapagaio.BackColor = Color.Lime;
            btnPapagaio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPapagaio.Location = new Point(290, 147);
            btnPapagaio.Margin = new Padding(3, 2, 3, 2);
            btnPapagaio.Name = "btnPapagaio";
            btnPapagaio.Size = new Size(238, 30);
            btnPapagaio.TabIndex = 3;
            btnPapagaio.Text = "CURUPACO";
            btnPapagaio.UseVisualStyleBackColor = false;
            btnPapagaio.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(364, 224);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(104, 37);
            button2.TabIndex = 4;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.papagaio_removebg_preview;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmPapagaio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 338);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(btnPapagaio);
            Controls.Add(label1);
            Controls.Add(txtBoxTexto);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPapagaio";
            Text = "Papagaio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxTexto;
        private Label label1;
        private Button btnPapagaio;
        private Button button2;
        private PictureBox pictureBox1;
    }
}