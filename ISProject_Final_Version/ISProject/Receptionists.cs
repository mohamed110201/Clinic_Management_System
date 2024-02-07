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
using System.Drawing.Text;
using Guna.UI2.HtmlRenderer.Adapters;
using System.Xml.Linq;

namespace ISProject
{
    public partial class Receptionists : Form
    {
        public Receptionists()
        {
            InitializeComponent();

            DisplayRec();
        }
        private void Clear()
        {
            RName.Text = "";
            RPhone.Text = "";
            RPass.Text = "";
            RDOB.Text = "";
            RGen.Text = "";
            RAdd.Text = "";
        }
        private void DisplayRec()
        {
            con.Open();
            string Query = "select * from ReceptionistsTb";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            RecDGV.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Open)
                con.Close();
            // Changing The Color Of Icons On Hover //

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
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox5.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
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
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label4.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
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
            pictureBox11.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox11.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            label16.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel4.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label16.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel4.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            pictureBox8.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel4.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox8.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel4.BackColor = ColorTranslator.FromHtml("#121d32");
            };
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClinicDb.mdf;Integrated Security=True");

        int key = 0;
     

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (RName.Text == "" || RPass.Text == "" || RPhone.Text == "" || RAdd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ReceptionistsTb(RecName,RecPhone,RecPass,RecDBO,RecGen,RecAdd) values(@RM,@RP,@RPA,@RD,@RG,@RA) ", con);
                    cmd.Parameters.AddWithValue("@RM", RName.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhone.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPass.Text);
                    cmd.Parameters.AddWithValue("@RD", RDOB.Value);
                    cmd.Parameters.AddWithValue("@RG", RGen.Text);
                    cmd.Parameters.AddWithValue("@RA", RAdd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reseptionist Added");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayRec();
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

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (RName.Text == "" || RPass.Text == "" || RPhone.Text == "" || RAdd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update ReceptionistsTb set RecName =@RM ,RecPhone=@RP,RecPass=@RPA,RecDBO=@RD,RecGen=@RG,RecAdd=@RA  where RecId=@Rkey", con);
                    cmd.Parameters.AddWithValue("@RM", RName.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhone.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPass.Text);
                    cmd.Parameters.AddWithValue("@RD", RDOB.Value);
                    cmd.Parameters.AddWithValue("@RG", RGen.Text);
                    cmd.Parameters.AddWithValue("@RA", RAdd.Text);
                    cmd.Parameters.AddWithValue("@RKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayRec();
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
                MessageBox.Show("Select The Receptionist");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ReceptionistsTb where RecId=@Rkey", con);
                    cmd.Parameters.AddWithValue("@RKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Deleted");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayRec();
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

        private void RecDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            RName.Text = RecDGV.SelectedRows[0].Cells[1].Value.ToString();
            RPhone.Text = RecDGV.SelectedRows[0].Cells[2].Value.ToString();
            RPass.Text = RecDGV.SelectedRows[0].Cells[3].Value.ToString();
            RDOB.Text = RecDGV.SelectedRows[0].Cells[4].Value.ToString();
            RGen.Text = RecDGV.SelectedRows[0].Cells[5].Value.ToString();
            RAdd.Text = RecDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (RName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(RecDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplaySpecificRec(string s, string p)
        {
            con.Open();
            string Query = $"select * from ReceptionistsTb where RecName Like '{s}%' and RecPhone Like '{p}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            RecDGV.DataSource = ds.Tables[0];
            con.Close();
        }



        private void RName_TextChanged(object sender, EventArgs e)
        {
        try
        {
            string N = RName.Text;
                string P = RPhone.Text;
            DisplaySpecificRec(N,P);
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

        private void RPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string N = RName.Text;
                string P = RPhone.Text;
                DisplaySpecificRec(N, P);
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
   

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Homes lg = new Homes();
            this.Hide();
            lg.ShowDialog();
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

