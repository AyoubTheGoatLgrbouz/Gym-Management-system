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
    public partial class UpdateContactInfoForm : Form
    {
        SqlConnection cn;
        SqlCommand cmd; 
        public UpdateContactInfoForm()
        {
            InitializeComponent();
        }
       private void UpdateContactInfoForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\Gym Management system\Gym Management system\Database1.mdf"";Integrated Security=True");
            cn.Open();
  
        
       }
       
       
        private void btnSaveContactInfo_Click_1(object sender, EventArgs e)
        {
            // Validate user input
            if (txtNewEmail.Text == "" || txtNewPostCode.Text == "")
            {
                MessageBox.Show("Please enter a valid email and post code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string updateQuery = "UPDATE Customer SET Email = @Email, PostCode = @PostCode , ContactNumber = @ContactNumber WHERE Username = @Username";
                cmd = new SqlCommand(updateQuery, cn);
                cmd.Parameters.AddWithValue("@Email", txtNewEmail.Text);
                cmd.Parameters.AddWithValue("@PostCode", txtNewPostCode.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", txtNewNumber.Text);
                cmd.Parameters.AddWithValue("@Username", Class1.user); // Assuming Class1.user contains the current username
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Contact information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update contact information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                cn.Close();

            }
        }
    }




}
