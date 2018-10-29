using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usctrRoomKaraokeShow : UserControl
    {
        Timer timer;
        bool stateMoPhong;
        DateTime time;

        int gio;
        int giay;
        int phut;

        public int Gio
        {
            get { return gio; }
            set { gio = value; }
        }
    

        public int Phut
        {
            get { return phut; }
            set { phut = value; }
        }
        

        public int Giay
        {
            get { return giay; }
            set { giay = value; }
        }

        public usctrRoomKaraokeShow(int Gio, int Phut, int Giay, bool StateMoPhong)
        {
            this.Gio = Gio;
            this.Phut = Phut;
            this.Giay = Giay;
            this.stateMoPhong = stateMoPhong;
            XuLySuKienChayGio();
            //gan laij
            
        }
        public bool StateMoPhong
        {
            get { return stateMoPhong; }
            set { stateMoPhong = value; }
        }

       
        //--------------


       
     

        public string MaPhong
        {
            get { return lblTenPhong.Text;}
            set{lblTenPhong.Text=value;}
        }


        public void lblTime_ChangeProperties(string text,Color BackColor,bool visible)
        {
            lbltime.Text = text;
            lbltime.BackColor = BackColor;
            lbltime.Visible = visible;
        }
        //--------------
        XuLy xl = new XuLy();
        public usctrRoomKaraokeShow()
        {
            InitializeComponent();
            stateMoPhong=false;
            SuKien();
        }

        private void _Load()
        {
          
        }

        private void SuKien()
        {
           
            this.Load += usctrRoomKaraokeShow_Load;
            btnMoPhong.Click += btnMoPhong_Click;
        }

        void usctrRoomKaraokeShow_Load(object sender, EventArgs e)
        {
            _Load();
        }

        void btnMoPhong_Click(object sender, EventArgs e)
        {

            if (stateMoPhong == true)
            {
                xl.MessageBoxThongBao("Phòng Đang Mở!");
                return;
            }
           //xuly giao dien
              //đổi ảnh

            lbltime.Text = "00:00";
          //phong đã đc mở
            XuLySuKienChayGio();


        }

        public void XuLySuKienChayGio()
        {
          
            //thời gian bắt đầu chạy
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
            //showtime
            lbltime.Visible = true;
            stateMoPhong = true;  
        }

      
        void timer_Tick(object sender, EventArgs e)
        {
            Giay++;
            if (Giay == 59)
            {
                Phut++;
                Giay = 0;
                lbltime.Text = CapNhatGio(Gio, Phut);
                if (Phut == 59)
                {
                    Gio++;
                    Phut = 0;
                }
            }

           
     
        }


        private string CapNhatGio(int Gio,int Phut)
        {
            String strTime = "";
            String strGio = null;
            String strPhut = null;
            if (Gio < 10)
                strGio = "0" + Gio;
            if (Phut < 10)
                strPhut = "0" + Phut;

            strTime = strGio + ":" + strPhut;
            return strTime;
        }

        
    }
}
