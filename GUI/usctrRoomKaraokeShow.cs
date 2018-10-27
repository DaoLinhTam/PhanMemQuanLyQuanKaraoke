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
        int stateMoPhong;
        //--------------

        public string TrangThai
        {
            get {return lblTime.Text; }
            set { lblTime.Text = value; }
        }

        public string TenPhong
        {
            get { return lblTenPhong.Text;}
            set{lblTenPhong.Text=value;}
        }

        public bool Visiblel_lblTime
        {
            get { return lblTime.Visible; }
            set { lblTime.Visible = value; }
        }

        public Color lblTime_Color
        {
            get { return lblTime.BackColor; }
            set { lblTime.BackColor = value; }
        }
     

        //--------------
        XuLy xl = new XuLy();
        public usctrRoomKaraokeShow()
        {
            InitializeComponent();
            stateMoPhong=0;
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

            if (stateMoPhong == 1)
            {
                xl.MessageBoxThongBao("Phòng Đang Mở!");
                return;
            }
           //xuly giao dien
              //đổi ảnh

            lblTime.Text = "00:00";
            lblTime.BackColor = Color.Red;
            picbox.Image = Properties.Resources.icon_room;
            //thời gian bắt đầu chạy
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
            //showtime
            lblTime.Visible = true;
            stateMoPhong = 1;  //phong đã đc mở


        }

        int Gio = 0;
        int Phut = 0;
        int Giay = 0;
        void timer_Tick(object sender, EventArgs e)
        {
            Giay++;
            if (Giay == 59)
            {
                Phut++;
                Giay = 0;
                lblTime.Text = CapNhatGio(Gio, Phut);
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
