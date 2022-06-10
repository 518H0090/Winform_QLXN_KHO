using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace QuanLyXuatNhapKho.Control
{
    public class LoginControl
    {
        /// <summary>
        /// hàm chuyển từ string sang base 64code để kt password dưới database 
        /// </summary>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        /// <summary>
        /// Hàm này để Kiểm tra accout có tồn tại ko để cho phép đăng nhập
        /// </summary>
        public static bool CheckLogin(string UserName, string PassWord)
        {
            //mã hóa pass trước khi kt việc đăng nhập
            string Pass = Base64Encode(PassWord);
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = dbo.Users.Where(p => p.UserName == UserName && p.Password == Pass && p.Status == 1).Count();
                if (rd > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
