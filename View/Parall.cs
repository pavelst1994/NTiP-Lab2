using System;
using System.Windows.Forms;

namespace View
{
    public partial class Parall : Form
    {
        public Parall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxV.Clear();
            if ((textBoxA.Text == "") || (textBoxB.Text == "") || (textBoxC.Text == "")) return;
            int a, b, c;
            double V;
            if ((int.TryParse(textBoxA.Text, out a)) 
                && ((int.TryParse(textBoxB.Text, out b)))
                && ((int.TryParse(textBoxC.Text, out c))))
            {
                V = a*b*c;
                textBoxV.AppendText(V.ToString());
            }
        }
    }
}
