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
using DAL_DATASET;

namespace GUI
{
    public partial class FrmSuDungDichVu : DevExpress.XtraEditors.XtraForm
    {
        MatHang_DAL mh = new MatHang_DAL();
        Phong_DAL ph = new Phong_DAL();
        PhieuDatPhong_DAL phieudh = new PhieuDatPhong_DAL();

        //---------------------------------
        DataTable dtDSPhong;
        List<TrangThaiPhong> lstTrangThai;//đẻ trả trạng thái phòng khi reset
        public FrmSuDungDichVu()
        {
            InitializeComponent();
            SuKien();
            lstTrangThai =new  List<TrangThaiPhong>();
        }
 //DANH SÁCH CÁC SỰ KIỆN
        private void SuKien()
        {
            this.Load += FrmSuDungDichVu_Load;
            this.cboTang.SelectedIndexChanged += cboTang_SelectedIndexChanged;
            this.FormClosing += FrmSuDungDichVu_FormClosing;
            this.btnLamMoi.Click += btnLamMoi_Click;
           
        }
//XỬ LÝ SỰ KIỆN LAM MỚI
        void btnLamMoi_Click(object sender, EventArgs e)
        {
           //LƯU CONTROL CŨ
            foreach (Control ctr in fplDSPhong.Controls)
            {
                if (ctr is usctrRoomKaraokeShow)
                {
                    usctrRoomKaraokeShow us=(usctrRoomKaraokeShow)ctr;
                    if (((usctrRoomKaraokeShow)ctr).StateMoPhong)  //Phòng đang mở
                    {
                        lstTrangThai.Add(new TrangThaiPhong(us.MaPhong,us.Gio,us.Phut,us.Giay));
                    }
                
                
                }
            }
            fplDSPhong.Controls.Clear();//clear heest control
            dtDSPhong = ph.getData();
            add_DanhSachPhong(dtDSPhong);


        }
//------------------------------------------------------
//XỬ LÝ ĐÓNG FORM
        void FrmSuDungDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  e.Cancel = true;
        }
//--------------------------------------

   

//XỬ CHỌN KHU VỰC PHÒNG
        void cboTang_SelectedIndexChanged(object sender, EventArgs e)
        {         

            DataView dv=new DataView(dtDSPhong);
            dv.RowFilter="KHUVUC = "+cboTang.Text;
            DataTable dt = dv.ToTable();
            List<String> lstTang = new List<string>();
            foreach (DataRow r in dt.Rows)
                lstTang.Add(r["MAPH"].ToString());
            foreach (usctrRoomKaraokeShow us in fplDSPhong.Controls)
            {
                if (lstTang.Contains(us.MaPhong))
                    us.Visible = true;
                else us.Visible = false;
            }

        }



      
        
//---------------------------------------------------LOAD
        void FrmSuDungDichVu_Load(object sender, EventArgs e)
        {
            //Load Mat Hàng
            LoadMatHang();
            LoadDSPhong();
            
        }

        private void LoadMatHang()
        {
            dgvMatHang.DataSource = mh.getData();
        }
        private void LoadDSPhong()
        {
            dtDSPhong = ph.getData();
            //thêm phòng file flowpnl
            add_DanhSachPhong(dtDSPhong);
            //add comboxtang
            addCbo_Tang();
        }

        private void addCbo_Tang()
        {
            
            foreach (DataRow r in dtDSPhong.Rows)
            {
                string Tang = r["KHUVUC"].ToString();
                if(!cboTang.Properties.Items.Contains(Tang))
                    cboTang.Properties.Items.Add(Tang);
            }
            if (cboTang.Properties.Items.Count > 0)
                cboTang.SelectedIndex = 0;
        }

        private void add_DanhSachPhong(DataTable dtDSPhong)
        {
            //Lay Ngay hien Tai
            DateTime dt = DateTime.Now;
            fplDSPhong.Controls.Clear();          
            foreach (DataRow r in dtDSPhong.Rows)
            {
               

                string MaPhong = r["MAPH"].ToString();
                usctrRoomKaraokeShow us ;
               TrangThaiPhong trangthai=null;
               
                 int k = lstTrangThai.Select(t=>t.MaPhong==MaPhong).ToList().Count();
                if(k>0)
                {
                  trangthai=lstTrangThai.Where(t => t.MaPhong == MaPhong).ToList()[0];
                }


             if (trangthai != null)
             {

                 us = new usctrRoomKaraokeShow(trangthai.Gio, trangthai.Phut, trangthai.Giay, true);
                

             }
             else
             {
                 us = new usctrRoomKaraokeShow();
                 us.MaPhong = MaPhong;
                 //phòng đc đặt
                 if (phieudh.CheckPhongDat_ByMa(dt.ToShortDateString(), MaPhong))
                 {
                     us.lblTime_ChangeProperties(phieudh.getGioPhongDat(MaPhong, dt.ToShortDateString()), Color.Blue, true);
                 }
                 else
                 {
                     us.lblTime_ChangeProperties("00:00", Color.Red, false);
                   
                 }
             }
                fplDSPhong.Controls.Add(us);
                
            }
        }

//---------------------------------------------------------



    }
}