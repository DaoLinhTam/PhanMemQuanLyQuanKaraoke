using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class NguoiDung_DAL:QLKaraokeDataContext
    {
        public dynamic loadTable_NguoiDung()
        {
           return from nd in NGUOIDUNGs
                  join nv in NHANVIENs on nd.MANV equals nv.MANV
                  select new { TENNHANVIEN = nv.TENNV, TENDANGNHAP = nd.TENDANGNHAP, nd.TINHTRANG };
          
        }

        public bool themNguoiDung(string tendn,string mk,string manv)
        {
            try
            {
                NGUOIDUNG nd = new NGUOIDUNG();
                nd.TENDANGNHAP = tendn;
                nd.MATKHAU = mk;
                nd.MANV = manv;
                nd.TINHTRANG = true;
                this.NGUOIDUNGs.InsertOnSubmit(nd);
                this.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DoiMatKhau(string tendn, string mk)
        {
            try
            {
                NGUOIDUNG nguoidung = (from nd in NGUOIDUNGs
                                       where nd.TENDANGNHAP == tendn
                                       select nd).First();
                nguoidung.MATKHAU = mk;
                this.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
                               
        }

        public bool ThayDoi_TinhTrang_NguoiDung(string tendn,bool bol)
        {
            try
            {
                NGUOIDUNG nguoidung = (from nd in NGUOIDUNGs
                                       where nd.TENDANGNHAP == tendn
                                       select nd).First();
                nguoidung.TINHTRANG=bol;
                this.SubmitChanges();
                return true;
            }
            catch
            {
              return false;
            }
        }

        public bool XoaNguoiDung(string tendn)
        {
            try
            {
                NGUOIDUNG nguoidung = (from nd in NGUOIDUNGs
                                       where nd.TENDANGNHAP == tendn
                                       select nd).First();
                this.NGUOIDUNGs.DeleteOnSubmit(nguoidung);
                this.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
        
}
