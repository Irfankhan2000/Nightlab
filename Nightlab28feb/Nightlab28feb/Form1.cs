using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.wordWrapToolStripMenuItem.Checked = false;
            this.textBox1.Dock = DockStyle.Fill;
            this.StartPosition = FormStartPosition.CenterScreen;
            

            this.Text = "Notepad";
            




        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(fname);

            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dx = saveFileDialog1.ShowDialog();
            if (dx == DialogResult.OK)
            {
                string fname = saveFileDialog1.FileName;
                File.WriteAllText(fname, this.textBox1.Text);



            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dx = saveFileDialog1.ShowDialog();
            if (dx == DialogResult.OK)
            {
                string fname = saveFileDialog1.FileName;
                File.WriteAllText(fname, this.textBox1.Text);
            }
            else
            {
                Application.Exit();


            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";        
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            DialogResult fn = fontDialog1.ShowDialog();
            if(fn==DialogResult.OK){
                this.textBox1.Font = this.fontDialog1.Font;
                this.textBox1.ForeColor = fontDialog1.Color;
             

            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                this.textBox1.WordWrap = true;
            }
            else {
                this.textBox1.WordWrap = false;
            }
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            DialogResult dx = saveFileDialog1.ShowDialog();
            if (dx == DialogResult.OK)
            {
                string fname = saveFileDialog1.FileName;
                File.WriteAllText(fname, this.textBox1.Text);



            }


            }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
     
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can type something you want");
        }

        private void aboutNotepadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Text editing Notepad");
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult fn = colorDialog1.ShowDialog();
            if (fn == DialogResult.OK)
            {
              
                this.textBox1.ForeColor = colorDialog1.Color;


            } this.fontDialog1.ShowColor = true;
          
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad");
        }



           

        }

       
    }

    

