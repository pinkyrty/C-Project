using System.Windows.Forms;

namespace C_Project
{
    partial class IT_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT_Form));
            pictureBox1 = new PictureBox();
            Department = new Label();
            label2 = new Label();
            UserName = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            DepartmentEntranceTabPage = new TabPage();
            label29 = new Label();
            FinanceButton = new Button();
            CustomerServiceButton = new Button();
            SupplyChainButton = new Button();
            ProductionButton = new Button();
            LogisticButton = new Button();
            SalesButton = new Button();
            RnDbutton = new Button();
            UserManagementTabPage = new TabPage();
            btn_UserSave = new Button();
            btn_UserAdd = new Button();
            dataGridView1 = new DataGridView();
            RepairSupportTabPage = new TabPage();
            btn_RepairSave = new Button();
            btn_RepairAdd = new Button();
            repairStatusCombo = new ComboBox();
            repairSubText = new TextBox();
            repairSubjectText = new TextBox();
            repairTicketNoText = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            AssetManagementTabPage = new TabPage();
            btn_AssetSave = new Button();
            btn_AssetAdd = new Button();
            assetStatusCombo = new ComboBox();
            assetTypeText = new TextBox();
            assetNameText = new TextBox();
            assetNumberText = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            dataGridView3 = new DataGridView();
            MaintenanceLogTabPage = new TabPage();
            AddNewLogButton = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            dataGridView4 = new DataGridView();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnUserProfile = new Button();
            label30 = new Label();
            label31 = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            DepartmentEntranceTabPage.SuspendLayout();
            UserManagementTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            RepairSupportTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            AssetManagementTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            MaintenanceLogTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Location = new Point(189, 38);
            Department.Name = "Department";
            Department.Size = new Size(0, 15);
            Department.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(111, 39);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 11;
            label2.Text = "Department :";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(180, 12);
            UserName.Name = "UserName";
            UserName.Size = new Size(0, 15);
            UserName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(111, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 9;
            label1.Text = "User Name :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(DepartmentEntranceTabPage);
            tabControl1.Controls.Add(UserManagementTabPage);
            tabControl1.Controls.Add(RepairSupportTabPage);
            tabControl1.Controls.Add(AssetManagementTabPage);
            tabControl1.Controls.Add(MaintenanceLogTabPage);
            tabControl1.Location = new Point(12, 129);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1129, 717);
            tabControl1.TabIndex = 13;
            // 
            // DepartmentEntranceTabPage
            // 
            DepartmentEntranceTabPage.BackColor = SystemColors.GradientInactiveCaption;
            DepartmentEntranceTabPage.Controls.Add(label29);
            DepartmentEntranceTabPage.Controls.Add(FinanceButton);
            DepartmentEntranceTabPage.Controls.Add(CustomerServiceButton);
            DepartmentEntranceTabPage.Controls.Add(SupplyChainButton);
            DepartmentEntranceTabPage.Controls.Add(ProductionButton);
            DepartmentEntranceTabPage.Controls.Add(LogisticButton);
            DepartmentEntranceTabPage.Controls.Add(SalesButton);
            DepartmentEntranceTabPage.Controls.Add(RnDbutton);
            DepartmentEntranceTabPage.Location = new Point(4, 24);
            DepartmentEntranceTabPage.Name = "DepartmentEntranceTabPage";
            DepartmentEntranceTabPage.Size = new Size(1121, 689);
            DepartmentEntranceTabPage.TabIndex = 7;
            DepartmentEntranceTabPage.Text = "Department Entrance";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(30, 38);
            label29.Name = "label29";
            label29.Size = new Size(127, 15);
            label29.TabIndex = 7;
            label29.Text = "Department Entrance";
            // 
            // FinanceButton
            // 
            FinanceButton.Location = new Point(110, 522);
            FinanceButton.Name = "FinanceButton";
            FinanceButton.Size = new Size(199, 90);
            FinanceButton.TabIndex = 6;
            FinanceButton.Text = "Finance";
            FinanceButton.UseVisualStyleBackColor = true;
            FinanceButton.Click += FinanceButton_Click;
            // 
            // CustomerServiceButton
            // 
            CustomerServiceButton.Location = new Point(816, 309);
            CustomerServiceButton.Name = "CustomerServiceButton";
            CustomerServiceButton.Size = new Size(199, 90);
            CustomerServiceButton.TabIndex = 5;
            CustomerServiceButton.Text = "Customer Service";
            CustomerServiceButton.UseVisualStyleBackColor = true;
            CustomerServiceButton.Click += CustomerServiceButton_Click;
            // 
            // SupplyChainButton
            // 
            SupplyChainButton.Location = new Point(457, 309);
            SupplyChainButton.Name = "SupplyChainButton";
            SupplyChainButton.Size = new Size(199, 90);
            SupplyChainButton.TabIndex = 4;
            SupplyChainButton.Text = "Supply Chain";
            SupplyChainButton.UseVisualStyleBackColor = true;
            SupplyChainButton.Click += SupplyChainButton_Click;
            // 
            // ProductionButton
            // 
            ProductionButton.BackgroundImageLayout = ImageLayout.Center;
            ProductionButton.Location = new Point(110, 309);
            ProductionButton.Name = "ProductionButton";
            ProductionButton.Size = new Size(199, 90);
            ProductionButton.TabIndex = 3;
            ProductionButton.Text = "Production";
            ProductionButton.UseVisualStyleBackColor = true;
            ProductionButton.Click += ProductionButton_Click;
            // 
            // LogisticButton
            // 
            LogisticButton.Location = new Point(816, 102);
            LogisticButton.Name = "LogisticButton";
            LogisticButton.Size = new Size(199, 90);
            LogisticButton.TabIndex = 2;
            LogisticButton.Text = "Logistic and  Warehouse";
            LogisticButton.UseVisualStyleBackColor = true;
            LogisticButton.Click += LogisticButton_Click;
            // 
            // SalesButton
            // 
            SalesButton.Location = new Point(457, 102);
            SalesButton.Name = "SalesButton";
            SalesButton.Size = new Size(199, 90);
            SalesButton.TabIndex = 1;
            SalesButton.Text = "Sales And Marketing";
            SalesButton.UseVisualStyleBackColor = true;
            SalesButton.Click += SalesButton_Click;
            // 
            // RnDbutton
            // 
            RnDbutton.Location = new Point(110, 102);
            RnDbutton.Name = "RnDbutton";
            RnDbutton.Size = new Size(199, 90);
            RnDbutton.TabIndex = 0;
            RnDbutton.Text = "RnD";
            RnDbutton.UseVisualStyleBackColor = true;
            RnDbutton.Click += RnDbutton_Click;
            // 
            // UserManagementTabPage
            // 
            UserManagementTabPage.Controls.Add(btn_UserSave);
            UserManagementTabPage.Controls.Add(btn_UserAdd);
            UserManagementTabPage.Controls.Add(dataGridView1);
            UserManagementTabPage.Location = new Point(4, 24);
            UserManagementTabPage.Name = "UserManagementTabPage";
            UserManagementTabPage.Size = new Size(1121, 689);
            UserManagementTabPage.TabIndex = 3;
            UserManagementTabPage.Text = "User Management";
            UserManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // btn_UserSave
            // 
            btn_UserSave.Location = new Point(1041, 32);
            btn_UserSave.Name = "btn_UserSave";
            btn_UserSave.Size = new Size(75, 23);
            btn_UserSave.TabIndex = 28;
            btn_UserSave.Text = "Save";
            btn_UserSave.UseVisualStyleBackColor = true;
            btn_UserSave.Click += btn_UserSave_Click;
            // 
            // btn_UserAdd
            // 
            btn_UserAdd.Location = new Point(1041, 3);
            btn_UserAdd.Name = "btn_UserAdd";
            btn_UserAdd.Size = new Size(75, 23);
            btn_UserAdd.TabIndex = 27;
            btn_UserAdd.Text = "Add";
            btn_UserAdd.UseVisualStyleBackColor = true;
            btn_UserAdd.Click += btn_UserAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1035, 686);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RepairSupportTabPage
            // 
            RepairSupportTabPage.Controls.Add(btn_RepairSave);
            RepairSupportTabPage.Controls.Add(btn_RepairAdd);
            RepairSupportTabPage.Controls.Add(repairStatusCombo);
            RepairSupportTabPage.Controls.Add(repairSubText);
            RepairSupportTabPage.Controls.Add(repairSubjectText);
            RepairSupportTabPage.Controls.Add(repairTicketNoText);
            RepairSupportTabPage.Controls.Add(label10);
            RepairSupportTabPage.Controls.Add(label9);
            RepairSupportTabPage.Controls.Add(label8);
            RepairSupportTabPage.Controls.Add(label7);
            RepairSupportTabPage.Controls.Add(dataGridView2);
            RepairSupportTabPage.Location = new Point(4, 24);
            RepairSupportTabPage.Name = "RepairSupportTabPage";
            RepairSupportTabPage.Padding = new Padding(3);
            RepairSupportTabPage.Size = new Size(1121, 689);
            RepairSupportTabPage.TabIndex = 1;
            RepairSupportTabPage.Text = "Repair Support";
            RepairSupportTabPage.UseVisualStyleBackColor = true;
            // 
            // btn_RepairSave
            // 
            btn_RepairSave.Location = new Point(1043, 74);
            btn_RepairSave.Name = "btn_RepairSave";
            btn_RepairSave.Size = new Size(75, 23);
            btn_RepairSave.TabIndex = 29;
            btn_RepairSave.Text = "Save";
            btn_RepairSave.UseVisualStyleBackColor = true;
            btn_RepairSave.Click += btn_RepairSave_Click;
            // 
            // btn_RepairAdd
            // 
            btn_RepairAdd.Location = new Point(186, 44);
            btn_RepairAdd.Name = "btn_RepairAdd";
            btn_RepairAdd.Size = new Size(79, 23);
            btn_RepairAdd.TabIndex = 9;
            btn_RepairAdd.Text = "Add";
            btn_RepairAdd.UseVisualStyleBackColor = true;
            btn_RepairAdd.Click += btn_RepairAdd_Click;
            // 
            // repairStatusCombo
            // 
            repairStatusCombo.FormattingEnabled = true;
            repairStatusCombo.Items.AddRange(new object[] { "Pending", "Processing", "Resolved" });
            repairStatusCombo.Location = new Point(53, 45);
            repairStatusCombo.Name = "repairStatusCombo";
            repairStatusCombo.Size = new Size(121, 23);
            repairStatusCombo.TabIndex = 8;
            // 
            // repairSubText
            // 
            repairSubText.Enabled = false;
            repairSubText.Location = new Point(873, 6);
            repairSubText.Name = "repairSubText";
            repairSubText.Size = new Size(228, 23);
            repairSubText.TabIndex = 7;
            // 
            // repairSubjectText
            // 
            repairSubjectText.Location = new Point(396, 6);
            repairSubjectText.Name = "repairSubjectText";
            repairSubjectText.Size = new Size(362, 23);
            repairSubjectText.TabIndex = 6;
            // 
            // repairTicketNoText
            // 
            repairTicketNoText.Location = new Point(104, 6);
            repairTicketNoText.Name = "repairTicketNoText";
            repairTicketNoText.Size = new Size(174, 23);
            repairTicketNoText.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 48);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 4;
            label10.Text = "Status: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(805, 9);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 3;
            label9.Text = "Submitter: ";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 9);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 2;
            label8.Text = "Subject: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 9);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 1;
            label7.Text = "Ticket number: ";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 74);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1035, 615);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // AssetManagementTabPage
            // 
            AssetManagementTabPage.Controls.Add(btn_AssetSave);
            AssetManagementTabPage.Controls.Add(btn_AssetAdd);
            AssetManagementTabPage.Controls.Add(assetStatusCombo);
            AssetManagementTabPage.Controls.Add(assetTypeText);
            AssetManagementTabPage.Controls.Add(assetNameText);
            AssetManagementTabPage.Controls.Add(assetNumberText);
            AssetManagementTabPage.Controls.Add(label14);
            AssetManagementTabPage.Controls.Add(label13);
            AssetManagementTabPage.Controls.Add(label12);
            AssetManagementTabPage.Controls.Add(label11);
            AssetManagementTabPage.Controls.Add(dataGridView3);
            AssetManagementTabPage.Location = new Point(4, 24);
            AssetManagementTabPage.Name = "AssetManagementTabPage";
            AssetManagementTabPage.Size = new Size(1121, 689);
            AssetManagementTabPage.TabIndex = 2;
            AssetManagementTabPage.Text = "Asset Management";
            AssetManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // btn_AssetSave
            // 
            btn_AssetSave.Location = new Point(1043, 80);
            btn_AssetSave.Name = "btn_AssetSave";
            btn_AssetSave.Size = new Size(75, 23);
            btn_AssetSave.TabIndex = 30;
            btn_AssetSave.Text = "Save";
            btn_AssetSave.UseVisualStyleBackColor = true;
            btn_AssetSave.Click += btn_AssetSave_Click;
            // 
            // btn_AssetAdd
            // 
            btn_AssetAdd.Location = new Point(186, 50);
            btn_AssetAdd.Name = "btn_AssetAdd";
            btn_AssetAdd.Size = new Size(74, 23);
            btn_AssetAdd.TabIndex = 9;
            btn_AssetAdd.Text = "Add";
            btn_AssetAdd.UseVisualStyleBackColor = true;
            btn_AssetAdd.Click += btn_AssetAdd_Click;
            // 
            // assetStatusCombo
            // 
            assetStatusCombo.FormattingEnabled = true;
            assetStatusCombo.Items.AddRange(new object[] { "In use", "Repair", "Scrapped" });
            assetStatusCombo.Location = new Point(56, 51);
            assetStatusCombo.Name = "assetStatusCombo";
            assetStatusCombo.Size = new Size(121, 23);
            assetStatusCombo.TabIndex = 8;
            // 
            // assetTypeText
            // 
            assetTypeText.Location = new Point(829, 12);
            assetTypeText.Name = "assetTypeText";
            assetTypeText.Size = new Size(243, 23);
            assetTypeText.TabIndex = 7;
            // 
            // assetNameText
            // 
            assetNameText.Location = new Point(399, 12);
            assetNameText.Name = "assetNameText";
            assetNameText.Size = new Size(303, 23);
            assetNameText.TabIndex = 6;
            // 
            // assetNumberText
            // 
            assetNumberText.Location = new Point(107, 12);
            assetNumberText.Name = "assetNumberText";
            assetNumberText.Size = new Size(174, 23);
            assetNumberText.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 54);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 4;
            label14.Text = "Status: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(782, 15);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 3;
            label13.Text = "Type: ";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(345, 15);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 2;
            label12.Text = "Name: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 15);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 1;
            label11.Text = "Asset Number: ";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 80);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(1034, 606);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // MaintenanceLogTabPage
            // 
            MaintenanceLogTabPage.Controls.Add(AddNewLogButton);
            MaintenanceLogTabPage.Controls.Add(textBox3);
            MaintenanceLogTabPage.Controls.Add(textBox2);
            MaintenanceLogTabPage.Controls.Add(textBox1);
            MaintenanceLogTabPage.Controls.Add(dateTimePicker2);
            MaintenanceLogTabPage.Controls.Add(label23);
            MaintenanceLogTabPage.Controls.Add(label22);
            MaintenanceLogTabPage.Controls.Add(label21);
            MaintenanceLogTabPage.Controls.Add(label20);
            MaintenanceLogTabPage.Controls.Add(dataGridView4);
            MaintenanceLogTabPage.Location = new Point(4, 24);
            MaintenanceLogTabPage.Name = "MaintenanceLogTabPage";
            MaintenanceLogTabPage.Size = new Size(1121, 689);
            MaintenanceLogTabPage.TabIndex = 4;
            MaintenanceLogTabPage.Text = "Maintenance Log";
            MaintenanceLogTabPage.UseVisualStyleBackColor = true;
            // 
            // AddNewLogButton
            // 
            AddNewLogButton.Location = new Point(605, 661);
            AddNewLogButton.Name = "AddNewLogButton";
            AddNewLogButton.Size = new Size(121, 23);
            AddNewLogButton.TabIndex = 9;
            AddNewLogButton.Text = "+ Add New Log";
            AddNewLogButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 661);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(516, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(882, 622);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 622);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 23);
            textBox1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(57, 619);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(141, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(11, 664);
            label23.Name = "label23";
            label23.Size = new Size(61, 15);
            label23.TabIndex = 4;
            label23.Text = "Remarks: ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(776, 625);
            label22.Name = "label22";
            label22.Size = new Size(106, 15);
            label22.TabIndex = 3;
            label22.Text = "Person in charge: ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(263, 625);
            label21.Name = "label21";
            label21.Size = new Size(58, 15);
            label21.TabIndex = 2;
            label21.Text = "Content: ";
            label21.Click += label21_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(11, 625);
            label20.Name = "label20";
            label20.Size = new Size(40, 15);
            label20.TabIndex = 1;
            label20.Text = "Date: ";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(1143, 613);
            dataGridView4.TabIndex = 0;
            // 
            // btnUserProfile
            // 
            btnUserProfile.Location = new Point(1091, 12);
            btnUserProfile.Name = "btnUserProfile";
            btnUserProfile.Size = new Size(59, 38);
            btnUserProfile.TabIndex = 21;
            btnUserProfile.Text = "User Profile";
            btnUserProfile.UseVisualStyleBackColor = true;
            btnUserProfile.Click += btnUserProfile_click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(202, 12);
            label30.Name = "label30";
            label30.Size = new Size(49, 15);
            label30.TabIndex = 22;
            label30.Text = "label30";
            label30.Click += label30_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(202, 39);
            label31.Name = "label31";
            label31.Size = new Size(49, 15);
            label31.TabIndex = 23;
            label31.Text = "label31";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1028, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(57, 38);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // IT_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1153, 858);
            Controls.Add(btnLogout);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(btnUserProfile);
            Controls.Add(tabControl1);
            Controls.Add(Department);
            Controls.Add(label2);
            Controls.Add(UserName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "IT_Form";
            Text = "IT_Form";
            Load += IT_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            DepartmentEntranceTabPage.ResumeLayout(false);
            DepartmentEntranceTabPage.PerformLayout();
            UserManagementTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            RepairSupportTabPage.ResumeLayout(false);
            RepairSupportTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            AssetManagementTabPage.ResumeLayout(false);
            AssetManagementTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            MaintenanceLogTabPage.ResumeLayout(false);
            MaintenanceLogTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Department;
        private Label label2;
        private Label UserName;
        private Label label1;
        private TabControl tabControl1;
        private TabPage RepairSupportTabPage;
        private TabPage AssetManagementTabPage;
        private TabPage UserManagementTabPage;
        private TabPage MaintenanceLogTabPage;
        private TabPage DepartmentEntranceTabPage;
        private ComboBox repairStatusCombo;
        private TextBox repairSubText;
        private TextBox repairSubjectText;
        private TextBox repairTicketNoText;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView2;
        private Button btn_RepairAdd;
        private Button btn_AssetAdd;
        private ComboBox assetStatusCombo;
        private TextBox assetTypeText;
        private TextBox assetNameText;
        private TextBox assetNumberText;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private DataGridView dataGridView3;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private DataGridView dataGridView4;
        private Button AddNewLogButton;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label29;
        private Button FinanceButton;
        private Button CustomerServiceButton;
        private Button SupplyChainButton;
        private Button ProductionButton;
        private Button LogisticButton;
        private Button SalesButton;
        private Button RnDbutton;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnUserProfile;
        private Label label30;
        private Label label31;
        private System.Windows.Forms.Button btnLogout;
        private Button btn_UserAdd;
        private Button btn_UserSave;
        private Button btn_RepairSave;
        private Button btn_AssetSave;
    }
}