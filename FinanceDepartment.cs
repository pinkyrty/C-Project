using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C_Project
{
    public partial class FinanceDepartment : Form
    {
        public string DepartmentName { get; set; }
        public string Username { get; set; }
        private string connStr;
        private static DataTable budgetDataTable;

        public FinanceDepartment()
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
            MessageBox.Show(Username);
        }

        private void FinanceDepartment_Load(object sender, EventArgs e)
        {
            this.LoadBudgetTable();
            //this.LoadCashFlowTable();
        }

        private void LoadBudgetTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM FI_Budget";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            budgetDataTable = new DataTable();
                            adapter.Fill(budgetDataTable);
                            dataGridView1.DataSource = budgetDataTable;
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

        //private void LoadCashFlowTable()
        //{
        //    try
        //    {
        //        using (OleDbConnection conn = new OleDbConnection(connStr))
        //        {

        //            conn.Open();

        //            string sql = "SELECT * FROM FI_CashFlow";
        //            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
        //            {

        //                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
        //                {
        //                    dataTable = new DataTable();
        //                    adapter.Fill(dataTable);
        //                    dataGridView1.DataSource = dataTable;
        //                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //                    dataGridView1.Columns["ID"].ReadOnly = true;
        //                }
        //            }

        //            conn.Close();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error connecting to database!\n" + ex.Message);
        //    }
        //}

        //private void InsertBudgetTable()
        //{
        //    try
        //    {
        //        using (OleDbConnection conn = new OleDbConnection(connStr))
        //        {

        //            conn.Open();

        //            string sql = "INSERT INTO FI_Budget (FiscalYear, BudgetIncome, BudgetExpense, ForecastIncome, ForecastExpense, Remark) VALUES (?, ?, ?, ?, ?, ?)";
        //            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
        //            {
        //                int rowsInserted = 0;
        //                foreach (DataRow row in dataTable.Rows)
        //                {
        //                    if ((row.RowState == DataRowState.Added))
        //                    {
        //                        string fiscalYear = row["FiscalYear"].ToString().Trim();
        //                        string budgetIncome = row["BudgetIncome"].ToString().Trim();
        //                        string BudgetExpense = row["BudgetExpense"].ToString().Trim();
        //                        string ForecastIncome = row["ForecastIncome"].ToString().Trim();
        //                        string ForecastExpense = row["ForecastExpense"].ToString().Trim();
        //                        string Remark = row["Remark"].ToString().Trim();

        //                        cmd.Parameters.Clear();
        //                        cmd.Parameters.AddWithValue("?", fiscalYear);
        //                        cmd.Parameters.AddWithValue("?", budgetIncome);
        //                        cmd.Parameters.AddWithValue("?", BudgetExpense);
        //                        cmd.Parameters.AddWithValue("?", ForecastIncome);
        //                        cmd.Parameters.AddWithValue("?", ForecastExpense);
        //                        cmd.Parameters.AddWithValue("?", Remark);
        //                        int rowsAffected = cmd.ExecuteNonQuery();
        //                        if (rowsAffected > 0)
        //                        {
        //                            rowsInserted++;

        //                        }
        //                    }
        //                }
        //                if (rowsInserted > 0)
        //                {
        //                    dataTable.AcceptChanges();
        //                    MessageBox.Show("Success Insert");
        //                    LoadBudgetTable();
        //                }
        //            }
        //            conn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error connecting to database!\n" + ex.Message);
        //    }
        //}

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //InsertBudgetTable();
        }
    }
}
