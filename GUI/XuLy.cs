using GUI.QLKaraokeTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class XuLy
    {
        public string AutoID(string strMA,DataTable dt,string Short)
        {
            
            dt.DefaultView.Sort = Short;  //sắp xếp từ dataview
            dt = dt.DefaultView.ToTable(true);  //gán bảng lại
            if (dt.Rows.Count == 0)
            {
                return strMA+"001";
            }
            else
            {
                string strTam = dt.Rows[0][0].ToString();
                strTam = strTam.Substring(strTam.Length - 3);
                int intTam = int.Parse(strTam);
                string[] str0 = { "0", "00" };
                return TinhToanID(strMA,str0, intTam);
                         
            }
        }


        public string AutoID(string strMA, string strMaTop)
        {

            if (strMaTop == null)
            {
                return strMA + "0001";
            }
            else
            { 
                string[] str0 = { "00", "000" };
                int intTam=int.Parse(strMaTop.Substring(2));
             return   TinhToanID(strMA, str0, intTam);
            }
        }

        public string AutoID5(string strMA, string strMaTop)
        {

            if (strMaTop == null)
            {
                return strMA + "001";
            }
            else
            {
                string[] str0 = { "0", "00" };
                int intTam = int.Parse(strMaTop.Substring(2));
                return TinhToanID(strMA, str0, intTam);
            }
        }
        

        public string AutoID_PhieuDatPhong(string strMA,string strMaTop)
        {
            DateTime t=DateTime.Now;

            string strDate = strMA+t.ToString("dd/MM/yyyy").Replace("/", "");
            t = new DateTime(t.Year, t.Month, t.Day,0,0,0);
            if (strMaTop==null)
                return strDate + "001";
            else
            {
                string strTam = strMaTop;  //lấy mã đầu tiên trong bảng sau khi sx
                strTam = strTam.Substring(2,8);   //lấy ngày trong chuỗi ra

                //lay tung thoi gian
                int ngay = int.Parse(strTam.Substring(0, 2));   
                int thang = int.Parse(strTam.Substring(2, 2));
                int nam = int.Parse(strTam.Substring(strTam.Length - 4));
                DateTime date = new DateTime(nam, thang, ngay);
                TimeSpan ts =t-date;
                string[] str0 = { "0", "00" };

                //nếu nó bằng time hiện tại
                if (ts.Days==0)
                {
                    strTam = strMaTop;
                    strTam = strTam.Substring(strTam.Length - 3);
                    int intTam = int.Parse(strTam);
                    return TinhToanID(strDate,str0, intTam);
                    
                }
                      //nếu nó bằng time hiện tại
                else  if (ts.Days > 0)
                {
                    strTam = strMaTop;
                    strTam = strTam.Substring(strTam.Length - 3);
                    int intTam = int.Parse(strTam);
                   
                    return TinhToanID(strDate,str0, intTam);        
                }
                else
                {
                    return strDate + "001";
                }
                
            }
          
        }


        public bool KTFullData(Control[] ctr)
        {
            foreach (Control c in ctr)
            {
                if (c.Text.Length == 0)
                    return false;
            }
            return true;
        }
        private string TinhToanID(string strHead,string []str0,int intTam)
        {
            String strID = null;
            if (intTam > 0 && intTam < 9)
                strID =strHead + str0[1] + (intTam + 1);
            else if (intTam >= 9 && intTam < 99)
                strID = strHead + str0[0] + (intTam + 1);
            else
                strID = strHead + (intTam + 1);

            return strID;
        }

        //Các MessageBox Thông Dụng
        public DialogResult MessageBoxCanhBao(string message)
        {
            return MessageBox.Show(message,"Cảnh Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }
        public DialogResult MessageBoxThongBaoEror(string message)
        {
            return MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DialogResult MessageBoxThongBao(string message)
        {
            return MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult MessageBoxThongBaoXacNhan(string message)
        {
            return MessageBox.Show(message, "Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }



        //Xử Lý Giao Diện Thêm Xóa Sưa
        public void XuLyGiaoDien_KhiThem(Control btnThem, Control btnXoa, Control btnSua, Control btnLuu, Control btnHuy)
        {
            btnThem.Enabled =false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }
        public void XuLyGiaoDien_KhiXoa(Control btnThem, Control btnXoa, Control btnSua, Control btnLuu, Control btnHuy)
        {
            //nút thêm ẩn đi;
            btnThem.Enabled = false;
            //nút xóa ẩn đi
            btnXoa.Enabled = false;
            //nút lưu ẩn đi
            btnLuu.Enabled = true;
            //nút cancel ẩn đi
            btnHuy.Enabled = true;
        }
        public void XuLyGiaoDien_KhiSua(Control btnThem, Control btnXoa, Control btnSua, Control btnLuu, Control btnHuy)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
           
        }
        public void XuLyGiaoDien_KhiHuy(Control btnThem, Control btnXoa, Control btnSua, Control btnLuu, Control btnHuy)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            
        }
        public void XuLyGiaoDien_KhiLuu(Control btnThem, Control btnXoa, Control btnSua, Control btnLuu, Control btnHuy)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

        }
        public void XuLyGiaoDien_KhiLoad(Control btnThem, Control btnXoa, Control btnSua, Control btnLuu, Control btnHuy)
        {
            //nút thêm hiện lên;
            btnThem.Enabled = true;
            //nút xóa ẩn đi
            btnXoa.Enabled = true;
            //nút lưu ẩn đi
            btnLuu.Enabled = false;
            //nút cancel ẩn đi
            btnHuy.Enabled = false;
        }


       
        public void TextBoxNhapSo(TextBox textbox)
        {
            textbox.KeyPress += textbox_KeyPress;
        }
        void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back) 
            {
                e.Handled = true;
            }
        }

        //kierm tra sdt hợp lệ
        public bool KiemTraSDT_HopLe(TextBox txt)
        {
            string s = txt.Text.Trim();
            if (s.Length != 10 && s.Length != 11)
            {
                MessageBoxCanhBao("Độ Dài Số Điện Thoại Không Hợp Lệ");
                txt.Focus();
                return false;
            }
            return true;
        }

        //Filter BiddingSource
        public int FilterBiddingSource(BindingSource bind, string strFilter)
        {
            bind.Filter = strFilter;
            return bind.Count;

        }


        internal void XuLyGiaoDien_KhiLoad(ToolStripButton btnThem, ToolStripButton btnXoa, ToolStripButton btnSua, ToolStripButton btnHuy, ToolStripButton btnLuu)
        {
            //nút thêm hiện lên;
            btnThem.Enabled = true;
            //nút xóa ẩn đi
            btnXoa.Enabled = true;
            //nút lưu ẩn đi
            btnLuu.Enabled = false;
            //nút cancel ẩn đi
            btnHuy.Enabled = false;
        }

        internal void XuLyGiaoDien_KhiThem(ToolStripButton btnThem, ToolStripButton btnXoa, ToolStripButton btnSua, ToolStripButton btnLuu, ToolStripButton btnHuy)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        internal void XuLyGiaoDien_KhiSua(ToolStripButton btnThem, ToolStripButton btnXoa, ToolStripButton btnSua, ToolStripButton btnLuu, ToolStripButton btnHuy)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        internal void XuLyGiaoDien_KhiHuy(ToolStripButton btnThem, ToolStripButton btnXoa, ToolStripButton btnSua, ToolStripButton btnLuu, ToolStripButton btnHuy)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        internal void XuLyGiaoDien_KhiLuu(ToolStripButton btnThem, ToolStripButton btnXoa, ToolStripButton btnSua, ToolStripButton btnLuu, ToolStripButton btnHuy)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }
    }
}
