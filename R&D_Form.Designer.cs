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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SearchBox = new TextBox();
            SearchButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ProductNameBox = new TextBox();
            ColorSchemeBox = new TextBox();
            DesignDimenstionsBox = new TextBox();
            ProductionTimeFrameBox = new TextBox();
            PrototypeImageBox = new TextBox();
            MOQBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            button2 = new Button();
            listBox1 = new ListBox();
            OverviewSaveButton = new Button();
            OverviewButton = new Button();
            DesignMaterialsButton = new Button();
            ProductionStepsButton = new Button();
            EquipmentNeededButton = new Button();
            LabelRequirementsButton = new Button();
            QualityStandardButton = new Button();
            TestingProedusesButton = new Button();
            RequlatoryComplianceButton = new Button();
            UserInstructionsButton = new Button();
            WarrantySupportButton = new Button();
            label20 = new Label();
            UserName = new Label();
            Department = new Label();
            SubmitButton = new Button();
            ResetButton = new Button();
            DeleteProductBox = new CheckBox();
            ProductCodeDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 354);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Add Product";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(118, 354);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(95, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Edit Product";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(12, 102);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(220, 23);
            SearchBox.TabIndex = 7;
            SearchBox.TextChanged += textBox1_TextChanged;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(238, 103);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 8;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 9;
            label2.Text = "Product Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 10;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 11;
            label4.Text = "Color Scheme";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 12;
            label5.Text = "Design Dimenstions";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 255);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 13;
            label6.Text = "Production TimeFrame";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 285);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 14;
            label7.Text = "Prototype Image";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 314);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 15;
            label8.Text = "MOQ";
            // 
            // ProductNameBox
            // 
            ProductNameBox.Location = new Point(153, 164);
            ProductNameBox.Name = "ProductNameBox";
            ProductNameBox.Size = new Size(113, 23);
            ProductNameBox.TabIndex = 16;
            ProductNameBox.TextChanged += ProductNameBox_TextChanged;
            // 
            // ColorSchemeBox
            // 
            ColorSchemeBox.Location = new Point(153, 194);
            ColorSchemeBox.Name = "ColorSchemeBox";
            ColorSchemeBox.Size = new Size(113, 23);
            ColorSchemeBox.TabIndex = 17;
            // 
            // DesignDimenstionsBox
            // 
            DesignDimenstionsBox.Location = new Point(153, 223);
            DesignDimenstionsBox.Name = "DesignDimenstionsBox";
            DesignDimenstionsBox.Size = new Size(113, 23);
            DesignDimenstionsBox.TabIndex = 18;
            // 
            // ProductionTimeFrameBox
            // 
            ProductionTimeFrameBox.Location = new Point(153, 252);
            ProductionTimeFrameBox.Name = "ProductionTimeFrameBox";
            ProductionTimeFrameBox.Size = new Size(113, 23);
            ProductionTimeFrameBox.TabIndex = 19;
            ProductionTimeFrameBox.TextChanged += textBox5_TextChanged;
            // 
            // PrototypeImageBox
            // 
            PrototypeImageBox.Location = new Point(153, 282);
            PrototypeImageBox.Name = "PrototypeImageBox";
            PrototypeImageBox.Size = new Size(113, 23);
            PrototypeImageBox.TabIndex = 20;
            // 
            // MOQBox
            // 
            MOQBox.Location = new Point(153, 311);
            MOQBox.Name = "MOQBox";
            MOQBox.Size = new Size(113, 23);
            MOQBox.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(322, 139);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 22;
            label9.Text = "Overview";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(322, 167);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 23;
            label10.Text = "Design Materials";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(322, 197);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 24;
            label11.Text = "Production Steps";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(322, 226);
            label12.Name = "label12";
            label12.Size = new Size(119, 15);
            label12.TabIndex = 25;
            label12.Text = "Equipment Needed";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(322, 255);
            label13.Name = "label13";
            label13.Size = new Size(119, 15);
            label13.TabIndex = 26;
            label13.Text = "Label Requirements";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(321, 285);
            label14.Name = "label14";
            label14.Size = new Size(102, 15);
            label14.TabIndex = 27;
            label14.Text = "Quality Standard";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(322, 314);
            label15.Name = "label15";
            label15.Size = new Size(109, 15);
            label15.TabIndex = 28;
            label15.Text = "Testing Proeduses";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(322, 342);
            label16.Name = "label16";
            label16.Size = new Size(140, 15);
            label16.TabIndex = 29;
            label16.Text = "Requlatory Compliance";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(322, 373);
            label17.Name = "label17";
            label17.Size = new Size(98, 15);
            label17.TabIndex = 30;
            label17.Text = "User Instructions";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(322, 404);
            label18.Name = "label18";
            label18.Size = new Size(107, 15);
            label18.TabIndex = 31;
            label18.Text = "Warranty Support";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(553, 111);
            label19.Name = "label19";
            label19.Size = new Size(59, 15);
            label19.TabIndex = 32;
            label19.Text = "Overview";
            label19.Click += label19_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button2.Location = new Point(730, 12);
            button2.Name = "button2";
            button2.Size = new Size(59, 38);
            button2.TabIndex = 33;
            button2.Text = "User Prifile";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(555, 133);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 274);
            listBox1.TabIndex = 34;
            // 
            // OverviewSaveButton
            // 
            OverviewSaveButton.Location = new Point(730, 413);
            OverviewSaveButton.Name = "OverviewSaveButton";
            OverviewSaveButton.Size = new Size(59, 24);
            OverviewSaveButton.TabIndex = 35;
            OverviewSaveButton.Text = "Save";
            OverviewSaveButton.UseVisualStyleBackColor = true;
            // 
            // OverviewButton
            // 
            OverviewButton.BackgroundImageLayout = ImageLayout.None;
            OverviewButton.FlatStyle = FlatStyle.System;
            OverviewButton.Location = new Point(460, 133);
            OverviewButton.Name = "OverviewButton";
            OverviewButton.Size = new Size(87, 21);
            OverviewButton.TabIndex = 36;
            OverviewButton.Text = "Click to edit";
            OverviewButton.UseVisualStyleBackColor = true;
            // 
            // DesignMaterialsButton
            // 
            DesignMaterialsButton.ImageAlign = ContentAlignment.MiddleLeft;
            DesignMaterialsButton.Location = new Point(460, 160);
            DesignMaterialsButton.Name = "DesignMaterialsButton";
            DesignMaterialsButton.Size = new Size(87, 21);
            DesignMaterialsButton.TabIndex = 37;
            DesignMaterialsButton.Text = "Click to edit";
            DesignMaterialsButton.UseVisualStyleBackColor = true;
            // 
            // ProductionStepsButton
            // 
            ProductionStepsButton.Location = new Point(460, 191);
            ProductionStepsButton.Name = "ProductionStepsButton";
            ProductionStepsButton.Size = new Size(89, 21);
            ProductionStepsButton.TabIndex = 38;
            ProductionStepsButton.Text = "Click to edit";
            ProductionStepsButton.UseVisualStyleBackColor = true;
            // 
            // EquipmentNeededButton
            // 
            EquipmentNeededButton.Location = new Point(460, 223);
            EquipmentNeededButton.Name = "EquipmentNeededButton";
            EquipmentNeededButton.Size = new Size(87, 21);
            EquipmentNeededButton.TabIndex = 39;
            EquipmentNeededButton.Text = "Click to edit";
            EquipmentNeededButton.UseVisualStyleBackColor = true;
            // 
            // LabelRequirementsButton
            // 
            LabelRequirementsButton.Location = new Point(460, 252);
            LabelRequirementsButton.Name = "LabelRequirementsButton";
            LabelRequirementsButton.Size = new Size(87, 21);
            LabelRequirementsButton.TabIndex = 40;
            LabelRequirementsButton.Text = "Click to edit";
            LabelRequirementsButton.UseVisualStyleBackColor = true;
            // 
            // QualityStandardButton
            // 
            QualityStandardButton.Location = new Point(460, 279);
            QualityStandardButton.Name = "QualityStandardButton";
            QualityStandardButton.Size = new Size(87, 21);
            QualityStandardButton.TabIndex = 41;
            QualityStandardButton.Text = "Click to edit";
            QualityStandardButton.UseVisualStyleBackColor = true;
            // 
            // TestingProedusesButton
            // 
            TestingProedusesButton.Location = new Point(460, 308);
            TestingProedusesButton.Name = "TestingProedusesButton";
            TestingProedusesButton.Size = new Size(87, 21);
            TestingProedusesButton.TabIndex = 42;
            TestingProedusesButton.Text = "Click to edit";
            TestingProedusesButton.UseVisualStyleBackColor = true;
            // 
            // RequlatoryComplianceButton
            // 
            RequlatoryComplianceButton.Location = new Point(460, 338);
            RequlatoryComplianceButton.Name = "RequlatoryComplianceButton";
            RequlatoryComplianceButton.Size = new Size(87, 21);
            RequlatoryComplianceButton.TabIndex = 43;
            RequlatoryComplianceButton.Text = "Click to edit";
            RequlatoryComplianceButton.UseVisualStyleBackColor = true;
            // 
            // UserInstructionsButton
            // 
            UserInstructionsButton.Location = new Point(460, 370);
            UserInstructionsButton.Name = "UserInstructionsButton";
            UserInstructionsButton.Size = new Size(87, 21);
            UserInstructionsButton.TabIndex = 44;
            UserInstructionsButton.Text = "Click to edit";
            UserInstructionsButton.UseVisualStyleBackColor = true;
            // 
            // WarrantySupportButton
            // 
            WarrantySupportButton.Location = new Point(460, 398);
            WarrantySupportButton.Name = "WarrantySupportButton";
            WarrantySupportButton.Size = new Size(87, 21);
            WarrantySupportButton.TabIndex = 45;
            WarrantySupportButton.Text = "Click to edit";
            WarrantySupportButton.UseVisualStyleBackColor = true;
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
            // SubmitButton
            // 
            SubmitButton.Location = new Point(12, 404);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 25);
            SubmitButton.TabIndex = 49;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(93, 404);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 25);
            ResetButton.TabIndex = 50;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // DeleteProductBox
            // 
            DeleteProductBox.AutoSize = true;
            DeleteProductBox.Location = new Point(15, 379);
            DeleteProductBox.Name = "DeleteProductBox";
            DeleteProductBox.Size = new Size(110, 19);
            DeleteProductBox.TabIndex = 51;
            DeleteProductBox.Text = "Delete Product";
            DeleteProductBox.UseVisualStyleBackColor = true;
            DeleteProductBox.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // ProductCodeDisplay
            // 
            ProductCodeDisplay.AutoSize = true;
            ProductCodeDisplay.Location = new Point(153, 139);
            ProductCodeDisplay.Name = "ProductCodeDisplay";
            ProductCodeDisplay.Size = new Size(0, 15);
            ProductCodeDisplay.TabIndex = 52;
            // 
            // RaD_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(799, 651);
            Controls.Add(ProductCodeDisplay);
            Controls.Add(DeleteProductBox);
            Controls.Add(ResetButton);
            Controls.Add(SubmitButton);
            Controls.Add(Department);
            Controls.Add(UserName);
            Controls.Add(label20);
            Controls.Add(WarrantySupportButton);
            Controls.Add(UserInstructionsButton);
            Controls.Add(RequlatoryComplianceButton);
            Controls.Add(TestingProedusesButton);
            Controls.Add(QualityStandardButton);
            Controls.Add(LabelRequirementsButton);
            Controls.Add(EquipmentNeededButton);
            Controls.Add(ProductionStepsButton);
            Controls.Add(DesignMaterialsButton);
            Controls.Add(OverviewButton);
            Controls.Add(OverviewSaveButton);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(MOQBox);
            Controls.Add(PrototypeImageBox);
            Controls.Add(ProductionTimeFrameBox);
            Controls.Add(DesignDimenstionsBox);
            Controls.Add(ColorSchemeBox);
            Controls.Add(ProductNameBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SearchButton);
            Controls.Add(SearchBox);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "RaD_Form";
            Text = "R&D_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox SearchBox;
        private Button SearchButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox ProductNameBox;
        private TextBox ColorSchemeBox;
        private TextBox DesignDimenstionsBox;
        private TextBox ProductionTimeFrameBox;
        private TextBox PrototypeImageBox;
        private TextBox MOQBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button2;
        private ListBox listBox1;
        private Button OverviewSaveButton;
        private Button OverviewButton;
        private Button DesignMaterialsButton;
        private Button ProductionStepsButton;
        private Button EquipmentNeededButton;
        private Button LabelRequirementsButton;
        private Button QualityStandardButton;
        private Button TestingProedusesButton;
        private Button RequlatoryComplianceButton;
        private Button UserInstructionsButton;
        private Button WarrantySupportButton;
        private Label label20;
        private Label UserName;
        private Label Department;
        private Button SubmitButton;
        private Button ResetButton;
        private CheckBox DeleteProductBox;
        private Label ProductCodeDisplay;
    }
}