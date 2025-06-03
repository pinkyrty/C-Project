namespace C_Project
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
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Time = new DataGridViewTextBoxColumn();
            Node = new DataGridViewTextBoxColumn();
            Remark = new DataGridViewTextBoxColumn();
            button8 = new Button();
            label19 = new Label();
            label18 = new Label();
            label8 = new Label();
            label9 = new Label();
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
            label1.Location = new Point(23, 112);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Logistic No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 112);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = " Order No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 143);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Recipient:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 143);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Carrier:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 143);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "State:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 174);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 7;
            label6.Text = "Address:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(583, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 23);
            comboBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(640, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(640, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(84, 229);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(640, 23);
            textBox5.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 263);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 14;
            label7.Text = "Logistics Progress:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Time, Node, Remark });
            dataGridView1.Location = new Point(23, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 104);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Time
            // 
            Time.HeaderText = "Node";
            Time.Name = "Time";
            // 
            // Node
            // 
            Node.HeaderText = "Time";
            Node.Name = "Node";
            // 
            // Remark
            // 
            Remark.HeaderText = "Remark";
            Remark.Name = "Remark";
            // 
            // button8
            // 
            button8.Location = new Point(652, 12);
            button8.Name = "button8";
            button8.Size = new Size(72, 62);
            button8.TabIndex = 20;
            button8.Text = "User Profile";
            button8.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(120, 65);
            label19.Name = "label19";
            label19.Size = new Size(81, 15);
            label19.TabIndex = 17;
            label19.Text = "Department :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(125, 31);
            label18.Name = "label18";
            label18.Size = new Size(76, 15);
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
            // LogisticTrackingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1153, 858);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button8);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
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
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Node;
        private DataGridViewTextBoxColumn Remark;
        private Button button8;
        private Label label19;
        private Label label18;
        private Label label8;
        private Label label9;
    }
}