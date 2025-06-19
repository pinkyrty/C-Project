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

                    string sql = "SELECT * FROM PD_OrderStep";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            orderStepDataTable = new DataTable();
                            adapter.Fill(orderStepDataTable);
                            dataGridView2.DataSource = orderStepDataTable;
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView2.AllowUserToResizeColumns = false;
                            dataGridView2.Columns["OStepID"].ReadOnly = true;
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
        private void LoadMaterialTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM PD_OrderPlan";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            materialDataTable = new DataTable();
                            adapter.Fill(materialDataTable);
                            dataGridView1.DataSource = materialDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView1.AllowUserToResizeColumns = false;
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

                    string sql = "SELECT * FROM PD_MRFDetail";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            processDataTable = new DataTable();
                            adapter.Fill(processDataTable);
                            dataGridView3.DataSource = processDataTable;
                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView3.AllowUserToResizeColumns = false;
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
        private void LoadRequestTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM PD_MaterialRequestForm";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            requsetDataTable = new DataTable();
                            adapter.Fill(requsetDataTable);
                            dataGridView4.DataSource = requsetDataTable;
                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            dataGridView4.AllowUserToResizeColumns = false;
                            dataGridView4.Columns["MRFNo"].ReadOnly = true;
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
    }
}
