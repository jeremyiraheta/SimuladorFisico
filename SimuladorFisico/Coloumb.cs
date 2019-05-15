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
        private bool q1_hover = false;
        private bool q2_hover = false;
        private System.Drawing.Graphics MyGraphics;

        public Coloumb()
        {
            InitializeComponent();
            MyGraphics = this.CreateGraphics();
            InitTick();

            q1 = new Rectangle(ClientRectangle.Width / 4 - 25, ClientRectangle.Height / 2 - 25, 50, 50);
            q2 = new Rectangle((ClientRectangle.Width / 4) * 3 - 25, ClientRectangle.Height / 2 - 25, 50, 50);
        }

        public void InitTick()
        {
            tick = new Timer();
            tick.Tick += new EventHandler(processTick);
            tick.Interval = 33; // in miliseconds
            tick.Start();
        }

        public void processTick(object sender, EventArgs e)
        {
            this.Invalidate();
            
            
                
            
        }

        private void Coloumb_Paint(object sender, PaintEventArgs e)
        {
            Pen blackpen = new Pen(Color.Black, 3);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            
            e.Graphics.FillEllipse(myBrush, q1);
            e.Graphics.DrawEllipse(blackpen, q1);

            e.Graphics.FillEllipse(myBrush, q2);
            e.Graphics.DrawEllipse(blackpen, q2);

            
        }

        private void Coloumb_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void Coloumb_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Coloumb_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
