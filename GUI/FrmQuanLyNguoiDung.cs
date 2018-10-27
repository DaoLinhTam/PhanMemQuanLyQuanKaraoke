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
using BUS;
using DAL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;

namespace GUI
{
    public partial class FrmQuanLyNguoiDung : DevExpress.XtraEditors.XtraForm
    {
         NguoiDung_BUS nd=new NguoiDung_BUS();   
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
           
           
        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyKaraokeDataSet);

        }

        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKaraokeDataSet.VIEW_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.vIEW_NGUOIDUNGTableAdapter.Fill(this.quanLyKaraokeDataSet.VIEW_NGUOIDUNG);
            // TODO: This line of code loads data into the 'quanLyKaraokeDataSet.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.quanLyKaraokeDataSet.NGUOIDUNG);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nGUOIDUNGTableAdapter.FillBy(this.quanLyKaraokeDataSet.NGUOIDUNG);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

       
        
        
    }
}