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
    public partial class FormSuplier : Form
    {
        public FormSuplier()
        {
            InitializeComponent();
            SuplierControl.DataLoad(dgv_View);
            LockTextBox();
        }
        #region kiểm tra và lock các button
        /// <summary>
        /// kiểm tra các textbox có trống ko
        /// </summary>
        private bool CheckTextBoxInfro()
        {
            if (txb_DisplayName.Text == "" || txb_Phone.Text == "" || txb_Address.Text == "")
                return false;
            return true;

        }
        /// <summary>
        /// lock các button lại 
        /// </summary>
        private void LockTextBox()
        {
            if (!CheckTextBoxInfro())
            {
                btn_AddSuplier.Enabled = false;
                btn_EditSuplier.Enabled = false;
                btn_DeleteSuplier.Enabled = false;
            }
            else
            {
                btn_AddSuplier.Enabled = true;
                btn_EditSuplier.Enabled = true;
                btn_DeleteSuplier.Enabled = true;
            }
        }
        /// <summary>
        ///  load data lên các textbox khi nhấn vào 1 dòng trên datagridview,
        ///  tao 1 biến đễ giữ id đối tượng được chọn nhằm edit và delete đối tượng đó
        /// </summary>
        int IdSelectedSuplier;
        private void Dgv_View_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = dgv_View.Rows[e.RowIndex];

                txb_DisplayName.Text = row.Cells[1].Value.ToString();

                txb_Phone.Text = row.Cells[2].Value.ToString();
                txb_Address.Text = row.Cells[3].Value.ToString();
        
                IdSelectedSuplier = int.Parse(row.Cells[0].Value.ToString());
            }
        }
        ///// <summary>
        ///// kiễm tra khi người dùng thực hiện việc xóa hết kí tự trong textbox để lock buton lại
        ///// </summary>
        private void Dgv_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LockTextBox();
        }

        private void Txb_DisplayName_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_Address_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_Phone_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        private void Txb_MoreInfo_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }
        /// <summary>
        /// hàm này để clear sạch textbot khi người dung edit hoặc delete
        /// </summary>
        void ClearTextbot()
        {
            txb_DisplayName.Clear();
            txb_Address.Clear();
            txb_Phone.Clear();
        }

        #endregion
        #region A,D,E
        /// <summary>
        /// add thêm đối tượng  và load lại data
        /// </summary>

        private void Btn_AddSuplier_Click(object sender, EventArgs e)
        {
            SuplierControl.AddSuplierToData(txb_DisplayName, txb_Address, txb_Phone);
            SuplierControl.DataLoad(dgv_View);
        }
        /// <summary>
        /// edit thêm đối tượng  và load lại data
        /// </summary>
        private void Btn_EditSuplier_Click(object sender, EventArgs e)
        {
            if (dgv_View.Rows.Count != 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn sửa thành nhà cung cấp: " + txb_DisplayName.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SuplierControl.EditSuplierToData(IdSelectedSuplier, txb_DisplayName, txb_Address, txb_Phone);
                    SuplierControl.DataLoad(dgv_View);
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
        /// delete thêm đối tượng  và load lại data
        /// </summary>
        private void Btn_DeleteSuplier_Click(object sender, EventArgs e)
        {
            
            if (dgv_View.Rows.Count != 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp: " + txb_DisplayName.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SuplierControl.DeleteSuplierToData(IdSelectedSuplier);
                    SuplierControl.DataLoad(dgv_View);
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
        #region Tìm kiếm
        ///// <summary>
        ///// tìm theo tên gần đúng
        ///// </summary>

        private void Btn_SeacrhSuplier_Click(object sender, EventArgs e)
        {
            SuplierControl.SearchSuplier(dgv_View, txb_SearchSuplier);
        }
        /// <summary>
        /// load lai data khi textbox tìm kiếm trống
        /// </summary>
        private void Txb_SearchSuplier_TextChanged(object sender, EventArgs e)
        {
            if (txb_SearchSuplier.Text == "")
            {
                SuplierControl.DataLoad(dgv_View);
            }
        }
        #endregion


    }
}
