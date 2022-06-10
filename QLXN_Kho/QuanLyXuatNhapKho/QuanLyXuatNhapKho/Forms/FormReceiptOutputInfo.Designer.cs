namespace QuanLyXuatNhapKho.Forms
{
    partial class FormReceiptOutputInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceiptOutputInfo));
            this.label5 = new System.Windows.Forms.Label();
            this.nud_OutputPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_Count = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_DisplayNameObject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_DisplayNameUser = new System.Windows.Forms.TextBox();
            this.dtp_DateOutput = new System.Windows.Forms.DateTimePicker();
            this.btn_DeleteObjectToList = new System.Windows.Forms.Button();
            this.btn_AddOjectToList = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_LapPhieu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SumPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InputPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DateInput = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pbx_DisplayaName = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OutputPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayaName)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(409, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Giá";
            // 
            // nud_OutputPrice
            // 
            this.nud_OutputPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_OutputPrice.Location = new System.Drawing.Point(371, 119);
            this.nud_OutputPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_OutputPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_OutputPrice.Name = "nud_OutputPrice";
            this.nud_OutputPrice.Size = new System.Drawing.Size(146, 20);
            this.nud_OutputPrice.TabIndex = 63;
            this.nud_OutputPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(301, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Số lượng";
            // 
            // nud_Count
            // 
            this.nud_Count.Location = new System.Drawing.Point(266, 119);
            this.nud_Count.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Count.Name = "nud_Count";
            this.nud_Count.Size = new System.Drawing.Size(82, 20);
            this.nud_Count.TabIndex = 60;
            this.nud_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(49, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tên hàng";
            // 
            // cmb_DisplayNameObject
            // 
            this.cmb_DisplayNameObject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_DisplayNameObject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_DisplayNameObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DisplayNameObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DisplayNameObject.FormattingEnabled = true;
            this.cmb_DisplayNameObject.Location = new System.Drawing.Point(9, 119);
            this.cmb_DisplayNameObject.Name = "cmb_DisplayNameObject";
            this.cmb_DisplayNameObject.Size = new System.Drawing.Size(237, 26);
            this.cmb_DisplayNameObject.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(343, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Người lập phiếu";
            // 
            // txb_DisplayNameUser
            // 
            this.txb_DisplayNameUser.Location = new System.Drawing.Point(304, 41);
            this.txb_DisplayNameUser.Multiline = true;
            this.txb_DisplayNameUser.Name = "txb_DisplayNameUser";
            this.txb_DisplayNameUser.ReadOnly = true;
            this.txb_DisplayNameUser.Size = new System.Drawing.Size(213, 23);
            this.txb_DisplayNameUser.TabIndex = 11;
            // 
            // dtp_DateOutput
            // 
            this.dtp_DateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateOutput.Location = new System.Drawing.Point(40, 41);
            this.dtp_DateOutput.Name = "dtp_DateOutput";
            this.dtp_DateOutput.Size = new System.Drawing.Size(204, 23);
            this.dtp_DateOutput.TabIndex = 0;
            this.dtp_DateOutput.Value = new System.DateTime(2020, 12, 30, 19, 5, 31, 0);
            // 
            // btn_DeleteObjectToList
            // 
            this.btn_DeleteObjectToList.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_DeleteObjectToList.FlatAppearance.BorderSize = 0;
            this.btn_DeleteObjectToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteObjectToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteObjectToList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_DeleteObjectToList.Location = new System.Drawing.Point(158, 3);
            this.btn_DeleteObjectToList.Name = "btn_DeleteObjectToList";
            this.btn_DeleteObjectToList.Size = new System.Drawing.Size(176, 43);
            this.btn_DeleteObjectToList.TabIndex = 5;
            this.btn_DeleteObjectToList.Text = "Xóa ";
            this.btn_DeleteObjectToList.UseVisualStyleBackColor = false;
            this.btn_DeleteObjectToList.Click += new System.EventHandler(this.Btn_DeleteObjectToList_Click);
            // 
            // btn_AddOjectToList
            // 
            this.btn_AddOjectToList.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_AddOjectToList.FlatAppearance.BorderSize = 0;
            this.btn_AddOjectToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddOjectToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOjectToList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddOjectToList.Location = new System.Drawing.Point(340, 4);
            this.btn_AddOjectToList.Name = "btn_AddOjectToList";
            this.btn_AddOjectToList.Size = new System.Drawing.Size(191, 43);
            this.btn_AddOjectToList.TabIndex = 4;
            this.btn_AddOjectToList.Text = "Thêm";
            this.btn_AddOjectToList.UseVisualStyleBackColor = false;
            this.btn_AddOjectToList.Click += new System.EventHandler(this.Btn_AddOjectToList_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_DeleteObjectToList);
            this.panel4.Controls.Add(this.btn_AddOjectToList);
            this.panel4.Location = new System.Drawing.Point(7, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 50);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Xuất Kho";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconPictureBox5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 103);
            this.panel3.TabIndex = 7;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 67;
            this.iconPictureBox5.Location = new System.Drawing.Point(400, 27);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(106, 67);
            this.iconPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox5.TabIndex = 1;
            this.iconPictureBox5.TabStop = false;
            // 
            // btn_LapPhieu
            // 
            this.btn_LapPhieu.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_LapPhieu.FlatAppearance.BorderSize = 0;
            this.btn_LapPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LapPhieu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_LapPhieu.Location = new System.Drawing.Point(3, 3);
            this.btn_LapPhieu.Name = "btn_LapPhieu";
            this.btn_LapPhieu.Size = new System.Drawing.Size(246, 70);
            this.btn_LapPhieu.TabIndex = 3;
            this.btn_LapPhieu.Text = "Lập Phiếu";
            this.btn_LapPhieu.UseVisualStyleBackColor = false;
            this.btn_LapPhieu.Click += new System.EventHandler(this.Btn_LapPhieu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(250, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng tiền";
            // 
            // txt_SumPrice
            // 
            this.txt_SumPrice.BackColor = System.Drawing.Color.White;
            this.txt_SumPrice.Font = new System.Drawing.Font("Garamond", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SumPrice.Location = new System.Drawing.Point(374, 3);
            this.txt_SumPrice.Multiline = true;
            this.txt_SumPrice.Name = "txt_SumPrice";
            this.txt_SumPrice.ReadOnly = true;
            this.txt_SumPrice.Size = new System.Drawing.Size(160, 46);
            this.txt_SumPrice.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_LapPhieu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_SumPrice);
            this.panel2.Location = new System.Drawing.Point(1, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 123);
            this.panel2.TabIndex = 6;
            // 
            // InputPrice
            // 
            this.InputPrice.DataPropertyName = "InputPrice";
            this.InputPrice.FillWeight = 99.61929F;
            this.InputPrice.HeaderText = "Giá nhập";
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.ReadOnly = true;
            // 
            // Cout
            // 
            this.Cout.DataPropertyName = "Cout";
            this.Cout.FillWeight = 99.61929F;
            this.Cout.HeaderText = "Số lượng";
            this.Cout.Name = "Cout";
            this.Cout.ReadOnly = true;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayNameOject";
            this.DisplayName.FillWeight = 99.61929F;
            this.DisplayName.HeaderText = "Tên hàng";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // dgv_View
            // 
            this.dgv_View.AllowUserToAddRows = false;
            this.dgv_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisplayName,
            this.Cout,
            this.InputPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View.Location = new System.Drawing.Point(0, 9);
            this.dgv_View.Name = "dgv_View";
            this.dgv_View.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_View.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_View.Size = new System.Drawing.Size(534, 243);
            this.dgv_View.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_View);
            this.panel1.Location = new System.Drawing.Point(4, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 255);
            this.panel1.TabIndex = 5;
            // 
            // lbl_DateInput
            // 
            this.lbl_DateInput.AutoSize = true;
            this.lbl_DateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_DateInput.Location = new System.Drawing.Point(72, 21);
            this.lbl_DateInput.Name = "lbl_DateInput";
            this.lbl_DateInput.Size = new System.Drawing.Size(74, 17);
            this.lbl_DateInput.TabIndex = 9;
            this.lbl_DateInput.Text = "Ngày Xuất";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconPictureBox4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.nud_OutputPrice);
            this.panel5.Controls.Add(this.iconPictureBox3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.nud_Count);
            this.panel5.Controls.Add(this.iconPictureBox2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cmb_DisplayNameObject);
            this.panel5.Controls.Add(this.iconPictureBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txb_DisplayNameUser);
            this.panel5.Controls.Add(this.pbx_DisplayaName);
            this.panel5.Controls.Add(this.lbl_DateInput);
            this.panel5.Controls.Add(this.dtp_DateOutput);
            this.panel5.Location = new System.Drawing.Point(4, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(537, 155);
            this.panel5.TabIndex = 9;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.Location = new System.Drawing.Point(371, 84);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 65;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(263, 81);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 62;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.HockeyPuck;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(11, 81);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 59;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(302, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
            // 
            // pbx_DisplayaName
            // 
            this.pbx_DisplayaName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_DisplayaName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayaName.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.pbx_DisplayaName.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayaName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_DisplayaName.Location = new System.Drawing.Point(31, 6);
            this.pbx_DisplayaName.Name = "pbx_DisplayaName";
            this.pbx_DisplayaName.Size = new System.Drawing.Size(32, 32);
            this.pbx_DisplayaName.TabIndex = 10;
            this.pbx_DisplayaName.TabStop = false;
            // 
            // FormReceiptOutputInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(543, 713);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReceiptOutputInfo";
            this.Text = "FLập phiếu xuất";
            ((System.ComponentModel.ISupportInitialize)(this.nud_OutputPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayaName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_OutputPrice;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_Count;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_DisplayNameObject;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_DisplayNameUser;
        private FontAwesome.Sharp.IconPictureBox pbx_DisplayaName;
        private System.Windows.Forms.DateTimePicker dtp_DateOutput;
        private System.Windows.Forms.Button btn_DeleteObjectToList;
        private System.Windows.Forms.Button btn_AddOjectToList;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_LapPhieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SumPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cout;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_DateInput;
        private System.Windows.Forms.Panel panel5;
    }
}