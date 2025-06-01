namespace C_Project
{
    partial class InternalTransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternalTransferForm));
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(702, 554);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 12);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 16;
            label1.Text = "Transfer Form ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 36);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 17;
            label2.Text = "Transfer Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 60);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 18;
            label3.Text = "Source Department:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 85);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 19;
            label4.Text = "Destination Department:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 194);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 21;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(554, 235);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 22;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(556, 289);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 23;
            label8.Text = "label8";
            // 
            // InternalTransferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(815, 608);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Name = "InternalTransferForm";
            Text = "InternalTransferForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}