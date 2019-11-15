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
    class Robot
    {
        private int posX, posY, height, width, robRot;
        private float robX, robY;
        Pen penAx = new Pen(Color.Black, 1);
        Pen penBackground = new Pen(Color.White, 1);
        Pen penRobot = new Pen(Color.Crimson, 2);
        Brush brushBlack = new SolidBrush(Color.Black);
        Brush brushWhite = new SolidBrush(Color.White);
        Font font = new Font("Arial", 10, FontStyle.Italic);
        Image image = Image.FromFile("K:\\projekt\\hmi\\hmi\\rob.jpg");
        public Robot()
        {
            this.posX = 1000;
            this.posY = 200;
            this.height = 200;
            this.width = 200;
            this.robX = posX + width / 2-15;
            this.robY = posY + height / 2-16;
        }
        public Robot(int PosX, int PosY, int Height, int Width)
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
                /*robot*/
                //e.Graphics.DrawImage(image, robX, robY, 30, 32);

                Graphics g = e.Graphics;
                g.TranslateTransform(robX+15, robY+16);
                g.RotateTransform(robRot);
                g.TranslateTransform(-robX-15, -robY-16);
                g.DrawImage(image, robX, robY, 30, 32);
                
                /*e.Graphics.RotateTransform(45);
                e.Graphics.DrawImage(image, robX, robY, 30, 32);*/
               // g.Transform = rot;
                //g.DrawImage(image, robX, robY, 30, 32);

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void move(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad8)
            {
                if (this.RobY > this.PosY && this.RobY < this.PosY + this.Height - 32 && this.RobX > this.PosX && this.RobX < this.PosX + this.Width - 30)
                {
                    int actualRobY = -1;
                    this.RobX += (-1) * actualRobY * (float)Math.Sin(this.RobRot * Math.PI / 180);
                    this.RobY += (1) * actualRobY * (float)Math.Cos(this.RobRot * Math.PI / 180);
                }
                if (this.RobY <= this.PosY) this.RobY = this.PosY + 2;
                if (this.RobX <= this.PosX) this.RobX = this.PosX + 2;
                if (this.RobY >= this.PosY + this.Height - 32) this.RobY = this.PosY + this.Height - 32 - 2;
                if (this.RobX >= this.PosX + this.Width - 30) this.RobX = this.PosX + this.Width - 30 - 2;
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                if (this.RobY < this.PosY + this.Height - 32 && this.RobY > this.PosY && this.RobX > this.PosX && this.RobX < this.PosX + this.Width - 30)
                {
                    int actualRobY = 1;
                    this.RobX += (-1) * actualRobY * (float)Math.Sin(this.RobRot * Math.PI / 180);
                    this.RobY += (1) * actualRobY * (float)Math.Cos(this.RobRot * Math.PI / 180);
                }
                if (this.RobY <= this.PosY) this.RobY = this.PosY + 2;
                if (this.RobX <= this.PosX) this.RobX = this.PosX + 2;
                if (this.RobY >= this.PosY + this.Height - 32) this.RobY = this.PosY + this.Height - 32 - 2;
                if (this.RobX >= this.PosX + this.Width - 30) this.RobX = this.PosX + this.Width - 30 - 2;
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                int actualRobRot = 1;
                if (this.RobRot == 360 || this.RobRot == -360)
                {
                    actualRobRot = 0;
                }                
                this.RobRot += actualRobRot;
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                int actualRobRot = -1;
                if (this.RobRot == 360 || this.RobRot == -360)
                {
                    actualRobRot = 0;
                }
                this.RobRot += actualRobRot;
            }
        }
        public int coordinateX()
        {
            return (int)(this.RobX - this.PosX);
        }
        public int coordinateY()
        {
            return (int)(this.RobY - this.PosY);
        }
        public float RobX
        {
            set { this.robX = value; }
            get { return this.robX; }
        }
        public float RobY
        {
            set { this.robY = value; }
            get { return this.robY; }
        }
        public int PosX
        {
            get { return this.posX; }
        }
        public int PosY
        {
            get { return this.posY; }
        }
        public int Height
        {
            get { return this.height; }
        }
        public int Width
        {
            get { return this.width; }
        }
        public int RobRot
        {
            set { this.robRot = value; }
            get { return this.robRot; }
        }
    }
}


