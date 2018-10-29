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
    public partial class FrmNhapThietBi : DevExpress.XtraEditors.XtraForm
    {


        ThietBi_DAL tb = new ThietBi_DAL();
        ChiTietPhieuNhapTB_DAL ct = new ChiTietPhieuNhapTB_DAL();
        PhieuNhapThietBi_DAL pn = new PhieuNhapThietBi_DAL();
         XuLy xl = new XuLy();
        //-----------------
        
        public FrmNhapThietBi(string MaPhieuNhap)
        {
            InitializeComponent();
            txtMaPhieuNhap.Text = MaPhieuNhap;
            SuKien();
           
            
        }

        private void SuKien()
        {
            this.Load += FrmNhapThietBi_Load;
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                matb = gvChiTiet.GetFocusedRowCellValue("MATHIETBI").ToString();
                if (matb == null)
                {
                    xl.MessageBoxThongBaoEror("Vui Lòng Chọn 1 Chi Tiết Để Xóa");
                    return;

                }
                ct.XoaCTPhieuNHap(txtMaPhieuNhap.Text, matb);
                LoadGv_ChiTiet(txtMaPhieuNhap.Text);
            }
            catch { };
        }

        string matb = null;
        void btnThem_Click(object sender, EventArgs e)
        {




            float donGia;
            int sl;

            //kime tra data
            if (!KT_DuLieuKhiThem()) return;
            try
            {
                 donGia = float.Parse(txtDonGia.Text);
                sl = int.Parse(numup.Value.ToString());
                if (donGia <= 0 || sl <= 0)
                {
                    xl.MessageBoxThongBaoEror("Số Lượng Hoặc Đơn Giá Không Hợp Lệ");
                    return;
                }
            }
            catch { xl.MessageBoxThongBaoEror("Số Lượng Hoặc Đơn Giá Không Hợp Lệ");
            return;
            }
            //----------------------------
            //Kiểm Tra  Xem thiết bị này đã có chưa..có thì tăng số lượng lêng

         
            if (KT_ThietBiDaThem(matb))
            {
                ct.CapNhatSoLuong(txtMaPhieuNhap.Text, matb, sl, donGia);
            }
            else
            { 
                 ct.Them(txtMaPhieuNhap.Text, matb, sl, donGia);
            }
              LoadGv_ChiTiet(txtMaPhieuNhap.Text);
        }

        private bool KT_ThietBiDaThem(string matb)
        {
          int k=  gvChiTiet.LocateByValue("MATHIETBI",matb);
          if (k >= 0)
          {
            return true;
          }
          return false;
        }

        private bool KT_DuLieuKhiThem()
        {
            //kiểm tra dữ liệu
            if (!xl.KTFullData(new Control[] { txtMaPhieuNhap, numup, txtDonGia }))
            {
                xl.MessageBoxThongBaoEror("Vui Lòng Nhập Đủ Dữ Liệu");
                return false;
            }

            matb = gvThietBi.GetFocusedRowCellValue("MATHIETBI").ToString();
            if (matb == null)
            {
                xl.MessageBoxThongBaoEror("Vui Lòng Chọn Thiết Bị Cần Nhập");
                return false;
            }

            return true;
        }

//-----------------------------------------------------

        void FrmNhapThietBi_Load(object sender, EventArgs e)
        {
            LoadGv_ThietBi();
        }

        private void LoadGv_ThietBi()
        {
            dgvThietBi.DataSource = tb.getData();
        }

        private void LoadGv_ChiTiet(string MAPN)
        {
            var c=ct.getDataQuery(MAPN);
            if (c == null)
                return;
            dgvChiTiet.DataSource = ct.getDataQuery(MAPN);
        }

       

        private void dgvThietBi_Click(object sender, EventArgs e)
        {

        }
    }
}