using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Form1 : Form
    {
        private string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ToySystem.accdb")};";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password!");
                MessageBox.Show("’à›î»ÅE√ëÙ√˚∑Q∫Õ√‹¥a£°");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    string sql = "SELECT COUNT(*) FROM [User] WHERE Username=? AND [Password]=? AND Active=True";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");

                        MessageBox.Show("µ«»ÅE…π¶£°");
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}