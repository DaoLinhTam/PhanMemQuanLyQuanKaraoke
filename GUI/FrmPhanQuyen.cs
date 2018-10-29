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
using DAL_DATASET;
namespace GUI
{
    public partial class FrmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        string Connect = DAL.ProjectSetting.ConnectionString;
        PhanQuyen_DAL pq = new PhanQuyen_DAL();
        public FrmPhanQuyen()
        {
            InitializeComponent();          
            nHOMNGUOIDUNGTableAdapter.Connection.ConnectionString = Connect;
            
        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'qLKaraoke.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLKaraoke.NHOMNGUOIDUNG);
            
        }

         
        private void pHANQUYENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.pHANQUYENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLKaraoke);

        }

        private void nHOMNGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLKaraoke);

        }

        private void tENNHOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboNhomND.SelectedValue.ToString());
            dgvPhanQuyen.DataSource = pq.getData_TheoMaNhom(cboNhomND.SelectedValue.ToString());
           
        }



    }
}