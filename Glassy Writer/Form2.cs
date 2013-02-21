using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glassy_Writer
{
    public partial class Form2 : Form
    {
        Form frmM;
        public Form2(Form parentForm)
        {
            InitializeComponent();
            frmM = parentForm;
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.BackgroundImage = new Bitmap(openFileDialog1.FileName);
            }
            frmM.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cld=new ColorDialog();
            cld.ShowDialog();
            this.BackColor = cld.Color;
            frmM.ForeColor= cld.Color;
            MessageBox.Show(frmM.Name.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.BackgroundImage = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void buttonPref_Click(object sender, EventArgs e)
        {
            
        }
    }
}
