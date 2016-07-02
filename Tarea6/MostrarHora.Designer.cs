namespace Tarea6
{
    partial class MostrarHora
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
            this.HoraButton = new System.Windows.Forms.Button();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HoraButton
            // 
            this.HoraButton.Location = new System.Drawing.Point(32, 23);
            this.HoraButton.Name = "HoraButton";
            this.HoraButton.Size = new System.Drawing.Size(160, 23);
            this.HoraButton.TabIndex = 0;
            this.HoraButton.Text = "Motrar Hora y Fecha";
            this.HoraButton.UseVisualStyleBackColor = true;
            this.HoraButton.Click += new System.EventHandler(this.HoraButton_Click);
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.Location = new System.Drawing.Point(116, 102);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.Size = new System.Drawing.Size(255, 20);
            this.HoraTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "La Fecha Es:";
            // 
            // MostrarHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoraTextBox);
            this.Controls.Add(this.HoraButton);
            this.MinimumSize = new System.Drawing.Size(283, 364);
            this.Name = "MostrarHora";
            this.Text = "MostrarHora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HoraButton;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.Label label1;
    }
}