using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
        private static System.Data.DataTable materialDataTable;

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
            this.LoadOrderFileTable();
            this.LoadProdOrderTable();
            this.prefillAfterLoadProdOrderTable();
            this.LoadMaterialsToComboBox();
            dgvProdOrderList.CellClick += new DataGridViewCellEventHandler(dgvProdOrderList_CellClick);
            dgvQuoteList.CellClick += new DataGridViewCellEventHandler(dgvQuoteList_CellClick);
            this.LoadOrderTable();
            InitializeQuotationDetailTable();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
            dgvProdOrderList.ClearSelection();
            dgvProdOrderList.CurrentCell = null;
        }

        //first Tab
        private void LoadQuotationlTable()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    string sql = "SELECT * FROM SMD_Quotation";
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

                            foreach (DataGridViewColumn column in dgvQuoteList.Columns)
                            {
                                if (column.Name != "QuotationNumber" && column.Name != "QDate" && column.Name != "ClientName")
                                {
                                    column.Visible = false;
                                }
                            }
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
            ConfigureQuotationDetailColumns();
        }

        private void ConfigureQuotationDetailColumns()
        {
            // 确保列名与查询结果匹配，并设置显示名称
            dataGridView2.AutoGenerateColumns = false; // 禁用自动生成列
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductID",
                HeaderText = "Product ID",
                Name = "ProductID"
            });
            // 添加列并设置属性
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product Name",
                Name = "ProductName"
            });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                HeaderText = "Quantity",
                Name = "Qty"
            });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "Unit Price",
                Name = "UnitPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // 货币格式
            });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Amount",
                Name = "Amount",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // 货币格式
            });
            dataGridView2.Columns["ProductID"].Visible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToResizeColumns = false;
        }

        private void ConfigureMaterialDetailColumns()
        {
            // 确保列名与查询结果匹配，并设置显示名称
            dataGridView3.AutoGenerateColumns = false; // 禁用自动生成列
            dataGridView3.Columns.Clear();

            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OMatID",
                HeaderText = "OMatID",
                Name = "OMatID"
            });
            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaterialID",
                HeaderText = "Material ID",
                Name = "MaterialID"
            });
            // 添加列并设置属性
            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaterialName",
                HeaderText = "Name",
                Name = "MaterialName"
            });
            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Spec",
                HeaderText = "Spec",
                Name = "Spec"
            });
            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NeedQty",
                HeaderText = "Quantity Need",
                Name = "NeedQty",
            });
            dataGridView3.Columns["OMatID"].Visible = false;
            dataGridView3.Columns["MaterialID"].Visible = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AllowUserToResizeColumns = false;
        }

        private void LoadQuotationDetailTable(string quotationID)
        {
            try
            {
                if (string.IsNullOrEmpty(quotationID))
                {
                    MessageBox.Show("No valid Quotation ID selected.");
                    dataGridView2.DataSource = null;
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    // Updated SQL query to properly reference tables and aliases
                    string sql = @"
                        SELECT 
                            SMD_QuotationDetail.ProductID,
                            RND_Product.Name AS ProductName,
                            SMD_QuotationDetail.Qty,
                            SMD_QuotationDetail.UnitPrice,
                            SMD_QuotationDetail.Amount
                        FROM SMD_QuotationDetail
                        INNER JOIN RND_Product ON (SMD_QuotationDetail.ProductID = RND_Product.ProductID)
                        WHERE SMD_QuotationDetail.QuotationID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.Add("QuotationID", OleDbType.Integer).Value = Convert.ToInt32(quotationID);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            quotationDetailDataTable = new System.Data.DataTable();
                            adapter.Fill(quotationDetailDataTable);
                            dataGridView2.DataSource = quotationDetailDataTable;
                            ConfigureQuotationDetailColumns();
                            dataGridView2.Refresh();
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quotation details!\nMessage: {ex.Message}\nStack Trace: {ex.StackTrace}");
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
                    // SQL query to include all relevant columns
                    string sql = "SELECT OrderID, OrderNumber, ODate, ProductID, RefQuotation, Qty, Remark, ESD, EED FROM SMD_ProdOrder";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            prodOrderDataTable = new System.Data.DataTable();
                            adapter.Fill(prodOrderDataTable);
                            dgvProdOrderList.DataSource = prodOrderDataTable;

                            // Configure visible columns
                            dgvProdOrderList.Columns["OrderNumber"].HeaderText = "Order Number";
                            dgvProdOrderList.Columns["ODate"].HeaderText = "Order Date";

                            // Hide columns that shouldn't be displayed
                            dgvProdOrderList.Columns["OrderID"].Visible = false;
                            dgvProdOrderList.Columns["ProductID"].Visible = false;
                            dgvProdOrderList.Columns["RefQuotation"].Visible = false;
                            dgvProdOrderList.Columns["Qty"].Visible = false;
                            dgvProdOrderList.Columns["Remark"].Visible = false;
                            dgvProdOrderList.Columns["ESD"].Visible = false;
                            dgvProdOrderList.Columns["EED"].Visible = false;

                            // Configure DataGridView properties
                            dgvProdOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvProdOrderList.AllowUserToResizeColumns = false;

                            // Enable row selection, ensure headers are not highlighted
                            dgvProdOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dgvProdOrderList.ClearSelection();
                            dgvProdOrderList.MultiSelect = false;
                            dgvProdOrderList.EnableHeadersVisualStyles = false; // Ensures headers use default visual style (no highlight)
                            dgvProdOrderList.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvProdOrderList.ColumnHeadersDefaultCellStyle.BackColor; // Prevent header highlight
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

        private void prefillAfterLoadProdOrderTable()
        {
            DataRow selectedRow = prodOrderDataTable.Rows[0];
            if (selectedRow != null)
            {
                //LoadMaterialDetailTable(selectedRow["OrderID"].ToString());
                // Populate textboxes with data from the selected row
                OrderNoTextBox.Text = selectedRow["OrderNumber"].ToString() ?? "";
                productIdText.Text = selectedRow["ProductID"].ToString() ?? "";
                CustomerNameTextBox.Text = selectedRow["ProductID"].ToString() ?? ""; // Adjust if CustomerName is from another table
                dateTimePicker2.Value = Convert.ToDateTime(selectedRow["ODate"] ?? DateTime.Now);
                PoQtyText.Text = selectedRow["Qty"].ToString() ?? "";
                ReferenceQuoteTextBox.Text = selectedRow["RefQuotation"].ToString() ?? "";
                NotesOrInstructionsTextBox.Text = selectedRow["Remark"].ToString() ?? "";

                LoadMaterialDetailTable(selectedRow["OrderID"].ToString());
                // Populate ESD and EED DateTimePickers
                try
                {
                    dateTimePicker3.Value = selectedRow["ESD"] != null && selectedRow["ESD"] != DBNull.Value
                        ? Convert.ToDateTime(selectedRow["ESD"])
                        : DateTime.Now; // Default to current date if null
                    dateTimePicker4.Value = selectedRow["EED"] != null && selectedRow["EED"] != DBNull.Value
                        ? Convert.ToDateTime(selectedRow["EED"])
                        : DateTime.Now; // Default to current date if null
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error setting ESD or EED dates: {ex.Message}");
                    dateTimePicker3.Value = DateTime.Now;
                    dateTimePicker4.Value = DateTime.Now;
                }
            }
        }

        // Event handler for cell click to highlight row (not headers) and populate textboxes and DateTimePickers
        private void dgvProdOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadMaterialsToComboBox();
            // Check if a valid row is clicked (ignore header clicks)
            if (e.RowIndex >= 0 && e.RowIndex <= prodOrderDataTable.Rows.Count - 1)
            {
                // Get the selected row
                dgvProdOrderList.Rows[e.RowIndex].Selected = true;
                DataGridViewRow row = dgvProdOrderList.Rows[e.RowIndex];

                // Populate textboxes with data from the selected row
                OrderNoTextBox.Text = row.Cells["OrderNumber"].Value?.ToString() ?? "";
                productIdText.Text = row.Cells["ProductID"].Value?.ToString() ?? "";
                CustomerNameTextBox.Text = row.Cells["ProductID"].Value?.ToString() ?? ""; // Adjust if CustomerName is from another table
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["ODate"].Value ?? DateTime.Now);
                PoQtyText.Text = row.Cells["Qty"].Value?.ToString() ?? "";
                ReferenceQuoteTextBox.Text = row.Cells["RefQuotation"].Value?.ToString() ?? "";
                NotesOrInstructionsTextBox.Text = row.Cells["Remark"].Value?.ToString() ?? "";

                LoadMaterialDetailTable(row.Cells["OrderID"].Value?.ToString());
                // Populate ESD and EED DateTimePickers
                try
                {
                    dateTimePicker3.Value = row.Cells["ESD"].Value != null && row.Cells["ESD"].Value != DBNull.Value
                        ? Convert.ToDateTime(row.Cells["ESD"].Value)
                        : DateTime.Now; // Default to current date if null
                    dateTimePicker4.Value = row.Cells["EED"].Value != null && row.Cells["EED"].Value != DBNull.Value
                        ? Convert.ToDateTime(row.Cells["EED"].Value)
                        : DateTime.Now; // Default to current date if null
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error setting ESD or EED dates: {ex.Message}");
                    dateTimePicker3.Value = DateTime.Now;
                    dateTimePicker4.Value = DateTime.Now;
                }

            }
        }

        private void LoadMaterialDetailTable(string orderID)
        {
            try
            {
                if (string.IsNullOrEmpty(orderID))
                {
                    MessageBox.Show("No valid Order ID selected.");
                    dataGridView3.DataSource = null;
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    // Updated SQL query to properly reference tables and aliases
                    string sql = @"
                        SELECT
                            SMD_ProdOrderMat.OMatID,
                            SMD_ProdOrderMat.NeedQty,
                            SCM_Material.MaterialID,
                            SCM_Material.Name AS MaterialName,
                            SCM_Material.Spec
                        FROM SMD_ProdOrderMat
                        INNER JOIN SCM_Material ON (SMD_ProdOrderMat.MaterialID = SCM_Material.MaterialID)
                        WHERE SMD_ProdOrderMat.OrderID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.Add("OrderID", OleDbType.Integer).Value = Convert.ToInt32(orderID);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            materialDataTable = new System.Data.DataTable();
                            adapter.Fill(materialDataTable);
                            dataGridView3.DataSource = materialDataTable;
                            ConfigureMaterialDetailColumns();
                            dataGridView3.Refresh();
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quotation details!\nMessage: {ex.Message}\nStack Trace: {ex.StackTrace}");
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

                    string sql = "SELECT OMatID, MaterialID, MaterialName, Spec, NeedQty FROM SMD_ProdOrderMat";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            orderFileDataTable = new System.Data.DataTable();
                            adapter.Fill(orderFileDataTable);
                            dataGridView3.DataSource = orderFileDataTable;
                            dataGridView3.Columns["OMatID"].Visible = false;
                            dataGridView3.Columns["MaterialID"].Visible = false;
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

        private void genPDF_Click(object sender, EventArgs e)
        {
            string baseDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));
            string excelFilePath = Path.Combine(baseDirectory, "QuotationTemplate.xlsx");
            string excelPdfPath = Path.Combine(baseDirectory, "QuotationTemplateExcel.pdf");

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

            string date = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");

            string address = AddressTextBox.Text;
            string contactPerson = ContactPersonTextBox.Text;
            string telephone = TelephoneTextBox.Text;
            string deliveryTime = DeliveryTimeTextBox.Text;
            string transport = TransportationMethodTextBox.Text;
            string discount = DiscountsOrOffersTextBox.Text;
            string payment = PaymentTermsTextBox.Text;
            string offers = NotesOrtermsTextBox.Text;

            worksheet.Cells[8, 3].Value = customerName;
            worksheet.Cells[8, 6].Value = quotationNum;
            worksheet.Cells[12, 3].Value = address;

            worksheet.Cells[10, 6].NumberFormat = "@";
            worksheet.Cells[10, 6].Value = date;

            worksheet.Cells[10, 3].Value = contactPerson;
            worksheet.Cells[32, 3].Value = deliveryTime;
            worksheet.Cells[32, 6].Value = transport;
            worksheet.Cells[28, 6].Value = discount;
            worksheet.Cells[34, 3].Value = payment;
            worksheet.Cells[30, 4].Value = offers;
            worksheet.Cells[12, 6].Value = telephone;

            for (int i = 0; i < quotationDetailDataTable.Rows.Count; i++)
            {
                worksheet.Cells[i + 17, 2] = quotationDetailDataTable.Rows[i][1]; // ProductName
                worksheet.Cells[i + 17, 4] = quotationDetailDataTable.Rows[i][2]; // Qty
                worksheet.Cells[i + 17, 5] = quotationDetailDataTable.Rows[i][3]; // UnitPrice
                worksheet.Cells[i + 17, 6] = quotationDetailDataTable.Rows[i][4]; // Amount
            }
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

        private void clearProdOrderFormData()
        {
            OrderNoTextBox.Clear();
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            productIdText.Clear();
        }


        private void btn_quoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                clearFormData();
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
                QuoteNumberTextBox.Text = $"Q{tempQuoteNumber:D5}";

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

                    OleDbTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Check if QuotationNumber already exists
                        string checkQuery = "SELECT QuotationID FROM SMD_Quotation WHERE QuotationNumber = ?";
                        int? existingQuotationId = null;
                        using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn, transaction))
                        {
                            checkCmd.Parameters.Add("QuotationNumber", OleDbType.VarChar).Value = QuoteNumberTextBox.Text;
                            var result = checkCmd.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                existingQuotationId = Convert.ToInt32(result);
                            }
                        }

                        int newQuotationId;
                        if (existingQuotationId.HasValue)
                        {
                            // QuotationNumber exists, update the existing record
                            string updateQuery = "UPDATE SMD_Quotation SET QDate = ?, ClientName = ?, Address = ?, Contact = ?, Phone = ?, Delivery = ?, Shipping = ?, Payment = ?, Discount = ?, Remark = ? WHERE QuotationNumber = ?";
                            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.Add("QDate", OleDbType.Date).Value = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                                updateCmd.Parameters.Add("ClientName", OleDbType.VarChar).Value = CustomerNameTextBox.Text;
                                updateCmd.Parameters.Add("Address", OleDbType.VarChar).Value = AddressTextBox.Text;
                                updateCmd.Parameters.Add("Contact", OleDbType.VarChar).Value = ContactPersonTextBox.Text;
                                updateCmd.Parameters.Add("Phone", OleDbType.VarChar).Value = TelephoneTextBox.Text;
                                updateCmd.Parameters.Add("Delivery", OleDbType.VarChar).Value = DeliveryTimeTextBox.Text;
                                updateCmd.Parameters.Add("Shipping", OleDbType.VarChar).Value = TransportationMethodTextBox.Text;
                                updateCmd.Parameters.Add("Payment", OleDbType.VarChar).Value = PaymentTermsTextBox.Text;
                                updateCmd.Parameters.Add("Discount", OleDbType.VarChar).Value = DiscountsOrOffersTextBox.Text;
                                updateCmd.Parameters.Add("Remark", OleDbType.VarChar).Value = NotesOrtermsTextBox.Text;
                                updateCmd.Parameters.Add("QuotationNumber", OleDbType.VarChar).Value = QuoteNumberTextBox.Text;

                                updateCmd.ExecuteNonQuery();
                            }

                            newQuotationId = existingQuotationId.Value;

                            // Optionally, delete existing details to avoid duplicates
                            string deleteDetailQuery = "DELETE FROM SMD_QuotationDetail WHERE QuotationID = ?";
                            using (OleDbCommand deleteCmd = new OleDbCommand(deleteDetailQuery, conn, transaction))
                            {
                                deleteCmd.Parameters.Add("QuotationID", OleDbType.Integer).Value = newQuotationId;
                                deleteCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // QuotationNumber does not exist, insert new record
                            string insertQuery = "INSERT INTO SMD_Quotation (QuotationNumber, QDate, ClientName, Address, Contact, Phone, Delivery, Shipping, Payment, Discount, Remark) " +
                                                "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn, transaction))
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

                                string idQuery = "SELECT @@IDENTITY;";
                                using (OleDbCommand idCmd = new OleDbCommand(idQuery, conn, transaction))
                                {
                                    newQuotationId = Convert.ToInt32(idCmd.ExecuteScalar());
                                }
                            }
                        }

                        // Insert details for the quotation
                        string insertDetailQuery = "INSERT INTO SMD_QuotationDetail (QuotationNumber, QuotationID, ProductID, Qty, UnitPrice, Amount) " +
                                                  "VALUES (?, ?, ?, ?, ?, ?)";
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            if (row.IsNewRow || row.Cells[0].Value == null) continue;

                            using (OleDbCommand detailCmd = new OleDbCommand(insertDetailQuery, conn, transaction))
                            {
                                detailCmd.Parameters.Add("QuotationNumber", OleDbType.VarChar).Value = QuoteNumberTextBox.Text;
                                detailCmd.Parameters.Add("QuotationID", OleDbType.Integer).Value = newQuotationId;
                                detailCmd.Parameters.Add("ProductID", OleDbType.VarChar).Value = row.Cells["ProductID"].Value?.ToString() ?? "";
                                detailCmd.Parameters.Add("Qty", OleDbType.VarChar).Value = row.Cells["Qty"].Value?.ToString() ?? "";
                                detailCmd.Parameters.Add("UnitPrice", OleDbType.Currency).Value = Convert.ToDecimal(row.Cells["UnitPrice"].Value ?? 0.0m);
                                detailCmd.Parameters.Add("Amount", OleDbType.Currency).Value = Convert.ToDecimal(row.Cells["Amount"].Value ?? 0.0m);

                                detailCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        conn.Close();

                        clearProdOrderFormData();
                        dgvQuoteList.Refresh();
                        LoadQuotationlTable();

                        MessageBox.Show("Quotation saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        transaction?.Rollback();
                        throw new Exception("保存报价或明细时出错：" + ex.Message);
                    }
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
                clearProdOrderFormData();
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

                    OleDbTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Check if QuotationNumber already exists
                        string checkQuery = "SELECT OrderID FROM SMD_ProdOrder WHERE OrderNumber = ?";
                        int? existingOrderId = null;
                        using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn, transaction))
                        {
                            checkCmd.Parameters.Add("QuotationNumber", OleDbType.VarChar).Value = OrderNoTextBox.Text;
                            var result = checkCmd.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                existingOrderId = Convert.ToInt32(result);
                            }
                        }

                        int newOrderId;
                        if (existingOrderId.HasValue)
                        {
                            newOrderId = existingOrderId.Value;
                            // QuotationNumber exists, update the existing record
                            string updateQuery = "UPDATE SMD_ProdOrder SET ODate = ?, ProductID = ?, RefQuotation = ?, Qty = ?, Remark = ?, ESD = ?, EED = ? WHERE OrderID = ?";
                            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.Add("ODate", OleDbType.Date).Value = dateTimePicker2.Value.ToString("MM/dd/yyyy");
                                updateCmd.Parameters.Add("ProductID", OleDbType.VarChar).Value = productIdText.Text;
                                updateCmd.Parameters.Add("RefQuotation", OleDbType.VarChar).Value = ReferenceQuoteTextBox.Text;
                                updateCmd.Parameters.Add("Qty", OleDbType.Integer).Value = Convert.ToInt32(PoQtyText.Text);
                                updateCmd.Parameters.Add("Remark", OleDbType.VarChar).Value = NotesOrInstructionsTextBox.Text;
                                updateCmd.Parameters.Add("ESD", OleDbType.Date).Value = dateTimePicker3.Value.ToString("MM/dd/yyyy");
                                updateCmd.Parameters.Add("EED", OleDbType.Date).Value = dateTimePicker4.Value.ToString("MM/dd/yyyy");
                                updateCmd.Parameters.Add("OrderID", OleDbType.VarChar).Value = newOrderId;

                                updateCmd.ExecuteNonQuery();
                            }

                        }
                        else
                        {
                            // QuotationNumber does not exist, insert new record
                            string insertQuery = "INSERT INTO SMD_ProdOrder (OrderNumber, ODate, ProductID, RefQuotation, Qty, Remark, ESD, EED) " +
                                                "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn, transaction))
                            {
                                insertCmd.Parameters.Add("OrderNumber", OleDbType.VarChar).Value = OrderNoTextBox.Text;
                                insertCmd.Parameters.Add("ODate", OleDbType.Date).Value = dateTimePicker2.Value.ToString("MM/dd/yyyy");
                                insertCmd.Parameters.Add("ProductID", OleDbType.VarChar).Value = productIdText.Text;
                                insertCmd.Parameters.Add("RefQuotation", OleDbType.VarChar).Value = ReferenceQuoteTextBox.Text;
                                insertCmd.Parameters.Add("Qty", OleDbType.Integer).Value = Convert.ToInt32(PoQtyText.Text);
                                insertCmd.Parameters.Add("Remark", OleDbType.VarChar).Value = NotesOrInstructionsTextBox.Text;
                                insertCmd.Parameters.Add("ESD", OleDbType.Date).Value = dateTimePicker3.Value.ToString("MM/dd/yyyy");
                                insertCmd.Parameters.Add("EED", OleDbType.Date).Value = dateTimePicker4.Value.ToString("MM/dd/yyyy");

                                insertCmd.ExecuteNonQuery();

                                string idQuery = "SELECT @@IDENTITY;";
                                using (OleDbCommand idCmd = new OleDbCommand(idQuery, conn, transaction))
                                {
                                    newOrderId = Convert.ToInt32(idCmd.ExecuteScalar());
                                }
                            }
                        }


                        transaction.Commit();

                        conn.Close();

                        this.SaveMaterialDataTable(newOrderId);


                        clearFormData();
                        dgvProdOrderList.Refresh();
                        LoadProdOrderTable();

                        MessageBox.Show("Prod Order saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        transaction?.Rollback();
                        throw new Exception("保存报价或明细时出错：" + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving quotation to database!\n" + ex.Message);
            }
        }

        private void SaveMaterialDataTable(int orderId)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    foreach (DataRow row in orderFileDataTable.Rows)
                    {
                        bool isNewRow = row["OMatID"] == DBNull.Value || Convert.ToInt32(row["OMatID"]) == -1;
                        if (isNewRow)
                        {
                            // 插入新行
                            string insertSql = "INSERT INTO SMD_ProdOrderMat (OrderID, MaterialID, MaterialName, Spec, NeedQty, StockQty) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(insertSql, conn))
                            {
                                cmd.Parameters.AddWithValue("?", orderId.ToString());
                                cmd.Parameters.AddWithValue("?", row["MaterialID"].ToString());
                                cmd.Parameters.AddWithValue("?", row["MaterialName"].ToString());
                                cmd.Parameters.AddWithValue("?", row["Spec"].ToString());
                                cmd.Parameters.AddWithValue("?", Convert.ToInt32(row["NeedQty"]));
                                cmd.Parameters.AddWithValue("?", 0);
                                cmd.ExecuteNonQuery();
                            }

                            //// 可選：獲取新插入的 MaterialID（如果需要）
                            //string getIdSql = "SELECT @@IDENTITY";
                            //using (OleDbCommand cmd = new OleDbCommand(getIdSql, conn))
                            //{
                            //    materialId = Convert.ToInt32(cmd.ExecuteScalar());
                            //    row["MaterialID"] = materialId; // 更新 DataTable 中的 MaterialID
                            //}
                        }
                    }

                    conn.Close();
                    MessageBox.Show("數據已成功保存到資料庫！");

                    // 可選：重新加載數據以刷新 DataGridView
                    LoadOrderFileTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存數據時發生錯誤！\n" + ex.Message);
            }
        }

        private void dgvQuoteList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                // Highlight the selected row
                dgvQuoteList.Rows[e.RowIndex].Selected = true;

                // Get the selected row from the DataTable
                if (quotationlDataTable.Rows.Count > e.RowIndex)
                {
                    DataRow selectedRow = quotationlDataTable.Rows[e.RowIndex];

                    // Populate the textboxes with the selected row's data
                    QuoteNumberTextBox.Text = selectedRow["QuotationNumber"].ToString();
                    dateTimePicker1.Text = selectedRow["QDate"].ToString();
                    CustomerNameTextBox.Text = selectedRow["ClientName"].ToString();
                    AddressTextBox.Text = selectedRow["Address"].ToString();
                    ContactPersonTextBox.Text = selectedRow["Contact"].ToString();
                    TelephoneTextBox.Text = selectedRow["Phone"].ToString();
                    DeliveryTimeTextBox.Text = selectedRow["Delivery"].ToString();
                    TransportationMethodTextBox.Text = selectedRow["Shipping"].ToString();
                    PaymentTermsTextBox.Text = selectedRow["Payment"].ToString();
                    DiscountsOrOffersTextBox.Text = selectedRow["Discount"].ToString();
                    NotesOrtermsTextBox.Text = selectedRow["Remark"].ToString();

                    // Load the quotation details into dataGridView2 using QuotationID
                    string quotationID = selectedRow["QuotationID"].ToString();
                    LoadQuotationDetailTable(quotationID);
                }

            }
        }

        private void LoadMaterialsToComboBox()
        {
            try
            {
                materialChoose.DataSource = null;
                materialSpec.Text = string.Empty;

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT MaterialID, Name FROM SCM_Material";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            adapter.Fill(dt);

                            // 綁定數據到 ComboBox
                            materialChoose.DataSource = dt;
                            materialChoose.DisplayMember = "Name"; // 顯示名稱
                            materialChoose.ValueMember = "MaterialID";    // 值為 ID
                            materialChoose.SelectedIndex = -1;     // 預設不選擇任何項目
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading materials!\n" + ex.Message);
            }
        }

        private void materialChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialChoose.SelectedValue != null)
            {
                string selectedMaterial = materialChoose.SelectedValue.ToString();
                LoadMaterialSpec(selectedMaterial);
            }
        }

        private void LoadMaterialSpec(string materialId)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT Spec FROM SCM_Material WHERE MaterialID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", materialId);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            materialSpec.Text = result.ToString();
                        }
                        else
                        {
                            materialSpec.Text = "Specification not found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading material specification!\n" + ex.Message);
            }
        }

        public System.Data.DataTable GetQuotationDetailData()
        {
            return quotationDetailDataTable;
        }

        private void NewMaterialsButton_Click(object sender, EventArgs e)
        {
            if (orderFileDataTable == null)
            {
                MessageBox.Show("請先加載數據表！");
                return;
            }

            if (materialChoose.SelectedValue != null)
            {
                // 獲取選中的 ID
                string selectedId = materialChoose.SelectedValue.ToString();
                // 獲取選中的名稱
                string selectedName = materialChoose.Text;

                // 顯示選中的值（或根據需求進行其他操作）
                MessageBox.Show($"選中的 ID: {selectedId}, 名稱: {selectedName}");

                //// 添加新行
                DataRow newRow = orderFileDataTable.NewRow();
                newRow["OMatID"] = -1;
                newRow["MaterialID"] = selectedId; // 根據需求設置值
                newRow["MaterialName"] = selectedName; // 可從輸入框獲取
                newRow["Spec"] = materialSpec.Text; // 可從輸入框獲取
                newRow["NeedQty"] = materialQty.Text; // 可從輸入框獲取
                orderFileDataTable.Rows.Add(newRow);

                dataGridView3.DataSource = null;
                dataGridView3.DataSource = orderFileDataTable;
                //ConfigureMaterialDetailColumns();
                dataGridView3.Refresh();
            }
            else
            {
                MessageBox.Show("請先選擇一個材料！");
            }
        }
    }
}

