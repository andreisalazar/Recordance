﻿using System;
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
    public partial class SignUpForm : Form
    {


        public SignUpForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string usernameDB = "usernameDB.txt";
        public static string passwordDB = "passwordDB.txt";
        public static string fullnameDB = "fullnameDB.txt";

        NavigationForm navigationForm = new NavigationForm();


        private void signupButton_Click(object sender, EventArgs e)
        {
            /* Username Validation */
            if (usernameTextBox.Text == "")
            {
                // Empty Username
                MessageBox.Show("Kindly enter your username."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
            }
            else if (usernameTextBox.Text.Length > 50)
            {
                // Too long or short username
                MessageBox.Show("Username should be at least 6 to 50 characters only."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
            }
            else if (usernameTextBox.Text.Contains(" "))
            {
                // Username has a white space
                MessageBox.Show("Username should not contain a whitespace character."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();

            }
            else if (
                (usernameTextBox.Text.Contains("@"))
                || (usernameTextBox.Text.Contains("/"))
                || (usernameTextBox.Text.Contains("."))
                || (usernameTextBox.Text.Contains("&"))
                || (usernameTextBox.Text.Contains("*"))
                || (usernameTextBox.Text.Contains("!"))
                || (usernameTextBox.Text.Contains("#"))
                || (usernameTextBox.Text.Contains("$"))
                || (usernameTextBox.Text.Contains("%"))
                || (usernameTextBox.Text.Contains("^"))
                || (usernameTextBox.Text.Contains("("))
                || (usernameTextBox.Text.Contains(")"))
                || (usernameTextBox.Text.Contains("-"))
                || (usernameTextBox.Text.Contains("+"))
                || (usernameTextBox.Text.Contains("="))
                )
            {
                // Username has unneccessary or prohibited characters
                MessageBox.Show("Username should be a combination of alphanumeric" +
                    " characters and digits from 0 to 9."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
            }

            /* Firstname Validation */
            else if (firstnameTextBox.Text == "")
            {
                // Empty first name
                MessageBox.Show("Kindly enter your first name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstnameTextBox.Focus();
            }
            else if (double.TryParse(firstnameTextBox.Text, out double firstnameParsed))
            {
                // Invalid format of first name (e.g. number)
                MessageBox.Show("First name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstnameTextBox.Text = "";
            }


            /* Lastname Validation */
            else if (lastnameTextBox.Text == "")
            {
                //Empty last name
                MessageBox.Show("Kindly enter your last name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastnameTextBox.Focus();
            }
            else if (double.TryParse(firstnameTextBox.Text, out double lastnameParsed))
            {
                // Invalid format of first name (e.g. number)
                MessageBox.Show("Last name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastnameTextBox.Text = "";
            }

            /* Password Validation */
            else if (passwordTextBox.Text == "")
            {
                // Empty password
                MessageBox.Show("Kindly enter your password."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
            }
            else if (passwordTextBox.Text.Length < 8)
            {
                // Too short password or too long password
                MessageBox.Show("Password should be 8 characters long."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
                passwordTextBox.SelectAll();
            }
            else if (passwordTextBox.Text.Contains(" "))
            {
                // Password contains white space
                MessageBox.Show("Password should not contain a whitespace character."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
                passwordTextBox.SelectAll();
            }
            else
            {
                proceedToNavigation();
            }
        }

        void proceedToNavigation()
        {

            this.Hide();
            navigationForm.Show();
            File.AppendAllText(usernameDB, usernameTextBox.Text + Environment.NewLine);
            File.AppendAllText(passwordDB, passwordTextBox.Text + Environment.NewLine);
            File.AppendAllText(fullnameDB, firstnameTextBox.Text + " " + lastnameTextBox.Text + Environment.NewLine);
        }
    }
}
