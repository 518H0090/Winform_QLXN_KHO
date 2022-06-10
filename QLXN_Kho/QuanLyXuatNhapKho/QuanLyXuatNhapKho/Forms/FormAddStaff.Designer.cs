namespace QuanLyXuatNhapKho.Forms
{
    partial class FormAddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddStaff));
            this.pbx_DisplayName = new FontAwesome.Sharp.IconPictureBox();
            this.txb_DisplayName = new System.Windows.Forms.TextBox();
            this.lbl_DisplayName = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.pbx_Password1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.pbx_UserName = new FontAwesome.Sharp.IconPictureBox();
            this.txb_Password2 = new System.Windows.Forms.TextBox();
            this.lbl_Password2 = new System.Windows.Forms.Label();
            this.pxb_Password1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_Infro = new System.Windows.Forms.Panel();
            this.lbl_AddStaff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Password1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_Password1)).BeginInit();
            this.pnl_Infro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbx_DisplayName
            // 
            this.pbx_DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_DisplayName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayName.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pbx_DisplayName.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_DisplayName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_DisplayName.IconSize = 38;
            this.pbx_DisplayName.Location = new System.Drawing.Point(17, 175);
            this.pbx_DisplayName.Name = "pbx_DisplayName";
            this.pbx_DisplayName.Size = new System.Drawing.Size(38, 39);
            this.pbx_DisplayName.TabIndex = 97;
            this.pbx_DisplayName.TabStop = false;
            // 
            // txb_DisplayName
            // 
            this.txb_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DisplayName.Location = new System.Drawing.Point(61, 195);
            this.txb_DisplayName.Multiline = true;
            this.txb_DisplayName.Name = "txb_DisplayName";
            this.txb_DisplayName.Size = new System.Drawing.Size(170, 31);
            this.txb_DisplayName.TabIndex = 4;
            this.txb_DisplayName.TextChanged += new System.EventHandler(this.Txb_DisplayName_TextChanged);
            // 
            // lbl_DisplayName
            // 
            this.lbl_DisplayName.AutoSize = true;
            this.lbl_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_DisplayName.Location = new System.Drawing.Point(61, 175);
            this.lbl_DisplayName.Name = "lbl_DisplayName";
            this.lbl_DisplayName.Size = new System.Drawing.Size(56, 17);
            this.lbl_DisplayName.TabIndex = 86;
            this.lbl_DisplayName.Text = "Họ tên";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Password.Location = new System.Drawing.Point(61, 85);
            this.txb_Password.Multiline = true;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(170, 31);
            this.txb_Password.TabIndex = 2;
            this.txb_Password.TextChanged += new System.EventHandler(this.Txb_Password_TextChanged);
            // 
            // txb_UserName
            // 
            this.txb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_UserName.Location = new System.Drawing.Point(61, 31);
            this.txb_UserName.Multiline = true;
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(171, 31);
            this.txb_UserName.TabIndex = 1;
            this.txb_UserName.TextChanged += new System.EventHandler(this.Txb_UserName_TextChanged);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Password.Location = new System.Drawing.Point(61, 65);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(77, 17);
            this.lbl_Password.TabIndex = 107;
            this.lbl_Password.Text = "Password";
            // 
            // pbx_Password1
            // 
            this.pbx_Password1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Password1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Password1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.pbx_Password1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_Password1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Password1.IconSize = 37;
            this.pbx_Password1.Location = new System.Drawing.Point(18, 65);
            this.pbx_Password1.Name = "pbx_Password1";
            this.pbx_Password1.Size = new System.Drawing.Size(38, 37);
            this.pbx_Password1.TabIndex = 106;
            this.pbx_Password1.TabStop = false;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_UserName.Location = new System.Drawing.Point(61, 11);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(118, 17);
            this.lbl_UserName.TabIndex = 105;
            this.lbl_UserName.Text = "Tên đăng nhập";
            // 
            // pbx_UserName
            // 
            this.pbx_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_UserName.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.pbx_UserName.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbx_UserName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_UserName.IconSize = 37;
            this.pbx_UserName.Location = new System.Drawing.Point(17, 11);
            this.pbx_UserName.Name = "pbx_UserName";
            this.pbx_UserName.Size = new System.Drawing.Size(38, 37);
            this.pbx_UserName.TabIndex = 104;
            this.pbx_UserName.TabStop = false;
            // 
            // txb_Password2
            // 
            this.txb_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Password2.Location = new System.Drawing.Point(61, 142);
            this.txb_Password2.Multiline = true;
            this.txb_Password2.Name = "txb_Password2";
            this.txb_Password2.PasswordChar = '*';
            this.txb_Password2.Size = new System.Drawing.Size(170, 31);
            this.txb_Password2.TabIndex = 3;
            this.txb_Password2.TextChanged += new System.EventHandler(this.Txb_Password2_TextChanged);
            // 
            // lbl_Password2
            // 
            this.lbl_Password2.AutoSize = true;
            this.lbl_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Password2.Location = new System.Drawing.Point(62, 119);
            this.lbl_Password2.Name = "lbl_Password2";
            this.lbl_Password2.Size = new System.Drawing.Size(141, 17);
            this.lbl_Password2.TabIndex = 111;
            this.lbl_Password2.Text = "Nhập lại password";
            // 
            // pxb_Password1
            // 
            this.pxb_Password1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pxb_Password1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pxb_Password1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.pxb_Password1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pxb_Password1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pxb_Password1.IconSize = 37;
            this.pxb_Password1.Location = new System.Drawing.Point(18, 119);
            this.pxb_Password1.Name = "pxb_Password1";
            this.pxb_Password1.Size = new System.Drawing.Size(38, 37);
            this.pxb_Password1.TabIndex = 110;
            this.pxb_Password1.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(55, 232);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(176, 49);
            this.btn_Add.TabIndex = 113;
            this.btn_Add.Text = "Tạo";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // pnl_Infro
            // 
            this.pnl_Infro.Controls.Add(this.btn_Add);
            this.pnl_Infro.Controls.Add(this.txb_Password2);
            this.pnl_Infro.Controls.Add(this.lbl_Password2);
            this.pnl_Infro.Controls.Add(this.pxb_Password1);
            this.pnl_Infro.Controls.Add(this.txb_Password);
            this.pnl_Infro.Controls.Add(this.txb_UserName);
            this.pnl_Infro.Controls.Add(this.lbl_Password);
            this.pnl_Infro.Controls.Add(this.pbx_Password1);
            this.pnl_Infro.Controls.Add(this.lbl_UserName);
            this.pnl_Infro.Controls.Add(this.pbx_UserName);
            this.pnl_Infro.Controls.Add(this.pbx_DisplayName);
            this.pnl_Infro.Controls.Add(this.txb_DisplayName);
            this.pnl_Infro.Controls.Add(this.lbl_DisplayName);
            this.pnl_Infro.Location = new System.Drawing.Point(29, 64);
            this.pnl_Infro.Name = "pnl_Infro";
            this.pnl_Infro.Size = new System.Drawing.Size(250, 292);
            this.pnl_Infro.TabIndex = 114;
            // 
            // lbl_AddStaff
            // 
            this.lbl_AddStaff.AutoSize = true;
            this.lbl_AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddStaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AddStaff.Location = new System.Drawing.Point(48, 30);
            this.lbl_AddStaff.Name = "lbl_AddStaff";
            this.lbl_AddStaff.Size = new System.Drawing.Size(213, 31);
            this.lbl_AddStaff.TabIndex = 115;
            this.lbl_AddStaff.Text = "Điền Thông Tin";
            // 
            // FormAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(316, 375);
            this.Controls.Add(this.lbl_AddStaff);
            this.Controls.Add(this.pnl_Infro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Password1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_Password1)).EndInit();
            this.pnl_Infro.ResumeLayout(false);
            this.pnl_Infro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_DisplayName;
        private System.Windows.Forms.Label lbl_DisplayName;
        private FontAwesome.Sharp.IconPictureBox pbx_DisplayName;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private FontAwesome.Sharp.IconPictureBox pbx_Password1;
        private System.Windows.Forms.Label lbl_UserName;
        private FontAwesome.Sharp.IconPictureBox pbx_UserName;
        private System.Windows.Forms.TextBox txb_Password2;
        private System.Windows.Forms.Label lbl_Password2;
        private FontAwesome.Sharp.IconPictureBox pxb_Password1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pnl_Infro;
        private System.Windows.Forms.Label lbl_AddStaff;
    }
}