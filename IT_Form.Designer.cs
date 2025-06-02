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
            DashboardTabPage = new TabPage();
            RepairSupportTabPage = new TabPage();
            dataGridView1 = new DataGridView();
            AssetManagementTabPage = new TabPage();
            UserManagementTabPage = new TabPage();
            MaintenanceLogTabPage = new TabPage();
            TechnicalSolutionsTabPage = new TabPage();
            StatisticalReportsTabPage = new TabPage();
            DepartmentEntranceTabPage = new TabPage();
            label3 = new Label();
            ActiveUsersTextBox = new TextBox();
            label4 = new Label();
            NumberofRepairTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            EventTextBox = new TextBox();
            AddNewEventsButton = new Button();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            TicketNumberTextBox = new TextBox();
            SubjectTextBox = new TextBox();
            SubmitterTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            AddNewButton = new Button();
            dataGridView3 = new DataGridView();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            AssetNumberTextBox = new TextBox();
            NameTextBox = new TextBox();
            TypeTextBox = new TextBox();
            AssetStatusComboBox = new ComboBox();
            AddNewAssetButton = new Button();
            dataGridView4 = new DataGridView();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            UserIDTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            DepartmentComboBox = new ComboBox();
            FullNameTextBox = new TextBox();
            ActiveComboBox = new ComboBox();
            AddNewUserButton = new Button();
            dataGridView5 = new DataGridView();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            AddNewLogButton = new Button();
            dataGridView6 = new DataGridView();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            TechniaslNameTextBox = new TextBox();
            TechnicalDepartmentComboBox = new ComboBox();
            ProgressTextBox = new TextBox();
            PersonInChargeTextBox = new TextBox();
            TechnicalStatusComboBox = new ComboBox();
            SolutionsButton = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            RnDbutton = new Button();
            SalesButton = new Button();
            MarketingButton = new Button();
            ProductionButton = new Button();
            SupplyChainButton = new Button();
            CustomerServiceButton = new Button();
            FinanceButton = new Button();
            label29 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            DashboardTabPage.SuspendLayout();
            RepairSupportTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            AssetManagementTabPage.SuspendLayout();
            UserManagementTabPage.SuspendLayout();
            MaintenanceLogTabPage.SuspendLayout();
            TechnicalSolutionsTabPage.SuspendLayout();
            DepartmentEntranceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
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
            label2.Location = new Point(108, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
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
            label1.Location = new Point(108, 12);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 9;
            label1.Text = "User Name :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(DashboardTabPage);
            tabControl1.Controls.Add(RepairSupportTabPage);
            tabControl1.Controls.Add(AssetManagementTabPage);
            tabControl1.Controls.Add(UserManagementTabPage);
            tabControl1.Controls.Add(MaintenanceLogTabPage);
            tabControl1.Controls.Add(TechnicalSolutionsTabPage);
            tabControl1.Controls.Add(StatisticalReportsTabPage);
            tabControl1.Controls.Add(DepartmentEntranceTabPage);
            tabControl1.Location = new Point(0, 133);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1025, 424);
            tabControl1.TabIndex = 13;
            // 
            // DashboardTabPage
            // 
            DashboardTabPage.Controls.Add(AddNewEventsButton);
            DashboardTabPage.Controls.Add(EventTextBox);
            DashboardTabPage.Controls.Add(label6);
            DashboardTabPage.Controls.Add(label5);
            DashboardTabPage.Controls.Add(dateTimePicker1);
            DashboardTabPage.Controls.Add(NumberofRepairTextBox);
            DashboardTabPage.Controls.Add(label4);
            DashboardTabPage.Controls.Add(ActiveUsersTextBox);
            DashboardTabPage.Controls.Add(label3);
            DashboardTabPage.Controls.Add(dataGridView1);
            DashboardTabPage.Location = new Point(4, 24);
            DashboardTabPage.Name = "DashboardTabPage";
            DashboardTabPage.Padding = new Padding(3);
            DashboardTabPage.Size = new Size(1017, 396);
            DashboardTabPage.TabIndex = 0;
            DashboardTabPage.Text = "Dashboard";
            DashboardTabPage.UseVisualStyleBackColor = true;
            // 
            // RepairSupportTabPage
            // 
            RepairSupportTabPage.Controls.Add(AddNewButton);
            RepairSupportTabPage.Controls.Add(StatusComboBox);
            RepairSupportTabPage.Controls.Add(SubmitterTextBox);
            RepairSupportTabPage.Controls.Add(SubjectTextBox);
            RepairSupportTabPage.Controls.Add(TicketNumberTextBox);
            RepairSupportTabPage.Controls.Add(label10);
            RepairSupportTabPage.Controls.Add(label9);
            RepairSupportTabPage.Controls.Add(label8);
            RepairSupportTabPage.Controls.Add(label7);
            RepairSupportTabPage.Controls.Add(dataGridView2);
            RepairSupportTabPage.Location = new Point(4, 24);
            RepairSupportTabPage.Name = "RepairSupportTabPage";
            RepairSupportTabPage.Padding = new Padding(3);
            RepairSupportTabPage.Size = new Size(1017, 396);
            RepairSupportTabPage.TabIndex = 1;
            RepairSupportTabPage.Text = "Repair support";
            RepairSupportTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1014, 256);
            dataGridView1.TabIndex = 0;
            // 
            // AssetManagementTabPage
            // 
            AssetManagementTabPage.Controls.Add(AddNewAssetButton);
            AssetManagementTabPage.Controls.Add(AssetStatusComboBox);
            AssetManagementTabPage.Controls.Add(TypeTextBox);
            AssetManagementTabPage.Controls.Add(NameTextBox);
            AssetManagementTabPage.Controls.Add(AssetNumberTextBox);
            AssetManagementTabPage.Controls.Add(label14);
            AssetManagementTabPage.Controls.Add(label13);
            AssetManagementTabPage.Controls.Add(label12);
            AssetManagementTabPage.Controls.Add(label11);
            AssetManagementTabPage.Controls.Add(dataGridView3);
            AssetManagementTabPage.Location = new Point(4, 24);
            AssetManagementTabPage.Name = "AssetManagementTabPage";
            AssetManagementTabPage.Size = new Size(1017, 396);
            AssetManagementTabPage.TabIndex = 2;
            AssetManagementTabPage.Text = "Asset management";
            AssetManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // UserManagementTabPage
            // 
            UserManagementTabPage.Controls.Add(AddNewUserButton);
            UserManagementTabPage.Controls.Add(ActiveComboBox);
            UserManagementTabPage.Controls.Add(FullNameTextBox);
            UserManagementTabPage.Controls.Add(DepartmentComboBox);
            UserManagementTabPage.Controls.Add(UserNameTextBox);
            UserManagementTabPage.Controls.Add(UserIDTextBox);
            UserManagementTabPage.Controls.Add(label19);
            UserManagementTabPage.Controls.Add(label18);
            UserManagementTabPage.Controls.Add(label17);
            UserManagementTabPage.Controls.Add(label16);
            UserManagementTabPage.Controls.Add(label15);
            UserManagementTabPage.Controls.Add(dataGridView4);
            UserManagementTabPage.Location = new Point(4, 24);
            UserManagementTabPage.Name = "UserManagementTabPage";
            UserManagementTabPage.Size = new Size(1017, 396);
            UserManagementTabPage.TabIndex = 3;
            UserManagementTabPage.Text = "User management";
            UserManagementTabPage.UseVisualStyleBackColor = true;
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
            MaintenanceLogTabPage.Controls.Add(dataGridView5);
            MaintenanceLogTabPage.Location = new Point(4, 24);
            MaintenanceLogTabPage.Name = "MaintenanceLogTabPage";
            MaintenanceLogTabPage.Size = new Size(1017, 396);
            MaintenanceLogTabPage.TabIndex = 4;
            MaintenanceLogTabPage.Text = "Maintenance log";
            MaintenanceLogTabPage.UseVisualStyleBackColor = true;
            // 
            // TechnicalSolutionsTabPage
            // 
            TechnicalSolutionsTabPage.Controls.Add(SolutionsButton);
            TechnicalSolutionsTabPage.Controls.Add(TechnicalStatusComboBox);
            TechnicalSolutionsTabPage.Controls.Add(PersonInChargeTextBox);
            TechnicalSolutionsTabPage.Controls.Add(ProgressTextBox);
            TechnicalSolutionsTabPage.Controls.Add(TechnicalDepartmentComboBox);
            TechnicalSolutionsTabPage.Controls.Add(TechniaslNameTextBox);
            TechnicalSolutionsTabPage.Controls.Add(label28);
            TechnicalSolutionsTabPage.Controls.Add(label27);
            TechnicalSolutionsTabPage.Controls.Add(label26);
            TechnicalSolutionsTabPage.Controls.Add(label25);
            TechnicalSolutionsTabPage.Controls.Add(label24);
            TechnicalSolutionsTabPage.Controls.Add(dataGridView6);
            TechnicalSolutionsTabPage.Location = new Point(4, 24);
            TechnicalSolutionsTabPage.Name = "TechnicalSolutionsTabPage";
            TechnicalSolutionsTabPage.Size = new Size(1017, 396);
            TechnicalSolutionsTabPage.TabIndex = 5;
            TechnicalSolutionsTabPage.Text = "Technical solutions";
            TechnicalSolutionsTabPage.UseVisualStyleBackColor = true;
            // 
            // StatisticalReportsTabPage
            // 
            StatisticalReportsTabPage.Location = new Point(4, 24);
            StatisticalReportsTabPage.Name = "StatisticalReportsTabPage";
            StatisticalReportsTabPage.Size = new Size(1017, 396);
            StatisticalReportsTabPage.TabIndex = 6;
            StatisticalReportsTabPage.Text = "Statistical reports";
            StatisticalReportsTabPage.UseVisualStyleBackColor = true;
            // 
            // DepartmentEntranceTabPage
            // 
            DepartmentEntranceTabPage.Controls.Add(label29);
            DepartmentEntranceTabPage.Controls.Add(FinanceButton);
            DepartmentEntranceTabPage.Controls.Add(CustomerServiceButton);
            DepartmentEntranceTabPage.Controls.Add(SupplyChainButton);
            DepartmentEntranceTabPage.Controls.Add(ProductionButton);
            DepartmentEntranceTabPage.Controls.Add(MarketingButton);
            DepartmentEntranceTabPage.Controls.Add(SalesButton);
            DepartmentEntranceTabPage.Controls.Add(RnDbutton);
            DepartmentEntranceTabPage.Location = new Point(4, 24);
            DepartmentEntranceTabPage.Name = "DepartmentEntranceTabPage";
            DepartmentEntranceTabPage.Size = new Size(1017, 396);
            DepartmentEntranceTabPage.TabIndex = 7;
            DepartmentEntranceTabPage.Text = "Department entrance";
            DepartmentEntranceTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 1;
            label3.Text = "Active users";
            // 
            // ActiveUsersTextBox
            // 
            ActiveUsersTextBox.Location = new Point(76, 14);
            ActiveUsersTextBox.Name = "ActiveUsersTextBox";
            ActiveUsersTextBox.Size = new Size(100, 23);
            ActiveUsersTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 17);
            label4.Name = "label4";
            label4.Size = new Size(206, 15);
            label4.TabIndex = 3;
            label4.Text = "Number of repair orders this month";
            // 
            // NumberofRepairTextBox
            // 
            NumberofRepairTextBox.Location = new Point(407, 14);
            NumberofRepairTextBox.Name = "NumberofRepairTextBox";
            NumberofRepairTextBox.Size = new Size(100, 23);
            NumberofRepairTextBox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(47, 318);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(123, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 324);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 6;
            label5.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 324);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 7;
            label6.Text = "Event";
            // 
            // EventTextBox
            // 
            EventTextBox.Location = new Point(311, 318);
            EventTextBox.Name = "EventTextBox";
            EventTextBox.Size = new Size(100, 23);
            EventTextBox.TabIndex = 8;
            // 
            // AddNewEventsButton
            // 
            AddNewEventsButton.Location = new Point(453, 317);
            AddNewEventsButton.Name = "AddNewEventsButton";
            AddNewEventsButton.Size = new Size(98, 23);
            AddNewEventsButton.TabIndex = 9;
            AddNewEventsButton.Text = "New Events";
            AddNewEventsButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1017, 179);
            dataGridView2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 213);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 1;
            label7.Text = "Ticket number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(328, 213);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 2;
            label8.Text = "Subject";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(687, 213);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 3;
            label9.Text = "Submitter";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 287);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 4;
            label10.Text = "status";
            // 
            // TicketNumberTextBox
            // 
            TicketNumberTextBox.Location = new Point(101, 210);
            TicketNumberTextBox.Name = "TicketNumberTextBox";
            TicketNumberTextBox.Size = new Size(174, 23);
            TicketNumberTextBox.TabIndex = 5;
            // 
            // SubjectTextBox
            // 
            SubjectTextBox.Location = new Point(383, 210);
            SubjectTextBox.Name = "SubjectTextBox";
            SubjectTextBox.Size = new Size(213, 23);
            SubjectTextBox.TabIndex = 6;
            // 
            // SubmitterTextBox
            // 
            SubmitterTextBox.Location = new Point(755, 210);
            SubmitterTextBox.Name = "SubmitterTextBox";
            SubmitterTextBox.Size = new Size(243, 23);
            SubmitterTextBox.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(53, 284);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(121, 23);
            StatusComboBox.TabIndex = 8;
            // 
            // AddNewButton
            // 
            AddNewButton.Location = new Point(221, 282);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(91, 23);
            AddNewButton.TabIndex = 9;
            AddNewButton.Text = "+ Add New";
            AddNewButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(2, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(1014, 204);
            dataGridView3.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 239);
            label11.Name = "label11";
            label11.Size = new Size(86, 15);
            label11.TabIndex = 1;
            label11.Text = "Asset Number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(384, 239);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 2;
            label12.Text = "Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(691, 239);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 3;
            label13.Text = "Type";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(42, 307);
            label14.Name = "label14";
            label14.Size = new Size(41, 15);
            label14.TabIndex = 4;
            label14.Text = "Status";
            // 
            // AssetNumberTextBox
            // 
            AssetNumberTextBox.Location = new Point(134, 236);
            AssetNumberTextBox.Name = "AssetNumberTextBox";
            AssetNumberTextBox.Size = new Size(244, 23);
            AssetNumberTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(432, 236);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(232, 23);
            NameTextBox.TabIndex = 6;
            // 
            // TypeTextBox
            // 
            TypeTextBox.Location = new Point(732, 236);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(219, 23);
            TypeTextBox.TabIndex = 7;
            // 
            // AssetStatusComboBox
            // 
            AssetStatusComboBox.FormattingEnabled = true;
            AssetStatusComboBox.Location = new Point(91, 305);
            AssetStatusComboBox.Name = "AssetStatusComboBox";
            AssetStatusComboBox.Size = new Size(121, 23);
            AssetStatusComboBox.TabIndex = 8;
            // 
            // AddNewAssetButton
            // 
            AddNewAssetButton.Location = new Point(250, 303);
            AddNewAssetButton.Name = "AddNewAssetButton";
            AddNewAssetButton.Size = new Size(128, 23);
            AddNewAssetButton.TabIndex = 9;
            AddNewAssetButton.Text = "+ Add new Asset";
            AddNewAssetButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(2, 2);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(1014, 196);
            dataGridView4.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 215);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 1;
            label15.Text = "UserID";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(366, 217);
            label16.Name = "label16";
            label16.Size = new Size(64, 15);
            label16.TabIndex = 2;
            label16.Text = "Username";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(683, 217);
            label17.Name = "label17";
            label17.Size = new Size(75, 15);
            label17.TabIndex = 3;
            label17.Text = "Department";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(19, 284);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 4;
            label18.Text = "FullName";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(366, 284);
            label19.Name = "label19";
            label19.Size = new Size(41, 15);
            label19.TabIndex = 5;
            label19.Text = "Active";
            // 
            // UserIDTextBox
            // 
            UserIDTextBox.Location = new Point(69, 212);
            UserIDTextBox.Name = "UserIDTextBox";
            UserIDTextBox.Size = new Size(173, 23);
            UserIDTextBox.TabIndex = 6;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(436, 212);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(213, 23);
            UserNameTextBox.TabIndex = 7;
            // 
            // DepartmentComboBox
            // 
            DepartmentComboBox.FormattingEnabled = true;
            DepartmentComboBox.Location = new Point(764, 212);
            DepartmentComboBox.Name = "DepartmentComboBox";
            DepartmentComboBox.Size = new Size(242, 23);
            DepartmentComboBox.TabIndex = 8;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(86, 281);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(164, 23);
            FullNameTextBox.TabIndex = 9;
            // 
            // ActiveComboBox
            // 
            ActiveComboBox.FormattingEnabled = true;
            ActiveComboBox.Location = new Point(413, 281);
            ActiveComboBox.Name = "ActiveComboBox";
            ActiveComboBox.Size = new Size(134, 23);
            ActiveComboBox.TabIndex = 10;
            // 
            // AddNewUserButton
            // 
            AddNewUserButton.Location = new Point(625, 281);
            AddNewUserButton.Name = "AddNewUserButton";
            AddNewUserButton.Size = new Size(121, 23);
            AddNewUserButton.TabIndex = 11;
            AddNewUserButton.Text = "+ Add New User";
            AddNewUserButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(1, 2);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(1016, 223);
            dataGridView5.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(25, 242);
            label20.Name = "label20";
            label20.Size = new Size(34, 15);
            label20.TabIndex = 1;
            label20.Text = "Date";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(327, 242);
            label21.Name = "label21";
            label21.Size = new Size(52, 15);
            label21.TabIndex = 2;
            label21.Text = "Content";
            label21.Click += label21_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(683, 242);
            label22.Name = "label22";
            label22.Size = new Size(100, 15);
            label22.TabIndex = 3;
            label22.Text = "Person in charge";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(25, 311);
            label23.Name = "label23";
            label23.Size = new Size(55, 15);
            label23.TabIndex = 4;
            label23.Text = "Remarks";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(65, 236);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(141, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(789, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 308);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 23);
            textBox3.TabIndex = 8;
            // 
            // AddNewLogButton
            // 
            AddNewLogButton.Location = new Point(372, 308);
            AddNewLogButton.Name = "AddNewLogButton";
            AddNewLogButton.Size = new Size(121, 23);
            AddNewLogButton.TabIndex = 9;
            AddNewLogButton.Text = "+ Add New Log";
            AddNewLogButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(1, 1);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.Size = new Size(1016, 226);
            dataGridView6.TabIndex = 0;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(28, 252);
            label24.Name = "label24";
            label24.Size = new Size(42, 15);
            label24.TabIndex = 1;
            label24.Text = "Name";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(381, 252);
            label25.Name = "label25";
            label25.Size = new Size(75, 15);
            label25.TabIndex = 2;
            label25.Text = "Department";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(705, 252);
            label26.Name = "label26";
            label26.Size = new Size(55, 15);
            label26.TabIndex = 3;
            label26.Text = "Progress";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(26, 311);
            label27.Name = "label27";
            label27.Size = new Size(100, 15);
            label27.TabIndex = 4;
            label27.Text = "Person in charge";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(381, 311);
            label28.Name = "label28";
            label28.Size = new Size(41, 15);
            label28.TabIndex = 5;
            label28.Text = "Status";
            // 
            // TechniaslNameTextBox
            // 
            TechniaslNameTextBox.Location = new Point(76, 249);
            TechniaslNameTextBox.Name = "TechniaslNameTextBox";
            TechniaslNameTextBox.Size = new Size(240, 23);
            TechniaslNameTextBox.TabIndex = 6;
            // 
            // TechnicalDepartmentComboBox
            // 
            TechnicalDepartmentComboBox.FormattingEnabled = true;
            TechnicalDepartmentComboBox.Location = new Point(462, 249);
            TechnicalDepartmentComboBox.Name = "TechnicalDepartmentComboBox";
            TechnicalDepartmentComboBox.Size = new Size(121, 23);
            TechnicalDepartmentComboBox.TabIndex = 7;
            // 
            // ProgressTextBox
            // 
            ProgressTextBox.Location = new Point(776, 249);
            ProgressTextBox.Name = "ProgressTextBox";
            ProgressTextBox.Size = new Size(210, 23);
            ProgressTextBox.TabIndex = 8;
            // 
            // PersonInChargeTextBox
            // 
            PersonInChargeTextBox.Location = new Point(135, 309);
            PersonInChargeTextBox.Name = "PersonInChargeTextBox";
            PersonInChargeTextBox.Size = new Size(181, 23);
            PersonInChargeTextBox.TabIndex = 9;
            // 
            // TechnicalStatusComboBox
            // 
            TechnicalStatusComboBox.FormattingEnabled = true;
            TechnicalStatusComboBox.Location = new Point(429, 307);
            TechnicalStatusComboBox.Name = "TechnicalStatusComboBox";
            TechnicalStatusComboBox.Size = new Size(121, 23);
            TechnicalStatusComboBox.TabIndex = 10;
            // 
            // SolutionsButton
            // 
            SolutionsButton.Location = new Point(617, 305);
            SolutionsButton.Name = "SolutionsButton";
            SolutionsButton.Size = new Size(117, 26);
            SolutionsButton.TabIndex = 11;
            SolutionsButton.Text = "+ Add new Solutions";
            SolutionsButton.UseVisualStyleBackColor = true;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // RnDbutton
            // 
            RnDbutton.Location = new Point(77, 88);
            RnDbutton.Name = "RnDbutton";
            RnDbutton.Size = new Size(149, 47);
            RnDbutton.TabIndex = 0;
            RnDbutton.Text = "RnD";
            RnDbutton.UseVisualStyleBackColor = true;
            // 
            // SalesButton
            // 
            SalesButton.Location = new Point(352, 88);
            SalesButton.Name = "SalesButton";
            SalesButton.Size = new Size(149, 47);
            SalesButton.TabIndex = 1;
            SalesButton.Text = "Sales";
            SalesButton.UseVisualStyleBackColor = true;
            // 
            // MarketingButton
            // 
            MarketingButton.Location = new Point(659, 88);
            MarketingButton.Name = "MarketingButton";
            MarketingButton.Size = new Size(149, 47);
            MarketingButton.TabIndex = 2;
            MarketingButton.Text = "Marketing";
            MarketingButton.UseVisualStyleBackColor = true;
            // 
            // ProductionButton
            // 
            ProductionButton.Location = new Point(77, 194);
            ProductionButton.Name = "ProductionButton";
            ProductionButton.Size = new Size(149, 47);
            ProductionButton.TabIndex = 3;
            ProductionButton.Text = "Production";
            ProductionButton.UseVisualStyleBackColor = true;
            // 
            // SupplyChainButton
            // 
            SupplyChainButton.Location = new Point(352, 194);
            SupplyChainButton.Name = "SupplyChainButton";
            SupplyChainButton.Size = new Size(149, 47);
            SupplyChainButton.TabIndex = 4;
            SupplyChainButton.Text = "Supply Chain";
            SupplyChainButton.UseVisualStyleBackColor = true;
            // 
            // CustomerServiceButton
            // 
            CustomerServiceButton.Location = new Point(659, 194);
            CustomerServiceButton.Name = "CustomerServiceButton";
            CustomerServiceButton.Size = new Size(149, 47);
            CustomerServiceButton.TabIndex = 5;
            CustomerServiceButton.Text = "Customer Service";
            CustomerServiceButton.UseVisualStyleBackColor = true;
            // 
            // FinanceButton
            // 
            FinanceButton.Location = new Point(77, 313);
            FinanceButton.Name = "FinanceButton";
            FinanceButton.Size = new Size(149, 47);
            FinanceButton.TabIndex = 6;
            FinanceButton.Text = "Finance";
            FinanceButton.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(77, 23);
            label29.Name = "label29";
            label29.Size = new Size(127, 15);
            label29.TabIndex = 7;
            label29.Text = "Department Entrance";
            // 
            // IT_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1025, 558);
            Controls.Add(tabControl1);
            Controls.Add(Department);
            Controls.Add(label2);
            Controls.Add(UserName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "IT_Form";
            Text = "IT_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            DashboardTabPage.ResumeLayout(false);
            DashboardTabPage.PerformLayout();
            RepairSupportTabPage.ResumeLayout(false);
            RepairSupportTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            AssetManagementTabPage.ResumeLayout(false);
            AssetManagementTabPage.PerformLayout();
            UserManagementTabPage.ResumeLayout(false);
            UserManagementTabPage.PerformLayout();
            MaintenanceLogTabPage.ResumeLayout(false);
            MaintenanceLogTabPage.PerformLayout();
            TechnicalSolutionsTabPage.ResumeLayout(false);
            TechnicalSolutionsTabPage.PerformLayout();
            DepartmentEntranceTabPage.ResumeLayout(false);
            DepartmentEntranceTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
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
        private TabPage DashboardTabPage;
        private TabPage RepairSupportTabPage;
        private DataGridView dataGridView1;
        private TabPage AssetManagementTabPage;
        private TabPage UserManagementTabPage;
        private TabPage MaintenanceLogTabPage;
        private TabPage TechnicalSolutionsTabPage;
        private TabPage StatisticalReportsTabPage;
        private TabPage DepartmentEntranceTabPage;
        private TextBox EventTextBox;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox NumberofRepairTextBox;
        private Label label4;
        private TextBox ActiveUsersTextBox;
        private Label label3;
        private Button AddNewEventsButton;
        private ComboBox StatusComboBox;
        private TextBox SubmitterTextBox;
        private TextBox SubjectTextBox;
        private TextBox TicketNumberTextBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView2;
        private Button AddNewButton;
        private Button AddNewAssetButton;
        private ComboBox AssetStatusComboBox;
        private TextBox TypeTextBox;
        private TextBox NameTextBox;
        private TextBox AssetNumberTextBox;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private DataGridView dataGridView3;
        private Button AddNewUserButton;
        private ComboBox ActiveComboBox;
        private TextBox FullNameTextBox;
        private ComboBox DepartmentComboBox;
        private TextBox UserNameTextBox;
        private TextBox UserIDTextBox;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private DataGridView dataGridView4;
        private DateTimePicker dateTimePicker2;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private DataGridView dataGridView5;
        private Button AddNewLogButton;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private DataGridView dataGridView6;
        private Button SolutionsButton;
        private ComboBox TechnicalStatusComboBox;
        private TextBox PersonInChargeTextBox;
        private TextBox ProgressTextBox;
        private ComboBox TechnicalDepartmentComboBox;
        private TextBox TechniaslNameTextBox;
        private Label label29;
        private Button FinanceButton;
        private Button CustomerServiceButton;
        private Button SupplyChainButton;
        private Button ProductionButton;
        private Button MarketingButton;
        private Button SalesButton;
        private Button RnDbutton;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}