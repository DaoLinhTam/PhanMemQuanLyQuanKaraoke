using DAL_DATASET.QLKARAOKETableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DATASET
{
  public  class PhieuDatPhong_DAL
    {
        PHIEUDATPHONGTableAdapter adapter = new PHIEUDATPHONGTableAdapter();
        CHITIET_PHIEUDATPHONGTableAdapter ch_adapter = new CHITIET_PHIEUDATPHONGTableAdapter();
   
        PHONGTableAdapter ph_adapter = new PHONGTableAdapter();
       
        public DataTable getData()
        {
           return adapter.GetData();
        }

        public DataTable getDataQuery()
        {
           return adapter.GetDataQuery();
            
        }


      //dùng để lọc dữu liêu
        public DataTable getDataFilter(string NgayDat,string NgayVao)
        {
            DataTable dt = getData();
            DataView dv = new DataView(dt);
            dv.RowFilter = "NGAYVAO = '"+NgayDat+"'";
            return dv.Table.Copy();
        }

       //lấy ds phòng đã có người đặt rồi vao hôm đó
        public List<string> getDSChiTietPhieuDP(string dtngayvao)
        {
            DataTable dt = adapter.GetDataDSTrong();
            List<string> lst = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string ngayvao = DateTime.Parse(r["NGAYVAO"].ToString()).ToShortDateString();
                if (ngayvao == dtngayvao)

                    lst.Add(r["MAPH"].ToString());
            }
            return lst;
        }


      //lấy mã lơn nhất
        public string getTopByMa() //lấy mã lớn nhất để tạo id auto
        {
            return (string)adapter.getTopByMa();
        }

        public int Them(string MAPHIEUDH,string  MAKH, string MANV,DateTime NGAYDAT, DateTime NGAYVAO,string GIOVAO)
        {          
            return adapter.InsertQuery(MAPHIEUDH, MAKH, MANV, NGAYDAT.ToShortDateString(), NGAYVAO.ToShortDateString(), GIOVAO);
        }


        public bool CheckPhongTrong(string MAPHONG,string NGAYVAO,int GIOSOSANH)
        {
            int k=(int)adapter.CheckPhongTrong(MAPHONG, NGAYVAO, GIOSOSANH);
            if (k > 0)
                return false;
            else return true;
        }

        public bool CheckPhongDat_ByMa(string NGAYVAO,string MAPH)
        {
            int k = (int)adapter.CheckPhongDat_ByDay(NGAYVAO, MAPH);
            if (k > 0)
                return true;
            else return false;
        }

        public string getGioPhongDat(string MAPH,string NGAYVAO)
        {
            DataTable dt = adapter.GetGioPhongDat(MAPH, NGAYVAO);
            return dt.Rows[0]["GIOVAO"].ToString();
        }


        
    }
}
