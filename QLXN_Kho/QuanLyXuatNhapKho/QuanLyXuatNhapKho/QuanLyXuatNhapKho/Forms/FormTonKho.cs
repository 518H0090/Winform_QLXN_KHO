using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace QuanLyXuatNhapKho.Forms
{
    public partial class FormTonKho : Form
    {
        //tạo list tốn kho để cho ở class nhập xuất dó thể sài dc 
        public List<TonKhoControl> listTonKho;
        public FormTonKho()
        {
            InitializeComponent();
            //thông kê tồn và load lên dataGirdview
            listTonKho= TonKhoControl.GetListTonKho(dgv_View);
            cmb_SearchTonKho.SelectedIndex=0;
        }
        /// <summary>
        /// hàm này để khi nhap, xuat xoa, sửa... thì cập nhập lại sl tồn
        /// </summary>
        public void UpdateListTonKho()
        {
            listTonKho = TonKhoControl.GetListTonKho(dgv_View);
        }
        //lấy lại list tồn kho
        public List<TonKhoControl> getListTonKho()
        {
            return listTonKho;
        }
        /// <summary>
        /// khi người dùng xóa trong textbox thì load lại data 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txb_SearchTonkho_TextChanged(object sender, EventArgs e)
        {
            if (txb_SearchTonkho.Text == "")
            {
                listTonKho = TonKhoControl.GetListTonKho(dgv_View);
            }

        }
        /// <summary>
        /// hàm này để tìm kiếm
        /// </summary>
        private void Btn_SeacrhTonKho_Click(object sender, EventArgs e)
        {
            // Biến này có tác dụng biết người dùng muốn tìm theo loại gì dựa vào index của combobox
            int TypeSearch = cmb_SearchTonKho.SelectedIndex;
            TonKhoControl.SearchTonKho(dgv_View, txb_SearchTonkho,TypeSearch);
        }
    }
}
