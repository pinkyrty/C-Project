using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C_Project
{
    public partial class Sales_MarketingForm : Form
    {
        private string connStr;
        private static System.Data.DataTable quotationDetailDataTable;
        private static System.Data.DataTable quotationlDataTable;
        private static System.Data.DataTable prodOrderDataTable;
        private static System.Data.DataTable orderFileDataTable;
        private static System.Data.DataTable prodOrderMatDataTable;
        public string DepartmentName { get; set; }
        public string Username { get; set; }
        public Sales_MarketingForm()
        {
            InitializeComponent();
            string projectRoot = Directory.GetCurrentDirectory();
            if (projectRoot.Contains("bin\\Debug"))
            {
                projectRoot = Directory.GetParent(projectRoot).Parent.Parent.FullName;
            }
            string dbPath = Path.Combine(projectRoot, "ToySystem.accdb");
            connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            this.LoadQuotationDetailTable();
            this.LoadQuotationlTable();
            this.LoadProdOrderTable();
            this.LoadOrderFileTable();
            this.LoadProdOrderMatTable();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }

        //first Tab
        private void LoadQuotationlTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string sql = "SELECT QuotationID, QDate, ClientName FROM SMD_Quotation";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            quotationlDataTable = new System.Data.DataTable();
                            adapter.Fill(quotationlDataTable);
                            dgvQuoteList.DataSource = quotationlDataTable; // Set DataSource first
                            dgvQuoteList.Columns["QDate"].HeaderText = "Quotation Date"; // Then set HeaderText
                            dgvQuoteList.Columns["ClientName"].HeaderText = "Client Name";
                            dgvQuoteList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvQuoteList.AllowUserToResizeColumns = false;
                            dgvQuoteList.Columns["QuotationID"].ReadOnly = true;
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

        private void LoadQuotationDetailTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SMD_QuotationDetail";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            quotationDetailDataTable = new System.Data.DataTable();
                            adapter.Fill(quotationDetailDataTable);
                            dataGridView2.DataSource = quotationDetailDataTable;
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView2.AllowUserToResizeColumns = false;
                            dataGridView2.Columns["QuotationID"].ReadOnly = true;
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
        private void LoadProdOrderTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SMD_ProdOrderMat";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            quotationDetailDataTable = new System.Data.DataTable();
                            adapter.Fill(quotationDetailDataTable);
                            dgvProdOrderList.DataSource = quotationDetailDataTable;
                            dgvProdOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvProdOrderList.AllowUserToResizeColumns = false;
                            dgvProdOrderList.Columns["OMatID"].ReadOnly = true;
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
        private void LoadOrderFileTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SMD_OrderFile";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            orderFileDataTable = new System.Data.DataTable();
                            adapter.Fill(orderFileDataTable);
                            dataGridView3.DataSource = orderFileDataTable;
                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView3.AllowUserToResizeColumns = false;
                            dataGridView3.Columns["OFID"].ReadOnly = true;
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
        private void LoadProdOrderMatTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT * FROM SMD_OrderFile";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            prodOrderMatDataTable = new System.Data.DataTable();
                            adapter.Fill(prodOrderMatDataTable);
                            dataGridView1.DataSource = prodOrderMatDataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.AllowUserToResizeColumns = false;
                            dataGridView1.Columns["OFID"].ReadOnly = true;
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
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dgvProdOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void genPDF_Click(object sender, EventArgs e)
        {
            // 定義檔案路徑
            string baseDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));
            string excelFilePath = Path.Combine(baseDirectory, "QuotationTemplate.xlsx"); // 替換為你的 Excel 檔案路徑
            //string excelPdfPath = Path.Combine(baseDirectory, "QuotationTemplateExcel.pdf"); // Excel 轉換後的 PDF 路徑

            string excelPdfPath = GetSaveFilePath("Save PDF", CustomerNameTextBox.Text + " - Quotation.pdf");
            if (string.IsNullOrEmpty(excelPdfPath))
            {
                MessageBox.Show("Please Select PDF export location");
                return;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(excelPdfPath));
            // 轉換 Excel 檔案為 PDF
            ConvertExcelToPdf(excelFilePath, excelPdfPath);
        }

        private void ConvertExcelToPdf(string excelPath, string pdfPath)
        {
            try
            {
                // 創建 Excel 應用程式物件
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;

                // 開啟 Excel 檔案
                Workbook workbook = excelApp.Workbooks.Open(excelPath);
                Worksheet worksheet = (Worksheet)workbook.ActiveSheet;

                InsertDataToExcel(worksheet);


                // 另存為 PDF
                workbook.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, pdfPath);

                // 關閉工作簿和應用程式
                workbook.Close();
                excelApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                MessageBox.Show($"Excel 檔案已轉換為 PDF: {pdfPath}", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excel 轉換錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertDataToExcel(Worksheet worksheet)
        {
            string quotationNum = QuoteNumberTextBox.Text;
            string customerName = CustomerNameTextBox.Text;
            string date = dateTimePicker1.Text;
            string address = AddressTextBox.Text;
            string contactPerson = ContactPersonTextBox.Text;
            string telephone = TelephoneTextBox.Text;

            worksheet.Cells[8, 3].Value = customerName;
            worksheet.Cells[8, 6].Value = quotationNum;
            worksheet.Cells[10, 3].Value = address;
            worksheet.Cells[10, 6].Value = date;
            worksheet.Cells[12, 3].Value = contactPerson;

        }

        private string GetSaveFilePath(string title, string defaultFileName)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = title;
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.FileName = defaultFileName;
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 預設開啟我的文件

                return saveFileDialog.ShowDialog() == DialogResult.OK ? saveFileDialog.FileName : null;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvQuoteList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword(this, connStr);
            changePasswordForm.Username = Username;
            changePasswordForm.DepartmentName = DepartmentName;
            changePasswordForm.ShowDialog();

        }

        private void btn_quoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    // Step 1: Get the last QuotationID from the database
                    string getLastIdQuery = "SELECT MAX(QuotationID) FROM SMD_Quotation";
                    string newQuoteNumber;
                    using (OleDbCommand cmd = new OleDbCommand(getLastIdQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            string lastQuoteId = result.ToString();
                            int lastNumber = int.Parse(lastQuoteId.Substring(1));
                            newQuoteNumber = $"Q{lastNumber + 1:D5}";
                        }
                        else
                        {
                            newQuoteNumber = "Q00001";
                        }
                    }

                    // Prepare values and handle empty fields
                    string clientName = CustomerNameTextBox.Text.Trim();
                    string address = string.IsNullOrWhiteSpace(AddressTextBox.Text) ? "" : AddressTextBox.Text.Trim();
                    string contact = string.IsNullOrWhiteSpace(ContactPersonTextBox.Text) ? "" : ContactPersonTextBox.Text.Trim();
                    string phone = string.IsNullOrWhiteSpace(TelephoneTextBox.Text) ? "" : TelephoneTextBox.Text.Trim();
                    string delivery = string.IsNullOrWhiteSpace(DeliveryTimeTextBox.Text) ? "" : DeliveryTimeTextBox.Text.Trim();
                    string shipping = string.IsNullOrWhiteSpace(TransportationMethodTextBox.Text) ? "" : TransportationMethodTextBox.Text.Trim();
                    string payment = string.IsNullOrWhiteSpace(PaymentTermsTextBox.Text) ? "" : PaymentTermsTextBox.Text.Trim();
                    string discount = string.IsNullOrWhiteSpace(DiscountsOrOffersTextBox.Text) ? "" : DiscountsOrOffersTextBox.Text.Trim();
                    string remark = string.IsNullOrWhiteSpace(NotesOrtermsTextBox.Text) ? "" : NotesOrtermsTextBox.Text.Trim();

                    // Debug: Log parameter values
                    string debugInfo = $"QuotationID: {newQuoteNumber}\n" +
                                      $"QDate: {dateTimePicker1.Value.Date:MM/dd/yyyy}\n" +
                                      $"ClientName: {clientName}\nAddress: {address}\nContact: {contact}\n" +
                                      $"Phone: {phone}\nDelivery: {delivery}\nShipping: {shipping}\n" +
                                      $"Payment: {payment}\nDiscount: {discount}\nRemark: {remark}";
                    MessageBox.Show(debugInfo); // Show values for debugging

                    // Step 3: Insert the new quotation into the database
                    string insertQuery = "INSERT INTO SMD_Quotation (QDate, ClientName, Address, Contact, Phone, Delivery, Shipping, Payment, Discount, Remark) " +
                                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.Add("QDate", OleDbType.Date).Value = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"); // Explicitly format date
                        insertCmd.Parameters.Add("ClientName", OleDbType.VarChar).Value = clientName;
                        insertCmd.Parameters.Add("Address", OleDbType.VarChar).Value = address;
                        insertCmd.Parameters.Add("Contact", OleDbType.VarChar).Value = contact;
                        insertCmd.Parameters.Add("Phone", OleDbType.VarChar).Value = phone;
                        insertCmd.Parameters.Add("Delivery", OleDbType.VarChar).Value = delivery;
                        insertCmd.Parameters.Add("Shipping", OleDbType.VarChar).Value = shipping;
                        insertCmd.Parameters.Add("Payment", OleDbType.VarChar).Value = payment;
                        insertCmd.Parameters.Add("Discount", OleDbType.VarChar).Value = discount;
                        insertCmd.Parameters.Add("Remar", OleDbType.VarChar).Value = remark;

                        insertCmd.ExecuteNonQuery();
                    }

                    // Step 4: Clear the input fields
                    ContactPersonTextBox.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                    AddressTextBox.Clear();
                    TelephoneTextBox.Clear();
                    DeliveryTimeTextBox.Clear();
                    TransportationMethodTextBox.Clear();
                    PaymentTermsTextBox.Clear();
                    DiscountsOrOffersTextBox.Clear();
                    NotesOrtermsTextBox.Clear();

                    // Step 5: Set the QuoteNumberTextBox to the new QuotationID
                    QuoteNumberTextBox.Text = newQuoteNumber;

                    // Step 6: Refresh the DataGridView to show the updated data
                    LoadQuotationDetailTable();

                    MessageBox.Show("Quotation added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding quotation to database!\n" + ex.Message);
            }
        }
    }
}
