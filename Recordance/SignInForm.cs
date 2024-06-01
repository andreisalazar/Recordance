using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recordance
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        SignUpForm signupform = new SignUpForm();
        NavigationForm navigationform = new NavigationForm();

        public static string usernameDB = "usernameDB.txt";
        public static string passwordDB = "passwordDB.txt";
        public static string fullnameDB = "fullnameDB.txt";

        private void signinButton_Click(object sender, EventArgs e)
        {
            string[] usernameList = File.ReadAllLines(usernameDB);
            string[] passwordList = File.ReadAllLines(passwordDB);


            int usernameIndex = Array.IndexOf(usernameList, usernameTextBox.Text);

            if (!usernameList.Contains(usernameTextBox.Text)
                || usernameIndex == -1)
            {
                // If the prompted username is not found on the username text file
                MessageBox.Show("Account not found.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
                passwordTextBox.Text = "";
            }
            else if (passwordList[usernameIndex] == passwordTextBox.Text)
            {
                // If the index of the password list is similar to the index of the text found, then the password
                // and username matches
                proceedToNavigationForm();
            }
            else if ((passwordList[usernameIndex] != passwordTextBox.Text) || (passwordTextBox.Text == "")
)
            {
                MessageBox.Show("An error occured. The password might be incorrect password or empty." + passwordList[usernameIndex].ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
                passwordTextBox.SelectAll();
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
           
            proceedToSignUpForm();
        }

        void proceedToSignUpForm()
        {
            this.Hide();
            signupform.Show();
        }

        void proceedToNavigationForm()
        {
            this.Hide();
            navigationform.Show();
        }
    }
}
