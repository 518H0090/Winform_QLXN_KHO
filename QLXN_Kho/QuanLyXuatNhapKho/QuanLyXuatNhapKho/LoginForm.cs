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

namespace QuanLyXuatNhapKho
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
           
        }
        

        /// <summary>
        /// thực hiện việc đăng nhập
        /// </summary>
        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
       
            string userName = txb_UserName.Text;
            string password = txb_Password.Text;
            //kiểm tra xem có trống ko
            if (userName == "" || password == "")
            {
                MessageBox.Show("Vui lòng điền tài khoản và mật khẩu!!");
            }
            else
            {
                //kiểm việc đăng nhập
                if (Login(userName, password))
                {
                   //mở form main và truyền username vào hàm khởi tạo
                   //mục đích để có thể phần quyền 
                   //và còn sẽ sử dụng lại username này rất nhiều
                    MainForm mainForm = new MainForm(userName);
                    this.Hide();
                    mainForm.ShowDialog();
                    //clear textbox
                    txb_UserName.Text = "";
                    txb_Password.Text = "";
                    //nếu như người dùng thoát ở main form thì cũng  như tắt chương trình
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại:\n1.Sai tài khoản hoặc mật khẩu." +
                                                       "\n2.Tài khoản này đã bị khóa");
                    //clear textbox password ...... tại thấy thường đăng nhâp nó như vậy =))
                    txb_Password.Text = "";

                }
            }

        }
        /// <summary>
        /// hàm này sẽ là hàm kiểm tra việc login thành công hay ko
        /// bằng cách gọi hàm dưới control 
        /// thành công thì true
        /// thất bại thì false
        /// </summary>
        bool Login(string userName, string password)
        {
            return LoginControl.CheckLogin(userName, password);
        }
    
    }
}
