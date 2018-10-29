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

namespace GUI
{
    public partial class FrmThemNguoiDungVaoNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        String connect = DAL.ProjectSetting.ConnectionString;
        public FrmThemNguoiDungVaoNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
   
            this.tableAdapterManager.UpdateAll(this.qLKaraoke);

            

        }

        private void FrmThemNguoiDungVaoNhomNguoiDung_Load(object sender, EventArgs e)
        {

            //gán chuỗi kết 
            this.nHOMNGUOIDUNGTableAdapter.Connection.ConnectionString = connect;
            this.nHANVIENTableAdapter.Connection.ConnectionString = connect;
            // TODO: This line of code loads data into the 'qLKaraoke.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLKaraoke.NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'qLKaraoke.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLKaraoke.NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'qLKaraoke.NGUOIDUNG_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
          
            this.nHANVIENTableAdapter.Fill(this.qLKaraoke.NHANVIEN);
            // TODO: This line of code loads data into the 'qLKaraoke.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
           
         
            this.nHANVIENTableAdapter.Fill(this.qLKaraoke.NHANVIEN);
          
   

        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLKaraoke);

        }
    }
}