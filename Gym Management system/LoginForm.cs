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
    public partial class LoginForm : Form
    {

        SqlDataReader dr;
        SqlConnection cn;
        SqlCommand cmd;
        Class1 name;
        public LoginForm()
        {

            InitializeComponent();
        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            name = new Class1();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\Gym management system\Gym Management system\Database1.mdf"";Integrated Security=True");
            cn.Open();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            string entered_username = textBox2.Text;
            Class1.user = entered_username;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                cmd = new SqlCommand("SELECT * FROM Customer WHERE Username = @Username AND Password = @Password", cn);
                cmd.Parameters.AddWithValue("@Username", textBox2.Text);
                cmd.Parameters.AddWithValue("@Password", textBox1.Text);

                try
                {
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string username = dr["Username"].ToString(); 

                        if (username == "mm")
                        {
                            dr.Close();
                            this.Hide();
                            AdminForm adminForm = new AdminForm();
                            adminForm.ShowDialog();
                        }
                        else
                        {
                            dr.Close();
                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.ShowDialog();
                        }
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No account available with this username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error logging in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
