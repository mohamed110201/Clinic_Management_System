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
    public partial class Doctors2 : Form
    {
        public Doctors2()
        {
            InitializeComponent();
             
            DisplayDoc();
        }
        int key=0;
        private void DisplayDoc()
        {
            con.Open();
            string Query = "select * from DoctorsTb";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            DocDGV.DataSource = ds.Tables[0];
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
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            pictureBox4.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
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

            label14.MouseHover += (a_sender, a_args) =>
            {
                PatPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label14.MouseLeave += (a_sender, a_args) =>
            {
                PatPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            label11.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            label3.MouseHover += (a_sender, a_args) =>
            {
                LabPanel.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label3.MouseLeave += (a_sender, a_args) =>
            {
                LabPanel.BackColor = ColorTranslator.FromHtml("#121d32");
            };

            label11.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label2.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel3.BackColor = ColorTranslator.FromHtml("#121d32");
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

            label2.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label2.MouseLeave += (a_sender, a_args) =>
            {
                guna2Panel1.BackColor = ColorTranslator.FromHtml("#121d32");
            };
            label17.MouseHover += (a_sender, a_args) =>
            {
                guna2Panel4.BackColor = ColorTranslator.FromHtml("#1662f3");
            };
            label17.MouseLeave += (a_sender, a_args) =>
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
        private void Clear()
        {
            DName.Text = "";
            DAdd.Text = "";
            DGen.SelectedIndex = -1;
            DocS.SelectedIndex = -1;
            DExp.Text = "";
            DNum.Text = "";
            DPass.Text = "";
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ClinicDb.mdf;Integrated Security=True");


        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (DName.Text == "" || DNum.Text == "" || DExp.Text == "" || DAdd.Text == "" || DPass.Text == "" || DocS.SelectedIndex == -1 || DGen.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorsTb(DocName,DocPhone,DocSpec,DocDOB,DocGen,DocAdd,DocExp,DocPass) values(@DM,@DP,@DS,@DD,@DG,@DA,@DEX,@DPA) ", con);
                    cmd.Parameters.AddWithValue("@DM", DName.Text);
                    cmd.Parameters.AddWithValue("@DP", DNum.Text);
                    cmd.Parameters.AddWithValue("@DS", DocS.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value);
                    cmd.Parameters.AddWithValue("@DG", DGen.Text);
                    cmd.Parameters.AddWithValue("@DA", DAdd.Text);
                    cmd.Parameters.AddWithValue("@DEX", DExp.Text);
                    cmd.Parameters.AddWithValue("@DPA", DPass.Text);



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Added");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayDoc();
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
            if (DName.Text == "" || DNum.Text == "" || DExp.Text == "" || DAdd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("update DoctorsTb set DocName=@DM,DocPhone=@DP,DocSpec=@DS,DocDOB=@DD,DocGen=@DG,DocAdd=@DA,DocExp= @DEX , DocPass=@DPA where DocId=@Dkey ", con);
                    cmd.Parameters.AddWithValue("@DM", DName.Text);
                    cmd.Parameters.AddWithValue("@DP", DNum.Text);
                    cmd.Parameters.AddWithValue("@DS", DocS.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value);
                    cmd.Parameters.AddWithValue("@DG", DGen.Text);
                    cmd.Parameters.AddWithValue("@DA", DAdd.Text);
                    cmd.Parameters.AddWithValue("@DEX", DExp.Text);
                    cmd.Parameters.AddWithValue("@DKey", key);
                    cmd.Parameters.AddWithValue("@DPA", DPass.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Edited");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayDoc();
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

        private void DocDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DName.Text = DocDGV.SelectedRows[0].Cells[1].Value.ToString();
                DNum.Text = DocDGV.SelectedRows[0].Cells[2].Value.ToString();
                DocS.SelectedItem = DocDGV.SelectedRows[0].Cells[3].Value.ToString();
                DocDOB.Text = DocDGV.SelectedRows[0].Cells[4].Value.ToString();
                DGen.SelectedItem = DocDGV.SelectedRows[0].Cells[5].Value.ToString();
                DAdd.Text = DocDGV.SelectedRows[0].Cells[6].Value.ToString();
                DExp.Text = DocDGV.SelectedRows[0].Cells[7].Value.ToString();
                DPass.Text = DocDGV.SelectedRows[0].Cells[8].Value.ToString();


            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

            if (DName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DocDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Choose A Doctor");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from  DoctorsTb where DocId=@Dkey ", con);
                    cmd.Parameters.AddWithValue("@DKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    DisplayDoc();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Homes homes = new Homes();
            homes.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Patients pt = new Patients();
            this.Hide();
            pt.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Homes homes = new Homes();
            homes.Show();
            this.Hide();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            this.Hide();
            appointment.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Prescriptions prescriptions = new Prescriptions();
            prescriptions.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
