using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GUI
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
