using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;


using System.Windows.Forms;


namespace GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       
        public FrmMain()
        {
            InitializeComponent();
          
            
        }




        private bool KiemTraFrom_TonTai(string frmName)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Name == frmName)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private void ShowFrom(Form form)
        {
            Type typef = form.GetType();
            object f = Activator.CreateInstance(typef);
            Form frm = (Form)f;
            if (KiemTraFrom_TonTai(frm.Name)) return;
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void btnSDDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFrom(new FrmSuDungDichVu());
            
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
