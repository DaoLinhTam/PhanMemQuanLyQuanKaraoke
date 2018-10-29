using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class MatHang_DAL:Database
    {
       public MatHang_DAL() { }


       public IEnumerable<MATHANG> getData()
       {
           return from mh in db.MATHANGs
                  select mh;
       }

       public bool Them( string MAMATHANG,string TENMATHANG,int LOAIMATHANG,int SOLUONGTON,int DONGIABAN,string DVT)
       {
           try
           {
               MATHANG mh = new MATHANG();

               mh.MAMATHANG = MAMATHANG;
               mh.TENMATHANG = TENMATHANG;
               mh.LOAIMATHANG = LOAIMATHANG;
               mh.SOLUONGTON = SOLUONGTON;
               mh.DONGIABAN = DONGIABAN;
               mh.DVT = DVT;
               db.MATHANGs.InsertOnSubmit(mh);
               db.SubmitChanges();
               return true;
           }
           catch (Exception ex) {

               return false;
           }
              
       }
       public bool Xoa(string MAMATHANG)
       {
           try
           {
               MATHANG mh = db.MATHANGs.SingleOrDefault(t => t.MAMATHANG == MAMATHANG);
               db.MATHANGs.DeleteOnSubmit(mh);
               db.SubmitChanges();
               return true;
           }
           catch (Exception ex)
           {
               return false;
           }

       }
       public bool Sua(string MAMATHANG, string TENMATHANG, int LOAIMATHANG, int DONGIABAN, string DVT)
       {
           try
           {
               MATHANG mh = db.MATHANGs.SingleOrDefault(t => t.MAMATHANG == MAMATHANG);
               mh.TENMATHANG = TENMATHANG;
               mh.LOAIMATHANG = LOAIMATHANG;
               mh.DONGIABAN = DONGIABAN;
               mh.DVT = DVT;
               db.SubmitChanges();
               return true;
           }
           catch (Exception ex)
           {

               return false;
           }

       }


       public string getTopMa()
       {
           try
           {

               return db.MATHANGs.OrderByDescending(t => t.MAMATHANG).ToList().First().MAMATHANG;
          
           }
           catch { return null; }
       }


    
    }
}
