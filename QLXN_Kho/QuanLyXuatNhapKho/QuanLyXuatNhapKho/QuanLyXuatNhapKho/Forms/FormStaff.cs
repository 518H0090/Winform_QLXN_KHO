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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            StaffControl.DataLoad(dgv_View);
            LockTextBox();
        }

        #region kiểm tra và lock các button
        /// <summary>
        /// kiểm tra các textbox có trống ko
        /// </summary>
        private bool CheckTextBoxInfro()
        {
            if (txb_DisplayName.Text == "" || txb_UserName.Text == "" || txb_Status.Text == "")
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
               
                btn_EditStaff.Enabled = false;
                btn_LockAcc.Enabled = false;
                btn_RecoveryPass.Enabled = false;
            }
            else
            {
               
                btn_EditStaff.Enabled = true;
                btn_LockAcc.Enabled = true;
                btn_RecoveryPass.Enabled = true;
            }
        }
        //lock cách button khi người dùng xóa trong textbox
        private void Txb_UserName_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_DisplayName_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_Status_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Btn_AddSuplier_Click(object sender, EventArgs e)
        {
            FormAddStaff formAddStaff = new FormAddStaff();
            formAddStaff.ShowDialog();
            StaffControl.DataLoad(dgv_View);

        }
        /// <summary>
        ///  load data lên các textbox khi nhấn vào 1 dòng trên datagridview,
        ///  tao 1 biến đễ giữ id đối tượng được chọn nhằm edit và delete đối tượng đó
        ///  tạo 1 biến để giữ role của user đang được chọn để thực hiện khóa btb_LockAccout khi người dùng click vào row của Quản lí
        /// </summary>
        int IdSelectedUser;
        string RoleSelectedUser;
        private void Dgv_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = dgv_View.Rows[e.RowIndex];
                txb_UserName.Text = row.Cells[1].Value.ToString();
                txb_DisplayName.Text = row.Cells[2].Value.ToString();
                txb_Status.Text = row.Cells[3].Value.ToString();
                
                IdSelectedUser = int.Parse(row.Cells[0].Value.ToString());
                RoleSelectedUser = row.Cells[4].Value.ToString();
                // nếu như đang chọn vào dòng mà thằng đó là quản lí thì lock button _khóa_user lại
                if (RoleSelectedUser == "Quản lí")
                {
                    btn_LockAcc.Enabled = false;
                    
                }
                else
                {
                    btn_LockAcc.Enabled =true;
                }
            }
        }
        /// <summary>
        /// hàm này để clear sạch textbot khi người dung edit hoặc delete
        /// </summary>
        void ClearTextbot()
        {
            txb_DisplayName.Clear();
            txb_UserName.Clear();
            txb_Status.Clear();
        }
        #endregion

        #region E,D
        /// <summary>
        /// edit đối tượng  và load lại data
        /// </summary>
        private void Btn_EditStaff_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show("Bạn có chắc chắn sửa tài khoản: " + txb_DisplayName.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
           if (result == System.Windows.Forms.DialogResult.Yes)
           {
              StaffControl.EditUserToData(IdSelectedUser, txb_UserName, txb_DisplayName);
              StaffControl.DataLoad(dgv_View);
           }
            //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
            ClearTextbot();
        }
        /// <summary>
        /// lock or unlock đối tượng  và load lại data
        /// </summary>
        private void Btn_LockAcc_Click(object sender, EventArgs e)
        {
            StaffControl.LockUser(IdSelectedUser, txb_UserName, txb_Status);
            StaffControl.DataLoad(dgv_View);
            //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
            ClearTextbot();
        }
        /// <summary>
        /// hàm này đặt lại password cho tài khoản
        /// </summary>
        private void Btn_RecoveryPass_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn khôi phục mật khẩu cho tài khoản: " + txb_DisplayName.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                StaffControl.RecoveryPassword(IdSelectedUser, txb_UserName);

            }
            //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
            ClearTextbot();
        }
        
        #endregion

        #region tìm kiếm

        /// <summary>
        /// load lai data khi textbox tìm kiếm trống
        /// </summary>
        private void Tbx_SeacrhStaff_TextChanged(object sender, EventArgs e)
        {
            if (txb_SeacrhUser.Text == "")
            {
                StaffControl.DataLoad(dgv_View);
            }
        }
        /// <summary>
        /// tìm theo tên gần đúng
        /// </summary>
        private void Btn_SeacrhStaff_Click(object sender, EventArgs e)
        {
            StaffControl.SearchUSer(dgv_View, txb_SeacrhUser);
        }
        #endregion
    }
}
