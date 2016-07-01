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
    public partial class JustificarCadena : System.Windows.Forms.Form
    {
        public JustificarCadena()
        {
            InitializeComponent();
        }
        private void JustificarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void JustificarButton_Click(object sender, EventArgs e)
        {

            string cadena = Convert.ToString(JustificarTextBox.Text);
            string resultado = JustificarComboBox.Text;

            switch(resultado)
            {
                case "Justificar a la Derecha":
                    resultado = cadena.PadLeft(5, ' ');
                    JustificarListBox.Items.Add(resultado);
                    break;
                case "Justificar a la Izquierda":
                    resultado = cadena.PadRight(5, ' ');
                    JustificarListBox.Items.Add(resultado);
                    break;
                default:
                    MessageBox.Show("Elija Una Opcion");
                    break;
            }
        }
    }
}
