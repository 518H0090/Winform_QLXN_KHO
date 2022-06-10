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
    public partial class FormObject : Form
    {
        public FormObject()
        {
            InitializeComponent();
            LockTextBox();
            ObjectControl.DataLoad(dgv_View);
            ObjectControl.GetListUnitToCMB(cmb_Unit);//đổ list unit vào cmbox ngay khi gọi formnay
            ObjectControl.GetListSuplierToCMB(cmb_Suplier);//đổ list suplier vào cmbox ngay khi gọi formnay
        }
        #region kiểm tra và lock các button
        /// <summary>
        /// kiểm tra các textbox có trống ko
        /// </summary>
        private bool CheckTextBoxInfro()
        {
            if (txb_DisplayName.Text == "" || cmb_Unit.Text == "" || cmb_Suplier.Text == "")
                return false;
            return true;

        }
        private void LockTextBox()
        {
            if (!CheckTextBoxInfro())
            {
                btn_AddObject.Enabled = false;
                btn_EditObject.Enabled = false;
                btn_DeleteObject.Enabled = false;
            }
            else
            {
                btn_AddObject.Enabled = true;
                btn_EditObject.Enabled = true;
                btn_DeleteObject.Enabled = true;
            }
            
        }
        private void Txb_DisplayName_TextChanged(object sender, EventArgs e)
        {
            LockTextBox();
        }

        /// <summary>
        ///  load data lên các textbox khi nhấn vào 1 dòng trên datagridview,
        ///  tao 1 biến đễ giữ id đối tượng được chọn nhằm edit và delete đối tượng đó
        /// </summary>
        int IdSelectedObject;

        private void Dgv_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = dgv_View.Rows[e.RowIndex];

                txb_DisplayName.Text = row.Cells[1].Value.ToString();

                cmb_Unit.Text = row.Cells[2].Value.ToString();
                cmb_Suplier.Text = row.Cells[3].Value.ToString();

                IdSelectedObject = int.Parse(row.Cells[0].Value.ToString());
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
        private void Btn_AddObject_Click(object sender, EventArgs e)
        {
            //tạo hai biến giữ id của Unit và Id suplier đang được chọn ở combobox
            int idUnit = Convert.ToInt32(cmb_Unit.SelectedValue.ToString());
            int idSuplier = Convert.ToInt32(cmb_Suplier.SelectedValue.ToString());
            ObjectControl.AddObjectToData(txb_DisplayName, idUnit, idSuplier);
            ObjectControl.DataLoad(dgv_View);
        }
        /// <summary>
        /// edit đối tượng  và load lại data
        /// </summary>
        private void Btn_EditObject_Click(object sender, EventArgs e)
        {
            if (dgv_View.Rows.Count != 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn sửa hàng thành: " + txb_DisplayName.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //tạo hai biến giữ id của Unit và Id suplier đang được chọn ở combobox
                    int idUnit = Convert.ToInt32(cmb_Unit.SelectedValue.ToString());
                    int idSuplier = Convert.ToInt32(cmb_Suplier.SelectedValue.ToString());
                    ObjectControl.EditObjectToData(IdSelectedObject, txb_DisplayName, idUnit, idSuplier);
                    ObjectControl.DataLoad(dgv_View);
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
        /// delete  đối tượng  và load lại data
        /// </summary>
        private void Btn_DeleteObject_Click(object sender, EventArgs e)
        {
           
            if (dgv_View.Rows.Count != 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng: " + txb_DisplayName.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ObjectControl.DeleteObjectToData(IdSelectedObject);
                    ObjectControl.DataLoad(dgv_View);
                }
                //clear textbox để tránh lỗi do người dùng vẫn còn có thể bấm edit hay delete
                ClearTextbot();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa hay sửa","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion
        #region tìm kiếm
        /// <summary>
        /// load lai data khi textbox tìm kiếm trống
        /// </summary>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ObjectControl.DataLoad(dgv_View);
        }
        /// <summary>
        /// tìm theo tên gần đúng
        /// </summary>

        private void Btn_SeacrhObject_Click(object sender, EventArgs e)
        {
            ObjectControl.SearchObject(dgv_View,textBox1);
        }
        #endregion
    }
}
