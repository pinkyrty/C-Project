namespace C_Project
{
    partial class ProductionOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionOrderForm));
            btnUserProfile = new Button();
            label19 = new Label();
            label18 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            orderNumberTextBox = new TextBox();
            label2 = new Label();
            productNumberTextBox = new TextBox();
            label3 = new Label();
            productNameTextBox = new TextBox();
            label4 = new Label();
            remarkTextBox = new TextBox();
            label5 = new Label();
            quantityTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_Save1 = new Button();
            btn_Add1 = new Button();
            dataGridView3 = new DataGridView();
            tabPage2 = new TabPage();
            btn_Add4 = new Button();
            dataGridView5 = new DataGridView();
            btn_Save4 = new Button();
            workInstructionsTextBox = new TextBox();
            label11 = new Label();
            targetDateTimePicker = new DateTimePicker();
            label10 = new Label();
            startDateTimePicker = new DateTimePicker();
            label9 = new Label();
            tabPage3 = new TabPage();
            btn_Save2 = new Button();
            btn_Add2 = new Button();
            label12 = new Label();
            dataGridView4 = new DataGridView();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            selectedDate = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            label31 = new Label();
            label30 = new Label();
            btnLogout = new Button();
            btn_Save3 = new Button();
            btn_Add3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            btnUserProfile.Click += btnUserProfile_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 70);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 19;
            label1.Text = "Order Number :";
            label1.Click += label1_Click;
            // 
            // orderNumberTextBox
            // 
            orderNumberTextBox.Location = new Point(521, 65);
            orderNumberTextBox.Name = "orderNumberTextBox";
            orderNumberTextBox.Size = new Size(134, 23);
            orderNumberTextBox.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(775, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 21;
            label2.Text = "Date :";
            // 
            // productNumberTextBox
            // 
            productNumberTextBox.Location = new Point(888, 117);
            productNumberTextBox.Name = "productNumberTextBox";
            productNumberTextBox.Size = new Size(100, 23);
            productNumberTextBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(775, 123);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 25;
            label3.Text = "Product Number :";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(521, 120);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(204, 23);
            productNameTextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 125);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 23;
            label4.Text = "Product Name :";
            // 
            // remarkTextBox
            // 
            remarkTextBox.Location = new Point(837, 170);
            remarkTextBox.Name = "remarkTextBox";
            remarkTextBox.Size = new Size(300, 23);
            remarkTextBox.TabIndex = 30;
            remarkTextBox.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(775, 173);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 29;
            label5.Text = "Remark :";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(521, 173);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 28;
            quantityTextBox.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(453, 176);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 27;
            label6.Text = "Quantity :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label7.Location = new Point(415, 228);
            label7.Name = "label7";
            label7.Size = new Size(136, 15);
            label7.TabIndex = 31;
            label7.Text = "Material Requirement";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(415, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(641, 170);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(415, 422);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(726, 401);
            tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_Save1);
            tabPage1.Controls.Add(btn_Add1);
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(718, 373);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Process Assignment";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btn_Save1
            // 
            btn_Save1.Location = new Point(643, 32);
            btn_Save1.Name = "btn_Save1";
            btn_Save1.Size = new Size(75, 23);
            btn_Save1.TabIndex = 44;
            btn_Save1.Text = "Save";
            btn_Save1.UseVisualStyleBackColor = true;
            btn_Save1.Click += btn_Save1_Click;
            // 
            // btn_Add1
            // 
            btn_Add1.Location = new Point(643, 3);
            btn_Add1.Name = "btn_Add1";
            btn_Add1.Size = new Size(75, 23);
            btn_Add1.TabIndex = 43;
            btn_Add1.Text = "Add";
            btn_Add1.UseVisualStyleBackColor = true;
            btn_Add1.Click += btn_Add1_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(-4, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(641, 377);
            dataGridView3.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_Add4);
            tabPage2.Controls.Add(dataGridView5);
            tabPage2.Controls.Add(btn_Save4);
            tabPage2.Controls.Add(workInstructionsTextBox);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(targetDateTimePicker);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(startDateTimePicker);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(718, 373);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Production Plan";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Add4
            // 
            btn_Add4.Location = new Point(640, 6);
            btn_Add4.Name = "btn_Add4";
            btn_Add4.Size = new Size(75, 23);
            btn_Add4.TabIndex = 49;
            btn_Add4.Text = "Add";
            btn_Add4.UseVisualStyleBackColor = true;
            btn_Add4.Click += btn_Add4_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(3, 120);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(715, 250);
            dataGridView5.TabIndex = 48;
            dataGridView5.CellContentClick += dataGridView5_CellContentClick;
            // 
            // btn_Save4
            // 
            btn_Save4.Location = new Point(640, 35);
            btn_Save4.Name = "btn_Save4";
            btn_Save4.Size = new Size(75, 23);
            btn_Save4.TabIndex = 47;
            btn_Save4.Text = "Save";
            btn_Save4.UseVisualStyleBackColor = true;
            btn_Save4.Click += btn_Save4_Click;
            // 
            // workInstructionsTextBox
            // 
            workInstructionsTextBox.Location = new Point(124, 91);
            workInstructionsTextBox.Name = "workInstructionsTextBox";
            workInstructionsTextBox.Size = new Size(248, 23);
            workInstructionsTextBox.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 94);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 4;
            label11.Text = "Work Instructions";
            // 
            // targetDateTimePicker
            // 
            targetDateTimePicker.Location = new Point(103, 53);
            targetDateTimePicker.Name = "targetDateTimePicker";
            targetDateTimePicker.Size = new Size(200, 23);
            targetDateTimePicker.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 59);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 2;
            label10.Text = "Target Date :";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(103, 16);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(200, 23);
            startDateTimePicker.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 22);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 0;
            label9.Text = "Start Date :";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_Save2);
            tabPage3.Controls.Add(btn_Add2);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(dataGridView4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(718, 373);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "File Management";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Save2
            // 
            btn_Save2.Location = new Point(88, 191);
            btn_Save2.Name = "btn_Save2";
            btn_Save2.Size = new Size(75, 23);
            btn_Save2.TabIndex = 46;
            btn_Save2.Text = "Save";
            btn_Save2.UseVisualStyleBackColor = true;
            btn_Save2.Click += btn_Save2_Click;
            // 
            // btn_Add2
            // 
            btn_Add2.Location = new Point(7, 191);
            btn_Add2.Name = "btn_Add2";
            btn_Add2.Size = new Size(75, 23);
            btn_Add2.TabIndex = 45;
            btn_Add2.Text = "Add";
            btn_Add2.UseVisualStyleBackColor = true;
            btn_Add2.Click += btn_Add2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 8);
            label12.Name = "label12";
            label12.Size = new Size(106, 15);
            label12.TabIndex = 1;
            label12.Text = "File Management";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(7, 26);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(705, 159);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView4_CellDoubleClick);
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(15, 157);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(380, 666);
            dataGridView2.TabIndex = 34;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label8.Location = new Point(15, 139);
            label8.Name = "label8";
            label8.Size = new Size(162, 15);
            label8.TabIndex = 35;
            label8.Text = "Production Order Preview";
            // 
            // selectedDate
            // 
            selectedDate.Location = new Point(821, 60);
            selectedDate.Name = "selectedDate";
            selectedDate.Size = new Size(135, 23);
            selectedDate.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(210, 25);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(210, 59);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 38;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(202, 39);
            label31.Name = "label31";
            label31.Size = new Size(49, 15);
            label31.TabIndex = 40;
            label31.Text = "label31";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(202, 12);
            label30.Name = "label30";
            label30.Size = new Size(49, 15);
            label30.TabIndex = 39;
            label30.Text = "label30";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1028, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(57, 38);
            btnLogout.TabIndex = 41;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btn_Save3
            // 
            btn_Save3.Location = new Point(1066, 275);
            btn_Save3.Name = "btn_Save3";
            btn_Save3.Size = new Size(75, 23);
            btn_Save3.TabIndex = 46;
            btn_Save3.Text = "Save";
            btn_Save3.UseVisualStyleBackColor = true;
            btn_Save3.Click += btn_Save3_Click_1;
            // 
            // btn_Add3
            // 
            btn_Add3.Location = new Point(1066, 246);
            btn_Add3.Name = "btn_Add3";
            btn_Add3.Size = new Size(75, 23);
            btn_Add3.TabIndex = 45;
            btn_Add3.Text = "Add";
            btn_Add3.UseVisualStyleBackColor = true;
            btn_Add3.Click += btn_Add3_Click;
            // 
            // ProductionOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1153, 858);
            Controls.Add(btn_Save3);
            Controls.Add(btn_Add3);
            Controls.Add(btnLogout);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(selectedDate);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(remarkTextBox);
            Controls.Add(label5);
            Controls.Add(quantityTextBox);
            Controls.Add(label6);
            Controls.Add(productNumberTextBox);
            Controls.Add(label3);
            Controls.Add(productNameTextBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(orderNumberTextBox);
            Controls.Add(label1);
            Controls.Add(btnUserProfile);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(pictureBox1);
            Name = "ProductionOrderForm";
            Text = "ProductionOrderForm";
            Load += ProductionOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUserProfile;
        private Label label19;
        private Label label18;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox orderNumberTextBox;
        private Label label2;
        private TextBox productNumberTextBox;
        private Label label3;
        private TextBox productNameTextBox;
        private Label label4;
        private TextBox remarkTextBox;
        private Label label5;
        private TextBox quantityTextBox;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Label label8;
        private DateTimePicker selectedDate;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private TextBox workInstructionsTextBox;
        private Label label11;
        private DateTimePicker targetDateTimePicker;
        private Label label10;
        private DateTimePicker startDateTimePicker;
        private Label label9;
        private Label label12;
        private DataGridView dataGridView4;
        private Label label13;
        private Label label14;
        private Label label31;
        private Label label30;
        private Button btnLogout;
        private Button btn_Save1;
        private Button btn_Add1;
        private Button btn_Save2;
        private Button btn_Add2;
        private Button btn_Save3;
        private Button btn_Add3;
        private Button btn_Save4;
        private DataGridView dataGridView5;
        private Button btn_Add4;
    }
}