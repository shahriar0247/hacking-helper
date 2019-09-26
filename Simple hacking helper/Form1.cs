using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_hacking_helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        public int textvalue = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = textvalue.ToString();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textvalue = textvalue + 1;
            textBox1.Text = textvalue.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
