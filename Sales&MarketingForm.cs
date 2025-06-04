using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;

namespace C_Project
{
    public partial class Sales_MarketingForm : Form
    {
        public Sales_MarketingForm()
        {
            InitializeComponent();
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
                Worksheet worksheet = workbook.ActiveSheet;

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
    }
}
