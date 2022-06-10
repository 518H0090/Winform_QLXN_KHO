namespace QuanLyXuatNhapKho.Forms
{
    partial class FormThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ViewOutput = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_DetailsTon = new FontAwesome.Sharp.IconButton();
            this.txb_SumOutput = new System.Windows.Forms.TextBox();
            this.txb_SumInput = new System.Windows.Forms.TextBox();
            this.dgv_ViewInput = new System.Windows.Forms.DataGridView();
            this.DisplayNameObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_Month = new System.Windows.Forms.DateTimePicker();
            this.cht_Input = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cht_Output = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Year = new FontAwesome.Sharp.IconButton();
            this.lbl_TopInput = new System.Windows.Forms.Label();
            this.lbl_TopOutput = new System.Windows.Forms.Label();
            this.dtp_Year = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Output)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_ViewOutput);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btn_DetailsTon);
            this.panel1.Controls.Add(this.txb_SumOutput);
            this.panel1.Controls.Add(this.txb_SumInput);
            this.panel1.Controls.Add(this.dgv_ViewInput);
            this.panel1.Location = new System.Drawing.Point(660, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 506);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tổng Hàng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(0, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tổng Hàng Xuất";
            // 
            // dgv_ViewOutput
            // 
            this.dgv_ViewOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ViewOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ViewOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ViewOutput.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ViewOutput.Location = new System.Drawing.Point(0, 325);
            this.dgv_ViewOutput.Name = "dgv_ViewOutput";
            this.dgv_ViewOutput.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ViewOutput.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ViewOutput.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_ViewOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewOutput.Size = new System.Drawing.Size(280, 181);
            this.dgv_ViewOutput.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DisplayNameObject";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Vật Tư";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButton1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(247, 273);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(33, 33);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // btn_DetailsTon
            // 
            this.btn_DetailsTon.BackColor = System.Drawing.Color.White;
            this.btn_DetailsTon.FlatAppearance.BorderSize = 0;
            this.btn_DetailsTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DetailsTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DetailsTon.ForeColor = System.Drawing.Color.Transparent;
            this.btn_DetailsTon.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btn_DetailsTon.IconColor = System.Drawing.Color.RoyalBlue;
            this.btn_DetailsTon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DetailsTon.IconSize = 30;
            this.btn_DetailsTon.Location = new System.Drawing.Point(247, 23);
            this.btn_DetailsTon.Name = "btn_DetailsTon";
            this.btn_DetailsTon.Size = new System.Drawing.Size(33, 37);
            this.btn_DetailsTon.TabIndex = 7;
            this.btn_DetailsTon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DetailsTon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DetailsTon.UseVisualStyleBackColor = false;
            this.btn_DetailsTon.Click += new System.EventHandler(this.Btn_DetailsTon_Click);
            // 
            // txb_SumOutput
            // 
            this.txb_SumOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SumOutput.Location = new System.Drawing.Point(0, 273);
            this.txb_SumOutput.Multiline = true;
            this.txb_SumOutput.Name = "txb_SumOutput";
            this.txb_SumOutput.ReadOnly = true;
            this.txb_SumOutput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txb_SumOutput.Size = new System.Drawing.Size(280, 56);
            this.txb_SumOutput.TabIndex = 14;
            this.txb_SumOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_SumInput
            // 
            this.txb_SumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SumInput.Location = new System.Drawing.Point(0, 23);
            this.txb_SumInput.Multiline = true;
            this.txb_SumInput.Name = "txb_SumInput";
            this.txb_SumInput.ReadOnly = true;
            this.txb_SumInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txb_SumInput.Size = new System.Drawing.Size(280, 48);
            this.txb_SumInput.TabIndex = 14;
            this.txb_SumInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_ViewInput
            // 
            this.dgv_ViewInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ViewInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ViewInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisplayNameObject,
            this.Count});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ViewInput.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ViewInput.Location = new System.Drawing.Point(0, 66);
            this.dgv_ViewInput.Name = "dgv_ViewInput";
            this.dgv_ViewInput.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ViewInput.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ViewInput.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_ViewInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ViewInput.Size = new System.Drawing.Size(280, 181);
            this.dgv_ViewInput.TabIndex = 13;
            // 
            // DisplayNameObject
            // 
            this.DisplayNameObject.DataPropertyName = "DisplayNameObject";
            this.DisplayNameObject.HeaderText = "Tên Vật Tư";
            this.DisplayNameObject.Name = "DisplayNameObject";
            this.DisplayNameObject.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Số lượng";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // dtp_Month
            // 
            this.dtp_Month.CustomFormat = "MM";
            this.dtp_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Month.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtp_Month.Location = new System.Drawing.Point(12, 44);
            this.dtp_Month.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_Month.Name = "dtp_Month";
            this.dtp_Month.ShowUpDown = true;
            this.dtp_Month.Size = new System.Drawing.Size(107, 29);
            this.dtp_Month.TabIndex = 2;
            this.dtp_Month.Value = new System.DateTime(2020, 10, 25, 0, 0, 0, 0);
            this.dtp_Month.ValueChanged += new System.EventHandler(this.Dtp_Month_ValueChanged);
            // 
            // cht_Input
            // 
            this.cht_Input.BackColor = System.Drawing.Color.Transparent;
            this.cht_Input.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.cht_Input.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.cht_Input.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.cht_Input.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cht_Input.Legends.Add(legend1);
            this.cht_Input.Location = new System.Drawing.Point(142, 36);
            this.cht_Input.Name = "cht_Input";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cht_Input.Series.Add(series1);
            this.cht_Input.Size = new System.Drawing.Size(450, 213);
            this.cht_Input.TabIndex = 15;
            this.cht_Input.Text = "chart";
            // 
            // cht_Output
            // 
            this.cht_Output.BackColor = System.Drawing.Color.Transparent;
            this.cht_Output.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.cht_Output.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.cht_Output.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.cht_Output.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cht_Output.Legends.Add(legend2);
            this.cht_Output.Location = new System.Drawing.Point(142, 295);
            this.cht_Output.Name = "cht_Output";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cht_Output.Series.Add(series2);
            this.cht_Output.Size = new System.Drawing.Size(450, 213);
            this.cht_Output.TabIndex = 16;
            this.cht_Output.Text = "chart";
            // 
            // btn_Year
            // 
            this.btn_Year.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Year.FlatAppearance.BorderSize = 0;
            this.btn_Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Year.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Year.IconChar = FontAwesome.Sharp.IconChar.Yoast;
            this.btn_Year.IconColor = System.Drawing.Color.White;
            this.btn_Year.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Year.IconSize = 30;
            this.btn_Year.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Year.Location = new System.Drawing.Point(12, 129);
            this.btn_Year.Name = "btn_Year";
            this.btn_Year.Size = new System.Drawing.Size(107, 30);
            this.btn_Year.TabIndex = 17;
            this.btn_Year.Text = "Cả Năm";
            this.btn_Year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Year.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Year.UseVisualStyleBackColor = false;
            this.btn_Year.Click += new System.EventHandler(this.Btn_Year_Click);
            // 
            // lbl_TopInput
            // 
            this.lbl_TopInput.AutoSize = true;
            this.lbl_TopInput.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TopInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TopInput.Location = new System.Drawing.Point(188, 7);
            this.lbl_TopInput.Name = "lbl_TopInput";
            this.lbl_TopInput.Size = new System.Drawing.Size(311, 30);
            this.lbl_TopInput.TabIndex = 18;
            this.lbl_TopInput.Text = "6 Loại hàng nhập nhiều nhất";
            // 
            // lbl_TopOutput
            // 
            this.lbl_TopOutput.AutoSize = true;
            this.lbl_TopOutput.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TopOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TopOutput.Location = new System.Drawing.Point(188, 262);
            this.lbl_TopOutput.Name = "lbl_TopOutput";
            this.lbl_TopOutput.Size = new System.Drawing.Size(305, 30);
            this.lbl_TopOutput.TabIndex = 19;
            this.lbl_TopOutput.Text = "6 Loại hàng xuất nhiều nhất";
            // 
            // dtp_Year
            // 
            this.dtp_Year.CustomFormat = "yyyy";
            this.dtp_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Year.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtp_Year.Location = new System.Drawing.Point(12, 79);
            this.dtp_Year.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_Year.Name = "dtp_Year";
            this.dtp_Year.ShowUpDown = true;
            this.dtp_Year.Size = new System.Drawing.Size(107, 29);
            this.dtp_Year.TabIndex = 2;
            this.dtp_Year.Value = new System.DateTime(2020, 10, 25, 0, 0, 0, 0);
            this.dtp_Year.ValueChanged += new System.EventHandler(this.Dtp_Month_ValueChanged);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(942, 509);
            this.Controls.Add(this.lbl_TopOutput);
            this.Controls.Add(this.lbl_TopInput);
            this.Controls.Add(this.btn_Year);
            this.Controls.Add(this.cht_Output);
            this.Controls.Add(this.cht_Input);
            this.Controls.Add(this.dtp_Year);
            this.Controls.Add(this.dtp_Month);
            this.Controls.Add(this.panel1);
            this.Name = "FormThongKe";
            this.Text = "Form5";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ViewInput;
        private System.Windows.Forms.TextBox txb_SumOutput;
        private System.Windows.Forms.TextBox txb_SumInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayNameObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridView dgv_ViewOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DateTimePicker dtp_Month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Input;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Output;
        private FontAwesome.Sharp.IconButton btn_Year;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_DetailsTon;
        private System.Windows.Forms.Label lbl_TopInput;
        private System.Windows.Forms.Label lbl_TopOutput;
        private System.Windows.Forms.DateTimePicker dtp_Year;
    }
}