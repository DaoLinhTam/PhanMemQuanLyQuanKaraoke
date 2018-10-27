using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Database
    {
      public  QLKaraokeDataContext db;
        public Database()
        {
            db = new QLKaraokeDataContext(DAL.Properties.Settings.Default.StringConnect);
        }
    }
}
