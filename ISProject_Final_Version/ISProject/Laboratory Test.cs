using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ISProject
{
    public partial class Laboratory_Test : Form
    {
        public Laboratory_Test()
        {
            InitializeComponent();
            DisplayTest();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClinicDb.mdf;Integrated Security=True");

        private void DisplayTest()
        {
            con.Open();
            string Query = "select * from TestsTb";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            TestDGV.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        private void Clear()
        {
            TName.Text = "";
            TCost.Text = "";

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TName.Text == "" || TCost.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TestsTb(TestName,TestCost) values(@TN,@TC) ", con);
                    cmd.Parameters.AddWithValue("@TN", TName.Text);
                    cmd.Parameters.AddWithValue("@TC", TCost.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Added");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        int key = 0;

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TName.Text == "" || TCost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("update TestsTb set TestName=@TN,TestCost=@TC where TestNum=@Tkey ", con);
                    cmd.Parameters.AddWithValue("@TN", TName.Text);
                    cmd.Parameters.AddWithValue("@TC", TCost.Text);
                    cmd.Parameters.AddWithValue("@TKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Updated");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (TName.Text == "" || TCost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from  TestsTb where TestNum=@Tkey ", con);
                    cmd.Parameters.AddWithValue("@TN", TName.Text);
                    cmd.Parameters.AddWithValue("@TC", TCost.Text);
                    cmd.Parameters.AddWithValue("@TKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Deleted");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void TestDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TName.Text = TestDGV.SelectedRows[0].Cells[1].Value.ToString();
            TCost.Text = TestDGV.SelectedRows[0].Cells[2].Value.ToString();
            
            if (TName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TestDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();

        }

        private void TName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Laboratory_Test_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Homes homes = new Homes();
            homes.Show();
            this.Hide();
        }
    }
    }

