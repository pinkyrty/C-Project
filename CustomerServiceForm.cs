using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
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
            // 設置 DataGridView 的選擇模式
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.EnableHeadersVisualStyles = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }

        private void LoadInteractionLogTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string sql = "SELECT ID, Date, Time, CustomerName, Channel, InquiryType, Staff, Summary, Status, Solution, FollowUp, Feedback FROM CSD_InteractionLog";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            interactionLogDataTable = new DataTable();
                            adapter.Fill(interactionLogDataTable);

                            dataGridView1.DataSource = interactionLogDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.ReadOnly = true;

                            dataGridView1.Columns["ID"].Visible = true;
                            dataGridView1.Columns["Date"].Visible = true;
                            dataGridView1.Columns["CustomerName"].Visible = true;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                if (column.Name != "ID" && column.Name != "Date" && column.Name != "CustomerName")
                                {
                                    column.Visible = false;
                                }
                            }
                        }
                    }

                    conn.Close();

                    //if (interactionLogDataTable.Rows.Count == 0)
                    //{
                    //    MessageBox.Show("No data found in CSD_InteractionLog table.");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database!\n" + ex.Message + "\nStackTrace: " + ex.StackTrace);
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
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dataGridView2.AllowUserToResizeColumns = false;
                            dataGridView2.AllowUserToAddRows = true;
                            dataGridView2.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            returnDataTable = new DataTable();
                            adapter.Fill(returnDataTable);
                            dataGridView2.DataSource = returnDataTable;
                            dataGridView2.Columns[1].HeaderText = "ApplyDate";
                            dataGridView2.Columns[2].HeaderText = "CustomerName";
                            dataGridView2.Columns[3].HeaderText = "Product";
                            dataGridView2.Columns[4].HeaderText = "Reason";
                            dataGridView2.Columns[5].HeaderText = "Status";
                            dataGridView2.Columns[6].HeaderText = "Remark";
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //InsertBudgetTable();
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
                            string query = "INSERT INTO CSD_RefundCase (ApplyDate, CustomerName, Product, Reason, Status, Remark) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ApplyDate"] != DBNull.Value ? row["ApplyDate"] : "");
                                cmd.Parameters.AddWithValue("?", row["CustomerName"] != DBNull.Value ? row["CustomerName"] : "");
                                cmd.Parameters.AddWithValue("?", row["Product"] != DBNull.Value ? row["Product"] : "");
                                cmd.Parameters.AddWithValue("?", row["Reason"] != DBNull.Value ? row["Reason"] : "");
                                cmd.Parameters.AddWithValue("?", row["Status"] != DBNull.Value ? row["Status"] : "");
                                cmd.Parameters.AddWithValue("?", row["Remark"] != DBNull.Value ? row["Remark"] : "");

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE CSD_RefundCase SET ApplyDate = ?, CustomerName = ?, Product = ?, Reason = ?, Status = ?, Remark = ? WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ApplyDate"] != DBNull.Value ? row["ApplyDate  "] : "");
                                cmd.Parameters.AddWithValue("?", row["CustomerName"] != DBNull.Value ? row["CustomerName"] : "");
                                cmd.Parameters.AddWithValue("?", row["Product"] != DBNull.Value ? row["Product"] : "");
                                cmd.Parameters.AddWithValue("?", row["Reason"] != DBNull.Value ? row["Reason"] : "");
                                cmd.Parameters.AddWithValue("?", row["Status"] != DBNull.Value ? row["Status"] : "");
                                cmd.Parameters.AddWithValue("?", row["Remark"] != DBNull.Value ? row["Remark"] : "");
                                cmd.Parameters.AddWithValue("?", row["ID"]);

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataRow newRow = returnDataTable.NewRow();

            newRow["ApplyDate"] = "";
            newRow["CustomerName"] = "";
            newRow["Product"] = "";
            newRow["Reason"] = "";
            newRow["Status"] = "";
            newRow["Remark"] = "";

            returnDataTable.Rows.Add(newRow);
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
                Login.OpenDepartmentForm(loginForm);
            }
            else
            {
                Application.Exit();
            }
        }

        private void RaDUserPrifileButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword(this);
            changePasswordForm.Username = Username;
            changePasswordForm.DepartmentName = DepartmentName;
            changePasswordForm.ShowDialog();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Selected = false;
                }
                dataGridView1.Rows[e.RowIndex].Selected = true;

                DataRow rowData = interactionLogDataTable.Rows[e.RowIndex];

                try
                {
                    Debug.WriteLine($"Selected Row Data: {rowData["Date"]}, {rowData["Time"]}, {rowData["CustomerName"]}");

                    dateTimePicker1.Value = rowData["Date"] != DBNull.Value && DateTime.TryParse(rowData["Date"].ToString(), out DateTime date)
                        ? date
                        : DateTime.Now;

                    timeText.Text = rowData["Time"] != DBNull.Value ? rowData["Time"].ToString() : "";
                    customerNameText.Text = rowData["CustomerName"] != DBNull.Value ? rowData["CustomerName"].ToString() : "";
                    contactInfoCombo.Text = rowData["Channel"] != DBNull.Value ? rowData["Channel"].ToString() : "";
                    inquiryTypeCombo.Text = rowData["InquiryType"] != DBNull.Value ? rowData["InquiryType"].ToString() : "";
                    resPersonText.Text = rowData["Staff"] != DBNull.Value ? rowData["Staff"].ToString() : "";
                    contentSumText.Text = rowData["Summary"] != DBNull.Value ? rowData["Summary"].ToString() : "";
                    statusCombo.Text = rowData["Status"] != DBNull.Value ? rowData["Status"].ToString() : "";
                    solText.Text = rowData["Solution"] != DBNull.Value ? rowData["Solution"].ToString() : "";
                    followUpText.Text = rowData["FollowUp"] != DBNull.Value ? rowData["FollowUp"].ToString() : "";
                    customerFeedbackText.Text = rowData["Feedback"] != DBNull.Value ? rowData["Feedback"].ToString() : "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error populating controls: {ex.Message}");
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int id = Convert.ToInt32(interactionLogDataTable.Rows[selectedRowIndex]["ID"]);

                    using (OleDbConnection conn = new OleDbConnection(connStr))
                    {
                        conn.Open();

                        string updateQuery = "UPDATE CSD_InteractionLog SET " +
                                             "[Date] = ?, [Time] = ?, [CustomerName] = ?, [Channel] = ?, [InquiryType] = ?, " +
                                             "[Staff] = ?, [Summary] = ?, [Status] = ?, [Solution] = ?, [FollowUp] = ?, [Feedback] = ? " +
                                             "WHERE ID = ?";
                        using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.Add("Date", OleDbType.VarChar).Value = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                            updateCmd.Parameters.Add("Time", OleDbType.VarChar).Value = timeText.Text;
                            updateCmd.Parameters.Add("CustomerName", OleDbType.VarChar).Value = customerNameText.Text;
                            updateCmd.Parameters.Add("Channel", OleDbType.VarChar).Value = contactInfoCombo.Text;
                            updateCmd.Parameters.Add("InquiryType", OleDbType.VarChar).Value = inquiryTypeCombo.Text;
                            updateCmd.Parameters.Add("Staff", OleDbType.VarChar).Value = resPersonText.Text;
                            updateCmd.Parameters.Add("Summary", OleDbType.VarChar).Value = contentSumText.Text;
                            updateCmd.Parameters.Add("Status", OleDbType.VarChar).Value = statusCombo.Text;
                            updateCmd.Parameters.Add("Solution", OleDbType.VarChar).Value = solText.Text;
                            updateCmd.Parameters.Add("FollowUp", OleDbType.VarChar).Value = followUpText.Text;
                            updateCmd.Parameters.Add("Feedback", OleDbType.VarChar).Value = customerFeedbackText.Text;
                            updateCmd.Parameters.Add("ID", OleDbType.Integer).Value = id;

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Save successfully!");
                                LoadInteractionLogTable();
                                dataGridView1.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No rows were updated in the database.");
                            }
                        }

                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer service detail in database!\n" + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO CSD_InteractionLog ([Date], [Time], [CustomerName], [Channel], [InquiryType], [Staff], [Summary], [Status], [Solution], [FollowUp], [Feedback]) " +
                                         "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.Add("Date", OleDbType.VarChar).Value = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                        insertCmd.Parameters.Add("Time", OleDbType.VarChar).Value = timeText.Text;
                        insertCmd.Parameters.Add("CustomerName", OleDbType.VarChar).Value = customerNameText.Text;
                        insertCmd.Parameters.Add("Channel", OleDbType.VarChar).Value = contactInfoCombo.Text;
                        insertCmd.Parameters.Add("InquiryType", OleDbType.VarChar).Value = inquiryTypeCombo.Text;
                        insertCmd.Parameters.Add("Staff", OleDbType.VarChar).Value = resPersonText.Text;
                        insertCmd.Parameters.Add("Summary", OleDbType.VarChar).Value = contentSumText.Text;
                        insertCmd.Parameters.Add("Status", OleDbType.VarChar).Value = statusCombo.Text;
                        insertCmd.Parameters.Add("Solution", OleDbType.VarChar).Value = solText.Text;
                        insertCmd.Parameters.Add("FollowUp", OleDbType.VarChar).Value = followUpText.Text;
                        insertCmd.Parameters.Add("Feedback", OleDbType.VarChar).Value = customerFeedbackText.Text;

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New record added successfully!");
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("No rows were added to the database.");
                        }
                        }

                        conn.Close();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new record to database!\n" + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }
        }

        private void ClearInputFields()
        {
            dateTimePicker1.Value = DateTime.Now;
            timeText.Text = "";
            customerNameText.Text = "";
            contactInfoCombo.Text = "";
            inquiryTypeCombo.Text = "";
            resPersonText.Text = "";
            contentSumText.Text = "";
            statusCombo.Text = "";
            solText.Text = "";
            followUpText.Text = "";
            customerFeedbackText.Text = "";
        }
    }
}
