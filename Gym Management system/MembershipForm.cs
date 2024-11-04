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

namespace Gym_Management_system
{
    public partial class MembershipForm : Form
    {
        SqlDataReader dr;
        SqlConnection cn;
        SqlCommand cmd;
        
        public MembershipForm()
        {
            InitializeComponent();

            PopulateMembershipTypes();

            
            PopulateMembershipTypes();

          
            listViewMembershipInfo.View = View.Details;
            listViewMembershipInfo.Columns.Add("Membership Type", 150);
            listViewMembershipInfo.Columns.Add("Price", 100);
            listViewMembershipInfo.Columns.Add("Benefits", 250);


        }
        
        private void PopulateMembershipTypes()
        {

            cmbMembershipType.Items.Clear();
            

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Project\\Gym management system\\Gym Management system\\Database1.mdf\";Integrated Security=True";

           
            string query = "SELECT MembershipTypeName FROM MembershipTypes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    // Execute the query and read the results
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {                       string membershipTypeName = reader["MembershipTypeName"].ToString();
                        cmbMembershipType.Items.Add(membershipTypeName);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while retrieving membership types: " + ex.Message);
                }
            }
        }

        private void cmbMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            listViewMembershipInfo.Items.Clear();

            
            string selectedMembershipType = cmbMembershipType.SelectedItem.ToString();

            
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Project\\Gym Management system\\Gym Management system\\Database1.mdf\";Integrated Security=True";

           
            string query = "SELECT Price, Benefits FROM MembershipTypes WHERE MembershipTypeName = @MembershipTypeName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MembershipTypeName", selectedMembershipType);

                try
                {
                    connection.Open();

                   
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string price = reader["Price"].ToString();
                        string benefits = reader["Benefits"].ToString();

                       
                        ListViewItem item = new ListViewItem(selectedMembershipType);
                        item.SubItems.Add(price);
                        item.SubItems.Add(benefits);
                        listViewMembershipInfo.Items.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while retrieving membership type information: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMembershipType.SelectedItem != null && dateTimePicker1.Value != DateTime.Now)
            {
                cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\Gym management system\Gym Management system\Database1.mdf;Integrated Security=True");
                cn.Open();
                cmd = new SqlCommand("INSERT INTO Membership (Username, MembershipType, StartDate, IsActive) VALUES (@Username, @MembershipType, @StartDate,@IsActive)", cn);
                cmd.Parameters.AddWithValue("@Username", txtUsernameID.Text);
                cmd.Parameters.AddWithValue("@MembershipType", cmbMembershipType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@IsActive", 1);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Membership created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


            }
            else
            {
                MessageBox.Show("Please select a membership type and choose a start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MembershipForm_Load(object sender, EventArgs e)
        {

        }

      
        private void txtUsernameID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewMembershipInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm home = new MainForm();
            home.ShowDialog();
        }
    }
}