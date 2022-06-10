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
     public class OutputControl
     {
        /// <summary>
        /// hàm load dữ liệu từ database và đổ vào dataGirdView
        /// </summary>
        public static void DataLoad(DataGridView dgv_View)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = from c in dbo.OutputInfo select new { c.IdOutput, IdOutputInfo = c.Id, DisplayNameObject = c.Object.DisplayName, c.Output.DateOutput, c.Count, c.OutputPrice, DisplayNameUser = c.Output.Users.DisplayName };
                
                dgv_View.DataSource = rd.ToList().OrderByDescending(p => p.IdOutputInfo).ToList();
            }
        }
        #region Lấy ra dữ liệu về Object từ data hoặc CMBox
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
        public static void GetListDisPlayNameUSerToTextBox(TextBox txb_DisplayNameUser, string UserNameLogining)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    var rd = dbo.Users.FirstOrDefault(p => p.UserName == UserNameLogining);
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
        /// hàm này dùng để kiểm tra mỗi dòng trong datagirdview trên phiếu xuất chuẩn bị lập, có loại hàng nào mà số lượng lớn hơn số lượng tồn ko 
        /// trả về fasle ngay khi có, true nếu tất cả đều ko
        /// </summary>
        public static bool checkAddOutput(List<TonKhoControl> list, DataGridView dgv_View)
        {
            //tạo các biến cần thiết
            DataGridViewRow row = new DataGridViewRow(); // row để duyệt từng dòng
            int idObject; // giữ id mặt hàng
            int Count_; // giữ sl 

            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                // bắt đầu duyệt từ list tồn kho
                foreach (var item in list)
                {
                    //kiểm tra từng dòng
                    for (int i = 1; i <= dgv_View.Rows.Count; i++)
                    {
                        row = dgv_View.Rows[i - 1];
                        string name = row.Cells[0].Value.ToString();
                        //lấy id của mặt hàng bằng cách dò trong database (do trên datagirdview ko có cột id) :v 
                        idObject = dbo.Object.FirstOrDefault(p => p.DisplayName == name).Id;
                        Count_ = int.Parse(row.Cells[1].Value.ToString());
                        //khi tìm thấy id thì kiểm tra sl tồn có >= sl xuất của dòng đó ko
                        if (idObject == item.Object.Id) 
                        {
                            if (Count_ > item.CountTon)
                            {
                                // có trả về fasle ngay lập tức
                                return false;
                            } 
                        } 
                    }
                }
                // trả về true khi tất cả đều đúng
                return true;
            }

            
        }
        /// <summary>
        /// hàm này dùng để add tất các các dòng mặt hàng chọn trong datagirdview
        /// trả về true nếu thành công
        /// fasle thất bại
        /// </summary>
        public static bool AddOutputToData(List<TonKhoControl> list, DataGridView dgv_View, DateTimePicker dtp_DateOut, string userName)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {   
                    //trước khi bắt đầu tạo phiếu xuất, kt mỗi dòng trong datagridview xem có sl của dòng nào lớn hơn sl tồn ko, nếu ko báo lỗi 
                    if (checkAddOutput(list,dgv_View))
                    {
                        //tạo Output
                        var idUser = dbo.Users.FirstOrDefault(p => p.UserName == userName).Id;
                        //add vào database
                        dbo.AddOutput(idUser, dtp_DateOut.Value);

                        //tao Outputinfo
                        // tạo các biến để giữ giá trị từ datagridview
                        int idObject;// giữa id của mặt hàng
                        int Count_;// số lượng
                        float OutputPrice_; //giá 

                        //lấy ra thằng output cuối cùng(cũng là thằng vừa mới tạo ở trên để lập outputInfo) bằng cách sắp xếp theo id giảm dần và lấy thằng đầu tiên
                        int idOutput = dbo.Output.OrderByDescending(p => p.Id).First().Id;

                        //tao biến row để bắt đầu duyệt từng dòng
                        DataGridViewRow row = new DataGridViewRow();
                        // chạy vòng lặp để tạo số lượng inputinfo tương dương với số dòng (mỗi dòng 1 loại hàng) trong datagirdview
                        for (int i = 1; i <= dgv_View.Rows.Count; i++)
                        {
                            row = dgv_View.Rows[i - 1];
                            string name = row.Cells[0].Value.ToString();
                            //lấy id của mặt hàng bằng cách dò trong database (do trên datagirdview ko có cột id) :v
                            idObject = dbo.Object.FirstOrDefault(p => p.DisplayName == name).Id;
                            Count_ = int.Parse(row.Cells[1].Value.ToString());
                            OutputPrice_ = Convert.ToSingle(row.Cells[2].Value.ToString());
                            //add inputInfo vào database
                            dbo.AddOutputInfo(idOutput, idObject, Count_, OutputPrice_);
                        }
                        MessageBox.Show("Lập phiếu thành công");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Số hàng còn lại trong kho ít số lượng bạn muốn xuất vui lòng kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                  

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// hàm này dùng để edit OutputInfo
        /// </summary>
        public static void EditOutputInfo(List<TonKhoControl> list, TextBox txb_DisplyNameObject, NumericUpDown nud_CountNew, NumericUpDown nud_OutputPrice, int IdSelectOutputInfo, int oldCount)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {
                    // do việc edit cần phải kiểm tra số lượng của phiếu này
                    //lấy ra tồn kho của mặt hàng 
                    int TonCount = list.FirstOrDefault(p => p.Object.DisplayName == txb_DisplyNameObject.Text).CountTon;
                    //số lượng tồn kho luôn phải >= sự trên lệch của sl mới - sl cũ, nếu ko có thể tồn kho sẽ âm =>sai dữ liệu
                    if ((int.Parse(nud_CountNew.Value.ToString()) - oldCount) <= TonCount)
                    {
                        var update = (from c in dbo.OutputInfo where c.Id == IdSelectOutputInfo select c).Single();
                        update.Count = (int)nud_CountNew.Value;
                        update.OutputPrice = (float)nud_OutputPrice.Value;
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
        public static void DeleteOutputInfo(TextBox txb_DisplyNameObject, int IdSelectOutputInfo)
        {
            try
            {
                using (QLXNKEntities dbo = new QLXNKEntities())
                {

                    var delete_ = (from c in dbo.OutputInfo where c.Id == IdSelectOutputInfo select c).Single();
                    dbo.OutputInfo.Remove(delete_);
                    dbo.SaveChanges();
                    MessageBox.Show("Thành công");


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
        public static void SearchOutput(DataGridView dgv_View, TextBox txb_Search)
        {
            //lấy ra danh sách full
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                //lấy ra danh sách theo tên gần đúng
                var ListApproximateName = dbo.OutputInfo.Where(p => p.Object.DisplayName.Contains(txb_Search.Text)).ToList();
                //xuất lên view
                var rd = from c in ListApproximateName select new { c.IdOutput, IdOutputInfo = c.Id, DisplayNameObject = c.Object.DisplayName, c.Output.DateOutput, c.Count, c.OutputPrice, DisplayNameUser = c.Output.Users.DisplayName };
                dgv_View.DataSource = rd.ToList();
            }

        }
        #endregion
    }
}
