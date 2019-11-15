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
    class Poziom
    {
        private int levelActual, levelMax, posX,posY,width,height,segments;
        public Poziom()
        {
            this.levelActual = 50;
            this.levelMax = 100;
            this.posX = 600;
            this.posY = 300;
            this.width = 100;
            this.height = 220;
            this.segments = 10;
        }
        public Poziom(int LevelActual, int LevelMax, int PosX, int PosY, int Width,int Height,int Segments)
        {
            this.levelActual = LevelActual;
            this.levelMax = LevelMax;
            this.posX = PosX;
            this.posY = PosY;
            this.width = Width;
            this.height = Height;
            this.segments = Segments;
        }
        public void Paint(PaintEventArgs e, int valueActual)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                
                /*ramka poziomu*/
                Pen pen = new Pen(Color.DarkSlateGray, 2);
                Point[] points = { new Point(posX, posY - 10), new Point(posX, posY + height),
                    new Point(posX + width, posY + height), new Point(posX + width, posY - 10) };
                e.Graphics.DrawLines(pen, points);
                /*poziom cieczy*/
                Pen pen2 = new Pen(Color.Aqua,1);
                Brush brush = new SolidBrush(Color.Aqua);
                Rectangle rect = new Rectangle((int)(posX + pen.Width), (int)(posY + height - pen.Width) - (int)(levelActual * (height - pen.Width) / 100),
                    (int)(width - 2 * pen.Width), (int)(levelActual * (height - pen.Width) / 100));
                e.Graphics.DrawRectangle(pen2, rect);
                e.Graphics.FillRectangle(brush, rect);
                /*miarka poziomu*/
                Pen pen3 = new Pen(Color.Black, 1);
                Font font=new Font("Arial", 8, FontStyle.Italic);
                Brush brush2 = new SolidBrush(Color.Black);

                levelActual = (int)(valueActual/1.5);
                for (int i = 0; i < segments; i++)
                {
                    e.Graphics.DrawLine(pen3, posX - 5, posY + i * height / segments, posX + 5, posY + i * height / segments);
                    e.Graphics.DrawLine(pen3, posX + width - 5, posY + i * height / segments, posX + width + 5, posY + i * height / segments);
                    if(i==0)
                        e.Graphics.DrawString((levelMax - i * levelMax / segments+" [%]").ToString(), font, brush2, posX + width + 5, posY - font.Height / 2 + i * height / segments);
                    else
                        e.Graphics.DrawString((levelMax - i * levelMax / segments).ToString(), font, brush2, posX + width + 5, posY - font.Height / 2 + i * height / segments);
                }
            }

            catch (Exception)
            {
                throw;
            }


        }
    }
}
