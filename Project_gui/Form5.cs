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
    public partial class Form5 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDH5DJ47\SQLEXPRESS;Initial Catalog=Gohar Apparel;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gohar_ApparelDataSet.Master_Product_has_Raw_Materials_Items' table. You can move, or remove it, as needed.
            this.master_Product_has_Raw_Materials_ItemsTableAdapter.Fill(this.gohar_ApparelDataSet.Master_Product_has_Raw_Materials_Items);
            // TODO: This line of code loads data into the 'gohar_ApparelDataSet.Raw_Materials_Items' table. You can move, or remove it, as needed.
            this.raw_Materials_ItemsTableAdapter.Fill(this.gohar_ApparelDataSet.Raw_Materials_Items);
            // TODO: This line of code loads data into the 'gohar_ApparelDataSet.Raw_Materials' table. You can move, or remove it, as needed.
            this.raw_MaterialsTableAdapter.Fill(this.gohar_ApparelDataSet.Raw_Materials);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete?";
            DialogResult dialogResult = MessageBox.Show(message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
            {


                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Raw_Materials_Items where id_details = " + textBox2.Text, con);
                    cmd.CommandType = CommandType.Text;
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
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Raw_Materials_Items r where " + "r.id_details = " + textBox2.Text, con);

                SqlCommand cmd = new SqlCommand("select * from Raw_Materials_Items r where " + "r.id_details = " + textBox2.Text, con);
                cmd.CommandType = CommandType.StoredProcedure;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
