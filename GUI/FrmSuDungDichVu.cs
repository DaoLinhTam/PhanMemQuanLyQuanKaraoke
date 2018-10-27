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
    public partial class FrmSuDungDichVu : DevExpress.XtraEditors.XtraForm
    {
        MatHang_DAL mh = new MatHang_DAL();
        Phong_DAL ph = new Phong_DAL();
        PhieuDatPhong_DAL phieudh = new PhieuDatPhong_DAL();

        //---------------------------------
        DataTable dtDSPhong;
        public FrmSuDungDichVu()
        {
            InitializeComponent();
            SuKien();
        }
 //DANH SÁCH CÁC SỰ KIỆN
        private void SuKien()
        {
            this.Load += FrmSuDungDichVu_Load;
            this.cboTang.SelectedIndexChanged += cboTang_SelectedIndexChanged;
           
        }

   

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
                if (lstTang.Contains(us.TenPhong))
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
                string TenPhong = r["MAPH"].ToString();
                usctrRoomKaraokeShow us = new usctrRoomKaraokeShow();
                us.TenPhong = TenPhong;
                //phòng đc đặt
                if (phieudh.CheckPhongDat_ByMa(dt.ToShortDateString(), TenPhong))
                {
                    us.TrangThai = phieudh.getGioPhongDat(TenPhong, dt.ToShortDateString());
                    us.Visiblel_lblTime = true;
                    us.lblTime_Color = Color.Blue;
                }else
                {
                    us.TrangThai = "00:00";
                    us.Visiblel_lblTime = false;
                    us.lblTime_Color = Color.Red;
                }
                fplDSPhong.Controls.Add(us);
            }
        }
//---------------------------------------------------------



    }
}