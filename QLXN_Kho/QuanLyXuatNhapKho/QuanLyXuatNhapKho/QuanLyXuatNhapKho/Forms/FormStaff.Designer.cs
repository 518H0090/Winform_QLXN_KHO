namespace QuanLyXuatNhapKho.Forms
{
    partial class FormStaff
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
            this.txb_Status = new System.Windows.Forms.TextBox();
            this.txb_DisplayName = new System.Windows.Forms.TextBox();
            this.txb_SeacrhUser = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_DisplayName = new System.Windows.Forms.Label();
            this.pbx_Status = new FontAwesome.Sharp.IconPictureBox();
            this.pbx_DisplayName = new FontAwesome.Sharp.IconPictureBox();
            this.btn_AddStaff = new FontAwesome.Sharp.IconButton();
            this.btn_EditStaff = new FontAwesome.Sharp.IconButton();
            this.btn_LockAcc = new FontAwesome.Sharp.IconButton();
            this.btn_SeacrhStaff = new FontAwesome.Sharp.IconButton();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.pbx_UserName = new FontAwesome.Sharp.IconPictureBox();
            this.pnl_ADE = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Seacrh = new System.Windows.Forms.Panel();
            this.pnl_ListView = new System.Windows.Forms.Panel();
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_RecoveryPass = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayName)).BeginInit();
            this.pnl_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UserName)).BeginInit();
            this.pnl_ADE.SuspendLayout();
            this.pnl_Seacrh.SuspendLayout();
            this.pnl_ListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Status
            // 
            this.txb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Status.Location = new System.Drawing.Point(719, 45);
            this.txb_Status.Multiline = true;
            this.txb_Status.Name = "txb_Status";
            this.txb_Status.ReadOnly = true;
            this.txb_Status.Size = new System.Drawing.Size(101, 31);
            this.txb_Status.TabIndex = 76;
            this.txb_Status.TextChanged += new System.EventHandler(this.Txb_Status_TextChanged);
            // 
            // txb_DisplayName
            // 
            this.txb_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DisplayName.Location = new System.Drawing.Point(492, 46);
            this.txb_DisplayName.Multiline = true;
            this.txb_DisplayName.Name = "txb_DisplayName";
            this.txb_DisplayName.Size = new System.Drawing.Size(221, 31);
            this.txb_DisplayName.TabIndex = 74;
            this.txb_DisplayName.TextChanged += new System.EventHandler(this.Txb_DisplayName_TextChanged);
            // 
            // txb_SeacrhUser
            // 
            this.txb_SeacrhUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SeacrhUser.Location = new System.Drawing.Point(3, 0);
            this.txb_SeacrhUser.Multiline = true;
            this.txb_SeacrhUser.Name = "txb_SeacrhUser";
            this.txb_SeacrhUser.Size = new System.Drawing.Size(209, 31);
            this.txb_SeacrhUser.TabIndex = 73;
            this.txb_SeacrhUser.TextChanged += new System.EventHandler(this.Tbx_SeacrhStaff_TextChanged);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Status.Location = new System.Drawing.Point(762, 19);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(54, 17);
            this.lbl_Status.TabIndex = 68;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_DisplayName
            // 
            this.lbl_DisplayName.AutoSize = true;
            this.lbl_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_DisplayName.Location = new System.Drawing.Point(531, 23);
            this.lbl_DisplayName.Name = "lbl_DisplayName";
            this.lbl_DisplayName.Size = new System.Drawing.Size(61, 17);
            this.lbl_DisplayName.TabIndex = 64;
            this.lbl_DisplayName.Text = "Họ Tên";
            // 
            // pbx_Status
            // 
            this.pbx_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Status.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.pbx_Status.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Status.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Status.IconSize = 37;
            this.pbx_Status.Location = new System.Drawing.Point(717, 4);
            this.pbx_Status.Name = "pbx_Status";
            this.pbx_Status.Size = new System.Drawing.Size(38, 37);
            this.pbx_Status.TabIndex = 67;
            this.pbx_Status.TabStop = false;
            // 
            // pbx_DisplayName
            // 
            this.pbx_DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_DisplayName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayName.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pbx_DisplayName.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_DisplayName.IconSize = 37;
            this.pbx_DisplayName.Location = new System.Drawing.Point(492, 4);
            this.pbx_DisplayName.Name = "pbx_DisplayName";
            this.pbx_DisplayName.Size = new System.Drawing.Size(38, 37);
            this.pbx_DisplayName.TabIndex = 63;
            this.pbx_DisplayName.TabStop = false;
            // 
            // btn_AddStaff
            // 
            this.btn_AddStaff.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_AddStaff.FlatAppearance.BorderSize = 0;
            this.btn_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddStaff.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_AddStaff.IconColor = System.Drawing.Color.White;
            this.btn_AddStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddStaff.IconSize = 30;
            this.btn_AddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddStaff.Location = new System.Drawing.Point(446, 2);
            this.btn_AddStaff.Name = "btn_AddStaff";
            this.btn_AddStaff.Size = new System.Drawing.Size(91, 31);
            this.btn_AddStaff.TabIndex = 62;
            this.btn_AddStaff.Text = "Thêm";
            this.btn_AddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddStaff.UseVisualStyleBackColor = false;
            this.btn_AddStaff.Click += new System.EventHandler(this.Btn_AddSuplier_Click);
            // 
            // btn_EditStaff
            // 
            this.btn_EditStaff.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_EditStaff.FlatAppearance.BorderSize = 0;
            this.btn_EditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EditStaff.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_EditStaff.IconColor = System.Drawing.Color.White;
            this.btn_EditStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EditStaff.IconSize = 30;
            this.btn_EditStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditStaff.Location = new System.Drawing.Point(349, 2);
            this.btn_EditStaff.Name = "btn_EditStaff";
            this.btn_EditStaff.Size = new System.Drawing.Size(91, 31);
            this.btn_EditStaff.TabIndex = 61;
            this.btn_EditStaff.Text = "Sửa";
            this.btn_EditStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditStaff.UseVisualStyleBackColor = false;
            this.btn_EditStaff.Click += new System.EventHandler(this.Btn_EditStaff_Click);
            // 
            // btn_LockAcc
            // 
            this.btn_LockAcc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_LockAcc.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_LockAcc.FlatAppearance.BorderSize = 0;
            this.btn_LockAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LockAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LockAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LockAcc.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btn_LockAcc.IconColor = System.Drawing.Color.White;
            this.btn_LockAcc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_LockAcc.IconSize = 30;
            this.btn_LockAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LockAcc.Location = new System.Drawing.Point(201, 2);
            this.btn_LockAcc.Name = "btn_LockAcc";
            this.btn_LockAcc.Size = new System.Drawing.Size(142, 31);
            this.btn_LockAcc.TabIndex = 60;
            this.btn_LockAcc.Text = "Khóa/Mở Khóa";
            this.btn_LockAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LockAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LockAcc.UseVisualStyleBackColor = false;
            this.btn_LockAcc.Click += new System.EventHandler(this.Btn_LockAcc_Click);
            // 
            // btn_SeacrhStaff
            // 
            this.btn_SeacrhStaff.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_SeacrhStaff.FlatAppearance.BorderSize = 0;
            this.btn_SeacrhStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeacrhStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeacrhStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SeacrhStaff.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_SeacrhStaff.IconColor = System.Drawing.Color.White;
            this.btn_SeacrhStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SeacrhStaff.IconSize = 30;
            this.btn_SeacrhStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhStaff.Location = new System.Drawing.Point(222, 2);
            this.btn_SeacrhStaff.Name = "btn_SeacrhStaff";
            this.btn_SeacrhStaff.Size = new System.Drawing.Size(91, 31);
            this.btn_SeacrhStaff.TabIndex = 59;
            this.btn_SeacrhStaff.Text = "Seacrh";
            this.btn_SeacrhStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SeacrhStaff.UseVisualStyleBackColor = false;
            this.btn_SeacrhStaff.Click += new System.EventHandler(this.Btn_SeacrhStaff_Click);
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.txb_UserName);
            this.pnl_Info.Controls.Add(this.lbl_UserName);
            this.pnl_Info.Controls.Add(this.pbx_UserName);
            this.pnl_Info.Controls.Add(this.txb_Status);
            this.pnl_Info.Controls.Add(this.txb_DisplayName);
            this.pnl_Info.Controls.Add(this.lbl_Status);
            this.pnl_Info.Controls.Add(this.pbx_Status);
            this.pnl_Info.Controls.Add(this.lbl_DisplayName);
            this.pnl_Info.Controls.Add(this.pbx_DisplayName);
            this.pnl_Info.Location = new System.Drawing.Point(0, 46);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(941, 79);
            this.pnl_Info.TabIndex = 85;
            // 
            // txb_UserName
            // 
            this.txb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_UserName.Location = new System.Drawing.Point(276, 48);
            this.txb_UserName.Multiline = true;
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(210, 31);
            this.txb_UserName.TabIndex = 87;
            this.txb_UserName.TextChanged += new System.EventHandler(this.Txb_UserName_TextChanged);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_UserName.Location = new System.Drawing.Point(323, 24);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(42, 17);
            this.lbl_UserName.TabIndex = 86;
            this.lbl_UserName.Text = "User";
            // 
            // pbx_UserName
            // 
            this.pbx_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_UserName.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.pbx_UserName.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_UserName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_UserName.IconSize = 37;
            this.pbx_UserName.Location = new System.Drawing.Point(279, 3);
            this.pbx_UserName.Name = "pbx_UserName";
            this.pbx_UserName.Size = new System.Drawing.Size(38, 37);
            this.pbx_UserName.TabIndex = 85;
            this.pbx_UserName.TabStop = false;
            // 
            // pnl_ADE
            // 
            this.pnl_ADE.Controls.Add(this.btn_RecoveryPass);
            this.pnl_ADE.Controls.Add(this.panel1);
            this.pnl_ADE.Controls.Add(this.btn_AddStaff);
            this.pnl_ADE.Controls.Add(this.btn_EditStaff);
            this.pnl_ADE.Controls.Add(this.btn_LockAcc);
            this.pnl_ADE.Location = new System.Drawing.Point(319, 129);
            this.pnl_ADE.Name = "pnl_ADE";
            this.pnl_ADE.Size = new System.Drawing.Size(610, 43);
            this.pnl_ADE.TabIndex = 86;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(81, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 43);
            this.panel1.TabIndex = 63;
            // 
            // pnl_Seacrh
            // 
            this.pnl_Seacrh.Controls.Add(this.txb_SeacrhUser);
            this.pnl_Seacrh.Controls.Add(this.btn_SeacrhStaff);
            this.pnl_Seacrh.Location = new System.Drawing.Point(543, 178);
            this.pnl_Seacrh.Name = "pnl_Seacrh";
            this.pnl_Seacrh.Size = new System.Drawing.Size(386, 44);
            this.pnl_Seacrh.TabIndex = 64;
            // 
            // pnl_ListView
            // 
            this.pnl_ListView.Controls.Add(this.dgv_View);
            this.pnl_ListView.Location = new System.Drawing.Point(7, 228);
            this.pnl_ListView.Name = "pnl_ListView";
            this.pnl_ListView.Size = new System.Drawing.Size(923, 260);
            this.pnl_ListView.TabIndex = 87;
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
            this.Id,
            this.UserName,
            this.DisplayName,
            this.Status,
            this.Role});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View.Location = new System.Drawing.Point(-1, 3);
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
            this.dgv_View.TabIndex = 14;
            this.dgv_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_View_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 101.5228F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 99.61929F;
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.FillWeight = 99.61929F;
            this.DisplayName.HeaderText = "Họ tên";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Chức danh";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // btn_RecoveryPass
            // 
            this.btn_RecoveryPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_RecoveryPass.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_RecoveryPass.FlatAppearance.BorderSize = 0;
            this.btn_RecoveryPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RecoveryPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecoveryPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_RecoveryPass.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btn_RecoveryPass.IconColor = System.Drawing.Color.White;
            this.btn_RecoveryPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RecoveryPass.IconSize = 30;
            this.btn_RecoveryPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RecoveryPass.Location = new System.Drawing.Point(52, 2);
            this.btn_RecoveryPass.Name = "btn_RecoveryPass";
            this.btn_RecoveryPass.Size = new System.Drawing.Size(143, 31);
            this.btn_RecoveryPass.TabIndex = 64;
            this.btn_RecoveryPass.Text = "Khôi phục pass";
            this.btn_RecoveryPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RecoveryPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RecoveryPass.UseVisualStyleBackColor = false;
            this.btn_RecoveryPass.Click += new System.EventHandler(this.Btn_RecoveryPass_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(942, 509);
            this.Controls.Add(this.pnl_ListView);
            this.Controls.Add(this.pnl_Seacrh);
            this.Controls.Add(this.pnl_ADE);
            this.Controls.Add(this.pnl_Info);
            this.Name = "FormStaff";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayName)).EndInit();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UserName)).EndInit();
            this.pnl_ADE.ResumeLayout(false);
            this.pnl_Seacrh.ResumeLayout(false);
            this.pnl_Seacrh.PerformLayout();
            this.pnl_ListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txb_Status;
        private System.Windows.Forms.TextBox txb_DisplayName;
        private System.Windows.Forms.TextBox txb_SeacrhUser;
        private System.Windows.Forms.Label lbl_Status;
        private FontAwesome.Sharp.IconPictureBox pbx_Status;
        private System.Windows.Forms.Label lbl_DisplayName;
        private FontAwesome.Sharp.IconPictureBox pbx_DisplayName;
        private FontAwesome.Sharp.IconButton btn_AddStaff;
        private FontAwesome.Sharp.IconButton btn_EditStaff;
        private FontAwesome.Sharp.IconButton btn_LockAcc;
        private FontAwesome.Sharp.IconButton btn_SeacrhStaff;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Panel pnl_ADE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Seacrh;
        private System.Windows.Forms.Panel pnl_ListView;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label lbl_UserName;
        private FontAwesome.Sharp.IconPictureBox pbx_UserName;
        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private FontAwesome.Sharp.IconButton btn_RecoveryPass;
    }
}