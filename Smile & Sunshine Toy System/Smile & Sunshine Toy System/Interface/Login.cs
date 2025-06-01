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
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var loginController = new LoginController();
            if (loginController.ValidateCredentials(username, password)) // Call the method
            {
                this.Hide(); // Hide the login form
                Main mainForm = new Main(); // Create an instance of the main form
                mainForm.Show(); // Show the main form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.Instance.CloseConnection(); // Close connection on form closing
        }
    }
}