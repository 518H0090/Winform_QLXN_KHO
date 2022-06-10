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
    
    public partial class FormOutput : Form
    {
        //tạo một biến để hứng giá trị usename đang login vào
        //mục đích để có dc id, displayName của user đang đăng nhập
        public string UserNameLogining_;
        public FormOutput(string UserNameLogining)
        {
            InitializeComponent();
            //load data
            OutputControl.DataLoad(dgv_View);
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
            if (txb_DisplayNameUser.Text == "" && txb_DisplayNameObject.Text == "" && txb_OutputDate.Text == "")
                return false;
            return true;
        
        }
        private void LockTextBox()
        {
            if (!CheckTextBoxInfro())
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
            }
            else
            {
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
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
        int IdSelectedOutputInfo;
        private void Dgv_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = dgv_View.Rows[e.RowIndex];

                txb_DisplayNameObject.Text = row.Cells[2].Value.ToString();
                // chỉ lấy ngày tháng năm nên cắt chuổi
                txb_OutputDate.Text = row.Cells[3].Value.ToString().Substring(0, 10);
                nud_Cout.Text = row.Cells[4].Value.ToString();
                //lấy sl của mặt hàng  đang chọn 
                OldCount = int.Parse(row.Cells[4].Value.ToString());
                nud_OutputPrice.Text = row.Cells[5].Value.ToString();
                txb_DisplayNameUser.Text = row.Cells[6].Value.ToString();

                IdSelectedOutputInfo = int.Parse(row.Cells[1].Value.ToString());
            }
        }
        /// <summary>
        /// hàm này để clear sạch textbot khi người dùng edit hoặc delete
        /// </summary>
        void ClearTextbot()
        {
            txb_DisplayNameObject.Clear();
            txb_DisplayNameUser.Clear();
            txb_OutputDate.Clear();
        }
        #endregion
        #region A,D,E
        /// <summary>
        /// hàm này để lập phiếu, mở form lập phiếu lên,load lại data,update list tồn kho
        /// </summary>
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //mở form lập phiếu 
            // truyền username đang login vào hàm khởi tạo 
            FormReceiptOutputInfo outputInfo = new FormReceiptOutputInfo(UserNameLogining_);
            outputInfo.ShowDialog();
            //sau khi lập phiếu thành công thì load lại data
            OutputControl.DataLoad(dgv_View);
            //update lại list sl tồn 
            FormTonKho tonKho = new FormTonKho();
            tonKho.UpdateListTonKho();
        }
        /// <summary>
        /// edit đối tượng  và load lại data,,update list tồn kho
        /// </summary>
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn sửa phiếu xuất này không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //muốn sửa thì phải cần có list tồn ko để kiểm tra 
                FormTonKho tonKho = new FormTonKho();
                //lấy list tồn kho
                var list = tonKho.getListTonKho();
                //thực hiện việc sửa, đưa cả list tồn kho xuống hàm ở control để kt 
                OutputControl.EditOutputInfo(list, txb_DisplayNameObject, nud_Cout, nud_OutputPrice, IdSelectedOutputInfo, OldCount);
                //load lại data
                OutputControl.DataLoad(dgv_View);
                //update lại tồn kho
                tonKho.UpdateListTonKho();
                //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
                ClearTextbot();
            }
           
        }
        /// <summary>
        /// delete đối tượng  và load lại data,,update list tồn kho
        /// </summary>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có chắc muốn xuất phiếu xuất này không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                OutputControl.DeleteOutputInfo(txb_DisplayNameObject, IdSelectedOutputInfo);
                //load lại data
                OutputControl.DataLoad(dgv_View);
                //update lại tồn kho
                FormTonKho tonKho = new FormTonKho();
                tonKho.UpdateListTonKho();
                //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
                ClearTextbot();
            }

        }
        #endregion
        #region tìm kiếm
        /// <summary>
        /// load lai data khi textbox tìm kiếm trống
        /// </summary
        private void Txb_SearchSuplier_TextChanged(object sender, EventArgs e)
        {
            OutputControl.DataLoad(dgv_View);
        }
        ///// <summary>
        ///// tìm theo tên gần đúng
        ///// </summary>
        private void Btn_SeacrhSuplier_Click(object sender, EventArgs e)
        {
            OutputControl.SearchOutput(dgv_View, txb_SearchSuplier);
        }
        #endregion
    }
}
