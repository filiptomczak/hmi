using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmi
{
    public partial class Form1 : Form
    {
        private int vMin, vMax, xMax, yMax, baud, skala;
        string unit, com;
        bool fail = false;
        int tick = 0;
        int tick2 = 0;
        private Wskaznik wsk = new Wskaznik();
        private Wskaznik wsk2 = new Wskaznik(0, 150, Color.Purple, Color.PowderBlue, Color.RosyBrown, 6, 200, 200, new Point(150, 400), "", 10);
        private int valueActual = 0;
        private int valueActual2 = 0;
        private List<Wskaznik> lWsk = new List<Wskaznik>();
        private List<TrackBar> lTb = new List<TrackBar>();
        private List<int> lValueActual = new List<int>();
        private bool addWsk = false;
        WriteTxt writeTxt = new WriteTxt("C:\\dane\\");
        string textData = "";
        PortSerial portSerial = new PortSerial("COM5", 9600);
        Poziom poziom = new Poziom();
        Alarm alarm = new Alarm();
        Oscyloskop oscyloskop = new Oscyloskop();
        Robot robot = new Robot();
        Arm arm = new Arm();
        string userGroup = "user";
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            lWsk.Add(wsk);
            lWsk.Add(wsk2);
            lTb.Add(trackBar1);
            lTb.Add(trackBar2);
            lValueActual.Add(valueActual);
            lValueActual.Add(valueActual2);

            numericUpDown1.Maximum = wsk.ValMax;
            trackBar1.Maximum = wsk.ValMax;
            numericUpDown2.Maximum = wsk2.ValMax;
            trackBar2.Maximum = wsk2.ValMax;
            oscyloskop.YMax = wsk.ValMax;

            timer1.Start();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                wsk.Paint(e, valueActual);
                wsk2.Paint(e, valueActual2);
                poziom.Paint(e, valueActual2);
                alarm.Paint(e, fail, tick);
                oscyloskop.Paint(e, tick2);

                for (int i = 2; i < lWsk.Count; i++) lWsk[i].Paint(e, lValueActual[i]);

                arm.Paint(e);
                robot.Paint(e);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            valueActual = (int)numericUpDown1.Value;
            trackBar1.Value = (int)valueActual;
            portSerial.sendMessage(valueActual);
            this.Refresh();
        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            valueActual = (int)trackBar1.Value;
            numericUpDown1.Value = (decimal)valueActual;
            this.Refresh();
        }
        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            valueActual2 = (int)trackBar2.Value;
            numericUpDown2.Value = (decimal)valueActual2;
            this.Refresh();
        }
        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            valueActual2 = (int)numericUpDown2.Value;
            trackBar2.Value = (int)valueActual2;
            this.Refresh();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label_clock.Text = DateTime.Now.ToString("HH:mm:ss");
            oscyloskop.ValueActual = valueActual;
            this.saveToFile();
            if (!fail)
            {
                tick++;
                if (tick == 2)
                {
                    valueActual = random.Next(65, 75);
                    valueActual2 = random.Next(15, 25);
                    numericUpDown1.Value = valueActual;
                    numericUpDown2.Value = valueActual2;
                    tick = 0;
                }
            }
            tick2++;
            if (tick2 == 400) tick2 = 0;
            this.Refresh();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            label2.Text = this.PointToClient(new Point(e.X, e.Y)).ToString();
            label3.Text = this.PointToScreen(new Point(e.X, e.Y)).ToString();
        }
        private void Button_reset_Click(object sender, EventArgs e)
        {
            fail = false;
            this.Refresh();
        }
        private void Button_robot_KeyDown(object sender, KeyEventArgs e)
        {
            label7.Text = robot.coordinateX().ToString();
            label8.Text = robot.coordinateY().ToString();
            robot.move(e);
        }
        private void Button_log_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.valueCallback = new Form3.ValueCallback(readUser);
            form3.Show();
        }
        private void readUser(string value)
        {
            userGroup = value;
            label_user.Text = userGroup;
        }
        private void Button_logout_Click(object sender, EventArgs e)
        {
            userGroup = "user";
            label_user.Text = userGroup;
        }
        private void Button_arm_KeyDown(object sender, KeyEventArgs e)
        {
            arm.move(e);            
        }
        private void Button_fail_Click(object sender, EventArgs e)
        {
            fail = true;
            this.Refresh();
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (addWsk)
            {
                lWsk.Add(new Wskaznik(vMin, vMax, Color.Purple, Color.PowderBlue, Color.RosyBrown, 6, xMax, yMax, this.PointToScreen(new Point(e.X - 15, e.Y - 40)), unit, skala));
                lTb.Add(new TrackBar());
                Controls.Add(lTb[lTb.Count - 1]);
                lTb[lTb.Count - 1].Location = this.PointToClient(new Point(e.X - 100, e.Y + 50 + yMax / 2));
                lTb[lTb.Count - 1].Minimum = vMin;
                lTb[lTb.Count - 1].Maximum = vMax;
                lTb[lTb.Count - 1].Name = "track" + lTb.Count.ToString();
                lTb[lTb.Count - 1].Size = new System.Drawing.Size(250, 56);
                lTb[lTb.Count - 1].Scroll += new System.EventHandler(this.TrackBars_Scroll);
                lValueActual.Add(new int());
                addWsk = false;
                this.Refresh();
            }
        }
        private void TrackBars_Scroll(object sender, EventArgs e)
        {
            for (int i = 0; i < lTb.Count; i++)
            {
                lValueActual[i] = (int)lTb[i].Value;
                this.Refresh();
            }
        }
        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (lWsk.Any())
            {
                lWsk.RemoveAt(lWsk.Count - 1);
                this.Refresh();
            }

            if (lTb.Any())
            {
                Controls.Remove(lTb[lTb.Count - 1]);
                lTb.RemoveAt(lTb.Count - 1);
                this.Refresh();
            }
            if (lValueActual.Any())
            {
                lValueActual.RemoveAt(lValueActual.Count - 1);
                this.Refresh();
            }
        }
        private void Button_add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.valueCallback = new Form2.ValueCallback(this.readForm);
            form2.Show();
            addWsk = true;
        }
        private void readForm(string value)
        {
            label5.Text = value;
            List<string> values = value.Split(',').ToList<string>();
            vMin = Int16.Parse(values[0]);
            vMax = Int16.Parse(values[1]);
            xMax = Int16.Parse(values[2]);
            yMax = xMax;
            skala = Int16.Parse(values[3]);
            unit = values[4];
            com = values[5];
            baud = Int16.Parse(values[6]);
        }
        private void saveToFile()
        {
            for (int i = 0; i < lTb.Count; i++)
            {
                textData = DateTime.Now.ToString("HH:mm:ss") + ", " + lTb[i].Name + ", " + lTb[i].Value;
                writeTxt.saveFile(textData);
            }
        }
    }
}