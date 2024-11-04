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
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection.Emit;

namespace Gym_Management_system
{
    public partial class RegistrationForm : Form
    {
        SqlDataReader dr;
        SqlConnection cn;
        SqlCommand cmd;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\Gym Management system\Gym Management system\Database1.mdf"";Integrated Security=True");
            cn.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text != string.Empty || textSurname.Text != string.Empty || txtAge.Text != string.Empty || txtEmail.Text != string.Empty || txtPassword.Text != string.Empty || txtConfirmPass.Text != string.Empty || textSex.Text != string.Empty || txtContactNumber.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPass.Text)
                {
                    cmd = new SqlCommand("select * from Customer where Username ='" + txtFirstname.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already Exists Please Try Another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {


                        dr.Close();
                        cmd = new SqlCommand("insert into Customer (Username, Fullname, Age, Email, Password, PostCode, Sex, ContactNumber) values (@Username, @Fullname, @Age, @Email, @Password, @PostCode, @Sex, @ContactNumber)", cn);
                        cmd.Parameters.AddWithValue("Username", txtFirstname.Text);
                        cmd.Parameters.AddWithValue("Fullname", textSurname.Text);
                        cmd.Parameters.AddWithValue("Age", txtAge.Text);
                        cmd.Parameters.AddWithValue("Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("PostCode", txtPostCode.Text);
                        cmd.Parameters.AddWithValue("Sex", textSex.Text);
                        cmd.Parameters.AddWithValue("ContactNumber", txtContactNumber.Text); 
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created. Please login now.", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Please enter same the password  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
