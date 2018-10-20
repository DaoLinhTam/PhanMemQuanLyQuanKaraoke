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
    public partial class FrmNhomND : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhomND()
        {
            InitializeComponent();
            SuKien();
        }

        private void SuKien()
        {
            btnThem.Click += btnThem_Click;
            btnCapNhat.Click += btnCapNhat_Click;
        }

        void btnCapNhat_Click(object sender, EventArgs e)
        {
            FrmNhomND_ThemND frm = new FrmNhomND_ThemND();
            frm.ShowDialog();
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhomND_ThemND frm = new FrmNhomND_ThemND();
            frm.ShowDialog();
        }
    }
}