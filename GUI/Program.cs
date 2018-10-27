using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;


namespace GUI
{
    static class Program
    {

        public static FrmMain frmMain;
        public static FrmDoiMatkhau frmDoiMK;
        public static FrmDangNhap frmDangNhap;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            frmDangNhap = new FrmDangNhap();
            Application.Run(frmDangNhap);
        
          
    
            //Application.Run(new FrmSuDungDichVu());
        }

   
    }
}
