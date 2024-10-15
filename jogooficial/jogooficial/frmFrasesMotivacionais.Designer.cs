namespace jogooficial
{
    partial class frmFrasesMotivacionais
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
            btnNovaFrase = new Button();
            btnSair = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNovaFrase
            // 
            btnNovaFrase.BackColor = Color.DodgerBlue;
            btnNovaFrase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovaFrase.Location = new Point(12, 153);
            btnNovaFrase.Name = "btnNovaFrase";
            btnNovaFrase.Size = new Size(734, 58);
            btnNovaFrase.TabIndex = 0;
            btnNovaFrase.Text = "Nova Frase";
            btnNovaFrase.UseVisualStyleBackColor = false;
            btnNovaFrase.Click += button1_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(12, 231);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(735, 60);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 75);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // frmFrasesMotivacionais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 318);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Controls.Add(btnNovaFrase);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFrasesMotivacionais";
            Text = "Frases Motivacionais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovaFrase;
        private Button btnSair;
        private Label label1;
    }
}