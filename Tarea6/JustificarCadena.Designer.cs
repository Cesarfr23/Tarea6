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
            this.JustificarListBox = new System.Windows.Forms.ListBox();
            this.JustificarTextBox = new System.Windows.Forms.TextBox();
            this.JustificarComboBox = new System.Windows.Forms.ComboBox();
            this.JustificarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadenaJustificadaLabel
            // 
            this.CadenaJustificadaLabel.AutoSize = true;
            this.CadenaJustificadaLabel.Location = new System.Drawing.Point(26, 119);
            this.CadenaJustificadaLabel.Name = "CadenaJustificadaLabel";
            this.CadenaJustificadaLabel.Size = new System.Drawing.Size(120, 13);
            this.CadenaJustificadaLabel.TabIndex = 0;
            this.CadenaJustificadaLabel.Text = "Introdusca Una Cadena";
            // 
            // JustificarListBox
            // 
            this.JustificarListBox.FormattingEnabled = true;
            this.JustificarListBox.Location = new System.Drawing.Point(29, 218);
            this.JustificarListBox.Name = "JustificarListBox";
            this.JustificarListBox.Size = new System.Drawing.Size(508, 95);
            this.JustificarListBox.TabIndex = 1;
            // 
            // JustificarTextBox
            // 
            this.JustificarTextBox.Location = new System.Drawing.Point(29, 149);
            this.JustificarTextBox.Name = "JustificarTextBox";
            this.JustificarTextBox.Size = new System.Drawing.Size(508, 20);
            this.JustificarTextBox.TabIndex = 2;
            // 
            // JustificarComboBox
            // 
            this.JustificarComboBox.FormattingEnabled = true;
            this.JustificarComboBox.Items.AddRange(new object[] {
            "Justificar a la Derecha",
            "Justificar a la Izquierda"});
            this.JustificarComboBox.Location = new System.Drawing.Point(152, 56);
            this.JustificarComboBox.Name = "JustificarComboBox";
            this.JustificarComboBox.Size = new System.Drawing.Size(234, 21);
            this.JustificarComboBox.TabIndex = 3;
            this.JustificarComboBox.SelectedIndexChanged += new System.EventHandler(this.JustificarComboBox_SelectedIndexChanged);
            // 
            // JustificarButton
            // 
            this.JustificarButton.Location = new System.Drawing.Point(410, 54);
            this.JustificarButton.Name = "JustificarButton";
            this.JustificarButton.Size = new System.Drawing.Size(75, 23);
            this.JustificarButton.TabIndex = 4;
            this.JustificarButton.Text = "Justificar";
            this.JustificarButton.UseVisualStyleBackColor = true;
            this.JustificarButton.Click += new System.EventHandler(this.JustificarButton_Click);
            // 
            // JustificarCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 429);
            this.Controls.Add(this.JustificarButton);
            this.Controls.Add(this.JustificarComboBox);
            this.Controls.Add(this.JustificarTextBox);
            this.Controls.Add(this.JustificarListBox);
            this.Controls.Add(this.CadenaJustificadaLabel);
            this.MinimumSize = new System.Drawing.Size(283, 364);
            this.Name = "JustificarCadena";
            this.Text = "JustificarCadena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CadenaJustificadaLabel;
        private System.Windows.Forms.ListBox JustificarListBox;
        private System.Windows.Forms.TextBox JustificarTextBox;
        private System.Windows.Forms.ComboBox JustificarComboBox;
        private System.Windows.Forms.Button JustificarButton;
    }
}