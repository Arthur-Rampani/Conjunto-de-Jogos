namespace Calculadora
{
    partial class FrmTemperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTemperatura));
            txtBoxCelsius = new TextBox();
            label1 = new Label();
            BttConverter = new Button();
            label2 = new Label();
            txtBoxFahrenheit = new TextBox();
            BttLimpar = new Button();
            SuspendLayout();
            // 
            // txtBoxCelsius
            // 
            txtBoxCelsius.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxCelsius.Location = new Point(14, 56);
            txtBoxCelsius.Multiline = true;
            txtBoxCelsius.Name = "txtBoxCelsius";
            txtBoxCelsius.Size = new Size(203, 37);
            txtBoxCelsius.TabIndex = 1;
            txtBoxCelsius.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(206, 23);
            label1.TabIndex = 2;
            label1.Text = "Temperatura em Celsius:";
            // 
            // BttConverter
            // 
            BttConverter.BackColor = Color.Yellow;
            BttConverter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BttConverter.Location = new Point(250, 56);
            BttConverter.Name = "BttConverter";
            BttConverter.Size = new Size(121, 37);
            BttConverter.TabIndex = 3;
            BttConverter.Text = "Converter";
            BttConverter.UseVisualStyleBackColor = false;
            BttConverter.Click += BttConverter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 127);
            label2.Name = "label2";
            label2.Size = new Size(231, 23);
            label2.TabIndex = 4;
            label2.Text = "Temperatura em Fahrenheit";
            // 
            // txtBoxFahrenheit
            // 
            txtBoxFahrenheit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxFahrenheit.Location = new Point(12, 159);
            txtBoxFahrenheit.Multiline = true;
            txtBoxFahrenheit.Name = "txtBoxFahrenheit";
            txtBoxFahrenheit.ReadOnly = true;
            txtBoxFahrenheit.Size = new Size(227, 72);
            txtBoxFahrenheit.TabIndex = 5;
            txtBoxFahrenheit.TextAlign = HorizontalAlignment.Center;
            // 
            // BttLimpar
            // 
            BttLimpar.BackColor = Color.Blue;
            BttLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BttLimpar.ForeColor = SystemColors.ButtonHighlight;
            BttLimpar.Location = new Point(264, 138);
            BttLimpar.Name = "BttLimpar";
            BttLimpar.Size = new Size(94, 55);
            BttLimpar.TabIndex = 6;
            BttLimpar.Text = "Limpar";
            BttLimpar.UseVisualStyleBackColor = false;
            BttLimpar.Click += BttLimpar_Click;
            // 
            // FrmTemperatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 267);
            Controls.Add(BttLimpar);
            Controls.Add(txtBoxFahrenheit);
            Controls.Add(label2);
            Controls.Add(BttConverter);
            Controls.Add(label1);
            Controls.Add(txtBoxCelsius);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmTemperatura";
            Text = "FrmTemperatura";
            Load += FrmTemperatura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BttIgual;
        private TextBox txtBoxCelsius;
        private Label label1;
        private Button BttConverter;
        private Label label2;
        private TextBox txtBoxFahrenheit;
        private Button BttLimpar;
    }
}