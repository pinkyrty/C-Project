namespace C_Project
{
    partial class IT_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT_Form));
            pictureBox1 = new PictureBox();
            CreateUserButton = new Button();
            DeleteUserButton = new Button();
            RADButton = new Button();
            FinanceButton = new Button();
            CustomerServiceButton = new Button();
            SupplyChainManagementButton = new Button();
            ProductionButton = new Button();
            SalesAMarketingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CreateUserButton
            // 
            CreateUserButton.Location = new Point(300, 120);
            CreateUserButton.Name = "CreateUserButton";
            CreateUserButton.Size = new Size(84, 53);
            CreateUserButton.TabIndex = 1;
            CreateUserButton.Text = "Create User";
            CreateUserButton.UseVisualStyleBackColor = true;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Location = new Point(181, 120);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(84, 53);
            DeleteUserButton.TabIndex = 2;
            DeleteUserButton.Text = "Delete User";
            DeleteUserButton.UseVisualStyleBackColor = true;
            // 
            // RADButton
            // 
            RADButton.Location = new Point(51, 207);
            RADButton.Name = "RADButton";
            RADButton.Size = new Size(84, 53);
            RADButton.TabIndex = 3;
            RADButton.Text = "Research and Development ";
            RADButton.UseVisualStyleBackColor = true;
            // 
            // FinanceButton
            // 
            FinanceButton.Location = new Point(181, 207);
            FinanceButton.Name = "FinanceButton";
            FinanceButton.Size = new Size(84, 53);
            FinanceButton.TabIndex = 4;
            FinanceButton.Text = "Finance";
            FinanceButton.UseVisualStyleBackColor = true;
            // 
            // CustomerServiceButton
            // 
            CustomerServiceButton.Location = new Point(300, 207);
            CustomerServiceButton.Name = "CustomerServiceButton";
            CustomerServiceButton.Size = new Size(84, 53);
            CustomerServiceButton.TabIndex = 5;
            CustomerServiceButton.Text = "Customer Service";
            CustomerServiceButton.UseVisualStyleBackColor = true;
            // 
            // SupplyChainManagementButton
            // 
            SupplyChainManagementButton.Location = new Point(300, 315);
            SupplyChainManagementButton.Name = "SupplyChainManagementButton";
            SupplyChainManagementButton.Size = new Size(84, 53);
            SupplyChainManagementButton.TabIndex = 6;
            SupplyChainManagementButton.TabStop = false;
            SupplyChainManagementButton.Text = "Supply Chain Management";
            SupplyChainManagementButton.UseVisualStyleBackColor = true;
            // 
            // ProductionButton
            // 
            ProductionButton.Location = new Point(181, 315);
            ProductionButton.Name = "ProductionButton";
            ProductionButton.Size = new Size(84, 53);
            ProductionButton.TabIndex = 7;
            ProductionButton.Text = "Production";
            ProductionButton.UseVisualStyleBackColor = true;
            // 
            // SalesAMarketingButton
            // 
            SalesAMarketingButton.Location = new Point(51, 315);
            SalesAMarketingButton.Name = "SalesAMarketingButton";
            SalesAMarketingButton.Size = new Size(84, 53);
            SalesAMarketingButton.TabIndex = 8;
            SalesAMarketingButton.Text = "Sales and Marketing";
            SalesAMarketingButton.UseVisualStyleBackColor = true;
            // 
            // IT_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(419, 432);
            Controls.Add(SalesAMarketingButton);
            Controls.Add(ProductionButton);
            Controls.Add(SupplyChainManagementButton);
            Controls.Add(CustomerServiceButton);
            Controls.Add(FinanceButton);
            Controls.Add(RADButton);
            Controls.Add(DeleteUserButton);
            Controls.Add(CreateUserButton);
            Controls.Add(pictureBox1);
            Name = "IT_Form";
            Text = "IT_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button CreateUserButton;
        private Button DeleteUserButton;
        private Button RADButton;
        private Button FinanceButton;
        private Button CustomerServiceButton;
        private Button SupplyChainManagementButton;
        private Button ProductionButton;
        private Button SalesAMarketingButton;
    }
}