namespace QuanLyXuatNhapKho.Forms
{
    partial class FormChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePass));
            this.txb_OldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_NewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_CheckNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_OldPass
            // 
            this.txb_OldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_OldPass.Location = new System.Drawing.Point(134, 37);
            this.txb_OldPass.Multiline = true;
            this.txb_OldPass.Name = "txb_OldPass";
            this.txb_OldPass.PasswordChar = '*';
            this.txb_OldPass.Size = new System.Drawing.Size(195, 25);
            this.txb_OldPass.TabIndex = 1;
            this.txb_OldPass.TextChanged += new System.EventHandler(this.Txb_OldPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txb_NewPass
            // 
            this.txb_NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NewPass.Location = new System.Drawing.Point(134, 68);
            this.txb_NewPass.Multiline = true;
            this.txb_NewPass.Name = "txb_NewPass";
            this.txb_NewPass.PasswordChar = '*';
            this.txb_NewPass.Size = new System.Drawing.Size(195, 25);
            this.txb_NewPass.TabIndex = 2;
            this.txb_NewPass.TextChanged += new System.EventHandler(this.Txb_NewPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(57, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txb_CheckNewPass
            // 
            this.txb_CheckNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CheckNewPass.Location = new System.Drawing.Point(134, 99);
            this.txb_CheckNewPass.Multiline = true;
            this.txb_CheckNewPass.Name = "txb_CheckNewPass";
            this.txb_CheckNewPass.PasswordChar = '*';
            this.txb_CheckNewPass.Size = new System.Drawing.Size(195, 25);
            this.txb_CheckNewPass.TabIndex = 3;
            this.txb_CheckNewPass.TextChanged += new System.EventHandler(this.Txb_CheckNewPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = " Xác nhận mật khẩu ";
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_ChangePass.FlatAppearance.BorderSize = 0;
            this.btn_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ChangePass.Location = new System.Drawing.Point(134, 148);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(195, 39);
            this.btn_ChangePass.TabIndex = 2;
            this.btn_ChangePass.Text = "Xác Nhận";
            this.btn_ChangePass.UseVisualStyleBackColor = false;
            this.btn_ChangePass.Click += new System.EventHandler(this.Btn_ChangePass_Click);
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(492, 213);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_CheckNewPass);
            this.Controls.Add(this.txb_NewPass);
            this.Controls.Add(this.txb_OldPass);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(508, 252);
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_OldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_NewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_CheckNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ChangePass;
    }
}