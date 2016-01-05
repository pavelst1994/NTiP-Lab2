using System;
using System.Windows.Forms;

namespace View
{
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSphere_Click(object sender, EventArgs e)
        {
            Sphere windowSphere = new Sphere();
            windowSphere.Show();
        }

        private void buttonPiram_Click(object sender, EventArgs e)
        {
            Piram windowPiram = new Piram();
            windowPiram.Show();
        }

        private void buttonParall_Click(object sender, EventArgs e)
        {
            Parall windowParall = new Parall();
            windowParall.Show();
        }
    }
}
