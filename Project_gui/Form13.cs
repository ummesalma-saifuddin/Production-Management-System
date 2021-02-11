using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Project_GUI
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Masterproducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gohar_ApparelDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.gohar_ApparelDataSet.Orders);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            //PdfWriter.GetInstance(document, new FileStream("C:/Users/Altaf Shaikh/source/repos/Project_GUI/invoice.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph("Invoice Generated");
            document.Add(p);
            document.Close();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
