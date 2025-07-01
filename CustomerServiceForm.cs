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
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }

        //first Tab
        private void LoadInteractionLogTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT ID, Date, CustomerName, Channel FROM CSD_InteractionLog";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            interactionLogDataTable = new DataTable();
                            adapter.Fill(interactionLogDataTable);
                            dataGridView1.DataSource = interactionLogDataTable;
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
    }
}
