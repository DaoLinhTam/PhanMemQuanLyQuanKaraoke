using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usctrThemXoaSua : UserControl
    {
        public delegate bool SUKIEN();
        public event SUKIEN them;
        public event SUKIEN sua;
        public event SUKIEN xoa;
        public event SUKIEN luu;
        public event SUKIEN huy;
    
        XuLy xl = new XuLy();
        public usctrThemXoaSua()
        {
            InitializeComponent();
            SuKien();
            xl.XuLyGiaoDien_KhiLoad(btnThem, btnXoa, btnSua, btnLuu, btnHuy);
        }

        private void SuKien()
        {
            btnThem.Click += btnThem_Click;
            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
        }

        void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
               if( sua())
                     xl.XuLyGiaoDien_KhiSua(btnThem, btnXoa, btnSua, btnLuu, btnHuy);

            }
            catch (Exception ex) { };
           
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(xoa())
                xl.XuLyGiaoDien_KhiXoa(btnThem, btnXoa, btnSua, btnLuu, btnHuy);

            }
            catch (Exception ex) { };
           
        }

        void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
               if( huy())
                   xl.XuLyGiaoDien_KhiHuy(btnThem, btnXoa, btnSua, btnLuu, btnHuy);

            }
            catch (Exception ex) { };
          
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            
                if(luu())
            xl.XuLyGiaoDien_KhiLuu(btnThem, btnXoa, btnSua, btnLuu, btnHuy);
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(them());
                xl.XuLyGiaoDien_KhiThem(btnThem, btnXoa, btnSua, btnLuu, btnHuy);

            }
            catch (Exception ex) { };
            
        }

       

       
    }
}
