using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI
{
    class TrangThaiPhong
    {
        string maPhong;

       
        int gio, phut, giay;

        public int Giay
        {
            get { return giay; }
            set { giay = value; }
        }

        public int Phut
        {
            get { return phut; }
            set { phut = value; }
        }

        public int Gio
        {
            get { return gio; }
            set { gio = value; }
        }

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }


       
        public TrangThaiPhong()
        { }

        public TrangThaiPhong(string maPhong, int Gio,int Phut,int Giay)
        {
            this.maPhong = maPhong;
            this.Gio = gio;
            this.Phut = phut;
            this.Giay = giay;
        }

        

    }
}
