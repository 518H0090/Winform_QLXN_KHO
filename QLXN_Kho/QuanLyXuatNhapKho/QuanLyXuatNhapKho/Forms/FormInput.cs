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
    public partial class FormInput : Form
    {
        //tạo một biến để hứng giá trị usename đang login vào
        //mục đích để có dc id, displayName của user đang đăng nhập
        public string UserNameLogining_;
        public FormInput(string UserNameLogining)
        {
            InitializeComponent();
            //load data
            InputConrol.DataLoad(dgv_View);
            LockTextBox();
            //hứng user đang login
            UserNameLogining_ = UserNameLogining;
        }
        #region kiểm tra và lock các button
        /// <summary>
        /// kiểm tra các textbox có trống ko
        /// </summary>
        private bool CheckTextBoxInfro()
        {
            if (txb_DisplayNameUser.Text == "" &&txb_DisplayNameObject.Text=="" && txb_InputDate.Text=="")
                return false;
            return true;

        }
        private void LockTextBox()
        {
            if (!CheckTextBoxInfro())
            {
                btn_EditInput.Enabled = false;
                btn_DeleteInput.Enabled = false;
            }
            else
            {
                btn_EditInput.Enabled = true;
                btn_DeleteInput.Enabled = true;
            }

        }
        private void Txb_DisplayNameUser_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }
        /// <summary>
        ///  load data lên các textbox khi nhấn vào 1 dòng trên datagridview,
        ///  tao 1 biến đễ giữ id đối tượng được chọn nhằm edit và delete đối tượng đó
        ///  một biến OldCount để giữ sl "cũ" nhằm để sửa  
        /// </summary>
        int OldCount;
        int IdSelectedInputInfo;
        private void Dgv_View_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = dgv_View.Rows[e.RowIndex];

                txb_DisplayNameObject.Text = row.Cells[2].Value.ToString();
                // chỉ lấy ngày tháng năm nên cắt chuổi
                txb_InputDate.Text = row.Cells[3].Value.ToString().Substring(0,10);
                nud_Cout.Text = row.Cells[4].Value.ToString();
                //lấy sl của mặt hàng  đang chọn 
                OldCount= int.Parse(row.Cells[4].Value.ToString());
                nud_InputPrice.Text = row.Cells[5].Value.ToString();
                txb_DisplayNameUser.Text = row.Cells[6].Value.ToString();

                //giữ id của InputInfo đang dc chọn để sửa xóa
                IdSelectedInputInfo = int.Parse(row.Cells[1].Value.ToString());
            }
        }
        /// <summary>
        /// hàm này để clear sạch textbot khi người dùng edit hoặc delete
        /// </summary>
        void ClearTextbot()
        {
            txb_DisplayNameUser.Clear();
            txb_DisplayNameObject.Clear();
            txb_InputDate.Clear();
        }
        #endregion
        #region A,D,E
        /// <summary>
        /// hàm này để lập phiếu, mở form lập phiếu lên,load lại data,update list tồn kho
        /// </summary>
        private void Btn_AddSuplier_Click(object sender, EventArgs e)
        {
            //mở form lập phiếu 
            // truyền username đang login vào hàm khởi tạo 
            FormReceiptInputInfo formReceiptInputInfo = new FormReceiptInputInfo(UserNameLogining_);
            formReceiptInputInfo.ShowDialog();
            //sau khi lập phiếu thành công thì load lại data
            InputConrol.DataLoad(dgv_View);
            //update lại list sl tồn 
            FormTonKho tonKho = new FormTonKho();
            tonKho.UpdateListTonKho();
        }
        /// <summary>
        /// edit đối tượng  và load lại data,,update list tồn kho
        /// </summary>
        private void Btn_EditInput_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có chắc muốn sửa phiếu nhập này không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //muốn sửa thì phải cần có list tồn ko để kiểm tra 
                FormTonKho tonKho = new FormTonKho();
                //lấy list tồn kho
                var list = tonKho.getListTonKho();
                //thực hiện việc sửa, đưa cả list tồn kho xuống hàm ở control để kt 
                InputConrol.EditInputInfo(list, txb_DisplayNameObject, nud_Cout, nud_InputPrice, IdSelectedInputInfo, OldCount);
                //load lại data
                InputConrol.DataLoad(dgv_View);
                //update lại tồn kho
                tonKho.UpdateListTonKho();
                //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
                ClearTextbot();
            }
        }
        /// <summary>
        /// delete đối tượng  và load lại data,,update list tồn kho
        /// </summary>
        private void Btn_DeleteInput_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập này không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //muốn xóa thì phải cần có list tồn ko để kiểm tra 
                FormTonKho tonKho = new FormTonKho();
                //lấy list tồn kho
                var list = tonKho.getListTonKho();
                //thực hiện việc xóa , đưa cả list tồn kho xuống hàm ở control để kt 
                InputConrol.DeleteInputInfo(list, txb_DisplayNameObject, IdSelectedInputInfo, OldCount);
                //load lại data
                InputConrol.DataLoad(dgv_View);
                //update lại tồn kho
                tonKho.UpdateListTonKho();
                //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
                ClearTextbot();
            }
        }
        #endregion
        #region tìm kiếm
        /// <summary>
        /// tìm theo tên gần đúng
        /// </summary>
        private void Txb_SearchSuplier_TextChanged(object sender, EventArgs e)
        {
            if (txb_Search.Text =="")
            {
                InputConrol.DataLoad(dgv_View);
            }
        }
        /// <summary>
        /// load lai data khi textbox tìm kiếm trống
        /// </summary>
        private void Btn_Seacrh_Click(object sender, EventArgs e)
        {
            InputConrol.SearchInput(dgv_View, txb_Search);
        }
        #endregion

        
    }
}
