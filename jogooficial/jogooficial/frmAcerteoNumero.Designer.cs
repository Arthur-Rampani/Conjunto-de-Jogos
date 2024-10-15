namespace jogooficial
{
    partial class frmAcerteoNumero
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
            numericUpDownNumeros = new NumericUpDown();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSair = new Button();
            btnResetar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumeros).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownNumeros
            // 
            numericUpDownNumeros.Font = new Font("Segoe UI Emoji", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownNumeros.Location = new Point(221, 117);
            numericUpDownNumeros.Name = "numericUpDownNumeros";
            numericUpDownNumeros.Size = new Size(183, 135);
            numericUpDownNumeros.TabIndex = 0;
            numericUpDownNumeros.TextAlign = HorizontalAlignment.Center;
            numericUpDownNumeros.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(221, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tentativas";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 51);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 0;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 49);
            label1.Name = "label1";
            label1.Size = new Size(387, 32);
            label1.TabIndex = 4;
            label1.Text = "Acerte um número entre 0 à 100";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cima_removebg_preview;
            pictureBox1.Location = new Point(27, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.baixo_removebg_preview__1_;
            pictureBox2.Location = new Point(460, 128);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(48, 312);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(81, 33);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnResetar
            // 
            btnResetar.BackColor = Color.Lime;
            btnResetar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetar.Location = new Point(510, 312);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(76, 38);
            btnResetar.TabIndex = 7;
            btnResetar.Text = "Resetar";
            btnResetar.UseVisualStyleBackColor = false;
            btnResetar.Click += btnResetar_Click;
            // 
            // frmAcerteoNumero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 410);
            Controls.Add(btnResetar);
            Controls.Add(btnSair);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(numericUpDownNumeros);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAcerteoNumero";
            Text = "Acerte o Número";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumeros).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownNumeros;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSair;
        private Button btnResetar;
    }
}