using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;

namespace QuanLyXuatNhapKho.Control
{
    public class AccoutControl
    {
        /// <summary>
        /// Hàm này để lấy lại tên người dùng sau khi đăng nhập thành công
        /// Đầu vào là userName và tìm kiếm trong data và trả về là tên người dùng của accout đó
        /// </summary>
        static public string getLoginDisplayName(string userName)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                //tìm tên dựa vào userName
                var rd = dbo.Users.FirstOrDefault(p => p.UserName == userName);
                string DisplayName = rd.DisplayName;
                
                return DisplayName;
            }
        }
        /// <summary>
        /// Hàm này để kiểm tra người dùng là quản lí hay nhân viên sau khi đăng nhập thành công
        /// Đầu vào là userName và tìm kiếm trong database và trả về nếu là Quản lí thì true, ngược lại fasle
        /// </summary>
        static public bool CheckAccout(string userName )
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = dbo.Users.Where(p => p.UserName == userName && p.IdRole == 1).Count();
                if (rd > 0)
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// Hàm này để đổi mật khẩu
        /// cần có userName, pass cũ, pass mới
        /// </summary>
        static public void ChangePass(string UserName, string OldPass, string NewPass)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities()) {
                    //trước khi đổi pass phải nhập pass cũ, đúng pass cũ mới cho đổi pass (dùng dòng check login ở loginControl do việc khá giống việc đăng nhập)
                    if (LoginControl.CheckLogin(UserName, OldPass))
                    {
                        //trước khi đổi ta cần mã hóa pass, dùng hàm lại này bên loginControl
                        dbo.ChangePassword(UserName, LoginControl.Base64Encode(NewPass));
                        MessageBox.Show("ĐỔI MẬT KHẨU THÀNH CÔNG");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }

        }
    }
}
