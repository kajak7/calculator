using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.ShowDialog();
            this.label1.Text = this.openFileDialog1.FileName;
            this.pictureBox1.Load(this.openFileDialog1.FileName);

        


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

