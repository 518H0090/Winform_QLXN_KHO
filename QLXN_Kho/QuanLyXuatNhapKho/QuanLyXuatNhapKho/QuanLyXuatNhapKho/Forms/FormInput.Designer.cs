namespace QuanLyXuatNhapKho.Forms
{
    partial class FormInput
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
            this.lbl_DisplayNameUSer = new System.Windows.Forms.Label();
            this.pbx_DsiplayNameUser = new FontAwesome.Sharp.IconPictureBox();
            this.txb_DisplayNameUser = new System.Windows.Forms.TextBox();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.btn_AddInput = new FontAwesome.Sharp.IconButton();
            this.btn_EditInput = new FontAwesome.Sharp.IconButton();
            this.btn_DeleteInput = new FontAwesome.Sharp.IconButton();
            this.btn_Seacrh = new FontAwesome.Sharp.IconButton();
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.IdInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInputInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayNameObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_Object = new FontAwesome.Sharp.IconPictureBox();
            this.pbx_DisplayaName = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_DateInput = new System.Windows.Forms.Label();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_InputPrice = new System.Windows.Forms.NumericUpDown();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_Cout = new System.Windows.Forms.NumericUpDown();
            this.txb_DisplayNameObject = new System.Windows.Forms.TextBox();
            this.txb_InputDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DsiplayNameUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Object)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayaName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_InputPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cout)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DisplayNameUSer
            // 
            this.lbl_DisplayNameUSer.AutoSize = true;
            this.lbl_DisplayNameUSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayNameUSer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_DisplayNameUSer.Location = new System.Drawing.Point(700, 57);
            this.lbl_DisplayNameUSer.Name = "lbl_DisplayNameUSer";
            this.lbl_DisplayNameUSer.Size = new System.Drawing.Size(77, 17);
            this.lbl_DisplayNameUSer.TabIndex = 51;
            this.lbl_DisplayNameUSer.Text = "Người lập";
            // 
            // pbx_DsiplayNameUser
            // 
            this.pbx_DsiplayNameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_DsiplayNameUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DsiplayNameUser.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.pbx_DsiplayNameUser.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DsiplayNameUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_DsiplayNameUser.IconSize = 37;
            this.pbx_DsiplayNameUser.Location = new System.Drawing.Point(656, 43);
            this.pbx_DsiplayNameUser.Name = "pbx_DsiplayNameUser";
            this.pbx_DsiplayNameUser.Size = new System.Drawing.Size(38, 37);
            this.pbx_DsiplayNameUser.TabIndex = 50;
            this.pbx_DsiplayNameUser.TabStop = false;
            // 
            // txb_DisplayNameUser
            // 
            this.txb_DisplayNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DisplayNameUser.Location = new System.Drawing.Point(656, 80);
            this.txb_DisplayNameUser.Multiline = true;
            this.txb_DisplayNameUser.Name = "txb_DisplayNameUser";
            this.txb_DisplayNameUser.ReadOnly = true;
            this.txb_DisplayNameUser.Size = new System.Drawing.Size(234, 35);
            this.txb_DisplayNameUser.TabIndex = 37;
            this.txb_DisplayNameUser.TextChanged += new System.EventHandler(this.Txb_DisplayNameUser_TextChanged);
            // 
            // txb_Search
            // 
            this.txb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Search.Location = new System.Drawing.Point(544, 174);
            this.txb_Search.Multiline = true;
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(193, 35);
            this.txb_Search.TabIndex = 36;
            this.txb_Search.TextChanged += new System.EventHandler(this.Txb_SearchSuplier_TextChanged);
            // 
            // btn_AddInput
            // 
            this.btn_AddInput.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_AddInput.FlatAppearance.BorderSize = 0;
            this.btn_AddInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddInput.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_AddInput.IconColor = System.Drawing.Color.White;
            this.btn_AddInput.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddInput.IconSize = 30;
            this.btn_AddInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddInput.Location = new System.Drawing.Point(743, 121);
            this.btn_AddInput.Name = "btn_AddInput";
            this.btn_AddInput.Size = new System.Drawing.Size(116, 31);
            this.btn_AddInput.TabIndex = 35;
            this.btn_AddInput.Text = "Lập phiếu";
            this.btn_AddInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddInput.UseVisualStyleBackColor = false;
            this.btn_AddInput.Click += new System.EventHandler(this.Btn_AddSuplier_Click);
            // 
            // btn_EditInput
            // 
            this.btn_EditInput.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_EditInput.FlatAppearance.BorderSize = 0;
            this.btn_EditInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EditInput.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_EditInput.IconColor = System.Drawing.Color.White;
            this.btn_EditInput.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EditInput.IconSize = 30;
            this.btn_EditInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditInput.Location = new System.Drawing.Point(646, 121);
            this.btn_EditInput.Name = "btn_EditInput";
            this.btn_EditInput.Size = new System.Drawing.Size(91, 31);
            this.btn_EditInput.TabIndex = 34;
            this.btn_EditInput.Text = "Sửa";
            this.btn_EditInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditInput.UseVisualStyleBackColor = false;
            this.btn_EditInput.Click += new System.EventHandler(this.Btn_EditInput_Click);
            // 
            // btn_DeleteInput
            // 
            this.btn_DeleteInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DeleteInput.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_DeleteInput.FlatAppearance.BorderSize = 0;
            this.btn_DeleteInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteInput.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_DeleteInput.IconColor = System.Drawing.Color.White;
            this.btn_DeleteInput.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DeleteInput.IconSize = 30;
            this.btn_DeleteInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteInput.Location = new System.Drawing.Point(549, 121);
            this.btn_DeleteInput.Name = "btn_DeleteInput";
            this.btn_DeleteInput.Size = new System.Drawing.Size(91, 31);
            this.btn_DeleteInput.TabIndex = 33;
            this.btn_DeleteInput.Text = "Xóa";
            this.btn_DeleteInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeleteInput.UseVisualStyleBackColor = false;
            this.btn_DeleteInput.Click += new System.EventHandler(this.Btn_DeleteInput_Click);
            // 
            // btn_Seacrh
            // 
            this.btn_Seacrh.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Seacrh.FlatAppearance.BorderSize = 0;
            this.btn_Seacrh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Seacrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Seacrh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Seacrh.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Seacrh.IconColor = System.Drawing.Color.White;
            this.btn_Seacrh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Seacrh.IconSize = 30;
            this.btn_Seacrh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Seacrh.Location = new System.Drawing.Point(743, 174);
            this.btn_Seacrh.Name = "btn_Seacrh";
            this.btn_Seacrh.Size = new System.Drawing.Size(91, 31);
            this.btn_Seacrh.TabIndex = 32;
            this.btn_Seacrh.Text = "Seacrh";
            this.btn_Seacrh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Seacrh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Seacrh.UseVisualStyleBackColor = false;
            this.btn_Seacrh.Click += new System.EventHandler(this.Btn_Seacrh_Click);
            // 
            // dgv_View
            // 
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
            this.IdInput,
            this.IdInputInfo,
            this.DisplayNameObject,
            this.DateInput,
            this.Cout,
            this.InputPrice,
            this.DisplayNameUser});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View.Location = new System.Drawing.Point(5, 242);
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
            this.dgv_View.Size = new System.Drawing.Size(925, 255);
            this.dgv_View.TabIndex = 52;
            this.dgv_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_View_CellClick_1);
            // 
            // IdInput
            // 
            this.IdInput.DataPropertyName = "IdInput";
            this.IdInput.FillWeight = 101.5228F;
            this.IdInput.HeaderText = "Id Phiếu Nhập";
            this.IdInput.Name = "IdInput";
            this.IdInput.ReadOnly = true;
            // 
            // IdInputInfo
            // 
            this.IdInputInfo.DataPropertyName = "IdInputInfo";
            this.IdInputInfo.HeaderText = "Id";
            this.IdInputInfo.Name = "IdInputInfo";
            this.IdInputInfo.ReadOnly = true;
            this.IdInputInfo.Visible = false;
            // 
            // DisplayNameObject
            // 
            this.DisplayNameObject.DataPropertyName = "DisplayNameObject";
            this.DisplayNameObject.FillWeight = 99.61929F;
            this.DisplayNameObject.HeaderText = "Tên mặt hàng";
            this.DisplayNameObject.Name = "DisplayNameObject";
            this.DisplayNameObject.ReadOnly = true;
            // 
            // DateInput
            // 
            this.DateInput.DataPropertyName = "DateInput";
            this.DateInput.FillWeight = 99.61929F;
            this.DateInput.HeaderText = "Ngày Nhập";
            this.DateInput.Name = "DateInput";
            this.DateInput.ReadOnly = true;
            // 
            // Cout
            // 
            this.Cout.DataPropertyName = "Count";
            this.Cout.FillWeight = 99.61929F;
            this.Cout.HeaderText = "Số lượng";
            this.Cout.Name = "Cout";
            this.Cout.ReadOnly = true;
            // 
            // InputPrice
            // 
            this.InputPrice.DataPropertyName = "InputPrice";
            this.InputPrice.HeaderText = "Giá ";
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.ReadOnly = true;
            // 
            // DisplayNameUser
            // 
            this.DisplayNameUser.DataPropertyName = "DisplayNameUser";
            this.DisplayNameUser.HeaderText = "Người lập";
            this.DisplayNameUser.Name = "DisplayNameUser";
            this.DisplayNameUser.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(65, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tên hàng";
            // 
            // pbx_Object
            // 
            this.pbx_Object.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Object.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Object.IconChar = FontAwesome.Sharp.IconChar.HockeyPuck;
            this.pbx_Object.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Object.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Object.IconSize = 37;
            this.pbx_Object.Location = new System.Drawing.Point(21, 45);
            this.pbx_Object.Name = "pbx_Object";
            this.pbx_Object.Size = new System.Drawing.Size(38, 37);
            this.pbx_Object.TabIndex = 59;
            this.pbx_Object.TabStop = false;
            // 
            // pbx_DisplayaName
            // 
            this.pbx_DisplayaName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_DisplayaName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayaName.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.pbx_DisplayaName.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayaName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_DisplayaName.Location = new System.Drawing.Point(234, 48);
            this.pbx_DisplayaName.Name = "pbx_DisplayaName";
            this.pbx_DisplayaName.Size = new System.Drawing.Size(32, 32);
            this.pbx_DisplayaName.TabIndex = 64;
            this.pbx_DisplayaName.TabStop = false;
            // 
            // lbl_DateInput
            // 
            this.lbl_DateInput.AutoSize = true;
            this.lbl_DateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_DateInput.Location = new System.Drawing.Point(272, 57);
            this.lbl_DateInput.Name = "lbl_DateInput";
            this.lbl_DateInput.Size = new System.Drawing.Size(77, 17);
            this.lbl_DateInput.TabIndex = 63;
            this.lbl_DateInput.Text = "Ngày nhập";
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.Location = new System.Drawing.Point(549, 45);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 71;
            this.iconPictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(590, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Giá";
            // 
            // nud_InputPrice
            // 
            this.nud_InputPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_InputPrice.Location = new System.Drawing.Point(549, 80);
            this.nud_InputPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_InputPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_InputPrice.Name = "nud_InputPrice";
            this.nud_InputPrice.Size = new System.Drawing.Size(101, 20);
            this.nud_InputPrice.TabIndex = 69;
            this.nud_InputPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(441, 48);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 68;
            this.iconPictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(479, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Số lượng";
            // 
            // nud_Cout
            // 
            this.nud_Cout.Location = new System.Drawing.Point(441, 80);
            this.nud_Cout.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_Cout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Cout.Name = "nud_Cout";
            this.nud_Cout.Size = new System.Drawing.Size(102, 20);
            this.nud_Cout.TabIndex = 66;
            this.nud_Cout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txb_DisplayNameObject
            // 
            this.txb_DisplayNameObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DisplayNameObject.Location = new System.Drawing.Point(21, 83);
            this.txb_DisplayNameObject.Multiline = true;
            this.txb_DisplayNameObject.Name = "txb_DisplayNameObject";
            this.txb_DisplayNameObject.ReadOnly = true;
            this.txb_DisplayNameObject.Size = new System.Drawing.Size(207, 35);
            this.txb_DisplayNameObject.TabIndex = 37;
            // 
            // txb_InputDate
            // 
            this.txb_InputDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_InputDate.Location = new System.Drawing.Point(234, 83);
            this.txb_InputDate.Multiline = true;
            this.txb_InputDate.Name = "txb_InputDate";
            this.txb_InputDate.ReadOnly = true;
            this.txb_InputDate.Size = new System.Drawing.Size(201, 35);
            this.txb_InputDate.TabIndex = 37;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(942, 509);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_InputPrice);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_Cout);
            this.Controls.Add(this.pbx_DisplayaName);
            this.Controls.Add(this.lbl_DateInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbx_Object);
            this.Controls.Add(this.dgv_View);
            this.Controls.Add(this.lbl_DisplayNameUSer);
            this.Controls.Add(this.pbx_DsiplayNameUser);
            this.Controls.Add(this.txb_InputDate);
            this.Controls.Add(this.txb_DisplayNameObject);
            this.Controls.Add(this.txb_DisplayNameUser);
            this.Controls.Add(this.txb_Search);
            this.Controls.Add(this.btn_AddInput);
            this.Controls.Add(this.btn_EditInput);
            this.Controls.Add(this.btn_DeleteInput);
            this.Controls.Add(this.btn_Seacrh);
            this.Name = "FormInput";
            this.Text = "FormInput";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DsiplayNameUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Object)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayaName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_InputPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DisplayNameUSer;
        private FontAwesome.Sharp.IconPictureBox pbx_DsiplayNameUser;
        private System.Windows.Forms.TextBox txb_DisplayNameUser;
        private System.Windows.Forms.TextBox txb_Search;
        private FontAwesome.Sharp.IconButton btn_AddInput;
        private FontAwesome.Sharp.IconButton btn_EditInput;
        private FontAwesome.Sharp.IconButton btn_DeleteInput;
        private FontAwesome.Sharp.IconButton btn_Seacrh;
        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox pbx_Object;
        private FontAwesome.Sharp.IconPictureBox pbx_DisplayaName;
        private System.Windows.Forms.Label lbl_DateInput;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_InputPrice;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_Cout;
        private System.Windows.Forms.TextBox txb_DisplayNameObject;
        private System.Windows.Forms.TextBox txb_InputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInputInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayNameObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cout;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayNameUser;
    }
}