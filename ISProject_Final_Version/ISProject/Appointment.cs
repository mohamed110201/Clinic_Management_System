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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Guna.UI2.WinForms.Suite;

namespace ISProject
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
            DisplayAPP();
            day.Format = DateTimePickerFormat.Custom;
            day.CustomFormat = "dd , MMM , yyyy  ";
            time.Format = DateTimePickerFormat.Time;
            time.ShowUpDown = true;
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

        private void DisplayAPP()
        {
            con.Open();
            string Query = "select * from AppointmentTb";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            AppDGV.DataSource = ds.Tables[0];
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
            PatId.Text = "";
            DocId.Text = "";
            RecId.Text = "";
            SearchTable.SelectedIndex = -1;
          

        }

        private void DisplayDoc(string s)
        {
            con.Open();
            string Query = $"select * from DoctorsTb where DocName Like '%{s}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            AppDGV.DataSource = ds.Tables[0];
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
            AppDGV.DataSource = ds.Tables[0];
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
            AppDGV.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                bool Busy = false;
                con.Open();
                // counting the number of doctors with the id selected
                SqlCommand check_Doc_Id = new SqlCommand("SELECT COUNT(*) FROM [DoctorsTb] WHERE ([DocId] = @DI)", con);
                check_Doc_Id.Parameters.AddWithValue("@DI", DocId.Text);
                int DocExist = (int)check_Doc_Id.ExecuteScalar();

                // counting the number of patients with the id selected
                SqlCommand check_Pat_Id = new SqlCommand("SELECT COUNT(*) FROM [PatientsTb] WHERE ([PatId] = @PI)", con);
                check_Pat_Id.Parameters.AddWithValue("@PI", PatId.Text);
                int PatExist = (int)check_Pat_Id.ExecuteScalar();

                // counting the number of receptionists with the id selected
                SqlCommand check_Rec_Id = new SqlCommand("SELECT COUNT(*) FROM [ReceptionistsTb] WHERE ([RecId] = @RI)", con);
                check_Rec_Id.Parameters.AddWithValue("@RI", RecId.Text);
                int RecExist = (int)check_Rec_Id.ExecuteScalar();

                DateTime AppDate = (day.Value.Date + time.Value.TimeOfDay);

                // checking if the Appointment is already exists
                SqlCommand check_APP = new SqlCommand("SELECT COUNT(*) FROM [AppointmentTb] WHERE ([Appointment] = @AP and [Doctor Id] = @DI)", con);
                check_APP.Parameters.AddWithValue("@AP", AppDate);
                check_APP.Parameters.AddWithValue("@DI", DocId.Text);


                int RepeatedApp = (int)check_APP.ExecuteScalar();
                // getting the last appointment
                SqlCommand Check_LastApp = new SqlCommand("SELECT COUNT(*) FROM [AppointmentTb] WHERE [Doctor Id]=@DI and Abs(DATEDIFF(minute,Appointment,@AP)) < 60 ", con);
                Check_LastApp.Parameters.AddWithValue("@AP", AppDate);
                Check_LastApp.Parameters.AddWithValue("@DI", DocId.Text);
                /* if there is a previous Appintments
                 ckeck if the difference less than 1 hours >> change the boolean value to true ( يعني كدا الدكتور مشغول) 
                 */
                if ((int)(Check_LastApp.ExecuteScalar()) != 0)
                {

                    Busy = true;

                }

                // ckeck if the ids is correct  
                if (DocExist == 0)
                    MessageBox.Show("Doctor does not exist");
                else if (PatExist == 0)
                    MessageBox.Show("Patient does not exist");
                else if (RecExist == 0)
                    MessageBox.Show("Receptionist does not exist");
                else if (DocExist != 0 && PatExist != 0 && RecExist != 0 && RepeatedApp != 0)
                    MessageBox.Show("Appointment Reserved");

                // هنا بقي بشوف لو ال busy  طلعت true 
                else if (Busy)
                    MessageBox.Show("Doctor Is Busy");

                // هنا لو بينطبق عليه كله الي فات دا يبقي تمام هيسجل الحجز
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into AppointmentTb([Doctor Id],[Patient Id],[Receptionist Id],[Appointment]) values(@DI,@PI,@RI,@AP) ", con);
                    cmd.Parameters.AddWithValue("@DI", DocId.Text);
                    cmd.Parameters.AddWithValue("@PI", PatId.Text);
                    cmd.Parameters.AddWithValue("@RI", RecId.Text);
                    cmd.Parameters.AddWithValue("@AP", AppDate);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Added");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayAPP();
                    Clear();
                }


            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }

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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime AppDate = day.Value.Date + time.Value.TimeOfDay;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("update AppointmentTb set [Doctor Id]=@DI,[Patient Id]=@PI,[Receptionist Id]=@RI,[Appointment]=@AP where AppId=@Akey ", con);
                cmd.Parameters.AddWithValue("@DI", DocId.Text);
                cmd.Parameters.AddWithValue("@PI", PatId.Text);
                cmd.Parameters.AddWithValue("@RI", RecId.Text);
                cmd.Parameters.AddWithValue("@AP", AppDate);
                cmd.Parameters.AddWithValue("@AKey", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Edited");
                if (con.State == ConnectionState.Open)
                    con.Close();
                DisplayAPP();
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

        private void AppDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                key = Convert.ToInt32(AppDGV.SelectedRows[0].Cells[0].Value.ToString());
                DocId.Text = AppDGV.SelectedRows[0].Cells[1].Value.ToString();
                PatId.Text = AppDGV.SelectedRows[0].Cells[2].Value.ToString();
                RecId.Text = AppDGV.SelectedRows[0].Cells[3].Value.ToString();
                day.Value  =  (DateTime)(AppDGV.SelectedRows[0].Cells[4].Value);
                time.Value = (DateTime)(AppDGV.SelectedRows[0].Cells[4].Value);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

           
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Delete from  AppointmentTb where AppId=@Akey ", con);
                cmd.Parameters.AddWithValue("@AKey", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Deleted");
                if (con.State == ConnectionState.Open)
                    con.Close();
                DisplayAPP();
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

        private void PatId_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void label13_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Hide();
            search.ShowDialog();

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

        private void label11_Click_1(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Homes homes = new Homes();
            homes.Show();
            this.Hide();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Prescriptions prescriptions= new Prescriptions();
            prescriptions.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Homes homes = new Homes();
            homes.Show();
            this.Hide();
        }

        private void SearchTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
