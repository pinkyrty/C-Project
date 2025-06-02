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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            button8 = new Button();
            label19 = new Label();
            label18 = new Label();
            pictureBox1 = new PictureBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            FIYear = new DataGridViewTextBoxColumn();
            FIBudgetRevenue = new DataGridViewTextBoxColumn();
            FIBudgetExpenditure = new DataGridViewTextBoxColumn();
            FIForecastRevenue = new DataGridViewTextBoxColumn();
            FIForecastSpending = new DataGridViewTextBoxColumn();
            FIOperation = new DataGridViewButtonColumn();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            FIIncomeDate = new DataGridViewTextBoxColumn();
            FIIncomeType = new DataGridViewComboBoxColumn();
            FIIncomeAmount = new DataGridViewTextBoxColumn();
            FIIncomeRemark = new DataGridViewTextBoxColumn();
            FIIncomeState = new DataGridViewComboBoxColumn();
            FIIincomeOperation = new DataGridViewButtonColumn();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label11 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            button2 = new Button();
            label13 = new Label();
            button3 = new Button();
            dataGridView3 = new DataGridView();
            FIStateType = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
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
            chartArea11.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            chart1.Legends.Add(legend11);
            chart1.Location = new Point(6, 311);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            chart1.Series.Add(series11);
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
            // button1
            // 
            button1.Location = new Point(28, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FIYear, FIBudgetRevenue, FIBudgetExpenditure, FIForecastRevenue, FIForecastSpending, FIOperation });
            dataGridView1.Location = new Point(16, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(782, 235);
            dataGridView1.TabIndex = 21;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 20;
            label1.Text = "Annual Budget and Forecast";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chart2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(804, 500);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(309, 15);
            label3.TabIndex = 0;
            label3.Text = "Income and Expenditure and Cash Flow Management";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { FIIncomeDate, FIIncomeType, FIIncomeAmount, FIIncomeRemark, FIIncomeState, FIIincomeOperation });
            dataGridView2.Location = new Point(3, 46);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(798, 198);
            dataGridView2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 262);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 2;
            label4.Text = "Cash flow monthly trend";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 22);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 59);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(210, 22);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(210, 59);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 24;
            // 
            // FIIncomeDate
            // 
            FIIncomeDate.HeaderText = "Date";
            FIIncomeDate.Name = "FIIncomeDate";
            // 
            // FIIncomeType
            // 
            FIIncomeType.HeaderText = "Type";
            FIIncomeType.Name = "FIIncomeType";
            // 
            // FIIncomeAmount
            // 
            FIIncomeAmount.HeaderText = "Amount";
            FIIncomeAmount.Name = "FIIncomeAmount";
            // 
            // FIIncomeRemark
            // 
            FIIncomeRemark.HeaderText = "Remark";
            FIIncomeRemark.Name = "FIIncomeRemark";
            // 
            // FIIncomeState
            // 
            FIIncomeState.HeaderText = "State";
            FIIncomeState.Name = "FIIncomeState";
            // 
            // FIIincomeOperation
            // 
            FIIincomeOperation.HeaderText = "Operation";
            FIIincomeOperation.Name = "FIIincomeOperation";
            // 
            // chart2
            // 
            chartArea12.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            chart2.Legends.Add(legend12);
            chart2.Location = new Point(3, 280);
            chart2.Name = "chart2";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            chart2.Series.Add(series12);
            chart2.Size = new Size(801, 220);
            chart2.TabIndex = 3;
            chart2.Text = "chart2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 18);
            label9.Name = "label9";
            label9.Size = new Size(431, 15);
            label9.TabIndex = 0;
            label9.Text = "Financial statements (income statement/balance sheet/cash flow statement)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 45);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 1;
            label10.Text = "Type :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(74, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 75);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 3;
            label11.Text = "Perior :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 109);
            label12.Name = "label12";
            label12.Size = new Size(78, 15);
            label12.TabIndex = 5;
            label12.Text = "Upload File :";
            label12.Click += label12_Click;
            // 
            // button2
            // 
            button2.Location = new Point(113, 106);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 6;
            button2.Text = "Choose File";
            button2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(194, 110);
            label13.Name = "label13";
            label13.Size = new Size(49, 15);
            label13.TabIndex = 7;
            label13.Text = "label13";
            // 
            // button3
            // 
            button3.Location = new Point(46, 160);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Upload";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { FIStateType });
            dataGridView3.Location = new Point(0, 280);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(804, 224);
            dataGridView3.TabIndex = 9;
            // 
            // FIStateType
            // 
            FIStateType.HeaderText = "Type";
            FIStateType.Name = "FIStateType";
            // 
            // FinanceDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(836, 641);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tabControl1);
            Controls.Add(button8);
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
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
        private Label label4;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private DataGridViewTextBoxColumn FIIncomeDate;
        private DataGridViewComboBoxColumn FIIncomeType;
        private DataGridViewTextBoxColumn FIIncomeAmount;
        private DataGridViewTextBoxColumn FIIncomeRemark;
        private DataGridViewComboBoxColumn FIIncomeState;
        private DataGridViewButtonColumn FIIincomeOperation;
        private Label label12;
        private TextBox textBox1;
        private Label label11;
        private ComboBox comboBox1;
        private Label label10;
        private Label label9;
        private Button button2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn FIStateType;
        private Button button3;
        private Label label13;
    }
}