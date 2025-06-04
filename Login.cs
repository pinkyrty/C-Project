using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Login : Form
    {
        private string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ToySystem.accdb")};";
        public enum FormType
        {
            LoginForm,
            RNDForm,
            SCMForm,
            PDForm,
            SMDForm,
            CSDForm,
            FIForm,
            ITForm,
            DTForm
        }
        public FormType TargetFormType { get; private set; } = FormType.LoginForm;
        public string DepartmentName { get; private set; }
        public string Username { get; private set; }
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
                                string fullname = reader["FullName"].ToString();
                                string department = reader["Department"].ToString();
                                string departmentName = "";

                                Username = fullname;
                                string sql2 = "SELECT Description FROM Login_Department WHERE DepartmentID = ?";
                                using (OleDbCommand cmd2 = new OleDbCommand(sql2, conn))
                                {
                                    cmd2.Parameters.AddWithValue("?", department);
                                    departmentName = cmd2.ExecuteScalar()?.ToString() ?? "";
                                    DepartmentName = departmentName;
                                }
                                MessageBox.Show($"Login successful! Department Name: {departmentName}, User: {fullname}");

                                OpenDepartmentForm(department);
                            }
                            else
                            {
                                MessageBox.Show("¥Î¤á¦WºÙ©Î±K½X¿ù»~");
                            }
                        }
                    }

                    conn.Close();

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
                    TargetFormType = FormType.RNDForm;
                    break;
                case "2":
                    TargetFormType = FormType.SMDForm;
                    break;
                case "3":
                    TargetFormType = FormType.PDForm;
                    break;
                case "4":
                    TargetFormType = FormType.SCMForm;
                    break;
                case "5":
                    TargetFormType = FormType.CSDForm;
                    break;
                case "6":
                    TargetFormType = FormType.FIForm;
                    break;
                case "7":
                    TargetFormType = FormType.ITForm;
                    break;
                default:
                    TargetFormType = FormType.DTForm;
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        // The remaining control event handlers can be kept
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_Load_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}