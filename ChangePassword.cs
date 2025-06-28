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
    public partial class ChangePassword : Form
    {
        public string DepartmentName { get; set; }
        public string Username { get; set; }
        private Form parentForm;

        public ChangePassword(Form parentForm = null)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label30.Text = Username;
            label31.Text = DepartmentName;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            parentForm.Close();
            this.Hide();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
            Login loginForm = new Login();
            loginForm.ShowDialog();
            Application.Exit();
        }
    }
}
