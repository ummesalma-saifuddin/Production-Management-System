using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Project_GUI
{
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDH5DJ47\SQLEXPRESS;Initial Catalog=Gohar Apparel;Integrated Security=True");

        public Form10()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete?";
            DialogResult dialogResult = MessageBox.Show(message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("cat_sum", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Color", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Size", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox1.Text);


                    cmd.Parameters.AddWithValue("@mode", "Delete");
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }

                finally
                {
                    con.Close();
                }
            }
        }



        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gohar_ApparelDataSet.Catalogue' table. You can move, or remove it, as needed.
            this.catalogueTableAdapter.Fill(this.gohar_ApparelDataSet.Catalogue);
            this.orders_has_CatalogueTableAdapter1.Fill(this.gohar_ApparelDataSet.Orders_has_Catalogue);

        }
            
        
    }
}