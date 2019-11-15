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
    class Wskaznik
    {
        private float ValueActual = 0;
        private Color TipColor = Color.Red, CircleColor = Color.Black, BackgroundColor = Color.White;
        private Font ControlFont;
        private int XMax, YMax, ValueMin, ValueMax, Skala, valueActual;
        private string Unit;
        Point Center;
        public Wskaznik()
        {
            this.ValueMin = 0;
            this.ValueMax = 100;
            this.TipColor = Color.Red;
            this.CircleColor = Color.Black;
            this.BackgroundColor = Color.White;
            this.XMax = 500;
            this.YMax = 500;
            this.ControlFont = new Font("Arial", 8, FontStyle.Italic);
            this.Center.X = XMax / 2;
            this.Center.Y = YMax / 2;
            this.Unit = "";
            this.Skala = 10;
        }
        public Wskaznik(int valueMin, int valueMax, Color circleColor, Color tipColor, Color backgroundColor, int font, int xMax, int yMax, Point center, string unit, int skala)
        {
            this.ValueMin = valueMin;
            this.ValueMax = valueMax;
            this.TipColor = tipColor;
            this.CircleColor = circleColor;
            this.BackgroundColor = backgroundColor;
            this.XMax = xMax;
            this.YMax = yMax;
            this.ControlFont = new Font("Arial", font, FontStyle.Italic);
            this.Center.X = center.X;
            this.Center.Y = center.Y;
            this.Unit = unit;
            this.Skala = skala;
        }
        private float deg2Rad(float st)
        {
            float rad = (float)Math.PI / 180 * st;
            return rad;
        }

        public void Paint(PaintEventArgs e, int valueActual)
        {
            try
            {
                #region ustawienia
                int xb = (int)XMax / 50;
                int yb = (int)YMax / 50;

                Pen penCircleBlackThick = new Pen(CircleColor, 2);
                Pen penCircleRedThick = new Pen(Color.Red, 2);
                Pen penTip = new Pen(TipColor, 2);

                SolidBrush brushBackground = new SolidBrush(BackgroundColor);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                #endregion

                #region wskaznik
                e.Graphics.FillEllipse(brushBackground, Center.X - XMax / 2 + xb, Center.Y - YMax / 2 + yb, XMax, YMax);
                e.Graphics.DrawEllipse(penCircleBlackThick, Center.X - XMax / 2 + xb, Center.Y - YMax / 2 + yb, XMax, YMax);
                #endregion

                #region wartosc
                StringFormat formatCenter = new StringFormat();
                formatCenter.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(Unit + valueActual, ControlFont, new SolidBrush(Color.Black), Center.X + xb, Center.Y + yb + 20, formatCenter);
                #endregion

                #region wskazowka
                double xw1, xw2, xw3, yw1, yw2, yw3;
                float factor = 270.0f / ValueMax;
                
                xw1 = Center.X + xb - (XMax / 2 - xb) * Math.Cos(deg2Rad(valueActual*factor));
                yw1 = Center.Y + yb - (YMax / 2 - yb) * Math.Sin(deg2Rad(valueActual * factor));
                xw2 = Center.X + xb - xb * Math.Cos(deg2Rad(valueActual * factor + 90));
                yw2 = Center.Y + yb - yb * Math.Sin(deg2Rad(valueActual * factor + 90));
                xw3 = Center.X + xb + xb * Math.Cos(deg2Rad(valueActual * factor + 90));
                yw3 = Center.Y + yb + yb * Math.Sin(deg2Rad(valueActual * factor + 90));

                Point[] hintPoints = { new Point((int)xw1, (int)yw1), new Point((int)xw2, (int)yw2), new Point((int)xw3, (int)yw3) };

                e.Graphics.DrawPolygon(penCircleBlackThick, hintPoints);
                LinearGradientBrush gradientBrush = new LinearGradientBrush(new Rectangle(xb, yb, Center.X + XMax, Center.Y + YMax), Color.Silver, Color.Black, LinearGradientMode.Horizontal);
                e.Graphics.FillPolygon(gradientBrush, hintPoints);

                e.Graphics.DrawEllipse(penCircleBlackThick, Center.X, Center.Y, xb * 2, yb * 2);
                LinearGradientBrush gradientBrush2 = new LinearGradientBrush(new Rectangle(Center.X - xb, Center.Y - yb, Center.X + xb, Center.Y + yb), Color.Black, Color.Black, LinearGradientMode.Vertical);
                e.Graphics.FillEllipse(gradientBrush2, Center.X, Center.Y, xb * 2, yb * 2);

                int step = Skala;
                int value = ValueMin;
                double x1, x2, y1, y2;
                for (int i = ValueMin; i <=ValueMax ; i++)
                {
                    if (i % Skala == 0)
                    {
                        x1 = Center.X + xb - (XMax / 2 - xb) * Math.Cos(deg2Rad(i*factor));
                        x2 = Center.X + xb - (XMax / 2 + xb) * Math.Cos(deg2Rad(i * factor));
                        y1 = Center.Y + yb - (YMax / 2 - yb) * Math.Sin(deg2Rad(i * factor));
                        y2 = Center.Y + yb - (YMax / 2 + yb) * Math.Sin(deg2Rad(i * factor));

                        double xt = Center.X + xb + 20 * Math.Cos(deg2Rad(i * factor)) - XMax / 2 * Math.Cos(deg2Rad(i * factor));
                        double yt = Center.Y + yb + 20 * Math.Sin(deg2Rad(i * factor)) - YMax / 2 * Math.Sin(deg2Rad(i * factor));
                        //skala
                        e.Graphics.DrawLine(penCircleBlackThick, (int)x1, (int)y1, (int)x2, (int)y2);
                        e.Graphics.DrawString(value.ToString(), ControlFont, new SolidBrush(Color.Black), (int)xt, (int)yt, formatCenter);
                        value += step;
                    }
                }
                #endregion
            }

            catch (Exception)
            {
                throw;
            }
        }
        public int ValMax
        {
            get
            {
                return ValueMax;
            }
        }
    }
}
