using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace ISProject
{
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();

            if (Login.role == "Admin")
            {
                label4.Enabled = true; label2.Enabled = true;
            }
            if (Login.role == "Doctor")
            {
                label11.Enabled = false; label4.Enabled = false;
            }
            DisplayPresc();
            GetDocId();
            GetPatientId();
            GetTestId();

            if (Login.role == "Receptionist")
            {
                label4.Enabled = false; label11.Enabled = false;
            }
            if (Login.role == "Admin")
            {
                label4.Enabled = true; label11.Enabled = true;
            }
        }
        int key = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClinicDb.mdf;Integrated Security=True");

        private void DisplayPresc()
        {
            con.Open();
            string Query = "select * from PrescriptionsTb";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            PresDGV.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Open)
                con.Close();
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
                DocPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label11.MouseLeave += (a_sender, a_args) =>
            {
                DocPanel.BackColor = ColorTranslator.FromHtml("#121d32");
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
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label2.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#121d32");
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
            label16.MouseHover += (a_sender, a_args) =>
            {
                PatPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label16.MouseLeave += (a_sender, a_args) =>
            {
                PatPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            label18.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label18.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            pictureBox8.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox8.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
            };
        }
        private void Clear()
        {
            Docidcb.SelectedIndex = 0;
            Ptidcb.SelectedIndex = 0;
            Testidcb.SelectedIndex = 0;
            DName.Text= "";
            PName.Text = "";
            Test.Text = "";
            Cost.Text = "";
            Med.Text = "";


        }
        private void GetDocId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select DocId from DoctorsTb", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocId",typeof(int));
            dt.Load(rdr);
            Docidcb.ValueMember= "DocId";
            Docidcb.DataSource= dt;
            con.Close();
        }
        private void GetPatientId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PatId from PatientsTb", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatId", typeof(int));
            dt.Load(rdr);
            Ptidcb.ValueMember = "PatId";
            Ptidcb.DataSource = dt;
            con.Close();
        }
        private void GetTestId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select TestNum from TestsTb", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestNum", typeof(int));
            dt.Load(rdr);
            Testidcb.ValueMember = "TestNum";
            Testidcb.DataSource = dt;
            con.Close();
        }
        private void GetDocName()
        {
            con.Open();
            String Query = "Select * from DoctorsTb where DocId=" + Docidcb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                DName.Text = dr["DocName"].ToString();
            }
            con.Close();
        }
        private void GetPatName()
        {
            con.Open();
            String Query = "Select * from PatientsTb where PatId=" + Ptidcb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PName.Text = dr["PatName"].ToString();
            }
            con.Close();
        }
        private void GetTestName()
        {
            con.Open();
            String Query = "Select * from TestsTb where TestNum=" + Testidcb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Test.Text = dr["TestName"].ToString();
                Cost.Text = dr["TestCost"].ToString();
            }
            con.Close();
        }
        private void label16_Click(object sender, EventArgs e)
        {
            Homes homes = new Homes();
            homes.Show();
            this.Hide();
        }

        private void Prescriptions_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label16_Click_1(object sender, EventArgs e)
        {
            Patients pt = new Patients();
            this.Hide();
            pt.ShowDialog();

        }

        private void label11_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Hide();
            search.ShowDialog();

        }

        private void label17_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            this.Hide();
            appointment.ShowDialog();

        }

        private void Docidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void Ptidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void Testidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTestName();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DName.Text == "" || PName.Text=="" || Test.Text=="" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionsTb(DocId,DocName,PatId,PatName,LabTestName,LabTestId,Medicines,Cost) values(@DI,@DN,@PI,@PN,@TN,@TI,@MED,@COST) ", con);
                    cmd.Parameters.AddWithValue("@DI", Docidcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DName.Text);
                    cmd.Parameters.AddWithValue("@PI", Ptidcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PName.Text);
                    cmd.Parameters.AddWithValue("@TN", Test.Text);
                    cmd.Parameters.AddWithValue("@TI", Testidcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MED", Med.Text);
                    cmd.Parameters.AddWithValue("@COST", Cost.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescriptions Added");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayPresc();
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

        private void presctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PresDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Presctxt.Text = "";
            Presctxt.Text = "                       Elite Clinic\n\n"+"                                                                                                    PRESCRIPTIONS                  "+"\n*************************************************"+"\n"+DateTime.Today.Date+"\n\n\n\n                                                                                         Doctor: "+PresDGV.SelectedRows[0].Cells[2].Value.ToString()+ "\n\n\n\n           Patient: "+PresDGV.SelectedRows[0].Cells[4].Value.ToString() + "\n\n\n\n                                                                           Test: " + PresDGV.SelectedRows[0].Cells[5].Value.ToString() + "\n\n\n\n           Medicine: " + PresDGV.SelectedRows[0].Cells[7].Value.ToString() +"\n\n\n\n                                                                                          Elite Clinic" ;
            
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            { 
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Presctxt.Text + "\n",new Font("Microsoft Sans Serif", 14,FontStyle.Bold), Brushes.Black,new Point(95,80));
           
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Homes homes = new Homes();
            homes.Show();
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


