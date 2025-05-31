using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class RaD_Form : Form
    {
        private BindingList<Product> productList = new BindingList<Product>();
        private Dictionary<string, ProjectInfo> projects;

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

        public RaD_Form()
        {
            InitializeComponent();
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
    }
}
