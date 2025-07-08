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

                    string sql = "SELECT OrderID, ODate, RefQuotation, Qty FROM SMD_ProdOrder";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dataGridView2.AllowUserToResizeColumns = false;
                            dataGridView2.AllowUserToAddRows = true;
                            dataGridView2.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            orderStepDataTable = new DataTable();
                            adapter.Fill(orderStepDataTable);
                            dataGridView2.DataSource = orderStepDataTable;
                            dataGridView2.Rows[0].HeaderCell.Value = "Row 1";
                            dataGridView2.Rows[1].HeaderCell.Value = "Row 2";
                            dataGridView2.Rows[2].HeaderCell.Value = "Row 3";
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView2.AllowUserToResizeColumns = false;
                            MessageBox.Show("first Tab", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            dataGridView2.Rows[0].HeaderCell.Value = "Row 1";
                            dataGridView2.Rows[1].HeaderCell.Value = "Row 2";
                            dataGridView2.Rows[2].HeaderCell.Value = "Row 3";
                            dataGridView2.Rows[3].HeaderCell.Value = "Row 4";
                            dataGridView2.Rows[4].HeaderCell.Value = "Row 5";
                            dataGridView2.Rows[5].HeaderCell.Value = "Row 6";
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView1.AllowUserToResizeColumns = false;
                            MessageBox.Show("second Tab", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            dataGridView3.Columns[1].HeaderText = "OrderID";
                            dataGridView3.Columns[2].HeaderText = "ProcName";
                            dataGridView3.Columns[3].HeaderText = "Staff";
                            dataGridView3.Columns[4].HeaderText = "Note";
                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView3.AllowUserToResizeColumns = false;
                            MessageBox.Show("third Tab", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            dataGridView2.AllowUserToResizeColumns = false;
                            dataGridView2.AllowUserToAddRows = true;
                            dataGridView2.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            requsetDataTable = new DataTable();
                            adapter.Fill(requsetDataTable);
                            dataGridView4.DataSource = requsetDataTable;
                            dataGridView4.Columns[1].HeaderText = "FileName";
                            dataGridView4.Columns[2].HeaderText = "UploadedBy";
                            dataGridView4.Columns[3].HeaderText = "UploadDate";
                            dataGridView4.Columns[4].HeaderText = "FilePath";
                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView4.AllowUserToResizeColumns = false;
                            MessageBox.Show("fourth Tab", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    string sql = "SELECT * FROM PD_OrderPlan";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dataGridView5.AllowUserToResizeColumns = false;
                            dataGridView5.AllowUserToAddRows = true;
                            dataGridView5.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            orderPlanDataTable = new DataTable();
                            adapter.Fill(orderPlanDataTable);
                            dataGridView5.DataSource = orderPlanDataTable;
                            dataGridView5.Columns[1].HeaderText = "PlanStart";
                            dataGridView5.Columns[2].HeaderText = "PlanEnd";
                            dataGridView5.Columns[3].HeaderText = "Instruction";
                            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView5.AllowUserToResizeColumns = false;
                            MessageBox.Show("7 Tab", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //LoadOrderStepTable();
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
                            string query = "INSERT INTO SMD_ProdOrder (ODate, RefQuotation, Qty) VALUES (?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ODate"] != DBNull.Value ? row["ODate"] : "");
                                cmd.Parameters.AddWithValue("?", row["RefQuotation"] != DBNull.Value ? row["RefQuotation"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : 0);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE SMD_ProdOrder SET  ODate = ?, RefQuotation = ?, Qty = ? WHERE OrderID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ODate"] != DBNull.Value ? row["ODate"] : "");
                                cmd.Parameters.AddWithValue("?", row["RefQuotation"] != DBNull.Value ? row["RefQuotation"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : "");
                                cmd.Parameters.AddWithValue("?", row["OrderID"]);


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
            DataRow newRow = orderStepDataTable.NewRow();

            newRow["ODate"] = "";
            newRow["RefQuotation"] = "";
            newRow["Qty"] = "";

            orderStepDataTable.Rows.Add(newRow);
        }

        private void btn_Save1_Click(object sender, EventArgs e)
        {
            //LoadProcessTable
            try
            {
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
                            string query = "INSERT INTO PD_OrderStep (OrderID, ProcName, Staff, Note) VALUES (?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["OrderID"] != DBNull.Value ? row["OrderID"] : "");
                                cmd.Parameters.AddWithValue("?", row["ProcName"] != DBNull.Value ? row["ProcName"] : "");
                                cmd.Parameters.AddWithValue("?", row["Staff"] != DBNull.Value ? row["Staff"] : "");
                                cmd.Parameters.AddWithValue("?", row["Note"] != DBNull.Value ? row["Note"] : "");
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE PD_OrderStep SET  OrderID = ?, ProcName = ?, Staff = ?, Note = ? WHERE OStepID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["OrderID"] != DBNull.Value ? row["OrderID"] : "");
                                cmd.Parameters.AddWithValue("?", row["ProcName"] != DBNull.Value ? row["ProcName"] : "");
                                cmd.Parameters.AddWithValue("?", row["Staff"] != DBNull.Value ? row["Staff"] : "");
                                cmd.Parameters.AddWithValue("?", row["Note"] != DBNull.Value ? row["Note"] : "");
                                cmd.Parameters.AddWithValue("?", row["OStepID"]);


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

        private void btn_Add1_Click(object sender, EventArgs e)
        {
            DataRow newRow = processDataTable.NewRow();

            newRow["OrderID"] = "";
            newRow["ProcName"] = "";
            newRow["Staff"] = "";
            newRow["Note"] = "";

            processDataTable.Rows.Add(newRow);
        }

        private void btn_Save2_Click(object sender, EventArgs e)
        {
            //LoadRequestTable
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
                            string query = "INSERT INTO SMD_OrderFile (FileName, UploadedBy, UploadDate, FilePath) VALUES (?, ?, ?, ?)";
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
                            string query = "UPDATE SMD_OrderFile SET  FileName = ?, UploadedBy = ?, UploadDate = ?, FilePath = ? WHERE OFID = ?";
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
            DataRow newRow = requsetDataTable.NewRow();

            newRow["FileName"] = "";
            newRow["UploadedBy"] = "";
            newRow["UploadDate"] = "";
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
            DataRow newRow = requsetDataTable.NewRow();

            newRow["MRFNo"] = "";
            newRow["ProductName"] = "";
            newRow["ProductSpec"] = "";
            newRow["DeliveryDate"] = "";
            newRow["CreateDate"] = "";
            newRow["Approver"] = "";
            newRow["Remark"] = "";

            requsetDataTable.Rows.Add(newRow);
        }
        private void btn_Save4_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = startDateTimePicker.Value;
            DateTime targetDateTime = targetDateTimePicker.Value;
            string workInstructionsText = workInstructionsTextBox.Text.Trim();

            if (string.IsNullOrEmpty(workInstructionsText))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string query = "INSERT INTO PD_OrderPlan (PlanStart, PlanEnd, Instruction) VALUES (?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = this.startDateTimePicker;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = this.targetDateTimePicker;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = quantityTextBox;

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
