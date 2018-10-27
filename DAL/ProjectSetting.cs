using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public static class ProjectSetting
    {
       //class này để lấy để cho GUI lấy connect string
        public static string ConnectionString
        {
            get
            {
                return DAL.Properties.Settings.Default.StringConnect;
            }
        }
    }
}
