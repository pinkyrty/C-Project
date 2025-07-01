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
    public partial class LogisticForm : Form
    {
        public string DepartmentName { get; set; }
        public string Username { get; set; }
        private string connStr;
        private static DataTable logisticInventoryRecordDataTable;
        private static DataTable logisticProcurementDataTable;
        private static DataTable logisticTransferDataTable;
        private static DataTable logisticForecastDataTable;
        private static DataTable logisticSupplierDataTable;
        public LogisticForm()
        {
            InitializeComponent();
            string projectRoot = Directory.GetCurrentDirectory();
            if (projectRoot.Contains("bin\\Debug"))
            {
                projectRoot = Directory.GetParent(projectRoot).Parent.Parent.FullName;
            }
            string dbPath = Path.Combine(projectRoot, "ToySystem.accdb");
            connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

            this.LoadLogisticInventoryRecordTable();
            this.LoadLogisticProcurementTable();
            this.LoadLogisticTransferTable();
            this.LoadLogisticForecastTable();
            this.LoadLogistiSupplierTable();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }
        //Record
        private void LoadLogisticInventoryRecordTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SCM_StockTrans";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticInventoryRecordDataTable = new DataTable();
                            adapter.Fill(logisticInventoryRecordDataTable);
                            dataGridView4.DataSource = logisticInventoryRecordDataTable;
                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView4.Columns["TransID"].ReadOnly = true;
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
        //second tab
        private void LoadLogisticProcurementTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SCM_PODetail";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticProcurementDataTable = new DataTable();
                            adapter.Fill(logisticProcurementDataTable);
                            dataGridView5.DataSource = logisticProcurementDataTable;
                            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView5.Columns["PODetailID"].ReadOnly = true;
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
        //Third tab
        private void LoadLogisticTransferTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SCM_TransferDetail";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticTransferDataTable = new DataTable();
                            adapter.Fill(logisticTransferDataTable);
                            dataGridView6.DataSource = logisticTransferDataTable;
                            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView6.AllowUserToResizeColumns = false;
                            dataGridView6.Columns["TransDetailID"].ReadOnly = true;
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
        //fourth 
        private void LoadLogisticForecastTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SCM_Forecast";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticForecastDataTable = new DataTable();
                            adapter.Fill(logisticForecastDataTable);
                            dataGridView7.DataSource = logisticForecastDataTable;
                            dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView7.AllowUserToResizeColumns = false;
                            dataGridView7.Columns["ForecastID"].ReadOnly = true;
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
        //fifth
        private void LoadLogistiSupplierTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SCM_Supplier";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticSupplierDataTable = new DataTable();
                            adapter.Fill(logisticSupplierDataTable);
                            dataGridView8.DataSource = logisticSupplierDataTable;
                            dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView8.AllowUserToResizeColumns = false;
                            dataGridView8.Columns["SupplierID"].ReadOnly = true;
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
        private void LogisticForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbOperation_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void btn_Save7_Click(object sender, EventArgs e)
        {
            //RecordTable();
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
                            string query = "INSERT INTO SCM_StockTrans (Time, Optype, MaterialID, Qty, Warehouse, Remark) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["Time"] != DBNull.Value ? row["Time"] : "");
                                cmd.Parameters.AddWithValue("?", row["Optype"] != DBNull.Value ? row["Optype"] : "");
                                cmd.Parameters.AddWithValue("?", row["MaterialID"] != DBNull.Value ? row["MaterialID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : "");
                                cmd.Parameters.AddWithValue("?", row["Warehouse"] != DBNull.Value ? row["Warehouse"] : "");
                                cmd.Parameters.AddWithValue("?", row["Remark"] != DBNull.Value ? row["Remark"] : "");
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE SCM_StockTrans SET Time = ?, Optype = ?, MaterialID = ?, Qty = ?, Warehouse = ?, Remark = ? WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["Time"] != DBNull.Value ? row["Time"] : "");
                                cmd.Parameters.AddWithValue("?", row["Optype"] != DBNull.Value ? row["Optype"] : "");
                                cmd.Parameters.AddWithValue("?", row["MaterialID"] != DBNull.Value ? row["MaterialID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : "");
                                cmd.Parameters.AddWithValue("?", row["Warehouse"] != DBNull.Value ? row["Warehouse"] : "");
                                cmd.Parameters.AddWithValue("?", row["Remark"] != DBNull.Value ? row["Remark"] : "");
                                cmd.Parameters.AddWithValue("?", row["TransID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView4.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add1_Click(object sender, EventArgs e)
        {
            DataRow newRow = logisticInventoryRecordDataTable.NewRow();

            newRow["Time"] = "";
            newRow["Optype"] = "";
            newRow["MaterialID"] = "";
            newRow["Qty"] = "";
            newRow["Warehouse"] = "";
            newRow["Remark"] = "";

            logisticInventoryRecordDataTable.Rows.Add(newRow);
        }
        //suppliertable
        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = (DataTable)dataGridView8.DataSource;
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
                            string query = "INSERT INTO SCM_Supplier (Name, Contact, Phone, Email, Rating) VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["Name"] != DBNull.Value ? row["Name"] : "");
                                cmd.Parameters.AddWithValue("?", row["Contact"] != DBNull.Value ? row["Contact"] : "");
                                cmd.Parameters.AddWithValue("?", row["Phone"] != DBNull.Value ? row["Phone"] : "");
                                cmd.Parameters.AddWithValue("?", row["Email"] != DBNull.Value ? row["Email"] : "");
                                cmd.Parameters.AddWithValue("?", row["Rating"] != DBNull.Value ? row["Rating"] : "");
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE SCM_Supplier SET Name = ?, Contact = ?, Phone = ?, Email = ?, Rating = ? WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["Name"] != DBNull.Value ? row["Name"] : "");
                                cmd.Parameters.AddWithValue("?", row["Contact"] != DBNull.Value ? row["Contact"] : "");
                                cmd.Parameters.AddWithValue("?", row["Phone"] != DBNull.Value ? row["Phone"] : "");
                                cmd.Parameters.AddWithValue("?", row["Email"] != DBNull.Value ? row["Email"] : "");
                                cmd.Parameters.AddWithValue("?", row["Rating"] != DBNull.Value ? row["Rating"] : "");
                                cmd.Parameters.AddWithValue("?", row["TransID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView4.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataRow newRow = logisticInventoryRecordDataTable.NewRow();

            newRow["Time"] = "";
            newRow["Optype"] = "";
            newRow["MaterialID"] = "";
            newRow["Qty"] = "";
            newRow["Warehouse"] = "";
            newRow["Remark"] = "";

            logisticInventoryRecordDataTable.Rows.Add(newRow);
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

        private void btn_Add4_Click(object sender, EventArgs e)
        {

        }
    }
}
