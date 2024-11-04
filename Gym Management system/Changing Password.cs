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
    public partial class ChangePasswordForm : Form
    {
        SqlDataReader dr;
        SqlConnection cn;
        SqlCommand cmd;
        public ChangePasswordForm()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\Gym Management system\Gym Management system\Database1.mdf"";Integrated Security=True");
        }

    
        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePassword_Click_1(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
           
            string newPassword = txtNewPassword.Text;
            
            string confirmPassword = txtConfirmPassword.Text;
            
            if (newPassword == confirmPassword)
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customer SET Password = @NewPassword WHERE Username = @Username AND Password = @CurrentPassword", cn);
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    cmd.Parameters.AddWithValue("@Username", Class1.user);
                    cmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid current password! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                MessageBox.Show("New password and confirm password do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
