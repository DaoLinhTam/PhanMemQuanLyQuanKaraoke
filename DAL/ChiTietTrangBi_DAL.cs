using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class ChiTietTrangBi_DAL:Database
    {
        public ChiTietTrangBi_DAL()
        {
        }
        public dynamic loadTable_ChiTietTrangBi(string matb)
        {
            return from cttb in db.CHITIETTRANGBIs
                   where cttb.MATB == matb
                   select cttb;
        }
        public bool kiemtratrungcttb(string matb, string mathietbi)
        {
            int a = 0;
            a = (from cttb in db.CHITIETTRANGBIs
                                  where (cttb.MATB == matb && cttb.MATHIETBI ==mathietbi)
                                  select cttb).Count();
            if (a == 0)
            {
                return true;
            }
            else return false;
        }
        public bool ktctsoluonghet(string matb, string mathietbi)
        {
            int a = 0;
            a = (from cttb in db.CHITIETTRANGBIs
                 where (cttb.MATB == matb && cttb.MATHIETBI == mathietbi && cttb.SOLUONGTRANGBI == 0)
                 select cttb).Count();
            if (a ==1)
            {
                return true;
            }
            {
                return false;
            }
        }
        public bool themChiTietThietBi(string matb, string mathietbi, int soluongtb)
        {
            CHITIETTRANGBI cttb = new CHITIETTRANGBI();
            cttb.MATB = matb;
            cttb.MATHIETBI = mathietbi;
            cttb.SOLUONGTRANGBI = soluongtb;
            db.CHITIETTRANGBIs.InsertOnSubmit(cttb);
            db.SubmitChanges();

            return true;

        }
        
        public bool XoaChiTietThietBi(string matb,string mathietbi)
        {
            CHITIETTRANGBI ct = (from cttb in db.CHITIETTRANGBIs
                                  where (cttb.MATB == matb && cttb.MATHIETBI ==mathietbi)
                                  select cttb).First();

            db.CHITIETTRANGBIs.DeleteOnSubmit(ct);
            db.SubmitChanges();

            return true;

        }

        public bool SuaTrangBiThietBi(string matb, string mathietbi,int soluongtb)
        {
            CHITIETTRANGBI ct = (from cttb in db.CHITIETTRANGBIs
                                  where (cttb.MATB == matb&& cttb.MATHIETBI ==mathietbi)
                                  select cttb).First();

            ct.MATB = matb;
            ct.MATHIETBI = mathietbi;
            ct.SOLUONGTRANGBI = soluongtb;
            db.SubmitChanges();

            return true;

        }
        public bool updatethemTrangBiThietBi(string matb, string mathietbi, int soluongtb)
        {
            CHITIETTRANGBI ct = (from cttb in db.CHITIETTRANGBIs
                                 where (cttb.MATB == matb && cttb.MATHIETBI == mathietbi)
                                 select cttb).First();

            ct.MATB = matb;
            ct.MATHIETBI = mathietbi;
            ct.SOLUONGTRANGBI += soluongtb;
            db.SubmitChanges();

            return true;

        }
        public bool updateTrangBiThietBiTrove(string matb, string mathietbi, int soluongtb)
        {
            CHITIETTRANGBI ct = (from cttb in db.CHITIETTRANGBIs
                                 where (cttb.MATB == matb && cttb.MATHIETBI == mathietbi)
                                 select cttb).First();

            ct.MATB = matb;
            ct.MATHIETBI = mathietbi;
            ct.SOLUONGTRANGBI -= soluongtb;
            db.SubmitChanges();

            return true;

        }
    }
    
}
