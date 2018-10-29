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
    public partial class FrmTrangBiThietBi : DevExpress.XtraEditors.XtraForm
    {
        TrangBiThietBi_DAL tbtb = new TrangBiThietBi_DAL();
        ThietBiPhong_DAL tbp = new ThietBiPhong_DAL();
        ThietBi_DAL tb = new ThietBi_DAL();
        DMPhong_DAL ph = new DMPhong_DAL();
        LoaiPhong_DAL lph = new LoaiPhong_DAL();
        ChiTietTrangBi_DAL cttb = new ChiTietTrangBi_DAL();
        XuLy xl = new XuLy();
        public FrmTrangBiThietBi()
        {
            InitializeComponent();
            load();
            btnThemTrangBi.Click += btnThemTrangBi_Click;

        }

        void btnThemTrangBi_Click(object sender, EventArgs e)
        {
            themTrangBiThietBi();
        }

        public void load()
        {
            gCThietBi.DataSource = tb.load_gCTB();
            cbMaPhong.DataSource = ph.loadTable_Phong();
            cbMaPhong.DisplayMember = "MAPH";
            cbMaPhong.ValueMember = "MAPH";
            cbMaTB.DataSource = tbtb.load_tbtb();
            cbMaTB.DisplayMember = "MATB";
            cbMaTB.ValueMember = "MATB";
            btnThemChitietThietbi.Click += btnThemChitietThietbi_Click;
            btntrovekho.Click += btntrovekho_Click;

        }

        void btntrovekho_Click(object sender, EventArgs e)
        {
            trovekhothietbi();
        }
        public bool trovekhothietbi()
        {
            try
            {
                if (cttb.ktctsoluonghet(txtmatrangbithietbi.Text, txtmatbtb.Text))
                {
                    cttb.XoaChiTietThietBi(txtmatrangbithietbi.Text, txtmatbtb.Text);
                }
                else
                {
                    int slt = int.Parse(txtsoluongtrangbi.Text);
                    tb.updateTBtrove(txtmatbtb.Text, slt);
                    cttb.updateTrangBiThietBiTrove(txtmatrangbithietbi.Text, txtmatbtb.Text, slt);
                }
                gCChiTietTrangBi.DataSource = cttb.loadTable_ChiTietTrangBi(cbMaTB.Text);

                MessageBox.Show("them thanh cong");
                return true;
            }
            catch
            {
                MessageBox.Show("them that bai");
                return false;
            }
        }

        public bool themTrangBiThietBi()
        {
            try
            {
                tbtb.themTrangBiThietBi(txtmatrangbi.Text, cbMaPhong.Text, dtngaytrangbi.Value);
                load();
                MessageBox.Show("thêm thành công");
                return true;
            }
            catch
            {
                MessageBox.Show("them that bai");
                return false;
            }
        }
        void btnThemChitietThietbi_Click(object sender, EventArgs e)
        {
            themChiTietTrangBi();
        }
        public bool themChiTietTrangBi()
        {

            try
            {
                int soluongtb = int.Parse(txtsoluong.Text);
                if (cttb.kiemtratrungcttb(cbMaTB.Text, txtmathietbi.Text))
                {

                    cttb.themChiTietThietBi(cbMaTB.Text, txtmathietbi.Text, soluongtb);
                }
                else
                {
                    cttb.updatethemTrangBiThietBi(cbMaTB.Text, txtmathietbi.Text, soluongtb);
                    tb.updateThemChiTietTB(txtmathietbi.Text, soluongtb);
                }
                MessageBox.Show("them thanh cong");
                gCChiTietTrangBi.DataSource = cttb.loadTable_ChiTietTrangBi(cbMaTB.Text);

                return true;
            }
            catch
            {
                MessageBox.Show("them that bai");
                return false;
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void cbMaTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            gCChiTietTrangBi.DataSource = cttb.loadTable_ChiTietTrangBi(cbMaTB.Text);
        }

        private void gvThietBi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtmathietbi.Text = gvThietBi.GetFocusedRowCellValue("MATHIETBI").ToString();
            btnThemChitietThietbi.Enabled = true;

        }

        private void gvChiTietTrangBi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtmatrangbithietbi.Text = gvChiTietTrangBi.GetFocusedRowCellValue("MATB").ToString();
            txtmatbtb.Text = gvChiTietTrangBi.GetFocusedRowCellValue("MATHIETBI").ToString();
            txtsoluongtrangbi.Text = gvChiTietTrangBi.GetFocusedRowCellValue("SOLUONGTRANGBI").ToString();
        }

    }
}