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
    public partial class AdminForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Project\\Gym management system\\Gym Management system\\Database1.mdf\";Integrated Security=True";
        public AdminForm()
        {
            InitializeComponent();
            LoadCustomers();
           
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            this.customerTableAdapter.Fill(this.database1DataSet3.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string fullname = txtFullname.Text;
            string Age = textBox6.Text;
            string Email = textBox5.Text;
            string Password = textBox1.Text;
            string PostCode = textBox3.Text;
            string Sex = textBox2.Text;
            string ContactNumber = textBox4.Text;
            

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(fullname))
            {
                string query = "INSERT INTO Customer (Username, Fullname, Age, Email, Password, PostCode, Sex, ContactNumber) " +
                               "VALUES (@Username, @Fullname, @Age, @Email, @Password, @PostCode, @Sex, @ContactNumber)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Fullname", fullname);
                    command.Parameters.AddWithValue("@Age", Age);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@PostCode", PostCode);
                    command.Parameters.AddWithValue("@Sex", Sex);
                    command.Parameters.AddWithValue("@ContactNumber", ContactNumber);


                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomers();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter username and fullname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCustomers()
        {
            string query = "SELECT * FROM Customer";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

        }

        private void Updatbtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string fullname = txtFullname.Text;
            string Age = textBox6.Text;
            string Email = textBox5.Text;
            string Password = textBox1.Text;
            string PostCode = textBox3.Text;
            string Sex = textBox2.Text;
            string ContactNumber = textBox4.Text;


            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(fullname))
            {
                string query = "UPDATE Customer " +
                           "SET Username = @Username, Fullname = @Fullname, Age = @Age, " +
                           "Email = @Email, Password = @Password, PostCode = @PostCode, " +
                           "Sex = @Sex, ContactNumber = @ContactNumber " +
                           "WHERE Username = @Username";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Fullname", fullname);
                    command.Parameters.AddWithValue("@Age", Age);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@PostCode", PostCode);
                    command.Parameters.AddWithValue("@Sex", Sex);
                    command.Parameters.AddWithValue("@ContactNumber", ContactNumber);


                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomers();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter username and fullname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usernameToDelete = txtUsername.Text.Trim();

            if (!string.IsNullOrEmpty(usernameToDelete))
            {
                if (MessageBox.Show($"Are you sure you want to delete the customer with username '{usernameToDelete}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "DELETE FROM Customer WHERE Username = @Username";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", usernameToDelete);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadCustomers(); 
                            }
                            else
                            {
                                MessageBox.Show($"No customer found with username '{usernameToDelete}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the username of the customer you want to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
