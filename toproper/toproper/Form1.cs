using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace toproper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = textInfo.ToTitleCase(richTextBox1.Text);
        }
    }
}
