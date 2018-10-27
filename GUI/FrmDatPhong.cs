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

            //txtMaDat.Text = gvPhieuDatPH.GetFocusedRowCellValue("MAPHIEUDH").ToString();
            //txtTenKhach.Text = gvPhieuDatPH.GetFocusedRowCellValue("TENKH").ToString();
            //dtpNgayDat.Value = DateTime.Parse(gvPhieuDatPH.GetFocusedRowCellValue("NGAYDAT").ToString());
            //dtpNgayVao.Value = DateTime.Parse(gvPhieuDatPH.GetFocusedRowCellValue("NGAYVAO").ToString());
            //dtpGioVao.Text = gvPhieuDatPH.GetFocusedRowCellValue("GIOVAO").ToString();
            
            
            
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
            return true;
               
        }

        bool usctrTXS_sua()
        {
            return true;
        }

        bool usctrTXS_xoa()
        {
            return true;
        }

        bool usctrTXS_them()
        {
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
            else
            {
                //chek phòng trống //đặt sau phòng khác
                bool check=phieudh.CheckPhongTrong(txtPhong.Text,dtpNgayVao.Value.ToShortDateString(),int.Parse(dtpGioVao.Text.Substring(0,2)));
                if (!check)
                {
                    xl.MessageBoxThongBaoEror("Phòng đã có này đã có người đặt trước");
                    return false;
                }
                else  //đặt trước phòng khác
                {
                    check = phieudh.CheckPhongTrong(txtPhong.Text, dtpNgayVao.Value.ToShortDateString(),23);
                    if (!check)
                    {
                        DialogResult dialog = xl.MessageBoxCanhBao("Phòng Đã Người Đặt Sau Đó Vui Lòng Cân Nhắc Thời Gian! \n\n Vẫn Muốn Thêm ?");
                        if (dialog != DialogResult.OK)
                        {
                            return false;
                        }
                    }
                }
                string strMANV = Properties.Settings.Default.strMANV;

                int k = phieudh.Them(txtMaDat.Text, kh.Makh, strMANV, dtpNgayDat.Value, dtpNgayVao.Value, dtpGioVao.Value.ToString("HH:mm"));
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
                        ((usctrRoomKaraoke)ctr).Image = Properties.Resources.icon_room_back;
                    else ((usctrRoomKaraoke)ctr).Image = Properties.Resources.icon_room;
                    

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