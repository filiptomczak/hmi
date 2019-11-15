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
    class Oscyloskop
    {
        private int posX, posY, axX, axY, valueActual, yMax,factor;
        private Point pointActual;

        Pen penAx = new Pen(Color.Black, 1);
        Pen penSub = new Pen(Color.LightGray, 1);
        Pen penBackground = new Pen(Color.White, 1);
        Pen penChart = new Pen(Color.Red, 2);
        Pen penChart2 = new Pen(Color.Blue, 2);
        Brush brushBlack = new SolidBrush(Color.White);
        Brush brushWhite = new SolidBrush(Color.Black);
        Font font = new Font("Arial", 10, FontStyle.Italic);

        private int[] tabX = new int[400];
        bool tab = false;
        public Oscyloskop()
        {
            this.posX = 50;
            this.posY = 725;
            this.axX = 400;
            this.axY = 200;
            this.valueActual = 50;
            this.pointActual = new Point(posX + axX / 2, valueActual);
            this.yMax = 120;
        }

        public void Paint(PaintEventArgs e, int tick)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                /*tlo*/
                e.Graphics.DrawRectangle(penBackground, posX, posY - axY, axX, axY);
                e.Graphics.FillRectangle(brushBlack, posX, posY - axY, axX, axY);
                /*os X*/
                e.Graphics.DrawLine(penAx, posX, posY, posX + axX, posY);
                for (int i = 1; i < 5; i++)
                {
                    e.Graphics.DrawLine(penSub, posX + axX / 4 * i, posY, posX + axX / 4 * i, posY - axY);
                    e.Graphics.DrawString((YMax / 4 * i).ToString(), font, brushWhite, posX - 36, posY - axY / 4 * i - 8);
                }
                for (int i = 0; i < 5; i++)
                {
                    e.Graphics.DrawLine(penSub, posX, posY - axY / 4 * i, posX + axX, posY - axY / 4 * i);
                    e.Graphics.DrawString((axX / 4 / 4 * (-i)).ToString() + "s", font, brushWhite, posX + axX - axX / 4 * i - 16, posY + 5);
                    //e.Graphics.DrawString();
                }
                /*os Y*/
                e.Graphics.DrawLine(penAx, posX, posY, posX, posY - axY);
                /*punkt aktualny*/
                factor = axY / YMax;

                tabX[tick] = ValueActual;
                for (int i = 0; i < tick; i++)
                {
                    e.Graphics.DrawLine(penChart, posX + axX - 1 - (i), (float)(posY - tabX[tick - i - 1] * factor), posX + axX - i, (float)(posY - tabX[tick - i] * factor));
                }
                if (tick == 399) tab = true;
                if (tab)
                {
                    for (int i = 1; i < 399 - tick; i++)
                    {
                        e.Graphics.DrawLine(penChart2, posX + i, (float)(posY - tabX[i + tick] * factor),
                            posX + i + 1, (float)(posY - tabX[i + tick + 1] * factor));
                    }
                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        public int ValueActual
        {
            set { this.valueActual = value; }
            get { return this.valueActual; }
        }
        public int YMax
        {
            set { this.yMax = value; }
            get { return this.yMax; }
        }
    }
}