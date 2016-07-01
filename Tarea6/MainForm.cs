using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea6
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void separarCadenasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SepararCadenas separarCadenas = new SepararCadenas();
            separarCadenas.MdiParent = this;
            separarCadenas.Show();
        }

        private void justificarCadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JustificarCadena justificarCadena = new JustificarCadena();
            justificarCadena.MdiParent = this;
            justificarCadena.Show();
        }

        private void mostrarHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarHora mostraHora = new MostrarHora();
            mostraHora.MdiParent = this;
            mostraHora.Show();
        }

        private void calcularSumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcularSuma calcularSuma = new CalcularSuma();
            calcularSuma.MdiParent = this;
            calcularSuma.Show();
        }

        private void ordenAlfabeticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenAlfabetico ordenAlfabetico = new OrdenAlfabetico();
            ordenAlfabetico.MdiParent = this;
            ordenAlfabetico.Show();
        }
    }
}
