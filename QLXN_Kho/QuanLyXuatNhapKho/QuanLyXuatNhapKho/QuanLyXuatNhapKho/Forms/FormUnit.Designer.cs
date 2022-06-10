namespace QuanLyXuatNhapKho.Forms
{
    partial class FormUnit
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
            this.txb_DisplayName = new System.Windows.Forms.TextBox();
            this.txb_SearchUnit = new System.Windows.Forms.TextBox();
            this.btn_SeacrhUnit = new FontAwesome.Sharp.IconButton();
            this.btn_DeleteUnit = new FontAwesome.Sharp.IconButton();
            this.btn_EditUnit = new FontAwesome.Sharp.IconButton();
            this.btn_AddUnit = new FontAwesome.Sharp.IconButton();
            this.lbl_DisplayName = new System.Windows.Forms.Label();
            this.pnl_ListView = new System.Windows.Forms.Panel();
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.pbx_DisplayaName = new FontAwesome.Sharp.IconPictureBox();
            this.pnl_Seacrh = new System.Windows.Forms.Panel();
            this.pnl_ADE = new System.Windows.Forms.Panel();
            this.pnl_ListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.pnl_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayaName)).BeginInit();
            this.pnl_Seacrh.SuspendLayout();
            this.pnl_ADE.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_DisplayName
            // 
            this.txb_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DisplayName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txb_DisplayName.Location = new System.Drawing.Point(166, 50);
            this.txb_DisplayName.Multiline = true;
            this.txb_DisplayName.Name = "txb_DisplayName";
            this.txb_DisplayName.Size = new System.Drawing.Size(203, 30);
            this.txb_DisplayName.TabIndex = 1;
            this.txb_DisplayName.TextChanged += new System.EventHandler(this.Txb_DisplayName_TextChanged);
            // 
            // txb_SearchUnit
            // 
            this.txb_SearchUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SearchUnit.Location = new System.Drawing.Point(84, 4);
            this.txb_SearchUnit.Multiline = true;
            this.txb_SearchUnit.Name = "txb_SearchUnit";
            this.txb_SearchUnit.Size = new System.Drawing.Size(188, 31);
            this.txb_SearchUnit.TabIndex = 2;
            this.txb_SearchUnit.TextChanged += new System.EventHandler(this.Txb_SearchUnit_TextChanged);
            // 
            // btn_SeacrhUnit
            // 
            this.btn_SeacrhUnit.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_SeacrhUnit.FlatAppearance.BorderSize = 0;
            this.btn_SeacrhUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeacrhUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeacrhUnit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SeacrhUnit.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_SeacrhUnit.IconColor = System.Drawing.Color.White;
            this.btn_SeacrhUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SeacrhUnit.IconSize = 30;
            this.btn_SeacrhUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhUnit.Location = new System.Drawing.Point(278, 4);
            this.btn_SeacrhUnit.Name = "btn_SeacrhUnit";
            this.btn_SeacrhUnit.Size = new System.Drawing.Size(91, 31);
            this.btn_SeacrhUnit.TabIndex = 3;
            this.btn_SeacrhUnit.Text = "Seacrh";
            this.btn_SeacrhUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SeacrhUnit.UseVisualStyleBackColor = false;
            this.btn_SeacrhUnit.Click += new System.EventHandler(this.Btn_SeacrhUnit_Click);
            // 
            // btn_DeleteUnit
            // 
            this.btn_DeleteUnit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DeleteUnit.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_DeleteUnit.FlatAppearance.BorderSize = 0;
            this.btn_DeleteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteUnit.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_DeleteUnit.IconColor = System.Drawing.Color.White;
            this.btn_DeleteUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DeleteUnit.IconSize = 30;
            this.btn_DeleteUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteUnit.Location = new System.Drawing.Point(86, 0);
            this.btn_DeleteUnit.Name = "btn_DeleteUnit";
            this.btn_DeleteUnit.Size = new System.Drawing.Size(91, 31);
            this.btn_DeleteUnit.TabIndex = 4;
            this.btn_DeleteUnit.Text = "Xóa";
            this.btn_DeleteUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeleteUnit.UseVisualStyleBackColor = false;
            this.btn_DeleteUnit.Click += new System.EventHandler(this.Btn_DeleteUnit_Click);
            // 
            // btn_EditUnit
            // 
            this.btn_EditUnit.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_EditUnit.FlatAppearance.BorderSize = 0;
            this.btn_EditUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EditUnit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_EditUnit.IconColor = System.Drawing.Color.White;
            this.btn_EditUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EditUnit.IconSize = 30;
            this.btn_EditUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditUnit.Location = new System.Drawing.Point(183, 0);
            this.btn_EditUnit.Name = "btn_EditUnit";
            this.btn_EditUnit.Size = new System.Drawing.Size(91, 31);
            this.btn_EditUnit.TabIndex = 5;
            this.btn_EditUnit.Text = "Sửa";
            this.btn_EditUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditUnit.UseVisualStyleBackColor = false;
            this.btn_EditUnit.Click += new System.EventHandler(this.Btn_EditUnit_Click);
            // 
            // btn_AddUnit
            // 
            this.btn_AddUnit.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_AddUnit.FlatAppearance.BorderSize = 0;
            this.btn_AddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddUnit.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_AddUnit.IconColor = System.Drawing.Color.White;
            this.btn_AddUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddUnit.IconSize = 30;
            this.btn_AddUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddUnit.Location = new System.Drawing.Point(280, 0);
            this.btn_AddUnit.Name = "btn_AddUnit";
            this.btn_AddUnit.Size = new System.Drawing.Size(91, 31);
            this.btn_AddUnit.TabIndex = 6;
            this.btn_AddUnit.Text = "Thêm";
            this.btn_AddUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddUnit.UseVisualStyleBackColor = false;
            this.btn_AddUnit.Click += new System.EventHandler(this.Btn_AddUnit_Click);
            // 
            // lbl_DisplayName
            // 
            this.lbl_DisplayName.AutoSize = true;
            this.lbl_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayName.Location = new System.Drawing.Point(207, 18);
            this.lbl_DisplayName.Name = "lbl_DisplayName";
            this.lbl_DisplayName.Size = new System.Drawing.Size(79, 17);
            this.lbl_DisplayName.TabIndex = 7;
            this.lbl_DisplayName.Text = "Tên Đơn Vị";
            // 
            // pnl_ListView
            // 
            this.pnl_ListView.Controls.Add(this.dgv_View);
            this.pnl_ListView.Location = new System.Drawing.Point(226, 243);
            this.pnl_ListView.Name = "pnl_ListView";
            this.pnl_ListView.Size = new System.Drawing.Size(380, 255);
            this.pnl_ListView.TabIndex = 8;
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
            this.DisplayName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View.Location = new System.Drawing.Point(86, -7);
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
            this.dgv_View.Size = new System.Drawing.Size(241, 255);
            this.dgv_View.TabIndex = 12;
            this.dgv_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_View_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Tên đơn vị ";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.pbx_DisplayaName);
            this.pnl_Info.Controls.Add(this.lbl_DisplayName);
            this.pnl_Info.Controls.Add(this.txb_DisplayName);
            this.pnl_Info.Location = new System.Drawing.Point(228, 39);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(378, 83);
            this.pnl_Info.TabIndex = 9;
            // 
            // pbx_DisplayaName
            // 
            this.pbx_DisplayaName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_DisplayaName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayaName.IconChar = FontAwesome.Sharp.IconChar.RulerVertical;
            this.pbx_DisplayaName.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayaName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_DisplayaName.Location = new System.Drawing.Point(166, 3);
            this.pbx_DisplayaName.Name = "pbx_DisplayaName";
            this.pbx_DisplayaName.Size = new System.Drawing.Size(32, 32);
            this.pbx_DisplayaName.TabIndex = 8;
            this.pbx_DisplayaName.TabStop = false;
            // 
            // pnl_Seacrh
            // 
            this.pnl_Seacrh.Controls.Add(this.btn_SeacrhUnit);
            this.pnl_Seacrh.Controls.Add(this.txb_SearchUnit);
            this.pnl_Seacrh.Location = new System.Drawing.Point(228, 195);
            this.pnl_Seacrh.Name = "pnl_Seacrh";
            this.pnl_Seacrh.Size = new System.Drawing.Size(379, 42);
            this.pnl_Seacrh.TabIndex = 10;
            // 
            // pnl_ADE
            // 
            this.pnl_ADE.Controls.Add(this.btn_AddUnit);
            this.pnl_ADE.Controls.Add(this.btn_EditUnit);
            this.pnl_ADE.Controls.Add(this.btn_DeleteUnit);
            this.pnl_ADE.Location = new System.Drawing.Point(226, 133);
            this.pnl_ADE.Name = "pnl_ADE";
            this.pnl_ADE.Size = new System.Drawing.Size(380, 52);
            this.pnl_ADE.TabIndex = 11;
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(942, 509);
            this.Controls.Add(this.pnl_ADE);
            this.Controls.Add(this.pnl_Seacrh);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.pnl_ListView);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FormUnit";
            this.Text = "Form3";
            this.pnl_ListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayaName)).EndInit();
            this.pnl_Seacrh.ResumeLayout(false);
            this.pnl_Seacrh.PerformLayout();
            this.pnl_ADE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txb_DisplayName;
        private System.Windows.Forms.TextBox txb_SearchUnit;
        private FontAwesome.Sharp.IconButton btn_SeacrhUnit;
        private FontAwesome.Sharp.IconButton btn_DeleteUnit;
        private FontAwesome.Sharp.IconButton btn_EditUnit;
        private FontAwesome.Sharp.IconButton btn_AddUnit;
        private System.Windows.Forms.Label lbl_DisplayName;
        private System.Windows.Forms.Panel pnl_ListView;
        private System.Windows.Forms.Panel pnl_Info;
        private FontAwesome.Sharp.IconPictureBox pbx_DisplayaName;
        private System.Windows.Forms.Panel pnl_Seacrh;
        private System.Windows.Forms.Panel pnl_ADE;
        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
    }
}