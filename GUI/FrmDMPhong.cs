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
    public partial class FrmDMPhong : DevExpress.XtraEditors.XtraForm
    {

        DMPhong_DAL ph = new DMPhong_DAL();
        LoaiPhong_DAL lph = new LoaiPhong_DAL();
        XuLy xl = new XuLy();
        public FrmDMPhong()
        {
            InitializeComponent();
            this.Load += FrmDMPhong_Load;
            usctrThemXoaSua1.them += usctrThemXoaSua1_them;
            usctrThemXoaSua1.luu += usctrThemXoaSua1_luu;
            usctrThemXoaSua1.huy += usctrThemXoaSua1_huy;
            usctrThemXoaSua1.sua += usctrThemXoaSua1_sua;
            usctrThemXoaSua1.xoa += usctrThemXoaSua1_xoa;
        }

        bool usctrThemXoaSua1_xoa()
        {
            xoa();
            throw new NotImplementedException();
        }

        bool usctrThemXoaSua1_sua()
        {
            sua();
            throw new NotImplementedException();
        }

        bool usctrThemXoaSua1_huy()
        {
            return true;
            throw new NotImplementedException();
        }

        bool usctrThemXoaSua1_luu()
        {
            luu();
            return true;
            throw new NotImplementedException();
        }

        bool usctrThemXoaSua1_them()
        {
            try
            {
                txtKhuVuc.Clear();
                txtMaPhong.Clear();
                cbMaLoaiPhong.SelectedItem = null;
                cbTinhTrang.SelectedItem = null;

                return true;
            }
            catch
            {
                return false;
            }
        }
        void FrmDMPhong_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {

            gvPhong.DataSource = ph.loadTable_Phong();
            cbMaLoaiPhong.DataSource = ph.loadTable_Phong();
            cbMaLoaiPhong.DataSource = lph.loadTable_LoaiPhong();
            cbMaLoaiPhong.DisplayMember = "MALOAIPH";
            cbMaLoaiPhong.ValueMember = "MALOAIPH";
        }
        public void luu()
        {
            try
            {

                if (ph.kiemTraKhoaChinh(txtMaPhong.Text))
                {
                    int khuvuc = int.Parse(txtKhuVuc.Text);
                    int tinhtrang = int.Parse(cbTinhTrang.Text);
                    ph.themPhong(txtMaPhong.Text, cbMaLoaiPhong.Text, khuvuc, tinhtrang);
                    this.load();
                }
                else
                {
                    MessageBox.Show("da ton tai phong");
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bai");
            }
        }
        public void sua()
        {
            try
            {
                int khuvuc = int.Parse(txtKhuVuc.Text);
                int tinhtrang = int.Parse(cbTinhTrang.Text);
                ph.SuaPhong(txtMaPhong.Text, cbMaLoaiPhong.Text, khuvuc, tinhtrang);
                this.load();
            }
            catch
            {
                MessageBox.Show("sua thất bai");
            }
        }
        public void xoa()
        {
            try
            {
                if (ph.kiemTraKhoaNgoai(txtMaPhong.Text))
                {
                    ph.XoaPhong(txtMaPhong.Text);

                    this.load();
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bai");
            }
        }

        private void gCPhong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


        }

        private void gCPhong_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaPhong.Text = gCPhong.GetFocusedRowCellValue("MAPH").ToString();
            cbMaLoaiPhong.Text = gCPhong.GetFocusedRowCellValue("MALOAIPH").ToString();
            cbTinhTrang.Text = gCPhong.GetFocusedRowCellValue("TINHTRANG").ToString();
            txtKhuVuc.Text = gCPhong.GetFocusedRowCellValue("KHUVUC").ToString();
        }
    }
}