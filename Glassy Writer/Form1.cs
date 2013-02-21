using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Glassy_Writer
{
    public partial class Form1 : Form
    {
        Form2 frm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] args = Environment.GetCommandLineArgs();
                if (args.Length == 2)
                {
                    richTextBox1.Text = File.ReadAllText(args[1]);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
            this.richTextBox1.Focus();
            this.richTextBox1.SelectionStart = richTextBox1.TextLength;
            }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }
            if (keyData == (Keys.Control | Keys.O))
            {
                string textO="";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string file = openFileDialog1.FileName;
                    try
                    {
                        textO= File.ReadAllText(file);
                    }
                    catch (IOException exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    richTextBox1.Text = textO;
                }
                return true;
            }
            if (keyData == (Keys.Control|Keys.S))
            {
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK && saveFileDialog1.FileName!=null)
                {
                    string file = saveFileDialog1.FileName;
                    try
                    {
                        File.WriteAllText(file,richTextBox1.Text);                
                    }
                    catch (IOException exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonPref_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2,
    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            panel1.Visible=true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Location = new Point(this.ClientSize.Width / 2 - panel2.Size.Width / 2,
    this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(fontDialog1.ShowDialog()==DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            richTextBox1.ForeColor = colorDialog2.Color;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
             this.Opacity = trackBar1.Value * 0.01;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm = new Form2(this);
            frm.Show();
            this.Opacity = 100;
            this.richTextBox1.BackColor = System.Drawing.Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.Opacity = .85;
            Font fnt = new Font("Century Gothic", 21);
            this.richTextBox1.ForeColor = System.Drawing.Color.PaleGreen;
            this.richTextBox1.Font = fnt;
            try{
                frm.Close();
        }
            catch(Exception exp)
            {            
            
            }
        }

        

        

        
        
    }
}
