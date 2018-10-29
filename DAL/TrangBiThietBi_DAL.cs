using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TrangBiThietBi_DAL : Database
    {
        public TrangBiThietBi_DAL()
        {
        }
        public dynamic load_tbtb()
        {
            return from tbtb in db.TRANGBI_THIETBIs
                   select tbtb;
        }
        public bool themTrangBiThietBi(string matb, string maph, DateTime ngaytrangbi)
        {
            TRANGBI_THIETBI tbtb = new TRANGBI_THIETBI();
            tbtb.MAPH = maph;
            tbtb.MATB = matb;
            tbtb.NGAYTRANGBI = ngaytrangbi;
            db.TRANGBI_THIETBIs.InsertOnSubmit(tbtb);
            db.SubmitChanges();

            return true;

        }
        public bool XoaTrangBiThietBi(string matb)
        {
            TRANGBI_THIETBI tb = (from tbtb in db.TRANGBI_THIETBIs
                                  where tbtb.MATB == matb
                                  select tbtb).First();

            db.TRANGBI_THIETBIs.DeleteOnSubmit(tb);
            db.SubmitChanges();

            return true;

        }

        public bool SuaTrangBiThietBi(string matb, string maph, DateTime ngaytrangbi)
        {
            TRANGBI_THIETBI tb = (from tbtb in db.TRANGBI_THIETBIs
                                  where tbtb.MATB == matb
                                  select tbtb).First();

            tb.MAPH = maph;
            tb.MAPH = matb;
            tb.NGAYTRANGBI = ngaytrangbi;
            db.SubmitChanges();

            return true;

        }

    }
}
