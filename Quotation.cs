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
    public partial class Quotation : Form
    {
        private string dbPath;          
        private Button btnConnect;
        private string connectionString;
        public Quotation()
        {
            InitializeComponent();
            dbPath = Path.Combine(Application.StartupPath, "ToySystem.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Quotation";
                    using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("?", "1");

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string customerName = reader["CustomerName"].ToString();
                                string customerContact = reader["CustomerContact"].ToString();
                                string customerAddr = reader["CustomerAdd"].ToString();
                                string dateOfIssuance = reader["DateOfIssuance"].ToString();
                                string price = reader["Price"].ToString();
                                string discount = reader["Discount"].ToString();
                                string quotationAmount = reader["QuotationAmount"].ToString();
                                MessageBox.Show("Customer Name is: " + customerName);
                                MessageBox.Show("Customer Contact is: " + customerContact);
                                MessageBox.Show("Customer Address is: " + customerAddr);
                                MessageBox.Show("Date is: " + dateOfIssuance);
                                MessageBox.Show("Price is: " + price);
                                MessageBox.Show("Discount is: " + discount);
                                MessageBox.Show("Quotation Amount is: " + quotationAmount);
                            }
                        }
                    }

                    connection.Close();

                    //OleDbCommand cmd = new OleDbCommand(sqlQuery, connection);

                    //connection.Open();

                    //String count = (String)cmd.ExecuteScalar();
                    //MessageBox.Show(count.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect Fail：" + ex.Message);
            }
        }

        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnConnect.Location = new System.Drawing.Point(55, 65);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(175, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect Database";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            SuspendLayout();

            ClientSize = new Size(284, 261);
            Controls.Add(btnConnect);
            Name = "Quotation";
            ResumeLayout(false);

        }
    }
}
