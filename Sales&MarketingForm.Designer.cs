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
            RaDUserPrifileButton = new Button();
            tabControl = new TabControl();
            QuotationTabPage = new TabPage();
            ProductionorderTabPage = new TabPage();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            label3 = new Label();
            AddNewOrdersButton = new Button();
            dgvProdOrderList = new DataGridView();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl.SuspendLayout();
            QuotationTabPage.SuspendLayout();
            ProductionorderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdOrderList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Location = new Point(105, 12);
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
            label2.Location = new Point(105, 38);
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
            // RaDUserPrifileButton
            // 
            RaDUserPrifileButton.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            RaDUserPrifileButton.Location = new Point(879, 12);
            RaDUserPrifileButton.Name = "RaDUserPrifileButton";
            RaDUserPrifileButton.Size = new Size(59, 38);
            RaDUserPrifileButton.TabIndex = 34;
            RaDUserPrifileButton.Text = "User Prifile";
            RaDUserPrifileButton.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(QuotationTabPage);
            tabControl.Controls.Add(ProductionorderTabPage);
            tabControl.Location = new Point(12, 106);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(936, 528);
            tabControl.TabIndex = 35;
            // 
            // QuotationTabPage
            // 
            QuotationTabPage.Controls.Add(splitContainer1);
            QuotationTabPage.Location = new Point(4, 24);
            QuotationTabPage.Name = "QuotationTabPage";
            QuotationTabPage.Padding = new Padding(3);
            QuotationTabPage.Size = new Size(928, 500);
            QuotationTabPage.TabIndex = 0;
            QuotationTabPage.Text = "Quotation";
            QuotationTabPage.UseVisualStyleBackColor = true;
            // 
            // ProductionorderTabPage
            // 
            ProductionorderTabPage.Controls.Add(splitContainer2);
            ProductionorderTabPage.Location = new Point(4, 24);
            ProductionorderTabPage.Name = "ProductionorderTabPage";
            ProductionorderTabPage.Padding = new Padding(3);
            ProductionorderTabPage.Size = new Size(928, 500);
            ProductionorderTabPage.TabIndex = 1;
            ProductionorderTabPage.Text = "Production order";
            ProductionorderTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvProdOrderList);
            splitContainer1.Panel1.Controls.Add(AddNewOrdersButton);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Size = new Size(922, 494);
            splitContainer1.SplitterDistance = 307;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView1);
            splitContainer2.Panel1.Controls.Add(button1);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Size = new Size(922, 494);
            splitContainer2.SplitterDistance = 307;
            splitContainer2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 5);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 0;
            label3.Text = "Production Order Overview";
            // 
            // AddNewOrdersButton
            // 
            AddNewOrdersButton.Location = new Point(4, 25);
            AddNewOrdersButton.Name = "AddNewOrdersButton";
            AddNewOrdersButton.Size = new Size(115, 23);
            AddNewOrdersButton.TabIndex = 1;
            AddNewOrdersButton.Text = "＋Add new orders";
            AddNewOrdersButton.UseVisualStyleBackColor = true;
            // 
            // dgvProdOrderList
            // 
            dgvProdOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdOrderList.Location = new Point(4, 54);
            dgvProdOrderList.Name = "dgvProdOrderList";
            dgvProdOrderList.Size = new Size(298, 138);
            dgvProdOrderList.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(298, 138);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(4, 25);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 4;
            button1.Text = "+ Add a new quotation";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 5);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 3;
            label4.Text = "Quotation Overview";
            // 
            // Sales_MarketingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(950, 635);
            Controls.Add(tabControl);
            Controls.Add(RaDUserPrifileButton);
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
            ProductionorderTabPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdOrderList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label UserName;
        private Label label2;
        private Label Department;
        private Button RaDUserPrifileButton;
        private TabControl tabControl;
        private TabPage QuotationTabPage;
        private SplitContainer splitContainer1;
        private TabPage ProductionorderTabPage;
        private SplitContainer splitContainer2;
        private DataGridView dgvProdOrderList;
        private Button AddNewOrdersButton;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label4;
    }
}