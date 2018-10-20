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
    public partial class FrmQLND : DevExpress.XtraEditors.XtraForm
    {
        public FrmQLND()
        {
            InitializeComponent();
            SuKien();
        }

        private void SuKien()
        {

        }





        private void FrmQuanLyNhomNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void FrmQLND_Load(object sender, EventArgs e)
        {




        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyKaraokeDataSet);

        }

        private void FrmQLND_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKaraokeDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyKaraokeDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'quanLyKaraokeDataSet.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.quanLyKaraokeDataSet.NGUOIDUNG);

        }


    }
    
}