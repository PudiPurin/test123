using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO WORLD");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world 2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}
