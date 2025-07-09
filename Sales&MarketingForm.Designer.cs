using System.Windows.Forms;

namespace C_Project
{
    partial class Sales_MarketingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_MarketingForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            UserName = new Label();
            label2 = new Label();
            Department = new Label();
            btnUserProfile = new Button();
            tabControl = new TabControl();
            QuotationTabPage = new TabPage();
            splitContainer1 = new SplitContainer();
            dgvQuoteList = new DataGridView();
            btn_quoAdd = new Button();
            label4 = new Label();
            NotesOrtermsTextBox = new TextBox();
            label20 = new Label();
            DiscountsOrOffersTextBox = new TextBox();
            label19 = new Label();
            PaymentTermsTextBox = new TextBox();
            label18 = new Label();
            TransportationMethodTextBox = new TextBox();
            label17 = new Label();
            DeliveryTimeTextBox = new TextBox();
            label16 = new Label();
            btn_quoSave = new Button();
            GenPDFButton = new Button();
            NewProductsButton = new Button();
            label11 = new Label();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            TelephoneTextBox = new TextBox();
            label10 = new Label();
            ContactPersonTextBox = new TextBox();
            label9 = new Label();
            AddressTextBox = new TextBox();
            label8 = new Label();
            CustomerNameTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            QuoteNumberTextBox = new TextBox();
            label5 = new Label();
            ProductionorderTabPage = new TabPage();
            splitContainer2 = new SplitContainer();
            btn_POadd = new Button();
            label3 = new Label();
            dgvProdOrderList = new DataGridView();
            poList = new DataGridView();
            label29 = new Label();
            materialSpec = new TextBox();
            materialChoose = new ComboBox();
            materialText = new Label();
            materialQtyText = new Label();
            materialQty = new TextBox();
            btnPOsave = new Button();
            label23 = new Label();
            dataGridView3 = new DataGridView();
            groupBox2 = new GroupBox();
            productIdText = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            PoQtyText = new TextBox();
            NotesOrInstructionsTextBox = new TextBox();
            ReferenceQuoteTextBox = new TextBox();
            label22 = new Label();
            label27 = new Label();
            label21 = new Label();
            label25 = new Label();
            label15 = new Label();
            label14 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label13 = new Label();
            OrderNoTextBox = new TextBox();
            label12 = new Label();
            NewMaterialsButton = new Button();
            label31 = new Label();
            label30 = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl.SuspendLayout();
            QuotationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuoteList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ProductionorderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdOrderList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)poList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 12);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "User Name :";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(177, 12);
            UserName.Name = "UserName";
            UserName.Size = new Size(0, 15);
            UserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 39);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Department :";
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Location = new Point(186, 38);
            Department.Name = "Department";
            Department.Size = new Size(0, 15);
            Department.TabIndex = 4;
            // 
            // btnUserProfile
            // 
            btnUserProfile.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnUserProfile.Location = new Point(1091, 12);
            btnUserProfile.Name = "btnUserProfile";
            btnUserProfile.Size = new Size(59, 38);
            btnUserProfile.TabIndex = 34;
            btnUserProfile.Text = "User Profile";
            btnUserProfile.UseVisualStyleBackColor = true;
            btnUserProfile.Click += btnUserProfile_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(QuotationTabPage);
            tabControl.Controls.Add(ProductionorderTabPage);
            tabControl.Location = new Point(3, 118);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1138, 736);
            tabControl.TabIndex = 35;
            // 
            // QuotationTabPage
            // 
            QuotationTabPage.Controls.Add(splitContainer1);
            QuotationTabPage.Location = new Point(4, 24);
            QuotationTabPage.Name = "QuotationTabPage";
            QuotationTabPage.Padding = new Padding(3);
            QuotationTabPage.Size = new Size(1130, 708);
            QuotationTabPage.TabIndex = 0;
            QuotationTabPage.Text = "Quotation";
            QuotationTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvQuoteList);
            splitContainer1.Panel1.Controls.Add(btn_quoAdd);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(NotesOrtermsTextBox);
            splitContainer1.Panel2.Controls.Add(label20);
            splitContainer1.Panel2.Controls.Add(DiscountsOrOffersTextBox);
            splitContainer1.Panel2.Controls.Add(label19);
            splitContainer1.Panel2.Controls.Add(PaymentTermsTextBox);
            splitContainer1.Panel2.Controls.Add(label18);
            splitContainer1.Panel2.Controls.Add(TransportationMethodTextBox);
            splitContainer1.Panel2.Controls.Add(label17);
            splitContainer1.Panel2.Controls.Add(DeliveryTimeTextBox);
            splitContainer1.Panel2.Controls.Add(label16);
            splitContainer1.Panel2.Controls.Add(btn_quoSave);
            splitContainer1.Panel2.Controls.Add(GenPDFButton);
            splitContainer1.Panel2.Controls.Add(NewProductsButton);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1124, 702);
            splitContainer1.SplitterDistance = 372;
            splitContainer1.TabIndex = 0;
            // 
            // dgvQuoteList
            // 
            dgvQuoteList.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvQuoteList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuoteList.Location = new Point(4, 54);
            dgvQuoteList.Name = "dgvQuoteList";
            dgvQuoteList.ReadOnly = true;
            dgvQuoteList.Size = new Size(365, 645);
            dgvQuoteList.TabIndex = 2;
            dgvQuoteList.CellClick += dgvQuoteList_CellClick;
            dgvQuoteList.CellContentClick += dgvQuoteList_CellContentClick;
            // 
            // btn_quoAdd
            // 
            btn_quoAdd.Location = new Point(4, 25);
            btn_quoAdd.Name = "btn_quoAdd";
            btn_quoAdd.Size = new Size(85, 23);
            btn_quoAdd.TabIndex = 1;
            btn_quoAdd.Text = "Add";
            btn_quoAdd.UseVisualStyleBackColor = true;
            btn_quoAdd.Click += btn_quoAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 7);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 3;
            label4.Text = "Quotation Overview";
            // 
            // NotesOrtermsTextBox
            // 
            NotesOrtermsTextBox.Location = new Point(102, 523);
            NotesOrtermsTextBox.Name = "NotesOrtermsTextBox";
            NotesOrtermsTextBox.Size = new Size(119, 23);
            NotesOrtermsTextBox.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(11, 526);
            label20.Name = "label20";
            label20.Size = new Size(85, 15);
            label20.TabIndex = 16;
            label20.Text = "Special Offers";
            label20.Click += label20_Click;
            // 
            // DiscountsOrOffersTextBox
            // 
            DiscountsOrOffersTextBox.Location = new Point(414, 484);
            DiscountsOrOffersTextBox.Name = "DiscountsOrOffersTextBox";
            DiscountsOrOffersTextBox.Size = new Size(141, 23);
            DiscountsOrOffersTextBox.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(347, 487);
            label19.Name = "label19";
            label19.Size = new Size(61, 15);
            label19.TabIndex = 14;
            label19.Text = "Discounts";
            // 
            // PaymentTermsTextBox
            // 
            PaymentTermsTextBox.Location = new Point(103, 484);
            PaymentTermsTextBox.Name = "PaymentTermsTextBox";
            PaymentTermsTextBox.Size = new Size(119, 23);
            PaymentTermsTextBox.TabIndex = 13;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 487);
            label18.Name = "label18";
            label18.Size = new Size(90, 15);
            label18.TabIndex = 12;
            label18.Text = "Payment terms";
            // 
            // TransportationMethodTextBox
            // 
            TransportationMethodTextBox.Location = new Point(414, 449);
            TransportationMethodTextBox.Name = "TransportationMethodTextBox";
            TransportationMethodTextBox.Size = new Size(141, 23);
            TransportationMethodTextBox.TabIndex = 11;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(270, 452);
            label17.Name = "label17";
            label17.Size = new Size(138, 15);
            label17.TabIndex = 10;
            label17.Text = "Transportation method";
            // 
            // DeliveryTimeTextBox
            // 
            DeliveryTimeTextBox.Location = new Point(103, 449);
            DeliveryTimeTextBox.Name = "DeliveryTimeTextBox";
            DeliveryTimeTextBox.Size = new Size(119, 23);
            DeliveryTimeTextBox.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 452);
            label16.Name = "label16";
            label16.Size = new Size(80, 15);
            label16.TabIndex = 8;
            label16.Text = "Delivery time";
            // 
            // btn_quoSave
            // 
            btn_quoSave.Location = new Point(648, 663);
            btn_quoSave.Name = "btn_quoSave";
            btn_quoSave.Size = new Size(97, 36);
            btn_quoSave.TabIndex = 6;
            btn_quoSave.Text = "Save";
            btn_quoSave.UseVisualStyleBackColor = true;
            btn_quoSave.Click += btn_quoSave_Click;
            // 
            // GenPDFButton
            // 
            GenPDFButton.Location = new Point(8, 560);
            GenPDFButton.Name = "GenPDFButton";
            GenPDFButton.Size = new Size(90, 23);
            GenPDFButton.TabIndex = 4;
            GenPDFButton.Text = "Gen to PDF";
            GenPDFButton.UseVisualStyleBackColor = true;
            GenPDFButton.Click += genPDF_Click;
            // 
            // NewProductsButton
            // 
            NewProductsButton.Location = new Point(8, 414);
            NewProductsButton.Name = "NewProductsButton";
            NewProductsButton.Size = new Size(118, 23);
            NewProductsButton.TabIndex = 3;
            NewProductsButton.Text = "＋New products";
            NewProductsButton.UseVisualStyleBackColor = true;
            NewProductsButton.Click += NewProductsButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 193);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 2;
            label11.Text = "Product Details";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 212);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(734, 196);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TelephoneTextBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(ContactPersonTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(AddressTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(CustomerNameTextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(QuoteNumberTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(6, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(734, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // TelephoneTextBox
            // 
            TelephoneTextBox.Location = new Point(449, 91);
            TelephoneTextBox.Name = "TelephoneTextBox";
            TelephoneTextBox.Size = new Size(152, 23);
            TelephoneTextBox.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(375, 92);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 10;
            label10.Text = "Telephone";
            // 
            // ContactPersonTextBox
            // 
            ContactPersonTextBox.Location = new Point(159, 89);
            ContactPersonTextBox.Name = "ContactPersonTextBox";
            ContactPersonTextBox.Size = new Size(145, 23);
            ContactPersonTextBox.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 92);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 8;
            label9.Text = "Contact Person";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(449, 58);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(152, 23);
            AddressTextBox.TabIndex = 7;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(384, 59);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 6;
            label8.Text = "Address";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(160, 56);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(144, 23);
            CustomerNameTextBox.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImageAlign = ContentAlignment.BottomLeft;
            label7.Location = new Point(57, 59);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 4;
            label7.Text = "Customer Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 29);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 3;
            label6.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(449, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // QuoteNumberTextBox
            // 
            QuoteNumberTextBox.Enabled = false;
            QuoteNumberTextBox.Location = new Point(161, 22);
            QuoteNumberTextBox.Name = "QuoteNumberTextBox";
            QuoteNumberTextBox.ReadOnly = true;
            QuoteNumberTextBox.Size = new Size(143, 23);
            QuoteNumberTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 29);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 0;
            label5.Text = "Quotation Number";
            label5.Click += label5_Click;
            // 
            // ProductionorderTabPage
            // 
            ProductionorderTabPage.Controls.Add(splitContainer2);
            ProductionorderTabPage.Location = new Point(4, 24);
            ProductionorderTabPage.Name = "ProductionorderTabPage";
            ProductionorderTabPage.Padding = new Padding(3);
            ProductionorderTabPage.Size = new Size(1130, 708);
            ProductionorderTabPage.TabIndex = 1;
            ProductionorderTabPage.Text = "Production order";
            ProductionorderTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btn_POadd);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(dgvProdOrderList);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(poList);
            splitContainer2.Panel2.Controls.Add(label29);
            splitContainer2.Panel2.Controls.Add(materialSpec);
            splitContainer2.Panel2.Controls.Add(materialChoose);
            splitContainer2.Panel2.Controls.Add(materialText);
            splitContainer2.Panel2.Controls.Add(materialQtyText);
            splitContainer2.Panel2.Controls.Add(materialQty);
            splitContainer2.Panel2.Controls.Add(btnPOsave);
            splitContainer2.Panel2.Controls.Add(label23);
            splitContainer2.Panel2.Controls.Add(dataGridView3);
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Panel2.Controls.Add(NewMaterialsButton);
            splitContainer2.Size = new Size(1124, 702);
            splitContainer2.SplitterDistance = 213;
            splitContainer2.TabIndex = 0;
            // 
            // btn_POadd
            // 
            btn_POadd.Location = new Point(4, 25);
            btn_POadd.Name = "btn_POadd";
            btn_POadd.Size = new Size(85, 23);
            btn_POadd.TabIndex = 4;
            btn_POadd.Text = "Add";
            btn_POadd.UseVisualStyleBackColor = true;
            btn_POadd.Click += btn_POadd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 7);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 0;
            label3.Text = "Production Order Overview";
            // 
            // dgvProdOrderList
            // 
            dgvProdOrderList.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvProdOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdOrderList.EnableHeadersVisualStyles = false;
            dgvProdOrderList.Location = new Point(4, 54);
            dgvProdOrderList.MultiSelect = false;
            dgvProdOrderList.Name = "dgvProdOrderList";
            dgvProdOrderList.ReadOnly = true;
            dgvProdOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdOrderList.Size = new Size(206, 645);
            dgvProdOrderList.TabIndex = 5;
            // 
            // poList
            // 
            poList.BackgroundColor = SystemColors.GradientInactiveCaption;
            poList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            poList.Location = new Point(11, 495);
            poList.Name = "poList";
            poList.Size = new Size(885, 162);
            poList.TabIndex = 8;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(11, 321);
            label29.Name = "label29";
            label29.Size = new Size(35, 15);
            label29.TabIndex = 15;
            label29.Text = "Spec";
            // 
            // materialSpec
            // 
            materialSpec.Location = new Point(11, 339);
            materialSpec.Multiline = true;
            materialSpec.Name = "materialSpec";
            materialSpec.ReadOnly = true;
            materialSpec.Size = new Size(293, 104);
            materialSpec.TabIndex = 14;
            // 
            // materialChoose
            // 
            materialChoose.FormattingEnabled = true;
            //materialChoose.Items.AddRange(new object[] { "Polyethylene", "Polypropylene", "ABS", "Stainless Steel", "Aluminum", "Copper", "Cotton", "Polyester", "Nylon", "Fiberglass", "Carbon Fiber", "Oak", "Pine", "Plywood", "Tempered Glass", "Laminated Glass" });
            materialChoose.Location = new Point(11, 230);
            materialChoose.Name = "materialChoose";
            materialChoose.Size = new Size(293, 23);
            materialChoose.TabIndex = 13;
            materialChoose.SelectedIndexChanged += materialChoose_SelectedIndexChanged;
            // 
            // materialText
            // 
            materialText.AutoSize = true;
            materialText.Location = new Point(11, 212);
            materialText.Name = "materialText";
            materialText.Size = new Size(54, 15);
            materialText.TabIndex = 12;
            materialText.Text = "Material";
            // 
            // materialQtyText
            // 
            materialQtyText.AutoSize = true;
            materialQtyText.Location = new Point(11, 263);
            materialQtyText.Name = "materialQtyText";
            materialQtyText.Size = new Size(105, 15);
            materialQtyText.TabIndex = 11;
            materialQtyText.Text = "Material Quantity";
            // 
            // materialQty
            // 
            materialQty.Location = new Point(11, 281);
            materialQty.Name = "materialQty";
            materialQty.Size = new Size(293, 23);
            materialQty.TabIndex = 10;
            // 
            // btnPOsave
            // 
            btnPOsave.Location = new Point(799, 663);
            btnPOsave.Name = "btnPOsave";
            btnPOsave.Size = new Size(97, 36);
            btnPOsave.TabIndex = 9;
            btnPOsave.Text = "Save";
            btnPOsave.UseVisualStyleBackColor = true;
            btnPOsave.Click += btnPOsave_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(320, 212);
            label23.Name = "label23";
            label23.Size = new Size(135, 15);
            label23.TabIndex = 2;
            label23.Text = "Material Requirements";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(320, 238);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(576, 205);
            dataGridView3.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(productIdText);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(dateTimePicker4);
            groupBox2.Controls.Add(PoQtyText);
            groupBox2.Controls.Add(NotesOrInstructionsTextBox);
            groupBox2.Controls.Add(ReferenceQuoteTextBox);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label27);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(OrderNoTextBox);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(13, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(883, 186);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // productIdText
            // 
            productIdText.Location = new Point(106, 73);
            productIdText.Name = "productIdText";
            productIdText.Size = new Size(123, 23);
            productIdText.TabIndex = 13;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(752, 22);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(115, 23);
            dateTimePicker3.TabIndex = 6;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(752, 70);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(115, 23);
            dateTimePicker4.TabIndex = 7;
            // 
            // PoQtyText
            // 
            PoQtyText.Location = new Point(106, 124);
            PoQtyText.Name = "PoQtyText";
            PoQtyText.Size = new Size(123, 23);
            PoQtyText.TabIndex = 12;
            // 
            // NotesOrInstructionsTextBox
            // 
            NotesOrInstructionsTextBox.Location = new Point(432, 124);
            NotesOrInstructionsTextBox.Multiline = true;
            NotesOrInstructionsTextBox.Name = "NotesOrInstructionsTextBox";
            NotesOrInstructionsTextBox.Size = new Size(435, 41);
            NotesOrInstructionsTextBox.TabIndex = 11;
            // 
            // ReferenceQuoteTextBox
            // 
            ReferenceQuoteTextBox.Location = new Point(432, 74);
            ReferenceQuoteTextBox.Name = "ReferenceQuoteTextBox";
            ReferenceQuoteTextBox.Size = new Size(111, 23);
            ReferenceQuoteTextBox.TabIndex = 9;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(315, 127);
            label22.Name = "label22";
            label22.Size = new Size(109, 15);
            label22.TabIndex = 10;
            label22.Text = "Notes/Instructions";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(625, 73);
            label27.Name = "label27";
            label27.Size = new Size(121, 15);
            label27.TabIndex = 2;
            label27.Text = "Expected End Date :";
            label27.Click += label27_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(315, 77);
            label21.Name = "label21";
            label21.Size = new Size(103, 15);
            label21.TabIndex = 8;
            label21.Text = "Reference Quote";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(621, 25);
            label25.Name = "label25";
            label25.Size = new Size(125, 15);
            label25.TabIndex = 0;
            label25.Text = "Expected Start Date :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 127);
            label15.Name = "label15";
            label15.Size = new Size(91, 15);
            label15.TabIndex = 6;
            label15.Text = "Order Quantity";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 76);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 4;
            label14.Text = "Product ID";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(432, 23);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(111, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(348, 26);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 2;
            label13.Text = "Order Date";
            // 
            // OrderNoTextBox
            // 
            OrderNoTextBox.Enabled = false;
            OrderNoTextBox.Location = new Point(106, 22);
            OrderNoTextBox.Name = "OrderNoTextBox";
            OrderNoTextBox.ReadOnly = true;
            OrderNoTextBox.Size = new Size(123, 23);
            OrderNoTextBox.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 25);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 0;
            label12.Text = "Order No.";
            // 
            // NewMaterialsButton
            // 
            NewMaterialsButton.Location = new Point(186, 449);
            NewMaterialsButton.Name = "NewMaterialsButton";
            NewMaterialsButton.Size = new Size(118, 25);
            NewMaterialsButton.TabIndex = 3;
            NewMaterialsButton.Text = "+ New Materials";
            NewMaterialsButton.UseVisualStyleBackColor = true;
            NewMaterialsButton.Click += NewMaterialsButton_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(202, 39);
            label31.Name = "label31";
            label31.Size = new Size(49, 15);
            label31.TabIndex = 37;
            label31.Text = "label31";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(202, 12);
            label30.Name = "label30";
            label30.Size = new Size(49, 15);
            label30.TabIndex = 36;
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
            // Sales_MarketingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1153, 858);
            Controls.Add(btnLogout);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(tabControl);
            Controls.Add(btnUserProfile);
            Controls.Add(Department);
            Controls.Add(label2);
            Controls.Add(UserName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Sales_MarketingForm";
            Text = "Sales_MarketingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl.ResumeLayout(false);
            QuotationTabPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuoteList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ProductionorderTabPage.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdOrderList).EndInit();
            ((System.ComponentModel.ISupportInitialize)poList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label UserName;
        private Label label2;
        private Label Department;
        private Button btnUserProfile;
        private TabControl tabControl;
        private TabPage QuotationTabPage;
        private SplitContainer splitContainer1;
        private TabPage ProductionorderTabPage;
        private SplitContainer splitContainer2;
        private DataGridView dgvQuoteList;
        private Button btn_quoAdd;
        private Label label3;
        private DataGridView dgvProdOrderList;
        private Button btn_POadd;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox AddressTextBox;
        private Label label8;
        private TextBox CustomerNameTextBox;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox QuoteNumberTextBox;
        private Label label5;
        private Label label10;
        private TextBox ContactPersonTextBox;
        private Label label9;
        private Label label11;
        private DataGridView dataGridView2;
        private TextBox TelephoneTextBox;
        private GroupBox groupBox2;
        private Label label14;
        private DateTimePicker dateTimePicker2;
        private Label label13;
        private TextBox OrderNoTextBox;
        private Label label12;
        private Label label15;
        private Label label16;
        private Button btn_quoSave;
        private Button GenPDFButton;
        private Button NewProductsButton;
        private Label label20;
        private TextBox DiscountsOrOffersTextBox;
        private Label label19;
        private TextBox PaymentTermsTextBox;
        private Label label18;
        private TextBox TransportationMethodTextBox;
        private Label label17;
        private TextBox DeliveryTimeTextBox;
        private TextBox NotesOrtermsTextBox;
        private DataGridView dataGridView3;
        private TextBox NotesOrInstructionsTextBox;
        private Label label22;
        private TextBox ReferenceQuoteTextBox;
        private Label label21;
        private Button NewMaterialsButton;
        private Label label23;
        private Button btnPOsave;
        private Label label27;
        private Label label25;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label31;
        private Label label30;
        private Button btnLogout;
        private TextBox PoQtyText;
        private TextBox productIdText;
        private Label label29;
        private TextBox materialSpec;
        private ComboBox materialChoose;
        private Label materialText;
        private Label materialQtyText;
        private TextBox materialQty;
        private DataGridView poList;
    }
}