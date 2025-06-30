using System;
using System.Windows.Forms;
using Smile___Sunshine_Toy_System.Controller;
using Smile___Sunshine_Toy_System.Interface;

namespace Smile___Sunshine_Toy_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsername.Text;
                var password = txtPassword.Text;

                var loginController = new LoginController();
                if (loginController.ValidateCredentials(username, password)) // Call the method
                {
                    this.Hide(); // Hide the login form
                    loginController.GetUser(txtUsername.Text);
                    Home mainForm = new Home(txtUsername.Text.ToString()); // Create an instance of the main form
                    mainForm.Show(); // Show the main form
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.Instance.CloseConnection(); // Close connection on form closing
        }
    }
}