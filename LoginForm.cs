using Store.DataQ;
using Store.Forms;
using Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            passwordtext.UseSystemPasswordChar = true;

            DatabaseQ db = new DatabaseQ();
            bool isConnected = db.TestConnection();
            if (!isConnected)
            {
       
                loginbutton.Enabled = false;
                MessageBox.Show("Cannot connect to the database. Please check your connection settings.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgotbutton_Click(object sender, EventArgs e)
        {
            ResetPassword resetPasswordForm = new ResetPassword();
            resetPasswordForm.Show();
        }

        private void Registerationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();
        }


        private void loginbutton_Click(object sender, EventArgs e)
        {


            string username = usernametext.Text.Trim();
            string password = passwordtext.Text;

          
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                DatabaseQ db = new DatabaseQ();

              
                User existingUser = db.GetUserByUsername(username);

                if (existingUser == null)
                {
                 
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password == existingUser.Password)
                {
                  
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                    RedirectUser(existingUser.Role, existingUser.UserID);


                    
                    this.Hide();
                }
                else
                {
                    
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void RedirectUser(string role, int userId)
        {
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("User role is not defined. Please contact support.", "Role Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (role.Trim().ToLower())
            {
                case "admin":
                     
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    break;

                
                case "user":
                   
                    DatabaseQ dbUser = new DatabaseQ();
                    User user = dbUser.GetUserByID(userId);

                    if (user != null)
                    {
                      
                        ChoiceSection jewellery = new ChoiceSection(user.UserID);
                        jewellery.Show();
                    }
                    else
                    {
                        MessageBox.Show("User profile not found. Please contact support.", "Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Unknown user role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
