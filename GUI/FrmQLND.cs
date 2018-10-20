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
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyKaraoke);

        }

        private void FrmQLND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKaraoke.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyKaraoke.NHANVIEN);
            // TODO: This line of code loads data into the 'quanLyKaraoke.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.quanLyKaraoke.NGUOIDUNG);
            // TODO: This line of code loads data into the 'quanLyKaraoke.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.quanLyKaraoke.NGUOIDUNG);
            // TODO: This line of code loads data into the 'quanLyKaraoke.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyKaraoke.NHANVIEN);

        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyKaraoke);

        }
    }
}