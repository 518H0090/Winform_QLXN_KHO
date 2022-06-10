namespace QuanLyXuatNhapKho.Forms
{
    partial class FormObject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Suplier = new System.Windows.Forms.Label();
            this.pbx_Suplier = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.pbx_Unit = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_DisplayName = new System.Windows.Forms.Label();
            this.pbx_Object = new FontAwesome.Sharp.IconPictureBox();
            this.btn_AddObject = new FontAwesome.Sharp.IconButton();
            this.btn_EditObject = new FontAwesome.Sharp.IconButton();
            this.btn_DeleteObject = new FontAwesome.Sharp.IconButton();
            this.btn_SeacrhObject = new FontAwesome.Sharp.IconButton();
            this.txb_DisplayName = new System.Windows.Forms.TextBox();
            this.cmb_Unit = new System.Windows.Forms.ComboBox();
            this.cmb_Suplier = new System.Windows.Forms.ComboBox();
            this.pnl_ListView = new System.Windows.Forms.Panel();
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayNameUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayNameSuplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_ADE = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_Seacrh = new System.Windows.Forms.Panel();
            this.pnl_Infro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Suplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Object)).BeginInit();
            this.pnl_ListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.pnl_ADE.SuspendLayout();
            this.pnl_Seacrh.SuspendLayout();
            this.pnl_Infro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Suplier
            // 
            this.lbl_Suplier.AutoSize = true;
            this.lbl_Suplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Suplier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Suplier.Location = new System.Drawing.Point(484, 27);
            this.lbl_Suplier.Name = "lbl_Suplier";
            this.lbl_Suplier.Size = new System.Drawing.Size(108, 17);
            this.lbl_Suplier.TabIndex = 49;
            this.lbl_Suplier.Text = "Nhà cung cấp";
            // 
            // pbx_Suplier
            // 
            this.pbx_Suplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Suplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Suplier.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.pbx_Suplier.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Suplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Suplier.IconSize = 37;
            this.pbx_Suplier.Location = new System.Drawing.Point(440, 4);
            this.pbx_Suplier.Name = "pbx_Suplier";
            this.pbx_Suplier.Size = new System.Drawing.Size(38, 37);
            this.pbx_Suplier.TabIndex = 48;
            this.pbx_Suplier.TabStop = false;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Unit.Location = new System.Drawing.Point(325, 27);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(54, 17);
            this.lbl_Unit.TabIndex = 47;
            this.lbl_Unit.Text = "Đơn vị";
            // 
            // pbx_Unit
            // 
            this.pbx_Unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Unit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Unit.IconChar = FontAwesome.Sharp.IconChar.RulerVertical;
            this.pbx_Unit.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Unit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Unit.IconSize = 37;
            this.pbx_Unit.Location = new System.Drawing.Point(281, 7);
            this.pbx_Unit.Name = "pbx_Unit";
            this.pbx_Unit.Size = new System.Drawing.Size(38, 37);
            this.pbx_Unit.TabIndex = 46;
            this.pbx_Unit.TabStop = false;
            // 
            // lbl_DisplayName
            // 
            this.lbl_DisplayName.AutoSize = true;
            this.lbl_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_DisplayName.Location = new System.Drawing.Point(153, 24);
            this.lbl_DisplayName.Name = "lbl_DisplayName";
            this.lbl_DisplayName.Size = new System.Drawing.Size(77, 17);
            this.lbl_DisplayName.TabIndex = 45;
            this.lbl_DisplayName.Text = "Tên hàng";
            // 
            // pbx_Object
            // 
            this.pbx_Object.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Object.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Object.IconChar = FontAwesome.Sharp.IconChar.HockeyPuck;
            this.pbx_Object.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Object.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Object.IconSize = 37;
            this.pbx_Object.Location = new System.Drawing.Point(120, 7);
            this.pbx_Object.Name = "pbx_Object";
            this.pbx_Object.Size = new System.Drawing.Size(38, 37);
            this.pbx_Object.TabIndex = 44;
            this.pbx_Object.TabStop = false;
            // 
            // btn_AddObject
            // 
            this.btn_AddObject.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_AddObject.FlatAppearance.BorderSize = 0;
            this.btn_AddObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddObject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddObject.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_AddObject.IconColor = System.Drawing.Color.White;
            this.btn_AddObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddObject.IconSize = 30;
            this.btn_AddObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddObject.Location = new System.Drawing.Point(239, 8);
            this.btn_AddObject.Name = "btn_AddObject";
            this.btn_AddObject.Size = new System.Drawing.Size(91, 31);
            this.btn_AddObject.TabIndex = 35;
            this.btn_AddObject.Text = "Thêm";
            this.btn_AddObject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddObject.UseVisualStyleBackColor = false;
            this.btn_AddObject.Click += new System.EventHandler(this.Btn_AddObject_Click);
            // 
            // btn_EditObject
            // 
            this.btn_EditObject.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_EditObject.FlatAppearance.BorderSize = 0;
            this.btn_EditObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditObject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EditObject.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_EditObject.IconColor = System.Drawing.Color.White;
            this.btn_EditObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EditObject.IconSize = 30;
            this.btn_EditObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditObject.Location = new System.Drawing.Point(142, 8);
            this.btn_EditObject.Name = "btn_EditObject";
            this.btn_EditObject.Size = new System.Drawing.Size(91, 31);
            this.btn_EditObject.TabIndex = 34;
            this.btn_EditObject.Text = "Sửa";
            this.btn_EditObject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditObject.UseVisualStyleBackColor = false;
            this.btn_EditObject.Click += new System.EventHandler(this.Btn_EditObject_Click);
            // 
            // btn_DeleteObject
            // 
            this.btn_DeleteObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DeleteObject.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_DeleteObject.FlatAppearance.BorderSize = 0;
            this.btn_DeleteObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteObject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteObject.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_DeleteObject.IconColor = System.Drawing.Color.White;
            this.btn_DeleteObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DeleteObject.IconSize = 30;
            this.btn_DeleteObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteObject.Location = new System.Drawing.Point(45, 8);
            this.btn_DeleteObject.Name = "btn_DeleteObject";
            this.btn_DeleteObject.Size = new System.Drawing.Size(91, 31);
            this.btn_DeleteObject.TabIndex = 33;
            this.btn_DeleteObject.Text = "Xóa";
            this.btn_DeleteObject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeleteObject.UseVisualStyleBackColor = false;
            this.btn_DeleteObject.Click += new System.EventHandler(this.Btn_DeleteObject_Click);
            // 
            // btn_SeacrhObject
            // 
            this.btn_SeacrhObject.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_SeacrhObject.FlatAppearance.BorderSize = 0;
            this.btn_SeacrhObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeacrhObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeacrhObject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SeacrhObject.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_SeacrhObject.IconColor = System.Drawing.Color.White;
            this.btn_SeacrhObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SeacrhObject.IconSize = 30;
            this.btn_SeacrhObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhObject.Location = new System.Drawing.Point(234, 17);
            this.btn_SeacrhObject.Name = "btn_SeacrhObject";
            this.btn_SeacrhObject.Size = new System.Drawing.Size(91, 31);
            this.btn_SeacrhObject.TabIndex = 32;
            this.btn_SeacrhObject.Text = "Seacrh";
            this.btn_SeacrhObject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SeacrhObject.UseVisualStyleBackColor = false;
            this.btn_SeacrhObject.Click += new System.EventHandler(this.Btn_SeacrhObject_Click);
            // 
            // txb_DisplayName
            // 
            this.txb_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DisplayName.Location = new System.Drawing.Point(120, 47);
            this.txb_DisplayName.Multiline = true;
            this.txb_DisplayName.Name = "txb_DisplayName";
            this.txb_DisplayName.Size = new System.Drawing.Size(158, 31);
            this.txb_DisplayName.TabIndex = 55;
            this.txb_DisplayName.TextChanged += new System.EventHandler(this.Txb_DisplayName_TextChanged);
            // 
            // cmb_Unit
            // 
            this.cmb_Unit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Unit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unit.FormattingEnabled = true;
            this.cmb_Unit.Location = new System.Drawing.Point(284, 47);
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(150, 26);
            this.cmb_Unit.TabIndex = 56;
            // 
            // cmb_Suplier
            // 
            this.cmb_Suplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Suplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Suplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Suplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Suplier.FormattingEnabled = true;
            this.cmb_Suplier.Location = new System.Drawing.Point(440, 47);
            this.cmb_Suplier.Name = "cmb_Suplier";
            this.cmb_Suplier.Size = new System.Drawing.Size(215, 26);
            this.cmb_Suplier.TabIndex = 57;
            // 
            // pnl_ListView
            // 
            this.pnl_ListView.Controls.Add(this.dgv_View);
            this.pnl_ListView.Location = new System.Drawing.Point(195, 225);
            this.pnl_ListView.Name = "pnl_ListView";
            this.pnl_ListView.Size = new System.Drawing.Size(661, 262);
            this.pnl_ListView.TabIndex = 59;
            // 
            // dgv_View
            // 
            this.dgv_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DisplayName,
            this.DisplayNameUnit,
            this.DisplayNameSuplier});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_View.Location = new System.Drawing.Point(3, 7);
            this.dgv_View.Name = "dgv_View";
            this.dgv_View.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_View.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_View.Size = new System.Drawing.Size(655, 255);
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
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.FillWeight = 99.61929F;
            this.DisplayName.HeaderText = "Tên hàng";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // DisplayNameUnit
            // 
            this.DisplayNameUnit.DataPropertyName = "DisplayNameUnit";
            this.DisplayNameUnit.FillWeight = 99.61929F;
            this.DisplayNameUnit.HeaderText = "Đơn vị tính";
            this.DisplayNameUnit.Name = "DisplayNameUnit";
            this.DisplayNameUnit.ReadOnly = true;
            // 
            // DisplayNameSuplier
            // 
            this.DisplayNameSuplier.DataPropertyName = "DisplayNameSuplier";
            this.DisplayNameSuplier.FillWeight = 99.61929F;
            this.DisplayNameSuplier.HeaderText = "Nhà cung cấp";
            this.DisplayNameSuplier.Name = "DisplayNameSuplier";
            this.DisplayNameSuplier.ReadOnly = true;
            // 
            // pnl_ADE
            // 
            this.pnl_ADE.Controls.Add(this.btn_AddObject);
            this.pnl_ADE.Controls.Add(this.btn_EditObject);
            this.pnl_ADE.Controls.Add(this.btn_DeleteObject);
            this.pnl_ADE.Location = new System.Drawing.Point(526, 123);
            this.pnl_ADE.Name = "pnl_ADE";
            this.pnl_ADE.Size = new System.Drawing.Size(374, 47);
            this.pnl_ADE.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 31);
            this.textBox1.TabIndex = 58;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // pnl_Seacrh
            // 
            this.pnl_Seacrh.Controls.Add(this.textBox1);
            this.pnl_Seacrh.Controls.Add(this.btn_SeacrhObject);
            this.pnl_Seacrh.Location = new System.Drawing.Point(527, 176);
            this.pnl_Seacrh.Name = "pnl_Seacrh";
            this.pnl_Seacrh.Size = new System.Drawing.Size(373, 57);
            this.pnl_Seacrh.TabIndex = 61;
            // 
            // pnl_Infro
            // 
            this.pnl_Infro.Controls.Add(this.cmb_Suplier);
            this.pnl_Infro.Controls.Add(this.cmb_Unit);
            this.pnl_Infro.Controls.Add(this.txb_DisplayName);
            this.pnl_Infro.Controls.Add(this.lbl_Suplier);
            this.pnl_Infro.Controls.Add(this.pbx_Suplier);
            this.pnl_Infro.Controls.Add(this.lbl_Unit);
            this.pnl_Infro.Controls.Add(this.pbx_Unit);
            this.pnl_Infro.Controls.Add(this.lbl_DisplayName);
            this.pnl_Infro.Controls.Add(this.pbx_Object);
            this.pnl_Infro.Location = new System.Drawing.Point(198, 27);
            this.pnl_Infro.Name = "pnl_Infro";
            this.pnl_Infro.Size = new System.Drawing.Size(658, 86);
            this.pnl_Infro.TabIndex = 62;
            // 
            // FormObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(942, 509);
            this.Controls.Add(this.pnl_Infro);
            this.Controls.Add(this.pnl_Seacrh);
            this.Controls.Add(this.pnl_ADE);
            this.Controls.Add(this.pnl_ListView);
            this.Name = "FormObject";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Suplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Object)).EndInit();
            this.pnl_ListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.pnl_ADE.ResumeLayout(false);
            this.pnl_Seacrh.ResumeLayout(false);
            this.pnl_Seacrh.PerformLayout();
            this.pnl_Infro.ResumeLayout(false);
            this.pnl_Infro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Suplier;
        private FontAwesome.Sharp.IconPictureBox pbx_Suplier;
        private System.Windows.Forms.Label lbl_Unit;
        private FontAwesome.Sharp.IconPictureBox pbx_Unit;
        private System.Windows.Forms.Label lbl_DisplayName;
        private FontAwesome.Sharp.IconPictureBox pbx_Object;
        private FontAwesome.Sharp.IconButton btn_AddObject;
        private FontAwesome.Sharp.IconButton btn_EditObject;
        private FontAwesome.Sharp.IconButton btn_DeleteObject;
        private FontAwesome.Sharp.IconButton btn_SeacrhObject;
        private System.Windows.Forms.TextBox txb_DisplayName;
        private System.Windows.Forms.ComboBox cmb_Unit;
        private System.Windows.Forms.ComboBox cmb_Suplier;
        private System.Windows.Forms.Panel pnl_ListView;
        private System.Windows.Forms.Panel pnl_ADE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnl_Seacrh;
        private System.Windows.Forms.Panel pnl_Infro;
        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayNameUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayNameSuplier;
    }
}