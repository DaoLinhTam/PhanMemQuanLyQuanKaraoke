using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;

namespace GUI
{
    public partial class FrmDoiMatkhau : DevExpress.XtraEditors.XtraForm
    {

        NguoiDung_DAL nd = new NguoiDung_DAL();
        CauHinh_DAL ch = new CauHinh_DAL();
        string strTenND;
        public FrmDoiMatkhau(string strTenND)
        {
            InitializeComponent();
            this.strTenND = strTenND;
            txtTenTK.Text = strTenND;
            cacSuKien();
        }

        private void cacSuKien()
        {
            btnHuy.Click += btnHuy_Click;
            btnLuu.Click += btnLuu_Click;
        }

        void btnLuu_Click(object sender, EventArgs e)
        {

            //kiểm tra các control có dữ liệu chưa
            if (!KT_FullDuLieu())
                return;

            //kiểm tra mật khẩu cũ có đúng không
            if (ch.checkUser(txtTenTK.Text.Trim(), txtMKCU.Text.Trim()) >= 2)
            {
                MessageBox.Show(" Mật Khẩu Cũ Không Đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //kiểm tra mk mới và cũ có trùng nhau không
            if (!txtMKMoi.Text.Trim().Equals(txtMKMoi2.Text.Trim()))
            {
                MessageBox.Show("Xác Nhận Lại Mật Khẩu Không Đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //nếu mk vừa thay đổi vs mk cũ giống nhau thì không đc 
            if (txtMKCU.Text.Trim().Equals(txtMKMoi.Text.Trim()))
            {
                MessageBox.Show("Mật Khẩu Mới Giống Mật Khẩu Cũ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

           bool check= nd.DoiMatKhau(strTenND,txtMKMoi.Text.Trim());
           if (check)
           {
               MessageBox.Show("Mật Khẩu Đã Được Thay Đổi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               MessageBox.Show("Vui Lòng Đăng Nhập Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Close();
             //Đăng Nhập Lại
               if (Program.frmMain != null)
                   Program.frmMain.Close();
               if (Program.frmDangNhap == null)
               {
                   Program.frmDangNhap = new FrmDangNhap();
               }
               Program.frmDangNhap.Show();
           }

           else
               MessageBox.Show("Thay Đổi Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private bool KT_FullDuLieu()
        {
            string mkCu = txtMKCU.Text.Trim();
            string mkMoi = txtMKMoi.Text.Trim();
            string mkMoi2 = txtMKMoi2.Text.Trim();
            string tenTK = txtTenTK.Text.Trim();

            if (mkCu.Length == 0 || mkMoi.Length == 0 || mkMoi2.Length == 0 || tenTK.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}