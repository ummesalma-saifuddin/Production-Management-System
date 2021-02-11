using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Project_GUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin123" && textBox2.Text=="admin" ){
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                string message = "Invalid Password or Username";
                MessageBox.Show(message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
