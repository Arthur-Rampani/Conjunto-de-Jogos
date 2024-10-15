namespace Calculadora
{
    partial class FrmCentimetroePolegada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCentimetroePolegada));
            txtBoxCentimetro = new TextBox();
            Converter = new Button();
            txtBoxPolegada = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BttLimpar = new Button();
            SuspendLayout();
            // 
            // txtBoxCentimetro
            // 
            txtBoxCentimetro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxCentimetro.Location = new Point(12, 68);
            txtBoxCentimetro.Name = "txtBoxCentimetro";
            txtBoxCentimetro.Size = new Size(151, 34);
            txtBoxCentimetro.TabIndex = 1;
            txtBoxCentimetro.TextAlign = HorizontalAlignment.Center;
            // 
            // Converter
            // 
            Converter.BackColor = Color.Yellow;
            Converter.Location = new Point(219, 23);
            Converter.Name = "Converter";
            Converter.Size = new Size(111, 47);
            Converter.TabIndex = 2;
            Converter.Text = "Converter";
            Converter.UseVisualStyleBackColor = false;
            Converter.Click += Converter_Click;
            // 
            // txtBoxPolegada
            // 
            txtBoxPolegada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxPolegada.Location = new Point(12, 178);
            txtBoxPolegada.Multiline = true;
            txtBoxPolegada.Name = "txtBoxPolegada";
            txtBoxPolegada.Size = new Size(280, 43);
            txtBoxPolegada.TabIndex = 3;
            txtBoxPolegada.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 4;
            label1.Text = "Valor em Cetímetro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 5;
            label2.Text = "Valor em Polegadas";
            // 
            // BttLimpar
            // 
            BttLimpar.BackColor = Color.Blue;
            BttLimpar.ForeColor = SystemColors.ButtonHighlight;
            BttLimpar.Location = new Point(219, 112);
            BttLimpar.Name = "BttLimpar";
            BttLimpar.Size = new Size(111, 47);
            BttLimpar.TabIndex = 6;
            BttLimpar.Text = "Limpar";
            BttLimpar.UseVisualStyleBackColor = false;
            BttLimpar.Click += BttLimpar_Click;
            // 
            // FrmCentimetroePolegada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 274);
            Controls.Add(BttLimpar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxPolegada);
            Controls.Add(Converter);
            Controls.Add(txtBoxCentimetro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmCentimetroePolegada";
            Text = "FrmCentimetroePolegada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxCentimetro;
        private Button Converter;
        private TextBox txtBoxPolegada;
        private Label label1;
        private Label label2;
        private Button BttLimpar;
    }
}