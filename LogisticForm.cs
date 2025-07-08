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

                    sql = "SELECT POID FROM SCM_PO";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticProcurementDataTable = new DataTable();
                            adapter.Fill(logisticProcurementDataTable);
                            dataGridView1.DataSource = logisticProcurementDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.Columns["POID"].ReadOnly = true;
                        }
                    }

                    sql = "SELECT DISTINCT SupplierID FROM SCM_PO";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox3.Items.Add(reader.GetString(0));
                            }
                        }

                        conn.Close();
                    }
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

                    sql = "SELECT TransferID FROM SCM_Transfer";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticTransferDataTable = new DataTable();
                            adapter.Fill(logisticTransferDataTable);
                            dataGridView2.DataSource = logisticTransferDataTable;
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView2.AllowUserToResizeColumns = false;
                            dataGridView2.Columns["TransferID"].ReadOnly = true;
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
        private void btn_Add4_Click(object sender, EventArgs e)
        {
            string InandOut = InOutCombo.Text.Trim();
            string Material = MaterialBox.Text.Trim();
            string Quantity = QuantityBox.Text.Trim();
            string Warehouse = WarehouseBox.Text.Trim();
            string Remark = RemarkBox.Text.Trim();

            if (string.IsNullOrEmpty(InandOut) || string.IsNullOrEmpty(Material) ||
    string.IsNullOrEmpty(Quantity) || string.IsNullOrEmpty(Warehouse))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string query = "INSERT INTO SCM_StockTrans ([Time], OpType, MaterialID, Qty, Warehouse, Remark) VALUES (?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Today;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = InandOut;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = Material;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = Quantity;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = Warehouse;
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = Remark;



                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                LoadLogisticInventoryRecordTable();

                MessageBox.Show("Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding risk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void clearInputData()
        {
            dataGridView4.ClearSelection();
            dataGridView4.CurrentCell = null;
            InOutCombo.Text = "";
            MaterialBox.Text = "";
            QuantityBox.Text = "";
            WarehouseBox.Text = "";
            RemarkBox.Text = "";
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
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView4.Rows.Count)
            {
                DataGridViewRow row = dataGridView4.Rows[e.RowIndex];

                InOutCombo.Text = row.Cells["OpType"].Value?.ToString() ?? "";
                MaterialBox.Text = row.Cells["MaterialID"].Value?.ToString() ?? "";
                QuantityBox.Text = row.Cells["Qty"].Value?.ToString() ?? "";
                WarehouseBox.Text = row.Cells["Warehouse"].Value?.ToString() ?? "";
                RemarkBox.Text = row.Cells["Remark"].Value?.ToString() ?? "";
            }
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
                            string query = "INSERT INTO SCM_Supplier (SupplierID, Name, Contact, Phone, Email, Rating) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                string supplierID = Guid.NewGuid().ToString();
                                cmd.Parameters.AddWithValue("?", supplierID);
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
                            string query = "UPDATE SCM_Supplier SET Name = ?, Contact = ?, Phone = ?, Email = ?, Rating = ? WHERE SupplierID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["Name"] != DBNull.Value ? row["Name"] : "");
                                cmd.Parameters.AddWithValue("?", row["Contact"] != DBNull.Value ? row["Contact"] : "");
                                cmd.Parameters.AddWithValue("?", row["Phone"] != DBNull.Value ? row["Phone"] : "");
                                cmd.Parameters.AddWithValue("?", row["Email"] != DBNull.Value ? row["Email"] : "");
                                cmd.Parameters.AddWithValue("?", row["Rating"] != DBNull.Value ? row["Rating"] : "");
                                cmd.Parameters.AddWithValue("?", row["SupplierID"]);

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
            DataRow newRow = logisticSupplierDataTable.NewRow();

            newRow["Time"] = "";
            newRow["Optype"] = "";
            newRow["MaterialID"] = "";
            newRow["Qty"] = "";
            newRow["Warehouse"] = "";
            newRow["Remark"] = "";

            logisticSupplierDataTable.Rows.Add(newRow);
        }
        //Forecasttable
        private void btn_Save1_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = (DataTable)dataGridView7.DataSource;
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
                            string query = "INSERT INTO SCM_Forecast (MaterialID, Period, Qty, Person, FDate) VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["MaterialID"] != DBNull.Value ? row["MaterialID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Period"] != DBNull.Value ? row["Period"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : "");
                                cmd.Parameters.AddWithValue("?", row["Person"] != DBNull.Value ? row["Person"] : "");
                                cmd.Parameters.AddWithValue("?", row["FDate"] != DBNull.Value ? row["FDate"] : "");
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE SCM_Forecast SET MaterialID = ?, Period = ?, Qty = ?, Person = ?, FDate = ? WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["MaterialID"] != DBNull.Value ? row["MaterialID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Period"] != DBNull.Value ? row["Period"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : "");
                                cmd.Parameters.AddWithValue("?", row["Person"] != DBNull.Value ? row["Person"] : "");
                                cmd.Parameters.AddWithValue("?", row["FDate"] != DBNull.Value ? row["FDate"] : "");
                                cmd.Parameters.AddWithValue("?", row["ForecastID"]);

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

        private void btn_Add8_Click(object sender, EventArgs e)
        {
            DataRow newRow = logisticForecastDataTable.NewRow();

            newRow["MaterialID"] = "";
            newRow["Period"] = "";
            newRow["Qty"] = "";
            newRow["Person"] = "";
            newRow["FDate"] = "";

            logisticForecastDataTable.Rows.Add(newRow);
        }
        //Transfertable
        private void btn_Save2_Click(object sender, EventArgs e)
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
                            string query = "INSERT INTO SCM_TransferDetail (TransferID, MaterialID, Desc, Spec, Type, Qty) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["TransferID"] != DBNull.Value ? row["TransferID"] : "");
                                cmd.Parameters.AddWithValue("?", row["MaterialID"] != DBNull.Value ? row["MaterialID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Desc"] != DBNull.Value ? row["Desc"] : "");
                                cmd.Parameters.AddWithValue("?", row["Spec"] != DBNull.Value ? row["Spec"] : "");
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : "");
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE SCM_TransferDetail SET MaterialID = ?, Period = ?, Qty = ?, Person = ?, FDate = ? WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["TransferID"] != DBNull.Value ? row["TransferID"] : "");
                                cmd.Parameters.AddWithValue("?", row["MaterialID"] != DBNull.Value ? row["MaterialID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Desc"] != DBNull.Value ? row["Desc"] : "");
                                cmd.Parameters.AddWithValue("?", row["Spec"] != DBNull.Value ? row["Spec"] : "");
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : "");
                                cmd.Parameters.AddWithValue("?", row["ForecastID"]);

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

        private void btn_Add7_Click(object sender, EventArgs e)
        {
            DataRow newRow = logisticTransferDataTable.NewRow();

            newRow["TransferID"] = "";
            newRow["MaterialID"] = "";
            newRow["Desc"] = "";
            newRow["Spec"] = "";
            newRow["Type"] = "";
            newRow["Qty"] = "";

            logisticTransferDataTable.Rows.Add(newRow);
        }
        //Procurementtable
        private void btn_Save3_Click(object sender, EventArgs e)
        {

            try
            {
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
                            string query = "INSERT INTO SCM_PODetail (POID, MaterialID, Spec, Qty, Price, SupplierID, PODate, ETA, Status) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["POID"] != DBNull.Value ? row["POID"] : "");
                                cmd.Parameters.AddWithValue("?", row["MaterialID"] != DBNull.Value ? row["MaterialID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Spec"] != DBNull.Value ? row["Spec"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : "");
                                cmd.Parameters.AddWithValue("?", row["Price"] != DBNull.Value ? row["Price"] : "");
                                cmd.Parameters.AddWithValue("?", row["SupplierID"] != DBNull.Value ? row["SupplierID"] : "");
                                cmd.Parameters.AddWithValue("?", row["PODate"] != DBNull.Value ? row["PODate"] : "");
                                cmd.Parameters.AddWithValue("?", row["ETA"] != DBNull.Value ? row["ETA"] : "");
                                cmd.Parameters.AddWithValue("?", row["Status"] != DBNull.Value ? row["Status"] : "");
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE SCM_PODetail SET POID = ?, MaterialID = ?, Spec = ?, Qty = ?, Price = ?, SupplierID = ?, PODate = ?, ETA = ?, Status = ? WHERE PODetailID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["POID"] != DBNull.Value ? row["POID"] : "");
                                cmd.Parameters.AddWithValue("?", row["MaterialID"] != DBNull.Value ? row["MaterialID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Spec"] != DBNull.Value ? row["Spec"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : "");
                                cmd.Parameters.AddWithValue("?", row["Price"] != DBNull.Value ? row["Price"] : "");
                                cmd.Parameters.AddWithValue("?", row["SupplierID"] != DBNull.Value ? row["SupplierID"] : "");
                                cmd.Parameters.AddWithValue("?", row["PODate"] != DBNull.Value ? row["PODate"] : "");
                                cmd.Parameters.AddWithValue("?", row["ETA"] != DBNull.Value ? row["ETA"] : "");
                                cmd.Parameters.AddWithValue("?", row["Status"] != DBNull.Value ? row["Status"] : "");
                                cmd.Parameters.AddWithValue("?", row["PODetailID"]);

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

        private void btn_Add5_Click(object sender, EventArgs e)
        {
            DataRow newRow = logisticProcurementDataTable.NewRow();

            newRow["POID"] = "";
            newRow["MaterialID"] = "";
            newRow["Spec"] = "";
            newRow["Qty"] = "";
            newRow["Price"] = "";
            newRow["SupplierID"] = "";
            newRow["PODate"] = "";
            newRow["ETA"] = "";
            newRow["Status"] = "";

            logisticProcurementDataTable.Rows.Add(newRow);
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



        private void InternalTransferOrder_Click(object sender, EventArgs e)
        {

        }

        private void Procurement_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void OnDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var cells = dataGridView1.SelectedCells;
            if (cells == null || cells.Count == 0)
            {
                return;
            }
            var cell = cells[0];
            if (cell != null)
            {
                //find key
                string key = cell.Value.ToString();
                textBox2.Text = key;

                //select
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM SCM_PO WHERE POID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@POID", key);
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            try
                            {
                                adapter.Fill(table);
                                if (table.Rows.Count > 0)
                                {
                                    DataRow row = table.Rows[0];
                                    dateTimePicker1.Value = Convert.ToDateTime(row["PODate"]);
                                    dateTimePicker2.Value = Convert.ToDateTime(row["ETA"]);
                                    comboBox1.SelectedItem = row["Status"].ToString();
                                    comboBox3.SelectedItem = row["SupplierID"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No record found for the selected key.");
                                }
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }
            }
        }

        private void btn_Add5_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter...");
                return;
            }
            if (comboBox1.Text == string.Empty || comboBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Select...");
                return;
            }



            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string _sql = "INSERT INTO SCM_PO(POID,SupplierID,PODate,ETA,Status) VALUES (@POID,@SupplierID,@PODate,@ETA,@Status)";
                    using (OleDbCommand cmd = new OleDbCommand(_sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@POID", textBox2.Text);
                        cmd.Parameters.AddWithValue("@SupplierID", comboBox3.Text);
                        cmd.Parameters.Add("@PODate", OleDbType.DBDate).Value = dateTimePicker1.Value;
                        cmd.Parameters.Add("@ETA", OleDbType.DBDate).Value = dateTimePicker2.Value;
                        cmd.Parameters.AddWithValue("@Status", comboBox1.Text);

                        int r = cmd.ExecuteNonQuery();
                        if (r == 0)
                        {
                            MessageBox.Show("Add Error");
                        }
                        else
                        {
                            MessageBox.Show("Add Successful");
                            LoadLogisticProcurementTable();
                        }
                    }
                }

                catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            }

        }


        private static readonly Random random = new Random();


        public static string GenerateShortTextKey()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8);
        }

        public static string GenerateRandomString(int length = 8)
        {
            if (length > 255) length = 255;
            if (length <= 0) length = 8;

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }

            return new string(result);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string key = GenerateShortTextKey();
            textBox2.Text = key;
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            string key = GenerateShortTextKey();
            textBox6.Text = key;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == string.Empty || comboBox4.Text == string.Empty) { MessageBox.Show("Please"); return; }
            if (textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty) { MessageBox.Show("Please"); return; }

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string _sql = "INSERT INTO SCM_Transfer([Date],[FromDept],[ToDept],[OrderNo],[Reason],[Manager],[Remark]) VALUES (@Date,@FromDept,@ToDept,@OrderNo,@Reason,@Manager,@Remark)";
                    using (OleDbCommand cmd = new OleDbCommand(_sql, conn))
                    {
                        cmd.Parameters.Add("@Date", OleDbType.DBDate).Value = dateTimePicker3.Value;
                        cmd.Parameters.AddWithValue("@FromDept", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@ToDept", comboBox4.Text);
                        cmd.Parameters.AddWithValue("@OrderNo", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Reason", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Manager", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Remark", "");
                        int r = cmd.ExecuteNonQuery();
                        if (r == 0)
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {
                            MessageBox.Show("Success");
                            // 刷新
                            this.LoadLogisticTransferTable();
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            var cells = dataGridView2.SelectedCells;
            if (cells == null || cells.Count == 0)
            {
                return;
            }
            var cell = cells[0];
            if (cell != null)
            {
                string key = cell.Value.ToString();
                textBox2.Text = key;

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM SCM_Transfer WHERE TransferID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TransferID", key);
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            try
                            {
                                adapter.Fill(table);
                                if (table.Rows.Count > 0)
                                {
                                    DataRow row = table.Rows[0];
                                    textBox6.Text = row["TransferID"].ToString();
                                    dateTimePicker3.Value = Convert.ToDateTime(row["Date"]);
                                    comboBox2.Text = row["FromDept"].ToString();
                                    comboBox4.Text = row["ToDept"].ToString();
                                    textBox3.Text = row["OrderNo"].ToString();
                                    textBox4.Text = row["Reason"].ToString();
                                    textBox5.Text = row["Manager"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No record found for the selected key.");
                                }
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }
            }
        }
    }
}
