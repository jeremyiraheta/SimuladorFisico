using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFisico
{
    public partial class Coloumb : Form
    {
        private Timer tick;
        private Rectangle q1;
        private Rectangle q2;
        private System.Drawing.Graphics MyGraphics;
        private Pen blackpen = new Pen(Color.Black, 3);
        private System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);

        public Coloumb()
        {
            InitializeComponent();
            MyGraphics = this.CreateGraphics();
            InitTick();

            q1 = new Rectangle(ClientRectangle.Width / 4, ClientRectangle.Height / 2 - 25, 50, 50);
            q2 = new Rectangle((ClientRectangle.Width / 4) * 3, ClientRectangle.Height / 2 - 25, 50, 50);
        }

        public void InitTick()
        {
            tick = new Timer();
            tick.Tick += new EventHandler(processTick);
            tick.Interval = 100; // in miliseconds
            tick.Start();
        }

        public void processTick(object sender, EventArgs e)
        {
            this.Refresh();
            MyGraphics.FillEllipse(myBrush, q1);
            MyGraphics.DrawEllipse(blackpen, q1);
            MyGraphics.FillEllipse(myBrush, q2);
            MyGraphics.DrawEllipse(blackpen, q2);

            MyGraphics.DrawLine(blackpen, q1.Location.X +25, q1.Location.Y -100, q1.Location.X + 25 + ConvertValueToUnit(trackBar1.Value) * 15, q1.Location.Y - 100);
            label_distance.Text = (q2.Location.X - q1.Location.X).ToString();
            //label_distance.Text = ClientRectangle.Width.ToString();
        }

        private void Coloumb_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            tick.Stop();
        }

        private void Coloumb_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Coloumb_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = ConvertValueToUnit(trackBar1.Value) + " uC";
        }

        private int ConvertValueToUnit(int a) {
            switch (a)
            {
                case 0:
                    return -10;
                case 1:
                    return -9;
                case 2:
                    return -8;
                case 3:
                    return -7;
                case 4:
                    return -6;
                case 5:
                    return -5;
                case 6:
                    return -4;
                case 7:
                    return -3;
                case 8:
                    return -2;
                case 9:
                    return -1;
                case 10:
                    return 0;
                case 11:
                    return 1;
                case 12:
                    return 2;
                case 13:
                    return 3;
                case 14:
                    return 4;
                case 15:
                    return 5;
                case 16:
                    return 6;
                case 17:
                    return 7;
                case 18:
                    return 8;
                case 19:
                    return 9;
                case 20:
                    return 10;
                default:
                    return 0;
            }
        }

        private void TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = ConvertValueToUnit(trackBar2.Value) + " uC";
        }

        private void Coloumb_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private double force(int q1, int q2, int distance)
        {
            double k = 9000000000;
            return 0;
        }
    }
}
