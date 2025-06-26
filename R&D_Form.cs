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
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            productDataTable = new System.Data.DataTable();
                            adapter.Fill(productDataTable);
                            dgvProductList.DataSource = productDataTable;
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

                    string sql = "SELECT Type, Name, Desc, Qty FROM RND_MaterialList";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            materialListDataTable = new System.Data.DataTable();
                            adapter.Fill(materialListDataTable);
                            dgvMaterials.DataSource = materialListDataTable;
                            dgvMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvMaterials.AllowUserToResizeColumns = false;
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

                    string sql = "SELECT ProductID, Content, Equip, Time, Staff FROM RND_Process";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            processDataTable = new System.Data.DataTable();
                            adapter.Fill(processDataTable);
                            dgvManufacturing.DataSource = processDataTable;
                            dgvManufacturing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvManufacturing.AllowUserToResizeColumns = false;
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

                    string sql = "SELECT Type, Condition, Standard FROM RND_Test";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            testDataTable = new System.Data.DataTable();
                            adapter.Fill(testDataTable);
                            dgvTesting.DataSource = testDataTable;
                            dgvTesting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvTesting.AllowUserToResizeColumns = false;
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

                    string sql = "SELECT Name, Content FROM RND_Cert";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            certDataTable = new System.Data.DataTable();
                            adapter.Fill(certDataTable);
                            dataGridView1.DataSource = certDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void RaDUserPrifileButton_Click(object sender, EventArgs e)
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
                // 重新登入後，根據部門再開啟對應表單
                Login.OpenDepartmentForm(loginForm);
            }
            else
            {
                // 如果沒登入成功，直接關閉應用程式
                Application.Exit();
            }
        }
    }
}
