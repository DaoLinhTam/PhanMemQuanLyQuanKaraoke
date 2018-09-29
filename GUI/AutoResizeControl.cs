using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
   
        public class AutoResizeControl
        {
            // List<Control> arrCtr;  //chứa các trol dùng 1 from
            List<Rectangle> lstRec;  //chứa vị trí control đó trong khởi tạo
            Control ctrFromOld;//chứa kích from thước ban đầu
            Rectangle recFromOld;

            public AutoResizeControl(Control control)
            {

                this.ctrFromOld = control;
                this.recFromOld = new Rectangle(control.Location, control.Size);
                getAllControl(ctrFromOld);

            }

            public void getAllControl(Control ctr)
            {
                lstRec = new List<Rectangle>();
                getControl(ctr);
            }
            private void getControl(Control control)
            {
                foreach (Control ctr in control.Controls)
                {
                    lstRec.Add(new Rectangle(ctr.Location, ctr.Size));
                    if(ctr.Controls.Count>0)
                          getControl(ctr);
                }


            }


            private void resizeControl(Rectangle recControl, Rectangle recFromOld, Rectangle recFromNew, Control ctrChild)
            {
                float x = (float)(recFromNew.Width) / (float)(recFromOld.Width);  //lấy tỉ lệ co giãn chiều rộng
                float y = (float)(recFromNew.Height) / (float)(recFromOld.Height);//lấy tỉ lệ co giãn chiều ngang

                int newX = (int)(recControl.X * x);
                int newY = (int)(recControl.Y * y);

                int newWidth = (int)(recControl.Width * x);
                int newHeight = (int)(recControl.Height * y);

                ctrChild.Location = new Point(newX, newY);
                ctrChild.Size = new Size(newWidth, newHeight);
            }


            public void resizeAll(Control ctrForm)
            {
                int index = 0;
                resizeControls(new Rectangle(ctrForm.Location, ctrForm.Size), ctrForm, index);

            }

            public void resizeControls(Rectangle recFromNew, Control control, int index)
            {

                foreach (Control ctr in control.Controls)
                {
                    resizeControl(lstRec[index], recFromOld, recFromNew, ctr);
                    index++;
                    resizeControls(recFromNew, ctr, index);
                }

            }

        }
 
}
