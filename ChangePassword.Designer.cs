namespace C_Project
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            label1 = new Label();
            label2 = new Label();
            DepartmentDisplay = new Label();
            StaffNameDisplay = new Label();
            label3 = new Label();
            label4 = new Label();
            ExistingPasswordBox = new TextBox();
            label5 = new Label();
            NewPasswordBox = new TextBox();
            label6 = new Label();
            ConfirmPasswordBox = new TextBox();
            UpdatePasswordButton = new Button();
            CancelButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 47);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Staff Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 97);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Department";
            // 
            // DepartmentDisplay
            // 
            DepartmentDisplay.AutoSize = true;
            DepartmentDisplay.Location = new Point(265, 97);
            DepartmentDisplay.Name = "DepartmentDisplay";
            DepartmentDisplay.Size = new Size(0, 15);
            DepartmentDisplay.TabIndex = 2;
            // 
            // StaffNameDisplay
            // 
            StaffNameDisplay.AutoSize = true;
            StaffNameDisplay.Location = new Point(265, 47);
            StaffNameDisplay.Name = "StaffNameDisplay";
            StaffNameDisplay.Size = new Size(0, 15);
            StaffNameDisplay.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 149);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Change password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 196);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 5;
            label4.Text = "Existing password";
            // 
            // ExistingPasswordBox
            // 
            ExistingPasswordBox.Location = new Point(253, 193);
            ExistingPasswordBox.Name = "ExistingPasswordBox";
            ExistingPasswordBox.Size = new Size(159, 23);
            ExistingPasswordBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 248);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 7;
            label5.Text = "New password";
            // 
            // NewPasswordBox
            // 
            NewPasswordBox.Location = new Point(253, 245);
            NewPasswordBox.Name = "NewPasswordBox";
            NewPasswordBox.Size = new Size(159, 23);
            NewPasswordBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 298);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 9;
            label6.Text = "Confirm password";
            // 
            // ConfirmPasswordBox
            // 
            ConfirmPasswordBox.Location = new Point(253, 295);
            ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            ConfirmPasswordBox.Size = new Size(159, 23);
            ConfirmPasswordBox.TabIndex = 10;
            // 
            // UpdatePasswordButton
            // 
            UpdatePasswordButton.Location = new Point(88, 366);
            UpdatePasswordButton.Name = "UpdatePasswordButton";
            UpdatePasswordButton.Size = new Size(125, 35);
            UpdatePasswordButton.TabIndex = 11;
            UpdatePasswordButton.Text = "Update password";
            UpdatePasswordButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(253, 366);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(125, 35);
            CancelButton.TabIndex = 12;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(469, 484);
            Controls.Add(pictureBox1);
            Controls.Add(CancelButton);
            Controls.Add(UpdatePasswordButton);
            Controls.Add(ConfirmPasswordBox);
            Controls.Add(label6);
            Controls.Add(NewPasswordBox);
            Controls.Add(label5);
            Controls.Add(ExistingPasswordBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(StaffNameDisplay);
            Controls.Add(DepartmentDisplay);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label DepartmentDisplay;
        private Label StaffNameDisplay;
        private Label label3;
        private Label label4;
        private TextBox ExistingPasswordBox;
        private Label label5;
        private TextBox NewPasswordBox;
        private Label label6;
        private TextBox ConfirmPasswordBox;
        private Button UpdatePasswordButton;
        private Button CancelButton;
        private PictureBox pictureBox1;
    }
}