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
            lblUserName = new Label();
            lblUserID = new Label();
            lblPassword = new Label();
            lblConfirm = new Label();
            txtName = new TextBox();
            txtUserID = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            lblDepartment = new Label();
            pictureBox1 = new PictureBox();
            lblCreateUser = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbbDepartment
            // 
            cbbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDepartment.FormattingEnabled = true;
            cbbDepartment.Items.AddRange(new object[] { "Sales Department", "R&D Department", "Production Department", "Inventory / Logistics Department", "Customer Service Department", "Finance Department", "IT Department" });
            cbbDepartment.Location = new Point(272, 286);
            cbbDepartment.Name = "cbbDepartment";
            cbbDepartment.Size = new Size(129, 23);
            cbbDepartment.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(297, 350);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(166, 128);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(70, 15);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "User Name";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(192, 170);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(44, 15);
            lblUserID.TabIndex = 4;
            lblUserID.Text = "UserID";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(176, 210);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(128, 248);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(108, 15);
            lblConfirm.TabIndex = 6;
            lblConfirm.Text = "Confirm Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(272, 128);
            txtName.MaxLength = 32;
            txtName.Name = "txtName";
            txtName.Size = new Size(129, 23);
            txtName.TabIndex = 8;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(272, 170);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(129, 23);
            txtUserID.TabIndex = 9;
            txtUserID.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(272, 207);
            txtPassword.MaxLength = 32;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(129, 23);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(272, 245);
            txtConfirm.MaxLength = 32;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(129, 23);
            txtConfirm.TabIndex = 11;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(161, 286);
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
            // lblCreateUser
            // 
            lblCreateUser.AutoSize = true;
            lblCreateUser.Font = new Font("Microsoft JhengHei UI", 15F);
            lblCreateUser.Location = new Point(206, 50);
            lblCreateUser.Name = "lblCreateUser";
            lblCreateUser.Size = new Size(119, 25);
            lblCreateUser.TabIndex = 16;
            lblCreateUser.Text = "Create User";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(146, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button1_Click;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(474, 429);
            Controls.Add(btnCancel);
            Controls.Add(lblCreateUser);
            Controls.Add(pictureBox1);
            Controls.Add(lblDepartment);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtUserID);
            Controls.Add(txtName);
            Controls.Add(lblConfirm);
            Controls.Add(lblPassword);
            Controls.Add(lblUserID);
            Controls.Add(lblUserName);
            Controls.Add(btnConfirm);
            Controls.Add(cbbDepartment);
            Name = "CreateUserForm";
            Text = "CreateUser";
            Load += CreateUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbDepartment;
        private Button btnConfirm;
        private Label lblFirstName;
        private Label lblUserName;
        private Label lblUserID;
        private Label lblPassword;
        private Label lblConfirm;
        private TextBox txtName;
        private TextBox txtUserID;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private TextBox txtFirstName;
        private Label lblDepartment;
        private PictureBox pictureBox1;
        private Label lblCreateUser;
        private Button btnCancel;
    }
}