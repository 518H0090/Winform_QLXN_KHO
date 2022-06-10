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
    public partial class FormUnit : Form
    {

        public FormUnit()
        {
            InitializeComponent();
            //Load dữ liệu lên dataGridView ngay khi chọn vào trang Unit
            UnitControl.DataLoad(dgv_View);
            // disEable các button Add,edit,delete đễ trách ko có dữ liệu trong các textbox mà người dùng vẫn bấm
            LockTextBox();
        }
        #region kiểm tra và lock các button
        /// <summary>
        /// kiểm tra các textbox có trống ko
        /// </summary>
        private bool CheckTextBoxInfro()
        {
            if (txb_DisplayName.Text == "")
                return false;
            return true;

        }
        /// <summary>
        /// lock (disEnable) các button A,E,D ngay khi thấy có 1 textbox trống, ngược lại enable
        /// </summary>
        private void LockTextBox()
        {
            if (!CheckTextBoxInfro())
            {
                btn_AddUnit.Enabled = false;
                btn_EditUnit.Enabled = false;
                btn_DeleteUnit.Enabled = false;
            }
            else
            {
                btn_AddUnit.Enabled = true;
                btn_EditUnit.Enabled = true;
                btn_DeleteUnit.Enabled = true;
            }
        }
        /// <summary>
        /// kiễm tra khi người dùng thực hiện việc xóa hết kí tự trong textbox để lock buton lại
        /// </summary>
        private void Txb_DisplayName_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }
        /// <summary>
        ///  load data lên các textbox khi nhấn vào 1 dòng trên datagridview,
        ///  tao 1 biến đễ giữ id đối tượng được chọn nhằm edit và delete đối tượng đó
        /// </summary>
        int IdSelectedUnit;
        private void Dgv_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = dgv_View.Rows[e.RowIndex];

                txb_DisplayName.Text = row.Cells[1].Value.ToString();
                IdSelectedUnit = int.Parse(row.Cells[0].Value.ToString());
            }
        }
        /// <summary>
        /// hàm này để clear sạch textbot khi người dung edit hoặc delete
        /// </summary>
        void ClearTextbot()
        {
            txb_DisplayName.Clear();
        }
        #endregion


        #region Add,Edit,Delete
        /// <summary>
        /// add thêm đối tượng  và load lại data
        /// </summary>

        private void Btn_AddUnit_Click(object sender, EventArgs e)
        {

            UnitControl.AddUnitToData(txb_DisplayName);
            UnitControl.DataLoad(dgv_View);
        }

        /// <summary>
        /// edit đối tượng  và load lại data
        /// </summary>
        private void Btn_EditUnit_Click(object sender, EventArgs e)
        {
            if (dgv_View.Rows.Count != 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn sửa đơn vị thành: " + txb_DisplayName.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    UnitControl.EditUnitToData(txb_DisplayName, IdSelectedUnit);
                    UnitControl.DataLoad(dgv_View);
                }
                //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
                ClearTextbot();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa hay sửa", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// delete đối tượng  và load lại data
        /// </summary>
        private void Btn_DeleteUnit_Click(object sender, EventArgs e)
        {
           
            if (dgv_View.Rows.Count != 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn vị: " + txb_DisplayName.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    UnitControl.DeleteUnitToData(IdSelectedUnit);
                    UnitControl.DataLoad(dgv_View);
                }
                //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
                ClearTextbot();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa hay sửa", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region tìm kiếm
        /// <summary>
        /// tìm theo tên gần đúng
        /// </summary>
        private void Btn_SeacrhUnit_Click(object sender, EventArgs e)
        {
            UnitControl.SearchUnit(dgv_View, txb_SearchUnit);
        }

        /// <summary>
        /// load lai data khi textbox tìm kiếm trống
        /// </summary>
        private void Txb_SearchUnit_TextChanged(object sender, EventArgs e)
        {
            if (txb_SearchUnit.Text == "")
            {
                UnitControl.DataLoad(dgv_View);
            }
        }
        #endregion

        
    }
}
