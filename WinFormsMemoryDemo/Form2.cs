using System;
using System.Text;
using System.Windows.Forms;

namespace WinFormsMemoryDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var sb = new StringBuilder();
            for (int i = 0; i < 200000; i++)
            {
                sb.Append(DateTime.Now);
            }

            textBox1.Text = sb.ToString();
        }
    }
}
