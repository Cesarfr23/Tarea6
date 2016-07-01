namespace Tarea6
{
    partial class OrdenAlfabetico
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
            this.OredenAlfabeticoButton = new System.Windows.Forms.Button();
            this.OrdenAlfabeticoLabel = new System.Windows.Forms.Label();
            this.CadenaEnOrdenListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OredenAlfabeticoButton
            // 
            this.OredenAlfabeticoButton.Location = new System.Drawing.Point(187, 46);
            this.OredenAlfabeticoButton.Name = "OredenAlfabeticoButton";
            this.OredenAlfabeticoButton.Size = new System.Drawing.Size(181, 23);
            this.OredenAlfabeticoButton.TabIndex = 0;
            this.OredenAlfabeticoButton.Text = "Mostras En Oreden Alfabetico";
            this.OredenAlfabeticoButton.UseVisualStyleBackColor = true;
            // 
            // OrdenAlfabeticoLabel
            // 
            this.OrdenAlfabeticoLabel.AutoSize = true;
            this.OrdenAlfabeticoLabel.Location = new System.Drawing.Point(41, 56);
            this.OrdenAlfabeticoLabel.Name = "OrdenAlfabeticoLabel";
            this.OrdenAlfabeticoLabel.Size = new System.Drawing.Size(120, 13);
            this.OrdenAlfabeticoLabel.TabIndex = 1;
            this.OrdenAlfabeticoLabel.Text = "Introdusca Una Cadena";
            // 
            // CadenaEnOrdenListBox
            // 
            this.CadenaEnOrdenListBox.FormattingEnabled = true;
            this.CadenaEnOrdenListBox.Location = new System.Drawing.Point(44, 186);
            this.CadenaEnOrdenListBox.Name = "CadenaEnOrdenListBox";
            this.CadenaEnOrdenListBox.Size = new System.Drawing.Size(471, 95);
            this.CadenaEnOrdenListBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 20);
            this.textBox1.TabIndex = 3;
            // 
            // OrdenAlfabetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 429);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CadenaEnOrdenListBox);
            this.Controls.Add(this.OrdenAlfabeticoLabel);
            this.Controls.Add(this.OredenAlfabeticoButton);
            this.MinimumSize = new System.Drawing.Size(283, 364);
            this.Name = "OrdenAlfabetico";
            this.Text = "OrdenAlfabetico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OredenAlfabeticoButton;
        private System.Windows.Forms.Label OrdenAlfabeticoLabel;
        private System.Windows.Forms.ListBox CadenaEnOrdenListBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}