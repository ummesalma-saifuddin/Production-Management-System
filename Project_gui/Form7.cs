using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GUI
{
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDH5DJ47\SQLEXPRESS;Initial Catalog=Gohar Apparel;Integrated Security=True");

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8= new Form8();
            f8.ShowDialog();
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
                    SqlCommand cmd = new SqlCommand("update_customers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@FullName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Addresss1", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Addresss2", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Telephone", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Mobile", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox9.Text);

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("update_customers", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@FullName", textBox2.Text);

                cmd.Parameters.AddWithValue("@Addresss1", textBox4.Text);
                cmd.Parameters.AddWithValue("@Addresss2", textBox5.Text);
                cmd.Parameters.AddWithValue("@Telephone", textBox6.Text);
                cmd.Parameters.AddWithValue("@Mobile", textBox7.Text);
                cmd.Parameters.AddWithValue("@Email", textBox9.Text);

                cmd.Parameters.AddWithValue("@mode", "Update");
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

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gohar_ApparelDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.gohar_ApparelDataSet.Customer);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Customer where " + "Customer.idcustomer = " + textBox1.Text, con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

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
