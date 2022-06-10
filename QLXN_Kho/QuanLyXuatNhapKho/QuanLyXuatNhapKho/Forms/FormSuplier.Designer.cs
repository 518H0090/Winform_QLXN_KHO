namespace QuanLyXuatNhapKho.Forms
{
    partial class FormSuplier
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
            this.btn_SeacrhSuplier = new FontAwesome.Sharp.IconButton();
            this.txb_SearchSuplier = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.txb_DisplayName = new System.Windows.Forms.TextBox();
            this.pbx_DisplayName = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_DisplayName = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.pbx_Address = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.pbx_Phone = new FontAwesome.Sharp.IconPictureBox();
            this.pnl_ListView = new System.Windows.Forms.Panel();
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.pnl_ADE = new System.Windows.Forms.Panel();
            this.btn_EditSuplier = new FontAwesome.Sharp.IconButton();
            this.btn_AddSuplier = new FontAwesome.Sharp.IconButton();
            this.btn_DeleteSuplier = new FontAwesome.Sharp.IconButton();
            this.pnl_Search = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Phone)).BeginInit();
            this.pnl_ListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.pnl_Info.SuspendLayout();
            this.pnl_ADE.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SeacrhSuplier
            // 
            this.btn_SeacrhSuplier.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_SeacrhSuplier.FlatAppearance.BorderSize = 0;
            this.btn_SeacrhSuplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeacrhSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeacrhSuplier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SeacrhSuplier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_SeacrhSuplier.IconColor = System.Drawing.Color.White;
            this.btn_SeacrhSuplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SeacrhSuplier.IconSize = 30;
            this.btn_SeacrhSuplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhSuplier.Location = new System.Drawing.Point(216, 0);
            this.btn_SeacrhSuplier.Name = "btn_SeacrhSuplier";
            this.btn_SeacrhSuplier.Size = new System.Drawing.Size(91, 31);
            this.btn_SeacrhSuplier.TabIndex = 11;
            this.btn_SeacrhSuplier.Text = "Seacrh";
            this.btn_SeacrhSuplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhSuplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SeacrhSuplier.UseVisualStyleBackColor = false;
            this.btn_SeacrhSuplier.Click += new System.EventHandler(this.Btn_SeacrhSuplier_Click);
            // 
            // txb_SearchSuplier
            // 
            this.txb_SearchSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SearchSuplier.Location = new System.Drawing.Point(17, 0);
            this.txb_SearchSuplier.Multiline = true;
            this.txb_SearchSuplier.Name = "txb_SearchSuplier";
            this.txb_SearchSuplier.Size = new System.Drawing.Size(193, 35);
            this.txb_SearchSuplier.TabIndex = 15;
            this.txb_SearchSuplier.TextChanged += new System.EventHandler(this.Txb_SearchSuplier_TextChanged);
            // 
            // txb_Phone
            // 
            this.txb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Phone.Location = new System.Drawing.Point(667, 60);
            this.txb_Phone.Multiline = true;
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(203, 35);
            this.txb_Phone.TabIndex = 18;
            this.txb_Phone.TextChanged += new System.EventHandler(this.Txb_Phone_TextChanged);
            // 
            // txb_Address
            // 
            this.txb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Address.Location = new System.Drawing.Point(427, 60);
            this.txb_Address.Multiline = true;
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(233, 35);
            this.txb_Address.TabIndex = 19;
            this.txb_Address.TextChanged += new System.EventHandler(this.Txb_Address_TextChanged);
            // 
            // txb_DisplayName
            // 
            this.txb_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DisplayName.Location = new System.Drawing.Point(175, 60);
            this.txb_DisplayName.Multiline = true;
            this.txb_DisplayName.Name = "txb_DisplayName";
            this.txb_DisplayName.Size = new System.Drawing.Size(246, 35);
            this.txb_DisplayName.TabIndex = 20;
            this.txb_DisplayName.TextChanged += new System.EventHandler(this.Txb_DisplayName_TextChanged);
            // 
            // pbx_DisplayName
            // 
            this.pbx_DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_DisplayName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayName.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.pbx_DisplayName.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_DisplayName.IconSize = 37;
            this.pbx_DisplayName.Location = new System.Drawing.Point(175, 20);
            this.pbx_DisplayName.Name = "pbx_DisplayName";
            this.pbx_DisplayName.Size = new System.Drawing.Size(38, 37);
            this.pbx_DisplayName.TabIndex = 21;
            this.pbx_DisplayName.TabStop = false;
            // 
            // lbl_DisplayName
            // 
            this.lbl_DisplayName.AutoSize = true;
            this.lbl_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_DisplayName.Location = new System.Drawing.Point(219, 37);
            this.lbl_DisplayName.Name = "lbl_DisplayName";
            this.lbl_DisplayName.Size = new System.Drawing.Size(139, 17);
            this.lbl_DisplayName.TabIndex = 22;
            this.lbl_DisplayName.Text = "Tên nhà cung cấp";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Address.Location = new System.Drawing.Point(471, 40);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(58, 17);
            this.lbl_Address.TabIndex = 24;
            this.lbl_Address.Text = "Địa chỉ";
            // 
            // pbx_Address
            // 
            this.pbx_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Address.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.pbx_Address.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Address.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Address.IconSize = 37;
            this.pbx_Address.Location = new System.Drawing.Point(427, 20);
            this.pbx_Address.Name = "pbx_Address";
            this.pbx_Address.Size = new System.Drawing.Size(38, 37);
            this.pbx_Address.TabIndex = 23;
            this.pbx_Address.TabStop = false;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Phone.Location = new System.Drawing.Point(706, 37);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(82, 17);
            this.lbl_Phone.TabIndex = 26;
            this.lbl_Phone.Text = "Điện thoại";
            // 
            // pbx_Phone
            // 
            this.pbx_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Phone.IconChar = FontAwesome.Sharp.IconChar.PhoneSquareAlt;
            this.pbx_Phone.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Phone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Phone.IconSize = 37;
            this.pbx_Phone.Location = new System.Drawing.Point(666, 20);
            this.pbx_Phone.Name = "pbx_Phone";
            this.pbx_Phone.Size = new System.Drawing.Size(38, 37);
            this.pbx_Phone.TabIndex = 25;
            this.pbx_Phone.TabStop = false;
            // 
            // pnl_ListView
            // 
            this.pnl_ListView.Controls.Add(this.dgv_View);
            this.pnl_ListView.Location = new System.Drawing.Point(2, 229);
            this.pnl_ListView.Name = "pnl_ListView";
            this.pnl_ListView.Size = new System.Drawing.Size(928, 259);
            this.pnl_ListView.TabIndex = 31;
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
            this.DisplayName,
            this.Address,
            this.Phone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View.Location = new System.Drawing.Point(0, 4);
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
            this.dgv_View.TabIndex = 13;
            this.dgv_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_View_CellClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 101.5228F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.FillWeight = 99.61929F;
            this.DisplayName.HeaderText = "Tên nhà cung cấp";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 99.61929F;
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 99.61929F;
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.lbl_Phone);
            this.pnl_Info.Controls.Add(this.pbx_Phone);
            this.pnl_Info.Controls.Add(this.lbl_Address);
            this.pnl_Info.Controls.Add(this.pbx_Address);
            this.pnl_Info.Controls.Add(this.lbl_DisplayName);
            this.pnl_Info.Controls.Add(this.pbx_DisplayName);
            this.pnl_Info.Controls.Add(this.txb_DisplayName);
            this.pnl_Info.Controls.Add(this.txb_Address);
            this.pnl_Info.Controls.Add(this.txb_Phone);
            this.pnl_Info.Location = new System.Drawing.Point(42, 33);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(886, 98);
            this.pnl_Info.TabIndex = 32;
            // 
            // pnl_ADE
            // 
            this.pnl_ADE.Controls.Add(this.btn_EditSuplier);
            this.pnl_ADE.Controls.Add(this.btn_AddSuplier);
            this.pnl_ADE.Controls.Add(this.btn_DeleteSuplier);
            this.pnl_ADE.Location = new System.Drawing.Point(552, 133);
            this.pnl_ADE.Name = "pnl_ADE";
            this.pnl_ADE.Size = new System.Drawing.Size(376, 43);
            this.pnl_ADE.TabIndex = 31;
            // 
            // btn_EditSuplier
            // 
            this.btn_EditSuplier.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_EditSuplier.FlatAppearance.BorderSize = 0;
            this.btn_EditSuplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditSuplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EditSuplier.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_EditSuplier.IconColor = System.Drawing.Color.White;
            this.btn_EditSuplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EditSuplier.IconSize = 30;
            this.btn_EditSuplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditSuplier.Location = new System.Drawing.Point(104, 3);
            this.btn_EditSuplier.Name = "btn_EditSuplier";
            this.btn_EditSuplier.Size = new System.Drawing.Size(91, 31);
            this.btn_EditSuplier.TabIndex = 13;
            this.btn_EditSuplier.Text = "Sửa";
            this.btn_EditSuplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditSuplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditSuplier.UseVisualStyleBackColor = false;
            this.btn_EditSuplier.Click += new System.EventHandler(this.Btn_EditSuplier_Click);
            // 
            // btn_AddSuplier
            // 
            this.btn_AddSuplier.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_AddSuplier.FlatAppearance.BorderSize = 0;
            this.btn_AddSuplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSuplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddSuplier.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_AddSuplier.IconColor = System.Drawing.Color.White;
            this.btn_AddSuplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddSuplier.IconSize = 30;
            this.btn_AddSuplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddSuplier.Location = new System.Drawing.Point(201, 4);
            this.btn_AddSuplier.Name = "btn_AddSuplier";
            this.btn_AddSuplier.Size = new System.Drawing.Size(91, 31);
            this.btn_AddSuplier.TabIndex = 14;
            this.btn_AddSuplier.Text = "Thêm";
            this.btn_AddSuplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddSuplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddSuplier.UseVisualStyleBackColor = false;
            this.btn_AddSuplier.Click += new System.EventHandler(this.Btn_AddSuplier_Click);
            // 
            // btn_DeleteSuplier
            // 
            this.btn_DeleteSuplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DeleteSuplier.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_DeleteSuplier.FlatAppearance.BorderSize = 0;
            this.btn_DeleteSuplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteSuplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteSuplier.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_DeleteSuplier.IconColor = System.Drawing.Color.White;
            this.btn_DeleteSuplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DeleteSuplier.IconSize = 30;
            this.btn_DeleteSuplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteSuplier.Location = new System.Drawing.Point(7, 4);
            this.btn_DeleteSuplier.Name = "btn_DeleteSuplier";
            this.btn_DeleteSuplier.Size = new System.Drawing.Size(91, 31);
            this.btn_DeleteSuplier.TabIndex = 12;
            this.btn_DeleteSuplier.Text = "Xóa";
            this.btn_DeleteSuplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteSuplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeleteSuplier.UseVisualStyleBackColor = false;
            this.btn_DeleteSuplier.Click += new System.EventHandler(this.Btn_DeleteSuplier_Click);
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.txb_SearchSuplier);
            this.pnl_Search.Controls.Add(this.btn_SeacrhSuplier);
            this.pnl_Search.Location = new System.Drawing.Point(535, 178);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(393, 48);
            this.pnl_Search.TabIndex = 33;
            // 
            // FormSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(942, 509);
            this.Controls.Add(this.pnl_ADE);
            this.Controls.Add(this.pnl_Search);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.pnl_ListView);
            this.Name = "FormSuplier";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Phone)).EndInit();
            this.pnl_ListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            this.pnl_ADE.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_SeacrhSuplier;
        private System.Windows.Forms.TextBox txb_SearchSuplier;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.TextBox txb_DisplayName;
        private FontAwesome.Sharp.IconPictureBox pbx_DisplayName;
        private System.Windows.Forms.Label lbl_DisplayName;
        private System.Windows.Forms.Label lbl_Address;
        private FontAwesome.Sharp.IconPictureBox pbx_Address;
        private System.Windows.Forms.Label lbl_Phone;
        private FontAwesome.Sharp.IconPictureBox pbx_Phone;
        private System.Windows.Forms.Panel pnl_ListView;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Panel pnl_ADE;
        private System.Windows.Forms.Panel pnl_Search;
        private FontAwesome.Sharp.IconButton btn_EditSuplier;
        private FontAwesome.Sharp.IconButton btn_AddSuplier;
        private FontAwesome.Sharp.IconButton btn_DeleteSuplier;
        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}