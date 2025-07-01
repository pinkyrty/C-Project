using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace C_Project
{
    public partial class ChangePassword : Form
    {
        public string DepartmentName { get; set; }
        public string Username { get; set; }
        private Form parentForm;
        private string connStr;

        public ChangePassword(Form parentForm = null, string connectionString = null)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.connStr = connectionString;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }

        private bool UpdatePassword(string username, string newPassword)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "UPDATE Login_User SET [Password] = @Password WHERE [Username] = @Username";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
                return false;
            }
        }


        private bool VerifyExistingPassword(string username, string existingPassword)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT Password FROM Login_User WHERE Username = @Username";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();

                        return result != null && existingPassword == result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying password: " + ex.Message);
                return false;
            }
        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                MessageBox.Show("Username is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!VerifyExistingPassword(Username, ExistingPasswordBox.Text))
            {
                MessageBox.Show("Existing password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(NewPasswordBox.Text) || NewPasswordBox.Text != ConfirmPasswordBox.Text)
            {
                MessageBox.Show("Passwords do not match or are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ExistingPasswordBox.Text == NewPasswordBox.Text)
            {
                MessageBox.Show("New password cannot be the same as the existing password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 新增密碼驗證
            if (!IsValidPassword(NewPasswordBox.Text))
            {
                MessageBox.Show("New password must be at least 8 characters long, start with an uppercase letter, and contain at least one uppercase letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = UpdatePassword(Username, NewPasswordBox.Text);

            if (success)
            {
                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                parentForm.Hide();
                Login loginForm = new Login();
                loginForm.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 新增密碼驗證方法
        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 && password.Any(char.IsUpper);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}