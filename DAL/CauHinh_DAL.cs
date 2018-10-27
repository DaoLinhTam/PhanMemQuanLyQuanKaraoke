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
                String strQuery = "SELECT * FROM NGUOIDUNG WHERE TENDANGNHAP ='" + pUser + "' AND MATKHAU = '" + pPass + "'";
                String strConnect = Properties.Settings.Default.StringConnect;
                SqlDataAdapter da = new SqlDataAdapter(strQuery, strConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
               
                int dong = dt.Rows.Count;
                if (dong > 0)   //tồn tại 1 dòng trong bảng người dùng khi truy vấn
                {
                    bool stateKhoa = (bool)dt.Rows[0][3];
                    if (!stateKhoa)
                    {
                        return 1; //tài khoản bị khóa
                    }
                    return 0; //đăng nhập thành công!
                }
                else  //domg==0
                {
                    return 2;  //không có user //hoặc tên mk or tài khoản bị sai
                }
            }
            catch (Exception ex)  //trường hợp chọn sai database và không có bảng người dùng=> chuỗi cấu hình sai
            {
                return 3;  //sai database
            }
        }
        public List<string> getDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> lst = new List<string>();  //khởi tạo list chứa các database
            DataTable dt = new DataTable();
            try
            {
                string strQuery = "SELECT NAME FROM  SYS.DATABASES";
                string strCnn = "SERVER=" + pServerName + ";DATABASE=MASTER;USER ID=" + pUser + ";PWD=" + pPass + "";
                SqlDataAdapter da = new SqlDataAdapter(strQuery, strCnn);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                    foreach (DataColumn col in dt.Columns)
                        lst.Add(row[col].ToString());

                return lst;
            }
            catch
            {
                return null;
            }
            
        }


        public void saveConnect(string pServerName, string pDatabase, string pUser, string pPass)
        {
            string strConnect = "Server=" + pServerName + ";Database=" + pDatabase + ";User ID=" + pUser + ";pwd=" + pPass + "";
            DAL.Properties.Settings.Default.StringConnect= strConnect; 
            DAL.Properties.Settings.Default.Save();       
        }

        public DataTable getServerName()
        {
            //lệnh getserver name
            //nhớ bật sql browser và tắt tường lửa
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
