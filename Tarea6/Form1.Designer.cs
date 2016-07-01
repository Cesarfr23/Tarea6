namespace Tarea6
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separarCadenasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificarCadenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularSumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenAlfabeticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.separarCadenasToolStripMenuItem,
            this.justificarCadenaToolStripMenuItem,
            this.mostrarHoraToolStripMenuItem,
            this.calcularSumaToolStripMenuItem,
            this.ordenAlfabeticoToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // separarCadenasToolStripMenuItem
            // 
            this.separarCadenasToolStripMenuItem.Name = "separarCadenasToolStripMenuItem";
            this.separarCadenasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.separarCadenasToolStripMenuItem.Text = "1-Separar Cadenas";
            // 
            // justificarCadenaToolStripMenuItem
            // 
            this.justificarCadenaToolStripMenuItem.Name = "justificarCadenaToolStripMenuItem";
            this.justificarCadenaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.justificarCadenaToolStripMenuItem.Text = "2-Justificar Cadena";
            // 
            // mostrarHoraToolStripMenuItem
            // 
            this.mostrarHoraToolStripMenuItem.Name = "mostrarHoraToolStripMenuItem";
            this.mostrarHoraToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.mostrarHoraToolStripMenuItem.Text = "3-Mostrar Hora";
            // 
            // calcularSumaToolStripMenuItem
            // 
            this.calcularSumaToolStripMenuItem.Name = "calcularSumaToolStripMenuItem";
            this.calcularSumaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.calcularSumaToolStripMenuItem.Text = "4-Calcular Suma";
            // 
            // ordenAlfabeticoToolStripMenuItem
            // 
            this.ordenAlfabeticoToolStripMenuItem.Name = "ordenAlfabeticoToolStripMenuItem";
            this.ordenAlfabeticoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ordenAlfabeticoToolStripMenuItem.Text = "5-Orden Alfabetico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 319);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separarCadenasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificarCadenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularSumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenAlfabeticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

