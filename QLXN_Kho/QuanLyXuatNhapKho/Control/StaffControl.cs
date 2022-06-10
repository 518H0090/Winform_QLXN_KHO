using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace QuanLyXuatNhapKho.Control
{
     public class StaffControl
    {
        /// <summary>
        /// hàm load dữ liệu từ database và đổ vào dataGirdView
        /// </summary>
        public static void DataLoad(DataGridView dgv_View)
        {
            using (QLXNKEntities dbo = new QLXNKEntities()) {
                var rd = from c in dbo.Users
                         select new
                         {
                             c.Id,
                             c.UserName,
                             c.DisplayName,
                             Status = c.Status == 1 ? "Hoạt động" : "Khóa",
                             Role = c.IdRole == 1 ? "Quản lí" : "Nhân viên"
                         };
                dgv_View.DataSource = rd.ToList();
            }
        }
        #region check các ràng buộc
        /// <summary>
        /// Hàm này Kiểm tra khi người dùng muốn edit, có 2 trường hợp:
        /// 1.là họ các thông tin không phải là displayName ->cho sửa thoải mái
        /// 2.là họ sửa displayName -> Kiểm tra xem DisplayName mới có trùng hay không bằng cách gọi lại hàm Exist
        /// </summary>
        public static bool CheckEdit(int IdSelectedUser, TextBox txb_UserName)
        {
            using (QLXNKEntities dbo = new QLXNKEntities()) {
                var rd = dbo.Users.Find(IdSelectedUser);
                if (rd.UserName == txb_UserName.Text)
                    return true;
                else
                {
                    return CheckUserExist(txb_UserName);
                }
            }
        }
        /// <summary>
        /// hàm này kiểm tra xem đã tồn tại chưa, trả về fasle nếu có tồn tại
        /// </summary>
        public static bool CheckUserExist(TextBox txb_UserName)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var List = dbo.Users.Where(p => p.UserName == txb_UserName.Text).Count();
                if (List == 0)
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// hàm này kiểm tra password mới và xác nhận password có trung nhau đồng thời kt pass 5<kí tự<15 trả về fasle nếu sai
        /// </summary>
        public static bool CheckPass(string text1, string text2)
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
        /// hàm này kiểm tra UserName 5<kí tự<15 trả về fasle nếu sai
        /// </summary>
        public static bool CheckUserName(string text1)
        {
         
            if (text1.Length < 5 || text1.Length > 15)
            {
                return false;
            }
            return true;

        }
        #endregion

        #region A,D,E -- recoveryPass,LockorUnLockAcc
        /// <summary>
        /// hàm này chuyển từ sting sang base64 để mã hóa password
        /// </summary>
        static public string EncodeTo64(string toEncode)

        {

            byte[] toEncodeAsBytes

                  = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);

            string returnValue

                  = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;

        }
        /// <summary>
        /// Hàm này để sửa đối tượng 
        /// thành công hoặc thất bại thì thông báo cho người dùng biết
        /// </summary>
        public static void EditUserToData(int IdSelectedUser, TextBox txb_UserName,TextBox txb_DisplayName)
        {
            try
            {
                /// trước khi sửa thì kiểm tra các điều kiện rạng buộc
                if (CheckEdit(IdSelectedUser, txb_UserName))
                {
                    using (QLXNKEntities dbo = new QLXNKEntities())
                    {
                      

                        Users users = dbo.Users.Find(IdSelectedUser);
                        if (users != null)
                        {
                            users.UserName = txb_UserName.Text;
                            users.DisplayName = txb_DisplayName.Text;
                            dbo.SaveChanges();
                            MessageBox.Show("Thành công");
                        }
                      
                       
                       
                    }
                }
                else
                {
                    MessageBox.Show("vui lòng kiểm tra lại dữ liệu  hoặc có thể UserName này đã tồn tại", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// Hàm này để thêm vào database
        /// trước khi thêm thì kiểm tra các điều kiện rạng buộc
        /// thành công hoặc thất bại thì thông báo cho người dùng biết
        /// </summary>
        public static void AddUserToData(TextBox txb_UserName, TextBox txb_DisplayName, TextBox txb_PassWord,TextBox txb_Password2)
        {
            try
            {
                /// trước khi sửa thì kiểm tra các điều kiện rạng buộc
                if (CheckUserExist(txb_UserName) && CheckPass(txb_PassWord.Text, txb_Password2.Text)&& CheckUserName(txb_UserName.Text))
                {
                    string Pass = EncodeTo64(txb_PassWord.Text);
                    using (QLXNKEntities dbo = new QLXNKEntities())
                    {
                        Users users = new Users();
                        users.IdRole = 2;
                        users.UserName = txb_UserName.Text;
                        users.Password = Pass;
                        users.DisplayName = txb_DisplayName.Text;
                        users.Status = 1;
                        dbo.Users.Add(users);
                        dbo.SaveChanges();
                        MessageBox.Show("Thành công");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản mới thất bại: \n1.Có thể là password và xác nhận pasword không trùng nhau. " +
                                                                "\n2.Tên tài khoản và password phải từ 5 kí tự dến 15 kí tự. " +
                                                                "\n3.Tên tài khoản này đã tồn tại ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// hàm này để khóa hoặc mở khóa cho accout được chọn
        /// </summary>
        public static void LockUser(int IdSelectedUser, TextBox txb_UserName,TextBox txb_Status)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    //nếu đang hoạt động thì khóa
                    if (txb_Status.Text == "Hoạt động")
                    {
                        //hỏi kĩ cho chắc
                        if (MessageBox.Show("Bạn có chắc khóa tài khoản: " + txb_UserName.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            Users users = dbo.Users.Find(IdSelectedUser);
                            if (users != null)
                            {
                                users.Status = 0;
                                dbo.SaveChanges();
                            }
                            MessageBox.Show("Tài khoản " + txb_UserName.Text + " đã bị khóa");
                        }
                    }
                    else
                    {
                        Users users = dbo.Users.Find(IdSelectedUser);
                        if (users != null)
                        {
                            users.Status = 1;
                            dbo.SaveChanges();
                        }
                        MessageBox.Show("Tài khoản: " + txb_UserName.Text + " mở khóa thành công");
                    }
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// Hàm này để gán lại mật khẩu cho accout được chọn,mậu khẩu mới = username
        /// </summary>
        public static void RecoveryPassword(int IdSelectedUser, TextBox txb_UserName)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                   //mã hóa password bằng bằng chính username để khôi phục
                   
                    
                    Users users = dbo.Users.Find(IdSelectedUser);
                    if (users != null)
                    {
                        users.Password = EncodeTo64(txb_UserName.Text);
                        dbo.SaveChanges();
                    }
                    MessageBox.Show("Khôi phục  mật khẩu cho tài khoản: " + txb_UserName.Text + " thành công. Mật khẩu mới sẽ là giống tên đăng nhập");
                    
                }
            }
            catch
            {

            }
        }
        #endregion
        #region Tìm kiếm
        /// <summary>
        /// hàm này để tìm kiếm gần đúng 
        /// tìm xong thì đổ DataGirdView
        /// </summary>
        public static void SearchUSer(DataGridView dgv_View, TextBox txb_SearchUser)
        {
           
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                //lấy ra danh sách theo tên gần đúng
                var ListApproximateName = dbo.Users.Where(p => p.UserName.Contains(txb_SearchUser.Text)).ToList();
                //xuất lên view
                var rd = from c in ListApproximateName
                         select new
                         {
                             c.Id,
                             c.UserName,
                             c.DisplayName,
                             Status = c.Status == 1 ? "Hoạt động" : "Khóa",
                             Role = c.IdRole == 1 ? "Quản lí" : "Nhân viên"
                         };
                dgv_View.DataSource = rd.ToList();
            }

        }
        #endregion
    }

}
