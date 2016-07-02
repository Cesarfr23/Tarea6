namespace Tarea6
{
    partial class CalcularSuma
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
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.Numero1Label = new System.Windows.Forms.Label();
            this.Numero2Label = new System.Windows.Forms.Label();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(131, 59);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(141, 20);
            this.Numero1TextBox.TabIndex = 0;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(131, 97);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(141, 20);
            this.Numero2TextBox.TabIndex = 1;
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(99, 146);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(173, 20);
            this.ResultadoTextBox.TabIndex = 2;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(35, 219);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(129, 23);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular Suma";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Numero1Label
            // 
            this.Numero1Label.AutoSize = true;
            this.Numero1Label.Location = new System.Drawing.Point(32, 62);
            this.Numero1Label.Name = "Numero1Label";
            this.Numero1Label.Size = new System.Drawing.Size(76, 13);
            this.Numero1Label.TabIndex = 4;
            this.Numero1Label.Text = "Primer Numero";
            // 
            // Numero2Label
            // 
            this.Numero2Label.AutoSize = true;
            this.Numero2Label.Location = new System.Drawing.Point(32, 104);
            this.Numero2Label.Name = "Numero2Label";
            this.Numero2Label.Size = new System.Drawing.Size(90, 13);
            this.Numero2Label.TabIndex = 5;
            this.Numero2Label.Text = "Segundo Numero";
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Location = new System.Drawing.Point(32, 153);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.ResultadoLabel.TabIndex = 6;
            this.ResultadoLabel.Text = "Resultado";
            this.ResultadoLabel.Click += new System.EventHandler(this.ResultadoLabel_Click);
            // 
            // CalcularSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 429);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.Numero2Label);
            this.Controls.Add(this.Numero1Label);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero1TextBox);
            this.MinimumSize = new System.Drawing.Size(283, 364);
            this.Name = "CalcularSuma";
            this.Text = "CalcularSuma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label Numero1Label;
        private System.Windows.Forms.Label Numero2Label;
        private System.Windows.Forms.Label ResultadoLabel;
    }
}