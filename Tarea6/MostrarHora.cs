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
    public partial class MostrarHora : System.Windows.Forms.Form
    {
        public MostrarHora()
        {
            InitializeComponent();
        }

        private void HoraButton_Click(object sender, EventArgs e)
        {
            HoraTextBox.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
