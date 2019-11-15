using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace hmi
{
    class Alarm
    {
        int posX, posY, size;
        Color colorOk = Color.Lime;
        Color colorFail = Color.OrangeRed;
        Color colorOff = Color.Black;

        public Alarm()
        {
            this.posX = 850;
            this.posY = 50;
            this.size = 50;
        }
        public Alarm(int PosX, int PosY, int Size)
        {
            this.posX = PosX;
            this.posY = PosY;
            this.size = Size;
        }
        public void Paint(PaintEventArgs e, bool fail, int tick)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;

                Pen pen = new Pen(Color.Black, 3);
                e.Graphics.DrawEllipse(pen, posX, posY, size, size);
                Brush brush;
                if (fail)
                {
                    if (tick>0)
                        brush = new SolidBrush(colorFail);
                    else
                        brush = new SolidBrush(colorOff);
                }
                else
                {
                    brush = new SolidBrush(colorOk);
                }
                e.Graphics.FillEllipse(brush, posX, posY, size, size);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
