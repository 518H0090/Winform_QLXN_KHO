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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            //tắt đi để làm effect cho đẹp :v
            dgv_ViewInput.Visible = false;
            dgv_ViewOutput.Visible = false;


          
        }

        private void Btn_DetailsTon_Click(object sender, EventArgs e)
        {
            //nếu đang tắt thì mở và ngược lại
            if (dgv_ViewInput.Visible == false)
            {
                dgv_ViewInput.Visible = true;
            }
            else
            {
                dgv_ViewInput.Visible = false;
            }
        }
        //nếu đang tắt thì mở và ngược lại
        private void IconButton1_Click(object sender, EventArgs e)
        {
            if (dgv_ViewOutput.Visible == false)
            {
                dgv_ViewOutput.Visible = true;
            }
            else
            {
                dgv_ViewOutput.Visible = false;
            }
        }

      
        /// <summary>
        /// khi người dùng thay đổi giá trị trên datetimepicker  thị load thông kê 
        /// </summary>
        private void Dtp_Month_ValueChanged(object sender, EventArgs e)
        {
            // hiện tổng nhập xuất
            txb_SumInput.Text = StatisticControl.GetCountInputForMonth(dtp_Month.Value,dtp_Year.Value).ToString();
            txb_SumOutput.Text = StatisticControl.GetCountOutputForMonth(dtp_Month.Value, dtp_Year.Value).ToString();
            // hiện ci tiết
            var ListInput=StatisticControl.GetDetailInputForMonth(dtp_Month.Value, dtp_Year.Value, dgv_ViewInput);
            var ListOutput = StatisticControl.GetDetailOutputForMonth(dtp_Month.Value,dtp_Year.Value, dgv_ViewOutput);
           
           //clear các  biểu đồ 
            cht_Input.Series[0].Points.Clear();
            cht_Output.Series[0].Points.Clear();
            //sắp sếp lại list giảm dần -> do ta chỉ muốn tối đa 6 mặt hàng nhập xuất nhiều nhất
            var SortListInput = ListInput.OrderByDescending(p => p.Count);
            var SortListOutput = ListOutput.OrderByDescending(p => p.Count);

            //biến i để có tác dụng là khi lấy dc 6 thằng đầu thì break khỏi vòng lặp
            //đồng thời nếu như có ít hơn 6 thì có thể linh hoạt sửa lại số cho 2 label 
            int i = 0;
            foreach (var item in SortListInput)
            {
                //kiểm tra nếu i>2 thì out do t chỉ lấy 3 mặt hàng
                // nếu có mặt hàng nào mà sl =0  có nghĩa là hết mặt đã hàng nhập xuất thì cũng phải break ra
                if (i > 2 || item.Count == 0)
                {
                    break;   
                }
                //add vào biểu đồ 
                cht_Input.Series[0].Points.AddXY(item.Object.DisplayName.ToString(), item.Count);
                i++;
            }
            //gắn giá trị text  của label bằng i (sl hàng để duyệt trên kia) bt tối đa là 6 mặt hàng
            lbl_TopInput.Text = i.ToString() + " Mặt hàng nhập nhều nhất";
            //gán lại i =0 để qua làm output
            i = 0;
            foreach (var item in SortListOutput)
            {
                //kiểm tra nếu i>2 thì out do t chỉ lấy 3 mặt hàng
                // nếu có mặt hàng nào mà sl =0  có nghĩa là hết mặt đã hàng nhập xuất thì cũng phải break ra
                if (i > 2 || item.Count==0)
                {
                    break;
                }
                //add vào biểu đồ
                cht_Output.Series[0].Points.AddXY(item.Object.DisplayName.ToString(), item.Count);
                i++;
            }
            //gắn giá trị text  của label bằng i (sl hàng để duyệt trên kia) bt tối đa là 6 mặt hàng
            lbl_TopOutput.Text = i.ToString() + " Mặt hàng xuất nhều nhất";


        }
        /// <summary>
        /// hàm này thông kê cả năm dc chọn trên datetimepicker
        /// </summary>
       
        private void Btn_Year_Click(object sender, EventArgs e)
        {
            txb_SumInput.Text = StatisticControl.GetCountInputForYear(dtp_Year.Value).ToString();
            txb_SumOutput.Text = StatisticControl.GetCountOutputForYear(dtp_Year.Value).ToString();
            var ListInput = StatisticControl.GetDetailInputForYear(dtp_Year.Value, dgv_ViewInput);
            var ListOutput = StatisticControl.GetDetailOutputForYear(dtp_Year.Value, dgv_ViewOutput);


            cht_Input.Series[0].Points.Clear();
            cht_Output.Series[0].Points.Clear();
            var SortListInput = ListInput.OrderByDescending(p => p.Count);
            var SortListOutput = ListOutput.OrderByDescending(p => p.Count);


            int i = 0;
            foreach (var item in SortListInput)
            {
                if (i > 5 || item.Count == 0)
                {
                    break;
                }
                cht_Input.Series[0].Points.AddXY(item.Object.DisplayName.ToString(), item.Count);
                i++;
            }
            lbl_TopInput.Text = i.ToString() + " Mặt hàng nhập nhều nhất";
            i = 0;
            foreach (var item in SortListOutput)
            {
                if (i > 5 || item.Count == 0)
                {
                    break;
                }
                cht_Output.Series[0].Points.AddXY(item.Object.DisplayName.ToString(), item.Count);
                i++;
            }
            lbl_TopOutput.Text = i.ToString() + " Mặt hàng xuất nhều nhất";
        }

       
    }
}
