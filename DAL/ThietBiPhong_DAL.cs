using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThietBiPhong_DAL : Database
    {
        public ThietBiPhong_DAL()
        {
        }
        public dynamic loadTable_ThietBiPHong(string maph)
        {
            return from ph in db.PHONGs
                   join tb_trb in db.TRANGBI_THIETBIs on ph.MAPH equals tb_trb.MAPH
                   join tb in db.CHITIETTRANGBIs on tb_trb.MATB equals tb.MATB
                   join t in db.THIETBIs on tb.MATHIETBI equals t.MATHIETBI
                   where ph.MAPH == maph
                   select new
                   {
                       MATHIETBI = t.MATHIETBI,
                       TENTHIETBI = t.TENTHIETBI,

                   };
            //return from ph in db.PHONGs
            //       from tbtrb in db.TRANGBI_THIETBIs
            //       from tb in db.CHITIETTRANGBIs
            //       from t in db.THIETBIs
            //       where (ph.MAPH == maph && ph.MAPH == tbtrb.MAPH && tbtrb.MATB == tb.MATB && tb.MATHIETBI == t.MATHIETBI)
            //       group t by t.MATHIETBI;


        }

    }
}
