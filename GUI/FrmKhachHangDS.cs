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
    public partial class FrmKhachHangDS : DevExpress.XtraEditors.XtraForm
    {

        KhachHang_DAL kh = new KhachHang_DAL();
        XuLy xl=new XuLy ();

        //---------------------
        public delegate void SentData(string MaKH,string TenKH);
        public event SentData sendata;
        public FrmKhachHangDS()
        {
            InitializeComponent();
            //su kien
            this.Load += FrmKhachHangDS_Load;
            SuKien();
        }

        private void SuKien()
        {
            btnThem.Click += btnThem_Click;
            btnChon.Click += btnChon_Click;
        }

        void btnChon_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string makh = gridView1.GetFocusedRowCellValue("MAKH").ToString();
                string tenkh = gridView1.GetFocusedRowCellValue("TENKH").ToString();
                sendata(makh, tenkh);
                this.Close();
            }
            else
            { 
               xl.MessageBoxThongBaoEror("Danh sách trống không thể chọn!");
            }
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            FrmKhachHangThem kh = new FrmKhachHangThem();
            kh.ShowDialog();
        }

        void FrmKhachHangDS_Load(object sender, EventArgs e)
        {
            dgvDSKH.DataSource = kh.getData();
        }
    }
}