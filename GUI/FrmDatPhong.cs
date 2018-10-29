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
using DAL_DATASET;

namespace GUI
{
    public partial class FrmDatPhong : DevExpress.XtraEditors.XtraForm
    {

        PhieuDatPhong_DAL phieudh = new PhieuDatPhong_DAL();
        ChiTietPhieuDatPhong_DAL ct = new ChiTietPhieuDatPhong_DAL();
        Phong_DAL ph = new Phong_DAL();
        XuLy xl = new XuLy();
        KH kh;



        //-------------
        int stateThemXoaSua = 0;//1 là thêm  2//sua  3//xoa
        string strNhanVien = Properties.Settings.Default.strMANV;  //để biết nhân viên thực hiệ
        
        //--------------
        DataTable dtDSPhieuDatPhong;
        
        public FrmDatPhong()
        {
            InitializeComponent();
           SuKien();
        }

        //--------------------------------------------------------------------
        void FrmDatPhong_Load(object sender, EventArgs e)
        {
            //Load du lieu

            Load_GVPhieuDatPhong();
            LoadDSPhong();
        
        }

        private void Load_GVPhieuDatPhong()
        {
            dtDSPhieuDatPhong = phieudh.getDataQuery();
            dgvPhieuDatPH.DataSource = dtDSPhieuDatPhong;
           

        }

        private void BiddingData()
        {

            txtMaDat.Text = gvPhieuDatPH.GetFocusedRowCellValue("MAPHIEUDH").ToString();
            txtTenKhach.Text = gvPhieuDatPH.GetFocusedRowCellValue("TENKH").ToString();
            txtPhong.Text = gvPhieuDatPH.GetFocusedRowCellValue("MAPH").ToString();
            dtpNgayDat.Value = DateTime.Parse(gvPhieuDatPH.GetFocusedRowCellValue("NGAYDAT").ToString());
            dtpNgayVao.Value = DateTime.Parse(gvPhieuDatPH.GetFocusedRowCellValue("NGAYVAO").ToString());
            dtpGioVao.Text = gvPhieuDatPH.GetFocusedRowCellValue("GIOVAO").ToString();
            
            
            
        }
        private void gvPhieuDatPH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try {
                BiddingData();
            }
            catch { }
        }

        //--------------------------------------------------------------------
       
        private void SuKien()
        {
            this.Load += FrmDatPhong_Load;
            usctrTXS.them += usctrTXS_them;
            usctrTXS.xoa += usctrTXS_xoa;
            usctrTXS.sua += usctrTXS_sua;
            usctrTXS.luu += usctrTXS_luu;
            usctrTXS.huy += usctrTXS_huy;
            btnMoDSKH.Click += btnMoDSKH_Click;
          
        }
        //--------------------------------------------------------------------
        bool usctrTXS_huy()
        {
            return true;
        }

     
        private bool FullDaTa()
        {
            if (txtPhong.Text.Length == 0 || txtTenKhach.Text.Length == 0 || txtMaDat.Text.Length == 0)
            {
                xl.MessageBoxThongBaoEror("Vui Lòng Nhấp Đủ Thông Tin");
             
                return false;
            }
            if (dtpNgayDat.Value.Date< DateTime.Now.Date)
            {
                xl.MessageBoxThongBaoEror("Vui Lòng Cập Nhật Giờ Hiện Tại");
                return false;
            }
            if (dtpNgayDat.Value.Date > dtpNgayVao.Value.Date)
            {
                xl.MessageBoxThongBaoEror("Ngày Vào Phải  Lớn Hơn Ngày Đặt ");
                return false;
            }
            if (dtpNgayDat.Value.Date <= dtpNgayVao.Value.Date && dtpGioVao.Value.Hour < DateTime.Now.Hour)
            {
                xl.MessageBoxThongBaoEror("Giờ Vào Phải  Lớn Giờ Hiện Tại ");
                return false;
            }
            return true;
               
        }

        bool usctrTXS_sua()
        {
            stateThemXoaSua = 2;
            BiddingData();
            return true;
        }

        bool usctrTXS_xoa()
        {
           //xử lý xóa


            int GioVao =int.Parse( gvPhieuDatPH.GetFocusedRowCellValue("GIOVAO").ToString().Substring(0, 2));
            DateTime NgayVao = DateTime.Parse(gvPhieuDatPH.GetFocusedRowCellValue("NGAYVAO").ToString());
            string maphieudh = gvPhieuDatPH.GetFocusedRowCellValue("MAPHIEUDH").ToString();
            //nếu ngày vào lơn hơn ngày hiện tại
            if (NgayVao.Day > DateTime.Now.Date.Day || (NgayVao.Day == DateTime.Now.Date.Day) && GioVao >= DateTime.Now.Hour)
            {
                xl.MessageBoxThongBaoEror("Không Thể Xóa Phiếu Đặt Bây Giờ");
                return false;
            }
            //xóa chit chitiet có mã phiếu này
                ct.XoaChiTiet_TheoMaDH(maphieudh);
                //xóa phiếu này
                phieudh.Xoa(txtMaDat.Text);  
                xl.MessageBoxThongBao("Xóa Thành Công");
                Load_GVPhieuDatPhong();
                return true;  
        }

        bool usctrTXS_them()
        {

            stateThemXoaSua = 1;
            string matop=phieudh.getTopByMa();
            txtMaDat.Text = xl.AutoID_PhieuDatPhong("PH", matop);
            //reset
            txtPhong.ResetText();
            txtTenKhach.ResetText();
            return true;

        }
        bool usctrTXS_luu()
        {


            if (!FullDaTa())
            {
                return false;
            }

            if (stateThemXoaSua == 1)
            {
                if (!CheckPhong())
                    return false; 
                int k = phieudh.Them(txtMaDat.Text, kh.Makh, strNhanVien, dtpNgayDat.Value, dtpNgayVao.Value, dtpGioVao.Value.ToString("HH:mm"));
                k = ct.Them(txtMaDat.Text, txtPhong.Text);
                if (k > 0)
                {
                    xl.MessageBoxThongBao("Thêm Thành Công");
                    Load_GVPhieuDatPhong();
                    //gọi lại sự kiện thay đôi khi ngayvao
                    XuLySuKienNgayVao();
                    return true;
                }
                else
                {
                    xl.MessageBoxThongBaoEror("Thêm Thất Bại");
                    return true;
                }

               
            }

            if (stateThemXoaSua == 2)
            {
                //  int K = phieudh.Sua(kh.Makh, strNhanVien, dtpNgayDat.Value.ToShortDateString(), dtpNgayVao.Value.ToShortDateString(), null, txtPhong.Text);
            }
            return true;
        }


        private bool CheckPhong()
        {
            //chek phòng trống //đặt sau phòng khác
            int GioVao = phieudh.Lay_GioVaoCuaPhong(dtpNgayVao.Value.ToShortDateString(), txtPhong.Text);
            if (GioVao !=-1)
            {
                int k = GioVao - dtpGioVao.Value.Hour;
          
                if (k<=0)
                {
                    xl.MessageBoxThongBaoEror("Phòng đã có này đã có người đặt trước");
                    return false;
                }
                else
                {
                    DialogResult result = xl.MessageBoxCanhBao("Sau "+k+ " Giờ Nữa Khách Đặt Phòng Này Sẽ Đến Nhận Phòng.Bạn vẫn Muốn Mở Phòng ?");
                    if (result == DialogResult.Yes)
                        return true;
                    else return false;
                }
            }
            return true;
                      
        }
        //--------------------------------------------------------------------

        void btnMoDSKH_Click(object sender, EventArgs e)
        {
            FrmKhachHangDS ds = new FrmKhachHangDS();
            ds.sendata += ds_sendata;
            ds.ShowDialog();

        }

        void ds_sendata(string MaKH, string TenKH)
        {
            kh = new KH(MaKH, TenKH);
            txtTenKhach.Text=kh.Tenkh;
        }
        //--------------------------------------------------------------------

        private void LoadDSPhong()
        {
            foreach(DataRow  r in ph.getData().Rows)
            {
                usctrRoomKaraoke us = new usctrRoomKaraoke();
                us.MaPhong = r[0].ToString();
                flpDSPhong.Controls.Add(us);
                us.sentdata+=us_sentdata;
            }
        }

        void us_sentdata(string txt)
        {
            txtPhong.Text = txt;
        }
//------------------------------------------------------------

       
      

        private void dtpNgayVao_ValueChanged(object sender, EventArgs e)
        {
           
            XuLySuKienNgayVao();
        }

        private void XuLySuKienNgayVao()
        {
            string ngayvao = dtpNgayVao.Value.ToShortDateString();
            dtDSPhieuDatPhong.DefaultView.RowFilter = "NGAYVAO= '" + ngayvao + "'";
            foreach (Control ctr in flpDSPhong.Controls)
            {
                if (ctr is usctrRoomKaraoke)
                {
                    string maph = ((usctrRoomKaraoke)ctr).MaPhong;
                    if (phieudh.getDSChiTietPhieuDP(ngayvao).Contains(maph))  //nếu không này k có đặt
                        ((usctrRoomKaraoke)ctr).Image = Properties.Resources.icon_room;
                    else ((usctrRoomKaraoke)ctr).Image = Properties.Resources.icon_room_back;
                    

                }
            }
        }

      

        //-------------------------------------------------------------

       
       
       

       
     

     
  
       

       
       

    


    }

    internal class KH
    {
        string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        string tenkh;

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        public KH(string makh,string tenkh)
        {
            this.makh = makh;
            this.tenkh = tenkh;
        }
    }

}