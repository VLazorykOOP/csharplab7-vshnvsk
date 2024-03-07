using System;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentenses = $"{DateTime.Now}: {textBox1.Text}{Environment.NewLine}";
            richTextBox1.AppendText(sentenses);
        }
    }
}
