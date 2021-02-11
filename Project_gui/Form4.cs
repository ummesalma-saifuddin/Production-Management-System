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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDH5DJ47\SQLEXPRESS;Initial Catalog=Gohar Apparel;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("update_supplier", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", 420);
                cmd.Parameters.AddWithValue("@FullName_Supplier", textBox2.Text);
                cmd.Parameters.AddWithValue("@Tax_Credit", textBox3.Text);
                cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                cmd.Parameters.AddWithValue("@Telephone", textBox6.Text);
                cmd.Parameters.AddWithValue("@Mobile", textBox7.Text);
                cmd.Parameters.AddWithValue("@Email", textBox9.Text);
                cmd.Parameters.AddWithValue("@std_code", textBox10.Text);
                cmd.Parameters.AddWithValue("@active_status", checkBox1.CheckState);
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
