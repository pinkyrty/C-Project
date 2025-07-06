using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
    public partial class AddProduct : Form
    {
        private string connStr;
        public AddProduct()
        {
            InitializeComponent();
            string projectRoot = Directory.GetCurrentDirectory();
            if (projectRoot.Contains("bin\\Debug"))
            {
                projectRoot = Directory.GetParent(projectRoot).Parent.Parent.FullName;
            }
            string dbPath = Path.Combine(projectRoot, "ToySystem.accdb");
            connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            loadProductTable();
        }

        public string productID { get; private set; }
        public string qty { get; private set; }
        public string productName { get; private set; }

        public int unitPrice { get; private set; }

        private void loadProductTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM RND_Product";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            adapter.Fill(dt);
                            comboBox1.DataSource = dt;
                            comboBox1.DisplayMember = "Name";
                            comboBox1.ValueMember = "ProductID";
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

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || textBox1.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill in");
                return;
            }

            DataRowView selectedRow = comboBox1.SelectedItem as DataRowView;
            productID = selectedRow["ProductID"].ToString(); // 獲取 ProductID
            productName = selectedRow["Name"].ToString();   // 獲取 Name
            qty = textBox1.Text;
            unitPrice = Convert.ToInt32(selectedRow["Unit Price"]);

            //productID = comboBox1.SelectedValue.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
