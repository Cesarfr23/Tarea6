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
    public partial class CalcularSuma : System.Windows.Forms.Form
    {
        public CalcularSuma()
        {
            InitializeComponent();
        }

        private void ResultadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int resultado;

            numero1 = Convert.ToInt16(Numero1TextBox.Text);
            numero2 = Convert.ToInt16(Numero2TextBox.Text);

            resultado = numero1 + numero2;
            if(resultado<0)
            {
                ResultadoTextBox.Text = "(" + Convert.ToInt16(resultado) + ")";
            }
            else
            {
                ResultadoTextBox.Text = "" + Convert.ToInt16(resultado);
            }
        }
    }
}
