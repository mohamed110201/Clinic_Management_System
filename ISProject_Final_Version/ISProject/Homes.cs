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
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
            if (Login.role == "Receptionist")
            {
               label4.Enabled=false; label2.Enabled=false; label16.Enabled=false;
            }
            if (Login.role == "Admin") 
            {
                label4.Enabled = true; label2.Enabled = true;
            }
            if(Login.role == "Doctor")
            {
                label4.Enabled = false; label2.Enabled = false;
            }
            

            Display();
            CountDoctors();
            CountPatients();
            CountTests();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClinicDb.mdf;Integrated Security=True");

        private void Display()
        {

            pictureBox2.MouseHover += (a_sender, a_args) =>
            {
                PatPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox2.MouseLeave += (a_sender, a_args) =>
            {
                PatPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            pictureBox3.MouseHover += (a_sender, a_args) =>
            {
                LabPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox3.MouseLeave += (a_sender, a_args) =>
            {
                LabPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            pictureBox4.MouseHover += (a_sender, a_args) =>
            {
                DocPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox4.MouseLeave += (a_sender, a_args) =>
            {
                DocPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            pictureBox5.MouseHover += (a_sender, a_args) =>
            {
                RecPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox5.MouseLeave += (a_sender, a_args) =>
            {
                RecPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            pictureBox11.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox11.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            pictureBox1.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel2.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox1.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel2.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            //--------------------------------------------------------------------//

            label11.MouseHover += (a_sender, a_args) =>
            {
                PatPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label11.MouseLeave += (a_sender, a_args) =>
            {
                PatPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            label3.MouseHover += (a_sender, a_args) =>
            {
                LabPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label3.MouseLeave += (a_sender, a_args) =>
            {
                LabPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            label2.MouseHover += (a_sender, a_args) =>
            {
                DocPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label2.MouseLeave += (a_sender, a_args) =>
            {
                DocPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            label4.MouseHover += (a_sender, a_args) =>
            {
                RecPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label4.MouseLeave += (a_sender, a_args) =>
            {
                RecPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            label1.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel2.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label1.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel2.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            label13.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label13.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            label16.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label16.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            pictureBox14.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox14.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
            };
        }
            private void Homes_Load(object sender, EventArgs e)
        {

        }

        private void CountPatients()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PatientsTb", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatC.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountDoctors()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DoctorsTb", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DocC.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountTests()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TestsTb", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TestC.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PatPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Patients pt= new Patients();
            this.Hide();
            pt.ShowDialog(); 
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Doctors2 dc= new Doctors2();
            this.Hide();
            dc.ShowDialog();    
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Laboratory_Test laboratory= new Laboratory_Test();
            
            laboratory.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Receptionists rc= new Receptionists();
            this.Hide();
            rc.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Search search= new Search();
            this.Hide();
            search.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Appointment appointment= new Appointment();
            this.Hide();
            appointment.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Login lg= new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Login lg= new Login();
            this.Hide(); 
            lg.ShowDialog();   
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Prescriptions prescriptions = new Prescriptions();
            prescriptions.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void PatC_Click(object sender, EventArgs e)
        {

        }
    }
}
