namespace QuanLyXuatNhapKho
{

    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_SignIn = new System.Windows.Forms.Panel();
            this.pbx_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.pbx_Password = new FontAwesome.Sharp.IconPictureBox();
            this.pbx_User = new FontAwesome.Sharp.IconPictureBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            this.pnl_SignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_User)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(204)))));
            this.pnl_Logo.Controls.Add(this.pbx_Logo);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(200, 291);
            this.pnl_Logo.TabIndex = 0;
            // 
            // pbx_Logo
            // 
            this.pbx_Logo.BackgroundImage = global::QuanLyXuatNhapKho.Properties.Resources.DEMO_003;
            this.pbx_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_Logo.Location = new System.Drawing.Point(33, 97);
            this.pbx_Logo.Name = "pbx_Logo";
            this.pbx_Logo.Size = new System.Drawing.Size(127, 123);
            this.pbx_Logo.TabIndex = 0;
            this.pbx_Logo.TabStop = false;
            // 
            // pnl_SignIn
            // 
            this.pnl_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pnl_SignIn.Controls.Add(this.pbx_Icon);
            this.pnl_SignIn.Controls.Add(this.btn_SignIn);
            this.pnl_SignIn.Controls.Add(this.lbl_Password);
            this.pnl_SignIn.Controls.Add(this.lbl_User);
            this.pnl_SignIn.Controls.Add(this.pbx_Password);
            this.pnl_SignIn.Controls.Add(this.pbx_User);
            this.pnl_SignIn.Controls.Add(this.txb_Password);
            this.pnl_SignIn.Controls.Add(this.txb_UserName);
            this.pnl_SignIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_SignIn.Location = new System.Drawing.Point(198, 0);
            this.pnl_SignIn.Name = "pnl_SignIn";
            this.pnl_SignIn.Size = new System.Drawing.Size(518, 291);
            this.pnl_SignIn.TabIndex = 1;
            // 
            // pbx_Icon
            // 
            this.pbx_Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(204)))));
            this.pbx_Icon.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.pbx_Icon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(204)))));
            this.pbx_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Icon.IconSize = 83;
            this.pbx_Icon.Location = new System.Drawing.Point(210, 29);
            this.pbx_Icon.Name = "pbx_Icon";
            this.pbx_Icon.Size = new System.Drawing.Size(90, 83);
            this.pbx_Icon.TabIndex = 7;
            this.pbx_Icon.TabStop = false;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_SignIn.Location = new System.Drawing.Point(188, 229);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(172, 41);
            this.btn_SignIn.TabIndex = 6;
            this.btn_SignIn.Text = "Đăng nhập";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.Btn_SignIn_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Password.Location = new System.Drawing.Point(31, 171);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(79, 18);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Mật Khẩu";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_User.Location = new System.Drawing.Point(31, 118);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(84, 18);
            this.lbl_User.TabIndex = 4;
            this.lbl_User.Text = "Tài Khoản";
            // 
            // pbx_Password
            // 
            this.pbx_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(204)))));
            this.pbx_Password.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.pbx_Password.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(204)))));
            this.pbx_Password.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_Password.IconSize = 35;
            this.pbx_Password.Location = new System.Drawing.Point(116, 171);
            this.pbx_Password.Name = "pbx_Password";
            this.pbx_Password.Size = new System.Drawing.Size(35, 36);
            this.pbx_Password.TabIndex = 3;
            this.pbx_Password.TabStop = false;
            // 
            // pbx_User
            // 
            this.pbx_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pbx_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(204)))));
            this.pbx_User.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pbx_User.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(204)))));
            this.pbx_User.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbx_User.IconSize = 35;
            this.pbx_User.Location = new System.Drawing.Point(116, 118);
            this.pbx_User.Name = "pbx_User";
            this.pbx_User.Size = new System.Drawing.Size(35, 36);
            this.pbx_User.TabIndex = 2;
            this.pbx_User.TabStop = false;
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Password.Location = new System.Drawing.Point(153, 171);
            this.txb_Password.Multiline = true;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(238, 36);
            this.txb_Password.TabIndex = 1;
            // 
            // txb_UserName
            // 
            this.txb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_UserName.Location = new System.Drawing.Point(153, 118);
            this.txb_UserName.Multiline = true;
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(238, 36);
            this.txb_UserName.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 291);
            this.Controls.Add(this.pnl_SignIn);
            this.Controls.Add(this.pnl_Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(732, 330);
            this.MinimumSize = new System.Drawing.Size(732, 330);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            this.pnl_SignIn.ResumeLayout(false);
            this.pnl_SignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Panel pnl_SignIn;
        private FontAwesome.Sharp.IconPictureBox pbx_Password;
        private FontAwesome.Sharp.IconPictureBox pbx_User;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.PictureBox pbx_Logo;
        private FontAwesome.Sharp.IconPictureBox pbx_Icon;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User;
    }
}