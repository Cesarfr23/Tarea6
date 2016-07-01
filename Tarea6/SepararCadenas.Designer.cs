namespace Tarea6
{
    partial class SepararCadenas
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
            this.SeparaButton = new System.Windows.Forms.Button();
            this.Cadenalabel = new System.Windows.Forms.Label();
            this.CadenaTextBox = new System.Windows.Forms.TextBox();
            this.CadenaSeparadaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SeparaButton
            // 
            this.SeparaButton.Location = new System.Drawing.Point(150, 12);
            this.SeparaButton.Name = "SeparaButton";
            this.SeparaButton.Size = new System.Drawing.Size(84, 23);
            this.SeparaButton.TabIndex = 0;
            this.SeparaButton.Text = "Separar";
            this.SeparaButton.UseVisualStyleBackColor = true;
            this.SeparaButton.Click += new System.EventHandler(this.SeparaButton_Click);
            // 
            // Cadenalabel
            // 
            this.Cadenalabel.AutoSize = true;
            this.Cadenalabel.Location = new System.Drawing.Point(33, 22);
            this.Cadenalabel.Name = "Cadenalabel";
            this.Cadenalabel.Size = new System.Drawing.Size(97, 13);
            this.Cadenalabel.TabIndex = 1;
            this.Cadenalabel.Text = "Introdusca Cadena";
            // 
            // CadenaTextBox
            // 
            this.CadenaTextBox.Location = new System.Drawing.Point(36, 55);
            this.CadenaTextBox.Name = "CadenaTextBox";
            this.CadenaTextBox.Size = new System.Drawing.Size(465, 20);
            this.CadenaTextBox.TabIndex = 2;
            // 
            // CadenaSeparadaListBox
            // 
            this.CadenaSeparadaListBox.FormattingEnabled = true;
            this.CadenaSeparadaListBox.Location = new System.Drawing.Point(36, 131);
            this.CadenaSeparadaListBox.Name = "CadenaSeparadaListBox";
            this.CadenaSeparadaListBox.Size = new System.Drawing.Size(465, 134);
            this.CadenaSeparadaListBox.TabIndex = 3;
            // 
            // SepararCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 429);
            this.Controls.Add(this.CadenaSeparadaListBox);
            this.Controls.Add(this.CadenaTextBox);
            this.Controls.Add(this.Cadenalabel);
            this.Controls.Add(this.SeparaButton);
            this.MinimumSize = new System.Drawing.Size(283, 364);
            this.Name = "SepararCadenas";
            this.Text = "SepararCadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SeparaButton;
        private System.Windows.Forms.Label Cadenalabel;
        private System.Windows.Forms.TextBox CadenaTextBox;
        private System.Windows.Forms.ListBox CadenaSeparadaListBox;
    }
}