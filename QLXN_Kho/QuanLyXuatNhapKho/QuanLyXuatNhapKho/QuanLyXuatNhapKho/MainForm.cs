using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyXuatNhapKho.Control;
using QuanLyXuatNhapKho.Forms;

namespace QuanLyXuatNhapKho
{

    public partial class MainForm : Form
    {
        #region desgin button,effect chuyển form
        private IconButton currentBtn;
        private Panel leftBorderBtn = new Panel() { Size = new Size(7, 60) };
        private Color colorButtonSelected = Color.Coral;
        private Form activeForm;
        #endregion
        //tạo một biến để hứng giá trị usename đang login vào
        //ở đây ta sẽ bắt đầu phân quyền
        //đồng thời sẽ dùng ở form input, output
        public string UserNameLogining;
        public MainForm(string UserName)
        {
            InitializeComponent();
            pnl_MenuStrip.Controls.Add(leftBorderBtn);
            //hứng user đang login vào
            UserNameLogining = UserName;
            //gán vào label tên người dùng ở góc phải màn hình
            // mục đích cho đẹp :v
            lbl_DisplayName.Text = AccoutControl.getLoginDisplayName(UserName);
            //thực hiện phân quyền user
            //bằng cách dùng hàm ở dưới AccoutControl 
            //xem accout này là của quản lí hay nhân viên
            // nếu của nhân viên thì hàm sẽ trả lại fasle và gắn và thuộc tính visible của button Staff(user hay quản lí accout)
            //->button đó sẽ mất để nhân viên ko vào dc form QL Staff(user hay quản lí accout)
            //ngược lại nếu của Quản lí thì trả lại true sẽ hiện lên 
            btn_Staff.Visible = AccoutControl.CheckAccout(UserName);
            
            //mặt định khi người mở chương trình thì mở form tồn kho đầu tiên
            //mục đích để cập nhật lại list tồn kho ngay khi mở chương trình
            openChildForm(new Forms.FormTonKho(), btn_TonKho);
        }

        #region desgin event button
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31,30,68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                
            }
        }
        private void Btn_TonKho_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormTonKho(), sender);
        }
        private void Btn_Input_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormInput(UserNameLogining), sender);
        }

        private void Btn_Output_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormOutput(UserNameLogining), sender);
        }

        private void Btn_Object_Click(object sender, EventArgs e)

        {
            openChildForm(new Forms.FormObject(), sender);
        }

        private void Btn_Suplier_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Forms.FormSuplier(), sender);
        }
        private void Btn_ObjectUnit_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Forms.FormUnit(), sender);
        }

        private void Btn_Suplier_Click_1(object sender, EventArgs e)
        {
           
            openChildForm(new Forms.FormSuplier(), sender);
        }
        private void Btn_ThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormThongKe(), sender);
        }

        private void Btn_Staff_Click(object sender, EventArgs e)
        {
           
            openChildForm(new Forms.FormStaff(), sender);
        }

        private void openChildForm(Form childForm, object btnsender)
        {
            if(activeForm!= null)
            {
                activeForm.Close();
            }
            ActivateButton(btnsender,colorButtonSelected);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_FormChild.Controls.Add(childForm);
            this.pnl_FormChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = currentBtn.Text;
            pbx_Icon.IconChar = currentBtn.IconChar;
        }



        #endregion
        /// <summary>
        /// Thực hiện việc đăng xuất
        /// </summary>
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        /// Thực hiện việc đổi pass
        private void Button3_Click(object sender, EventArgs e)
        {
            
            FormChangePass formChangePass = new FormChangePass(UserNameLogining);
            formChangePass.ShowDialog();
        }

        
    }
}
