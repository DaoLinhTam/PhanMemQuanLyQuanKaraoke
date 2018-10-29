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
    public partial class FrmDanhMucMH : DevExpress.XtraEditors.XtraForm
    {
        MatHang_DAL mh = new MatHang_DAL();
        XuLy xl = new XuLy();
        bool stateThem;
        public FrmDanhMucMH()
        {
            InitializeComponent();
            SuKien();
        }
        //DS CÁC SU KIÊN
        private void SuKien()
        {
            this.Load += FrmDanhMucMH_Load;
            usctrTXS.them += usctrTXS_them;
            usctrTXS.xoa += usctrTXS_xoa;
            usctrTXS.sua += usctrTXS_sua;
            usctrTXS.luu += usctrTXS_luu;
            usctrTXS.huy += usctrTXS_huy;

        }

        bool usctrTXS_huy()
        {
            return true;
        }

        bool usctrTXS_luu()
        {
            if (stateThem == true)
            {

                mh.Them(txtMaHang.Text, txtTenHang.Text, LoaiHang(), 0, int.Parse(txtDonGiaBan.Text), txtDVT.Text);
                xl.MessageBoxThongBao("Thêm Thành Công!");
                LoadGV_MatHang();
                return true;
            }
            else
            { 
               mh.Sua(txtMaHang.Text, txtTenHang.Text, LoaiHang(), int.Parse(txtDonGiaBan.Text), txtDVT.Text);
               xl.MessageBoxThongBao("Sửa Thành Công!");
               LoadGV_MatHang();
               return true;
            }

            return false;
        }


        //CÁC SƯ KIÊN LOAD
        void FrmDanhMucMH_Load(object sender, EventArgs e)
        {
            LoadGV_MatHang();
        }


        private void LoadGV_MatHang()
        {
            dgvMatHang.DataSource = mh.getData();
            mh.getData();
        }
        //----------------------------------------------
        //SỰ KIỆN THÊM XÓA SỮA
        bool usctrTXS_sua()
        {
            stateThem = false;

            //-------------------------
            txtTenHang.Focus();
            return true;
        }

        bool usctrTXS_xoa()
        {
            string tenhang=null,manh;
            try
            {
                 manh = gvMatHang.GetFocusedRowCellValue("MAMATHANG").ToString();
                tenhang = gvMatHang.GetFocusedRowCellValue("TENMATHANG").ToString();
                DialogResult result = xl.MessageBoxCanhBao("Bạn Muốn Xóa Món Hàng "+tenhang+" Vào Lúc Này?");
                if (result == DialogResult.Yes)
                {
                    mh.Xoa(manh);
                    xl.MessageBoxThongBao("Xóa Thành Công");
                    LoadGV_MatHang();
                    return true;
                }

            }
            catch (Exception ex)
            {
                xl.MessageBoxThongBaoEror("Không Thẻ Xóa Mặt Hàng Vào Lúc Này");
              
            }
            return true;
           //kiểm tra khóa ngoại
        }

        bool usctrTXS_them()
        {

            //
            txtDonGiaBan.ResetText();
            txtDVT.ResetText();
            txtMaHang.ResetText();
            txtSoLuongTon.ResetText();
            txtTenHang.ResetText();
            cbo_LoaiMH.ResetText();
            //-----------
            txtMaHang.Text = xl.AutoID5("MH", mh.getTopMa());
            txtTenHang.Focus();
            stateThem = true;
            return true;
            //
            
        }

        public int LoaiHang()
        {
            if (cbo_LoaiMH.Text == "Đồ Uống")
                return 1;
            else if (cbo_LoaiMH.Text == "Đồ Ăn")
                return 2;
            else return 3;
        }
        //-----------------------------------

        //--------------------------------------

        private void gVMatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            databinding();
        }

        public void databinding()
        {
            txtMaHang.Text = gvMatHang.GetFocusedRowCellValue("MAMATHANG").ToString();
            txtTenHang.Text = gvMatHang.GetFocusedRowCellValue("TENMATHANG").ToString();
            cbo_LoaiMH.Text = gvMatHang.GetFocusedRowCellValue("LOAIMATHANG").ToString();
            txtDonGiaBan.Text = gvMatHang.GetFocusedRowCellValue("DONGIABAN").ToString();
            txtDVT.Text = gvMatHang.GetFocusedRowCellValue("DVT").ToString();
            txtSoLuongTon.Text = gvMatHang.GetFocusedRowCellValue("SOLUONGTON").ToString();
        }
    }
}