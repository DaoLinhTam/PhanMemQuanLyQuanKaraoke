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
    public partial class FrmPhieuNhapThietBi : DevExpress.XtraEditors.XtraForm
    {
        ChiTietPhieuNhapTB_DAL ct=new ChiTietPhieuNhapTB_DAL();
        PhieuNhapThietBi_DAL pn=new PhieuNhapThietBi_DAL();
        XuLy xl = new XuLy();
        public FrmPhieuNhapThietBi()
        {
            InitializeComponent();
            SuKien();
        }

        private void SuKien()
        {
            LoadGv_PhieuNhap();
            usctrTSX.them += usctrTSX_them;
        }

        bool usctrTSX_them()
        {
            //lay manv
            string manv=Properties.Settings.Default.strMANV;
            string mapn=xl.AutoID_PhieuDatPhong("PN",pn.getTopMa());
            pn.Them(mapn, DateTime.Now.Date, manv);
            FrmNhapThietBi frm = new FrmNhapThietBi(mapn);
            frm.Show();
            return true;
        }

        private void LoadGv_PhieuNhap()
        {
            dgvPhieuNhapMH.DataSource=pn.getData();
         
        }

        private void gvPhieuNhapMH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                string mapn = gvPhieuNhapMH.GetFocusedRowCellValue("MAPHIEUNHAP").ToString();
                dgvCTPhieuNhap.DataSource = ct.getDataQuery(mapn);
            }
            catch { };
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCTPhieuNhap_Click(object sender, EventArgs e)
        {

        }

       

      
    }
}