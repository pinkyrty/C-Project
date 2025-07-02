using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic.ApplicationServices;
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
        private static System.Data.DataTable userManDataTable;
        private static System.Data.DataTable repairSupportDataTable;
        private static System.Data.DataTable assetManDataTable;
        private static System.Data.DataTable MaintenanceLogDataTable;

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

                    string sql = "SELECT UserID, [Username], [Password], Department, FullName, Active FROM Login_User";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            userManDataTable = new System.Data.DataTable();
                            adapter.Fill(userManDataTable);

                            if (userManDataTable.Columns["Active"].DataType != typeof(bool))
                            {
                                userManDataTable.Columns["Active"].DataType = typeof(bool);
                            }

                            dataGridView1.DataSource = userManDataTable;

                            if (dataGridView1.Columns.Count >= 6)
                            {
                                dataGridView1.Columns[1].HeaderText = "User Name";
                                dataGridView1.Columns[2].HeaderText = "Password";
                                dataGridView1.Columns[3].HeaderText = "Department";
                                dataGridView1.Columns[4].HeaderText = "Full Name";
                                dataGridView1.Columns[5].HeaderText = "Active";
                                dataGridView1.Columns[5].Width = 100;
                                dataGridView1.Columns["UserID"].ReadOnly = true;
                            }
                            else
                            {
                                Console.WriteLine($"Expected at least 6 columns, but got: {dataGridView1.Columns.Count}");
                            }

                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.AllowUserToResizeColumns = false;
                            dataGridView1.ReadOnly = false;
                            dataGridView1.AllowUserToAddRows = true;
                            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
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

        //Third Tab
        private void RepairSupportTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT ID, TicketNo, Title, Submitter, Status, CreateDate FROM IT_Ticket";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            repairSupportDataTable = new System.Data.DataTable();
                            adapter.Fill(repairSupportDataTable);
                            dataGridView2.DataSource = repairSupportDataTable;

                            if (dataGridView2.Columns.Count >= 6)
                            {
                                dataGridView2.Columns[1].HeaderText = "Ticket No";
                                dataGridView2.Columns[2].HeaderText = "Title";
                                dataGridView2.Columns[3].HeaderText = "Submitter";
                                dataGridView2.Columns[4].HeaderText = "Status";
                                dataGridView2.Columns[5].HeaderText = "Created Date";
                                dataGridView2.ReadOnly = true;

                                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dataGridView2.AllowUserToResizeColumns = false;
                                dataGridView2.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                                clearInputData();
                            }
                            else
                            {
                                Console.WriteLine($"Expected at least 6 columns, but got: {dataGridView2.Columns.Count}");
                            }
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
                            repairSupportDataTable = new System.Data.DataTable();
                            adapter.Fill(repairSupportDataTable);
                            dataGridView3.DataSource = repairSupportDataTable;

                            if (dataGridView3.Columns.Count >= 5)
                            {
                                dataGridView3.Columns[1].HeaderText = "Asset No";
                                dataGridView3.Columns[2].HeaderText = "Name";
                                dataGridView3.Columns[3].HeaderText = "Type";
                                dataGridView3.Columns[4].HeaderText = "Status";
                                dataGridView3.ReadOnly = true;

                                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dataGridView3.AllowUserToResizeColumns = false;
                                dataGridView3.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                                clearInputData();
                            }
                            else
                            {
                                Console.WriteLine($"Expected at least 5 columns, but got: {dataGridView2.Columns.Count}");
                            }
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
                            MaintenanceLogDataTable = new System.Data.DataTable();
                            adapter.Fill(MaintenanceLogDataTable);
                            dataGridView4.DataSource = MaintenanceLogDataTable;
                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            ChangePassword changePasswordForm = new ChangePassword(this, connStr);
            changePasswordForm.Username = Username;
            changePasswordForm.DepartmentName = DepartmentName;
            changePasswordForm.ShowDialog();
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
                System.Windows.Forms.Application.Exit();
            }
        }

        //Department Entrance
        private void RnDbutton_Click(object sender, EventArgs e)
        {
            RnD_Form rndForm = new RnD_Form();
            rndForm.Username = this.Username;
            rndForm.DepartmentName = this.DepartmentName;
            rndForm.Show();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            Sales_MarketingForm smdForm = new Sales_MarketingForm();
            smdForm.Username = this.Username;
            smdForm.DepartmentName = this.DepartmentName;
            smdForm.Show();
        }
        private void LogisticButton_Click(object sender, EventArgs e)
        {
            LogisticTrackingForm DTForm = new LogisticTrackingForm();
            DTForm.Username = this.Username;
            DTForm.DepartmentName = this.DepartmentName;
            DTForm.Show();
        }

        private void ProductionButton_Click(object sender, EventArgs e)
        {
            ProductionOrderForm pdForm = new ProductionOrderForm();
            pdForm.Username = this.Username;
            pdForm.DepartmentName = this.DepartmentName;
            pdForm.Show();
        }

        private void SupplyChainButton_Click(object sender, EventArgs e)
        {
            LogisticForm scmForm = new LogisticForm();
            scmForm.Username = this.Username;
            scmForm.DepartmentName = this.DepartmentName;
            scmForm.Show();
        }

        private void CustomerServiceButton_Click(object sender, EventArgs e)
        {
            CustomerServiceForm csdForm = new CustomerServiceForm();
            csdForm.Username = this.Username;
            csdForm.DepartmentName = this.DepartmentName;
            csdForm.Show();
        }

        private void FinanceButton_Click(object sender, EventArgs e)
        {
            FinanceDepartment fiForm = new FinanceDepartment();
            fiForm.Username = this.Username;
            fiForm.DepartmentName = this.DepartmentName;
            fiForm.Show();
        }

        private void btn_UserAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = userManDataTable.NewRow();

            newRow["Username"] = "";
            newRow["Password"] = "";
            newRow["Department"] = 0;
            newRow["FullName"] = "";
            newRow["Active"] = false;

            userManDataTable.Rows.Add(newRow);
        }
        private void btn_UserSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();

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
                            string query = "INSERT INTO Login_User (Username, [Password], Department, FullName, Active) VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["Username"] != DBNull.Value ? row["Username"] : "";
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["Password"] != DBNull.Value ? row["Password"] : "";
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["Department"] != DBNull.Value ? row["Department"] : "";
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["FullName"] != DBNull.Value ? row["FullName"] : "";
                                cmd.Parameters.Add("?", OleDbType.Boolean).Value = row["Active"] != DBNull.Value ? Convert.ToBoolean(row["Active"]) : false;

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE Login_User SET Username = ?, [Password] = ?, Department = ?, FullName = ?, Active = ? WHERE UserID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["Username"] != DBNull.Value ? row["Username"] : "";
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["Password"] != DBNull.Value ? row["Password"] : "";
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["Department"] != DBNull.Value ? row["Department"] : "";
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["FullName"] != DBNull.Value ? row["FullName"] : "";
                                cmd.Parameters.Add("?", OleDbType.Boolean).Value = row["Active"] != DBNull.Value ? Convert.ToBoolean(row["Active"]) : false;
                                cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(row["UserID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserManTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_RepairAdd_Click(object sender, EventArgs e)
        {
            string repairTicketNo = repairTicketNoText.Text.Trim();
            string repairSubject = repairSubjectText.Text.Trim();
            string repairSub = Username;
            string repairStatus = repairStatusCombo.Text.Trim();

            if (string.IsNullOrEmpty(repairTicketNo) || string.IsNullOrEmpty(repairSubject) ||
            string.IsNullOrEmpty(repairSub) || string.IsNullOrEmpty(repairStatus))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string query = "INSERT INTO IT_Ticket (TicketNo, Title, Submitter, Status, CreateDate) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = repairTicketNo;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = repairSubject;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = repairSub;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = repairStatus;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Today;

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

        private void clearInputData()
        {
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
            repairTicketNoText.Text = "";
            repairSubjectText.Text = "";
            repairSubText.Text = "";
            repairStatusCombo.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                repairTicketNoText.Text = row.Cells["TicketNo"].Value?.ToString() ?? "";
                repairSubjectText.Text = row.Cells["Title"].Value?.ToString() ?? "";
                repairSubText.Text = row.Cells["Submitter"].Value?.ToString() ?? "";
                repairStatusCombo.Text = row.Cells["Status"].Value?.ToString() ?? "";
            }
        }

        private void btn_RepairSave_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count != 1)
            {
                MessageBox.Show("Please select a row to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewCell selectedCell = dataGridView2.SelectedCells[0];
            DataGridViewRow row = selectedCell.OwningRow;
            string ticketId = row.Cells["ID"].Value.ToString() ?? "";

            string repairTicketNo = repairTicketNoText.Text.Trim();
            string repairSubject = repairSubjectText.Text.Trim();
            string repairSub = Username ?? "Unknown";
            string repairStatus = repairStatusCombo.Text.Trim();

            if (string.IsNullOrEmpty(repairTicketNo) || string.IsNullOrEmpty(repairSubject) ||
                string.IsNullOrEmpty(repairSub) || string.IsNullOrEmpty(repairStatus))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(repairTicketNo + repairSubject + repairSub + repairStatus);
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string query = "UPDATE IT_Ticket SET TicketNo = ?, Title = ?, Submitter = ?, Status = ? WHERE ID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = repairTicketNo;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = repairSubject;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = repairSub;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = repairStatus;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = ticketId;


                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No record was updated. Please check if the ticket ID exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        clearInputData();
                    }

                    conn.Close();
                }

                RepairSupportTable();
                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AssetSave_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedCells.Count != 1)
            {
                MessageBox.Show("Please select a row to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewCell selectedCell = dataGridView3.SelectedCells[0];
            DataGridViewRow row = selectedCell.OwningRow;
            string assetId = row.Cells["ID"].Value.ToString() ?? "";

            string assetNumber = assetNumberText.Text.Trim();
            string assetName = assetNameText.Text.Trim();
            string assetType = assetTypeText.Text.Trim();
            string assetStatus = assetStatusCombo.Text.Trim();

            if (string.IsNullOrEmpty(assetNumber) || string.IsNullOrEmpty(assetName) ||
                string.IsNullOrEmpty(assetType) || string.IsNullOrEmpty(assetStatus))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string query = "UPDATE IT_Asset SET AssetNo = ?, Name = ?, Type = ?, Status = ? WHERE ID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = assetNumber;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = assetName;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = assetType;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = assetStatus;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = assetId;


                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No record was updated. Please check if the ticket ID exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        clearInputData();
                    }

                    conn.Close();
                }

                AssetManTable();
                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView3.Rows.Count)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                assetNumberText.Text = row.Cells["AssetNo"].Value?.ToString() ?? "";
                assetNameText.Text = row.Cells["Name"].Value?.ToString() ?? "";
                assetTypeText.Text = row.Cells["Type"].Value?.ToString() ?? "";
                assetStatusCombo.Text = row.Cells["Status"].Value?.ToString() ?? "";
            }
        }

        private void btn_AssetAdd_Click(object sender, EventArgs e)
        {
            string assetNumber = assetNumberText.Text.Trim();
            string assetName = assetNameText.Text.Trim();
            string assetType = assetTypeText.Text.Trim();
            string assetStatus = assetStatusCombo.Text.Trim();

            if (string.IsNullOrEmpty(assetNumber) || string.IsNullOrEmpty(assetName) ||
            string.IsNullOrEmpty(assetType) || string.IsNullOrEmpty(assetStatus))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string query = "INSERT INTO IT_Asset (AssetNo, Name, Type, Status) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = assetNumber;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = assetName;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = assetType;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = assetStatus;

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                AssetManTable();

                MessageBox.Show("Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView3.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding risk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
