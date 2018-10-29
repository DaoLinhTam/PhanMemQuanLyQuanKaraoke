using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapThietBi_DAL : Database
    {
        public dynamic getData()
        {
            return from pn in db.PHIEUNHAPTHIETBIs
                   join nv in db.NHANVIENs on pn.MANV equals nv.MANV
                   select new { pn.MAPHIEUNHAP, nv.TENNV, pn.NGAYNHAP, pn.TONGTIEN };

        }

        public bool Them(string mapn, DateTime ngaynh, string manv)
        {
            try
            {
                PHIEUNHAPTHIETBI pn = new PHIEUNHAPTHIETBI();
                pn.MAPHIEUNHAP = mapn;
                pn.NGAYNHAP = ngaynh;
                pn.MANV = manv;
                pn.TONGTIEN = 0;
                db.PHIEUNHAPTHIETBIs.InsertOnSubmit(pn);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }


        public string getTopMa()
        {
            try
            {

                return db.PHIEUNHAPTHIETBIs.OrderByDescending(t => t.MAPHIEUNHAP).ToList().First().MAPHIEUNHAP;

            }
            catch { return null; }
        }



    }
}
