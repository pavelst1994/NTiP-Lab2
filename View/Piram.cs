using System;
using System.Windows.Forms;

namespace View
{
    public partial class Piram : Form
    {
        public Piram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxV.Clear();
            if ((textBoxS.Text == "") || (textBoxH.Text == "")) return;
            int S, H;
            double V;
            if ((int.TryParse(textBoxS.Text, out S)) 
                && ((int.TryParse(textBoxH.Text, out H))))
            {
                V = 1 / 3.0 * S * H;
                textBoxV.AppendText(V.ToString());
            }
            else
            {

            }
        }
    }
}
