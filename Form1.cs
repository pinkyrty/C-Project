using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Form1 : Form
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HayesPC\Documents\C-Project\ToySystem.accdb";

        public Form1()
        {
            InitializeComponent();
        }

        // 如果 Designer.cs 有 Load += Form1_Load; 就要有呢個方法
        private void Form1_Load(object sender, EventArgs e)
        {
            // 可以留空
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("請輸入用戶名稱和密碼！");
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
                        MessageBox.Show("登入成功！");
                        // 可跳轉主畫面
                    }
                    else
                    {
                        MessageBox.Show("用戶名稱或密碼錯誤！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("連接資料庫出錯！\n" + ex.Message);
            }

        }

    }
}