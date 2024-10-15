namespace Calculadora
{
    partial class FrmTeladeSplash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeladeSplash));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pgbTempo = new ProgressBar();
            trmTempo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._12_59_14_660_512;
            pictureBox1.Location = new Point(225, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 33);
            label1.Name = "label1";
            label1.Size = new Size(215, 36);
            label1.TabIndex = 1;
            label1.Text = "CARREGANDO";
            // 
            // pgbTempo
            // 
            pgbTempo.Location = new Point(2, 415);
            pgbTempo.Maximum = 10;
            pgbTempo.Name = "pgbTempo";
            pgbTempo.Size = new Size(797, 33);
            pgbTempo.TabIndex = 2;
            pgbTempo.Click += pgbTempo_Click;
            // 
            // trmTempo
            // 
            trmTempo.Enabled = true;
            trmTempo.Interval = 750;
            trmTempo.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pgbTempo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora3000";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ProgressBar pgbTempo;
        private System.Windows.Forms.Timer trmTempo;
    }
}
