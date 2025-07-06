namespace C_Project
{
    partial class AddProduct
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
            comboBox1 = new ComboBox();
            qtyLabel = new Label();
            productItemName = new Label();
            cancelBtn = new Button();
            okBtn = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(222, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new Point(156, 119);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(25, 15);
            qtyLabel.TabIndex = 10;
            qtyLabel.Text = "qty";
            // 
            // productItemName
            // 
            productItemName.AutoSize = true;
            productItemName.Location = new Point(156, 72);
            productItemName.Name = "productItemName";
            productItemName.Size = new Size(52, 15);
            productItemName.TabIndex = 9;
            productItemName.Text = "product";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(312, 188);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(156, 188);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 7;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 6;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(532, 273);
            Controls.Add(comboBox1);
            Controls.Add(qtyLabel);
            Controls.Add(productItemName);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(textBox1);
            Name = "AddProduct";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label qtyLabel;
        private Label productItemName;
        private Button cancelBtn;
        private Button okBtn;
        private TextBox textBox1;
    }
}