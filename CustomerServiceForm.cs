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
        }

        private void LoadInteractionLogTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM CSD_InteractionLog";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        MessageBox.Show("Connect Success");
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



        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
