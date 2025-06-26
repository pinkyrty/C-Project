using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class CustomerServiceForm : Form
    {
        private string connStr;
        private static DataTable interactionLogDataTable;
        private static DataTable returnDataTable;
        public string DepartmentName { get; set; }
        public string Username { get; set; }

        public CustomerServiceForm()
        {
            InitializeComponent();
            string projectRoot = Directory.GetCurrentDirectory();
            if (projectRoot.Contains("bin\\Debug"))
            {
                projectRoot = Directory.GetParent(projectRoot).Parent.Parent.FullName;
            }
            string dbPath = Path.Combine(projectRoot, "ToySystem.accdb");
            connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            this.LoadInteractionLogTable();
            this.LoadReturnTable();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }

        //first Tab
        private void LoadInteractionLogTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT ID, Date, CustomerName, Channel FROM CSD_InteractionLog";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            interactionLogDataTable = new DataTable();
                            adapter.Fill(interactionLogDataTable);
                            dataGridView1.DataSource = interactionLogDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.Columns["ID"].ReadOnly = true;
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

        //second Tab
        private void LoadReturnTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM CSD_RefundCase";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            returnDataTable = new DataTable();
                            adapter.Fill(returnDataTable);
                            dataGridView2.DataSource = returnDataTable;
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView2.Columns["ID"].ReadOnly = true;
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



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // 重新登入後，根據部門再開啟對應表單
                Login.OpenDepartmentForm(loginForm);
            }
            else
            {
                // 如果沒登入成功，直接關閉應用程式
                Application.Exit();
            }
        }
    }
}
