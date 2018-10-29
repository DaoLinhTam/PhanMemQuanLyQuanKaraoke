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
using GUI.QLKaraokeTableAdapters;

namespace GUI
{
    public partial class FrmQLNhomND : DevExpress.XtraEditors.XtraForm
    {
        NHOMNGUOIDUNGTableAdapter nhomnd = new NHOMNGUOIDUNGTableAdapter();
        XuLy xl = new XuLy();
        public FrmQLNhomND()
        {
            InitializeComponent();
            nhomnd.Connection.ConnectionString = DAL.ProjectSetting.ConnectionString;
           
        }

        private void nHOMNGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLKaraoke);

        }

        private void FrmQLNhomND_Load(object sender, EventArgs e)
        {
            this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Connection.ConnectionString = DAL.ProjectSetting.ConnectionString;
            this.nHOMNGUOIDUNGTableAdapter.Connection.ConnectionString = DAL.ProjectSetting.ConnectionString;
            // TODO: This line of code loads data into the 'qLKaraoke.NGUOIDUNG_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Fill(this.qLKaraoke.NGUOIDUNG_NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'qLKaraoke.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLKaraoke.NHOMNGUOIDUNG);


            //Sự Kiện
            SuKien();
            //--------------
            xl.XuLyGiaoDien_KhiLoad(btnThem, btnXoa, btnSua, btnHuy, btnLuu);

        }

        private void SuKien()
        {
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnHuy.Click += btnHuy_Click;
            btnXoa.Click += btnXoa_Click;
            btnLuu.Click += btnLuu_Click;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            //Kiêm tra dữ liệu
            if (txtTenNhomND.Text.Length == 0)
            {
                xl.MessageBoxThongBaoEror("Vui Lòng Nhập Đử Dữ Liệu");
                return;
            }

            //kiểm tra trùng trên nhóm
            int k = nHOMNGUOIDUNGBindingSource.Find("TENNHOM", txtTenNhomND.Text);
            if(k>1)
            {
               xl.MessageBoxThongBaoEror("Nhóm Người Dùng Đã Tồn Tại");
                return;
            }
            //Lưu
            UpdateALL();
            //xl giao diện
            xl.XuLyGiaoDien_KhiLuu(btnThem, btnXoa, btnSua, btnHuy, btnLuu);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            nHOMNGUOIDUNGBindingSource.CancelEdit();
            xl.XuLyGiaoDien_KhiHuy(btnThem, btnXoa, btnSua, btnHuy, btnLuu);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult t = xl.MessageBoxCanhBao("Bạn có muốn xóa nhóm người dùng này không?");
            if (t == DialogResult.Yes)
            {
                //kiểm tra khóa ngoại
                string filter = " MANHOM ='" + txtMaNhom.Text + "'";
                int k = xl.FilterBiddingSource(NguoiDungNhomNguoiDung, filter);
                if (k > 0)
                {
                    xl.MessageBoxThongBaoEror("Không Thể Xóa Nhóm Người Dùng " + txtTenNhomND.Text);
                    return;
                }
                else
                {
                    try
                    {
                        nHOMNGUOIDUNGBindingSource.RemoveCurrent();
                        UpdateALL();
                    }
                    catch { };
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xl.XuLyGiaoDien_KhiSua(btnThem, btnXoa, btnSua, btnHuy, btnLuu);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            nHOMNGUOIDUNGBindingSource.AddNew();
            txtMaNhom.Text = xl.AutoID("NH",nhomnd.GetData(),"MANHOM DESC");
            xl.XuLyGiaoDien_KhiThem(btnThem, btnXoa, btnSua, btnHuy, btnLuu);
        }

        private void UpdateALL()
        {
            this.Validate();
            this.nHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLKaraoke);
        }

     
    }
}