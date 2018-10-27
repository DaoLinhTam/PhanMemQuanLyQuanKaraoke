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
    public partial class FrmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        CauHinh_DAL cauhinh = new CauHinh_DAL();
        public FrmCauHinh()
        {
            InitializeComponent();
            suKien();


        }

        private void suKien()
        {
            cboTenServer.QueryPopUp += cboTenServer_QueryPopUp;
            cboCSDL.QueryPopUp += cboCSDL_QueryPopUp;
            btnLuu.Click += btnLuu_Click;
        }

        //Xử lý nút Lưu
        void btnLuu_Click(object sender, EventArgs e)
        {

            //kiểm tra dữ liệu các control
            if (cboCSDL.Text.Length == 0 || txtMK.Text.Length == 0 || txtTenDN.Text.Length == 0 || cboCSDL.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin", "Đề Nghị", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            cauhinh.saveConnect(cboTenServer.Text, cboCSDL.Text, txtTenDN.Text, txtMK.Text);
            MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void cboCSDL_QueryPopUp(object sender, CancelEventArgs e)
        {

            if (txtMK.Text.Trim().Length > 0 && txtTenDN.Text.Trim().Length > 0 && cboTenServer.Text.Trim().Length > 0)
            {

                //lấy ds database đưa vao lstdatabase
                List<string> lstDatabase = cauhinh.getDatabaseName(cboTenServer.Text, txtTenDN.Text, txtMK.Text);
                //đưa dữ liệu lên combobox
                foreach (string item in lstDatabase)
                    cboCSDL.Properties.Items.Add(item);


            }
        }

        void cboTenServer_QueryPopUp(object sender, CancelEventArgs e)
        {

            DataTable dt = cauhinh.getServerName();
            foreach (DataRow r in dt.Rows)
            {
                if (r[1] != null)
                    cboTenServer.Properties.Items.Add(r[0] + @"\" + r[1]);
            }
        }

    }


}