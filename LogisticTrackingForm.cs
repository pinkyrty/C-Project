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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // 刷新
            try
            {
                comboBox3.Items.Clear();
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string _sql = "SELECT QuotationNumber FROM SMD_Quotation";
                    using (OleDbCommand cmd = new OleDbCommand(_sql, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    comboBox3.Items.Add(reader["QuotationNumber"].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

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
            textBox4.Text = key;
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
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["TrackID"] != DBNull.Value ? row["TrackID"] : Guid.NewGuid().ToString();
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["NodeName"] != DBNull.Value ? row["NodeName"] : DBNull.Value;
                                cmd.Parameters.Add("?", OleDbType.Date).Value = row["NodeTime"] != DBNull.Value ? Convert.ToDateTime(row["NodeTime"]) : DBNull.Value;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["NodeStatus"] != DBNull.Value ? row["NodeStatus"] : DBNull.Value;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["Remark"] != DBNull.Value ? row["Remark"] : DBNull.Value;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            string query = "UPDATE DT_LogisticsNode SET TrackID = ?, NodeName = ?, NodeTime = ?, NodeStatus = ?, Remark = ? WHERE NodeID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["TrackID"] != DBNull.Value ? row["TrackID"] : DBNull.Value;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["NodeName"] != DBNull.Value ? row["NodeName"] : DBNull.Value;
                                cmd.Parameters.Add("?", OleDbType.Date).Value = row["NodeTime"] != DBNull.Value ? Convert.ToDateTime(row["NodeTime"]) : DBNull.Value;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["NodeStatus"] != DBNull.Value ? row["NodeStatus"] : DBNull.Value;
                                cmd.Parameters.Add("?", OleDbType.VarChar).Value = row["Remark"] != DBNull.Value ? row["Remark"] : DBNull.Value;
                                cmd.Parameters.Add("?", OleDbType.Integer).Value = row["NodeID"] != DBNull.Value ? Convert.ToInt32(row["NodeID"]) : DBNull.Value;
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
            if(textBox4.Text == string.Empty)
            {
                return;
            }
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string _sql = "INSERT INTO DT_Logistics(TrackID,RefOrder,Carrier,Status,Receiver,Phone,Address) VALUES (@TrackID,@RefOrder,@Carrier,@Status,@Receiver,@Phone,@Address)";

                    using (OleDbCommand cmd = new OleDbCommand(_sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TrackID",textBox4.Text);
                        cmd.Parameters.AddWithValue("@RefOrder", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Carrier", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@Status", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@Receiver", textBox1.Text);
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex < 0) return;

            using (OleDbConnection connn = new OleDbConnection(connStr))
            {
                try
                {
                    connn.Open();
                    string _sql = "SELECT * FROM SMD_Quotation WHERE QuotationNumber = ?";
                    using (OleDbCommand cmd = new OleDbCommand(_sql, connn))
                    {
                        cmd.Parameters.AddWithValue("@QuotationNumber", comboBox3.Text);
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            da.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                DataRow row = table.Rows[0];
                                textBox1.Text = row["ClientName"].ToString();
                                textBox3.Text = row["Address"].ToString();

                            }
                        }
                    }
                }
                catch { }

            }
        }
    }
}