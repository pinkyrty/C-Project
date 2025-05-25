using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Form1 : Form
    {
        // Ո��·���ĳ����Լ� Access �Y�ώ�Č��H·��
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HayesPC\Documents\C-Project\ToySystem.accdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Ոݔ���Ñ����Q���ܴa��");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    string sql = "SELECT COUNT(*) FROM Users WHERE Username=? AND [Password]=? AND Active=True";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("����ɹ���");
                        // ����Ԇնȴ��_������
                    }
                    else
                    {
                        MessageBox.Show("�Ñ����Q���ܴa�e�`��");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�B���Y�ώ���e��\n" + ex.Message);
            }
            private void btnLogin_Click(object sender, EventArgs e)
        {
            // ������õ� code
            MessageBox.Show("Login Clicked");
        }
    }
    }
}