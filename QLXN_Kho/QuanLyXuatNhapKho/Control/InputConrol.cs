using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Model;

namespace QuanLyXuatNhapKho.Control
{
    public class InputConrol
    {
        /// <summary>
        /// hàm load dữ liệu từ database và đổ vào dataGirdView
        /// </summary>
        public static void DataLoad(DataGridView dgv_View)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = from c in dbo.InputInfo select new { c.IdInput, IdInputInfo=c.Id,DisplayNameObject= c.Object.DisplayName, c.Input.DateInput, c.Count,c.InputPrice, DisplayNameUser=c.Input.Users.DisplayName };
                // do ta muốn những phiếu nhập mới nằm trên cùng -> sắp xếp lại giảm dần dực vào id của idInputInfo
                dgv_View.DataSource = rd.ToList().OrderByDescending(p => p.IdInputInfo).ToList();
            }
        }
        #region Lấy ra dữ liệu data hoặc CMBox
        /// <summary>
        /// Hàm này để lấy danh sách Unit từ bảng unit đổ vào comboBoxUnit 
        /// </summary>
        public static void GetListObjectToCMB(ComboBox cmb_Object)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    var rd = from c in dbo.Object select new { c.DisplayName };
                    cmb_Object.DataSource = rd.ToList();
                    cmb_Object.DisplayMember = "DisplayName";
                    cmb_Object.ValueMember = "Id";
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// Hàm này để lấy tên của accout đang đăng nhập để lập phiếu
        /// </summary>
        public static void GetListDisPlayNameUSerToTextBox(TextBox txb_DisplayNameUser,string UserNameLogining)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    var rd = dbo.Users.FirstOrDefault(p=>p.UserName==UserNameLogining);
                    txb_DisplayNameUser.Text = rd.DisplayName;
                   
                }
            }
            catch
            {

            }
        }

        #endregion
        #region A,D,E
        /// <summary>
        /// hàm này dùng để add tất các các dòng mặt hàng chọn trong datagirdview
        /// trả về true nếu thành công
        /// fasle thất bại
        /// </summary>
        public static bool AddInputToData(DataGridView dgv_View,DateTimePicker dtp_DateInput,string userName)
        {
            try
            {
               using (QLXNKEntities dbo = new QLXNKEntities())
               {
                    //tạo input 
                    var idUser = dbo.Users.FirstOrDefault(p => p.UserName == userName).Id;
                    //add vào database
                   
                    Input a = new Input();
                    a.IdUser = idUser;
                    a.DateInput = dtp_DateInput.Value;
                    dbo.Input.Add(a);
                    dbo.SaveChanges();
                    //tao inputinfo
                    // tạo các biến để giữ giá trị từ datagridview
                    int idObject; // giữa id của mặt hàng
                     int Count_; // số lượng
                     float InputPrice_; //giá 
                    //lấy ra thằng intput cuối cùng(cũng là thằng vừa mới tạo ở trên để lập inputInfo) bằng cách sắp xếp theo id giảm dần và lấy thằng đầu tiên
                    int idInput = dbo.Input.OrderByDescending(p=>p.Id).First().Id;

                     //tao biến row để bắt đầu duyệt từng dòng
                    DataGridViewRow row = new DataGridViewRow();
                     // chạy vòng lặp để tạo số lượng inputinfo tương dương với số dòng (mỗi dòng 1 loại hàng) trong datagirdview
                    for (int i = 1; i <= dgv_View.Rows.Count; i++)
                    {
                        
                        row = dgv_View.Rows[i - 1];
                        string name = row.Cells[0].Value.ToString();
                        //lấy id của mặt hàng bằng cách dò trong database (do trên datagirdview ko có cột id) :v
                        idObject =dbo.Object.FirstOrDefault(p=>p.DisplayName== name).Id;
                        Count_ = int.Parse(row.Cells[1].Value.ToString());
                        InputPrice_ = Convert.ToSingle(row.Cells[2].Value.ToString());
                        //add inputInfo vào database
                        InputInfo inputInfo = new InputInfo();
                        inputInfo.IdInput = idInput;
                        inputInfo.IdObject = idObject;
                        inputInfo.Count = Count_;
                        inputInfo.InputPrice = InputPrice_;
                        dbo.InputInfo.Add(inputInfo);
                        dbo.SaveChanges();
                    }
                    MessageBox.Show("Lập phiếu thành công");
                    return true;
               }
               
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// hàm này dùng để edit inputInfo
        /// </summary>
        public static void EditInputInfo(List<TonKhoControl> list, TextBox txb_DisplyNameObject, NumericUpDown nud_CountNew, NumericUpDown nud_InputPrice, int IdSelectInputInfo,int oldCount)
        {
            try {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    // do việc edit cần phải kiểm tra số lượng của phiếu này
                     //lấy ra tồn kho của mặt hàng này
                     int TonCount = list.FirstOrDefault(p => p.Object.DisplayName == txb_DisplyNameObject.Text).CountTon;
                     //Trong việc nhập kho: số lượng tồn kho luôn phải >= sự trên lệch của sl cũ - sl mới, nếu ko có thể tồn kho sẽ âm =>sai dữ liệu
                    if ((oldCount - int.Parse(nud_CountNew.Value.ToString())) <= TonCount)
                    {
                        // tìm đối tượng cần sửa
                        var update = (from c in dbo.InputInfo where c.Id == IdSelectInputInfo select c).Single();
                        //gán thông tin mới
                        update.Count = (int)nud_CountNew.Value;
                        update.InputPrice = (float)nud_InputPrice.Value;
                        //save
                        dbo.SaveChanges();
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Số hàng còn lại trong kho ít hơn sự chêch lệch bạn vừa sửa vui lòng kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// hàm này dùng để delete inputInfo
        /// </summary>

        public static void DeleteInputInfo(List<TonKhoControl> list, TextBox txb_DisplyNameObject, int IdSelectInputInfo, int oldCount)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    // do việc delete cần phải kiểm tra số lượng của phiếu này
                     //lấy ra tồn kho của mặt hàng 
                     int TonCount = list.FirstOrDefault(p => p.Object.DisplayName == txb_DisplyNameObject.Text).CountTon;
                    //Trong việc nhập kho: số lượng tồn kho luôn phải >= sl cũ (sl  của inputInfo muốn xóa) , nếu ko có thể tồn kho sẽ âm =>sai dữ liệu
                    if (oldCount <= TonCount)
                    {
                        // tìm đối tượng cần deleta
                        var delete_ = (from c in dbo.InputInfo where c.Id == IdSelectInputInfo select c).Single();
                        //thực hiện việc xóa
                        dbo.InputInfo.Remove(delete_);
                        //save
                        dbo.SaveChanges();
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Số hàng còn lại trong kho ít hơn số lượng nhập ở hóa đơn này vui lòng kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }
        #endregion
        #region tìm kiếm
        /// <summary> 
        /// hàm này để tìm kiếm gần đúng 
        /// tìm xong thì đổ DataGirdView  
        /// </summary>
        public static void SearchInput(DataGridView dgv_View, TextBox txb_SearchInput)
        {
            
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
               
                //lấy ra danh sách theo tên gần đúng
                var ListApproximateName = dbo.InputInfo.Where(p => p.Object.DisplayName.Contains(txb_SearchInput.Text)).ToList();
                //xuất lên view
                var rd = from c in ListApproximateName select new { c.IdInput, IdInputInfo = c.Id, DisplayNameObject = c.Object.DisplayName, c.Input.DateInput, c.Count, c.InputPrice, DisplayNameUser = c.Input.Users.DisplayName };
                dgv_View.DataSource = rd.ToList();
            }

        }
        #endregion

    }


}
