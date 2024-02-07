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

namespace ISProject
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClinicDb.mdf;Integrated Security=True");
        public static string role;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            PassWord.isPassword = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Homes h = new Homes();
            h.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(Role.SelectedIndex==-1)
            {
                MessageBox.Show("Select Your Position");
            }
            else if(Role.SelectedIndex==0)
            {
                if(UserName.Text==""||PassWord.Text=="")
                {
                    MessageBox.Show("Enter Both Admin Name and Password");
                }
                else if(UserName.Text=="Admin" && PassWord.Text=="PASSWORD")
                {
                    role = UserName.Text;
                    Homes pa = new Homes();
                    this.Hide();
                    pa.Show();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or PassWord");
                }
            }

            else if (Role.SelectedIndex == 1)
            {
                if (UserName.Text == "" || PassWord.Text == "")
                {
                    MessageBox.Show("Enter Both Receptionist Name and Password");
                }

                else
                {


                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from ReceptionistsTb where RecName = '" + UserName.Text + "' and RecPass ='" + PassWord.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        role = "Receptionist";
                        Homes pre = new Homes();
                        pre.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receprionist Not Found");
                    }
                }
                con.Close();
            }

            else 
            {
                if (UserName.Text == "" || PassWord.Text == "")
                {
                    MessageBox.Show("Enter Both Doctor Name and Password");
                }

                else
                {


                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DoctorsTb where DocName = '" + UserName.Text + "' and DocPass ='" + PassWord.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        role = "Doctor";
                        Prescriptions pre = new Prescriptions();
                        pre.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor Not Found");
                    }
                }
                con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PassWord_OnValueChanged(object sender, EventArgs e)
        {
            PassWord.isPassword= true;
        }
    }
}
