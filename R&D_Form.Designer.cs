namespace C_Project
{
    partial class RaD_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaD_Form));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label20 = new Label();
            UserName = new Label();
            Department = new Label();
            dgvProductList = new DataGridView();
            NewProductsButton = new Button();
            tabProductDetail = new TabControl();
            ProductSpecificationsTabPage = new TabPage();
            BillofMaterialsTabPage = new TabPage();
            ManufacturingInstructionsTabPage = new TabPage();
            PackagingInformationTabPage = new TabPage();
            TestingACertificationTabPage = new TabPage();
            ImageAttachmentsTabPage = new TabPage();
            label2 = new Label();
            txtProductName = new TextBox();
            cmbStatus = new ComboBox();
            label3 = new Label();
            txtProductCode = new TextBox();
            label4 = new Label();
            txtMOQ = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbProject = new ComboBox();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            CustomerTextBox = new TextBox();
            label9 = new Label();
            RequirementTextBox = new TextBox();
            label10 = new Label();
            StatusTextBox = new TextBox();
            ViewProjectButton = new Button();
            dgvMaterials = new DataGridView();
            MaterialType = new DataGridViewComboBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            BillofMaterialsDelete = new DataGridViewButtonColumn();
            AddMaterialButton = new Button();
            dgvManufacturing = new DataGridView();
            StepNumber = new DataGridViewTextBoxColumn();
            Content = new DataGridViewTextBoxColumn();
            Equipment = new DataGridViewTextBoxColumn();
            WorkingHours = new DataGridViewTextBoxColumn();
            Personnel = new DataGridViewTextBoxColumn();
            ManufacturingInstructionsDelete = new DataGridViewButtonColumn();
            AddNewStepButton = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtPackDimensions = new TextBox();
            txtPackMaterial = new TextBox();
            txtPackLabel = new TextBox();
            dgvTesting = new DataGridView();
            Testtype = new DataGridViewTextBoxColumn();
            condition = new DataGridViewTextBoxColumn();
            standard = new DataGridViewTextBoxColumn();
            dgvTestingdelete = new DataGridViewButtonColumn();
            AddedTestsButton = new Button();
            dataGridView1 = new DataGridView();
            CertificationName = new DataGridViewTextBoxColumn();
            dgvCertsContent = new DataGridViewTextBoxColumn();
            dgvCertsDeletion = new DataGridViewButtonColumn();
            NewCertificationButton = new Button();
            pictureBox2 = new PictureBox();
            UploadImageButton = new Button();
            ViewAllButton = new Button();
            btnSave = new Button();
            btnReset = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            tabProductDetail.SuspendLayout();
            ProductSpecificationsTabPage.SuspendLayout();
            BillofMaterialsTabPage.SuspendLayout();
            ManufacturingInstructionsTabPage.SuspendLayout();
            PackagingInformationTabPage.SuspendLayout();
            TestingACertificationTabPage.SuspendLayout();
            ImageAttachmentsTabPage.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterials).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTesting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 50);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Department :";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button2.Location = new Point(1091, 12);
            button2.Name = "button2";
            button2.Size = new Size(59, 38);
            button2.TabIndex = 33;
            button2.Text = "User Prifile";
            button2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(104, 24);
            label20.Name = "label20";
            label20.Size = new Size(76, 15);
            label20.TabIndex = 46;
            label20.Text = "User Name :";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(176, 24);
            UserName.Name = "UserName";
            UserName.Size = new Size(0, 15);
            UserName.TabIndex = 47;
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Location = new Point(176, 50);
            Department.Name = "Department";
            Department.Size = new Size(0, 15);
            Department.TabIndex = 48;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductList.Columns.AddRange(new DataGridViewColumn[] { ProductCode, ProductName, Edit, Delete });
            dgvProductList.Location = new Point(12, 125);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.Size = new Size(330, 710);
            dgvProductList.TabIndex = 49;
            dgvProductList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NewProductsButton
            // 
            NewProductsButton.Location = new Point(12, 97);
            NewProductsButton.Name = "NewProductsButton";
            NewProductsButton.Size = new Size(118, 23);
            NewProductsButton.TabIndex = 50;
            NewProductsButton.TabStop = false;
            NewProductsButton.Text = "＋New products";
            NewProductsButton.UseVisualStyleBackColor = true;
            NewProductsButton.Click += NewProductsButton_Click;
            // 
            // tabProductDetail
            // 
            tabProductDetail.CausesValidation = false;
            tabProductDetail.Controls.Add(ProductSpecificationsTabPage);
            tabProductDetail.Controls.Add(BillofMaterialsTabPage);
            tabProductDetail.Controls.Add(ManufacturingInstructionsTabPage);
            tabProductDetail.Controls.Add(PackagingInformationTabPage);
            tabProductDetail.Controls.Add(TestingACertificationTabPage);
            tabProductDetail.Controls.Add(ImageAttachmentsTabPage);
            tabProductDetail.Location = new Point(348, 125);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.SelectedIndex = 0;
            tabProductDetail.Size = new Size(802, 680);
            tabProductDetail.TabIndex = 51;
            // 
            // ProductSpecificationsTabPage
            // 
            ProductSpecificationsTabPage.Controls.Add(panel1);
            ProductSpecificationsTabPage.Location = new Point(4, 24);
            ProductSpecificationsTabPage.Name = "ProductSpecificationsTabPage";
            ProductSpecificationsTabPage.Padding = new Padding(3);
            ProductSpecificationsTabPage.Size = new Size(794, 652);
            ProductSpecificationsTabPage.TabIndex = 0;
            ProductSpecificationsTabPage.Text = "Product Specifications";
            ProductSpecificationsTabPage.UseVisualStyleBackColor = true;
            // 
            // BillofMaterialsTabPage
            // 
            BillofMaterialsTabPage.Controls.Add(AddMaterialButton);
            BillofMaterialsTabPage.Controls.Add(dgvMaterials);
            BillofMaterialsTabPage.Location = new Point(4, 24);
            BillofMaterialsTabPage.Name = "BillofMaterialsTabPage";
            BillofMaterialsTabPage.Padding = new Padding(3);
            BillofMaterialsTabPage.Size = new Size(794, 652);
            BillofMaterialsTabPage.TabIndex = 1;
            BillofMaterialsTabPage.Text = "Bill of Materials";
            BillofMaterialsTabPage.UseVisualStyleBackColor = true;
            // 
            // ManufacturingInstructionsTabPage
            // 
            ManufacturingInstructionsTabPage.Controls.Add(AddNewStepButton);
            ManufacturingInstructionsTabPage.Controls.Add(dgvManufacturing);
            ManufacturingInstructionsTabPage.Location = new Point(4, 24);
            ManufacturingInstructionsTabPage.Name = "ManufacturingInstructionsTabPage";
            ManufacturingInstructionsTabPage.Padding = new Padding(3);
            ManufacturingInstructionsTabPage.Size = new Size(794, 652);
            ManufacturingInstructionsTabPage.TabIndex = 2;
            ManufacturingInstructionsTabPage.Text = "Manufacturing Instructions";
            ManufacturingInstructionsTabPage.UseVisualStyleBackColor = true;
            // 
            // PackagingInformationTabPage
            // 
            PackagingInformationTabPage.Controls.Add(txtPackLabel);
            PackagingInformationTabPage.Controls.Add(txtPackMaterial);
            PackagingInformationTabPage.Controls.Add(txtPackDimensions);
            PackagingInformationTabPage.Controls.Add(label13);
            PackagingInformationTabPage.Controls.Add(label12);
            PackagingInformationTabPage.Controls.Add(label11);
            PackagingInformationTabPage.Location = new Point(4, 24);
            PackagingInformationTabPage.Name = "PackagingInformationTabPage";
            PackagingInformationTabPage.Padding = new Padding(3);
            PackagingInformationTabPage.Size = new Size(794, 652);
            PackagingInformationTabPage.TabIndex = 3;
            PackagingInformationTabPage.Text = "Packaging Information";
            PackagingInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // TestingACertificationTabPage
            // 
            TestingACertificationTabPage.Controls.Add(NewCertificationButton);
            TestingACertificationTabPage.Controls.Add(dataGridView1);
            TestingACertificationTabPage.Controls.Add(AddedTestsButton);
            TestingACertificationTabPage.Controls.Add(dgvTesting);
            TestingACertificationTabPage.Location = new Point(4, 24);
            TestingACertificationTabPage.Name = "TestingACertificationTabPage";
            TestingACertificationTabPage.Padding = new Padding(3);
            TestingACertificationTabPage.Size = new Size(794, 652);
            TestingACertificationTabPage.TabIndex = 4;
            TestingACertificationTabPage.Text = "Testing/Certification";
            TestingACertificationTabPage.UseVisualStyleBackColor = true;
            // 
            // ImageAttachmentsTabPage
            // 
            ImageAttachmentsTabPage.Controls.Add(ViewAllButton);
            ImageAttachmentsTabPage.Controls.Add(UploadImageButton);
            ImageAttachmentsTabPage.Controls.Add(pictureBox2);
            ImageAttachmentsTabPage.Location = new Point(4, 24);
            ImageAttachmentsTabPage.Name = "ImageAttachmentsTabPage";
            ImageAttachmentsTabPage.Padding = new Padding(3);
            ImageAttachmentsTabPage.Size = new Size(794, 652);
            ImageAttachmentsTabPage.TabIndex = 5;
            ImageAttachmentsTabPage.Text = "Image Attachments";
            ImageAttachmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 15);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 52;
            label2.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(9, 33);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(157, 23);
            txtProductName.TabIndex = 53;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Under development", "", "In mass production", "", "Discontinued" });
            cmbStatus.Location = new Point(521, 30);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(168, 23);
            cmbStatus.TabIndex = 54;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 12);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 55;
            label3.Text = "Product Number";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(202, 30);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(131, 23);
            txtProductCode.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 12);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 57;
            label4.Text = "MOQ";
            // 
            // txtMOQ
            // 
            txtMOQ.Location = new Point(375, 30);
            txtMOQ.Name = "txtMOQ";
            txtMOQ.Size = new Size(97, 23);
            txtMOQ.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 12);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 59;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 67);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 60;
            label6.Text = "Project";
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(9, 85);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(680, 23);
            cmbProject.TabIndex = 61;
            // 
            // ProductCode
            // 
            ProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ProductCode.HeaderText = "ProductCode";
            ProductCode.Name = "ProductCode";
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ProductName.HeaderText = "ProductName";
            ProductName.Name = "ProductName";
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Width = 35;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Width = 50;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(ViewProjectButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(StatusTextBox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RequirementTextBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cmbProject);
            panel1.Controls.Add(CustomerTextBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtProductCode);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtMOQ);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 649);
            panel1.TabIndex = 62;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 134);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 0;
            label7.Text = "Project Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 134);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 1;
            label8.Text = "Customer";
            // 
            // CustomerTextBox
            // 
            CustomerTextBox.Location = new Point(275, 131);
            CustomerTextBox.Name = "CustomerTextBox";
            CustomerTextBox.Size = new Size(100, 23);
            CustomerTextBox.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 166);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 3;
            label9.Text = "Requirement";
            // 
            // RequirementTextBox
            // 
            RequirementTextBox.Location = new Point(102, 163);
            RequirementTextBox.Name = "RequirementTextBox";
            RequirementTextBox.Size = new Size(100, 23);
            RequirementTextBox.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 197);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 5;
            label10.Text = "Status";
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(102, 197);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(100, 23);
            StatusTextBox.TabIndex = 6;
            // 
            // ViewProjectButton
            // 
            ViewProjectButton.Location = new Point(13, 238);
            ViewProjectButton.Name = "ViewProjectButton";
            ViewProjectButton.Size = new Size(128, 33);
            ViewProjectButton.TabIndex = 7;
            ViewProjectButton.Text = "View Project";
            ViewProjectButton.UseVisualStyleBackColor = true;
            // 
            // dgvMaterials
            // 
            dgvMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterials.Columns.AddRange(new DataGridViewColumn[] { MaterialType, MaterialName, Description, Quantity, BillofMaterialsDelete });
            dgvMaterials.Location = new Point(0, 0);
            dgvMaterials.Name = "dgvMaterials";
            dgvMaterials.Size = new Size(794, 652);
            dgvMaterials.TabIndex = 0;
            // 
            // MaterialType
            // 
            MaterialType.HeaderText = "Material Type";
            MaterialType.Name = "MaterialType";
            // 
            // MaterialName
            // 
            MaterialName.HeaderText = "Material Name";
            MaterialName.Name = "MaterialName";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // BillofMaterialsDelete
            // 
            BillofMaterialsDelete.HeaderText = "Delete";
            BillofMaterialsDelete.Name = "BillofMaterialsDelete";
            // 
            // AddMaterialButton
            // 
            AddMaterialButton.Location = new Point(0, 65);
            AddMaterialButton.Name = "AddMaterialButton";
            AddMaterialButton.Size = new Size(145, 39);
            AddMaterialButton.TabIndex = 52;
            AddMaterialButton.Text = "＋Add Material";
            AddMaterialButton.UseVisualStyleBackColor = true;
            // 
            // dgvManufacturing
            // 
            dgvManufacturing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManufacturing.Columns.AddRange(new DataGridViewColumn[] { StepNumber, Content, Equipment, WorkingHours, Personnel, ManufacturingInstructionsDelete });
            dgvManufacturing.Location = new Point(0, 0);
            dgvManufacturing.Name = "dgvManufacturing";
            dgvManufacturing.Size = new Size(795, 652);
            dgvManufacturing.TabIndex = 0;
            // 
            // StepNumber
            // 
            StepNumber.HeaderText = "Step number";
            StepNumber.Name = "StepNumber";
            // 
            // Content
            // 
            Content.HeaderText = "Content";
            Content.Name = "Content";
            // 
            // Equipment
            // 
            Equipment.HeaderText = "Equipment";
            Equipment.Name = "Equipment";
            // 
            // WorkingHours
            // 
            WorkingHours.HeaderText = "Working hours";
            WorkingHours.Name = "WorkingHours";
            // 
            // Personnel
            // 
            Personnel.HeaderText = "Personnel";
            Personnel.Name = "Personnel";
            // 
            // ManufacturingInstructionsDelete
            // 
            ManufacturingInstructionsDelete.HeaderText = "Delete";
            ManufacturingInstructionsDelete.Name = "ManufacturingInstructionsDelete";
            // 
            // AddNewStepButton
            // 
            AddNewStepButton.Location = new Point(6, 69);
            AddNewStepButton.Name = "AddNewStepButton";
            AddNewStepButton.Size = new Size(100, 42);
            AddNewStepButton.TabIndex = 52;
            AddNewStepButton.Text = "＋Add new step";
            AddNewStepButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 17);
            label11.Name = "label11";
            label11.Size = new Size(101, 15);
            label11.TabIndex = 0;
            label11.Text = "Pack Dimensions";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(238, 18);
            label12.Name = "label12";
            label12.Size = new Size(83, 15);
            label12.TabIndex = 1;
            label12.Text = "Pack Material";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 79);
            label13.Name = "label13";
            label13.Size = new Size(91, 15);
            label13.TabIndex = 2;
            label13.Text = "Label/Warning";
            // 
            // txtPackDimensions
            // 
            txtPackDimensions.AcceptsTab = true;
            txtPackDimensions.Location = new Point(21, 37);
            txtPackDimensions.Name = "txtPackDimensions";
            txtPackDimensions.Size = new Size(157, 23);
            txtPackDimensions.TabIndex = 3;
            // 
            // txtPackMaterial
            // 
            txtPackMaterial.Location = new Point(233, 37);
            txtPackMaterial.Name = "txtPackMaterial";
            txtPackMaterial.Size = new Size(163, 23);
            txtPackMaterial.TabIndex = 4;
            // 
            // txtPackLabel
            // 
            txtPackLabel.Location = new Point(20, 97);
            txtPackLabel.Name = "txtPackLabel";
            txtPackLabel.Size = new Size(766, 23);
            txtPackLabel.TabIndex = 5;
            // 
            // dgvTesting
            // 
            dgvTesting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTesting.Columns.AddRange(new DataGridViewColumn[] { Testtype, condition, standard, dgvTestingdelete });
            dgvTesting.Location = new Point(0, 0);
            dgvTesting.Name = "dgvTesting";
            dgvTesting.Size = new Size(794, 225);
            dgvTesting.TabIndex = 0;
            // 
            // Testtype
            // 
            Testtype.HeaderText = "Test type";
            Testtype.Name = "Testtype";
            // 
            // condition
            // 
            condition.HeaderText = "condition";
            condition.Name = "condition";
            // 
            // standard
            // 
            standard.HeaderText = "standard";
            standard.Name = "standard";
            // 
            // dgvTestingdelete
            // 
            dgvTestingdelete.HeaderText = "delete";
            dgvTestingdelete.Name = "dgvTestingdelete";
            // 
            // AddedTestsButton
            // 
            AddedTestsButton.Location = new Point(3, 231);
            AddedTestsButton.Name = "AddedTestsButton";
            AddedTestsButton.Size = new Size(133, 46);
            AddedTestsButton.TabIndex = 52;
            AddedTestsButton.Text = "+Added tests";
            AddedTestsButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CertificationName, dgvCertsContent, dgvCertsDeletion });
            dataGridView1.Location = new Point(6, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(788, 242);
            dataGridView1.TabIndex = 53;
            // 
            // CertificationName
            // 
            CertificationName.HeaderText = "Certification Name";
            CertificationName.Name = "CertificationName";
            // 
            // dgvCertsContent
            // 
            dgvCertsContent.HeaderText = "Content";
            dgvCertsContent.Name = "dgvCertsContent";
            // 
            // dgvCertsDeletion
            // 
            dgvCertsDeletion.HeaderText = "Deletion";
            dgvCertsDeletion.Name = "dgvCertsDeletion";
            // 
            // NewCertificationButton
            // 
            NewCertificationButton.Location = new Point(3, 538);
            NewCertificationButton.Name = "NewCertificationButton";
            NewCertificationButton.Size = new Size(133, 46);
            NewCertificationButton.TabIndex = 54;
            NewCertificationButton.Text = "+ New certification";
            NewCertificationButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(341, 346);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // UploadImageButton
            // 
            UploadImageButton.Location = new Point(387, 132);
            UploadImageButton.Name = "UploadImageButton";
            UploadImageButton.Size = new Size(90, 90);
            UploadImageButton.TabIndex = 1;
            UploadImageButton.Text = "Upload Image";
            UploadImageButton.UseVisualStyleBackColor = true;
            // 
            // ViewAllButton
            // 
            ViewAllButton.Location = new Point(539, 132);
            ViewAllButton.Name = "ViewAllButton";
            ViewAllButton.Size = new Size(90, 90);
            ViewAllButton.TabIndex = 2;
            ViewAllButton.Text = "View All";
            ViewAllButton.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(797, 811);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 42);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(922, 811);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(97, 42);
            btnReset.TabIndex = 53;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1049, 811);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 42);
            btnClose.TabIndex = 54;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // RaD_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1161, 865);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(tabProductDetail);
            Controls.Add(NewProductsButton);
            Controls.Add(dgvProductList);
            Controls.Add(Department);
            Controls.Add(UserName);
            Controls.Add(label20);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "RaD_Form";
            Text = "RaD_Form";
            Load += RaD_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            tabProductDetail.ResumeLayout(false);
            ProductSpecificationsTabPage.ResumeLayout(false);
            BillofMaterialsTabPage.ResumeLayout(false);
            ManufacturingInstructionsTabPage.ResumeLayout(false);
            PackagingInformationTabPage.ResumeLayout(false);
            PackagingInformationTabPage.PerformLayout();
            TestingACertificationTabPage.ResumeLayout(false);
            ImageAttachmentsTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterials).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturing).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTesting).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label20;
        private Label UserName;
        private Label Department;
        private DataGridView dgvProductList;
        private Button NewProductsButton;
        private TabControl tabProductDetail;
        private TabPage ProductSpecificationsTabPage;
        private TabPage BillofMaterialsTabPage;
        private TabPage ManufacturingInstructionsTabPage;
        private TabPage PackagingInformationTabPage;
        private TabPage TestingACertificationTabPage;
        private TabPage ImageAttachmentsTabPage;
        private Label label2;
        private TextBox txtProductName;
        private ComboBox cmbStatus;
        private Label label3;
        private TextBox txtProductCode;
        private Label label4;
        private TextBox txtMOQ;
        private Label label5;
        private Label label6;
        private ComboBox cmbProject;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Panel panel1;
        private Button ViewProjectButton;
        private TextBox StatusTextBox;
        private Label label10;
        private TextBox RequirementTextBox;
        private Label label9;
        private TextBox CustomerTextBox;
        private Label label8;
        private Label label7;
        private DataGridView dgvMaterials;
        private Button AddMaterialButton;
        private DataGridViewComboBoxColumn MaterialType;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewButtonColumn BillofMaterialsDelete;
        private DataGridView dgvManufacturing;
        private DataGridViewTextBoxColumn StepNumber;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn Equipment;
        private DataGridViewTextBoxColumn WorkingHours;
        private DataGridViewTextBoxColumn Personnel;
        private DataGridViewButtonColumn ManufacturingInstructionsDelete;
        private Button AddNewStepButton;
        private TextBox txtPackLabel;
        private TextBox txtPackMaterial;
        private TextBox txtPackDimensions;
        private Label label13;
        private Label label12;
        private Label label11;
        private DataGridView dgvTesting;
        private Button AddedTestsButton;
        private DataGridViewTextBoxColumn Testtype;
        private DataGridViewTextBoxColumn condition;
        private DataGridViewTextBoxColumn standard;
        private DataGridViewButtonColumn dgvTestingdelete;
        private Button NewCertificationButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CertificationName;
        private DataGridViewTextBoxColumn dgvCertsContent;
        private DataGridViewButtonColumn dgvCertsDeletion;
        private Button ViewAllButton;
        private Button UploadImageButton;
        private PictureBox pictureBox2;
        private Button btnSave;
        private Button btnReset;
        private Button btnClose;
    }
}