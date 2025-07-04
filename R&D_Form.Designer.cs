﻿namespace C_Project
{
    partial class RnD_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RnD_Form));
            pictureBox1 = new PictureBox();
            btnUserProfile = new Button();
            UserNamelabel = new Label();
            dgvProductList = new DataGridView();
            NewProductsButton = new Button();
            tabProductDetail = new TabControl();
            ProductSpecificationsTabPage = new TabPage();
            panel2 = new Panel();
            WarrantySupportTextBox = new TextBox();
            UserGuideTextBox = new TextBox();
            ComplianceStandardsTextBox = new TextBox();
            FunctionalDescriptionTextBox = new TextBox();
            ColorTextBox = new TextBox();
            SizeTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            BillofMaterialsTabPage = new TabPage();
            btn_Add = new Button();
            btn_Save = new Button();
            dgvMaterials = new DataGridView();
            ManufacturingInstructionsTabPage = new TabPage();
            btn_Add1 = new Button();
            btn_Save2 = new Button();
            dgvManufacturing = new DataGridView();
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
            AddedTestsButton = new Button();
            dgvTesting = new DataGridView();
            ImageAttachmentsTabPage = new TabPage();
            UploadImageButton = new Button();
            ProductPictureBox = new PictureBox();
            panel1 = new Panel();
            txtProductName = new TextBox();
            ProductNamelabel = new Label();
            cmbStatus = new ComboBox();
            RaDStatuslabel = new Label();
            ProductNumberlabel = new Label();
            Requirementlabel = new Label();
            cmbProject = new ComboBox();
            txtProductCode = new TextBox();
            txtMOQ = new TextBox();
            Projectlabel = new Label();
            Statuslabel = new Label();
            MOQlabel = new Label();
            btnSave = new Button();
            label2 = new Label();
            label31 = new Label();
            label30 = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            tabProductDetail.SuspendLayout();
            ProductSpecificationsTabPage.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.SuspendLayout();
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
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnUserProfile
            // 
            btnUserProfile.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnUserProfile.Location = new Point(1091, 12);
            btnUserProfile.Name = "btnUserProfile";
            btnUserProfile.Size = new Size(59, 38);
            btnUserProfile.TabIndex = 33;
            btnUserProfile.Text = "User Profile";
            btnUserProfile.UseVisualStyleBackColor = true;
            btnUserProfile.Click += RaDUserPrifileButton_Click;
            // 
            // UserNamelabel
            // 
            UserNamelabel.AutoSize = true;
            UserNamelabel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            UserNamelabel.Location = new Point(111, 12);
            UserNamelabel.Name = "UserNamelabel";
            UserNamelabel.Size = new Size(78, 15);
            UserNamelabel.TabIndex = 46;
            UserNamelabel.Text = "User Name :";
            UserNamelabel.Click += UserNamelabel_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductList.Location = new Point(12, 146);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.Size = new Size(330, 679);
            dgvProductList.TabIndex = 49;
            dgvProductList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NewProductsButton
            // 
            NewProductsButton.Location = new Point(12, 110);
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
            tabProductDetail.Location = new Point(352, 187);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.SelectedIndex = 0;
            tabProductDetail.Size = new Size(798, 594);
            tabProductDetail.TabIndex = 51;
            // 
            // ProductSpecificationsTabPage
            // 
            ProductSpecificationsTabPage.Controls.Add(panel2);
            ProductSpecificationsTabPage.Location = new Point(4, 24);
            ProductSpecificationsTabPage.Name = "ProductSpecificationsTabPage";
            ProductSpecificationsTabPage.Padding = new Padding(3);
            ProductSpecificationsTabPage.Size = new Size(790, 566);
            ProductSpecificationsTabPage.TabIndex = 0;
            ProductSpecificationsTabPage.Text = "Product Specifications";
            ProductSpecificationsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(WarrantySupportTextBox);
            panel2.Controls.Add(UserGuideTextBox);
            panel2.Controls.Add(ComplianceStandardsTextBox);
            panel2.Controls.Add(FunctionalDescriptionTextBox);
            panel2.Controls.Add(ColorTextBox);
            panel2.Controls.Add(SizeTextBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 566);
            panel2.TabIndex = 0;
            // 
            // WarrantySupportTextBox
            // 
            WarrantySupportTextBox.Location = new Point(125, 196);
            WarrantySupportTextBox.Name = "WarrantySupportTextBox";
            WarrantySupportTextBox.Size = new Size(389, 23);
            WarrantySupportTextBox.TabIndex = 11;
            // 
            // UserGuideTextBox
            // 
            UserGuideTextBox.Location = new Point(88, 151);
            UserGuideTextBox.Name = "UserGuideTextBox";
            UserGuideTextBox.Size = new Size(426, 23);
            UserGuideTextBox.TabIndex = 10;
            // 
            // ComplianceStandardsTextBox
            // 
            ComplianceStandardsTextBox.Location = new Point(147, 106);
            ComplianceStandardsTextBox.Name = "ComplianceStandardsTextBox";
            ComplianceStandardsTextBox.Size = new Size(460, 23);
            ComplianceStandardsTextBox.TabIndex = 9;
            // 
            // FunctionalDescriptionTextBox
            // 
            FunctionalDescriptionTextBox.Location = new Point(148, 52);
            FunctionalDescriptionTextBox.Name = "FunctionalDescriptionTextBox";
            FunctionalDescriptionTextBox.Size = new Size(459, 23);
            FunctionalDescriptionTextBox.TabIndex = 8;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(200, 9);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 7;
            // 
            // SizeTextBox
            // 
            SizeTextBox.Location = new Point(46, 11);
            SizeTextBox.Name = "SizeTextBox";
            SizeTextBox.Size = new Size(76, 23);
            SizeTextBox.TabIndex = 6;
            SizeTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 199);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 5;
            label7.Text = "Warranty Support:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 155);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 4;
            label6.Text = "User Guide:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 110);
            label5.Name = "label5";
            label5.Size = new Size(138, 15);
            label5.TabIndex = 3;
            label5.Text = "Compliance Standards:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(9, 55);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 2;
            label4.Text = "Functional Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 14);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 1;
            label3.Text = "Color:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Size:";
            // 
            // BillofMaterialsTabPage
            // 
            BillofMaterialsTabPage.Controls.Add(btn_Add);
            BillofMaterialsTabPage.Controls.Add(btn_Save);
            BillofMaterialsTabPage.Controls.Add(dgvMaterials);
            BillofMaterialsTabPage.Location = new Point(4, 24);
            BillofMaterialsTabPage.Name = "BillofMaterialsTabPage";
            BillofMaterialsTabPage.Padding = new Padding(3);
            BillofMaterialsTabPage.Size = new Size(790, 566);
            BillofMaterialsTabPage.TabIndex = 1;
            BillofMaterialsTabPage.Text = "Bill of Materials";
            BillofMaterialsTabPage.UseVisualStyleBackColor = true;
            BillofMaterialsTabPage.Click += BillofMaterialsTabPage_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(3, 537);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 53;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(87, 537);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 54;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // dgvMaterials
            // 
            dgvMaterials.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterials.Location = new Point(0, 0);
            dgvMaterials.Name = "dgvMaterials";
            dgvMaterials.Size = new Size(788, 531);
            dgvMaterials.TabIndex = 0;
            dgvMaterials.CellContentClick += dgvMaterials_CellContentClick;
            // 
            // ManufacturingInstructionsTabPage
            // 
            ManufacturingInstructionsTabPage.Controls.Add(btn_Add1);
            ManufacturingInstructionsTabPage.Controls.Add(btn_Save2);
            ManufacturingInstructionsTabPage.Controls.Add(dgvManufacturing);
            ManufacturingInstructionsTabPage.Location = new Point(4, 24);
            ManufacturingInstructionsTabPage.Name = "ManufacturingInstructionsTabPage";
            ManufacturingInstructionsTabPage.Padding = new Padding(3);
            ManufacturingInstructionsTabPage.Size = new Size(790, 566);
            ManufacturingInstructionsTabPage.TabIndex = 2;
            ManufacturingInstructionsTabPage.Text = "Manufacturing Instructions";
            ManufacturingInstructionsTabPage.UseVisualStyleBackColor = true;
            // 
            // btn_Add1
            // 
            btn_Add1.Location = new Point(5, 536);
            btn_Add1.Name = "btn_Add1";
            btn_Add1.Size = new Size(75, 23);
            btn_Add1.TabIndex = 55;
            btn_Add1.Text = "Add";
            btn_Add1.UseVisualStyleBackColor = true;
            btn_Add1.Click += btn_Add1_Click;
            // 
            // btn_Save2
            // 
            btn_Save2.Location = new Point(89, 536);
            btn_Save2.Name = "btn_Save2";
            btn_Save2.Size = new Size(75, 23);
            btn_Save2.TabIndex = 56;
            btn_Save2.Text = "Save";
            btn_Save2.UseVisualStyleBackColor = true;
            btn_Save2.Click += btn_Save2_Click;
            // 
            // dgvManufacturing
            // 
            dgvManufacturing.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvManufacturing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManufacturing.Location = new Point(0, 0);
            dgvManufacturing.Name = "dgvManufacturing";
            dgvManufacturing.Size = new Size(790, 530);
            dgvManufacturing.TabIndex = 0;
            dgvManufacturing.CellContentClick += dgvManufacturing_CellContentClick;
            // 
            // PackagingInformationTabPage
            // 
            PackagingInformationTabPage.BackColor = SystemColors.GradientInactiveCaption;
            PackagingInformationTabPage.Controls.Add(txtPackLabel);
            PackagingInformationTabPage.Controls.Add(txtPackMaterial);
            PackagingInformationTabPage.Controls.Add(txtPackDimensions);
            PackagingInformationTabPage.Controls.Add(Label_Warninglabel);
            PackagingInformationTabPage.Controls.Add(PackMateriallabel);
            PackagingInformationTabPage.Controls.Add(PackDimensionslabel);
            PackagingInformationTabPage.Location = new Point(4, 24);
            PackagingInformationTabPage.Name = "PackagingInformationTabPage";
            PackagingInformationTabPage.Padding = new Padding(3);
            PackagingInformationTabPage.Size = new Size(790, 566);
            PackagingInformationTabPage.TabIndex = 3;
            PackagingInformationTabPage.Text = "Packaging Information";
            // 
            // txtPackLabel
            // 
            txtPackLabel.Location = new Point(20, 97);
            txtPackLabel.Name = "txtPackLabel";
            txtPackLabel.Size = new Size(745, 23);
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
            TestingACertificationTabPage.Size = new Size(790, 566);
            TestingACertificationTabPage.TabIndex = 4;
            TestingACertificationTabPage.Text = "Testing/Certification";
            TestingACertificationTabPage.UseVisualStyleBackColor = true;
            // 
            // NewCertificationButton
            // 
            NewCertificationButton.Location = new Point(0, 488);
            NewCertificationButton.Name = "NewCertificationButton";
            NewCertificationButton.Size = new Size(133, 30);
            NewCertificationButton.TabIndex = 54;
            NewCertificationButton.Text = "+ New certification";
            NewCertificationButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(785, 250);
            dataGridView1.TabIndex = 53;
            // 
            // AddedTestsButton
            // 
            AddedTestsButton.Location = new Point(0, 179);
            AddedTestsButton.Name = "AddedTestsButton";
            AddedTestsButton.Size = new Size(133, 30);
            AddedTestsButton.TabIndex = 52;
            AddedTestsButton.Text = "+ New test";
            AddedTestsButton.UseVisualStyleBackColor = true;
            // 
            // dgvTesting
            // 
            dgvTesting.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvTesting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTesting.Location = new Point(0, 0);
            dgvTesting.Name = "dgvTesting";
            dgvTesting.Size = new Size(794, 173);
            dgvTesting.TabIndex = 0;
            dgvTesting.CellContentClick += dgvTesting_CellContentClick;
            // 
            // ImageAttachmentsTabPage
            // 
            ImageAttachmentsTabPage.BackColor = SystemColors.GradientInactiveCaption;
            ImageAttachmentsTabPage.Controls.Add(UploadImageButton);
            ImageAttachmentsTabPage.Controls.Add(ProductPictureBox);
            ImageAttachmentsTabPage.Location = new Point(4, 24);
            ImageAttachmentsTabPage.Name = "ImageAttachmentsTabPage";
            ImageAttachmentsTabPage.Padding = new Padding(3);
            ImageAttachmentsTabPage.Size = new Size(790, 566);
            ImageAttachmentsTabPage.TabIndex = 5;
            ImageAttachmentsTabPage.Text = "Image Attachments";
            // 
            // UploadImageButton
            // 
            UploadImageButton.Location = new Point(612, 266);
            UploadImageButton.Name = "UploadImageButton";
            UploadImageButton.Size = new Size(123, 50);
            UploadImageButton.TabIndex = 1;
            UploadImageButton.Text = "Upload Image";
            UploadImageButton.UseVisualStyleBackColor = true;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.BackColor = Color.Gainsboro;
            ProductPictureBox.Location = new Point(9, 6);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(540, 554);
            ProductPictureBox.TabIndex = 0;
            ProductPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(ProductNamelabel);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(RaDStatuslabel);
            panel1.Controls.Add(ProductNumberlabel);
            panel1.Controls.Add(Requirementlabel);
            panel1.Controls.Add(cmbProject);
            panel1.Controls.Add(txtProductCode);
            panel1.Controls.Add(txtMOQ);
            panel1.Controls.Add(Projectlabel);
            panel1.Controls.Add(Statuslabel);
            panel1.Controls.Add(MOQlabel);
            panel1.Location = new Point(352, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 142);
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
            cmbStatus.Items.AddRange(new object[] { "Under Development", "In Mass Production", "Discontinued" });
            cmbStatus.Location = new Point(9, 97);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(168, 23);
            cmbStatus.TabIndex = 54;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // RaDStatuslabel
            // 
            RaDStatuslabel.AutoSize = true;
            RaDStatuslabel.Location = new Point(335, 197);
            RaDStatuslabel.Name = "RaDStatuslabel";
            RaDStatuslabel.Size = new Size(0, 15);
            RaDStatuslabel.TabIndex = 5;
            // 
            // ProductNumberlabel
            // 
            ProductNumberlabel.AutoSize = true;
            ProductNumberlabel.Location = new Point(275, 12);
            ProductNumberlabel.Name = "ProductNumberlabel";
            ProductNumberlabel.Size = new Size(101, 15);
            ProductNumberlabel.TabIndex = 55;
            ProductNumberlabel.Text = "Product Number";
            // 
            // Requirementlabel
            // 
            Requirementlabel.AutoSize = true;
            Requirementlabel.Location = new Point(256, 192);
            Requirementlabel.Name = "Requirementlabel";
            Requirementlabel.Size = new Size(0, 15);
            Requirementlabel.TabIndex = 3;
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Items.AddRange(new object[] { "Tailor-made", "Ready-made" });
            cmbProject.Location = new Point(275, 97);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(157, 23);
            cmbProject.TabIndex = 61;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(275, 33);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(131, 23);
            txtProductCode.TabIndex = 56;
            // 
            // txtMOQ
            // 
            txtMOQ.Location = new Point(514, 33);
            txtMOQ.Name = "txtMOQ";
            txtMOQ.Size = new Size(97, 23);
            txtMOQ.TabIndex = 58;
            // 
            // Projectlabel
            // 
            Projectlabel.AutoSize = true;
            Projectlabel.Location = new Point(275, 75);
            Projectlabel.Name = "Projectlabel";
            Projectlabel.Size = new Size(46, 15);
            Projectlabel.TabIndex = 60;
            Projectlabel.Text = "Project";
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Location = new Point(13, 75);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(41, 15);
            Statuslabel.TabIndex = 59;
            Statuslabel.Text = "Status";
            // 
            // MOQlabel
            // 
            MOQlabel.AutoSize = true;
            MOQlabel.Location = new Point(514, 12);
            MOQlabel.Name = "MOQlabel";
            MOQlabel.Size = new Size(39, 15);
            MOQlabel.TabIndex = 57;
            MOQlabel.Text = "MOQ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1047, 804);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 42);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(111, 39);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 63;
            label2.Text = "Department :";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(202, 39);
            label31.Name = "label31";
            label31.Size = new Size(49, 15);
            label31.TabIndex = 65;
            label31.Text = "label31";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(202, 12);
            label30.Name = "label30";
            label30.Size = new Size(49, 15);
            label30.TabIndex = 64;
            label30.Text = "label30";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1028, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(57, 38);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // RnD_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1153, 858);
            Controls.Add(btnLogout);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(tabProductDetail);
            Controls.Add(NewProductsButton);
            Controls.Add(dgvProductList);
            Controls.Add(UserNamelabel);
            Controls.Add(btnUserProfile);
            Controls.Add(pictureBox1);
            Name = "RnD_Form";
            Text = "RnD_Form";
            Load += RaD_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            tabProductDetail.ResumeLayout(false);
            ProductSpecificationsTabPage.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnUserProfile;
        private Label UserNamelabel;
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
        private Panel panel1;
        private Label RaDStatuslabel;
        private Label Requirementlabel;
        private DataGridView dgvMaterials;
        private DataGridView dgvManufacturing;
        private TextBox txtPackLabel;
        private TextBox txtPackMaterial;
        private TextBox txtPackDimensions;
        private Label Label_Warninglabel;
        private Label PackMateriallabel;
        private Label PackDimensionslabel;
        private DataGridView dgvTesting;
        private Button AddedTestsButton;
        private Button NewCertificationButton;
        private DataGridView dataGridView1;
        private Button UploadImageButton;
        private PictureBox ProductPictureBox;
        private Button btnSave;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private TextBox SizeTextBox;
        private Label label7;
        private Label label6;
        private TextBox ColorTextBox;
        private TextBox WarrantySupportTextBox;
        private TextBox UserGuideTextBox;
        private TextBox ComplianceStandardsTextBox;
        private TextBox FunctionalDescriptionTextBox;
        private Label label31;
        private Label label30;
        private Button btnLogout;
        private Button btn_Add;
        private Button btn_Save;
        private Button btn_Add1;
        private Button btn_Save2;
    }
}