using System;
using System.Windows.Forms;

namespace OOP_TextBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Name : " + textBox1.Text +
                            "\r\nPassword : " + textBox2.Text;
        }
    }
}
