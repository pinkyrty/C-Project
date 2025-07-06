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
using static C_Project.RnD_Form;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        private static System.Data.DataTable orderDataTable;

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
            this.LoadQuotationlTable();
            this.LoadProdOrderTable();
            this.LoadOrderFileTable();
            this.LoadOrderTable();
            InitializeQuotationDetailTable();
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

                    string sql = "SELECT QuotationNumber, QDate, ClientName FROM SMD_Quotation";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            quotationlDataTable = new System.Data.DataTable();
                            adapter.Fill(quotationlDataTable);
                            dgvQuoteList.DataSource = quotationlDataTable;
                            dgvQuoteList.Columns["QuotationNumber"].HeaderText = "Quotation Number";
                            dgvQuoteList.Columns["QDate"].HeaderText = "Quotation Date";
                            dgvQuoteList.Columns["ClientName"].HeaderText = "Client Name";
                            dgvQuoteList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvQuoteList.AllowUserToResizeColumns = false;
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
        private void InitializeQuotationDetailTable()
        {
            quotationDetailDataTable = new System.Data.DataTable();
            quotationDetailDataTable.Columns.Add("ProductID", typeof(string));
            quotationDetailDataTable.Columns.Add("ProductName", typeof(string));
            quotationDetailDataTable.Columns.Add("Qty", typeof(string));
            quotationDetailDataTable.Columns.Add("UnitPrice", typeof(decimal));
            quotationDetailDataTable.Columns.Add("Amount", typeof(decimal));

            dataGridView2.DataSource = quotationDetailDataTable;
            ConfigureQuotationDetailTable();
        }
        private void ConfigureQuotationDetailTable()
        {
            if (dataGridView2.Columns.Contains("ProductName"))
                dataGridView2.Columns["ProductName"].HeaderText = "Product Name";
            if (dataGridView2.Columns.Contains("Qty"))
                dataGridView2.Columns["Qty"].HeaderText = "Quantity";
            if (dataGridView2.Columns.Contains("UnitPrice"))
                dataGridView2.Columns["UnitPrice"].HeaderText = "Unit Price";
            if (dataGridView2.Columns.Contains("Amount"))
                dataGridView2.Columns["Amount"].HeaderText = "Amount";
            if (dataGridView2.Columns.Contains("ProductID"))
                dataGridView2.Columns["ProductID"].Visible = false;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToResizeColumns = false;
        }

        //third Tab
        private void LoadProdOrderTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = "SELECT OrderNumber, ODate FROM SMD_ProdOrder";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            quotationlDataTable = new System.Data.DataTable();
                            adapter.Fill(quotationlDataTable);
                            dgvProdOrderList.DataSource = quotationlDataTable;
                            dgvProdOrderList.Columns["OrderNumber"].HeaderText = "Order Number";
                            dgvProdOrderList.Columns["ODate"].HeaderText = "Order Date";
                            dgvProdOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvProdOrderList.AllowUserToResizeColumns = false;
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

                    string sql = "SELECT MaterialName, Spec, NeedQty FROM SMD_ProdOrderMat";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            orderFileDataTable = new System.Data.DataTable();
                            adapter.Fill(orderFileDataTable);
                            dataGridView3.DataSource = orderFileDataTable;
                            dataGridView3.Columns["MaterialName"].HeaderText = "Material";
                            dataGridView3.Columns["NeedQty"].HeaderText = "Quantity Need";
                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        //fifth Tab
        private void LoadOrderTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {

                    conn.Open();

                    string sql = @"
                SELECT 
                    SMD_ProdOrder.ProductID, 
                    SMD_ProdOrder.RefQuotation, 
                    SMD_ProdOrder.Qty, 
                    SMD_ProdOrder.Remark, 
                    SMD_ProdOrder.ESD, 
                    SMD_ProdOrder.EED,
                    RND_Product.ProductID AS RND_ProductID
                FROM SMD_ProdOrder
                LEFT JOIN RND_Product ON (SMD_ProdOrder.ProductID = RND_Product.ProductID)";

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            orderDataTable = new System.Data.DataTable();
                            adapter.Fill(orderDataTable);
                            poList.DataSource = orderDataTable;
                            MessageBox.Show(poList.Columns["ProductID"].ToString());
                            poList.Columns["ProductID"].HeaderText = "Product ID";
                            poList.Columns["RefQuotation"].HeaderText = "Quotation Ref";
                            poList.Columns["Qty"].HeaderText = "Quantity";
                            poList.Columns["Remark"].HeaderText = "Remark";
                            poList.Columns["ESD"].HeaderText = "Expected Start Date";
                            poList.Columns["EED"].HeaderText = "Expected End Date";
                            poList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            poList.AllowUserToResizeColumns = false;
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
            string baseDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));
            string excelFilePath = Path.Combine(baseDirectory, "QuotationTemplate.xlsx"); // 替換為你的 Excel 檔案路徑
            string excelPdfPath = Path.Combine(baseDirectory, "QuotationTemplateExcel.pdf"); // Excel 轉換後的 PDF 路徑

            excelPdfPath = GetSaveFilePath("Save PDF", CustomerNameTextBox.Text + " - Quotation.pdf");
            if (string.IsNullOrEmpty(excelPdfPath))
            {
                MessageBox.Show("Please Select PDF export location");
                return;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(excelPdfPath));
            ConvertExcelToPdf(excelFilePath, excelPdfPath);
        }

        private void ConvertExcelToPdf(string excelPath, string pdfPath)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;

                Workbook workbook = excelApp.Workbooks.Open(excelPath);
                Worksheet worksheet = (Worksheet)workbook.ActiveSheet;

                InsertDataToExcel(worksheet);

                workbook.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, pdfPath);

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
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                return saveFileDialog.ShowDialog() == DialogResult.OK ? saveFileDialog.FileName : null;
            }
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

        private void clearFormData()
        {
            // Clear form fields
            CustomerNameTextBox.Clear();
            dateTimePicker1.Value = DateTime.Now;
            AddressTextBox.Clear();
            ContactPersonTextBox.Clear();
            TelephoneTextBox.Clear();
            DeliveryTimeTextBox.Clear();
            TransportationMethodTextBox.Clear();
            PaymentTermsTextBox.Clear();
            DiscountsOrOffersTextBox.Clear();
            NotesOrtermsTextBox.Clear();
        }

        private void btn_quoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                clearFormData();
                // Generate temporary QuotationNumber for UI display
                int tempQuoteNumber;
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string getLastIdQuery = "SELECT MAX(QuotationNumber) FROM SMD_Quotation";
                    using (OleDbCommand cmd = new OleDbCommand(getLastIdQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int newQuotationNumber = (result != DBNull.Value && result != null) ? int.Parse(result.ToString().Substring(1)) + 1 : 1;
                        tempQuoteNumber = newQuotationNumber;
                    }
                    conn.Close();
                }
                // Update UI
                QuoteNumberTextBox.Text = $"Q{tempQuoteNumber:D5}";

                // Load related details (if needed)
                //LoadQuotationDetailTable();

                MessageBox.Show("Quotation data prepared. Click Save to store in database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing quotation data!\n" + ex.Message);
            }
        }

        private void btn_quoSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CustomerNameTextBox.Text))
                {
                    MessageBox.Show("No quotation data to save. Please add a quotation first.");
                    return;
                }


                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    // Insert quotation data (exclude QuotationID as it's AutoNumber)
                    string insertQuery = "INSERT INTO SMD_Quotation (QuotationNumber, QDate, ClientName, Address, Contact, Phone, Delivery, Shipping, Payment, Discount, Remark) " +
                                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.Add("QuotationNumber", OleDbType.VarChar).Value = QuoteNumberTextBox.Text;
                        insertCmd.Parameters.Add("QDate", OleDbType.Date).Value = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                        insertCmd.Parameters.Add("ClientName", OleDbType.VarChar).Value = CustomerNameTextBox.Text;
                        insertCmd.Parameters.Add("Address", OleDbType.VarChar).Value = AddressTextBox.Text;
                        insertCmd.Parameters.Add("Contact", OleDbType.VarChar).Value = ContactPersonTextBox.Text;
                        insertCmd.Parameters.Add("Phone", OleDbType.VarChar).Value = TelephoneTextBox.Text;
                        insertCmd.Parameters.Add("Delivery", OleDbType.VarChar).Value = DeliveryTimeTextBox.Text;
                        insertCmd.Parameters.Add("Shipping", OleDbType.VarChar).Value = TransportationMethodTextBox.Text;
                        insertCmd.Parameters.Add("Payment", OleDbType.VarChar).Value = PaymentTermsTextBox.Text;
                        insertCmd.Parameters.Add("Discount", OleDbType.VarChar).Value = DiscountsOrOffersTextBox.Text;
                        insertCmd.Parameters.Add("Remark", OleDbType.VarChar).Value = NotesOrtermsTextBox.Text;

                        insertCmd.ExecuteNonQuery();
                    }

                    conn.Close();

                    dgvQuoteList.Refresh();
                    LoadQuotationlTable();

                    MessageBox.Show("Quotation saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving quotation to database!\n" + ex.Message);
            }
        }

        private void NewProductsButton_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string productID = addForm.productID;
                string qty = addForm.qty;
                string productName = addForm.productName;
                int unitPrice = addForm.unitPrice;

                MessageBox.Show(productName, unitPrice.ToString());
                addDataIntoQuotationDetail(productID, qty, productName, unitPrice);
            }
            else
            {
                MessageBox.Show("Cancel");
            }
            addForm.Dispose();
        }

        private void addDataIntoQuotationDetail(string productID, string qty, string productName, int unitPrice)
        {
            try
            {
                decimal amount = int.Parse(qty) * unitPrice;
                DataRow newRow = quotationDetailDataTable.NewRow();
                newRow["ProductID"] = productID;
                newRow["ProductName"] = productName;
                newRow["Qty"] = qty;
                newRow["UnitPrice"] = unitPrice;
                newRow["Amount"] = amount;
                quotationDetailDataTable.Rows.Add(newRow);

                // 刷新 DataGridView（通常不需要，因為 DataTable 自動更新）
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加記錄時出錯：{ex.Message}");
            }
        }

        private void addProductIntoTable(string productID, string qty)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                try
                {
                    // Insert quotation data (exclude QuotationID as it's AutoNumber)
                    string insertQuery = "INSERT INTO SMD_QuotationDetail (QuotationNumber, ProductID, Qty) " +
                                        "VALUES (?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.Add("QuotationNumber", OleDbType.VarChar).Value = QuoteNumberTextBox.Text;
                        insertCmd.Parameters.Add("ProductID", OleDbType.VarChar).Value = productID;
                        insertCmd.Parameters.Add("Qty", OleDbType.VarChar).Value = qty;

                        insertCmd.ExecuteNonQuery();
                    }

                    conn.Close();
                    MessageBox.Show("Quotation saved successfully!");

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error addProductIntoTable!\n" + e.Message);
                }
            }
        }

        private void btn_POadd_Click(object sender, EventArgs e)
        {
            try
            {
                clearFormData();
                int tempPONumber;
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string getLastIdQuery = "SELECT MAX(OrderNumber) FROM SMD_ProdOrder";
                    using (OleDbCommand cmd = new OleDbCommand(getLastIdQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int newPONumber = (result != DBNull.Value && result != null) ? int.Parse(result.ToString().Substring(2)) + 1 : 1;
                        tempPONumber = newPONumber;
                    }
                    conn.Close();
                }
                OrderNoTextBox.Text = $"PO{tempPONumber:D5}";

                dgvProdOrderList.Refresh();
                LoadProdOrderTable();

                MessageBox.Show("PO data prepared. Click Save to store in database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing PO data!\n" + ex.Message);
            }
        }

        private void btnPOsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ReferenceQuoteTextBox.Text))
                {
                    MessageBox.Show("No refernce quote. Please add a reference quote first.");
                    return;
                }
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO SMD_ProdOrder (OrderNumber, ODate, ProductID, RefQuotation, Qty, Remark, ESD, EED) " +
                                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.Add("OrderNumber", OleDbType.VarChar).Value = OrderNoTextBox.Text;
                        insertCmd.Parameters.Add("ODate", OleDbType.Date).Value = dateTimePicker2.Value.ToString("MM/dd/yyyy");
                        insertCmd.Parameters.Add("ProductID", OleDbType.VarChar).Value = productIdText.Text;
                        insertCmd.Parameters.Add("RefQuotation", OleDbType.VarChar).Value = ReferenceQuoteTextBox.Text;
                        insertCmd.Parameters.Add("Qty", OleDbType.VarChar).Value = PoQtyText.Text;
                        insertCmd.Parameters.Add("Remark", OleDbType.VarChar).Value = NotesOrInstructionsTextBox.Text;
                        insertCmd.Parameters.Add("ESD", OleDbType.Date).Value = dateTimePicker3.Value.ToString("MM/dd/yyyy");
                        insertCmd.Parameters.Add("EED", OleDbType.Date).Value = dateTimePicker4.Value.ToString("MM/dd/yyyy");

                        insertCmd.ExecuteNonQuery();
                    }

                    conn.Close();

                    dgvProdOrderList.Refresh();
                    LoadProdOrderTable();

                    MessageBox.Show("Product Order saved successfully!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving PO to database!\n" + ex.Message);
            }
        }

    }
}

