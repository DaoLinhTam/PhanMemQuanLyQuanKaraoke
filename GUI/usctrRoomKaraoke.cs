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
    public partial class usctrRoomKaraoke : UserControl
    {

        public delegate void SentData(string txt);
        public event SentData sentdata;
         
        

        public Image Image
        {         
            set { pictureBox1.Image = value; }
        }
        public string MaPhong
        {
            get { return lblTenPhong.Text; }
            set { lblTenPhong.Text = value; }
        }
     

   
        public usctrRoomKaraoke()
        {
            InitializeComponent();
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            XuLuSuKien();
        }

        private void usctrRoomKaraoke_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void usctrRoomKaraoke_Click(object sender, EventArgs e)
        {
            XuLuSuKien();
       
        }

        private void XuLuSuKien()
        {
            try
            {
                this.BackColor = Color.Yellow;
                sentdata(lblTenPhong.Text);
            }
            catch { };
        }

       

     
       
    }
}
