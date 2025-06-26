using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C_Project
{
    public partial class FinanceDepartment : Form
    {
        public string DepartmentName { get; set; }
        public string Username { get; set; }
        private string connStr;
        private static DataTable budgetDataTable;
        private static DataTable cashFlowDataTable;
        private static DataTable statementDataTable;
        private static DataTable riskMgmtDataTable;
        private static DataTable investmentDataTable;

        public FinanceDepartment()
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

        private void FinanceDepartment_Load(object sender, EventArgs e)
        {
            this.LoadBudgetTable();
            this.LoadCashFlowTable();
            this.statementTable();
            this.riskMgmtTable();
            this.investmentTable();
        }

        //First Tab
        private void LoadBudgetTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM FI_Budget";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            budgetDataTable = new DataTable();
                            adapter.Fill(budgetDataTable);
                            dataGridView1.DataSource = budgetDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView1.AllowUserToResizeColumns = false;
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

        //Second Tab
        private void LoadCashFlowTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM FI_CashFlow";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            cashFlowDataTable = new DataTable();
                            adapter.Fill(cashFlowDataTable);
                            dataGridView2.DataSource = cashFlowDataTable;
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

        //Third Tab
        private void statementTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM FI_FinanceReport";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            statementDataTable = new DataTable();
                            adapter.Fill(statementDataTable);
                            dataGridView3.DataSource = statementDataTable;
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

        //Forth Tab
        private void riskMgmtTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM FI_RiskMgmt";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            riskMgmtDataTable = new DataTable();
                            adapter.Fill(riskMgmtDataTable);
                            dataGridView4.DataSource = riskMgmtDataTable;
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

        //Fifth Tab
        private void investmentTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM FI_Investment";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            investmentDataTable = new DataTable();
                            adapter.Fill(investmentDataTable);
                            dataGridView5.DataSource = investmentDataTable;
                            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView5.AllowUserToResizeColumns = false;
                            dataGridView5.Columns["ID"].ReadOnly = true;
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


        //private void Form_Load(object sender, EventArgs e)
        //{
        //    LoadBudgetTable();
        //    dataGridView1.Width = (int)(this.ClientSize.Width * 0.8);
        //}

        //private void InsertBudgetTable()
        //{
        //    try
        //    {
        //        using (OleDbConnection conn = new OleDbConnection(connStr))
        //        {

        //            conn.Open();

        //            string sql = "INSERT INTO FI_Budget (FiscalYear, BudgetIncome, BudgetExpense, ForecastIncome, ForecastExpense, Remark) VALUES (?, ?, ?, ?, ?, ?)";
        //            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
        //            {
        //                int rowsInserted = 0;
        //                foreach (DataRow row in dataTable.Rows)
        //                {
        //                    if ((row.RowState == DataRowState.Added))
        //                    {
        //                        string fiscalYear = row["FiscalYear"].ToString().Trim();
        //                        string budgetIncome = row["BudgetIncome"].ToString().Trim();
        //                        string BudgetExpense = row["BudgetExpense"].ToString().Trim();
        //                        string ForecastIncome = row["ForecastIncome"].ToString().Trim();
        //                        string ForecastExpense = row["ForecastExpense"].ToString().Trim();
        //                        string Remark = row["Remark"].ToString().Trim();

        //                        cmd.Parameters.Clear();
        //                        cmd.Parameters.AddWithValue("?", fiscalYear);
        //                        cmd.Parameters.AddWithValue("?", budgetIncome);
        //                        cmd.Parameters.AddWithValue("?", BudgetExpense);
        //                        cmd.Parameters.AddWithValue("?", ForecastIncome);
        //                        cmd.Parameters.AddWithValue("?", ForecastExpense);
        //                        cmd.Parameters.AddWithValue("?", Remark);
        //                        int rowsAffected = cmd.ExecuteNonQuery();
        //                        if (rowsAffected > 0)
        //                        {
        //                            rowsInserted++;

        //                        }
        //                    }
        //                }
        //                if (rowsInserted > 0)
        //                {
        //                    dataTable.AcceptChanges();
        //                    MessageBox.Show("Success Insert");
        //                    LoadBudgetTable();
        //                }
        //            }
        //            conn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error connecting to database!\n" + ex.Message);
        //    }
        //}

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //InsertBudgetTable();
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
