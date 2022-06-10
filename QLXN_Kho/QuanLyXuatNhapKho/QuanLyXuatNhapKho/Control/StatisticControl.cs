using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace QuanLyXuatNhapKho.Control
{
    public class StatisticControl
    {
        // tạo hai thuộc tính gồm: mặt hàng và sl, sẽ có list thuộc kiểu  StatisticControl  để tiện cho việc thông kê
        public Model.Object Object { get; set; }
        public int Count{ get; set; }
        #region lấy  lại tổng số lượng trong tháng hoặc cả năm
        // cả 4 hàm này đều sẽ lấy lấy tổng số lượng nhập và xuất trong tháng hay cả năm
        // 2 hàm trên sẽ theo tháng  nhưng cũng phải so sánh cả năm để biết tháng này của năm nào
        // 2 hàm dưới sẽ theo năm  
        // cả 4 hàm đều trả lại một biến chứa tổng sl, mặc định =0
        public static int GetCountInputForMonth(DateTime month, DateTime year) 
        {
            //tạo biến tổng, mặc định=0;
            int CountInput = 0;
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                //lấy ra list thuộc tháng đó
                var ListObjectInMonth = dbo.InputInfo.Where(p => p.Input.DateInput.Month == month.Month && p.Input.DateInput.Year == year.Year).ToList();
                //nếu như list ko null thì thực hiện việc sum sl 
                if (ListObjectInMonth.Count > 0)
                {
                    CountInput = (int)ListObjectInMonth.Sum(p => p.Count);
                }
                //trả về tổng 
                return CountInput;
            }
        }
        public static int GetCountOutputForMonth(DateTime month, DateTime year)
        {
            int CountOutput = 0;
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var ListObjectInMonth = dbo.OutputInfo.Where(p => p.Output.DateOutput.Month == month.Month && p.Output.DateOutput.Year== year.Year).ToList();
                if (ListObjectInMonth.Count > 0)
                {
                    CountOutput = (int)ListObjectInMonth.Sum(p => p.Count);
                }
                return CountOutput;
            }
        }
        public static int GetCountInputForYear(DateTime year)
        {
            int CountOutput = 0;
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var ListObjectInMonth = dbo.OutputInfo.Where(p => p.Output.DateOutput.Year == year.Year).ToList();
                if (ListObjectInMonth.Count > 0)
                {
                    CountOutput = (int)ListObjectInMonth.Sum(p => p.Count);
                }
                return CountOutput;
            }
        }
        public static int GetCountOutputForYear(DateTime year)
        {
            int CountOutput = 0;
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var ListObjectInMonth = dbo.OutputInfo.Where(p => p.Output.DateOutput.Year == year.Year).ToList();
                if (ListObjectInMonth.Count > 0)
                {
                    CountOutput = (int)ListObjectInMonth.Sum(p => p.Count);
                }
                return CountOutput;
            }
        }
        #endregion

        #region load lên 2 datagridview chi tiết sl  trong tháng hay năm
        // cả 4 hàm này đều sẽ load lên 2 datagridview chi tiết sl nhập và xuất trong tháng hay cả năm
        // 2 hàm trên sẽ theo tháng  nhưng cũng phải so sánh cả năm để biết tháng này của năm nào
        // 2 hàm dưới sẽ theo năm  
        // cả 4 hàm đều trả về list ds có tên hàng và sl để làm biểu đồ
        public static List<StatisticControl> GetDetailInputForMonth(DateTime month, DateTime year, DataGridView dgv_ViewInput)
        {
            // khởi tạo list ds  để làm biểu đồ
            List<StatisticControl> listStatisticInput = new List<StatisticControl>();
           
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                //lấy ra list mặt hàng
                var ListObject = dbo.Object.ToList();
                //kt xem có null ko
                if (ListObject.Count > 0)
                {
                    // chạy để duyệt từng mặt hàng
                    foreach (var item in ListObject)
                    {
                        // lấy ra list chi tiết phiếu  có mặt hàng đang duyệt trong tháng 
                        var InputList = dbo.InputInfo.Where(p => p.IdObject == item.Id && p.Input.DateInput.Month == month.Month && p.Input.DateInput.Year == year.Year);
                        
                        // tạo biến sum( sẽ chứa tổng sl của mặt hàng trong tháng = cách + tất cả sl trong ds phiếu trên)
                        int SumInput = 0;
                        // kt xem có null ko
                        if (InputList.Count() > 0)
                        {
                            SumInput = (int)InputList.Sum(p => p.Count);
                        }
                        // tạo 1 biến để giử hai giá trị  hàng và sl 
                        StatisticControl statisticInput = new StatisticControl();
                        statisticInput.Object = item;
                        statisticInput.Count = SumInput;
                        // ad vào list
                        listStatisticInput.Add(statisticInput);

                    }
                    var rdInput = from c in listStatisticInput select new { DisplayNameObject = c.Object.DisplayName, c.Count };
                    //load lên datagridview
                    dgv_ViewInput.DataSource = rdInput.ToList();
                 
                }

                return listStatisticInput; 
            }
        }
        public static List<StatisticControl> GetDetailOutputForMonth(DateTime month, DateTime year, DataGridView dgv_ViewOuput)
        {
           
            List<StatisticControl> listStatisticOutput = new List<StatisticControl>();
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var ListObject = dbo.Object.ToList();
                if (ListObject.Count > 0)
                {
                    foreach (var item in ListObject)
                    {

                        var OutputList = dbo.OutputInfo.Where(p => p.IdObject == item.Id && p.Output.DateOutput.Month == month.Month && p.Output.DateOutput.Year == year.Year);


                        int SumOutPut = 0;
                        if (OutputList.Count() > 0)
                        {
                            SumOutPut = (int)OutputList.Sum(p => p.Count);
                        }
                        StatisticControl statisticOutput = new StatisticControl();
                        statisticOutput.Object = item;
                        statisticOutput.Count = SumOutPut;
                        listStatisticOutput.Add(statisticOutput);
                    }

                    var rdOutput = from c in listStatisticOutput select new { DisplayNameObject = c.Object.DisplayName, c.Count };

                    dgv_ViewOuput.DataSource = rdOutput.ToList();
                }
                return listStatisticOutput;
            }
        }
        public static List<StatisticControl> GetDetailInputForYear(DateTime year, DataGridView dgv_ViewInput)
        {
            List<StatisticControl> listStatisticInput = new List<StatisticControl>();

            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var ListObject = dbo.Object.ToList();
                if (ListObject.Count > 0)
                {
                    foreach (var item in ListObject)
                    {
                        var InputList = dbo.InputInfo.Where(p => p.IdObject == item.Id &&  p.Input.DateInput.Year == year.Year);


                        int SumInput = 0;
                        if (InputList.Count() > 0)
                        {
                            SumInput = (int)InputList.Sum(p => p.Count);
                        }
                        StatisticControl statisticInput = new StatisticControl();
                        statisticInput.Object = item;
                        statisticInput.Count = SumInput;
                        listStatisticInput.Add(statisticInput);

                    }
                    var rdInput = from c in listStatisticInput select new { DisplayNameObject = c.Object.DisplayName, c.Count };

                    dgv_ViewInput.DataSource = rdInput.ToList();

                }
                return listStatisticInput;
            }
        }
        public static List<StatisticControl> GetDetailOutputForYear(DateTime year, DataGridView dgv_ViewOuput)
        {

            List<StatisticControl> listStatisticOutput = new List<StatisticControl>();
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var ListObject = dbo.Object.ToList();
                if (ListObject.Count > 0)
                {
                    foreach (var item in ListObject)
                    {

                        var OutputList = dbo.OutputInfo.Where(p => p.IdObject == item.Id && p.Output.DateOutput.Year == year.Year);


                        int SumOutPut = 0;
                        if (OutputList.Count() > 0)
                        {
                            SumOutPut = (int)OutputList.Sum(p => p.Count);
                        }
                        StatisticControl statisticOutput = new StatisticControl();
                        statisticOutput.Object = item;
                        statisticOutput.Count = SumOutPut;
                        listStatisticOutput.Add(statisticOutput);
                    }

                    var rdOutput = from c in listStatisticOutput select new { DisplayNameObject = c.Object.DisplayName, c.Count };

                    dgv_ViewOuput.DataSource = rdOutput.ToList();
                }
                return listStatisticOutput;
            }
        }
        #endregion
    }
}
