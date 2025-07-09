using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace C_Project
{
    partial class LogisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogisticForm));
            dataGridView4 = new DataGridView();
            btn_Add6 = new TabControl();
            Inventory = new TabPage();
            MaterialBox = new ComboBox();
            RemarkBox = new TextBox();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label25 = new Label();
            label24 = new Label();
            WarehouseBox = new ComboBox();
            InOutCombo = new ComboBox();
            QuantityBox = new TextBox();
            btn_Add4 = new Button();
            btn_Save7 = new Button();
            lblRecord = new Label();
            Procurement = new TabPage();
            dataGridView1 = new DataGridView();
            comboBox3 = new ComboBox();
            label6 = new Label();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label1 = new Label();
            btn_Add5 = new Button();
            btn_Save3 = new Button();
            dataGridView5 = new DataGridView();
            InternalTransferOrder = new TabPage();
            dataGridView2 = new DataGridView();
            textBox6 = new TextBox();
            button1 = new Button();
            btn_Add7 = new Button();
            btn_Save2 = new Button();
            button10 = new Button();
            dateTimePicker3 = new DateTimePicker();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dataGridView6 = new DataGridView();
            label7 = new Label();
            DemandForecast = new TabPage();
            btn_Add8 = new Button();
            btn_Save1 = new Button();
            label14 = new Label();
            button12 = new Button();
            dataGridView7 = new DataGridView();
            Supplier = new TabPage();
            btn_Add = new Button();
            btn_Save = new Button();
            button15 = new Button();
            dataGridView8 = new DataGridView();
            label15 = new Label();
            label18 = new Label();
            label19 = new Label();
            button8 = new Button();
            label20 = new Label();
            label21 = new Label();
            pictureBox2 = new PictureBox();
            label30 = new Label();
            label31 = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            btn_Add6.SuspendLayout();
            Inventory.SuspendLayout();
            Procurement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            InternalTransferOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            DemandForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            Supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(8, 125);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 82;
            dataGridView4.Size = new Size(1037, 288);
            dataGridView4.TabIndex = 6;
            // 
            // btn_Add6
            // 
            btn_Add6.Controls.Add(Inventory);
            btn_Add6.Controls.Add(Procurement);
            btn_Add6.Controls.Add(InternalTransferOrder);
            btn_Add6.Controls.Add(DemandForecast);
            btn_Add6.Controls.Add(Supplier);
            btn_Add6.Location = new Point(12, 108);
            btn_Add6.Name = "btn_Add6";
            btn_Add6.SelectedIndex = 0;
            btn_Add6.Size = new Size(1129, 738);
            btn_Add6.TabIndex = 7;
            btn_Add6.Tag = "";
            // 
            // Inventory
            // 
            Inventory.Controls.Add(MaterialBox);
            Inventory.Controls.Add(RemarkBox);
            Inventory.Controls.Add(label29);
            Inventory.Controls.Add(label28);
            Inventory.Controls.Add(label27);
            Inventory.Controls.Add(label25);
            Inventory.Controls.Add(label24);
            Inventory.Controls.Add(WarehouseBox);
            Inventory.Controls.Add(InOutCombo);
            Inventory.Controls.Add(QuantityBox);
            Inventory.Controls.Add(btn_Add4);
            Inventory.Controls.Add(btn_Save7);
            Inventory.Controls.Add(lblRecord);
            Inventory.Controls.Add(dataGridView4);
            Inventory.Location = new Point(4, 24);
            Inventory.Name = "Inventory";
            Inventory.Padding = new Padding(3, 3, 3, 3);
            Inventory.Size = new Size(1121, 710);
            Inventory.TabIndex = 0;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += tabPage1_Click;
            // 
            // MaterialBox
            // 
            MaterialBox.FormattingEnabled = true;
            MaterialBox.Items.AddRange(new object[] { "M001", "M002", "M003", "M004" });
            MaterialBox.Location = new Point(135, 28);
            MaterialBox.Name = "MaterialBox";
            MaterialBox.Size = new Size(121, 23);
            MaterialBox.TabIndex = 45;
            // 
            // RemarkBox
            // 
            RemarkBox.Location = new Point(499, 28);
            RemarkBox.Name = "RemarkBox";
            RemarkBox.Size = new Size(359, 23);
            RemarkBox.TabIndex = 44;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(499, 10);
            label29.Name = "label29";
            label29.Size = new Size(50, 15);
            label29.TabIndex = 43;
            label29.Text = "Remark";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(368, 10);
            label28.Name = "label28";
            label28.Size = new Size(71, 15);
            label28.TabIndex = 40;
            label28.Text = "Warehouse";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(262, 10);
            label27.Name = "label27";
            label27.Size = new Size(55, 15);
            label27.TabIndex = 39;
            label27.Text = "Quantity";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(135, 10);
            label25.Name = "label25";
            label25.Size = new Size(54, 15);
            label25.TabIndex = 37;
            label25.Text = "Material";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(8, 10);
            label24.Name = "label24";
            label24.Size = new Size(56, 15);
            label24.TabIndex = 36;
            label24.Text = "In or Out";
            // 
            // WarehouseBox
            // 
            WarehouseBox.FormattingEnabled = true;
            WarehouseBox.Items.AddRange(new object[] { "Thailand ", "Hong Kong", "Vietnam", "Mainland China" });
            WarehouseBox.Location = new Point(368, 28);
            WarehouseBox.Name = "WarehouseBox";
            WarehouseBox.Size = new Size(121, 23);
            WarehouseBox.TabIndex = 35;
            // 
            // InOutCombo
            // 
            InOutCombo.FormattingEnabled = true;
            InOutCombo.Items.AddRange(new object[] { "In", "Out" });
            InOutCombo.Location = new Point(8, 28);
            InOutCombo.Name = "InOutCombo";
            InOutCombo.Size = new Size(121, 23);
            InOutCombo.TabIndex = 34;
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(262, 28);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(100, 23);
            QuantityBox.TabIndex = 33;
            // 
            // btn_Add4
            // 
            btn_Add4.Location = new Point(864, 28);
            btn_Add4.Name = "btn_Add4";
            btn_Add4.Size = new Size(75, 23);
            btn_Add4.TabIndex = 29;
            btn_Add4.Text = "Add";
            btn_Add4.UseVisualStyleBackColor = true;
            btn_Add4.Click += btn_Add4_Click;
            // 
            // btn_Save7
            // 
            btn_Save7.Location = new Point(1046, 125);
            btn_Save7.Name = "btn_Save7";
            btn_Save7.Size = new Size(75, 23);
            btn_Save7.TabIndex = 30;
            btn_Save7.Text = "Save";
            btn_Save7.UseVisualStyleBackColor = true;
            btn_Save7.Click += btn_Save7_Click;
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Location = new Point(8, 107);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(93, 15);
            lblRecord.TabIndex = 7;
            lblRecord.Text = "In / Out Record";
            // 
            // Procurement
            // 
            Procurement.Controls.Add(dataGridView1);
            Procurement.Controls.Add(comboBox3);
            Procurement.Controls.Add(label6);
            Procurement.Controls.Add(button2);
            Procurement.Controls.Add(label5);
            Procurement.Controls.Add(label4);
            Procurement.Controls.Add(label3);
            Procurement.Controls.Add(label2);
            Procurement.Controls.Add(comboBox1);
            Procurement.Controls.Add(dateTimePicker2);
            Procurement.Controls.Add(dateTimePicker1);
            Procurement.Controls.Add(textBox2);
            Procurement.Controls.Add(label1);
            Procurement.Controls.Add(btn_Add5);
            Procurement.Controls.Add(btn_Save3);
            Procurement.Controls.Add(dataGridView5);
            Procurement.Location = new Point(4, 24);
            Procurement.Name = "Procurement";
            Procurement.Padding = new Padding(3, 3, 3, 3);
            Procurement.Size = new Size(1121, 710);
            Procurement.TabIndex = 1;
            Procurement.Text = "Procurement";
            Procurement.UseVisualStyleBackColor = true;
            Procurement.Click += Procurement_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(773, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(172, 162);
            dataGridView1.TabIndex = 41;
            dataGridView1.SelectionChanged += OnDataGridView1_SelectionChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(135, 69);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 40;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 173);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 39;
            label6.Text = "Status";
            // 
            // button2
            // 
            button2.Location = new Point(317, 36);
            button2.Name = "button2";
            button2.Size = new Size(98, 23);
            button2.TabIndex = 38;
            button2.Text = "New Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 143);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 37;
            label5.Text = "Estimated Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 108);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 36;
            label4.Text = "Order Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 72);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 35;
            label3.Text = "Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 39);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 34;
            label2.Text = "Order No. :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ordered", "Shipping", "Complete" });
            comboBox1.Location = new Point(135, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 33;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(135, 137);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(135, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(821, 13);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 29;
            label1.Text = "Order History";
            // 
            // btn_Add5
            // 
            btn_Add5.Location = new Point(368, 169);
            btn_Add5.Name = "btn_Add5";
            btn_Add5.Size = new Size(75, 23);
            btn_Add5.TabIndex = 27;
            btn_Add5.Text = "Add";
            btn_Add5.UseVisualStyleBackColor = true;
            btn_Add5.Click += btn_Add5_Click_1;
            // 
            // btn_Save3
            // 
            btn_Save3.Location = new Point(1040, 237);
            btn_Save3.Name = "btn_Save3";
            btn_Save3.Size = new Size(75, 23);
            btn_Save3.TabIndex = 28;
            btn_Save3.Text = "Save";
            btn_Save3.UseVisualStyleBackColor = true;
            btn_Save3.Click += btn_Save3_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(6, 237);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 82;
            dataGridView5.Size = new Size(1028, 225);
            dataGridView5.TabIndex = 2;
            dataGridView5.CellContentClick += dataGridView5_CellContentClick;
            // 
            // InternalTransferOrder
            // 
            InternalTransferOrder.BackgroundImageLayout = ImageLayout.None;
            InternalTransferOrder.Controls.Add(dataGridView2);
            InternalTransferOrder.Controls.Add(textBox6);
            InternalTransferOrder.Controls.Add(button1);
            InternalTransferOrder.Controls.Add(btn_Add7);
            InternalTransferOrder.Controls.Add(btn_Save2);
            InternalTransferOrder.Controls.Add(button10);
            InternalTransferOrder.Controls.Add(dateTimePicker3);
            InternalTransferOrder.Controls.Add(comboBox4);
            InternalTransferOrder.Controls.Add(comboBox2);
            InternalTransferOrder.Controls.Add(textBox5);
            InternalTransferOrder.Controls.Add(textBox4);
            InternalTransferOrder.Controls.Add(textBox3);
            InternalTransferOrder.Controls.Add(label17);
            InternalTransferOrder.Controls.Add(label16);
            InternalTransferOrder.Controls.Add(label12);
            InternalTransferOrder.Controls.Add(label11);
            InternalTransferOrder.Controls.Add(label10);
            InternalTransferOrder.Controls.Add(label9);
            InternalTransferOrder.Controls.Add(label8);
            InternalTransferOrder.Controls.Add(dataGridView6);
            InternalTransferOrder.Controls.Add(label7);
            InternalTransferOrder.Location = new Point(4, 24);
            InternalTransferOrder.Name = "InternalTransferOrder";
            InternalTransferOrder.Padding = new Padding(3, 3, 3, 3);
            InternalTransferOrder.Size = new Size(1121, 710);
            InternalTransferOrder.TabIndex = 2;
            InternalTransferOrder.Text = "Internal Transfer Order";
            InternalTransferOrder.UseVisualStyleBackColor = true;
            InternalTransferOrder.Click += InternalTransferOrder_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(785, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(240, 238);
            dataGridView2.TabIndex = 53;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(132, 15);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(146, 23);
            textBox6.TabIndex = 52;
            // 
            // button1
            // 
            button1.Location = new Point(407, 191);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 51;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Add7
            // 
            btn_Add7.Location = new Point(1031, 294);
            btn_Add7.Name = "btn_Add7";
            btn_Add7.Size = new Size(75, 23);
            btn_Add7.TabIndex = 49;
            btn_Add7.Text = "Add";
            btn_Add7.UseVisualStyleBackColor = true;
            // 
            // btn_Save2
            // 
            btn_Save2.Location = new Point(1031, 323);
            btn_Save2.Name = "btn_Save2";
            btn_Save2.Size = new Size(75, 23);
            btn_Save2.TabIndex = 50;
            btn_Save2.Text = "Save";
            btn_Save2.UseVisualStyleBackColor = true;
            btn_Save2.Click += btn_Save2_Click;
            // 
            // button10
            // 
            button10.Location = new Point(284, 14);
            button10.Name = "button10";
            button10.Size = new Size(126, 23);
            button10.TabIndex = 47;
            button10.Text = "New Transfer No.";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click_1;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(132, 55);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(225, 23);
            dateTimePicker3.TabIndex = 45;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(501, 101);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(215, 23);
            comboBox4.TabIndex = 44;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(132, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(256, 23);
            comboBox2.TabIndex = 43;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 188);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 23);
            textBox5.TabIndex = 42;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(501, 143);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 23);
            textBox4.TabIndex = 41;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 23);
            textBox3.TabIndex = 40;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 191);
            label17.Name = "label17";
            label17.Size = new Size(93, 15);
            label17.TabIndex = 39;
            label17.Text = "Manager Sign :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(392, 146);
            label16.Name = "label16";
            label16.Size = new Size(103, 15);
            label16.TabIndex = 38;
            label16.Text = "Transfer Reason :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(418, 104);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 37;
            label12.Text = "Destination :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 146);
            label11.Name = "label11";
            label11.Size = new Size(161, 15);
            label11.TabIndex = 36;
            label11.Text = "Production Order Number :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 104);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 35;
            label10.Text = "Source :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 61);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 34;
            label9.Text = "Launch Date :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 18);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 33;
            label8.Text = "Transfer Number : ";
            // 
            // dataGridView6
            // 
            dataGridView6.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(15, 294);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 82;
            dataGridView6.Size = new Size(1010, 168);
            dataGridView6.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label7.Location = new Point(834, 18);
            label7.Name = "label7";
            label7.Size = new Size(152, 15);
            label7.TabIndex = 2;
            label7.Text = "Internal Transfer History";
            // 
            // DemandForecast
            // 
            DemandForecast.BackgroundImageLayout = ImageLayout.None;
            DemandForecast.Controls.Add(btn_Add8);
            DemandForecast.Controls.Add(btn_Save1);
            DemandForecast.Controls.Add(label14);
            DemandForecast.Controls.Add(button12);
            DemandForecast.Controls.Add(dataGridView7);
            DemandForecast.Location = new Point(4, 24);
            DemandForecast.Name = "DemandForecast";
            DemandForecast.Padding = new Padding(3, 3, 3, 3);
            DemandForecast.Size = new Size(1121, 710);
            DemandForecast.TabIndex = 3;
            DemandForecast.Text = "Demand Forecast";
            DemandForecast.UseVisualStyleBackColor = true;
            // 
            // btn_Add8
            // 
            btn_Add8.Location = new Point(1046, 29);
            btn_Add8.Name = "btn_Add8";
            btn_Add8.Size = new Size(75, 23);
            btn_Add8.TabIndex = 27;
            btn_Add8.Text = "Add";
            btn_Add8.UseVisualStyleBackColor = true;
            // 
            // btn_Save1
            // 
            btn_Save1.Location = new Point(1046, 58);
            btn_Save1.Name = "btn_Save1";
            btn_Save1.Size = new Size(75, 23);
            btn_Save1.TabIndex = 28;
            btn_Save1.Text = "Save";
            btn_Save1.UseVisualStyleBackColor = true;
            btn_Save1.Click += btn_Save1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label14.Location = new Point(17, 11);
            label14.Name = "label14";
            label14.Size = new Size(156, 15);
            label14.TabIndex = 3;
            label14.Text = "Demand Forecast History";
            // 
            // button12
            // 
            button12.Location = new Point(1018, 668);
            button12.Name = "button12";
            button12.Size = new Size(97, 36);
            button12.TabIndex = 1;
            button12.Text = "Save";
            button12.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            dataGridView7.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(17, 29);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 82;
            dataGridView7.Size = new Size(1027, 629);
            dataGridView7.TabIndex = 0;
            // 
            // Supplier
            // 
            Supplier.Controls.Add(btn_Add);
            Supplier.Controls.Add(btn_Save);
            Supplier.Controls.Add(button15);
            Supplier.Controls.Add(dataGridView8);
            Supplier.Controls.Add(label15);
            Supplier.Location = new Point(4, 24);
            Supplier.Name = "Supplier";
            Supplier.Padding = new Padding(3, 3, 3, 3);
            Supplier.Size = new Size(1121, 710);
            Supplier.TabIndex = 4;
            Supplier.Text = "Supplier";
            Supplier.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(1043, 29);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 27;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(1043, 58);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 28;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // button15
            // 
            button15.Location = new Point(1018, 668);
            button15.Name = "button15";
            button15.Size = new Size(97, 36);
            button15.TabIndex = 3;
            button15.Text = "Save";
            button15.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            dataGridView8.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(17, 29);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowHeadersWidth = 82;
            dataGridView8.Size = new Size(1024, 633);
            dataGridView8.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label15.Location = new Point(17, 11);
            label15.Name = "label15";
            label15.Size = new Size(115, 15);
            label15.TabIndex = 0;
            label15.Text = "Supplier Overview";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label18.Location = new Point(111, 12);
            label18.Name = "label18";
            label18.Size = new Size(78, 15);
            label18.TabIndex = 8;
            label18.Text = "User Name :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label19.Location = new Point(111, 39);
            label19.Name = "label19";
            label19.Size = new Size(85, 15);
            label19.TabIndex = 9;
            label19.Text = "Department :";
            // 
            // button8
            // 
            button8.Location = new Point(1091, 12);
            button8.Name = "button8";
            button8.Size = new Size(59, 38);
            button8.TabIndex = 12;
            button8.Text = "User Profile";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnUserProfile_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(210, 25);
            label20.Name = "label20";
            label20.Size = new Size(0, 15);
            label20.TabIndex = 13;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(210, 59);
            label21.Name = "label21";
            label21.Size = new Size(0, 15);
            label21.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(195, 12);
            label30.Name = "label30";
            label30.Size = new Size(49, 15);
            label30.TabIndex = 26;
            label30.Text = "label30";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(195, 39);
            label31.Name = "label31";
            label31.Size = new Size(49, 15);
            label31.TabIndex = 27;
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
            // LogisticForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1153, 671);
            Controls.Add(btnLogout);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(pictureBox2);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(button8);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(btn_Add6);
            Name = "LogisticForm";
            Text = "LogisticForm";
            Load += LogisticForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            btn_Add6.ResumeLayout(false);
            Inventory.ResumeLayout(false);
            Inventory.PerformLayout();
            Procurement.ResumeLayout(false);
            Procurement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            InternalTransferOrder.ResumeLayout(false);
            InternalTransferOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            DemandForecast.ResumeLayout(false);
            DemandForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            Supplier.ResumeLayout(false);
            Supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private DataGridView dataGridView4;
        private TabControl btn_Add6;
        private TabPage Inventory;
        private TabPage Procurement;
        private TabPage InternalTransferOrder;
        private TabPage DemandForecast;
        private TabPage Supplier;
        private Label lblRecord;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private Label label7;
        private DataGridView dataGridView7;
        private Button button12;
        private Label label14;
        private Button button15;
        private DataGridView dataGridView8;
        private Label label15;
        private Label label16;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label17;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox4;
        private ComboBox comboBox2;
        private Label label18;
        private Label label19;
        private Button button8;
        private Label label20;
        private Label label21;
        private PictureBox pictureBox2;
        private Button button10;
        private Label label30;
        private Label label31;
        private Button btnLogout;
        private Button btn_Add;
        private Button btn_Save;
        private Button btn_Add8;
        private Button btn_Save1;
        private Button btn_Add4;
        private Button btn_Save7;
        private Button btn_Add5;
        private Button btn_Save3;
        private Button btn_Add7;
        private Button btn_Save2;
        private ComboBox InOutCombo;
        private TextBox QuantityBox;
        private Label label28;
        private Label label27;
        private Label label25;
        private Label label24;
        private ComboBox WarehouseBox;
        private TextBox RemarkBox;
        private Label label29;
        private ComboBox MaterialBox;
        private Button button1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label1;
        private ComboBox comboBox3;
        private Label label6;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox6;
        private DataGridView dataGridView2;
    }
}