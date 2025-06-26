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
    public partial class IT_Form : Form
    {
        public string DepartmentName { get; set; }
        public string Username { get; set; }
        private string connStr;
        private static DataTable userManDataTable;
        private static DataTable repairSupportDataTable;
        private static DataTable assetManDataTable;
        private static DataTable MaintenanceLogDataTable;

        public IT_Form()
        {
            InitializeComponent();
            string projectRoot = Directory.GetCurrentDirectory();
            if (projectRoot.Contains("bin\\Debug"))
            {
                projectRoot = Directory.GetParent(projectRoot).Parent.Parent.FullName;
            }
            string dbPath = Path.Combine(projectRoot, "ToySystem.accdb");
            connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }

        private void IT_Form_Load(object sender, EventArgs e)
        {
            this.UserManTable();
            this.RepairSupportTable();
            this.AssetManTable();
            this.MaintenanceLogTable();
        }

        //Second Tab
        private void UserManTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM Login_User";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            userManDataTable = new DataTable();
                            adapter.Fill(userManDataTable);
                            dataGridView1.DataSource = userManDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView1.AllowUserToResizeColumns = false;
                            dataGridView1.Columns["UserID"].ReadOnly = true;
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

        //Third Tab
        private void RepairSupportTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM IT_Ticket";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            repairSupportDataTable = new DataTable();
                            adapter.Fill(repairSupportDataTable);
                            dataGridView2.DataSource = repairSupportDataTable;
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView2.AllowUserToResizeColumns = false;
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

        //Forth Tab
        private void AssetManTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM IT_Asset";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            assetManDataTable = new DataTable();
                            adapter.Fill(assetManDataTable);
                            dataGridView3.DataSource = assetManDataTable;
                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView3.AllowUserToResizeColumns = false;
                            dataGridView3.Columns["ID"].ReadOnly = true;
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

        //Fifth Tab
        private void MaintenanceLogTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM IT_Maintenance";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            MaintenanceLogDataTable = new DataTable();
                            adapter.Fill(MaintenanceLogDataTable);
                            dataGridView4.DataSource = MaintenanceLogDataTable;
                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView4.AllowUserToResizeColumns = false;
                            dataGridView4.Columns["ID"].ReadOnly = true;
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



        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUserProfile_click(object sender, EventArgs e)
        {
            MessageBox.Show("btnUserProfile_click");
            ChangePassword changePasswordForm = new ChangePassword();
            changePasswordForm.Username = Username;
            changePasswordForm.DepartmentName = DepartmentName;
            changePasswordForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Login.OpenDepartmentForm(loginForm);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
