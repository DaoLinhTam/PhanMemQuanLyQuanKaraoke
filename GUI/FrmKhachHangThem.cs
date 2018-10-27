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
    public partial class FrmKhachHangThem : DevExpress.XtraEditors.XtraForm
    {

        XuLy xl = new XuLy();
      
        public FrmKhachHangThem()
        {
            InitializeComponent();
            this.btnHuy.Click += btnHuy_Click;
            this.btnLuu.Click += btnLuu_Click;
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
          
        }

        void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKhachHangThem_Load(object sender, EventArgs e)
        {
          
        }
    }
}