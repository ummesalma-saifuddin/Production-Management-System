using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_GUI
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDH5DJ47\SQLEXPRESS;Initial Catalog=Gohar Apparel;Integrated Security=True");
         

        public Form3()
        {
            InitializeComponent();
           
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gohar_ApparelDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.gohar_ApparelDataSet.Supplier);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();

            //supplierBindingSource.AddNew();
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
                    SqlCommand cmd = new SqlCommand("update_supplier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@FullName_Supplier", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Tax_Credit", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Telephone", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Mobile", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox9.Text);
                    cmd.Parameters.AddWithValue("@std_code", textBox10.Text);
                    cmd.Parameters.AddWithValue("@active_status", checkBox1.CheckState);
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
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //supplierBindingSource.EndEdit();
            //supplierTableAdapter.Update(gohar_ApparelDataSet.Supplier);

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("update_supplier",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@FullName_Supplier", textBox2.Text);
                cmd.Parameters.AddWithValue("@Tax_Credit", textBox3.Text);
                cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                cmd.Parameters.AddWithValue("@Telephone", textBox6.Text);
                cmd.Parameters.AddWithValue("@Mobile", textBox7.Text);
                cmd.Parameters.AddWithValue("@Email" , textBox9.Text);
                cmd.Parameters.AddWithValue("@std_code" , textBox10.Text);
                cmd.Parameters.AddWithValue("@active_status" , checkBox1.CheckState);
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

            //DBconnectioncs c = new DBconnectioncs();
            //c.Inserts("update Supplier set ID  = '" + textBox1.Text + "' where id = " + textBox1.Text);
            //c.Inserts("update Supplier set [FullName_Supplier] = '" + textBox2.Text + "' where id = " + textBox1.Text);
            //c.Inserts("update Supplier set Tax_Credit = '" + textBox3.Text + "' where id = " + textBox1.Text);
            //c.Inserts("update Supplier set Address1 = '" + textBox4.Text + "' where id = " + textBox1.Text);
            //c.Inserts("update Supplier set Telephone = '" + textBox6.Text + "' where id = " + textBox1.Text);
            //c.Inserts("update Supplier set Mobile = '" + textBox7.Text + "' where id = " + textBox1.Text);
            //c.Inserts("update Supplier set Email = '" + textBox9.Text + "' where id = " + textBox1.Text);
            //c.Inserts("update Supplier set STD_Code = '" + textBox10.Text + "' where id = " + textBox1.Text);
            //c.Inserts("update Supplier set Active_Status = '" + checkBox1.CheckState + "' where id = " + textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Supplier where " +"Supplier.idsupplier = " + textBox1.Text, con);
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
        void fill_data_grid_view()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataAdapter sqlda = new SqlDataAdapter("search_supplier", con);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@ID", textBox1.Text);
            sqlda.SelectCommand.Parameters.AddWithValue("@FullName_Supplier", textBox2.Text);
            sqlda.SelectCommand.Parameters.AddWithValue("@Tax_Credit", textBox3.Text);
            sqlda.SelectCommand.Parameters.AddWithValue("@Address", textBox4.Text);
            sqlda.SelectCommand.Parameters.AddWithValue("@Telephone", textBox6.Text);
            sqlda.SelectCommand.Parameters.AddWithValue("@Mobile", textBox7.Text);
            sqlda.SelectCommand.Parameters.AddWithValue("@Email", textBox9.Text);
            sqlda.SelectCommand.Parameters.AddWithValue("@std_code", textBox10.Text);
            sqlda.SelectCommand.Parameters.AddWithValue("@active_status", checkBox1.CheckState);

            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
