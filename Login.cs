using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Login : Form
    {
        private string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ToySystem.accdb")};";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password!");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    // Change to check Department
                    string sql = "SELECT * FROM Login_User WHERE Username=@username AND Password=@password";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string department = reader["Department"].ToString();
                                string fullname = reader["FullName"].ToString();
                                MessageBox.Show($"Login successful! Name: {fullname}");

                                OpenDepartmentForm(department);
                            }
                        }
                    }
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database!\n" + ex.Message);
            }
        }

        // Open the corresponding form according to the department
        private void OpenDepartmentForm(string department)
        {
            Form deptForm = null;
            switch (department)
            {
                case "1":
                    deptForm = new RnD_Form();
                    break;
                case "2":
                    deptForm = new Sales_MarketingForm();
                    break;
                case "7":
                    deptForm = new IT_Form();
                    break;
                case "6":
                    deptForm = new FinanceDepartment();
                    break;
                default:
                    deptForm = new IT_Form();
                    break;
            }
            deptForm.Show();
        }

        // The remaining control event handlers can be kept
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_Load_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}