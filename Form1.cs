using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        // 請將路徑改成你自己 Access 資料庫的實際路徑
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
                        // 你可以喺度打開主畫面
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