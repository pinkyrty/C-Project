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
                    // �令�dDepartment
                    string sql = "SELECT Department FROM [User] WHERE Username=? AND [Password]=? AND Active=True";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string department = result.ToString();
                        MessageBox.Show($"Login successful! Department: {department}");

                        // �ھڳ����}�ҹ���Form
                        OpenDepartmentForm(department);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database!\n" + ex.Message);
            }
        }

        // �ھڳ����}�Ҭ���Form
        private void OpenDepartmentForm(string department)
        {
            Form deptForm = null;
            switch (department)
            {
                case "HR":
                    
                    break;
                case "R&D":
                    deptForm = new RaD_Form();
                    break;
                case "Sales_Marketing":
                    deptForm = new Sales_MarketingForm();
                    break;
                default:
                    MessageBox.Show("This department does not have a page yet!");
                    return;
            }
            deptForm.Show();
        }

        // �Ѫ��L����ƥ�handler�i�Hkeep��
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_Load_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}