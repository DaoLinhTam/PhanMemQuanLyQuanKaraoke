using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
   public class CauHinh_DAL
    {
        public int Check_Config()
        {
            SqlConnection cnn;
           
          
            if (DAL.Properties.Settings.Default.StringConnect == string.Empty)  //k tồn tại chuỗi cấu hình
                  return 1;  //k tồn tại
            using (cnn = new SqlConnection(DAL.Properties.Settings.Default.StringConnect))
            {
             try
                {
                    if (cnn == null)
                        return 0;

                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                        cnn.Close();
                      
                    }

                }
                catch
                {

                    return 2; //chuỗi cấu hình sai
                }
   
        
            
        }

            return 0;
        
        }
        public int checkUser(string pUser, string pPass)
        {
            try
            {
                QLKaraokeDataContext db = new QLKaraokeDataContext();
        
                int dem = (from nd in db.NGUOIDUNGs
                           where nd.MATKHAU == pPass && nd.TENDANGNHAP == pUser
                           select nd).Count();
                if (dem == 0) return 2; //k có user nào

                NGUOIDUNG nguoidung = (from nd in db.NGUOIDUNGs
                                       where nd.MATKHAU == pPass && nd.TENDANGNHAP == pUser
                                       select nd).First();
                if (nguoidung.TINHTRANG == null || nguoidung.TINHTRANG == false)
                    return 1;//tài khoản bị khóa
                return 0;
            }
            catch
            {
                return 3; // lỗi config
            }
           

        }
        public List<string> getDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> lst = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                string strQuery = "Select name From sys.databases";
                string strCnn = "Server=" + pServerName + ";Database=master;User ID=" + pUser + ";pwd=" + pPass + "";
                SqlDataAdapter da = new SqlDataAdapter(strQuery, strCnn);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                    foreach (DataColumn col in dt.Columns)
                        lst.Add(row[col].ToString());

            }
            catch
            {
                return null;
            }
            return lst;
        }


        public void saveConnect(string pServerName, string pDatabase, string pUser, string pPass)
        {
            string strConnect = "Server=" + pServerName + ";Database=" + pDatabase + ";User ID=" + pUser + ";pwd=" + pPass + "";
            DAL.Properties.Settings.Default.StringConnect= strConnect;
            DAL.Properties.Settings.Default.Save();
          

         
           
        }

        public DataTable getServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            return instance.GetDataSources();
        }


        public String Load_User()
        {
            return DAL.Properties.Settings.Default.StringUser;
        }
        public String Load_Pass()
        {
            return DAL.Properties.Settings.Default.StringPass;
        }

        public void SaveAccount(String user,String pass)
        {
            DAL.Properties.Settings.Default.StringUser = user;
            DAL.Properties.Settings.Default.StringPass=pass;
            DAL.Properties.Settings.Default.Save();
        }
        public void saveState_Chk(bool bol)
        { 
             DAL.Properties.Settings.Default.CheckLuu=bol;
             DAL.Properties.Settings.Default.Save();
        }

        public bool loadState_Chk()
        {
            return DAL.Properties.Settings.Default.CheckLuu;
        }

   
    }
}
