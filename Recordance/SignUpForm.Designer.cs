﻿namespace Recordance
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            panel1 = new Panel();
            passwordTextBox = new TextBox();
            label7 = new Label();
            lastnameTextBox = new TextBox();
            label5 = new Label();
            signupButton = new Button();
            firstnameTextBox = new TextBox();
            label4 = new Label();
            usernameTextBox = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lastnameTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signupButton);
            panel1.Controls.Add(firstnameTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(usernameTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 732);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(33, 449);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(352, 27);
            passwordTextBox.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 425);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 17;
            label7.Text = "Password:";
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastnameTextBox.Location = new Point(34, 383);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(352, 27);
            lastnameTextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 359);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 15;
            label5.Text = "Last Name:";
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.Maroon;
            signupButton.FlatStyle = FlatStyle.Flat;
            signupButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            signupButton.ForeColor = SystemColors.ButtonHighlight;
            signupButton.Location = new Point(35, 492);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(101, 43);
            signupButton.TabIndex = 14;
            signupButton.Text = "Sign-up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstnameTextBox.Location = new Point(34, 329);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(352, 27);
            firstnameTextBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 305);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 12;
            label4.Text = "First Name:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(35, 272);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(352, 27);
            usernameTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 251);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 10;
            label6.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 222);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Sign-up:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(106, 182);
            label2.Name = "label2";
            label2.Size = new Size(183, 21);
            label2.TabIndex = 3;
            label2.Text = "Class Monitoring App";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 126);
            label1.Name = "label1";
            label1.Size = new Size(341, 67);
            label1.TabIndex = 2;
            label1.Text = "RecordAnce";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(439, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 732);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(65, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(600, 600);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignUpForm";
            Text = "Sign-up ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button signupButton;
        private TextBox firstnameTextBox;
        private Label label4;
        private TextBox usernameTextBox;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox passwordTextBox;
        private Label label7;
        private TextBox lastnameTextBox;
        private Label label5;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}