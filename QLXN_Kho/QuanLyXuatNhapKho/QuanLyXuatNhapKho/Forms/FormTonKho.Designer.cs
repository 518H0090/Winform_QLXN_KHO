namespace QuanLyXuatNhapKho.Forms
{
    partial class FormTonKho
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
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.DisplayNameObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayNameUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayNameSuplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SeacrhTonKho = new FontAwesome.Sharp.IconButton();
            this.txb_SearchTonkho = new System.Windows.Forms.TextBox();
            this.cmb_SearchTonKho = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.SuspendLayout();
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
            this.DisplayNameObject,
            this.DisplayNameUnit,
            this.DisplayNameSuplier,
            this.CountTon});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View.Location = new System.Drawing.Point(12, 128);
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
            this.dgv_View.Size = new System.Drawing.Size(785, 310);
            this.dgv_View.TabIndex = 53;
            // 
            // DisplayNameObject
            // 
            this.DisplayNameObject.DataPropertyName = "DisplayNameObject";
            this.DisplayNameObject.FillWeight = 99.61929F;
            this.DisplayNameObject.HeaderText = "Tên mặt hàng";
            this.DisplayNameObject.Name = "DisplayNameObject";
            this.DisplayNameObject.ReadOnly = true;
            // 
            // DisplayNameUnit
            // 
            this.DisplayNameUnit.DataPropertyName = "DisplayNameUnit";
            this.DisplayNameUnit.HeaderText = "Đơn vị tính";
            this.DisplayNameUnit.Name = "DisplayNameUnit";
            this.DisplayNameUnit.ReadOnly = true;
            // 
            // DisplayNameSuplier
            // 
            this.DisplayNameSuplier.DataPropertyName = "DisplayNameSuplier";
            this.DisplayNameSuplier.HeaderText = "Nhà cung cấp";
            this.DisplayNameSuplier.Name = "DisplayNameSuplier";
            this.DisplayNameSuplier.ReadOnly = true;
            // 
            // CountTon
            // 
            this.CountTon.DataPropertyName = "CountTon";
            this.CountTon.HeaderText = "Số lượng tồn";
            this.CountTon.Name = "CountTon";
            this.CountTon.ReadOnly = true;
            // 
            // btn_SeacrhTonKho
            // 
            this.btn_SeacrhTonKho.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_SeacrhTonKho.FlatAppearance.BorderSize = 0;
            this.btn_SeacrhTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeacrhTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeacrhTonKho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SeacrhTonKho.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_SeacrhTonKho.IconColor = System.Drawing.Color.White;
            this.btn_SeacrhTonKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SeacrhTonKho.IconSize = 30;
            this.btn_SeacrhTonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhTonKho.Location = new System.Drawing.Point(592, 58);
            this.btn_SeacrhTonKho.Name = "btn_SeacrhTonKho";
            this.btn_SeacrhTonKho.Size = new System.Drawing.Size(91, 31);
            this.btn_SeacrhTonKho.TabIndex = 55;
            this.btn_SeacrhTonKho.Text = "Seacrh";
            this.btn_SeacrhTonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeacrhTonKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SeacrhTonKho.UseVisualStyleBackColor = false;
            this.btn_SeacrhTonKho.Click += new System.EventHandler(this.Btn_SeacrhTonKho_Click);
            // 
            // txb_SearchTonkho
            // 
            this.txb_SearchTonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SearchTonkho.Location = new System.Drawing.Point(398, 58);
            this.txb_SearchTonkho.Multiline = true;
            this.txb_SearchTonkho.Name = "txb_SearchTonkho";
            this.txb_SearchTonkho.Size = new System.Drawing.Size(188, 31);
            this.txb_SearchTonkho.TabIndex = 54;
            this.txb_SearchTonkho.TextChanged += new System.EventHandler(this.Txb_SearchTonkho_TextChanged);
            // 
            // cmb_SearchTonKho
            // 
            this.cmb_SearchTonKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchTonKho.FormattingEnabled = true;
            this.cmb_SearchTonKho.Items.AddRange(new object[] {
            "Tên hàng",
            "Đơn vị tính",
            "Nhà cung cấp"});
            this.cmb_SearchTonKho.Location = new System.Drawing.Point(271, 60);
            this.cmb_SearchTonKho.Name = "cmb_SearchTonKho";
            this.cmb_SearchTonKho.Size = new System.Drawing.Size(121, 24);
            this.cmb_SearchTonKho.TabIndex = 56;
            // 
            // FormTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_SearchTonKho);
            this.Controls.Add(this.btn_SeacrhTonKho);
            this.Controls.Add(this.txb_SearchTonkho);
            this.Controls.Add(this.dgv_View);
            this.Name = "FormTonKho";
            this.Text = "FormTonKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayNameObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayNameUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayNameSuplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountTon;
        private FontAwesome.Sharp.IconButton btn_SeacrhTonKho;
        private System.Windows.Forms.TextBox txb_SearchTonkho;
        private System.Windows.Forms.ComboBox cmb_SearchTonKho;
    }
}