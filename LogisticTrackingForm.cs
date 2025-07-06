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
    public partial class LogisticTrackingForm : Form
    {
        public string DepartmentName { get; set; }
        public string Username { get; set; }
        private string connStr;
        private static DataTable LogisticNodeDataTable;
        public LogisticTrackingForm()
        {
            InitializeComponent();
            string projectRoot = Directory.GetCurrentDirectory();
            if (projectRoot.Contains("bin\\Debug"))
            {
                projectRoot = Directory.GetParent(projectRoot).Parent.Parent.FullName;
            }
            string dbPath = Path.Combine(projectRoot, "ToySystem.accdb");
            connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            this.LoadLogisticNodeTable();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }

        private void LoadLogisticNodeTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM DT_LogisticsNode";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            LogisticNodeDataTable = new DataTable();
                            adapter.Fill(LogisticNodeDataTable);
                            dataGridView1.DataSource = LogisticNodeDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            //dataGridView1.Columns["NodeID"].ReadOnly = true;
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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void LogisticTrackingForm_Load(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

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
                            string query = "INSERT INTO DT_LogisticsNode (TrackID, NodeName, NodeTime, NodeStatus, Remark) VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                string supplierID = Guid.NewGuid().ToString();
                                cmd.Parameters.AddWithValue("?", supplierID);
                                cmd.Parameters.AddWithValue("?", row["TrackID"] != DBNull.Value ? row["TrackID"] : "");
                                cmd.Parameters.AddWithValue("?", row["NodeName"] != DBNull.Value ? row["NodeName"] : "");
                                cmd.Parameters.AddWithValue("?", row["NodeTime"] != DBNull.Value ? row["NodeTime"] : "");
                                cmd.Parameters.AddWithValue("?", row["NodeStatus"] != DBNull.Value ? row["NodeStatus"] : "");
                                cmd.Parameters.AddWithValue("?", row["Remark"] != DBNull.Value ? row["Remark"] : "");
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE SCM_Supplier SET TrackID = ?, NodeName = ?, NodeTime = ?, NodeStatus = ?, Remark = ? WHERE NodeID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("?", row["TrackID"] != DBNull.Value ? row["TrackID"] : "");
                                cmd.Parameters.AddWithValue("?", row["NodeName"] != DBNull.Value ? row["NodeName"] : "");
                                cmd.Parameters.AddWithValue("?", row["NodeTime"] != DBNull.Value ? row["NodeTime"] : "");
                                cmd.Parameters.AddWithValue("?", row["NodeStatus"] != DBNull.Value ? row["NodeStatus"] : "");
                                cmd.Parameters.AddWithValue("?", row["Remark"] != DBNull.Value ? row["Remark"] : "");
                                cmd.Parameters.AddWithValue("?", row["NodeID"]);

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
            DataRow newRow = LogisticNodeDataTable.NewRow();

            newRow["TrackID"] = "";
            newRow["NodeName"] = "";
            newRow["NodeTime"] = "";
            newRow["NodeStatus"] = "";
            newRow["Remark"] = "";

            LogisticNodeDataTable.Rows.Add(newRow);
        }
        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword(this, connStr);
            changePasswordForm.Username = Username;
            changePasswordForm.DepartmentName = DepartmentName;
            changePasswordForm.ShowDialog();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select on state");
                return;
            }
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string _sql = "INSERT INTO DT_Logistics(RefOrder,Carrier,Status,Receiver,Phone,Address) VALUES (@RefOrder,@Carrier,@Status,@Receiver,@Phone,@Address)";

                    using (OleDbCommand cmd = new OleDbCommand(_sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@RefOrder", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Carrier", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Status", comboBox1.SelectedText);
                        cmd.Parameters.AddWithValue("@Receiver", "");
                        cmd.Parameters.AddWithValue("@Phone", "");
                        cmd.Parameters.AddWithValue("@Address", textBox3.Text);

                        int r = cmd.ExecuteNonQuery();
                        if (r == 0)
                        {
                            MessageBox.Show("Add Error");
                        }
                        else
                        {
                            MessageBox.Show("Add Success");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}