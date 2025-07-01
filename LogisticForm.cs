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
        private static DataTable logisticInventoryDataTable;
        private static DataTable logisticInventoryInDataTable;
        private static DataTable logisticInventoryOutDataTable;
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
            this.LoadLogisticInventoryTable();
            this.LoadLogisticInventoryInTable();
            this.LoadLogisticInventoryOutTable();
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
        //First Tab
        private void LoadLogisticInventoryTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SCM_Material";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticInventoryDataTable = new DataTable();
                            adapter.Fill(logisticInventoryDataTable);
                            dataGridView1.DataSource = logisticInventoryDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.Columns["MaterialID"].ReadOnly = true;
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
        //in ware
        private void LoadLogisticInventoryInTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SCM_Material";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticInventoryInDataTable = new DataTable();
                            adapter.Fill(logisticInventoryInDataTable);
                            dataGridView2.DataSource = logisticInventoryInDataTable;
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView2.Columns["MaterialID"].ReadOnly = true;
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
        //Out ware
        private void LoadLogisticInventoryOutTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SCM_Material";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            logisticInventoryOutDataTable = new DataTable();
                            adapter.Fill(logisticInventoryOutDataTable);
                            dataGridView3.DataSource = logisticInventoryOutDataTable;
                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView3.Columns["MaterialID"].ReadOnly = true;
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
                            dataGridView4.DataSource = logisticProcurementDataTable;
                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView4.Columns["PODetailID"].ReadOnly = true;
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
        private void btn_Save4_Click(object sender, EventArgs e)
        {
            //LoadLogisticInventoryTable();
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
                            string query = "INSERT INTO SCM_Material (Name, Spec, Type, Unit, Warehouse) VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["Name"] != DBNull.Value ? row["Name"] : "");
                                cmd.Parameters.AddWithValue("?", row["Spec"] != DBNull.Value ? row["Spec"] : "");
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Unit"] != DBNull.Value ? row["Unit"] : "");
                                cmd.Parameters.AddWithValue("?", row["Warehouse"] != DBNull.Value ? row["Warehouse"] : "");
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE SCM_Material SET Name = ?, Spec = ?, Type = ?, Unit = ?, Warehouse = ? WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["Name"] != DBNull.Value ? row["Name"] : "");
                                cmd.Parameters.AddWithValue("?", row["Spec"] != DBNull.Value ? row["Spec"] : "");
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Unit"] != DBNull.Value ? row["Unit"] : "");
                                cmd.Parameters.AddWithValue("?", row["Warehouse"] != DBNull.Value ? row["Warehouse"] : "");
                                cmd.Parameters.AddWithValue("?", row["MaterialID"]);

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

        private void btn_Add1_Click(object sender, EventArgs e)
        {
            DataRow newRow = logisticInventoryDataTable.NewRow();

            newRow["Name"] = "";
            newRow["Spec"] = "";
            newRow["Type"] = "";
            newRow["Unit"] = "";
            newRow["Warehouse"] = "";

            logisticInventoryDataTable.Rows.Add(newRow);
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
    }
}
