namespace Recordance
{
    partial class NavigationForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 733);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(258, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 617);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(259, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(905, 101);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 36);
            label2.Name = "label2";
            label2.Size = new Size(151, 18);
            label2.TabIndex = 5;
            label2.Text = "Class Monitoring App";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(206, 40);
            label1.TabIndex = 4;
            label1.Text = "RecordAnce";
            // 
            // panel4
            // 
            panel4.Location = new Point(16, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 59);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Location = new Point(16, 182);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 59);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Location = new Point(15, 263);
            panel6.Name = "panel6";
            panel6.Size = new Size(203, 59);
            panel6.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Location = new Point(16, 656);
            panel7.Name = "panel7";
            panel7.Size = new Size(203, 59);
            panel7.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 9);
            label3.Name = "label3";
            label3.Size = new Size(231, 40);
            label3.TabIndex = 5;
            label3.Text = "Your Courses:";
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NavigationForm";
            Text = "Navigation Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label3;
    }
}