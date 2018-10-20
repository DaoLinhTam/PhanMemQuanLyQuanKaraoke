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
using BUS;

namespace GUI
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        CauHinh_BUS cauhinh = new CauHinh_BUS();
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

        void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void chkLuuMK_CheckedChanged(object sender, EventArgs e)
        {
            cauhinh.saveState_Chk(chkLuuMK.Checked);
        }

        void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (chkLuuMK.Checked = cauhinh.loadState_Chk())
            {
               
                txtMK.Text = cauhinh.Load_Pass();
                txtTenTK.Text = cauhinh.Load_User();
            }
            else
            {
                txtTenTK.Text = string.Empty;
                txtMK.Text = string.Empty;
                chkLuuMK.Checked = false;
            }

        }

        void btnDN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTK.Text.Trim()))
            {
                
                this.txtTenTK.Focus();
                MessageBox.Show("Vui Lòng Nhập Tên Đăng Nhập!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(txtMK.Text.Trim()))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Mật Khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                this.txtMK.Focus();
                return;
            }
            int k = cauhinh.Check_Config();
            

            if (k == 0) //chuoi cau hinh đúng
            {
                XuLyDangNhap();
            }
            else if (k == 1)
            {
                MessageBox.Show("Chuỗi Cấu Hình Không Tồn Tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                XuLyCauHinh();
            }
            else
            {
                MessageBox.Show("Chuỗi Cấu Hình Không Đúng!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XuLyCauHinh();
            }
        }

        private void XuLyDangNhap()
        {
            int k = cauhinh.checkUser(txtTenTK.Text, txtMK.Text);
            if(k==2)
                MessageBox.Show("Tên Tài Khoản Hoặc Password Bị Sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (k == 1)
                MessageBox.Show("Tài Khoản Đã Bị Khóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (k == 3)
            {
                MessageBox.Show("Cấu Hình Không Đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XuLyCauHinh();
            }
            else
            {
                if (chkLuuMK.Checked)
                    cauhinh.SaveAccount(txtTenTK.Text, txtMK.Text);

                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Show();
            }
        }

        private void XuLyCauHinh()
        {
            //đang nhập thành công check luu mk
           
            this.Hide();
            FrmCauHinh frmCauHinh = new FrmCauHinh();
            frmCauHinh.ShowDialog();
            this.Show();            
        }


    }
}