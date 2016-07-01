namespace Tarea6
{
    partial class JustificarCadena
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
            this.CadenaJustificadaLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.JustificarComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CadenaJustificadaLabel
            // 
            this.CadenaJustificadaLabel.AutoSize = true;
            this.CadenaJustificadaLabel.Location = new System.Drawing.Point(26, 26);
            this.CadenaJustificadaLabel.Name = "CadenaJustificadaLabel";
            this.CadenaJustificadaLabel.Size = new System.Drawing.Size(120, 13);
            this.CadenaJustificadaLabel.TabIndex = 0;
            this.CadenaJustificadaLabel.Text = "Introdusca Una Cadena";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 95);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 20);
            this.textBox1.TabIndex = 2;
            // 
            // JustificarComboBox
            // 
            this.JustificarComboBox.FormattingEnabled = true;
            this.JustificarComboBox.Location = new System.Drawing.Point(189, 26);
            this.JustificarComboBox.Name = "JustificarComboBox";
            this.JustificarComboBox.Size = new System.Drawing.Size(121, 21);
            this.JustificarComboBox.TabIndex = 3;
            // 
            // JustificarCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 429);
            this.Controls.Add(this.JustificarComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CadenaJustificadaLabel);
            this.MinimumSize = new System.Drawing.Size(283, 364);
            this.Name = "JustificarCadena";
            this.Text = "JustificarCadena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CadenaJustificadaLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox JustificarComboBox;
    }
}