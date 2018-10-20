using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
  public  class CauHinh_BUS
    {
        CauHinh_DAL cauhinh = new CauHinh_DAL();

        public int checkUser(string user,string pass)
        {
            return cauhinh.checkUser(user, pass);
        }
        public List<string> getDatabaseName(string strServer, string strUser, string strPass)
        {
            return cauhinh.getDatabaseName(strServer,strUser,strPass);

        }
        public DataTable getServerName()
        {
            return cauhinh.getServerName();
        }
        public int Check_Config()
        {
            return cauhinh.Check_Config();
        }

        public void saveConnect(string pServerName, string pDatabase, string pUser, string pPass)
        {
             cauhinh.saveConnect(pServerName, pDatabase, pUser, pPass);
        }

        public String Load_User()
        {
            return cauhinh.Load_User();
        }
        public String Load_Pass()
        {
            return cauhinh.Load_Pass();
        }

        public void SaveAccount(String user, String pass)
        {
            cauhinh.SaveAccount(user, pass);
        }
        public void saveState_Chk(bool bol)
        {
            cauhinh.saveState_Chk(bol);
        }
        public bool loadState_Chk()
        {
            return cauhinh.loadState_Chk();
        }

      

    }
}
