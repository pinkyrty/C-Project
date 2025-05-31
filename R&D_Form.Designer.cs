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
            pictureBox1 = new PictureBox();
            RaDUserPrifileButton = new Button();
            UserNamelabel = new Label();
            UserName = new Label();
            Department = new Label();
            dgvProductList = new DataGridView();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            NewProductsButton = new Button();
            tabProductDetail = new TabControl();
            ProductSpecificationsTabPage = new TabPage();
            panel1 = new Panel();
            txtProductName = new TextBox();
            ViewProjectButton = new Button();
            ProductNamelabel = new Label();
            cmbStatus = new ComboBox();
            StatusTextBox = new TextBox();
            RaDStatuslabel = new Label();
            ProductNumberlabel = new Label();
            RequirementTextBox = new TextBox();
            Requirementlabel = new Label();
            cmbProject = new ComboBox();
            CustomerTextBox = new TextBox();
            Customerlabel = new Label();
            txtProductCode = new TextBox();
            ProjectNamelabel = new Label();
            txtMOQ = new TextBox();
            Projectlabel = new Label();
            Statuslabel = new Label();
            MOQlabel = new Label();
            BillofMaterialsTabPage = new TabPage();
            AddMaterialButton = new Button();
            dgvMaterials = new DataGridView();
            MaterialType = new DataGridViewComboBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            BillofMaterialsDelete = new DataGridViewButtonColumn();
            ManufacturingInstructionsTabPage = new TabPage();
            AddNewStepButton = new Button();
            dgvManufacturing = new DataGridView();
            StepNumber = new DataGridViewTextBoxColumn();
            Content = new DataGridViewTextBoxColumn();
            Equipment = new DataGridViewTextBoxColumn();
            WorkingHours = new DataGridViewTextBoxColumn();
            Personnel = new DataGridViewTextBoxColumn();
            ManufacturingInstructionsDelete = new DataGridViewButtonColumn();
            PackagingInformationTabPage = new TabPage();
            txtPackLabel = new TextBox();
            txtPackMaterial = new TextBox();
            txtPackDimensions = new TextBox();
            Label_Warninglabel = new Label();
            PackMateriallabel = new Label();
            PackDimensionslabel = new Label();
            TestingACertificationTabPage = new TabPage();
            NewCertificationButton = new Button();
            dataGridView1 = new DataGridView();
            CertificationName = new DataGridViewTextBoxColumn();
            dgvCertsContent = new DataGridViewTextBoxColumn();
            dgvCertsDeletion = new DataGridViewButtonColumn();
            AddedTestsButton = new Button();
            dgvTesting = new DataGridView();
            Testtype = new DataGridViewTextBoxColumn();
            condition = new DataGridViewTextBoxColumn();
            standard = new DataGridViewTextBoxColumn();
            dgvTestingdelete = new DataGridViewButtonColumn();
            ImageAttachmentsTabPage = new TabPage();
            ViewAllButton = new Button();
            UploadImageButton = new Button();
            ProductPictureBox = new PictureBox();
            btnSave = new Button();
            btnReset = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            tabProductDetail.SuspendLayout();
            ProductSpecificationsTabPage.SuspendLayout();
            panel1.SuspendLayout();
            BillofMaterialsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterials).BeginInit();
            ManufacturingInstructionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturing).BeginInit();
            PackagingInformationTabPage.SuspendLayout();
            TestingACertificationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTesting).BeginInit();
            ImageAttachmentsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            SuspendLayout();
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
            // RaDUserPrifileButton
            // 
            RaDUserPrifileButton.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            RaDUserPrifileButton.Location = new Point(1091, 12);
            RaDUserPrifileButton.Name = "RaDUserPrifileButton";
            RaDUserPrifileButton.Size = new Size(59, 38);
            RaDUserPrifileButton.TabIndex = 33;
            RaDUserPrifileButton.Text = "User Prifile";
            RaDUserPrifileButton.UseVisualStyleBackColor = true;
            RaDUserPrifileButton.Click += RaDUserPrifileButton_Click;
            // 
            // UserNamelabel
            // 
            UserNamelabel.AutoSize = true;
            UserNamelabel.Location = new Point(104, 24);
            UserNamelabel.Name = "UserNamelabel";
            UserNamelabel.Size = new Size(76, 15);
            UserNamelabel.TabIndex = 46;
            UserNamelabel.Text = "User Name :";
            UserNamelabel.Click += UserNamelabel_Click;
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
            // panel1
            // 
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(ViewProjectButton);
            panel1.Controls.Add(ProductNamelabel);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(StatusTextBox);
            panel1.Controls.Add(RaDStatuslabel);
            panel1.Controls.Add(ProductNumberlabel);
            panel1.Controls.Add(RequirementTextBox);
            panel1.Controls.Add(Requirementlabel);
            panel1.Controls.Add(cmbProject);
            panel1.Controls.Add(CustomerTextBox);
            panel1.Controls.Add(Customerlabel);
            panel1.Controls.Add(txtProductCode);
            panel1.Controls.Add(ProjectNamelabel);
            panel1.Controls.Add(txtMOQ);
            panel1.Controls.Add(Projectlabel);
            panel1.Controls.Add(Statuslabel);
            panel1.Controls.Add(MOQlabel);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 649);
            panel1.TabIndex = 62;
            panel1.Paint += panel1_Paint;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(9, 33);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(157, 23);
            txtProductName.TabIndex = 53;
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
            // ProductNamelabel
            // 
            ProductNamelabel.AutoSize = true;
            ProductNamelabel.Location = new Point(9, 12);
            ProductNamelabel.Name = "ProductNamelabel";
            ProductNamelabel.Size = new Size(89, 15);
            ProductNamelabel.TabIndex = 52;
            ProductNamelabel.Text = "Product Name";
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
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(102, 197);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(100, 23);
            StatusTextBox.TabIndex = 6;
            // 
            // RaDStatuslabel
            // 
            RaDStatuslabel.AutoSize = true;
            RaDStatuslabel.Location = new Point(16, 197);
            RaDStatuslabel.Name = "RaDStatuslabel";
            RaDStatuslabel.Size = new Size(41, 15);
            RaDStatuslabel.TabIndex = 5;
            RaDStatuslabel.Text = "Status";
            // 
            // ProductNumberlabel
            // 
            ProductNumberlabel.AutoSize = true;
            ProductNumberlabel.Location = new Point(198, 12);
            ProductNumberlabel.Name = "ProductNumberlabel";
            ProductNumberlabel.Size = new Size(101, 15);
            ProductNumberlabel.TabIndex = 55;
            ProductNumberlabel.Text = "Product Number";
            // 
            // RequirementTextBox
            // 
            RequirementTextBox.Location = new Point(102, 163);
            RequirementTextBox.Name = "RequirementTextBox";
            RequirementTextBox.Size = new Size(100, 23);
            RequirementTextBox.TabIndex = 4;
            // 
            // Requirementlabel
            // 
            Requirementlabel.AutoSize = true;
            Requirementlabel.Location = new Point(16, 166);
            Requirementlabel.Name = "Requirementlabel";
            Requirementlabel.Size = new Size(80, 15);
            Requirementlabel.TabIndex = 3;
            Requirementlabel.Text = "Requirement";
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(9, 85);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(680, 23);
            cmbProject.TabIndex = 61;
            // 
            // CustomerTextBox
            // 
            CustomerTextBox.Location = new Point(275, 131);
            CustomerTextBox.Name = "CustomerTextBox";
            CustomerTextBox.Size = new Size(100, 23);
            CustomerTextBox.TabIndex = 2;
            // 
            // Customerlabel
            // 
            Customerlabel.AutoSize = true;
            Customerlabel.Location = new Point(208, 134);
            Customerlabel.Name = "Customerlabel";
            Customerlabel.Size = new Size(61, 15);
            Customerlabel.TabIndex = 1;
            Customerlabel.Text = "Customer";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(202, 30);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(131, 23);
            txtProductCode.TabIndex = 56;
            // 
            // ProjectNamelabel
            // 
            ProjectNamelabel.AutoSize = true;
            ProjectNamelabel.Location = new Point(16, 134);
            ProjectNamelabel.Name = "ProjectNamelabel";
            ProjectNamelabel.Size = new Size(84, 15);
            ProjectNamelabel.TabIndex = 0;
            ProjectNamelabel.Text = "Project Name";
            // 
            // txtMOQ
            // 
            txtMOQ.Location = new Point(375, 30);
            txtMOQ.Name = "txtMOQ";
            txtMOQ.Size = new Size(97, 23);
            txtMOQ.TabIndex = 58;
            // 
            // Projectlabel
            // 
            Projectlabel.AutoSize = true;
            Projectlabel.Location = new Point(6, 67);
            Projectlabel.Name = "Projectlabel";
            Projectlabel.Size = new Size(46, 15);
            Projectlabel.TabIndex = 60;
            Projectlabel.Text = "Project";
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Location = new Point(518, 12);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(41, 15);
            Statuslabel.TabIndex = 59;
            Statuslabel.Text = "Status";
            // 
            // MOQlabel
            // 
            MOQlabel.AutoSize = true;
            MOQlabel.Location = new Point(372, 12);
            MOQlabel.Name = "MOQlabel";
            MOQlabel.Size = new Size(39, 15);
            MOQlabel.TabIndex = 57;
            MOQlabel.Text = "MOQ";
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
            // AddMaterialButton
            // 
            AddMaterialButton.Location = new Point(0, 65);
            AddMaterialButton.Name = "AddMaterialButton";
            AddMaterialButton.Size = new Size(145, 39);
            AddMaterialButton.TabIndex = 52;
            AddMaterialButton.Text = "＋Add Material";
            AddMaterialButton.UseVisualStyleBackColor = true;
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
            // AddNewStepButton
            // 
            AddNewStepButton.Location = new Point(6, 69);
            AddNewStepButton.Name = "AddNewStepButton";
            AddNewStepButton.Size = new Size(100, 42);
            AddNewStepButton.TabIndex = 52;
            AddNewStepButton.Text = "＋Add new step";
            AddNewStepButton.UseVisualStyleBackColor = true;
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
            // PackagingInformationTabPage
            // 
            PackagingInformationTabPage.Controls.Add(txtPackLabel);
            PackagingInformationTabPage.Controls.Add(txtPackMaterial);
            PackagingInformationTabPage.Controls.Add(txtPackDimensions);
            PackagingInformationTabPage.Controls.Add(Label_Warninglabel);
            PackagingInformationTabPage.Controls.Add(PackMateriallabel);
            PackagingInformationTabPage.Controls.Add(PackDimensionslabel);
            PackagingInformationTabPage.Location = new Point(4, 24);
            PackagingInformationTabPage.Name = "PackagingInformationTabPage";
            PackagingInformationTabPage.Padding = new Padding(3);
            PackagingInformationTabPage.Size = new Size(794, 652);
            PackagingInformationTabPage.TabIndex = 3;
            PackagingInformationTabPage.Text = "Packaging Information";
            PackagingInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // txtPackLabel
            // 
            txtPackLabel.Location = new Point(20, 97);
            txtPackLabel.Name = "txtPackLabel";
            txtPackLabel.Size = new Size(766, 23);
            txtPackLabel.TabIndex = 5;
            // 
            // txtPackMaterial
            // 
            txtPackMaterial.Location = new Point(233, 37);
            txtPackMaterial.Name = "txtPackMaterial";
            txtPackMaterial.Size = new Size(163, 23);
            txtPackMaterial.TabIndex = 4;
            // 
            // txtPackDimensions
            // 
            txtPackDimensions.AcceptsTab = true;
            txtPackDimensions.Location = new Point(21, 37);
            txtPackDimensions.Name = "txtPackDimensions";
            txtPackDimensions.Size = new Size(157, 23);
            txtPackDimensions.TabIndex = 3;
            // 
            // Label_Warninglabel
            // 
            Label_Warninglabel.AutoSize = true;
            Label_Warninglabel.Location = new Point(20, 79);
            Label_Warninglabel.Name = "Label_Warninglabel";
            Label_Warninglabel.Size = new Size(91, 15);
            Label_Warninglabel.TabIndex = 2;
            Label_Warninglabel.Text = "Label/Warning";
            // 
            // PackMateriallabel
            // 
            PackMateriallabel.AutoSize = true;
            PackMateriallabel.Location = new Point(238, 18);
            PackMateriallabel.Name = "PackMateriallabel";
            PackMateriallabel.Size = new Size(83, 15);
            PackMateriallabel.TabIndex = 1;
            PackMateriallabel.Text = "Pack Material";
            // 
            // PackDimensionslabel
            // 
            PackDimensionslabel.AutoSize = true;
            PackDimensionslabel.Location = new Point(20, 17);
            PackDimensionslabel.Name = "PackDimensionslabel";
            PackDimensionslabel.Size = new Size(101, 15);
            PackDimensionslabel.TabIndex = 0;
            PackDimensionslabel.Text = "Pack Dimensions";
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
            // NewCertificationButton
            // 
            NewCertificationButton.Location = new Point(3, 538);
            NewCertificationButton.Name = "NewCertificationButton";
            NewCertificationButton.Size = new Size(133, 46);
            NewCertificationButton.TabIndex = 54;
            NewCertificationButton.Text = "+ New certification";
            NewCertificationButton.UseVisualStyleBackColor = true;
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
            // AddedTestsButton
            // 
            AddedTestsButton.Location = new Point(3, 231);
            AddedTestsButton.Name = "AddedTestsButton";
            AddedTestsButton.Size = new Size(133, 46);
            AddedTestsButton.TabIndex = 52;
            AddedTestsButton.Text = "+Added tests";
            AddedTestsButton.UseVisualStyleBackColor = true;
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
            // ImageAttachmentsTabPage
            // 
            ImageAttachmentsTabPage.Controls.Add(ViewAllButton);
            ImageAttachmentsTabPage.Controls.Add(UploadImageButton);
            ImageAttachmentsTabPage.Controls.Add(ProductPictureBox);
            ImageAttachmentsTabPage.Location = new Point(4, 24);
            ImageAttachmentsTabPage.Name = "ImageAttachmentsTabPage";
            ImageAttachmentsTabPage.Padding = new Padding(3);
            ImageAttachmentsTabPage.Size = new Size(794, 652);
            ImageAttachmentsTabPage.TabIndex = 5;
            ImageAttachmentsTabPage.Text = "Image Attachments";
            ImageAttachmentsTabPage.UseVisualStyleBackColor = true;
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
            // UploadImageButton
            // 
            UploadImageButton.Location = new Point(387, 132);
            UploadImageButton.Name = "UploadImageButton";
            UploadImageButton.Size = new Size(90, 90);
            UploadImageButton.TabIndex = 1;
            UploadImageButton.Text = "Upload Image";
            UploadImageButton.UseVisualStyleBackColor = true;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Location = new Point(6, 6);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(341, 346);
            ProductPictureBox.TabIndex = 0;
            ProductPictureBox.TabStop = false;
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
            Controls.Add(UserNamelabel);
            Controls.Add(RaDUserPrifileButton);
            Controls.Add(pictureBox1);
            Name = "RaD_Form";
            Text = "RaD_Form";
            Load += RaD_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            tabProductDetail.ResumeLayout(false);
            ProductSpecificationsTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            BillofMaterialsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterials).EndInit();
            ManufacturingInstructionsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvManufacturing).EndInit();
            PackagingInformationTabPage.ResumeLayout(false);
            PackagingInformationTabPage.PerformLayout();
            TestingACertificationTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTesting).EndInit();
            ImageAttachmentsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button RaDUserPrifileButton;
        private Label UserNamelabel;
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
        private Label ProductNamelabel;
        private TextBox txtProductName;
        private ComboBox cmbStatus;
        private Label ProductNumberlabel;
        private TextBox txtProductCode;
        private Label MOQlabel;
        private TextBox txtMOQ;
        private Label Statuslabel;
        private Label Projectlabel;
        private ComboBox cmbProject;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Panel panel1;
        private Button ViewProjectButton;
        private TextBox StatusTextBox;
        private Label RaDStatuslabel;
        private TextBox RequirementTextBox;
        private Label Requirementlabel;
        private TextBox CustomerTextBox;
        private Label Customerlabel;
        private Label ProjectNamelabel;
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
        private Label Label_Warninglabel;
        private Label PackMateriallabel;
        private Label PackDimensionslabel;
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
        private PictureBox ProductPictureBox;
        private Button btnSave;
        private Button btnReset;
        private Button btnClose;
    }
}