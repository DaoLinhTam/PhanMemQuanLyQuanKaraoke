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
using GUI.QLKaraokeTableAdapters;

namespace GUI
{
    public partial class FrmQLND : DevExpress.XtraEditors.XtraForm
    {
        NHANVIENTableAdapter nd = new NHANVIENTableAdapter();
        String strConnect = DAL.ProjectSetting.ConnectionString;
        XuLy xl = new XuLy();
        bool stateThem = false; //stateThem=true là đang thêm,false đang sữa
        public FrmQLND()
        {
            InitializeComponent();
            nd.Connection.ConnectionString = strConnect;
            SuKien();
            xl.XuLyGiaoDien_KhiLoad(btnThem, btnXoa, btnSua, btnHuy, btnLuu);
        }


        private void SuKien()
        {
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnHuy.Click += btnHuy_Click;
            btnXoa.Click += btnXoa_Click;
            btnLuu.Click += btnLuu_Click;

        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            //Nếu Đang Thêm
            if (!KiemTraFullData())
                return;
            this.Validate(); //nhaan gia tri
            this.nHANVIENBindingSource.EndEdit();  //ket thuc chinh sua
            this.tableAdapterManager.UpdateAll(this.qLKaraoke);  //cap nhat
            //xu lyGiaoDien
            xl.XuLyGiaoDien_KhiLuu(btnThem, btnXoa, btnSua, btnLuu, btnHuy);
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult t = xl.MessageBoxCanhBao("Bạn có muốn xóa người dùng này không?");
            if (t == DialogResult.Yes)
            {
                if (!KT_HopLeXoa())
                    return;
                //xử lý xóa
                nHANVIENBindingSource.RemoveCurrent();
                xl.MessageBoxThongBao("Xóa Thành Công!");
                btnLuu.PerformClick();
            }
            
        }

        //Kiểm Tra Hợp Lệ Để Xóa
        private bool KT_HopLeXoa()
        {
            if (nHANVIENBindingSource.Count == 0)
            {
                xl.MessageBoxThongBao("Dữ Liệu Nhân Viên Trống");
                return false;
            }
            DataRowView rowview = ((DataRowView)nHANVIENBindingSource.Current);   //Lấy Mã Hiện Tại
            String strMANV = rowview.Row["MANV"].ToString();
            //kiểm tra khóa ngoại
            NguoiDungBindingSource.Filter = "MANV='" + strMANV + "'"; //Lọc dữ liệu người dùng

            int k = NguoiDungBindingSource.Count;  //đêm dữ liếu sau khi lọc
            if (k > 0)
            {
               
                string strTenNV = rowview.Row["TENNV"].ToString();
                xl.MessageBoxThongBaoEror(" Dữ Liệu Nhân Viên Đang Được Dùng \n Không Thể Xóa Nhân Viên " + strTenNV);
                return false;
            }
            return true;
        }

        void btnHuy_Click(object sender, EventArgs e)
        {

            nHANVIENBindingSource.CancelEdit();  //hủy bỏ chỉnh sửa

           //Xóa dong đang thêm dỡ
            //
            xl.XuLyGiaoDien_KhiHuy(btnThem, btnXoa, btnSua, btnLuu, btnHuy);
            

        }

        void btnSua_Click(object sender, EventArgs e)
        {
           
            txtTenNV.Focus();
            //XuLyGiaoDien
            stateThem = false;
            xl.XuLyGiaoDien_KhiSua(btnThem, btnXoa, btnSua, btnLuu, btnHuy);
        }

        void btnThem_Click(object sender, EventArgs e)
        {

           
            nHANVIENBindingSource.AddNew();  //thêm dòng mới cho người dùng nhập
            txtMaNV.Text = xl.AutoID("NV", nd.GetData(), "MANV DESC");
        
            //Xử lý giao diện
            stateThem = true;
            dtpNgaySinh.Text = "";
             xl.XuLyGiaoDien_KhiThem(btnThem, btnXoa, btnSua, btnLuu, btnHuy);

        }

        private bool KiemTraFullData()
        {
            foreach (Control item in tblThongTinNV.Controls)
                if (item.Text.Length == 0)
                {
                    xl.MessageBoxThongBaoEror("Vui Lòng Nhập Đủ Dữ Liệu");
                    item.Focus();
                    return false;
                }

            int k=DateTime.Now.Year - dtpNgaySinh.Value.Year;
            if (k < 18)
            {
                xl.MessageBoxThongBaoEror("Nhân Viên Phải Trên 18 Tuổi");
                return false;
            }
            if (!xl.KiemTraSDT_HopLe(txtSDT))
                  return false;
                    
            return true;
        }
        private void FrmQLND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKaraoke.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Connection.ConnectionString = DAL.ProjectSetting.ConnectionString;
            this.nHANVIENTableAdapter.Connection.ConnectionString = DAL.ProjectSetting.ConnectionString;
            this.nGUOIDUNGTableAdapter.Fill(this.qLKaraoke.NGUOIDUNG);
            this.nHANVIENTableAdapter.Fill(this.qLKaraoke.NHANVIEN);
            //đánh stt grid view
            new DanhSoTT(gvQLND);
            xl.TextBoxNhapSo(txtSDT);
        }
      




    }
}