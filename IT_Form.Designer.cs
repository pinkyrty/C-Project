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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pictureBox1 = new PictureBox();
            Department = new Label();
            label2 = new Label();
            UserName = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            DashboardTabPage = new TabPage();
            AddNewEventsButton = new Button();
            EventTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            NumberofRepairTextBox = new TextBox();
            label4 = new Label();
            ActiveUsersTextBox = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ITDashBoardTime = new DataGridViewTextBoxColumn();
            ITDashBoardEvent = new DataGridViewTextBoxColumn();
            RepairSupportTabPage = new TabPage();
            AddNewButton = new Button();
            StatusComboBox = new ComboBox();
            SubmitterTextBox = new TextBox();
            SubjectTextBox = new TextBox();
            TicketNumberTextBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            ITrepairOrderNumber = new DataGridViewTextBoxColumn();
            ITrepairSubject = new DataGridViewTextBoxColumn();
            ITrepairAuthor = new DataGridViewTextBoxColumn();
            ITrepaidState = new DataGridViewComboBoxColumn();
            ITrepairOperation = new DataGridViewButtonColumn();
            AssetManagementTabPage = new TabPage();
            AddNewAssetButton = new Button();
            AssetStatusComboBox = new ComboBox();
            TypeTextBox = new TextBox();
            NameTextBox = new TextBox();
            AssetNumberTextBox = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            dataGridView3 = new DataGridView();
            ITAssetNumber = new DataGridViewTextBoxColumn();
            ITassetName = new DataGridViewTextBoxColumn();
            ITassetType = new DataGridViewTextBoxColumn();
            ITassetState = new DataGridViewTextBoxColumn();
            ITassetOperation = new DataGridViewButtonColumn();
            UserManagementTabPage = new TabPage();
            AddNewUserButton = new Button();
            ActiveComboBox = new ComboBox();
            FullNameTextBox = new TextBox();
            DepartmentComboBox = new ComboBox();
            UserNameTextBox = new TextBox();
            UserIDTextBox = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            dataGridView4 = new DataGridView();
            ITuserID = new DataGridViewTextBoxColumn();
            ITuserName = new DataGridViewTextBoxColumn();
            ITuserDepartment = new DataGridViewComboBoxColumn();
            ITuserFullName = new DataGridViewTextBoxColumn();
            ITuserActive = new DataGridViewCheckBoxColumn();
            ITuserOperation = new DataGridViewButtonColumn();
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
            dataGridView5 = new DataGridView();
            ITmaintenanceDate = new DataGridViewTextBoxColumn();
            ITmaintenanceContent = new DataGridViewTextBoxColumn();
            ITmaintenanceInCharge = new DataGridViewTextBoxColumn();
            ITmaintenanceRemark = new DataGridViewTextBoxColumn();
            ITmaintenanceOperation = new DataGridViewButtonColumn();
            TechnicalSolutionsTabPage = new TabPage();
            SolutionsButton = new Button();
            TechnicalStatusComboBox = new ComboBox();
            PersonInChargeTextBox = new TextBox();
            ProgressTextBox = new TextBox();
            TechnicalDepartmentComboBox = new ComboBox();
            TechniaslNameTextBox = new TextBox();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            dataGridView6 = new DataGridView();
            ITtechnicalProjectName = new DataGridViewTextBoxColumn();
            ITtechnicalDepartment = new DataGridViewComboBoxColumn();
            ITtechnicalProcess = new DataGridViewComboBoxColumn();
            ITtechnicalIncharge = new DataGridViewTextBoxColumn();
            ITtechnicalState = new DataGridViewComboBoxColumn();
            ITtechnicalOperation = new DataGridViewButtonColumn();
            StatisticalReportsTabPage = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DepartmentEntranceTabPage = new TabPage();
            label29 = new Label();
            FinanceButton = new Button();
            CustomerServiceButton = new Button();
            SupplyChainButton = new Button();
            ProductionButton = new Button();
            MarketingButton = new Button();
            SalesButton = new Button();
            RnDbutton = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            DashboardTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            RepairSupportTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            AssetManagementTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            UserManagementTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            MaintenanceLogTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            TechnicalSolutionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            StatisticalReportsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            DepartmentEntranceTabPage.SuspendLayout();
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
            tabControl1.Controls.Add(DashboardTabPage);
            tabControl1.Controls.Add(RepairSupportTabPage);
            tabControl1.Controls.Add(AssetManagementTabPage);
            tabControl1.Controls.Add(UserManagementTabPage);
            tabControl1.Controls.Add(MaintenanceLogTabPage);
            tabControl1.Controls.Add(TechnicalSolutionsTabPage);
            tabControl1.Controls.Add(StatisticalReportsTabPage);
            tabControl1.Controls.Add(DepartmentEntranceTabPage);
            tabControl1.Location = new Point(12, 129);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1129, 717);
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
            DashboardTabPage.Size = new Size(1121, 689);
            DashboardTabPage.TabIndex = 0;
            DashboardTabPage.Text = "Dashboard";
            DashboardTabPage.UseVisualStyleBackColor = true;
            // 
            // AddNewEventsButton
            // 
            AddNewEventsButton.Location = new Point(600, 660);
            AddNewEventsButton.Name = "AddNewEventsButton";
            AddNewEventsButton.Size = new Size(98, 23);
            AddNewEventsButton.TabIndex = 9;
            AddNewEventsButton.Text = "New Events";
            AddNewEventsButton.UseVisualStyleBackColor = true;
            // 
            // EventTextBox
            // 
            EventTextBox.Location = new Point(285, 661);
            EventTextBox.Name = "EventTextBox";
            EventTextBox.Size = new Size(309, 23);
            EventTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 664);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 7;
            label6.Text = "Event: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 664);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "Time: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(58, 658);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(123, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // NumberofRepairTextBox
            // 
            NumberofRepairTextBox.Location = new Point(407, 14);
            NumberofRepairTextBox.Name = "NumberofRepairTextBox";
            NumberofRepairTextBox.Size = new Size(100, 23);
            NumberofRepairTextBox.TabIndex = 4;
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
            // ActiveUsersTextBox
            // 
            ActiveUsersTextBox.Location = new Point(76, 14);
            ActiveUsersTextBox.Name = "ActiveUsersTextBox";
            ActiveUsersTextBox.Size = new Size(100, 23);
            ActiveUsersTextBox.TabIndex = 2;
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ITDashBoardTime, ITDashBoardEvent });
            dataGridView1.Location = new Point(0, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1143, 608);
            dataGridView1.TabIndex = 0;
            // 
            // ITDashBoardTime
            // 
            ITDashBoardTime.HeaderText = "Time";
            ITDashBoardTime.Name = "ITDashBoardTime";
            // 
            // ITDashBoardEvent
            // 
            ITDashBoardEvent.HeaderText = "Event";
            ITDashBoardEvent.Name = "ITDashBoardEvent";
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
            RepairSupportTabPage.Size = new Size(1121, 689);
            RepairSupportTabPage.TabIndex = 1;
            RepairSupportTabPage.Text = "Repair Support";
            RepairSupportTabPage.UseVisualStyleBackColor = true;
            // 
            // AddNewButton
            // 
            AddNewButton.Location = new Point(185, 660);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(91, 23);
            AddNewButton.TabIndex = 9;
            AddNewButton.Text = "+ Add New";
            AddNewButton.UseVisualStyleBackColor = true;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(56, 661);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(121, 23);
            StatusComboBox.TabIndex = 8;
            // 
            // SubmitterTextBox
            // 
            SubmitterTextBox.Location = new Point(829, 622);
            SubmitterTextBox.Name = "SubmitterTextBox";
            SubmitterTextBox.Size = new Size(243, 23);
            SubmitterTextBox.TabIndex = 7;
            // 
            // SubjectTextBox
            // 
            SubjectTextBox.Location = new Point(399, 622);
            SubjectTextBox.Name = "SubjectTextBox";
            SubjectTextBox.Size = new Size(303, 23);
            SubjectTextBox.TabIndex = 6;
            // 
            // TicketNumberTextBox
            // 
            TicketNumberTextBox.Location = new Point(107, 622);
            TicketNumberTextBox.Name = "TicketNumberTextBox";
            TicketNumberTextBox.Size = new Size(174, 23);
            TicketNumberTextBox.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 664);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 4;
            label10.Text = "Status: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(761, 625);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 3;
            label9.Text = "Submitter: ";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 625);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 2;
            label8.Text = "Subject: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 625);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 1;
            label7.Text = "Ticket number: ";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ITrepairOrderNumber, ITrepairSubject, ITrepairAuthor, ITrepaidState, ITrepairOperation });
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1143, 616);
            dataGridView2.TabIndex = 0;
            // 
            // ITrepairOrderNumber
            // 
            ITrepairOrderNumber.HeaderText = "Order Number";
            ITrepairOrderNumber.Name = "ITrepairOrderNumber";
            // 
            // ITrepairSubject
            // 
            ITrepairSubject.HeaderText = "Subjet";
            ITrepairSubject.Name = "ITrepairSubject";
            // 
            // ITrepairAuthor
            // 
            ITrepairAuthor.HeaderText = "Author";
            ITrepairAuthor.Name = "ITrepairAuthor";
            // 
            // ITrepaidState
            // 
            ITrepaidState.HeaderText = "State";
            ITrepaidState.Name = "ITrepaidState";
            // 
            // ITrepairOperation
            // 
            ITrepairOperation.HeaderText = "Operation";
            ITrepairOperation.Name = "ITrepairOperation";
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
            AssetManagementTabPage.Size = new Size(1121, 689);
            AssetManagementTabPage.TabIndex = 2;
            AssetManagementTabPage.Text = "Asset Management";
            AssetManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // AddNewAssetButton
            // 
            AddNewAssetButton.Location = new Point(185, 660);
            AddNewAssetButton.Name = "AddNewAssetButton";
            AddNewAssetButton.Size = new Size(91, 23);
            AddNewAssetButton.TabIndex = 9;
            AddNewAssetButton.Text = "+ Add New";
            AddNewAssetButton.UseVisualStyleBackColor = true;
            // 
            // AssetStatusComboBox
            // 
            AssetStatusComboBox.FormattingEnabled = true;
            AssetStatusComboBox.Location = new Point(56, 661);
            AssetStatusComboBox.Name = "AssetStatusComboBox";
            AssetStatusComboBox.Size = new Size(121, 23);
            AssetStatusComboBox.TabIndex = 8;
            // 
            // TypeTextBox
            // 
            TypeTextBox.Location = new Point(829, 622);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(243, 23);
            TypeTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(399, 622);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(303, 23);
            NameTextBox.TabIndex = 6;
            // 
            // AssetNumberTextBox
            // 
            AssetNumberTextBox.Location = new Point(107, 622);
            AssetNumberTextBox.Name = "AssetNumberTextBox";
            AssetNumberTextBox.Size = new Size(174, 23);
            AssetNumberTextBox.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 664);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 4;
            label14.Text = "Status: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(782, 625);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 3;
            label13.Text = "Type: ";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(345, 625);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 2;
            label12.Text = "Name: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 625);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 1;
            label11.Text = "Asset Number: ";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { ITAssetNumber, ITassetName, ITassetType, ITassetState, ITassetOperation });
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(1143, 616);
            dataGridView3.TabIndex = 0;
            // 
            // ITAssetNumber
            // 
            ITAssetNumber.HeaderText = "Asset Number";
            ITAssetNumber.Name = "ITAssetNumber";
            // 
            // ITassetName
            // 
            ITassetName.HeaderText = "Name";
            ITassetName.Name = "ITassetName";
            // 
            // ITassetType
            // 
            ITassetType.HeaderText = "Type";
            ITassetType.Name = "ITassetType";
            // 
            // ITassetState
            // 
            ITassetState.HeaderText = "State";
            ITassetState.Name = "ITassetState";
            // 
            // ITassetOperation
            // 
            ITassetOperation.HeaderText = "Operation";
            ITassetOperation.Name = "ITassetOperation";
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
            UserManagementTabPage.Size = new Size(1121, 689);
            UserManagementTabPage.TabIndex = 3;
            UserManagementTabPage.Text = "User Management";
            UserManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // AddNewUserButton
            // 
            AddNewUserButton.Location = new Point(564, 661);
            AddNewUserButton.Name = "AddNewUserButton";
            AddNewUserButton.Size = new Size(121, 23);
            AddNewUserButton.TabIndex = 11;
            AddNewUserButton.Text = "+ Add New User";
            AddNewUserButton.UseVisualStyleBackColor = true;
            // 
            // ActiveComboBox
            // 
            ActiveComboBox.FormattingEnabled = true;
            ActiveComboBox.Location = new Point(378, 661);
            ActiveComboBox.Name = "ActiveComboBox";
            ActiveComboBox.Size = new Size(134, 23);
            ActiveComboBox.TabIndex = 10;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(78, 661);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(164, 23);
            FullNameTextBox.TabIndex = 9;
            // 
            // DepartmentComboBox
            // 
            DepartmentComboBox.FormattingEnabled = true;
            DepartmentComboBox.Location = new Point(887, 622);
            DepartmentComboBox.Name = "DepartmentComboBox";
            DepartmentComboBox.Size = new Size(242, 23);
            DepartmentComboBox.TabIndex = 8;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(407, 622);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(341, 23);
            UserNameTextBox.TabIndex = 7;
            // 
            // UserIDTextBox
            // 
            UserIDTextBox.Location = new Point(67, 622);
            UserIDTextBox.Name = "UserIDTextBox";
            UserIDTextBox.Size = new Size(209, 23);
            UserIDTextBox.TabIndex = 6;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(331, 664);
            label19.Name = "label19";
            label19.Size = new Size(41, 15);
            label19.TabIndex = 5;
            label19.Text = "Active";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 664);
            label18.Name = "label18";
            label18.Size = new Size(67, 15);
            label18.TabIndex = 4;
            label18.Text = "FullName: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(800, 625);
            label17.Name = "label17";
            label17.Size = new Size(81, 15);
            label17.TabIndex = 3;
            label17.Text = "Department: ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(331, 625);
            label16.Name = "label16";
            label16.Size = new Size(70, 15);
            label16.TabIndex = 2;
            label16.Text = "Username: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 625);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 1;
            label15.Text = "UserID: ";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { ITuserID, ITuserName, ITuserDepartment, ITuserFullName, ITuserActive, ITuserOperation });
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(1143, 616);
            dataGridView4.TabIndex = 0;
            // 
            // ITuserID
            // 
            ITuserID.HeaderText = "User ID";
            ITuserID.Name = "ITuserID";
            // 
            // ITuserName
            // 
            ITuserName.HeaderText = "User Name";
            ITuserName.Name = "ITuserName";
            // 
            // ITuserDepartment
            // 
            ITuserDepartment.HeaderText = "Department";
            ITuserDepartment.Name = "ITuserDepartment";
            // 
            // ITuserFullName
            // 
            ITuserFullName.HeaderText = "Full Name";
            ITuserFullName.Name = "ITuserFullName";
            // 
            // ITuserActive
            // 
            ITuserActive.HeaderText = "Active";
            ITuserActive.Name = "ITuserActive";
            // 
            // ITuserOperation
            // 
            ITuserOperation.HeaderText = "Operation";
            ITuserOperation.Name = "ITuserOperation";
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
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { ITmaintenanceDate, ITmaintenanceContent, ITmaintenanceInCharge, ITmaintenanceRemark, ITmaintenanceOperation });
            dataGridView5.Location = new Point(0, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(1143, 613);
            dataGridView5.TabIndex = 0;
            // 
            // ITmaintenanceDate
            // 
            ITmaintenanceDate.HeaderText = "Date";
            ITmaintenanceDate.Name = "ITmaintenanceDate";
            // 
            // ITmaintenanceContent
            // 
            ITmaintenanceContent.HeaderText = "Content";
            ITmaintenanceContent.Name = "ITmaintenanceContent";
            // 
            // ITmaintenanceInCharge
            // 
            ITmaintenanceInCharge.HeaderText = "In Charge Person";
            ITmaintenanceInCharge.Name = "ITmaintenanceInCharge";
            // 
            // ITmaintenanceRemark
            // 
            ITmaintenanceRemark.HeaderText = "Remark";
            ITmaintenanceRemark.Name = "ITmaintenanceRemark";
            // 
            // ITmaintenanceOperation
            // 
            ITmaintenanceOperation.HeaderText = "Operation";
            ITmaintenanceOperation.Name = "ITmaintenanceOperation";
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
            TechnicalSolutionsTabPage.Size = new Size(1121, 689);
            TechnicalSolutionsTabPage.TabIndex = 5;
            TechnicalSolutionsTabPage.Text = "Technical Solutions";
            TechnicalSolutionsTabPage.UseVisualStyleBackColor = true;
            // 
            // SolutionsButton
            // 
            SolutionsButton.Location = new Point(579, 658);
            SolutionsButton.Name = "SolutionsButton";
            SolutionsButton.Size = new Size(117, 26);
            SolutionsButton.TabIndex = 11;
            SolutionsButton.Text = "+ Add new Solutions";
            SolutionsButton.UseVisualStyleBackColor = true;
            // 
            // TechnicalStatusComboBox
            // 
            TechnicalStatusComboBox.FormattingEnabled = true;
            TechnicalStatusComboBox.Location = new Point(424, 661);
            TechnicalStatusComboBox.Name = "TechnicalStatusComboBox";
            TechnicalStatusComboBox.Size = new Size(121, 23);
            TechnicalStatusComboBox.TabIndex = 10;
            // 
            // PersonInChargeTextBox
            // 
            PersonInChargeTextBox.Location = new Point(123, 661);
            PersonInChargeTextBox.Name = "PersonInChargeTextBox";
            PersonInChargeTextBox.Size = new Size(181, 23);
            PersonInChargeTextBox.TabIndex = 9;
            // 
            // ProgressTextBox
            // 
            ProgressTextBox.Location = new Point(858, 617);
            ProgressTextBox.Name = "ProgressTextBox";
            ProgressTextBox.Size = new Size(210, 23);
            ProgressTextBox.TabIndex = 8;
            // 
            // TechnicalDepartmentComboBox
            // 
            TechnicalDepartmentComboBox.FormattingEnabled = true;
            TechnicalDepartmentComboBox.Location = new Point(504, 622);
            TechnicalDepartmentComboBox.Name = "TechnicalDepartmentComboBox";
            TechnicalDepartmentComboBox.Size = new Size(232, 23);
            TechnicalDepartmentComboBox.TabIndex = 7;
            // 
            // TechniaslNameTextBox
            // 
            TechniaslNameTextBox.Location = new Point(65, 622);
            TechniaslNameTextBox.Name = "TechniaslNameTextBox";
            TechniaslNameTextBox.Size = new Size(298, 23);
            TechniaslNameTextBox.TabIndex = 6;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(371, 664);
            label28.Name = "label28";
            label28.Size = new Size(47, 15);
            label28.TabIndex = 5;
            label28.Text = "Status: ";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(11, 664);
            label27.Name = "label27";
            label27.Size = new Size(106, 15);
            label27.TabIndex = 4;
            label27.Text = "Person in charge: ";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(791, 625);
            label26.Name = "label26";
            label26.Size = new Size(61, 15);
            label26.TabIndex = 3;
            label26.Text = "Progress: ";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(417, 625);
            label25.Name = "label25";
            label25.Size = new Size(81, 15);
            label25.TabIndex = 2;
            label25.Text = "Department: ";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(11, 625);
            label24.Name = "label24";
            label24.Size = new Size(48, 15);
            label24.TabIndex = 1;
            label24.Text = "Name: ";
            // 
            // dataGridView6
            // 
            dataGridView6.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Columns.AddRange(new DataGridViewColumn[] { ITtechnicalProjectName, ITtechnicalDepartment, ITtechnicalProcess, ITtechnicalIncharge, ITtechnicalState, ITtechnicalOperation });
            dataGridView6.Location = new Point(0, 0);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.Size = new Size(1143, 611);
            dataGridView6.TabIndex = 0;
            // 
            // ITtechnicalProjectName
            // 
            ITtechnicalProjectName.HeaderText = "Project Name";
            ITtechnicalProjectName.Name = "ITtechnicalProjectName";
            // 
            // ITtechnicalDepartment
            // 
            ITtechnicalDepartment.HeaderText = "Department";
            ITtechnicalDepartment.Name = "ITtechnicalDepartment";
            // 
            // ITtechnicalProcess
            // 
            ITtechnicalProcess.HeaderText = "Process";
            ITtechnicalProcess.Name = "ITtechnicalProcess";
            // 
            // ITtechnicalIncharge
            // 
            ITtechnicalIncharge.HeaderText = "In Charge Person";
            ITtechnicalIncharge.Name = "ITtechnicalIncharge";
            // 
            // ITtechnicalState
            // 
            ITtechnicalState.HeaderText = "State";
            ITtechnicalState.Name = "ITtechnicalState";
            // 
            // ITtechnicalOperation
            // 
            ITtechnicalOperation.HeaderText = "Operation";
            ITtechnicalOperation.Name = "ITtechnicalOperation";
            // 
            // StatisticalReportsTabPage
            // 
            StatisticalReportsTabPage.BackColor = SystemColors.GradientInactiveCaption;
            StatisticalReportsTabPage.Controls.Add(chart1);
            StatisticalReportsTabPage.Location = new Point(4, 24);
            StatisticalReportsTabPage.Name = "StatisticalReportsTabPage";
            StatisticalReportsTabPage.Size = new Size(1121, 689);
            StatisticalReportsTabPage.TabIndex = 6;
            StatisticalReportsTabPage.Text = "Statistical Reports";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(11, 95);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(1123, 469);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // DepartmentEntranceTabPage
            // 
            DepartmentEntranceTabPage.BackColor = SystemColors.GradientInactiveCaption;
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
            // 
            // CustomerServiceButton
            // 
            CustomerServiceButton.Location = new Point(816, 309);
            CustomerServiceButton.Name = "CustomerServiceButton";
            CustomerServiceButton.Size = new Size(199, 90);
            CustomerServiceButton.TabIndex = 5;
            CustomerServiceButton.Text = "Customer Service";
            CustomerServiceButton.UseVisualStyleBackColor = true;
            // 
            // SupplyChainButton
            // 
            SupplyChainButton.Location = new Point(457, 309);
            SupplyChainButton.Name = "SupplyChainButton";
            SupplyChainButton.Size = new Size(199, 90);
            SupplyChainButton.TabIndex = 4;
            SupplyChainButton.Text = "Supply Chain";
            SupplyChainButton.UseVisualStyleBackColor = true;
            // 
            // ProductionButton
            // 
            ProductionButton.Location = new Point(110, 309);
            ProductionButton.Name = "ProductionButton";
            ProductionButton.Size = new Size(199, 90);
            ProductionButton.TabIndex = 3;
            ProductionButton.Text = "Production";
            ProductionButton.UseVisualStyleBackColor = true;
            // 
            // MarketingButton
            // 
            MarketingButton.Location = new Point(816, 102);
            MarketingButton.Name = "MarketingButton";
            MarketingButton.Size = new Size(199, 90);
            MarketingButton.TabIndex = 2;
            MarketingButton.Text = "Logistic and  Warehouse";
            MarketingButton.UseVisualStyleBackColor = true;
            // 
            // SalesButton
            // 
            SalesButton.Location = new Point(457, 102);
            SalesButton.Name = "SalesButton";
            SalesButton.Size = new Size(199, 90);
            SalesButton.TabIndex = 1;
            SalesButton.Text = "Sales And Marketing";
            SalesButton.UseVisualStyleBackColor = true;
            // 
            // RnDbutton
            // 
            RnDbutton.Location = new Point(110, 102);
            RnDbutton.Name = "RnDbutton";
            RnDbutton.Size = new Size(199, 90);
            RnDbutton.TabIndex = 0;
            RnDbutton.Text = "RnD";
            RnDbutton.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(1091, 12);
            button8.Name = "button8";
            button8.Size = new Size(59, 38);
            button8.TabIndex = 21;
            button8.Text = "User Profile";
            button8.UseVisualStyleBackColor = true;
            // 
            // IT_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1153, 858);
            Controls.Add(button8);
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
            DashboardTabPage.ResumeLayout(false);
            DashboardTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            RepairSupportTabPage.ResumeLayout(false);
            RepairSupportTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            AssetManagementTabPage.ResumeLayout(false);
            AssetManagementTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            UserManagementTabPage.ResumeLayout(false);
            UserManagementTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            MaintenanceLogTabPage.ResumeLayout(false);
            MaintenanceLogTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            TechnicalSolutionsTabPage.ResumeLayout(false);
            TechnicalSolutionsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            StatisticalReportsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            DepartmentEntranceTabPage.ResumeLayout(false);
            DepartmentEntranceTabPage.PerformLayout();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button8;
        private DataGridViewTextBoxColumn ITDashBoardTime;
        private DataGridViewTextBoxColumn ITDashBoardEvent;
        private DataGridViewTextBoxColumn ITrepairOrderNumber;
        private DataGridViewTextBoxColumn ITrepairSubject;
        private DataGridViewTextBoxColumn ITrepairAuthor;
        private DataGridViewComboBoxColumn ITrepaidState;
        private DataGridViewButtonColumn ITrepairOperation;
        private DataGridViewTextBoxColumn ITAssetNumber;
        private DataGridViewTextBoxColumn ITassetName;
        private DataGridViewTextBoxColumn ITassetType;
        private DataGridViewTextBoxColumn ITassetState;
        private DataGridViewButtonColumn ITassetOperation;
        private DataGridViewTextBoxColumn ITuserID;
        private DataGridViewTextBoxColumn ITuserName;
        private DataGridViewComboBoxColumn ITuserDepartment;
        private DataGridViewTextBoxColumn ITuserFullName;
        private DataGridViewCheckBoxColumn ITuserActive;
        private DataGridViewButtonColumn ITuserOperation;
        private DataGridViewTextBoxColumn ITmaintenanceDate;
        private DataGridViewTextBoxColumn ITmaintenanceContent;
        private DataGridViewTextBoxColumn ITmaintenanceInCharge;
        private DataGridViewTextBoxColumn ITmaintenanceRemark;
        private DataGridViewButtonColumn ITmaintenanceOperation;
        private DataGridViewTextBoxColumn ITtechnicalProjectName;
        private DataGridViewComboBoxColumn ITtechnicalDepartment;
        private DataGridViewComboBoxColumn ITtechnicalProcess;
        private DataGridViewTextBoxColumn ITtechnicalIncharge;
        private DataGridViewComboBoxColumn ITtechnicalState;
        private DataGridViewButtonColumn ITtechnicalOperation;
    }
}