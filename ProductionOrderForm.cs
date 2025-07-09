using Microsoft.IdentityModel.Tokens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C_Project
{
    public partial class ProductionOrderForm : Form
    {
        private string connStr;
        private static DataTable orderStepDataTable;
        private static DataTable materialDataTable;
        private static DataTable processDataTable;
        private static DataTable requsetDataTable;
        private static DataTable orderPlanDataTable;
        public string DepartmentName { get; set; }
        public string Username { get; set; }

        public ProductionOrderForm()
        {
            InitializeComponent();
            this.dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

            string projectRoot = Directory.GetCurrentDirectory();
            if (projectRoot.Contains("bin\\Debug"))
            {
                projectRoot = Directory.GetParent(projectRoot).Parent.Parent.FullName;
            }
            string dbPath = Path.Combine(projectRoot, "ToySystem.accdb");
            connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            this.LoadOrderStepTable();
            this.LoadMaterialTable();
            this.LoadProcessTable();
            this.LoadRequestTable();
            this.LoadOrderPlanTable();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }

        //first Tab
        private void LoadOrderStepTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT OrderID, OrderNumber, ODate, ProductID, RefQuotation, Qty, Remark, ESD, EED FROM SMD_ProdOrder";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            orderStepDataTable = new DataTable();
                            adapter.Fill(orderStepDataTable);
                            dataGridView2.DataSource = orderStepDataTable;

                            // 設定Row Header（避免Index Out Of Range）
                            for (int i = 0; i < dataGridView2.Rows.Count; i++)
                            {
                                if (!dataGridView2.Rows[i].IsNewRow)
                                    dataGridView2.Rows[i].HeaderCell.Value = $"Row {i + 1}";
                            }

                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView2.AllowUserToResizeColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database OrderStep!\n" + ex.Message);
            }
        }

        //second Tab
        private void LoadMaterialTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string sql = "SELECT MRFNo, ProductName, ProductSpec, DeliveryDate, Approver, Remark FROM PD_MaterialRequestForm";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dataGridView1.AllowUserToResizeColumns = false;
                            dataGridView1.AllowUserToAddRows = true;
                            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            materialDataTable = new DataTable();
                            adapter.Fill(materialDataTable);
                            dataGridView1.DataSource = materialDataTable;

                            // 正確做法
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                if (!dataGridView1.Rows[i].IsNewRow)
                                    dataGridView1.Rows[i].HeaderCell.Value = $"Row {i + 1}";
                            }

                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView1.AllowUserToResizeColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database Material!\n" + ex.Message);
            }
        }

        //third Tab
        private void LoadProcessTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT OStepID, OrderID, ProcName, Staff, Note FROM PD_OrderStep";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dataGridView3.AllowUserToResizeColumns = false;
                            dataGridView3.AllowUserToAddRows = true;
                            dataGridView3.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            processDataTable = new DataTable();
                            adapter.Fill(processDataTable);
                            dataGridView3.DataSource = processDataTable;
                            SetProcessGridReadOnly(); // <--- 加呢句！
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database Process!\n" + ex.Message);
            }
        }


        //fourth Tab
        private void LoadRequestTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT OFID, FileName, UploadedBy, UploadDate, FilePath FROM SMD_OrderFile";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dataGridView4.AllowUserToResizeColumns = false;
                            dataGridView4.AllowUserToAddRows = true;
                            dataGridView4.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            requsetDataTable = new DataTable();
                            adapter.Fill(requsetDataTable);
                            dataGridView4.DataSource = requsetDataTable;
                            dataGridView4.Columns[1].HeaderText = "FileName";
                            dataGridView4.Columns[2].HeaderText = "UploadedBy";
                            dataGridView4.Columns[3].HeaderText = "UploadDate";
                            dataGridView4.Columns[4].HeaderText = "FilePath";
                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView4.AllowUserToResizeColumns = false;
                        }
                    }

                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database Request!\n" + ex.Message);
            }
        }

        private void LoadOrderPlanTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT OPlanID, OrderID, PlanStart, PlanEnd, Instruction FROM PD_OrderPlan";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            orderPlanDataTable = new DataTable();
                            adapter.Fill(orderPlanDataTable);
                            dataGridView5.DataSource = orderPlanDataTable;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to PD_OrderPlan!\n" + ex.Message);
            }
        }


        private void btn_Save1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.EndEdit();

                DataTable dt = (DataTable)dataGridView3.DataSource;
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
                            string query = "INSERT INTO PD_OrderStep ([OrderID], [ProcName], [Staff], [Note]) VALUES (?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["OrderID"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("?", row["ProcName"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("?", row["Staff"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("?", row["Note"] ?? DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE PD_OrderStep SET [OrderID]=?, [ProcName]=?, [Staff]=?, [Note]=? WHERE [OStepID]=?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["OrderID"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("?", row["ProcName"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("?", row["Staff"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("?", row["Note"] ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("?", row["OStepID"]);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 儲存完 reload
                if (dataGridView2.CurrentRow != null && dataGridView2.CurrentRow.Cells["OrderID"].Value != null)
                {
                    string orderID = dataGridView2.CurrentRow.Cells["OrderID"].Value.ToString();
                    LoadOrderStepTableByOrderID(orderID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add1_Click(object sender, EventArgs e)
        {
            if (processDataTable == null)
            {
                MessageBox.Show("工序資料未載入！");
                return;
            }

            DataRow newRow = processDataTable.NewRow();

            // 自動帶入左邊 OrderID
            string orderId = "";
            if (dataGridView2.CurrentRow != null && dataGridView2.CurrentRow.Cells["OrderID"].Value != null)
                orderId = dataGridView2.CurrentRow.Cells["OrderID"].Value.ToString();

            newRow["OrderID"] = orderId;   // 自動帶入
            newRow["ProcName"] = "";
            newRow["Staff"] = "";
            newRow["Note"] = "";

            processDataTable.Rows.Add(newRow);
        }

        private void btn_Save2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView4.EndEdit();
                if (dataGridView4.CurrentCell != null)
                    dataGridView4.CurrentCell = null;
                this.Validate();

                DataTable dt = (DataTable)dataGridView4.DataSource;
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
                        object fileName = row["FileName"];
                        object filePath = row["FilePath"];

                        // 跳過空白行
                        if (fileName == DBNull.Value || fileName == null || fileName.ToString().Trim() == "")
                            continue;

                        // 自動填入現時用戶
                        row["UploadedBy"] = this.Username;
                        // 自動填入今日日期（只日期部分）
                        row["UploadDate"] = DateTime.Now.Date;

                        if (row.RowState == DataRowState.Added)
                        {
                            string query = "INSERT INTO SMD_OrderFile ([OrderID], [FileName], [UploadedBy], [UploadDate], [FilePath]) VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["OrderID"]);
                                cmd.Parameters.AddWithValue("?", fileName.ToString());
                                cmd.Parameters.AddWithValue("?", this.Username);
                                //OleDb會自動將DateTime型別存成日期，不用 ToString("yyyy-MM-dd")
                                cmd.Parameters.AddWithValue("?", DateTime.Now.Date);
                                cmd.Parameters.AddWithValue("?", filePath == DBNull.Value ? "" : filePath.ToString());
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE SMD_OrderFile SET [FileName]=?, [UploadedBy]=?, [UploadDate]=?, [FilePath]=? WHERE [OFID]=?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", fileName.ToString());
                                cmd.Parameters.AddWithValue("?", this.Username);
                                cmd.Parameters.AddWithValue("?", DateTime.Now.Date);
                                cmd.Parameters.AddWithValue("?", filePath == DBNull.Value ? "" : filePath.ToString());
                                cmd.Parameters.AddWithValue("?", row["OFID"]);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 重新載入
                if (dataGridView2.CurrentRow != null && dataGridView2.CurrentRow.Cells["OrderID"].Value != null)
                {
                    string orderID = dataGridView2.CurrentRow.Cells["OrderID"].Value.ToString();
                    LoadOrderFileTableByOrderID(orderID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Save3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView4.DataSource;
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
                            string query = "INSERT INTO PD_OrderPlan (PlanStart, PlanEnd, Instruction) VALUES (?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["FileName"] != DBNull.Value ? row["FileName"] : "");
                                cmd.Parameters.AddWithValue("?", row["UploadedBy"] != DBNull.Value ? row["UploadedBy"] : "");
                                cmd.Parameters.AddWithValue("?", row["UploadDate"] != DBNull.Value ? row["UploadDate"] : "");
                                cmd.Parameters.AddWithValue("?", row["FilePath"] != DBNull.Value ? row["FilePath"] : "");

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE PD_OrderPlan SET  FileName = ?, UploadedBy = ?, UploadDate = ?, FilePath = ? WHERE OFID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["FileName"] != DBNull.Value ? row["FileName"] : "");
                                cmd.Parameters.AddWithValue("?", row["UploadedBy"] != DBNull.Value ? row["UploadedBy"] : "");
                                cmd.Parameters.AddWithValue("?", row["UploadDate"] != DBNull.Value ? row["UploadDate"] : "");
                                cmd.Parameters.AddWithValue("?", row["FilePath"] != DBNull.Value ? row["FilePath"] : "");
                                cmd.Parameters.AddWithValue("?", row["OFID"]);


                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add2_Click(object sender, EventArgs e)
        {
            if (requsetDataTable == null)
            {
                MessageBox.Show("檔案清單未載入。");
                return;
            }

            // 取得左側選中 OrderID
            string orderId = dataGridView2.CurrentRow?.Cells["OrderID"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(orderId))
            {
                MessageBox.Show("請先選擇訂單。");
                return;
            }

            DataRow newRow = requsetDataTable.NewRow();
            newRow["OrderID"] = orderId; // 自動帶入外鍵
            newRow["FileName"] = "";
            newRow["UploadedBy"] = "";
            newRow["UploadDate"] = DBNull.Value;
            newRow["FilePath"] = "";

            requsetDataTable.Rows.Add(newRow);
        }

        private void btn_Save3_Click_1(object sender, EventArgs e)
        {
            string orderNumber = orderNumberTextBox.Text.Trim();
            string productName = productNameTextBox.Text.Trim();
            string productNumber = productNumberTextBox.Text.Trim();
            DateTime selected = selectedDate.Value;
            string quantity = quantityTextBox.Text.Trim();
            string remark = remarkTextBox.Text.Trim();

            if (string.IsNullOrEmpty(orderNumber) || string.IsNullOrEmpty(productName) ||
    string.IsNullOrEmpty(productNumber) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(remark))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string query = "INSERT INTO PD_MaterialRequestForm (MRFNo, ProductName, ProductSpec, DeliveryDate, CreateDate, Approver, Remark) VALUES (?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = orderNumberTextBox;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = productNameTextBox;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = productNumberTextBox;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = this.selectedDate;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = quantityTextBox;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = remarkTextBox;

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                RepairSupportTable();

                MessageBox.Show("Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding risk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Add3_Click(object sender, EventArgs e)
        {
            if (materialDataTable == null)
            {
                MessageBox.Show("PD_MaterialRequestForm 資料尚未載入。");
                return;
            }
            DataRow newRow = materialDataTable.NewRow();

            newRow["MRFNo"] = "";
            newRow["MRFDate"] = DBNull.Value;
            newRow["Dept"] = "";
            newRow["Priority"] = "";
            newRow["ProductName"] = "";
            newRow["ProductSpec"] = "";
            newRow["DeliveryDate"] = DBNull.Value;
            newRow["Approver"] = "";
            newRow["Remark"] = "";
            newRow["OrderID"] = "";

            materialDataTable.Rows.Add(newRow);
        }
        private void btn_Save4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView5.EndEdit();
                if (dataGridView5.CurrentCell != null)
                    dataGridView5.CurrentCell = null;
                this.Validate();

                DataTable dt = (DataTable)dataGridView5.DataSource;
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
                            // 強力檢查空值和型別
                            object planStart = row["PlanStart"];
                            object planEnd = row["PlanEnd"];
                            object instruction = row["Instruction"];

                            // 跳過完全空白行
                            if (row["OrderID"] == DBNull.Value ||
                                planStart == DBNull.Value || planStart == null || planStart.ToString().Trim() == "" ||
                                planEnd == DBNull.Value || planEnd == null || planEnd.ToString().Trim() == "" ||
                                instruction == DBNull.Value || instruction == null || instruction.ToString().Trim() == "")
                            {
                                continue;
                            }

                            // 轉型，確保一定係 DateTime
                            DateTime planStartDate, planEndDate;
                            if (!DateTime.TryParse(planStart.ToString(), out planStartDate) ||
                                !DateTime.TryParse(planEnd.ToString(), out planEndDate))
                            {
                                MessageBox.Show("請輸入正確的日期格式！");
                                continue;
                            }

                            string query = "INSERT INTO PD_OrderPlan ([OrderID], [PlanStart], [PlanEnd], [Instruction]) VALUES (?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["OrderID"].ToString());
                                cmd.Parameters.AddWithValue("?", planStartDate);
                                cmd.Parameters.AddWithValue("?", planEndDate);
                                cmd.Parameters.AddWithValue("?", instruction.ToString());
                                cmd.ExecuteNonQuery();
                            }
                        }
                        // 如有需要，這裡可以加修改邏輯
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrderPlanTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Add4_Click(object sender, EventArgs e)
        {
            if (orderPlanDataTable == null)
            {
                MessageBox.Show("生產計劃資料未載入。");
                return;
            }

            string orderId = dataGridView2.CurrentRow?.Cells["OrderID"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(orderId))
            {
                MessageBox.Show("請先選擇訂單。");
                return;
            }

            DataRow newRow = orderPlanDataTable.NewRow();
            newRow["OrderID"] = orderId;

            // 將上面的輸入框值寫入新行
            newRow["PlanStart"] = startDateTimePicker.Value;
            newRow["PlanEnd"] = targetDateTimePicker.Value;
            newRow["Instruction"] = workInstructionsTextBox.Text.Trim();

            orderPlanDataTable.Rows.Add(newRow);

            // 清空輸入欄（選擇性）
            // workInstructionsTextBox.Text = "";
        }
        private void SetOrderPlanGridReadOnly()
        {
            if (dataGridView5.Columns.Contains("OPlanID"))
                dataGridView5.Columns["OPlanID"].ReadOnly = true;
            if (dataGridView5.Columns.Contains("OrderID"))
                dataGridView5.Columns["OrderID"].ReadOnly = true;
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.IsNewRow)
                return;

            var row = dataGridView2.CurrentRow;

            orderNumberTextBox.Text = row.Cells["OrderNumber"].Value?.ToString() ?? "";
            if (row.Cells["ODate"].Value != null && DateTime.TryParse(row.Cells["ODate"].Value.ToString(), out DateTime dt))
                selectedDate.Value = dt;
            else
                selectedDate.Value = DateTime.Now;

            productNameTextBox.Text = row.Cells["RefQuotation"].Value?.ToString() ?? "";
            productNumberTextBox.Text = row.Cells["ProductID"].Value?.ToString() ?? "";
            quantityTextBox.Text = row.Cells["Qty"].Value?.ToString() ?? "";
            remarkTextBox.Text = row.Cells["Remark"].Value?.ToString() ?? "";

            orderNumberTextBox.ReadOnly = true;
            selectedDate.Enabled = false;
            productNameTextBox.ReadOnly = true;
            productNumberTextBox.ReadOnly = true;
            quantityTextBox.ReadOnly = true;
            remarkTextBox.ReadOnly = true;

            var orderIDValue = row.Cells["OrderID"].Value;
            if (orderIDValue != null)
            {
                string orderID = orderIDValue.ToString();
                LoadMaterialTableByOrderID(orderID);
                LoadOrderStepTableByOrderID(orderID);
                LoadOrderPlanTableByOrderID(orderID);
                LoadOrderFileTableByOrderID(orderID);
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView3.DataSource = null;
                dataGridView5.DataSource = null;
                dataGridView4.DataSource = null;
            }

        }

        private void LoadMaterialTableByOrderID(string orderID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    // 用參數化查詢防止 SQL Injection
                    string sql = "SELECT MRFNo, MRFDate, Dept, Priority, ProductName, ProductSpec, DeliveryDate, Approver, Remark, OrderID " +
                                 "FROM PD_MaterialRequestForm WHERE OrderID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", orderID);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            materialDataTable = new DataTable();
                            adapter.Fill(materialDataTable);
                            dataGridView1.DataSource = materialDataTable;

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                if (!dataGridView1.Rows[i].IsNewRow)
                                    dataGridView1.Rows[i].HeaderCell.Value = $"Row {i + 1}";
                            }

                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView1.AllowUserToResizeColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to PD_MaterialRequestForm!\n" + ex.Message);
            }
        }

        private void LoadOrderStepTableByOrderID(string orderID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT OStepID, OrderID, ProcName, Staff, Note FROM PD_OrderStep WHERE OrderID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", orderID);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            processDataTable = new DataTable();
                            adapter.Fill(processDataTable);
                            dataGridView3.DataSource = processDataTable;

                            for (int i = 0; i < dataGridView3.Rows.Count; i++)
                            {
                                if (!dataGridView3.Rows[i].IsNewRow)
                                    dataGridView3.Rows[i].HeaderCell.Value = $"Row {i + 1}";
                            }

                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView3.AllowUserToResizeColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to PD_OrderStep!\n" + ex.Message);
            }
        }
        private void LoadOrderPlanTableByOrderID(string orderID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT OPlanID, OrderID, PlanStart, PlanEnd, Instruction FROM PD_OrderPlan WHERE OrderID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", orderID);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            orderPlanDataTable = new DataTable();
                            adapter.Fill(orderPlanDataTable);
                            dataGridView5.DataSource = orderPlanDataTable;

                            for (int i = 0; i < dataGridView5.Rows.Count; i++)
                            {
                                if (!dataGridView5.Rows[i].IsNewRow)
                                    dataGridView5.Rows[i].HeaderCell.Value = $"Row {i + 1}";
                            }

                            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView5.AllowUserToResizeColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to PD_OrderPlan!\n" + ex.Message);
            }
        }
        private void LoadOrderFileTableByOrderID(string orderID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT OFID, OrderID, FileName, UploadedBy, UploadDate, FilePath FROM SMD_OrderFile WHERE OrderID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", orderID);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            requsetDataTable = new DataTable();
                            adapter.Fill(requsetDataTable);
                            dataGridView4.DataSource = requsetDataTable;

                            for (int i = 0; i < dataGridView4.Rows.Count; i++)
                            {
                                if (!dataGridView4.Rows[i].IsNewRow)
                                    dataGridView4.Rows[i].HeaderCell.Value = $"Row {i + 1}";
                            }

                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView4.AllowUserToResizeColumns = false;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to SMD_OrderFile!\n" + ex.Message);
            }
        }

        // 設定 OStepID、OrderID 唔俾改
        private void SetProcessGridReadOnly()
        {
            if (dataGridView3.Columns.Contains("OStepID"))
                dataGridView3.Columns["OStepID"].ReadOnly = true;
            if (dataGridView3.Columns.Contains("OrderID"))
                dataGridView3.Columns["OrderID"].ReadOnly = true;
        }
        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 檢查是否點擊到 FilePath 欄
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var dgv = dataGridView4;
            var col = dgv.Columns[e.ColumnIndex];

            if (col.Name == "FilePath")
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "選擇上傳檔案";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string sourcePath = ofd.FileName;
                        string fileName = Path.GetFileName(sourcePath);

                        // 建議：存入 App資料夾下 \Uploads\OrderID\ 子資料夾
                        string orderId = dgv.Rows[e.RowIndex].Cells["OrderID"].Value?.ToString();
                        string targetFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads", orderId ?? "UnknownOrder");
                        if (!Directory.Exists(targetFolder))
                            Directory.CreateDirectory(targetFolder);

                        string targetPath = Path.Combine(targetFolder, fileName);

                        // 防止覆蓋同名檔案
                        int idx = 1;
                        string baseName = Path.GetFileNameWithoutExtension(fileName);
                        string ext = Path.GetExtension(fileName);
                        while (File.Exists(targetPath))
                        {
                            targetPath = Path.Combine(targetFolder, $"{baseName}({idx++}){ext}");
                        }

                        try
                        {
                            File.Copy(sourcePath, targetPath);
                            // 直接寫入 DataGridView（DataTable 也跟住更新）
                            dgv.Rows[e.RowIndex].Cells["FilePath"].Value = targetPath;
                            // 你可選擇自動填 FileName
                            if (string.IsNullOrWhiteSpace(dgv.Rows[e.RowIndex].Cells["FileName"].Value?.ToString()))
                                dgv.Rows[e.RowIndex].Cells["FileName"].Value = fileName;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("檔案複製失敗：" + ex.Message);
                        }
                    }
                }
            }
        }
        private void RepairSupportTable()
        {
            throw new NotImplementedException();
        }

        private void ProductionOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword(this, connStr);
            changePasswordForm.Username = Username;
            changePasswordForm.DepartmentName = DepartmentName;
            changePasswordForm.ShowDialog();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
