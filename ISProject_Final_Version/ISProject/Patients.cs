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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            DisplayPat();
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
        
        int key = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClinicDb.mdf;Integrated Security=True");
       private void DisplayPat()
        {
            con.Open();
            string Query = "select * from PatientsTb";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            PatDGV.DataSource = ds.Tables[0];
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

            pictureBox8.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox8.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
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

        }
        private void Clear()
        {
            PatName.Text = "";
            PatAdd.Text = "";
            PatGen.Text = "";
            PatAll.Text = "";
            PatNum.Text = "";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PatName.Text == "" || PatNum.Text == "" || PatAll.Text == "" || PatAdd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientsTb(PatName,PatPhone,PatAll,PatDOB,PatGen,PatAdd) values(@PM,@PN,@PA,@PD,@PG,@PAD) ", con);
                    cmd.Parameters.AddWithValue("@PM", PatName.Text);
                    cmd.Parameters.AddWithValue("@PN", PatNum.Text);
                    cmd.Parameters.AddWithValue("@PA", PatAll.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value);
                    cmd.Parameters.AddWithValue("@PG", PatGen.Text);
                    cmd.Parameters.AddWithValue("@PAD", PatAdd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Added");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayPat();
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PatName.Text == "" || PatNum.Text == "" || PatAll.Text == "" || PatAdd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("update PatientsTb set PatName=@PM,PatPhone=@PN,PatDOB=@PD,PatGen=@PG,PatAdd=@PAD,PatAll= @PA where PatId=@Pkey ", con);
                    cmd.Parameters.AddWithValue("@PM", PatName.Text);
                    cmd.Parameters.AddWithValue("@PN", PatNum.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value);
                    cmd.Parameters.AddWithValue("@PG", PatGen.Text);
                    cmd.Parameters.AddWithValue("@PAD", PatAdd.Text);
                    cmd.Parameters.AddWithValue("@PA", PatAll.Text);
                    cmd.Parameters.AddWithValue("@Pkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Edited");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayPat();
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
            if (key == 0)
            {
                MessageBox.Show("Choose A Patient");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from  PatientsTb where PatId=@Pkey ", con);
                    cmd.Parameters.AddWithValue("@PKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayPat();
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

        private void PatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PatName.Text = PatDGV.SelectedRows[0].Cells[1].Value.ToString();
                PatGen.Text = PatDGV.SelectedRows[0].Cells[2].Value.ToString();
                PatAdd.Text = PatDGV.SelectedRows[0].Cells[3].Value.ToString();
                PatDOB.Text = PatDGV.SelectedRows[0].Cells[4].Value.ToString();
                PatAll.Text = PatDGV.SelectedRows[0].Cells[5].Value.ToString();
                PatNum.Text = PatDGV.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch ( Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            
            if (PatName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DisplaySpecificPat(string s, string p)
        {
            con.Open();
            string Query = $"select * from PatientsTb where PatName Like '{s}%' and PatPhone Like '{p}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            PatDGV.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        private void PatName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string N = PatName.Text;
                string P =PatNum.Text;
                DisplaySpecificPat(N,P);
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

        private void PatNum_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string N = PatName.Text;
                string P = PatNum.Text;
                DisplaySpecificPat(N, P);
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

        private void label13_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Hide();
            search.ShowDialog();

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

        private void label11_Click(object sender, EventArgs e)
        {
            Homes homes = new Homes();
            homes.Show();
            this.Hide();

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
