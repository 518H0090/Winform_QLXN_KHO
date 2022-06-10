using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace Control
{
     public class TonKhoControl
    {
        // tạo hai thuộc tính gồm: mặt hàng và sl tồn, sẽ có list thuộc kiểu  TonKhoControl , list này sẽ sữ dụng cho việt sửa, xóa cho input, lập phiếu mới, sửa cho output
        public Model.Object Object { get; set; }
        public int CountTon { get; set; }
        /// <summary>
        /// hàm này vàu load lên datagirdview vừa trả về list1 tồn kho
        /// </summary>
       
        public static List<TonKhoControl> GetListTonKho(DataGridView dgv_View)
        {
            //  khởi tạo list ds tồn 
            List<TonKhoControl> listTonKho = new List<TonKhoControl>();
           
           
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                //lấy ra list mặt hàng
                var ObjectList = dbo.Object.ToList();
                //kt xem có null ko
                if (ObjectList.Count > 0)
                {
                    // chạy để duyệt từng mặt hàng
                    foreach (var item in ObjectList)
                    { 
                        // lấy ra list chi tiết phiếu  inputInfo có chứa mặt hàng đó
                        var InputList = dbo.InputInfo.Where(p => p.IdObject == item.Id);
                        // lấy ra list chi tiết phiếu  OutputInfo có chứa mặt hàng đó
                        var OutputList = dbo.OutputInfo.Where(p => p.IdObject == item.Id);
                       
                        // tạo biến sum( sẽ chứa tổng sl của mặt hàng = cách + tất cả sl trong ds phiếu trên)
                        int SumInput = 0;
                        int SumOutPut = 0;

                        // kt xem có null ko
                        if (InputList.Count() > 0)
                        {
                            SumInput = (int)InputList.Sum(p => p.Count);
                        }
                        // kt xem có null ko
                        if (OutputList.Count() > 0)
                        {
                            SumOutPut = (int)OutputList.Sum(p => p.Count);
                        }
                        // tạo 1 biến để giử hai giá trị  hàng và sl 
                        TonKhoControl tonKho = new TonKhoControl();
                        tonKho.Object = item;
                        //sl tồn thì = sl nhập - sl xuất 
                        tonKho.CountTon = SumInput - SumOutPut;
                        // ad vào list
                        listTonKho.Add(tonKho);

                    }
                    //load lên datagridview
                    var rd = from c in listTonKho
                             select new
                             {
                                 DisplayNameObject = c.Object.DisplayName,
                                 DisplayNameUnit = c.Object.Unit.DisplayName,
                                 DisplayNameSuplier = c.Object.Suplier.DisplayName,
                                 c.CountTon
                             };
                    dgv_View.DataSource = rd.ToList();
                }
               
            }
            //trả lại list tồn kho
            return listTonKho;
        }
        #region tìm kiếm
        /// <summary> 
        /// hàm này để tìm kiếm gần đúng có 3 kiểu tìm, tìm theo tên hàng (typeSearh =0), theo tên đơn vị (typeSearh =1), theo nhà cung cấp (typeSearh =2) 
        /// tìm xong thì đổ DataGirdView  
        /// </summary>
        public static void SearchTonKho(DataGridView dgv_View, TextBox txb_SearchTonKho, int TypeSearch)
        {
            
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                //khởi tạo list chứa giá các giá trị tìm kiếm
                List<TonKhoControl> ListApproximateName = new List<TonKhoControl>();
              
                if (TypeSearch == 0)
                {
                     ListApproximateName = GetListTonKho(dgv_View).Where(p => p.Object.DisplayName.Contains(txb_SearchTonKho.Text)).ToList();
                }
                else if(TypeSearch==1)
                {
                    ListApproximateName = GetListTonKho(dgv_View).Where(p => p.Object.Unit.DisplayName.Contains(txb_SearchTonKho.Text)).ToList();
                }
                else
                {
                    ListApproximateName = GetListTonKho(dgv_View).Where(p => p.Object.Suplier.DisplayName.Contains(txb_SearchTonKho.Text)).ToList();
                }
                //lấy ra danh sách theo tên gần đúng
              
                //xuất lên view
                var rd = from c in ListApproximateName select new
                {
                    DisplayNameObject = c.Object.DisplayName,
                    DisplayNameUnit = c.Object.Unit.DisplayName,
                    DisplayNameSuplier = c.Object.Suplier.DisplayName,
                    c.CountTon
                };
                dgv_View.DataSource = rd.ToList();
            }

        }
        #endregion

    }
}
