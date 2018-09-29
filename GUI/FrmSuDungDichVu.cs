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
    public partial class FrmSuDungDichVu : DevExpress.XtraEditors.XtraForm
    {
        AutoResizeControl auto;
        public FrmSuDungDichVu()
        {
            this.SuspendLayout();
            InitializeComponent();
            this.ResumeLayout();
            for (int i = 0; i < 5; i++)
            {
                fpnTang2.Controls.Add(new uscPhong());
            }
         
        }

        private void FrmSuDungDichVu_Resize(object sender, EventArgs e)
        {

        }

        private void FrmSuDungDichVu_Load(object sender, EventArgs e)
        {
             
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}