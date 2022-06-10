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
    public partial class FormAddStaff : Form
    {
        public FormAddStaff()
        {
            InitializeComponent();
            LockTextBox();
          
        }
        #region kiểm tra và lock các button
        private bool CheckTextBoxInfro()
        {
            if (txb_DisplayName.Text == "" || txb_Password.Text == "" || txb_Password2.Text == ""||txb_UserName.Text=="")
                return false;
            return true;

        }
      
        /// <summary>
        /// kiểm tra các textbox có trống ko
        /// </summary>
        private void LockTextBox()
        {
            if (!CheckTextBoxInfro())
            {
                btn_Add.Enabled = false;
                
            }
            else
            {
                btn_Add.Enabled = true;
              
            }
        }
      
       //khi người dùng xóa thì lock các button lại
        private void Txb_UserName_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_Password_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_Password2_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_DisplayName_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }
        #endregion
        /// <summary>
        /// add thêm đối tượng  và load lại data
        /// </summary>
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            StaffControl.AddUserToData(txb_UserName, txb_DisplayName, txb_Password, txb_Password2);
            
        }

       
    }
}
