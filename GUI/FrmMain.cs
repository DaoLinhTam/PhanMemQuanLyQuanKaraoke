using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;


using System.Windows.Forms;


namespace GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       
        public FrmMain()
        {
            InitializeComponent();
            SuKien();
          
            
        }

        private void SuKien()
        {
            btnDangXuat.ItemClick += btnDangXuat_ItemClick;
            btnDoiMK.ItemClick += btnDoiMK_ItemClick;
            btnQLND.ItemClick += btnQLND_ItemClick;
            btnPhanQuyen.ItemClick += btnPhanQuyen_ItemClick;
            btnGroupND.ItemClick += btnGroupND_ItemClick;
            this.Load += FrmMain_Load;
            btnThemND.ItemClick += btnThemND_ItemClick;
            //from danh mục chính
            btnKhachHang.ItemClick += btnKhachHang_ItemClick;


            //danh mục chính

            btnDatPhong.ItemClick += btnDatPhong_ItemClick;
        }

        void btnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFrom(new FrmDatPhong());
        }

        void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFrom(new FrmKhachHang());
        }

        void btnThemND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFrom(new FrmThemNguoiDungVaoNhomNguoiDung());
        }

        void btnGroupND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPhanQuyen frm = new FrmPhanQuyen();
            ShowFrom(frm);
        }

        void FrmMain_Load(object sender, EventArgs e)
        {
            FrmBaner frm = new FrmBaner();
            ShowFrom(frm);
        }


        //sự kiện quản lý người dùng
        void btnQLND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFrom(new FrmQLND());
        }

        void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            FrmDoiMatkhau frm = new FrmDoiMatkhau();
            frm.ShowDialog();
           
           
        }

        void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }




        private bool KiemTraFrom_TonTai(string frmName)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Name == frmName)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private void ShowFrom(Form form)
        {
            Type typef = form.GetType();
            object f = Activator.CreateInstance(typef);
            Form frm = (Form)f;
            if (KiemTraFrom_TonTai(frm.Name)) return;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
           
        }

        private void btnSDDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFrom(new FrmSuDungDichVu());
            
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            
        }

       
    }
}
