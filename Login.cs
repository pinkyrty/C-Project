using Microsoft.Data.SqlClient;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Login : Form
    {
        private string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\ToySystem.accdb")};";
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
            SqlConnection.ClearAllPools();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string checkUserSql = "SELECT COUNT(*) FROM Login_User WHERE Username = @username";
                    using (OleDbCommand checkUserCmd = new OleDbCommand(checkUserSql, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", username);
                        int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                        if (userCount == 0)
                        {
                            MessageBox.Show("Account inactive!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string sql = "SELECT FullName, Department FROM Login_User WHERE Username = @username AND Password = @password";
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
                                //MessageBox.Show($"Login successful! Department Name: {departmentName}, User: {fullname}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SetDepartmentForm(department);
                                this.Hide();
                                OpenDepartmentForm(this);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDepartmentForm(string department)
        {
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
        }

        // Open the corresponding form according to the department
        public static void OpenDepartmentForm(Login login)
        {
            Form targetForm = null;
            switch (login.TargetFormType)
            {
                case FormType.RNDForm:
                    targetForm = new RnD_Form();
                    break;
                case FormType.SMDForm:
                    targetForm = new Sales_MarketingForm();
                    break;
                case FormType.PDForm:
                    targetForm = new ProductionOrderForm();
                    break;
                case FormType.SCMForm:
                    targetForm = new LogisticForm();
                    break;
                case FormType.CSDForm:
                    targetForm = new CustomerServiceForm();
                    break;
                case FormType.FIForm:
                    targetForm = new FinanceDepartment();
                    break;
                case FormType.ITForm:
                    targetForm = new IT_Form();
                    break;
                default:
                    targetForm = new LogisticTrackingForm();
                    break;
            }

            if (targetForm is IT_Form itForm)
            {
                itForm.Username = login.Username;
                itForm.DepartmentName = login.DepartmentName;
            }
            else if (targetForm is FinanceDepartment fiForm)
            {
                fiForm.Username = login.Username;
                fiForm.DepartmentName = login.DepartmentName;
            }
            else if (targetForm is CustomerServiceForm csdForm)
            {
                csdForm.Username = login.Username;
                csdForm.DepartmentName = login.DepartmentName;
            }
            else if (targetForm is LogisticForm scmForm)
            {
                scmForm.Username = login.Username;
                scmForm.DepartmentName = login.DepartmentName;
            }
            else if (targetForm is Sales_MarketingForm smdForm)
            {
                smdForm.Username = login.Username;
                smdForm.DepartmentName = login.DepartmentName;
            }
            else if (targetForm is RnD_Form rndForm)
            {
                rndForm.Username = login.Username;
                rndForm.DepartmentName = login.DepartmentName;
            }
            else if (targetForm is ProductionOrderForm pdForm)
            {
                pdForm.Username = login.Username;
                pdForm.DepartmentName = login.DepartmentName;
            }
            else if (targetForm is LogisticTrackingForm DTForm)
            {
                DTForm.Username = login.Username;
                DTForm.DepartmentName = login.DepartmentName;
            }
            if (targetForm != null)
                targetForm.ShowDialog();
        }

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