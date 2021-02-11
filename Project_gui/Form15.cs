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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[1].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[1].Cells[1].Value = textBox3.Text;
            dataGridView1.Rows[1].Cells[2].Value = richTextBox1.Text;
            dataGridView1.Rows[1].Cells[3].Value = comboBox1.Text; 
            dataGridView1.Rows[1].Cells[4].Value = textBox1.Text;
            dataGridView1.Rows[1].Cells[5].Value = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gohar_ApparelDataSet.Catalogue' table. You can move, or remove it, as needed.
            this.catalogueTableAdapter.Fill(this.gohar_ApparelDataSet.Catalogue);

        }
    }
}
