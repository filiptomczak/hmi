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
    class Arm
    {
        private int posX, posY, height, width, rot1, rot2, rot3;
        private float length;
        Pen penAx = new Pen(Color.Black, 1);
        Pen penS1 = new Pen(Color.Crimson, 2);
        Pen penS2 = new Pen(Color.Peru, 2);
        Pen penS3 = new Pen(Color.Turquoise, 2);
        Brush brushWhite = new SolidBrush(Color.White);

        public Arm()
        {
            this.posX = 795;
            this.posY = 200;
            this.height = 200;
            this.width = 200;
            this.length = 34;
        }
        public Arm(int PosX, int PosY, int Height, int Width)
        {
            this.posX = PosX;
            this.posY = PosY;
            this.height = Height;
            this.width = Width;
        }
        public void Paint(PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;

                /*ramka*/
                Rectangle rectangle = new Rectangle(new Point(posX, posY), new Size(width, height));
                e.Graphics.DrawRectangle(penAx, rectangle);
                e.Graphics.FillRectangle(brushWhite, rectangle);

                //s1
                Point s11 = new Point(posX + width / 2, posY + height / 2);
                Point s12 = new Point(posX + width / 2 + (int)(length * Math.Cos(rot1 * Math.PI / 180)), posY + height / 2 + (int)(length * Math.Sin(rot1 * Math.PI / 180)));
                Point s21 = new Point(posX + width / 2 + (int)(length * Math.Cos(rot1 * Math.PI / 180) + (length * Math.Cos(rot2 * Math.PI / 180))),
                    posY + height / 2 + (int)(length * Math.Sin(rot1 * Math.PI / 180) + length * Math.Sin(rot2 * Math.PI / 180)));

                Point s22 = new Point(posX + width / 2 + (int)(length * Math.Cos(rot1 * Math.PI / 180) + (length * Math.Cos(rot2 * Math.PI / 180)) + (length * Math.Cos(rot3 * Math.PI / 180))),
                    posY + height / 2 + (int)(length * Math.Sin(rot1 * Math.PI / 180) + length * Math.Sin(rot2 * Math.PI / 180) + length * Math.Sin(rot3 * Math.PI / 180)));

                e.Graphics.DrawEllipse(penS1, s11.X - 5, s11.Y - 5, 10, 10);
                e.Graphics.DrawLine(penS1, s11, s12);
                e.Graphics.DrawEllipse(penS2, s12.X - 5, s12.Y - 5, 10, 10);
                e.Graphics.DrawLine(penS1, s12, s21);
                e.Graphics.DrawEllipse(penS3, s21.X - 5, s21.Y - 5, 10, 10);
                e.Graphics.DrawLine(penS1, s21, s22);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void move(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                this.Rot1 += 1;
                this.Rot2 += 1;
                this.Rot3 += 1;
            }
            if (e.KeyCode == Keys.Q)
            {
                this.Rot1 -= 1;
                this.Rot2 -= 1;
                this.Rot3 -= 1;
            }

            if (e.KeyCode == Keys.D2)
            {
                this.Rot2 += 1;
                this.Rot3 += 1;
            }
            if (e.KeyCode == Keys.W)
            {
                this.Rot2 -= 1;
                this.Rot3 -= 1;
            }
            if (e.KeyCode == Keys.D3)
            {
                this.Rot3 += 1;
            }
            if (e.KeyCode == Keys.E)
            {
                this.Rot3 -= 1;
            }
        }
        public int Rot1
        {
            set { this.rot1 = value; }
            get { return this.rot1; }
        }
        public int Rot2
        {
            set { this.rot2 = value; }
            get { return this.rot2; }
        }
        public int Rot3
        {
            set { this.rot3 = value; }
            get { return this.rot3; }
        }
    }
}
