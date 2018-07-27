using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
     
        public Form3()
        {
           
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.button1.Text = "Find with";

            this.button2.Text = "Replace with";
            this.button3.Text = "Ok";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            if (f1.textBox1.Text.Contains(this.textBox1.Text)) {
                f1.textBox1.Text.Replace(this.textBox2.Text, f1.textBox1.Text);
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.textBox1.Text.Replace(this.textBox1.Text, f1.textBox1.Text);
        }
    }
}
