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
    public partial class Form12 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDH5DJ47\SQLEXPRESS;Initial Catalog=Gohar Apparel;Integrated Security=True");

        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

                cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);


                cmd.Parameters.AddWithValue("@mode", "Add");
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
}
