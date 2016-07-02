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
    public partial class OrdenAlfabetico : System.Windows.Forms.Form
    {
        public OrdenAlfabetico()
        {
            InitializeComponent();
        }

        private void OredenAlfabeticoButton_Click(object sender, EventArgs e)
        {
            string cadena = Convert.ToString(OrdenarTextBox.Text);
            string cadena2 = Convert.ToString(Ordenar2TextBox.Text);


           

            CadenaEnOrdenListBox.Items.Add(string.CompareOrdinal(cadena, cadena2));
        }
    }
}
