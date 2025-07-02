using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Word;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace C_Project
{
    public partial class FinanceDepartment : Form
    {
        public string DepartmentName { get; set; }
        public string Username { get; set; }
        private string connStr;
        private string fileAttachmentPath = string.Empty;
        private static System.Data.DataTable budgetDataTable;
        private static System.Data.DataTable cashFlowDataTable;
        private static System.Data.DataTable statementDataTable;
        private static System.Data.DataTable riskMgmtDataTable;
        private static System.Data.DataTable investmentDataTable;

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

                            budgetDataTable = new System.Data.DataTable();
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

                    loadChart();

                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database!\n" + ex.Message);
            }
        }

        private void loadChart()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea("FinancialChart");
            chart3.ChartAreas.Add(chartArea);

            System.Windows.Forms.DataVisualization.Charting.Series budgetIncomeSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Budget Income")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            chart3.Series.Clear();
            chart3.Series.Add(budgetIncomeSeries);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string financialYear = row.Cells["FiscalYear"].Value?.ToString();
                    //string budgetIncome = row.Cells["BudgetIncome"].Value.ToString();
                    bool isValid = double.TryParse(row.Cells["BudgetIncome"].Value?.ToString(), out double budgetIncome);

                    if (isValid)
                    {
                        budgetIncomeSeries.Points.AddXY(financialYear, budgetIncome);

                    }
                }
            }

            chart3.Titles.Add("Financial Overview by Year");
            chartArea.AxisX.Title = "Financial Year";
            chartArea.AxisY.Title = "Amount ($)";
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisX.LabelStyle.Enabled = true;

            chartArea.AxisY.Minimum = 0;

            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.IsLabelAutoFit = true;

            budgetIncomeSeries["PointWidth"] = "0.2";

            budgetIncomeSeries["DrawSideBySide"] = "true";

            chart3.Invalidate();
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
                            dataGridView2.AllowUserToResizeColumns = false;
                            dataGridView2.AllowUserToAddRows = true;
                            dataGridView2.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            cashFlowDataTable = new System.Data.DataTable();
                            adapter.Fill(cashFlowDataTable);
                            dataGridView2.DataSource = cashFlowDataTable;
                            dataGridView2.Columns[1].HeaderText = "Transaction Date";
                            dataGridView2.Columns[2].HeaderText = "Type";
                            dataGridView2.Columns[3].HeaderText = "Amount";
                            dataGridView2.Columns[4].HeaderText = "Summary";
                            dataGridView2.Columns[5].HeaderText = "Status";
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

                    // 查詢附件檔案名稱
                    string sql = "SELECT ID, ReportType, Period, FileAttachment.FileName AS FileAttachment, UploadDate, Uploader FROM FI_FinanceReport";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            statementDataTable = new System.Data.DataTable();
                            adapter.Fill(statementDataTable);
                            dataGridView3.DataSource = statementDataTable;

                            if (dataGridView3.Columns.Count >= 6)
                            {
                                dataGridView3.Columns[1].HeaderText = "Report Type";
                                dataGridView3.Columns[2].HeaderText = "Period";
                                dataGridView3.Columns[3].HeaderText = "File Attachment";
                                dataGridView3.Columns[4].HeaderText = "Upload Date";
                                dataGridView3.Columns[5].HeaderText = "Uploader";
                                dataGridView3.Columns[5].Width = 100;
                                dataGridView3.Columns["ID"].ReadOnly = true;
                                dataGridView3.Columns["UploadDate"].ReadOnly = true;
                            }
                            else
                            {
                                Console.WriteLine($"Expected at least 6 columns, but got: {dataGridView3.Columns.Count}");
                                CheckColumns(dataGridView3);
                            }

                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView3.AllowUserToResizeColumns = false;
                            dataGridView3.ReadOnly = false;
                            dataGridView3.AllowUserToAddRows = true;
                            dataGridView3.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
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
        private void CheckColumns(DataGridView dataGridView3)
        {
            Console.WriteLine($"Total Columns: {dataGridView3.Columns.Count}");
            foreach (DataGridViewColumn col in dataGridView3.Columns)
            {
                Console.WriteLine($"Index: {col.Index}, Name: {col.Name}, Header: {col.HeaderText}");
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

                    string sql = "SELECT ID, RiskType, RiskLevel, Description, Mitigation, CreatedDate FROM FI_RiskMgmt";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            riskMgmtDataTable = new System.Data.DataTable();
                            adapter.Fill(riskMgmtDataTable);
                            dataGridView4.DataSource = riskMgmtDataTable;

                            dataGridView4.Columns[1].HeaderText = "Risk Type";
                            dataGridView4.Columns[2].HeaderText = "Risk Level";
                            dataGridView4.Columns[3].HeaderText = "Description";
                            dataGridView4.Columns[4].HeaderText = "Mitigation";
                            dataGridView4.Columns[5].HeaderText = "Created Date";
                            dataGridView4.Columns["ID"].ReadOnly = true;
                            dataGridView4.Columns["CreatedDate"].ReadOnly = true;

                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView4.AllowUserToResizeColumns = false;
                            dataGridView4.AllowUserToAddRows = true;
                            dataGridView4.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
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
                            dataGridView5.AllowUserToResizeColumns = false;
                            dataGridView5.AllowUserToAddRows = true;
                            dataGridView5.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            investmentDataTable = new System.Data.DataTable();
                            adapter.Fill(investmentDataTable);
                            dataGridView5.DataSource = investmentDataTable;
                            dataGridView5.Columns[1].HeaderText = "Project Name";
                            dataGridView5.Columns[2].HeaderText = "Amount";
                            dataGridView5.Columns[3].HeaderText = "ROI";
                            dataGridView5.Columns[4].HeaderText = "Description";
                            dataGridView5.Columns[5].HeaderText = "Created Date";
                            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                System.Data.DataTable dt = (System.Data.DataTable)dataGridView1.DataSource;
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
                System.Windows.Forms.Application.Exit();
            }
        }


        private void btn_Income_Save_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dt = (System.Data.DataTable)dataGridView2.DataSource;
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

                LoadCashFlowTable();

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Invest_Add_Click(object sender, EventArgs e)
        {
            DataRow newRow = investmentDataTable.NewRow();

            newRow["ProjectName"] = "";
            newRow["Amount"] = "";
            newRow["ROI"] = "0";
            newRow["Description"] = "";
            newRow["CreatedDate"] = "";

            investmentDataTable.Rows.Add(newRow);
        }

        private void btn_Invest_Save_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dt = (System.Data.DataTable)dataGridView5.DataSource;
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
                            string query = "INSERT INTO FI_Investment (ProjectName, Amount, ROI, Description, CreatedDate) VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ProjectName"] != DBNull.Value ? row["ProjectName"] : "");
                                cmd.Parameters.AddWithValue("?", row["Amount"] != DBNull.Value ? row["Amount"] : "");
                                cmd.Parameters.AddWithValue("?", row["ROI"] != DBNull.Value ? row["ROI"] : "0");
                                cmd.Parameters.AddWithValue("?", row["Description"] != DBNull.Value ? row["Description"] : "");
                                cmd.Parameters.AddWithValue("?", row["CreatedDate"] != DBNull.Value ? row["CreatedDate"] : "");

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE FI_Investment SET ProjectName = ?, Amount = ?, ROI = ?, Description = ?, CreatedDate = ? WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ProjectName"] != DBNull.Value ? row["ProjectName"] : "");
                                cmd.Parameters.AddWithValue("?", row["Amount"] != DBNull.Value ? row["Amount"] : "");
                                cmd.Parameters.AddWithValue("?", row["ROI"] != DBNull.Value ? row["ROI"] : "0");
                                cmd.Parameters.AddWithValue("?", row["Description"] != DBNull.Value ? row["Description"] : "");
                                cmd.Parameters.AddWithValue("?", row["CreatedDate"] != DBNull.Value ? row["CreatedDate"] : "");
                                cmd.Parameters.AddWithValue("?", row["ID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                LoadCashFlowTable();

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Risk_Add_Click(object sender, EventArgs e)
        {
            string riskType = riskTypeText.Text.Trim();
            string riskLevel = riskLevelCombo.Text.Trim();
            string riskDesc = riskDescText.Text.Trim();
            string riskMiti = riskMitiText.Text.Trim();

            if (string.IsNullOrEmpty(riskType) || string.IsNullOrEmpty(riskLevel) ||
                string.IsNullOrEmpty(riskDesc) || string.IsNullOrEmpty(riskMiti))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string query = "INSERT INTO FI_RiskMgmt (RiskType, RiskLevel, Description, Mitigation, CreatedDate) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = riskType;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = riskLevel;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = riskDesc;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = riskMiti;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Today;

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                riskMgmtTable();

                MessageBox.Show("Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding risk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Report_Add_Click(object sender, EventArgs e)
        {
            string reportType = riskReportTypeText.Text.Trim();
            string reportPeriod = riskPeriodText.Text.Trim();

            // 驗證輸入
            if (string.IsNullOrEmpty(reportType) || string.IsNullOrEmpty(reportPeriod))
            {
                MessageBox.Show("Please fill in Report Type and Period!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    // 插入非附件欄位
                    string query = "INSERT INTO FI_FinanceReport (ReportType, Period, UploadDate, Uploader) VALUES (?, ?, ?, ?)";
                    int newId;
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = reportType;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = reportPeriod;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Today;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = Username ?? "Unknown";
                        cmd.ExecuteNonQuery();

                        // 獲取新插入記錄的 ID
                        using (OleDbCommand idCmd = new OleDbCommand("SELECT @@IDENTITY", conn))
                        {
                            newId = Convert.ToInt32(idCmd.ExecuteScalar());
                        }
                    }

                    // 如果有選擇 PDF，插入附件
                    if (!string.IsNullOrEmpty(fileAttachmentPath))
                    {
                        if (!File.Exists(fileAttachmentPath))
                        {
                            MessageBox.Show($"Uploaded file not found: {fileAttachmentPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            fileAttachmentPath = string.Empty;
                            return;
                        }

                        // 插入附件到 FileAttachment 子表
                        string attachmentTable = "FI_FinanceReport.FileAttachment";
                        string attachmentQuery = $"INSERT INTO {attachmentTable} (ParentID, FileData, FileName) VALUES (?, ?, ?)";
                        using (OleDbCommand attachmentCmd = new OleDbCommand(attachmentQuery, conn))
                        {
                            byte[] fileData = File.ReadAllBytes(fileAttachmentPath);
                            attachmentCmd.Parameters.Add("?", OleDbType.Integer).Value = newId;
                            attachmentCmd.Parameters.Add("?", OleDbType.Binary).Value = fileData;
                            attachmentCmd.Parameters.Add("?", OleDbType.VarChar).Value = Path.GetFileName(fileAttachmentPath);
                            attachmentCmd.ExecuteNonQuery();
                        }
                    }

                    conn.Close();
                }

                fileAttachmentPath = string.Empty; // 重置
                statementTable();
                MessageBox.Show("Report added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ReportUpload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "PDF Files|*.pdf";
                    openFileDialog.Title = "Select a PDF File";
                    if (openFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("No PDF file selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 檢查檔案是否存在
                    string sourceFilePath = openFileDialog.FileName;
                    if (!File.Exists(sourceFilePath))
                    {
                        MessageBox.Show($"Selected file not found: {sourceFilePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 定義儲存檔案的資料夾
                    string uploadFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");
                    if (!Directory.Exists(uploadFolder))
                    {
                        try
                        {
                            Directory.CreateDirectory(uploadFolder);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to create Uploads folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 複製檔案到 Uploads 資料夾
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destinationPath = Path.Combine(uploadFolder, fileName);
                    try
                    {
                        File.Copy(sourceFilePath, destinationPath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to copy file to Uploads folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    fileAttachmentPath = destinationPath; // 儲存複製後的檔案路徑
                    MessageBox.Show("PDF file selected and copied successfully! Click 'Add Report' to save to database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting PDF file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
