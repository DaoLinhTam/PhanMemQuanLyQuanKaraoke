using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;

namespace GUI
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        CauHinh_DAL cauhinh = new CauHinh_DAL();
        public FrmDangNhap()
        {
            InitializeComponent();
            CacSuKien();

        }

        private void CacSuKien()
        {
            btnDN.Click += btnDN_Click;
            this.Load += FrmDangNhap_Load;
            chkLuuMK.CheckedChanged += chkLuuMK_CheckedChanged;
            btnThoat.Click += btnThoat_Click;
        }


        //thoát chương trình
        void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //xử ly lưu mật khẩu
        void chkLuuMK_CheckedChanged(object sender, EventArgs e)
        {
            cauhinh.saveState_Chk(chkLuuMK.Checked);
        }

        //Load from Đăng Nhập
        void FrmDangNhap_Load(object sender, EventArgs e)
        {
            //loadState_Chk() : load trạng thái checkbox từ appconfig
            if (chkLuuMK.Checked = cauhinh.loadState_Chk())  
            {
               
                txtMK.Text = cauhinh.Load_Pass();  //Load pass từ appconfig
                txtTenTK.Text = cauhinh.Load_User();  //load user từ appconfig
            }
            else  //nếu không có lưu mk thì gán trống textbox
            {
                txtTenTK.Text = string.Empty;
                txtMK.Text = string.Empty;
                chkLuuMK.Checked = false;
            }

           

        }


        //Xử ly nút đăng nhập
        void btnDN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTK.Text.Trim()))   //nếu tên mk trống
            {
                
                this.txtTenTK.Focus();
                MessageBox.Show("Vui Lòng Nhập Tên Đăng Nhập!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(txtMK.Text.Trim()))  //nếu tên pass trống
            {
                MessageBox.Show("Vui Lòng Nhập Tên Mật Khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                this.txtMK.Focus();
                return;
            }
            //dùng biến k để check cấu hình
            //nếu k=0 kết nối thnahf công
            //nếu k=1 kết nối chuỗi k tồn tại
            //nếu k=2 chuỗi cấu hình k phù hợp
            int k = cauhinh.Check_Config();
            

            if (k == 0) //chuoi cau hinh đúng
            {
                XuLyDangNhap(); 
            }
            else if (k == 1) // kết nối chuỗi k tồn tại
            {
                MessageBox.Show("Chuỗi Cấu Hình Không Tồn Tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XuLyCauHinh(); //thực hiện xử lý cấu hình
            }
            else
            {
                MessageBox.Show("Chuỗi Cấu Hình Không Đúng!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XuLyCauHinh();//thực hiện xử lý cấu hình
            }
        }

        private void XuLyDangNhap()
        {
            //tạo biến k để checkUser xem có csdl có tên nd này hay không
            int k = cauhinh.checkUser(txtTenTK.Text, txtMK.Text);
            if(k==2)
                MessageBox.Show("Tên Tài Khoản Hoặc Password Bị Sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (k == 1)
                MessageBox.Show("Tài Khoản Đã Bị Khóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (k == 3)
            {
                MessageBox.Show("Chọn Sai Database.Vui Lòng Cấu Hình Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XuLyCauHinh();
            }
            else  //k==0
            {
                if (chkLuuMK.Checked)  //nếu có bật lưu mk thì mật mk xuống appconfig
                    cauhinh.SaveAccount(txtTenTK.Text, txtMK.Text);


                //xử lý hiện from Main
                if (Program.frmMain == null||Program.frmMain.IsDisposed)
                {
                   //lưu manv xuong app config
                    Properties.Settings.Default.strMANV = txtTenTK.Text;
                    Properties.Settings.Default.Save();
                    Program.frmMain = new FrmMain(txtTenTK.Text.Trim());
                }
                Program.frmMain.Show();
                Program.frmDangNhap.Hide();
            }
        }

        private void XuLyCauHinh()
        {
            
           //Xử lý bật from cấu hình
            this.Hide();
            FrmCauHinh frmCauHinh = new FrmCauHinh();
            frmCauHinh.ShowDialog();
            this.Show();            
        }


    }
}