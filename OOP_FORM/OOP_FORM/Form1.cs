using System;
using System.Windows.Forms;

namespace OOP_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Flat.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Popup.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Standard.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.System.ToString();
        }
    }
}