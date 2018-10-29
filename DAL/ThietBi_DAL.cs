using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class ThietBi_DAL:Database
    {

      public IEnumerable<THIETBI> getData()
      {
          return from tb in db.THIETBIs
                 select tb;
      }

      public bool Them(string matb,string tentb,int slton,string dvt,float giatri)
      {

          try
          {
              THIETBI tb = new THIETBI();
              tb.MATHIETBI = matb;
              tb.TENTHIETBI = tentb;
              tb.SOLUONGTON = slton;
              tb.DVT = dvt;
              tb.GIATRI = giatri;
              db.THIETBIs.InsertOnSubmit(tb);
              db.SubmitChanges();
              return true;
          }
          catch
          {
              return false;
          }
      }
      public bool Xoa(string MATB)
      {
          try
          {
              THIETBI tb = db.THIETBIs.SingleOrDefault(t => t.MATHIETBI == MATB);
              db.THIETBIs.DeleteOnSubmit(tb);
              db.SubmitChanges();
              return true;
          }
          catch { return false; };
         
      }
      public bool Sua(string matb, string tentb, string dvt, float giatri)
      {
          try
          {
              THIETBI tb = db.THIETBIs.SingleOrDefault(t => t.MATHIETBI == matb);
              tb.MATHIETBI = matb;
              tb.TENTHIETBI = tentb;
              tb.DVT = dvt;
              tb.GIATRI = giatri;
              db.SubmitChanges();
              return true;
          }
          catch
          {
              return false;
          }
      
      }

      public string getTopMa()
      {
          try
          {
              return db.THIETBIs.OrderByDescending(t => t.MATHIETBI).ToList().First().MATHIETBI;
          }
          catch { return null; }
      }


      public IEnumerable<THIETBI> load_gCTB()
      {
          return from tb in db.THIETBIs
                 select tb;
      }


      public bool themTB(string ma, string ten, int slt, string dvt, float gt)
      {
          try
          {
              THIETBI tb = new THIETBI();
              tb.MATHIETBI = ma;
              tb.TENTHIETBI = ten;
              tb.SOLUONGTON = slt;
              tb.DVT = dvt;
              tb.GIATRI = gt;
              db.THIETBIs.InsertOnSubmit(tb);
              db.SubmitChanges();
              return true;
          }
          catch (Exception ex)
          {
              return false;
          }
      }

      public string getMaTop()
      {
          if (load_gCTB().Count() > 0)
          {
              return (from tb in db.THIETBIs
                      select tb).OrderByDescending(t => t.MATHIETBI).First().MATHIETBI;
          }
          return null;
      }

      public bool xoaTB(string ma)
      {
          try
          {
              THIETBI tb = (db.THIETBIs.Where(t => t.MATHIETBI == ma).FirstOrDefault());
              db.THIETBIs.DeleteOnSubmit(tb);
              db.SubmitChanges();
              return true;
          }
          catch (Exception ex)
          {
              return false;
          }
      }

      public bool suaTB(string ma, string ten, string dvt, float gt)
      {
          try
          {
              THIETBI tb = (db.THIETBIs.Where(t => t.MATHIETBI == ma).FirstOrDefault());
              tb.TENTHIETBI = ten;
              tb.DVT = dvt;
              tb.GIATRI = gt;
              db.SubmitChanges();
              return true;
          }
          catch (Exception ex)
          {
              return false;
          }
      }
      public bool updateThemChiTietTB(string ma, int slt)
      {
          THIETBI ct = (from cttb in db.THIETBIs
                        where (cttb.MATHIETBI == ma)
                        select cttb).First();

          ct.MATHIETBI = ma;
          ct.SOLUONGTON -= slt;
          db.SubmitChanges();

          return true;
      }
      public bool updateTBtrove(string ma, int slt)
      {
          THIETBI ct = (from cttb in db.THIETBIs
                        where (cttb.MATHIETBI == ma)
                        select cttb).First();

          ct.MATHIETBI = ma;
          ct.SOLUONGTON += slt;
          db.SubmitChanges();

          return true;
      }

    }
}
