using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace QuanLyXuatNhapKho.Control
{
    public class SuplierControl
    {

        /// <summary>
        /// hàm load dữ liệu từ database và đổ vào dataGirdView
        /// </summary>
        public static void DataLoad(DataGridView dgv_View)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = from c in dbo.Suplier select new { c.Id, c.DisplayName, c.Phone, c.Address };
                dgv_View.DataSource = rd.ToList();
            }
        }
        #region check các ràng buộc
        /// <summary>
        /// hàm này kiểm tra Phone có từ 10-12 chữ số ko trả về fasle nếu sai
        /// </summary>
        public static bool CheckPhone(string text)
        {
            if (text.Length>12||text.Length<10)
            {
                return false;
                
            }
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] < '0' || text[i] > '9'))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Hàm này Kiểm tra khi người dùng muốn edit, có 2 trường hợp:
        /// 1.là họ các thông tin không phải là displayName ->cho sửa thoải mái
        /// 2.là họ sửa displayName -> Kiểm tra xem DisplayName mới có trùng hay không bằng cách gọi lại hàm Exist
        /// </summary>
        public static bool CheckEdit(int IdSelectedSuplier, TextBox txb_DisplayName)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = dbo.Suplier.Find(IdSelectedSuplier);
                if (rd.DisplayName == txb_DisplayName.Text)
                    return true;
                else
                {
                    return CheckSuplierExist(txb_DisplayName);
                }
            }
        }
        /// <summary>
        /// hàm này kiểm tra xem đã tồn tại chưa, trả về fasle nếu có tồn tại
        /// </summary>
        public static bool CheckSuplierExist(TextBox txb_DisplayName)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var List = dbo.Suplier.Where(p => p.DisplayName == txb_DisplayName.Text).Count();
                if (List == 0)
                {
                    return true;
                }
                return false;
            }
        }
        #endregion
        #region A,D,E
        /// <summary>
        /// Hàm này để thêm vào database
        /// trước khi thêm thì kiểm tra các điều kiện rạng buộc
        /// thành công hoặc thất bại thì thông báo cho người dùng biết
        /// </summary>
        public static void AddSuplierToData(TextBox txb_DisplayName, TextBox txb_Address, TextBox txb_Phone)
        {
            try
            {
                if (CheckSuplierExist(txb_DisplayName) && CheckPhone(txb_Phone.Text))
                {
                    using (QLXNKEntities dbo = new QLXNKEntities())
                    {
                        dbo.AddSuplier(txb_DisplayName.Text, txb_Address.Text, txb_Phone.Text);
                        MessageBox.Show("Thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi:\n 1.Đối tượng này đã tồn tại. \n2.Số điện thoại từ 10-12 số.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// Hàm này để sửa đối tượng 
        /// trước khi sửa thì kiểm tra các điều kiện rạng buộc
        /// thành công hoặc thất bại thì thông báo cho người dùng biết
        /// </summary>
        public static void EditSuplierToData(int IdSelectedSuplier, TextBox txb_DisplayName,TextBox txb_Address, TextBox txb_Phone)
        {
            try
            {
                if (CheckEdit(IdSelectedSuplier, txb_DisplayName) && CheckPhone(txb_Phone.Text))
                {
                    using (QLXNKEntities dbo = new QLXNKEntities())
                    {
                        dbo.EditSuplier(IdSelectedSuplier, txb_DisplayName.Text, txb_Address.Text, txb_Phone.Text);
                        MessageBox.Show("Thành công");
                    }
                }
                else
                {
                    MessageBox.Show("vui lòng kiểm tra lại dữ liệu  hoặc có thể đối tượng này đã tồn tại", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch 
            {

               
            }
        }
        /// <summary>
        /// Hàm này để xóa đối tượng 
        /// thành công hoặc thất bại thì thông báo cho người dùng biết
        /// </summary>
        public static void DeleteSuplierToData(int IdSelectedSuplier)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    dbo.DeleteSuplier(IdSelectedSuplier);
                    try
                    {
                        MessageBox.Show("Thành công");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có mặt hàng được cung cấp bởi nhà cung cấp này, nếu bạn thật sự muốn xóa thì vui lòng xóa tất cả mặt hàng từ nhà cung cấp này trước!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        #endregion
        #region Tìm kiếm
        /// <summary>
        /// hàm này để tìm kiếm gần đúng 
        /// tìm xong thì đổ DataGirdView
        /// </summary>
        public static void SearchSuplier(DataGridView dgv_View, TextBox txb_SearchSuplier)
        {
            //lấy ra danh sách full
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                
                var ListApproximateName = dbo.Suplier.Where(p => p.DisplayName.Contains(txb_SearchSuplier.Text)).ToList();
                //xuất lên view
                var rd = from c in ListApproximateName
                         select new
                         {
                             c.Id,
                             c.DisplayName,
                             c.Phone,
                             c.Address

                         };
                dgv_View.DataSource = rd.ToList();
            }


        }
        #endregion
    }
}
