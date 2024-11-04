using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Gym_Management_system
{
    
    public partial class BookingForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Project\\Gym management system\\Gym Management system\\Database1.mdf\";Integrated Security=True";


        public BookingForm()
        {
            InitializeComponent();
            LoadClasses();
            
        }
       
        private void BookingForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadClasses()
        {
            string query = "SELECT c.ClassID, c.ClassName, c.ClassDate, c.StartTime, c.Duration, c.Capacity, i.InstructorName " +
                           "FROM Classes c " +
                           "INNER JOIN Instructors i ON c.InstructorID = i.InstructorID " +
                           "WHERE c.ClassDate >= @CurrentDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CurrentDate", DateTime.Today);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string className = reader["ClassName"].ToString();
                        DateTime classDate = Convert.ToDateTime(reader["ClassDate"]);
                        TimeSpan startTime = TimeSpan.Parse(reader["StartTime"].ToString());
                        int duration = Convert.ToInt32(reader["Duration"]);
                        int capacity = Convert.ToInt32(reader["Capacity"]);
                        string instructorName = reader["InstructorName"].ToString();

                        string classInfo = $"{className} - {classDate.ToShortDateString()} {startTime}" +
                                           $" | Duration: {duration} min | Capacity: {capacity} | Instructor: {instructorName}";

                        listBoxClasses.Items.Add(classInfo);
                        listBoxClasses.Items.Add(""); 
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading classes: " + ex.Message);
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (listBoxClasses.SelectedItem != null)
            {
                string selectedClass = listBoxClasses.SelectedItem.ToString();
                int classID = GetClassID(selectedClass);

                if (classID != -1)
                {
                   
                    string username = "Class1.user";

                    InsertBooking(classID, username);
                }
                else
                {
                    MessageBox.Show("Invalid class selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a class to book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void InsertBooking(int classID, string username)
        {
            int customerID = GetCustomerID(username);

            if (customerID != -1)
            {
                string query = "INSERT INTO Booking (ClassID, CustomerID, BookingDate) VALUES (@ClassID, @CustomerID, @BookingDate)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassID", classID);
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@BookingDate", DateTime.Today);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booking successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Booking failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error booking class: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Customer information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetCustomerID(string username)
        {
            int customerID = 0;

            string query = "SELECT CustomerID FROM Customer WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        customerID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving CustomerID: " + ex.Message);
                }
            }

            return customerID;
        }

        private int GetClassID(string selectedClass)
        {
           
            int classID = -1;

            
            int spaceIndex = selectedClass.IndexOf('5');

            if (spaceIndex != -1)
            {
                string classIDString = selectedClass.Substring(0, spaceIndex).Trim();
                if (int.TryParse(classIDString, out classID))
                {
                    return classID;
                }
            }

            return classID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm home = new MainForm();
            home.ShowDialog();
        }
    }








}
