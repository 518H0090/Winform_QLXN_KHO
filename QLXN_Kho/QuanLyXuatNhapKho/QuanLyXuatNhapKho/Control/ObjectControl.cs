using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;

namespace QuanLyXuatNhapKho.Control
{
    public class ObjectControl
    {
        /// <summary>
        /// hàm load dữ liệu từ database và đổ vào dataGirdView
        /// </summary>
        public static void DataLoad(DataGridView dgv_View)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = from c in dbo.Object select new { c.Id, c.DisplayName, DisplayNameUnit = c.Unit.DisplayName, DisplayNameSuplier = c.Suplier.DisplayName };
                dgv_View.DataSource = rd.ToList();
            }
        }
        #region Lấy ra dữ liệu về Unit và Suplier từ data hoặc CMBox
        /// <summary>
        /// Hàm này để lấy danh sách Unit từ bảng unit đổ vào comboBoxUnit 
        /// </summary>
        public static void GetListUnitToCMB(ComboBox cmb_Unit)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    var rd = from c in dbo.Unit select new {c.Id, c.DisplayName };
                    cmb_Unit.DataSource = rd.ToList();
                    cmb_Unit.DisplayMember = "DisplayName";
                    cmb_Unit.ValueMember = "Id";
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// Hàm này để lấy danh sách Suplier từ bảng suplier đổ vào comboBoxUnit 
        /// </summary>
        public static void GetListSuplierToCMB(ComboBox cmb_Suplier)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    var rd = from c in dbo.Suplier select new { c.Id, c.DisplayName };
                    cmb_Suplier.DataSource = rd.ToList();
                    cmb_Suplier.DisplayMember = "DisplayName";
                    cmb_Suplier.ValueMember = "Id";
                }
            }
            catch
            {

            }
        }
       
#endregion
        #region check các ràng buộc
        /// <summary>
        /// hàm này kiểm tra xem đã tồn tại chưa, trả về fasle nếu có tồn tại
        /// </summary>
        public static bool CheckObjectExist(TextBox txb_DisplayName)
        {
            using (QLXNKEntities dbo = new QLXNKEntities()) {
                var List = dbo.Object.Where(p => p.DisplayName == txb_DisplayName.Text).Count();
                if (List == 0)
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// Hàm này Kiểm tra khi người dùng muốn edit, có 2 trường hợp:
        /// 1.là họ các thông tin không phải là displayName ->cho sửa thoải mái
        /// 2.là họ sửa displayName -> Kiểm tra xem DisplayName mới có trùng hay không bằng cách gọi lại hàm Exist
        /// </summary>
        public static bool CheckEdit(int IdSelectedObject, TextBox txb_DisplayName)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = dbo.Object.Find(IdSelectedObject);
                if (rd.DisplayName == txb_DisplayName.Text)
                    return true;
                else
                {
                   return CheckObjectExist(txb_DisplayName);
                }
               
            }
           
        }
        #endregion
        #region A,D,E
        /// <summary>
        /// Hàm này để thêm vào database
        /// trước khi thêm thì kiểm tra các điều kiện rạng buộc
        /// thành công hoặc thất bại thì thông báo cho người dùng biết
        /// </summary>
        public static void AddObjectToData(TextBox txb_DisplayName,int IdUnit,int IdSuplier )
        {
            try
            {
                if (CheckObjectExist(txb_DisplayName))
                {
                    using (QLXNKEntities dbo = new QLXNKEntities())
                    {
                        dbo.AddObject(txb_DisplayName.Text,IdUnit,IdSuplier);
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
        /// Hàm này để sửa đối tượng 
        /// trước khi sửa thì kiểm tra các điều kiện rạng buộc
        /// thành công hoặc thất bại thì thông báo cho người dùng biết
        /// </summary>
        public static void EditObjectToData(int IdSelecteObject, TextBox txb_DisplayName, int IdUnit, int IdSuplier)
        {

            try
            {
                if (CheckEdit(IdSelecteObject, txb_DisplayName))
                {
                    using (QLXNKEntities dbo = new QLXNKEntities())
                    {
                        dbo.EditObject(IdSelecteObject, txb_DisplayName.Text, IdUnit, IdSuplier);
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
        public static void DeleteObjectToData(int IdSelectedObject)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    dbo.DeleteObject(IdSelectedObject);
                    MessageBox.Show("Thành công");
                  
                }
            }
            catch
            {
                MessageBox.Show("Mặt hàng có trong một hay nhiều phiếu lập hoặc phiếu xuất, nếu bạn thật sự muốn xóa thì vui lòng xóa tất các phiếu nhập/xuất có mặt hàng này trước!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Tìm kiếm
        /// <summary>
        /// hàm này để tìm kiếm gần đúng 
        /// tìm xong thì đổ DataGirdView
        /// </summary>
        public static void SearchObject(DataGridView dgv_View, TextBox txb_SearchObject)
        {
          
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
               
                //lấy ra danh sách theo tên gần đúng
                var ListApproximateName = dbo.Object.Where(p => p.DisplayName.Contains(txb_SearchObject.Text)).ToList();
                //xuất lên view
                var rd = from c in ListApproximateName
                         select new
                         {
                             c.Id,
                             c.DisplayName,
                             DisplayNameUnit = c.Unit.DisplayName,
                             DisplayNameSuplier = c.Suplier.DisplayName

                         };
                dgv_View.DataSource = rd.ToList();
            }
        }
        #endregion
    }
}
