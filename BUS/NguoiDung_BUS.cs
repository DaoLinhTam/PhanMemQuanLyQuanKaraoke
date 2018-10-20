using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BUS
{
   public  class NguoiDung_BUS
    {
        NguoiDung_DAL nd=new NguoiDung_DAL();

        public dynamic loadTable_NguoiDung()
        {
            return nd.loadTable_NguoiDung();
        }
         public bool themNguoiDung(string tendn,string mk,string manv)
        {
            return nd.themNguoiDung(tendn,mk,manv);
        }
        public bool DoiMatKhau(string tendn, string mk)
        {
            return nd.DoiMatKhau(tendn,mk);
                               
        }

        public bool ThayDoi_TinhTrang_NguoiDung(string tendn,bool bol)
        {
            return nd.ThayDoi_TinhTrang_NguoiDung(tendn,bol);
        }

        public bool XoaNguoiDung(string tendn)
        {
           return nd.XoaNguoiDung(tendn);
        }


    }
    
}
