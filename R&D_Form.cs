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
    public partial class RnD_Form : Form
    {
        private string connStr;
        private static DataTable productDataTable;
        private static DataTable materialListDataTable;
        private static DataTable processDataTable;
        private static DataTable testDataTable;
        private static DataTable certDataTable;
        private BindingList<Product> productList = new BindingList<Product>();
        private Dictionary<string, ProjectInfo> projects;
        public string DepartmentName { get; set; }
        public string Username { get; set; }

        public RnD_Form()
        {
            InitializeComponent();
            string projectRoot = Directory.GetCurrentDirectory();
            if (projectRoot.Contains("bin\\Debug"))
            {
                projectRoot = Directory.GetParent(projectRoot).Parent.Parent.FullName;
            }
            string dbPath = Path.Combine(projectRoot, "ToySystem.accdb");
            connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            this.LoadProductTable();
            this.LoadMaterialListTable();
            this.LoadProcessTable();
            this.LoadTestTable();
            this.LoadCertTable();
            this.LoadProductTable2();
            this.dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }
        //first Tab
        private void LoadProductTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT ProductID, Name FROM RND_Cert";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dgvProductList.AllowUserToResizeColumns = false;
                            dgvProductList.AllowUserToAddRows = true;
                            dgvProductList.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            productDataTable = new System.Data.DataTable();
                            adapter.Fill(productDataTable);
                            dgvProductList.DataSource = productDataTable;
                            dgvProductList.Columns[1].HeaderText = "Name";
                            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvProductList.AllowUserToResizeColumns = false;
                            dgvProductList.Columns["ProductID"].ReadOnly = true;
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

        //second Tab
        private void LoadMaterialListTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT MaterialID, ProductID, Type, Name, Desc, Qty FROM RND_MaterialList";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dgvMaterials.AllowUserToResizeColumns = false;
                            dgvMaterials.AllowUserToAddRows = true;
                            dgvMaterials.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            materialListDataTable = new System.Data.DataTable();
                            adapter.Fill(materialListDataTable);
                            dgvMaterials.DataSource = materialListDataTable;
                            dgvMaterials.Columns[1].HeaderText = "ProductID";
                            dgvMaterials.Columns[2].HeaderText = "Type";
                            dgvMaterials.Columns[3].HeaderText = "Name";
                            dgvMaterials.Columns[4].HeaderText = "Desc";
                            dgvMaterials.Columns[5].HeaderText = "Qty";
                            dgvMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvMaterials.AllowUserToResizeColumns = false;
                            dgvMaterials.Columns["MaterialID"].ReadOnly = true;
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

        //third Tab
        private void LoadProcessTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT StepID, ProductID, Seq, Content, Equip, Time, Staff FROM RND_Process";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dgvManufacturing.AllowUserToResizeColumns = false;
                            dgvManufacturing.AllowUserToAddRows = true;
                            dgvManufacturing.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            processDataTable = new System.Data.DataTable();
                            adapter.Fill(processDataTable);
                            dgvManufacturing.DataSource = processDataTable;
                            dgvManufacturing.Columns[1].HeaderText = "ProductID";
                            dgvManufacturing.Columns[2].HeaderText = "Seq";
                            dgvManufacturing.Columns[2].HeaderText = "Content";
                            dgvManufacturing.Columns[3].HeaderText = "Equip";
                            dgvManufacturing.Columns[4].HeaderText = "Time";
                            dgvManufacturing.Columns[5].HeaderText = "Staff";
                            dgvManufacturing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvManufacturing.AllowUserToResizeColumns = false;
                            dgvManufacturing.Columns["StepID"].ReadOnly = true; ;
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

        //fourth Tab
        private void LoadTestTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT TestID, Type, Condition, Standard FROM RND_Test";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dgvTesting.AllowUserToResizeColumns = false;
                            dgvTesting.AllowUserToAddRows = true;
                            dgvTesting.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            testDataTable = new System.Data.DataTable();
                            adapter.Fill(testDataTable);
                            dgvTesting.DataSource = testDataTable;
                            dgvTesting.Columns[1].HeaderText = "Type";
                            dgvTesting.Columns[2].HeaderText = "Condition";
                            dgvTesting.Columns[3].HeaderText = "Standard";
                            dgvTesting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvTesting.AllowUserToResizeColumns = false;
                            dgvTesting.Columns["TestID"].ReadOnly = true;
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

        //fifth Tab
        private void LoadCertTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT CertID, Name, Content FROM RND_Cert";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            dataGridView1.AllowUserToResizeColumns = false;
                            dataGridView1.AllowUserToAddRows = true;
                            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                            certDataTable = new System.Data.DataTable();
                            adapter.Fill(certDataTable);
                            dataGridView1.DataSource = certDataTable;
                            dataGridView1.Columns[1].HeaderText = "Name";
                            dataGridView1.Columns[2].HeaderText = "Content";
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.AllowUserToResizeColumns = false;
                            dataGridView1.Columns["CertID"].ReadOnly = true;
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
        private void LoadProductTable2()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT ProductID, Name, MOQ, [Unit Price], Status, Project FROM RND_Product";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView2.DataSource = dt;

                            dataGridView2.Columns["ProductID"].HeaderText = "Product Number";
                            dataGridView2.Columns["Name"].HeaderText = "Product Name";
                            dataGridView2.Columns["MOQ"].HeaderText = "MOQ";
                            dataGridView2.Columns["Unit Price"].HeaderText = "Unit Price";
                            dataGridView2.Columns["Status"].HeaderText = "Status";
                            dataGridView2.Columns["Project"].HeaderText = "Project";
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading RND_Product: " + ex.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //LoadMaterialListTable();
            try
            {
                DataTable dt = (DataTable)dgvMaterials.DataSource;
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
                            string query = "INSERT INTO RND_MaterialList (ProductID, Type, Name, Desc, Qty) VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ProductID"] != DBNull.Value ? row["ProductID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Name"] != DBNull.Value ? row["Name"] : "");
                                cmd.Parameters.AddWithValue("?", row["Desc"] != DBNull.Value ? row["Desc"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : 0);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE RND_MaterialList SET ProductID = ?, Type = ?, Name = ?, Desc = ?, Qty = ?, WHERE MaterialID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ProductID"] != DBNull.Value ? row["ProductID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Name"] != DBNull.Value ? row["Name"] : "");
                                cmd.Parameters.AddWithValue("?", row["Desc"] != DBNull.Value ? row["Desc"] : "");
                                cmd.Parameters.AddWithValue("?", row["Qty"] != DBNull.Value ? row["Qty"] : 0); ;
                                cmd.Parameters.AddWithValue("?", row["MaterialID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMaterials.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataRow newRow = materialListDataTable.NewRow();

            newRow["ProductID"] = "";
            newRow["Type"] = "";
            newRow["Name"] = "";
            newRow["Desc"] = "";
            newRow["Qty"] = 0;

            materialListDataTable.Rows.Add(newRow);
        }

        private void btn_Save1_Click(object sender, EventArgs e)
        {
            //LoadProcessTable()
            try
            {
                DataTable dt = (DataTable)dgvManufacturing.DataSource;
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
                            string query = "INSERT INTO RND_Process (ProductID, Seq, Content, Equip, Time, Staff) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ProductID"] != DBNull.Value ? row["ProductID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Seq"] != DBNull.Value ? row["Seq"] : 0);
                                cmd.Parameters.AddWithValue("?", row["Content"] != DBNull.Value ? row["Content"] : "");
                                cmd.Parameters.AddWithValue("?", row["Equip"] != DBNull.Value ? row["Equip"] : "");
                                cmd.Parameters.AddWithValue("?", row["Time"] != DBNull.Value ? row["Time"] : "");
                                cmd.Parameters.AddWithValue("?", row["Staff"] != DBNull.Value ? row["Staff"] : "");

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE RND_Process SET ProductID = ?, Seq = ?, Content = ?, Equip = ?, Time = ?, Staff = ? WHERE StepID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ProductID"] != DBNull.Value ? row["ProductID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Seq"] != DBNull.Value ? row["Seq"] : 0);
                                cmd.Parameters.AddWithValue("?", row["Content"] != DBNull.Value ? row["Content"] : "");
                                cmd.Parameters.AddWithValue("?", row["Equip"] != DBNull.Value ? row["Equip"] : "");
                                cmd.Parameters.AddWithValue("?", row["Time"] != DBNull.Value ? row["Time"] : ""); ;
                                cmd.Parameters.AddWithValue("?", row["Staff"] != DBNull.Value ? row["Staff"] : ""); ;
                                cmd.Parameters.AddWithValue("?", row["StepID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMaterials.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Add1_Click(object sender, EventArgs e)
        {
            DataRow newRow = processDataTable.NewRow();

            newRow["ProductID"] = "";
            newRow["Seq"] = 0;
            newRow["Content"] = "";
            newRow["Equip"] = "";
            newRow["Time"] = "";
            newRow["Staff"] = "";

            processDataTable.Rows.Add(newRow);
        }

        private void btn_Save2_Click(object sender, EventArgs e)
        {
            //LoadTestTable()
            try
            {
                DataTable dt = (DataTable)dgvTesting.DataSource;
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
                            string query = "INSERT INTO RND_Process (Type, Condition, Standard) VALUES (?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Condition"] != DBNull.Value ? row["Condition"] : "");
                                cmd.Parameters.AddWithValue("?", row["Standard"] != DBNull.Value ? row["Standard"] : "");

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE RND_Process SET Type = ?, Condition = ?, Standard = ? WHERE TestID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["Type"] != DBNull.Value ? row["Type"] : "");
                                cmd.Parameters.AddWithValue("?", row["Condition"] != DBNull.Value ? row["Condition"] : "");
                                cmd.Parameters.AddWithValue("?", row["Standard"] != DBNull.Value ? row["Standard"] : "");
                                cmd.Parameters.AddWithValue("?", row["TestID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMaterials.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Add2_Click(object sender, EventArgs e)
        {
            DataRow newRow = testDataTable.NewRow();

            newRow["Type"] = "";
            newRow["Condition"] = "";
            newRow["Standard"] = "";

            testDataTable.Rows.Add(newRow);
        }

        private void btn_Save3_Click(object sender, EventArgs e)
        {
            //LoadCertTable()
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
                            string query = "INSERT INTO LoadCertTable (ProductID, Name, Content) VALUES (?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ProductID"] != DBNull.Value ? row["ProductID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Name"] != DBNull.Value ? row["Name"] : "");
                                cmd.Parameters.AddWithValue("?", row["Content"] != DBNull.Value ? row["Content"] : "");

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE LoadCertTable SET ProductID = ?, Name = ?, Content = ? WHERE CertID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["ProductID"] != DBNull.Value ? row["ProductID"] : "");
                                cmd.Parameters.AddWithValue("?", row["Name"] != DBNull.Value ? row["Name"] : "");
                                cmd.Parameters.AddWithValue("?", row["Content"] != DBNull.Value ? row["Content"] : "");
                                cmd.Parameters.AddWithValue("?", row["CertID"]);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    dt.AcceptChanges();
                }

                MessageBox.Show("Data saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMaterials.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add3_Click(object sender, EventArgs e)
        {
            DataRow newRow = certDataTable.NewRow();

            newRow["Name"] = "";
            newRow["Content"] = "";

            certDataTable.Rows.Add(newRow);
        }
        private void btn_Save4_Click(object sender, EventArgs e)
        {
            string productId = txtProductCode.Text.Trim();
            string name = txtProductName.Text.Trim();
            string moqText = txtMOQ.Text.Trim();
            string unitPriceText = unitPriceTextBox.Text.Trim();
            string status = cmbStatus.Text.Trim();
            string project = cmbProject.Text.Trim();

            if (string.IsNullOrEmpty(productId) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Product Number and Name are required.");
                return;
            }
            if (!int.TryParse(moqText, out int moq))
            {
                MessageBox.Show("MOQ must be an integer.");
                return;
            }
            if (!decimal.TryParse(unitPriceText, out decimal unitPrice))
            {
                MessageBox.Show("Unit Price must be a number.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    // 檢查是否已存在
                    string checkSql = "SELECT COUNT(*) FROM RND_Product WHERE ProductID = ?";
                    using (var checkCmd = new OleDbCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", productId);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // 更新
                            string updateSql = @"UPDATE RND_Product SET Name=?, MOQ=?, [Unit Price]=?, Status=?, Project=? WHERE ProductID=?";
                            using (var cmd = new OleDbCommand(updateSql, conn))
                            {
                                cmd.Parameters.AddWithValue("?", name);
                                cmd.Parameters.AddWithValue("?", moq);
                                cmd.Parameters.AddWithValue("?", unitPrice);
                                cmd.Parameters.AddWithValue("?", status);
                                cmd.Parameters.AddWithValue("?", project);
                                cmd.Parameters.AddWithValue("?", productId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // 新增
                            string insertSql = @"INSERT INTO RND_Product (ProductID, Name, MOQ, [Unit Price], Status, Project) VALUES (?, ?, ?, ?, ?, ?)";
                            using (var cmd = new OleDbCommand(insertSql, conn))
                            {
                                cmd.Parameters.AddWithValue("?", productId);
                                cmd.Parameters.AddWithValue("?", name);
                                cmd.Parameters.AddWithValue("?", moq);
                                cmd.Parameters.AddWithValue("?", unitPrice);
                                cmd.Parameters.AddWithValue("?", status);
                                cmd.Parameters.AddWithValue("?", project);
                                cmd.ExecuteNonQuery();
                            }

                            // 新增到RND_Cert，Name欄位帶產品名稱
                            string insertCertSql = @"INSERT INTO RND_Cert (ProductID, Name, Content) VALUES (?, ?, '')";
                            using (var certCmd = new OleDbCommand(insertCertSql, conn))
                            {
                                certCmd.Parameters.AddWithValue("?", productId);
                                certCmd.Parameters.AddWithValue("?", name);  // 產品名稱
                                certCmd.ExecuteNonQuery();
                            }

                            // 新增到RND_Spec（ProductID、ID都寫同一個值）
                            string checkSpecSql = "SELECT COUNT(*) FROM RND_Spec WHERE ID = ?";
                            using (var checkSpecCmd = new OleDbCommand(checkSpecSql, conn))
                            {
                                checkSpecCmd.Parameters.AddWithValue("?", productId);
                                int specCount = (int)checkSpecCmd.ExecuteScalar();

                                if (specCount == 0)
                                {
                                    string insertSpecSql = @"INSERT INTO RND_Spec 
                            (ProductID, Size, Color, Des, Standard, Guide, Warranty, ID)
                            VALUES (?, '', '', '', '', '', '', ?)";
                                    using (var specCmd = new OleDbCommand(insertSpecSql, conn))
                                    {
                                        specCmd.Parameters.AddWithValue("?", productId);
                                        // 其餘欄位預設空字串
                                        specCmd.Parameters.AddWithValue("?", productId); // ID 填 ProductID
                                        specCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                    conn.Close();
                }
                LoadProductTable2();
                MessageBox.Show("Saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null && dataGridView2.CurrentRow.Index >= 0)
            {
                var row = dataGridView2.CurrentRow;
                string productId = row.Cells["ProductID"].Value?.ToString();

                if (!string.IsNullOrEmpty(productId))
                {
                    using (OleDbConnection conn = new OleDbConnection(connStr))
                    {
                        conn.Open();
                        string sql = "SELECT ProductID, Name, MOQ, [Unit Price], Status, Project FROM RND_Product WHERE ProductID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("?", productId);
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtProductCode.Text = reader["ProductID"].ToString();
                                    txtProductName.Text = reader["Name"].ToString();
                                    txtMOQ.Text = reader["MOQ"].ToString();
                                    unitPriceTextBox.Text = reader["Unit Price"].ToString();
                                    cmbStatus.Text = reader["Status"].ToString();
                                    cmbProject.Text = reader["Project"].ToString();
                                }
                            }
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void btn_Add4_Click(object sender, EventArgs e)
        {
            string newProductId = Guid.NewGuid().ToString(); // 產生 UUID
            txtProductCode.Text = newProductId;
            txtProductName.Text = "";
            txtMOQ.Text = "";
            unitPriceTextBox.Text = "";
            cmbStatus.SelectedIndex = -1;
            cmbProject.SelectedIndex = -1;
            txtProductCode.Focus();
        }

        // Product data structure
        public class Product
        {
            public string ProductName { get; set; }
            public string ProductCode { get; set; }
            public string ProjectKey { get; set; }
            // ... Other data fields can be added with the control name
        }

        // Project Data Structure
        public class ProjectInfo
        {
            public string ProjectName { get; set; }
            public string CustomerName { get; set; }
            public string Requirement { get; set; }
            public string Status { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProductNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewProductsButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RaD_Form_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void RequirementTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ViewProjectButton_Click(object sender, EventArgs e)
        {

        }

        private void dgvTesting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvManufacturing_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            ChangePassword changePasswordForm = new ChangePassword(this, connStr);
            changePasswordForm.Username = Username;
            changePasswordForm.DepartmentName = DepartmentName;
            changePasswordForm.ShowDialog();
        }

        private void BillofMaterialsTabPage_Click(object sender, EventArgs e)
        {

        }

        private void txtMOQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged_1(object sender, EventArgs e)
        {

        }
    }
}
