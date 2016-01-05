using System;
using System.Windows.Forms;

namespace View
{
    public partial class Sphere : Form
    {
        public Sphere()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxV.Clear();
            if (textBoxR.Text == "") return;
            int R;
            double V;
            if (int.TryParse(textBoxR.Text, out R))
            {
                V = 4 / 3.0 * 3.1415 * R * R * R;
                textBoxV.AppendText(V.ToString());
            }
            else
            {
                
            }
        }
    }
}
