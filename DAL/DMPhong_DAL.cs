using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DMPhong_DAL : Database
    {

        public DMPhong_DAL()
        {
        }
        public dynamic loadTable_Phong()
        {
            return from ph in db.PHONGs
                   select ph;
        }
        public bool kiemTraKhoaChinh(string maph)
        {
            int k = 0;
            k = (from ph in db.PHONGs
                 where ph.MAPH == maph
                 select ph).Count();
            if (k == 0)
            {
                return true;
            }
            else return false;
        }
        public bool kiemTraKhoaNgoai(string maph)
        {
            int k = 0;
            k = (from ph in db.TRANGBI_THIETBIs
                 where ph.MAPH == maph
                 select ph).Count();
            k = (from ph in db.CHITIET_PHIEUDATPHONGs
                 where ph.MAPH == maph
                 select ph).Count();
            if (k == 0)
                return true;
            else
                return false;
        }

        public bool themPhong(string maPhong, string loaiPhong, int khuvuc, int tinhTrang)
        {
            PHONG ph = new PHONG();
            ph.MAPH = maPhong;
            ph.KHUVUC = khuvuc;
            ph.MALOAIPH = loaiPhong;
            ph.TINHTRANG = tinhTrang;
            db.PHONGs.InsertOnSubmit(ph);
            db.SubmitChanges();
            return true;

        }
        public bool XoaPhong(string maph)
        {
            try
            {
                PHONG phong = (from ph in db.PHONGs
                               where ph.MAPH == maph
                               select ph).First();
                db.PHONGs.DeleteOnSubmit(phong);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaPhong(string maPhong, string loaiPhong, int khuvuc, int tinhTrang)
        {
            try
            {
                PHONG ph = (from phong in db.PHONGs
                            where phong.MAPH == maPhong
                            select phong).First();
                ph.MAPH = maPhong;
                ph.KHUVUC = khuvuc;
                ph.MALOAIPH = loaiPhong;
                ph.TINHTRANG = tinhTrang;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
