using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXuatNhapKho.Control;

namespace QuanLyXuatNhapKho.Forms
{
    public partial class FormChangePass : Form
    {
        //tạo một biến để hứng giá trị usename đang login vào
        public string userName;
        public FormChangePass(string UserNameLogining)
        {   
            InitializeComponent();
            LockTextBox();
            userName = UserNameLogining;// lấy username của accout đang đăng nhập để thực hiên đổi pass cho acc đó 
        }
        #region kiểm tra và lock các button
        /// <summary>
        /// kiểm tra các textbox có trống ko
        /// </summary>
        private bool CheckTextBoxInfro()
        {
            if (txb_CheckNewPass.Text == "" || txb_NewPass.Text == "" || txb_OldPass.Text == "")
                return false;
            return true;
        }
        /// <summary>
        /// lock các button AED ngay khi thấy có 1 textbox trống, ngược lại enable
        /// </summary>
        private void LockTextBox()
        {
            if (!CheckTextBoxInfro())
            {
                btn_ChangePass.Enabled = false;
            }
            else
            {
                btn_ChangePass.Enabled = true;
            }
        }

        private void Txb_OldPass_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_NewPass_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_CheckNewPass_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }
        #endregion
        /// <summary>
        /// kiểm tra xem pass mới và xác nhận pass có trùng nhau hay khong
        /// kiểm tra xem pass mới dài hơn 5 và ít hơn 15 kí tự ko
        /// trả về true nếu thoãn mãn
        /// </summary>
        bool checkChangePass(string text1, string text2)
        {
            if (text1 != text2)
            {
                return false;
            }
            if (text1.Length < 5 || text1.Length > 15)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// thực hiện đổi pass
        /// </summary>
        private void Btn_ChangePass_Click(object sender, EventArgs e)
        {
            if (checkChangePass(txb_NewPass.Text,txb_CheckNewPass.Text))
            {
                AccoutControl.ChangePass(userName, txb_OldPass.Text, txb_NewPass.Text);
               
            }
            else
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ (Mật khẩu phải trên 5 kí tự và ít hơn 12 kí tự hoặc xác nhận mậu khẩu không đúng)","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
