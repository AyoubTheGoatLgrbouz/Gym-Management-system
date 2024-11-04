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
using static Gym_Management_system.MembershipForm;

namespace Gym_Management_system
{
    public partial class AccountForm : Form
    {
        SqlDataReader dr;
        SqlConnection cn;
        SqlCommand cmd;
           private MembershipForm membershipForm;
        
        public AccountForm()
        {
            InitializeComponent();
            label8.Text = Class1.user;
            LoadUserProfile();
            DisplayMembershipStatus();

        }
        private void DisplayMembershipStatus()
        {
            
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Project\\Gym management system\\Gym Management system\\Database1.mdf;Integrated Security=True";

            
            string query = "SELECT m.MembershipType " +
                    "FROM Membership m " +
                    "INNER JOIN Customer c ON m.Username = c.Username " +
                    "WHERE c.Username = @Username AND m.IsActive = 1";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", label8.Text);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string membershipType = reader["MembershipType"].ToString();
                        richTextBox2.Text = $"Membership Status: Active\nMembership Type: {membershipType}";
                    }
                    else
                    {
                        richTextBox2.Text = "No active membership found.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while retrieving membership status: " + ex.Message);
                }
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            

        }
        private void LoadUserProfile()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\Gym management system\Gym Management system\Database1.mdf;Integrated Security=True");
                cn.Open();
                cmd = new SqlCommand("select * from Customer where Username = @username", cn);
                cmd.Parameters.AddWithValue("@username", label8.Text);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    label9.Text = dr["Fullname"].ToString();
                    label10.Text = dr["Email"].ToString();
                    label12.Text = dr["PostCode"].ToString();
                    label13.Text = dr["Age"].ToString();
                    label14.Text = dr["Sex"].ToString();
                    label11.Text = dr["ContactNumber"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user profile: " + ex.Message);
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                
                cn.Open();
                cmd = new SqlCommand("UPDATE Customer SET Surname = @Fullname, Email = @email, PostCode = @postcode WHERE Username = @username", cn);
                cmd.Parameters.AddWithValue("@username", label8.Text);
                cmd.Parameters.AddWithValue("@Fullname", label9.Text);
                cmd.Parameters.AddWithValue("@email", label10.Text);
                cmd.Parameters.AddWithValue("@postcode", label12.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnUpdateContactInfo_Click(object sender, EventArgs e)
        {
            
            UpdateContactInfoForm updateContactInfoForm = new UpdateContactInfoForm();
            updateContactInfoForm.ShowDialog();

            
            LoadUserProfile();
        }









        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm home = new MainForm();
            home.ShowDialog();
        }

        private void btnUpdateContactInfo_Click_1(object sender, EventArgs e)
        {
            
            UpdateContactInfoForm updateContactInfoForm = new UpdateContactInfoForm();
            updateContactInfoForm.ShowDialog();

           
            LoadUserProfile();
        }
    }
}
