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
                            dataGridView1.AllowUserToResizeColumns = false;
                            dataGridView1.AllowUserToAddRows = true;
                            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            budgetDataTable = new DataTable();
                            adapter.Fill(budgetDataTable);
                            dataGridView1.DataSource = budgetDataTable;
                            dataGridView1.Columns[1].HeaderText = "Financial Year";
                            dataGridView1.Columns[2].HeaderText = "Budget Income";
                            dataGridView1.Columns[3].HeaderText = "Budget Expense";
                            dataGridView1.Columns[4].HeaderText = "Forecast Income";
                            dataGridView1.Columns[5].HeaderText = "Forecast Expense";
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

        //Second Tab
        private void LoadCashFlowTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    dataGridView1.AllowUserToResizeColumns = false;
                    dataGridView1.AllowUserToAddRows = true;
                    dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                    conn.Open();

                    string sql = "SELECT * FROM FI_CashFlow";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dataGridView2.AllowUserToResizeColumns = false;
                            dataGridView2.AllowUserToAddRows = true;
                            dataGridView2.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            cashFlowDataTable = new DataTable();
                            adapter.Fill(cashFlowDataTable);
                            dataGridView2.DataSource = cashFlowDataTable;
                            dataGridView2.Columns[1].HeaderText = "Transaction Date";
                            dataGridView2.Columns[2].HeaderText = "Type";
                            dataGridView2.Columns[3].HeaderText = "Amount";
                            dataGridView2.Columns[4].HeaderText = "Summary";
                            dataGridView2.Columns[4].HeaderText = "Status";
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private void btnUserProfile_click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword(this, connStr);
            changePasswordForm.Username = Username;
            changePasswordForm.DepartmentName = DepartmentName;
            changePasswordForm.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Added)
                        {
                            string query = "INSERT INTO FI_Budget (FiscalYear, BudgetIncome, BudgetExpense, ForecastIncome, ForecastExpense, Remark) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["FiscalYear"] != DBNull.Value ? row["FiscalYear"] : "");
                                cmd.Parameters.AddWithValue("?", row["BudgetIncome"] != DBNull.Value ? row["BudgetIncome"] : 0);
                                cmd.Parameters.AddWithValue("?", row["BudgetExpense"] != DBNull.Value ? row["BudgetExpense"] : 0);
                                cmd.Parameters.AddWithValue("?", row["ForecastIncome"] != DBNull.Value ? row["ForecastIncome"] : 0);
                                cmd.Parameters.AddWithValue("?", row["ForecastExpense"] != DBNull.Value ? row["ForecastExpense"] : 0);
                                cmd.Parameters.AddWithValue("?", row["Remark"] != DBNull.Value ? row["Remark"] : "");

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE FI_Budget SET FiscalYear = ?, BudgetIncome = ?, BudgetExpense = ?, ForecastIncome = ?, ForecastExpense = ?, Remark = ? WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["FiscalYear"] != DBNull.Value ? row["FiscalYear"] : "");
                                cmd.Parameters.AddWithValue("?", row["BudgetIncome"] != DBNull.Value ? row["BudgetIncome"] : 0);
                                cmd.Parameters.AddWithValue("?", row["BudgetExpense"] != DBNull.Value ? row["BudgetExpense"] : 0);
                                cmd.Parameters.AddWithValue("?", row["ForecastIncome"] != DBNull.Value ? row["ForecastIncome"] : 0);
                                cmd.Parameters.AddWithValue("?", row["ForecastExpense"] != DBNull.Value ? row["ForecastExpense"] : 0);
                                cmd.Parameters.AddWithValue("?", row["Remark"] != DBNull.Value ? row["Remark"] : "");
                                cmd.Parameters.AddWithValue("?", row["ID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataRow newRow = budgetDataTable.NewRow();

            newRow["FiscalYear"] = "";
            newRow["BudgetIncome"] = 0;
            newRow["BudgetExpense"] = 0;
            newRow["ForecastIncome"] = 0;
            newRow["ForecastExpense"] = 0;
            newRow["Remark"] = "";

            budgetDataTable.Rows.Add(newRow);
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


        private void btn_Income_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView2.DataSource;
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Added)
                        {
                            string query = "INSERT INTO FI_CashFlow (TransDate, Type, Amount, Summary, Status) VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["TransDate"] != DBNull.Value ? row["TransDate"] : "");
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Amount"] != DBNull.Value ? row["Amount"] : "");
                                cmd.Parameters.AddWithValue("?", row["Summary"] != DBNull.Value ? row["Summary"] : "");
                                cmd.Parameters.AddWithValue("?", row["Status"] != DBNull.Value ? row["Status"] : "");

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE FI_CashFlow SET TransDate = ?, Type = ?, Amount = ?, Summary = ?, Status = ? WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["TransDate"] != DBNull.Value ? row["TransDate"] : "");
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Amount"] != DBNull.Value ? row["Amount"] : "");
                                cmd.Parameters.AddWithValue("?", row["Summary"] != DBNull.Value ? row["Summary"] : "");
                                cmd.Parameters.AddWithValue("?", row["Status"] != DBNull.Value ? row["Status"] : "");
                                cmd.Parameters.AddWithValue("?", row["ID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Income_Add_Click(object sender, EventArgs e)
        {
            DataRow newRow = cashFlowDataTable.NewRow();

            newRow["TransDate"] = "";
            newRow["Type"] = "";
            newRow["Amount"] = "";
            newRow["Summary"] = "";
            newRow["Status"] = "";

            cashFlowDataTable.Rows.Add(newRow);
        }
    }
}
