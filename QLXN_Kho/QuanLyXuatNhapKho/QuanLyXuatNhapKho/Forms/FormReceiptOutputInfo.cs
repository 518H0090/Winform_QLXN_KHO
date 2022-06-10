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
    public partial class FormReceiptOutputInfo : Form
    {
        //tạo một biến để hứng giá trị usename đang login vào
        //mục đích để có dc id, displayName của user đang đăng nhập
        public static string userName;
        public FormReceiptOutputInfo(string UserNameLogining)
        {
            InitializeComponent();
            //lock các button lại
            LockTextBox();
            //để giá trị vào các combobox
            OutputControl.GetListObjectToCMB(cmb_DisplayNameObject);
            OutputControl.GetListDisPlayNameUSerToTextBox(txb_DisplayNameUser, UserNameLogining);
            //giá trị mặt định của ngày lập phiếu = ngày hôm nay
            dtp_DateOutput.Value = DateTime.Now;
            //hứng giá trị userName đang login
            userName = UserNameLogining;
        }
        /// <summary>
        /// lock các button lại 
        /// </summary>
        private void LockTextBox()
        {
            if (dgv_View.SelectedRows.Count <= 0)
            {
                btn_DeleteObjectToList.Enabled = false;
                btn_LapPhieu.Enabled = false;

            }
            else
            {
                btn_DeleteObjectToList.Enabled = true;
                btn_LapPhieu.Enabled = true;
            }
        }
        /// <summary>
        /// hàm này để cộng tổng giá của phiếu hàng
        /// trả lại sl tổng 
        /// </summary>
        private float SumPrice()
        {
            //khởi tạo các giá trị cần thiết
            float SumPrice = 0;//tổng giá cuối cùng, mặc định =0
            int Count_;//sl từng mặt hàng
            float Price_;//giá của mặt hàng
            //biến row để duyệt từng dòng
            DataGridViewRow row = new DataGridViewRow();
            for (int i = 1; i <= dgv_View.Rows.Count; i++)
            {
                row = dgv_View.Rows[i - 1];
                Count_ = int.Parse(row.Cells[1].Value.ToString());
                Price_ = Convert.ToSingle(row.Cells[2].Value.ToString());
                //tổng = sl*đơn giá
                SumPrice = SumPrice + Count_*Price_;

            }
            return SumPrice;
        }
        /// <summary>
        /// add thêm đối tượng  vào datagirdview(danh sách mặt hàng)
        /// </summary>
        private void Btn_AddOjectToList_Click(object sender, EventArgs e)
        {
            //qui định là ko dc chọn mặt hàng đã có rồi trong danh sách
            // nếu sl dòng >0 thì phải kiểm tr
            if (dgv_View.Rows.Count > 0)
            { 
                //biến row để duyệt từng dòng
                DataGridViewRow row = new DataGridViewRow();

                for (int i = 1; i <= dgv_View.Rows.Count; i++)
                {
                    row = dgv_View.Rows[i - 1];
                    string name = row.Cells[0].Value.ToString();
                    //thực hiện kiểm tra  nếu đã tồn tại thì thông báo ra và kết thúc
                    if (name == cmb_DisplayNameObject.Text)
                    {
                        MessageBox.Show("Đã có mặt hàng này trong danh sách","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                 
                }
                //nếu ok thì cho add vào danh sách
                dgv_View.Rows.Add(cmb_DisplayNameObject.Text, nud_Count.Value, nud_OutputPrice.Value);
                btn_DeleteObjectToList.Enabled = true;
                btn_LapPhieu.Enabled = true;
                txt_SumPrice.Text = SumPrice().ToString();
            }
            // nếu danh sách chưa có mặt hàng nào thì add thoải mái
            else
            {
                dgv_View.Rows.Add(cmb_DisplayNameObject.Text, nud_Count.Value, nud_OutputPrice.Value);
                btn_DeleteObjectToList.Enabled = true;
                btn_LapPhieu.Enabled = true;
                txt_SumPrice.Text = SumPrice().ToString();
            }
          
          
        }
        /// <summary>
        /// delete thêm đối tượng  vào datagirdview(danh sách mặt hàng)
        /// </summary>
        private void Btn_DeleteObjectToList_Click(object sender, EventArgs e)
        {
            //kiểm tra coi có mặt hàng nào ko có thì mới cho xóa
            if (dgv_View.SelectedRows.Count > 0)
            {
                dgv_View.Rows.RemoveAt(dgv_View.SelectedRows[0].Index);
                //cập nhật lại giá tổng
                txt_SumPrice.Text = SumPrice().ToString();
            }
            LockTextBox();
        }
        /// <summary>
        /// hàm này để lập phiếu khi người dùng bấm lập
        /// </summary>
        private void Btn_LapPhieu_Click(object sender, EventArgs e)
        {  
            //do khi lập phiếu xuất ta phải kiểm tra số lượng tồn còn nhiều thì mới cho xuất nên 
            // ở đây khởi tạo 1 biến list tồn kho 
            FormTonKho tonKho = new FormTonKho();
            // hứng danh sách tồn kho
            var list = tonKho.getListTonKho();
            //tạo một biến kiểu bool để xem việc lập phiếu thành công ko
            bool IsSusccess = OutputControl.AddOutputToData(list, dgv_View, dtp_DateOutput, userName);
            //thành công thì tắt Form lập phiếu
            if (IsSusccess)
            {
                this.Close();
            }
            //ko thì ko tắt  :v
        }
    }
}
