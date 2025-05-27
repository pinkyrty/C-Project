namespace C_Project
{
    partial class CreateUserForm
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
            cbbDepartment = new ComboBox();
            btnConfirm = new Button();
            lblFirstName = new Label();
            lblName = new Label();
            lblUserID = new Label();
            lblPassword = new Label();
            lblConfirm = new Label();
            cbbPermission = new ComboBox();
            txtName = new TextBox();
            txtUserID = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            txtFirstName = new TextBox();
            lblPermission = new Label();
            lblDepartment = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbbDepartment
            // 
            cbbDepartment.FormattingEnabled = true;
            cbbDepartment.Location = new Point(275, 253);
            cbbDepartment.Name = "cbbDepartment";
            cbbDepartment.Size = new Size(129, 23);
            cbbDepartment.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(275, 360);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(172, 56);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(195, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(195, 137);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(44, 15);
            lblUserID.TabIndex = 4;
            lblUserID.Text = "UserID";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(179, 177);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(131, 215);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(108, 15);
            lblConfirm.TabIndex = 6;
            lblConfirm.Text = "Confirm Password";
            // 
            // cbbPermission
            // 
            cbbPermission.FormattingEnabled = true;
            cbbPermission.Location = new Point(275, 289);
            cbbPermission.Name = "cbbPermission";
            cbbPermission.Size = new Size(129, 23);
            cbbPermission.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(275, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(129, 23);
            txtName.TabIndex = 8;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(275, 137);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(129, 23);
            txtUserID.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(275, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(129, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(275, 212);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(129, 23);
            txtConfirm.TabIndex = 11;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(275, 56);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(129, 23);
            txtFirstName.TabIndex = 12;
            // 
            // lblPermission
            // 
            lblPermission.AutoSize = true;
            lblPermission.Location = new Point(172, 292);
            lblPermission.Name = "lblPermission";
            lblPermission.Size = new Size(67, 15);
            lblPermission.TabIndex = 13;
            lblPermission.Text = "Permission";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(164, 253);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(75, 15);
            lblDepartment.TabIndex = 14;
            lblDepartment.Text = "Department";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SmilesunToy;
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(474, 429);
            Controls.Add(pictureBox1);
            Controls.Add(lblDepartment);
            Controls.Add(lblPermission);
            Controls.Add(txtFirstName);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtUserID);
            Controls.Add(txtName);
            Controls.Add(cbbPermission);
            Controls.Add(lblConfirm);
            Controls.Add(lblPassword);
            Controls.Add(lblUserID);
            Controls.Add(lblName);
            Controls.Add(lblFirstName);
            Controls.Add(btnConfirm);
            Controls.Add(cbbDepartment);
            Name = "CreateUserForm";
            Text = "CreateUserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbDepartment;
        private Button btnConfirm;
        private Label lblFirstName;
        private Label lblName;
        private Label lblUserID;
        private Label lblPassword;
        private Label lblConfirm;
        private ComboBox cbbPermission;
        private TextBox txtName;
        private TextBox txtUserID;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private TextBox txtFirstName;
        private Label lblPermission;
        private Label lblDepartment;
        private PictureBox pictureBox1;
    }
}