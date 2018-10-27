using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Phong_DAL:Database
    {
       public dynamic LoadData()
       {
           return db.PHONGs.Select(t => t).ToList();
       }
    }
}
