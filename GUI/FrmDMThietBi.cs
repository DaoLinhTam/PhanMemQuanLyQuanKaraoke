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
    public partial class FrmDMThietBi : DevExpress.XtraEditors.XtraForm
    {
        ThietBi_DAL tb = new ThietBi_DAL();
        XuLy xl = new XuLy();
        //---------------
        bool stateThem = false;
        public FrmDMThietBi()
        {
            InitializeComponent();
            SuKien();
        }

        private void SuKien()
        {
            this.Load += FrmDMThietBi_Load;
            usctrTSX.them += usctrTSX_them;
            usctrTSX.xoa += usctrTSX_xoa;
            usctrTSX.sua += usctrTSX_sua;
            usctrTSX.huy += usctrTSX_huy;
            usctrTSX.luu += usctrTSX_luu;
        }

        bool usctrTSX_luu()
        {
            if (!xl.KTFullData(new Control[] { txtDVT, txtGiaTri, txtMaTB, txtTenTB }))
            {
                xl.MessageBoxThongBaoEror("Vui Lòng Nhập Đử Dữ Liệu");
                return false;
            }
            try
            {
                if (stateThem)
                {
                    tb.Them(txtMaTB.Text, txtTenTB.Text, 0, txtDVT.Text, float.Parse(txtGiaTri.Text));
                    xl.MessageBoxThongBao("Thêm Thành Công");
                    Load_GVThietBi();
                    return true;
                }
                else
                {
                    tb.Sua(txtMaTB.Text, txtTenTB.Text, txtDVT.Text, float.Parse(txtGiaTri.Text));
                    xl.MessageBoxThongBao("Sữa Thành Công");
                    Load_GVThietBi();
                    return true;
                }
            }
            catch {

                xl.MessageBoxThongBaoEror("Thao Tác Thất Bại");
                return false;
            }
        }

        bool usctrTSX_huy()
        {
            Bidding();
            return true;
        }

        bool usctrTSX_sua()
        {
            stateThem = false;
            txtTenTB.Focus();
            return true;
        }

        bool usctrTSX_xoa()
        {
            try
            {
                if (txtMaTB.Text.Length == 0)
                {
                    xl.MessageBoxThongBaoEror("Bảng Trống");
                    return true;
                }
                tb.Xoa(txtMaTB.Text);
                xl.MessageBoxThongBao("Xóa Thành Công");
                Load_GVThietBi();
                return true;
            }
            catch
            {
                xl.MessageBoxThongBaoEror("Không Thẻ Xóa Thiết Bị Đang Chọn Lúc Này");
                return false;
            }
        }

        bool usctrTSX_them()
        {
            try
            {
               
                stateThem = true;
                //reset
                txtDVT.ResetText();
                txtMaTB.ResetText();
                txtTenTB.ResetText();
                txtGiaTri.ResetText();
               
                //getID
                txtMaTB.Text = xl.AutoID5("TB", tb.getTopMa());
                txtTenTB.Focus();
                return true;
            }
            catch { return false; }
        }

        void FrmDMThietBi_Load(object sender, EventArgs e)
        {
            Load_GVThietBi();
            
        }

        private void Load_GVThietBi()
        {
            try
            {
                gCThietBi.DataSource = tb.getData();
                Bidding();
            }
            catch { };
            
        }

        private void Bidding()
        {
            txtMaTB.Text = gVThietBi.GetFocusedRowCellValue("MATHIETBI").ToString();
            txtTenTB.Text = gVThietBi.GetFocusedRowCellValue("TENTHIETBI").ToString();
            txtDVT.Text= gVThietBi.GetFocusedRowCellValue("DVT").ToString();
            txtGiaTri.Text = gVThietBi.GetFocusedRowCellValue("GIATRI").ToString();

        }
    }
}