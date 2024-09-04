namespace Mnogoagentnoe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bntStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorLog = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDaysCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChanceBecomeCustomer = new System.Windows.Forms.TextBox();
            this.txtChanceNotice = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblErrorDays = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStoringDays = new System.Windows.Forms.TextBox();
            this.lblErrorPopul = new System.Windows.Forms.Label();
            this.lblErrorCustomer = new System.Windows.Forms.Label();
            this.lblErrorNotice = new System.Windows.Forms.Label();
            this.lblErrorStoringDays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column2, this.Column3, this.Column4, this.Column5, this.Column6, this.Column7, this.Column8, this.Column9, this.Column10, this.Column20, this.Column11, this.Column12, this.Column13, this.Column14, this.Column15, this.Column16, this.Column17, this.Column18, this.Column19 });
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 15;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(504, 767);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 25;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 25;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 25;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Width = 25;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Width = 25;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.Width = 25;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Column20";
            this.Column20.Name = "Column20";
            this.Column20.Width = 25;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.Width = 25;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column12.Width = 25;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.Width = 25;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            this.Column14.Width = 25;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.Width = 25;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Column16";
            this.Column16.Name = "Column16";
            this.Column16.Width = 25;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Column17";
            this.Column17.Name = "Column17";
            this.Column17.Width = 25;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Column18";
            this.Column18.Name = "Column18";
            this.Column18.Width = 25;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Column19";
            this.Column19.Name = "Column19";
            this.Column19.Width = 25;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(792, 455);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(546, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // bntStart
            // 
            this.bntStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntStart.Location = new System.Drawing.Point(3, 57);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(267, 104);
            this.bntStart.TabIndex = 2;
            this.bntStart.Text = "Start";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(518, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число людей в популяции";
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(521, 54);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(174, 20);
            this.txtPopulation.TabIndex = 4;
            this.txtPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "До 1000 человек";
            // 
            // ErrorLog
            // 
            this.ErrorLog.AutoSize = true;
            this.ErrorLog.Location = new System.Drawing.Point(14, 224);
            this.ErrorLog.Name = "ErrorLog";
            this.ErrorLog.Size = new System.Drawing.Size(0, 13);
            this.ErrorLog.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = " количество дней";
            // 
            // txtDaysCount
            // 
            this.txtDaysCount.Location = new System.Drawing.Point(8, 19);
            this.txtDaysCount.Name = "txtDaysCount";
            this.txtDaysCount.Size = new System.Drawing.Size(109, 20);
            this.txtDaysCount.TabIndex = 8;
            this.txtDaysCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(701, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Процент стать потребителем";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(908, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Процент оповещения";
            // 
            // txtChanceBecomeCustomer
            // 
            this.txtChanceBecomeCustomer.Location = new System.Drawing.Point(704, 54);
            this.txtChanceBecomeCustomer.Name = "txtChanceBecomeCustomer";
            this.txtChanceBecomeCustomer.Size = new System.Drawing.Size(198, 20);
            this.txtChanceBecomeCustomer.TabIndex = 11;
            this.txtChanceBecomeCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChanceNotice
            // 
            this.txtChanceNotice.Location = new System.Drawing.Point(911, 54);
            this.txtChanceNotice.Name = "txtChanceNotice";
            this.txtChanceNotice.Size = new System.Drawing.Size(144, 20);
            this.txtChanceNotice.TabIndex = 12;
            this.txtChanceNotice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 188);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(270, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSet.Location = new System.Drawing.Point(6, 164);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(46, 23);
            this.btnSet.TabIndex = 14;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(58, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1090, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 45);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Жёлтые ячейки - потенциальные покупатели\r\nЗелёные ячейки - потребители\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lblDay);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblErrorDays);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.bntStart);
            this.panel2.Controls.Add(this.ErrorLog);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSet);
            this.panel2.Controls.Add(this.txtDaysCount);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Location = new System.Drawing.Point(510, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 312);
            this.panel2.TabIndex = 17;
            // 
            // lblDay
            // 
            this.lblDay.Location = new System.Drawing.Point(226, 19);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(100, 23);
            this.lblDay.TabIndex = 25;
            this.lblDay.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(191, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Текущий день";
            // 
            // lblErrorDays
            // 
            this.lblErrorDays.AutoSize = true;
            this.lblErrorDays.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDays.Location = new System.Drawing.Point(8, 42);
            this.lblErrorDays.Name = "lblErrorDays";
            this.lblErrorDays.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDays.TabIndex = 18;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(113, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(106, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Error log";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Срок хранения продукта в днях";
            // 
            // txtStoringDays
            // 
            this.txtStoringDays.Location = new System.Drawing.Point(521, 127);
            this.txtStoringDays.Name = "txtStoringDays";
            this.txtStoringDays.Size = new System.Drawing.Size(163, 20);
            this.txtStoringDays.TabIndex = 19;
            this.txtStoringDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblErrorPopul
            // 
            this.lblErrorPopul.AutoSize = true;
            this.lblErrorPopul.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPopul.Location = new System.Drawing.Point(524, 77);
            this.lblErrorPopul.Name = "lblErrorPopul";
            this.lblErrorPopul.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPopul.TabIndex = 20;
            // 
            // lblErrorCustomer
            // 
            this.lblErrorCustomer.AutoSize = true;
            this.lblErrorCustomer.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCustomer.Location = new System.Drawing.Point(701, 77);
            this.lblErrorCustomer.Name = "lblErrorCustomer";
            this.lblErrorCustomer.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCustomer.TabIndex = 21;
            // 
            // lblErrorNotice
            // 
            this.lblErrorNotice.AutoSize = true;
            this.lblErrorNotice.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNotice.Location = new System.Drawing.Point(908, 77);
            this.lblErrorNotice.Name = "lblErrorNotice";
            this.lblErrorNotice.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNotice.TabIndex = 22;
            // 
            // lblErrorStoringDays
            // 
            this.lblErrorStoringDays.AutoSize = true;
            this.lblErrorStoringDays.Location = new System.Drawing.Point(518, 150);
            this.lblErrorStoringDays.Name = "lblErrorStoringDays";
            this.lblErrorStoringDays.Size = new System.Drawing.Size(0, 13);
            this.lblErrorStoringDays.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 767);
            this.Controls.Add(this.lblErrorStoringDays);
            this.Controls.Add(this.lblErrorNotice);
            this.Controls.Add(this.lblErrorCustomer);
            this.Controls.Add(this.lblErrorPopul);
            this.Controls.Add(this.txtStoringDays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtChanceNotice);
            this.Controls.Add(this.txtChanceBecomeCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPopulation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDay;

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDaysCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChanceBecomeCustomer;
        private System.Windows.Forms.TextBox txtChanceNotice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStoringDays;
        private System.Windows.Forms.Label lblErrorPopul;
        private System.Windows.Forms.Label lblErrorCustomer;
        private System.Windows.Forms.Label lblErrorNotice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblErrorStoringDays;
        private System.Windows.Forms.Label lblErrorDays;
    }
}

