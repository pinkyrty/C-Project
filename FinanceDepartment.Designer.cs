namespace C_Project
{
    partial class FinanceDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceDepartment));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            button8 = new Button();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            label19 = new Label();
            label18 = new Label();
            pictureBox1 = new PictureBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            FIYear = new DataGridViewTextBoxColumn();
            FIBudgetRevenue = new DataGridViewTextBoxColumn();
            FIBudgetExpenditure = new DataGridViewTextBoxColumn();
            FIForecastRevenue = new DataGridViewTextBoxColumn();
            FIForecastSpending = new DataGridViewTextBoxColumn();
            FIOperation = new DataGridViewButtonColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button8
            // 
            button8.Location = new Point(752, 12);
            button8.Name = "button8";
            button8.Size = new Size(72, 62);
            button8.TabIndex = 18;
            button8.Text = "Profile";
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(210, 56);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(124, 23);
            textBox8.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(210, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(124, 23);
            textBox7.TabIndex = 16;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(123, 59);
            label19.Name = "label19";
            label19.Size = new Size(81, 15);
            label19.TabIndex = 15;
            label19.Text = "Department :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(128, 22);
            label18.Name = "label18";
            label18.Size = new Size(76, 15);
            label18.TabIndex = 14;
            label18.Text = "User Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(6, 311);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(792, 183);
            chart1.TabIndex = 19;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 101);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(812, 528);
            tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(chart1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(804, 500);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 20;
            label1.Text = "Annual Budget and Forecast";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FIYear, FIBudgetRevenue, FIBudgetExpenditure, FIForecastRevenue, FIForecastSpending, FIOperation });
            dataGridView1.Location = new Point(16, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(782, 235);
            dataGridView1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 284);
            label2.Name = "label2";
            label2.Size = new Size(217, 15);
            label2.TabIndex = 22;
            label2.Text = "Annual budget and actual trend chart";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(804, 500);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(804, 500);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(804, 500);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // FIYear
            // 
            FIYear.HeaderText = "Year";
            FIYear.Name = "FIYear";
            // 
            // FIBudgetRevenue
            // 
            FIBudgetRevenue.HeaderText = "Budget Revenue";
            FIBudgetRevenue.Name = "FIBudgetRevenue";
            // 
            // FIBudgetExpenditure
            // 
            FIBudgetExpenditure.HeaderText = "Budget Expenditure";
            FIBudgetExpenditure.Name = "FIBudgetExpenditure";
            // 
            // FIForecastRevenue
            // 
            FIForecastRevenue.HeaderText = "Forecastr Revenue";
            FIForecastRevenue.Name = "FIForecastRevenue";
            // 
            // FIForecastSpending
            // 
            FIForecastSpending.HeaderText = "Forecast Spending";
            FIForecastSpending.Name = "FIForecastSpending";
            // 
            // FIOperation
            // 
            FIOperation.HeaderText = "Operation";
            FIOperation.Name = "FIOperation";
            // 
            // button1
            // 
            button1.Location = new Point(28, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            // 
            // FinanceDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(836, 641);
            Controls.Add(tabControl1);
            Controls.Add(button8);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(pictureBox1);
            Name = "FinanceDepartment";
            Text = "FinanceDepartment";
            Load += FinanceDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label19;
        private Label label18;
        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FIYear;
        private DataGridViewTextBoxColumn FIBudgetRevenue;
        private DataGridViewTextBoxColumn FIBudgetExpenditure;
        private DataGridViewTextBoxColumn FIForecastRevenue;
        private DataGridViewTextBoxColumn FIForecastSpending;
        private DataGridViewButtonColumn FIOperation;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button1;
    }
}