using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Model;
namespace QuanLyXuatNhapKho.Control
{
    public class UnitControl
    {
        
       
        /// <summary>
        /// hiện dự liệu lên datagridview
        /// </summary>
        /// <param name="dgv_View"></param>
        public static void  DataLoad(DataGridView dgv_View)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = from c in dbo.Unit select new { c.Id, c.DisplayName };
                dgv_View.DataSource = rd.ToList();
            }
        }
        #region check trước khi thêm hoặc sửa
       
       
        /// <summary>
        /// Kiểm tra xem DisplayName có tồn tại chưa
        /// </summary>
        public static bool CheckUnitExist(TextBox txb_DisplayName)
        {
            int List;
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                List = dbo.Unit.Where(p => p.DisplayName == txb_DisplayName.Text).Count();
            }
            if (List == 0)
            {
                return true;
            }
            return false;
        }
        #endregion


        #region Add,edit,delete
        /// <summary>
        /// Hàm này để thêm vào database
        /// trước khi thêm thì kiểm tra các điều kiện rạng buộc
        /// thành công hoặc thất bại thì thông báo cho người dùng biết
        /// </summary>
        public static void AddUnitToData(TextBox txb_DisplayName)
        {
            try
            {
                if (CheckUnitExist(txb_DisplayName))
                {
                    using (QLXNKEntities dbo = new QLXNKEntities())
                    {
                        dbo.AddUnit(txb_DisplayName.Text);
                        MessageBox.Show("Thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Tên ko hợp lệ hoặc đã tồn tại", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        public static void EditUnitToData(TextBox txb_DisplayName,int IdSelectedUnit)
        {
            try
            {
                if (CheckUnitExist(txb_DisplayName))
                {
                    using (QLXNKEntities dbo = new QLXNKEntities())
                    {
                        dbo.EditUnit(IdSelectedUnit, txb_DisplayName.Text);
                        MessageBox.Show("Thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Tên ko hợp lệ hoặc đã tồn tại", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        public static void DeleteUnitToData( int IdSelectedUnit)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    dbo.DeleteUnit(IdSelectedUnit);
                    MessageBox.Show("Thành công");
                }
            }
            catch
            {
                MessageBox.Show("Có mặt hàng sử dụng đơn vị này, nếu bạn thật sự muốn xóa thì vui lòng xóa tất cả mặt hàng sử dụng đơn vị này trước!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region tìm kiếm
        /// <summary> 
        /// hàm này để tìm kiếm gần đúng 
        /// tìm xong thì đổ DataGirdView  
        /// </summary>
        public static void SearchUnit(DataGridView dgv_View, TextBox txb_SearchUnit)
        {
            
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
              
                //lấy ra danh sách theo tên gần đúng
                var ListApproximateName = dbo.Unit.Where(p => p.DisplayName.Contains(txb_SearchUnit.Text)).ToList();
                //xuất lên view
                var rd = from c in ListApproximateName select new { c.Id, c.DisplayName };
                dgv_View.DataSource = rd.ToList();
            }

        }
        #endregion
    }
}
