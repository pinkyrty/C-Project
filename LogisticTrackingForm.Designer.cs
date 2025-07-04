﻿namespace C_Project
{
    partial class LogisticTrackingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogisticTrackingForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            button8 = new Button();
            label19 = new Label();
            label18 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            label31 = new Label();
            label30 = new Label();
            btnLogout = new Button();
            btn_Add = new Button();
            btn_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 124);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Logistic No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 124);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = " Order No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 155);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Recipient:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 155);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Carrier:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(529, 155);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "State:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 186);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 7;
            label6.Text = "Address:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Awaiting Shipment", "In Transit", "Delivered", "Abnormal Situation" });
            comboBox1.Location = new Point(574, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 23);
            comboBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 186);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1000, 95);
            textBox3.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label7.Location = new Point(14, 530);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 14;
            label7.Text = "Logistics Progress:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 548);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1031, 164);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button8
            // 
            button8.Location = new Point(1091, 12);
            button8.Name = "button8";
            button8.Size = new Size(59, 38);
            button8.TabIndex = 20;
            button8.Text = "User Profile";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnUserProfile_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label19.Location = new Point(111, 39);
            label19.Name = "label19";
            label19.Size = new Size(85, 15);
            label19.TabIndex = 17;
            label19.Text = "Department :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label18.Location = new Point(111, 12);
            label18.Name = "label18";
            label18.Size = new Size(78, 15);
            label18.TabIndex = 16;
            label18.Text = "User Name :";
            label18.Click += label18_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 31);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(207, 65);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(30, 736);
            button1.Name = "button1";
            button1.Size = new Size(89, 42);
            button1.TabIndex = 23;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(30, 607);
            button2.Name = "button2";
            button2.Size = new Size(101, 23);
            button2.TabIndex = 24;
            button2.Text = "New Station";
            button2.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(202, 39);
            label31.Name = "label31";
            label31.Size = new Size(49, 15);
            label31.TabIndex = 26;
            label31.Text = "label31";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(202, 12);
            label30.Name = "label30";
            label30.Size = new Size(49, 15);
            label30.TabIndex = 25;
            label30.Text = "label30";
            label30.Click += label30_Click;
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
            // btn_Add
            // 
            btn_Add.Location = new Point(1051, 548);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 27;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(1051, 577);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 28;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // LogisticTrackingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1153, 858);
            Controls.Add(btn_Add);
            Controls.Add(btn_Save);
            Controls.Add(btnLogout);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button8);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LogisticTrackingForm";
            Text = "LogisticTracking";
            Load += LogisticTrackingForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button8;
        private Label label19;
        private Label label18;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
        private Label label31;
        private Label label30;
        private Button btnLogout;
        private Button btn_Add;
        private Button btn_Save;
    }
}