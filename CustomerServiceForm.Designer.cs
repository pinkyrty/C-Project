namespace C_Project
{
    partial class CustomerServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerServiceForm));
            tabMain = new TabControl();
            InteractionRecordsTabPage = new TabPage();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            SaveButton = new Button();
            groupBox1 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            comboBox3 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ReturnAndExchangeAreaTabPage = new TabPage();
            RaEaSaveButton = new Button();
            dataGridView2 = new DataGridView();
            label14 = new Label();
            label2 = new Label();
            Department = new Label();
            UserName = new Label();
            UserNamelabel = new Label();
            pictureBox1 = new PictureBox();
            ExportToExcelButton = new Button();
            RaDUserPrifileButton = new Button();
            label31 = new Label();
            label30 = new Label();
            btnLogout = new Button();
            tabMain.SuspendLayout();
            InteractionRecordsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ReturnAndExchangeAreaTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(InteractionRecordsTabPage);
            tabMain.Controls.Add(ReturnAndExchangeAreaTabPage);
            tabMain.Location = new Point(12, 121);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1129, 725);
            tabMain.TabIndex = 0;
            // 
            // InteractionRecordsTabPage
            // 
            InteractionRecordsTabPage.Controls.Add(splitContainer1);
            InteractionRecordsTabPage.Location = new Point(4, 24);
            InteractionRecordsTabPage.Name = "InteractionRecordsTabPage";
            InteractionRecordsTabPage.Padding = new Padding(3);
            InteractionRecordsTabPage.Size = new Size(1121, 697);
            InteractionRecordsTabPage.TabIndex = 0;
            InteractionRecordsTabPage.Text = "Interaction Records";
            InteractionRecordsTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SaveButton);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1115, 691);
            splitContainer1.SplitterDistance = 371;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(363, 662);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "Interaction Records Overview";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(642, 661);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(95, 27);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(6, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 629);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(471, 312);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(245, 311);
            textBox6.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 312);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 311);
            textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(408, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(302, 23);
            textBox4.TabIndex = 18;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Pending", "Following up", "Completed" });
            comboBox3.Location = new Point(137, 257);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(171, 23);
            comboBox3.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(372, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(471, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 23);
            textBox2.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Product Consultation", "Technical Support", "Complaint", "Return or Exchange", "Other" });
            comboBox2.Location = new Point(109, 152);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(183, 23);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phone", "Email", "Live Chat", "Other" });
            comboBox1.Location = new Point(545, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(67, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(348, 315);
            label13.Name = "label13";
            label13.Size = new Size(125, 15);
            label13.TabIndex = 10;
            label13.Text = "Customer Feedback: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 315);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 9;
            label12.Text = "Follow-up: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(348, 260);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 8;
            label11.Text = "Solution: ";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 260);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 7;
            label10.Text = "Processing Status: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 207);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 6;
            label9.Text = "Content Summary: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 155);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 5;
            label8.Text = "Responsible Person: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 155);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 4;
            label7.Text = "Inquiry Type: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(419, 104);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 3;
            label6.Text = "Contact Information: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 104);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 2;
            label5.Text = "Customer Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 53);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 1;
            label4.Text = "Time: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 53);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 0;
            label3.Text = "Date: ";
            // 
            // ReturnAndExchangeAreaTabPage
            // 
            ReturnAndExchangeAreaTabPage.Controls.Add(RaEaSaveButton);
            ReturnAndExchangeAreaTabPage.Controls.Add(dataGridView2);
            ReturnAndExchangeAreaTabPage.Controls.Add(label14);
            ReturnAndExchangeAreaTabPage.Location = new Point(4, 24);
            ReturnAndExchangeAreaTabPage.Name = "ReturnAndExchangeAreaTabPage";
            ReturnAndExchangeAreaTabPage.Padding = new Padding(3);
            ReturnAndExchangeAreaTabPage.Size = new Size(1121, 697);
            ReturnAndExchangeAreaTabPage.TabIndex = 1;
            ReturnAndExchangeAreaTabPage.Text = "Return and Exchange Area";
            ReturnAndExchangeAreaTabPage.UseVisualStyleBackColor = true;
            // 
            // RaEaSaveButton
            // 
            RaEaSaveButton.Location = new Point(3, 671);
            RaEaSaveButton.Name = "RaEaSaveButton";
            RaEaSaveButton.Size = new Size(75, 23);
            RaEaSaveButton.TabIndex = 2;
            RaEaSaveButton.Text = "Save";
            RaEaSaveButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 21);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1121, 644);
            dataGridView2.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 3);
            label14.Name = "label14";
            label14.Size = new Size(156, 15);
            label14.TabIndex = 0;
            label14.Text = "Return and Exchange Area";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(111, 39);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 68;
            label2.Text = "Department :";
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Location = new Point(184, 49);
            Department.Name = "Department";
            Department.Size = new Size(0, 15);
            Department.TabIndex = 67;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(178, 20);
            UserName.Name = "UserName";
            UserName.Size = new Size(0, 15);
            UserName.TabIndex = 66;
            // 
            // UserNamelabel
            // 
            UserNamelabel.AutoSize = true;
            UserNamelabel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            UserNamelabel.Location = new Point(111, 12);
            UserNamelabel.Name = "UserNamelabel";
            UserNamelabel.Size = new Size(78, 15);
            UserNamelabel.TabIndex = 65;
            UserNamelabel.Text = "User Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // ExportToExcelButton
            // 
            ExportToExcelButton.Location = new Point(1033, 114);
            ExportToExcelButton.Name = "ExportToExcelButton";
            ExportToExcelButton.Size = new Size(108, 25);
            ExportToExcelButton.TabIndex = 69;
            ExportToExcelButton.Text = "Export to Excel";
            ExportToExcelButton.UseVisualStyleBackColor = true;
            // 
            // RaDUserPrifileButton
            // 
            RaDUserPrifileButton.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            RaDUserPrifileButton.Location = new Point(1091, 12);
            RaDUserPrifileButton.Name = "RaDUserPrifileButton";
            RaDUserPrifileButton.Size = new Size(59, 38);
            RaDUserPrifileButton.TabIndex = 70;
            RaDUserPrifileButton.Text = "User Profile";
            RaDUserPrifileButton.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(202, 39);
            label31.Name = "label31";
            label31.Size = new Size(49, 15);
            label31.TabIndex = 72;
            label31.Text = "label31";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(202, 12);
            label30.Name = "label30";
            label30.Size = new Size(49, 15);
            label30.TabIndex = 71;
            label30.Text = "label30";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1028, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(57, 38);
            btnLogout.TabIndex = 73;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // CustomerServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1153, 858);
            Controls.Add(btnLogout);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(RaDUserPrifileButton);
            Controls.Add(ExportToExcelButton);
            Controls.Add(label2);
            Controls.Add(Department);
            Controls.Add(UserName);
            Controls.Add(UserNamelabel);
            Controls.Add(pictureBox1);
            Controls.Add(tabMain);
            Name = "CustomerServiceForm";
            Text = "CustomerServiceForm";
            Load += CustomerServiceForm_Load;
            tabMain.ResumeLayout(false);
            InteractionRecordsTabPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ReturnAndExchangeAreaTabPage.ResumeLayout(false);
            ReturnAndExchangeAreaTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabMain;
        private TabPage InteractionRecordsTabPage;
        private TabPage ReturnAndExchangeAreaTabPage;
        private Label label2;
        private Label Department;
        private Label UserName;
        private Label UserNamelabel;
        private PictureBox pictureBox1;
        private Button ExportToExcelButton;
        private Button RaDUserPrifileButton;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button SaveButton;
        private GroupBox groupBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label13;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private ComboBox comboBox3;
        private Button RaEaSaveButton;
        private DataGridView dataGridView2;
        private Label label14;
        private Label label31;
        private Label label30;
        private Button btnLogout;
    }
}