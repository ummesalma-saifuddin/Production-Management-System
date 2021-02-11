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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDH5DJ47\SQLEXPRESS;Initial Catalog=Gohar Apparel;Integrated Security=True");

        public Form9()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
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
                    SqlCommand cmd = new SqlCommand("mp", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", textBox2.Text); 
                    cmd.Parameters.AddWithValue("@Name", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Unit_Cost_Production", textBox1.Text);


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
                    SqlCommand cmd = new SqlCommand("mp", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Name", textBox3.Text);

                    cmd.Parameters.AddWithValue("@Unit_Cost_Production", textBox1.Text);


                    cmd.Parameters.AddWithValue("@mode", "Edit");
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

            private void Form9_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'gohar_ApparelDataSet.Master_Product' table. You can move, or remove it, as needed.
                this.master_ProductTableAdapter.Fill(this.gohar_ApparelDataSet.Master_Product);
                this.catalogueTableAdapter.Fill(this.gohar_ApparelDataSet.Catalogue);

                this.master_Product_has_Raw_MaterialTableAdapter.Fill(this.gohar_ApparelDataSet.Master_Product_has_Raw_Materials_Items);



            }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Master_Product where " + "Master_Product.idMaster_Product = " + textBox2.Text, con);
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

