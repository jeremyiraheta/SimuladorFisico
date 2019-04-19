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
    public partial class Centrifuga : Form
    {
        public Centrifuga()
        {
            InitializeComponent();
        }

        private void Centrifuga_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(this.Width / 2, this.Height / 2);
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(-10, 0));
            g.DrawLine(Pens.Green, new Point(0, 0), new Point(10, 0));
            g.DrawLine(Pens.Red, new Point(0, 0), new Point(0, -10));
            g.DrawLine(Pens.Silver, new Point(0, 0), new Point(0, 10));
        }

        private void Centrifuga_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
