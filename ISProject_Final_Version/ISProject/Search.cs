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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            SidePar();

            if (Login.role == "Receptionist")
            {
                label4.Enabled = false; label2.Enabled = false; label16.Enabled = false;
            }
            if (Login.role == "Admin")
            {
                label4.Enabled = true; label2.Enabled = true;
            }
            if (Login.role == "Doctor")
            {
                label4.Enabled = false; label2.Enabled = false;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClinicDb.mdf;Integrated Security=True");

        private void SidePar()
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

            pictureBox8.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox8.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            pictureBox7.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel2.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox7.MouseLeave += (a_sender, a_args) =>
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

            label8.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label8.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            label1.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel2.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label1.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel2.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            label16.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label16.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            pictureBox10.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox10.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
            };
        }
        private void DisplayDoc(string s)
        {
            con.Open();
            string Query = $"select * from DoctorsTb where DocName Like '%{s}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            RecDGV.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        private void DisplayRec(string s)
        {
            con.Open();
            string Query = $"select * from ReceptionistsTb where RecName Like '%{s}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            RecDGV.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        private void DisplayPat(string s)
        {
            con.Open();
            string Query = $"select * from PatientsTb where PatName Like '%{s}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            RecDGV.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        private void DisplayTest(string s)
        {
            con.Open();
            string Query = $"select * from TestsTb where TestName Like '%{s}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            RecDGV.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string N = name.Text;
                if (SearchTable.Text == "Doctors")
                {
                    DisplayDoc(N);
                }
                if (SearchTable.Text == "Tests")
                {
                    DisplayTest(N);
                }
                if (SearchTable.Text == "Patients")
                {
                    DisplayPat(N);
                }
                if (SearchTable.Text == "Receptionists")
                {
                    DisplayRec(N);
                }
              
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Patients pt = new Patients();
            this.Hide();
            pt.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Doctors2 dc = new Doctors2();
            this.Hide();
            dc.ShowDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Laboratory_Test laboratory = new Laboratory_Test();

            laboratory.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Receptionists rc = new Receptionists();
            this.Hide();
            rc.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            this.Hide();
            appointment.ShowDialog();

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();

        }

        private void SearchTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Prescriptions prescriptions = new Prescriptions();
            prescriptions.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Homes homes = new Homes();
            homes.Show();
            this.Hide();
        }
    }
}
