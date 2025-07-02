namespace C_Project
{
    partial class FinanceDepartment
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceDepartment));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnUserProfile = new Button();
            label19 = new Label();
            label18 = new Label();
            pictureBox1 = new PictureBox();
            ad = new TabControl();
            tabPage1 = new TabPage();
            btn_Add = new Button();
            btn_Save = new Button();
            dataGridView1 = new DataGridView();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btn_Income_Add = new Button();
            btn_Income_Save = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            btn_Report_Add = new Button();
            uploadFileText = new Label();
            btn_ReportUpload = new Button();
            label12 = new Label();
            riskPeriodText = new TextBox();
            label11 = new Label();
            riskReportTypeText = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            btn_RiskSave = new Button();
            riskTypeText = new TextBox();
            dataGridView4 = new DataGridView();
            btn_Risk_Add = new Button();
            riskMitiText = new TextBox();
            label20 = new Label();
            riskDescText = new TextBox();
            label17 = new Label();
            riskLevelCombo = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            tabPage5 = new TabPage();
            btn_Invest_Save = new Button();
            btn_Invest_Add = new Button();
            dataGridView5 = new DataGridView();
            textBox7 = new TextBox();
            label25 = new Label();
            textBox6 = new TextBox();
            label24 = new Label();
            textBox5 = new TextBox();
            label23 = new Label();
            textBox4 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            financeDepartmentBindingSource = new BindingSource(components);
            financeDepartmentBindingSource1 = new BindingSource(components);
            financeDepartmentBindingSource2 = new BindingSource(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label30 = new Label();
            label31 = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ad.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)financeDepartmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)financeDepartmentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)financeDepartmentBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // btnUserProfile
            // 
            btnUserProfile.Location = new Point(1091, 12);
            btnUserProfile.Name = "btnUserProfile";
            btnUserProfile.Size = new Size(59, 38);
            btnUserProfile.TabIndex = 18;
            btnUserProfile.Text = "User Profile";
            btnUserProfile.UseVisualStyleBackColor = true;
            btnUserProfile.Click += btnUserProfile_click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label19.Location = new Point(111, 39);
            label19.Name = "label19";
            label19.Size = new Size(85, 15);
            label19.TabIndex = 15;
            label19.Text = "Department :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label18.Location = new Point(111, 12);
            label18.Name = "label18";
            label18.Size = new Size(78, 15);
            label18.TabIndex = 14;
            label18.Text = "User Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // ad
            // 
            ad.Controls.Add(tabPage1);
            ad.Controls.Add(tabPage2);
            ad.Controls.Add(tabPage3);
            ad.Controls.Add(tabPage4);
            ad.Controls.Add(tabPage5);
            ad.Location = new Point(15, 108);
            ad.Name = "ad";
            ad.SelectedIndex = 0;
            ad.Size = new Size(1126, 738);
            ad.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_Add);
            tabPage1.Controls.Add(btn_Save);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(chart3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1118, 710);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Budgeting/Forecasting";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(1037, 29);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 26;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(1037, 58);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 26;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1025, 277);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // chart3
            // 
            chart3.Location = new Point(20, 355);
            chart3.Name = "chart3";
            chart3.Size = new Size(800, 200);
            chart3.TabIndex = 24;
            chart3.Text = "budgetChart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(6, 320);
            label2.Name = "label2";
            label2.Size = new Size(232, 15);
            label2.TabIndex = 22;
            label2.Text = "Annual budget and actual trend chart";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 20;
            label1.Text = "Annual Budget and Forecast";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_Income_Add);
            tabPage2.Controls.Add(btn_Income_Save);
            tabPage2.Controls.Add(chart1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1118, 710);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Income and Expenditure and Cash Flow";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Income_Add
            // 
            btn_Income_Add.Location = new Point(1040, 29);
            btn_Income_Add.Name = "btn_Income_Add";
            btn_Income_Add.Size = new Size(75, 23);
            btn_Income_Add.TabIndex = 28;
            btn_Income_Add.Text = "Add";
            btn_Income_Add.UseVisualStyleBackColor = true;
            btn_Income_Add.Click += btn_Income_Add_Click;
            // 
            // btn_Income_Save
            // 
            btn_Income_Save.Location = new Point(1040, 59);
            btn_Income_Save.Name = "btn_Income_Save";
            btn_Income_Save.Size = new Size(75, 23);
            btn_Income_Save.TabIndex = 27;
            btn_Income_Save.Text = "Save";
            btn_Income_Save.UseVisualStyleBackColor = true;
            btn_Income_Save.Click += btn_Income_Save_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(333, 320);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(3, 259);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 2;
            label4.Text = "Cash flow monthly trend";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 29);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1031, 219);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(323, 15);
            label3.TabIndex = 0;
            label3.Text = "Income and Expenditure and Cash Flow Management";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(btn_Report_Add);
            tabPage3.Controls.Add(uploadFileText);
            tabPage3.Controls.Add(btn_ReportUpload);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(riskPeriodText);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(riskReportTypeText);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1118, 710);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Financial Statements";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 196);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(1109, 508);
            dataGridView3.TabIndex = 9;
            // 
            // btn_Report_Add
            // 
            btn_Report_Add.Location = new Point(48, 151);
            btn_Report_Add.Name = "btn_Report_Add";
            btn_Report_Add.Size = new Size(75, 23);
            btn_Report_Add.TabIndex = 8;
            btn_Report_Add.Text = "Add";
            btn_Report_Add.UseVisualStyleBackColor = true;
            btn_Report_Add.Click += btn_Report_Add_Click;
            // 
            // uploadFileText
            // 
            uploadFileText.AutoSize = true;
            uploadFileText.Location = new Point(212, 113);
            uploadFileText.Name = "uploadFileText";
            uploadFileText.Size = new Size(95, 15);
            uploadFileText.TabIndex = 7;
            uploadFileText.Text = "No file selected";
            // 
            // btn_ReportUpload
            // 
            btn_ReportUpload.Location = new Point(131, 109);
            btn_ReportUpload.Name = "btn_ReportUpload";
            btn_ReportUpload.Size = new Size(82, 23);
            btn_ReportUpload.TabIndex = 6;
            btn_ReportUpload.Text = "Choose File";
            btn_ReportUpload.UseVisualStyleBackColor = true;
            btn_ReportUpload.Click += btn_ReportUpload_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(45, 112);
            label12.Name = "label12";
            label12.Size = new Size(78, 15);
            label12.TabIndex = 5;
            label12.Text = "Upload File :";
            label12.Click += label12_Click;
            // 
            // riskPeriodText
            // 
            riskPeriodText.Location = new Point(92, 75);
            riskPeriodText.Name = "riskPeriodText";
            riskPeriodText.Size = new Size(121, 23);
            riskPeriodText.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 78);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 3;
            label11.Text = "Period :";
            // 
            // riskReportTypeText
            // 
            riskReportTypeText.FormattingEnabled = true;
            riskReportTypeText.Items.AddRange(new object[] { "Income Statement", "Balance Sheet", "Cash Flow Statement" });
            riskReportTypeText.Location = new Point(92, 45);
            riskReportTypeText.Name = "riskReportTypeText";
            riskReportTypeText.Size = new Size(121, 23);
            riskReportTypeText.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 48);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 1;
            label10.Text = "Type :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label9.Location = new Point(6, 11);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 0;
            label9.Text = "Financial statements";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btn_RiskSave);
            tabPage4.Controls.Add(riskTypeText);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Controls.Add(btn_Risk_Add);
            tabPage4.Controls.Add(riskMitiText);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(riskDescText);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(riskLevelCombo);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label14);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1118, 710);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Risk Management";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_RiskSave
            // 
            btn_RiskSave.Location = new Point(1040, 200);
            btn_RiskSave.Name = "btn_RiskSave";
            btn_RiskSave.Size = new Size(75, 23);
            btn_RiskSave.TabIndex = 30;
            btn_RiskSave.Text = "Save";
            btn_RiskSave.UseVisualStyleBackColor = true;
            btn_RiskSave.Click += btn_RiskSave_Click;
            // 
            // riskTypeText
            // 
            riskTypeText.Location = new Point(98, 46);
            riskTypeText.Name = "riskTypeText";
            riskTypeText.Size = new Size(133, 23);
            riskTypeText.TabIndex = 11;
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(6, 200);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(1028, 507);
            dataGridView4.TabIndex = 10;
            dataGridView4.CellClick += dataGridView4_CellClick;
            // 
            // btn_Risk_Add
            // 
            btn_Risk_Add.Location = new Point(17, 171);
            btn_Risk_Add.Name = "btn_Risk_Add";
            btn_Risk_Add.Size = new Size(75, 23);
            btn_Risk_Add.TabIndex = 9;
            btn_Risk_Add.Text = "Add";
            btn_Risk_Add.UseVisualStyleBackColor = true;
            btn_Risk_Add.Click += btn_Risk_Add_Click;
            // 
            // riskMitiText
            // 
            riskMitiText.Location = new Point(98, 129);
            riskMitiText.Name = "riskMitiText";
            riskMitiText.Size = new Size(365, 23);
            riskMitiText.TabIndex = 8;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(20, 132);
            label20.Name = "label20";
            label20.Size = new Size(72, 15);
            label20.TabIndex = 7;
            label20.Text = "Mitigation :";
            // 
            // riskDescText
            // 
            riskDescText.Location = new Point(98, 89);
            riskDescText.Name = "riskDescText";
            riskDescText.Size = new Size(365, 23);
            riskDescText.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 92);
            label17.Name = "label17";
            label17.Size = new Size(77, 15);
            label17.TabIndex = 5;
            label17.Text = "Description :";
            // 
            // riskLevelCombo
            // 
            riskLevelCombo.FormattingEnabled = true;
            riskLevelCombo.Items.AddRange(new object[] { "Low", "Medium", "High" });
            riskLevelCombo.Location = new Point(342, 46);
            riskLevelCombo.Name = "riskLevelCombo";
            riskLevelCombo.Size = new Size(121, 23);
            riskLevelCombo.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(269, 46);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 3;
            label16.Text = "Risk Level :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(26, 49);
            label15.Name = "label15";
            label15.Size = new Size(66, 15);
            label15.TabIndex = 1;
            label15.Text = "Risk Type :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label14.Location = new Point(6, 11);
            label14.Name = "label14";
            label14.Size = new Size(168, 15);
            label14.TabIndex = 0;
            label14.Text = "Financial Risk Management";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btn_Invest_Save);
            tabPage5.Controls.Add(btn_Invest_Add);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Controls.Add(textBox7);
            tabPage5.Controls.Add(label25);
            tabPage5.Controls.Add(textBox6);
            tabPage5.Controls.Add(label24);
            tabPage5.Controls.Add(textBox5);
            tabPage5.Controls.Add(label23);
            tabPage5.Controls.Add(textBox4);
            tabPage5.Controls.Add(label22);
            tabPage5.Controls.Add(label21);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1118, 710);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Investment Analysis";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage5.Click += tabPage5_Click;
            // 
            // btn_Invest_Save
            // 
            btn_Invest_Save.Location = new Point(1040, 41);
            btn_Invest_Save.Name = "btn_Invest_Save";
            btn_Invest_Save.Size = new Size(75, 23);
            btn_Invest_Save.TabIndex = 27;
            btn_Invest_Save.Text = "Save";
            btn_Invest_Save.UseVisualStyleBackColor = true;
            btn_Invest_Save.Click += btn_Invest_Save_Click;
            // 
            // btn_Invest_Add
            // 
            btn_Invest_Add.Location = new Point(1040, 11);
            btn_Invest_Add.Name = "btn_Invest_Add";
            btn_Invest_Add.Size = new Size(75, 23);
            btn_Invest_Add.TabIndex = 10;
            btn_Invest_Add.Text = "Add";
            btn_Invest_Add.UseVisualStyleBackColor = true;
            btn_Invest_Add.Click += btn_Invest_Add_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(3, 3);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(1031, 704);
            dataGridView5.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(475, 86);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(317, 89);
            label25.Name = "label25";
            label25.Size = new Size(152, 15);
            label25.TabIndex = 7;
            label25.Text = "Expected Rate Of Return :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(121, 137);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(454, 23);
            textBox6.TabIndex = 6;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(38, 140);
            label24.Name = "label24";
            label24.Size = new Size(77, 15);
            label24.TabIndex = 5;
            label24.Text = "Description :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(176, 89);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 23);
            textBox5.TabIndex = 4;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(37, 92);
            label23.Name = "label23";
            label23.Size = new Size(133, 15);
            label23.TabIndex = 3;
            label23.Text = "Estimated Investment :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 46);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(438, 23);
            textBox4.TabIndex = 2;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(38, 49);
            label22.Name = "label22";
            label22.Size = new Size(90, 15);
            label22.TabIndex = 1;
            label22.Text = "Project Name :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label21.Location = new Point(6, 11);
            label21.Name = "label21";
            label21.Size = new Size(217, 15);
            label21.TabIndex = 0;
            label21.Text = "Investment opportunity evaluation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 22);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 59);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(210, 22);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(210, 59);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 24;
            // 
            // financeDepartmentBindingSource
            // 
            financeDepartmentBindingSource.DataSource = typeof(FinanceDepartment);
            // 
            // financeDepartmentBindingSource1
            // 
            financeDepartmentBindingSource1.DataSource = typeof(FinanceDepartment);
            // 
            // financeDepartmentBindingSource2
            // 
            financeDepartmentBindingSource2.DataSource = typeof(FinanceDepartment);
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(198, 12);
            label30.Name = "label30";
            label30.Size = new Size(49, 15);
            label30.TabIndex = 25;
            label30.Text = "label30";
            label30.Click += label30_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(198, 39);
            label31.Name = "label31";
            label31.Size = new Size(49, 15);
            label31.TabIndex = 26;
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
            // FinanceDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1153, 858);
            Controls.Add(btnLogout);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ad);
            Controls.Add(btnUserProfile);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(pictureBox1);
            Name = "FinanceDepartment";
            Text = "FinanceDepartment";
            Load += FinanceDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ad.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)financeDepartmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)financeDepartmentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)financeDepartmentBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUserProfile;
        private Label label19;
        private Label label18;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button btn_Add;
        private Label label4;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label12;
        private TextBox riskPeriodText;
        private Label label11;
        private ComboBox riskReportTypeText;
        private Label label10;
        private Label label9;
        private Button btn_ReportUpload;
        private DataGridView dataGridView3;
        private Button btn_Report_Add;
        private Label uploadFileText;
        private ComboBox riskLevelCombo;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label17;
        private DataGridView dataGridView4;
        private Button btn_Risk_Add;
        private TextBox riskMitiText;
        private Label label20;
        private TextBox riskDescText;
        private DataGridView dataGridView5;
        private TextBox textBox7;
        private Label label25;
        private TextBox textBox6;
        private Label label24;
        private TextBox textBox5;
        private Label label23;
        private TextBox textBox4;
        private Label label22;
        private Label label21;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btn_Invest_Add;
        private TextBox riskTypeText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private BindingSource financeDepartmentBindingSource;
        private BindingSource financeDepartmentBindingSource1;
        private BindingSource financeDepartmentBindingSource2;
        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_Save;
        private Label label30;
        private Label label31;
        private Button btnLogout;
        private Button btn_Income_Save;
        private Button btn_Income_Add;
        private Button btn_Invest_Save;
        private TabControl ad;
        private Button btn_RiskSave;
    }
}