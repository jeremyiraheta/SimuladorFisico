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
        private const int BALLSIZE = 10;
        private const int CENTERS = 10;
        private Brush BALLCOLOR = Brushes.Blue;
        private const string NONUM = "Debe contener un numero valido";
        private const string MAXED = "Sobrepasa el valor maximo posible: {0}";

        FCentri c;
        PointF cp;
        double secs = 0;
        Timer t = new Timer();
        public Centrifuga()
        {
            InitializeComponent();
            t.Interval = 100;
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            secs += 0.1;           
            cp = c.Posicion(secs);
            this.Invalidate();
        }

        private void Centrifuga_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(this.Width / 2, this.Height / 2);
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(-CENTERS, 0));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(CENTERS, 0));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(0, -CENTERS));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(0, CENTERS));
            if(cp.X != 0 && cp.Y != 0)
            {
                drawCircle(g, cp, BALLSIZE);
                g.DrawLine(Pens.DarkBlue, new PointF(0, 0), cp);
            }
        }

        private void Centrifuga_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            t.Stop();
        }

        private void Centrifuga_Load(object sender, EventArgs e)
        {

        }
        private void drawCircle(Graphics g, PointF center, int radius)
        {
            float x = center.X - radius;
            float y = center.Y - radius;
            float width = 2 * radius;
            float height = 2 * radius;
            g.FillEllipse(Brushes.DarkBlue, x, y, width, height);            
        }
        private void drawVectors(Graphics g, PointF center, PointF origen)
        {
            PointF[] f = new PointF[8];
            f[0] = new PointF(center.X, center.Y);
            f[1] = new PointF(center.X, center.Y);
            f[2] = new PointF(center.X, center.Y);
            f[3] = new PointF(center.X, center.Y);
            f[4] = new PointF(center.X, center.Y);
            f[5] = new PointF(center.X, center.Y);
            f[6] = new PointF(center.X, center.Y);
            f[7] = new PointF(center.X, center.Y);            
            g.FillPolygon(Brushes.Red,f);
        }

        private void c_Lstart_Click(object sender, EventArgs e)
        {
            error.Clear();
            object[] vals = values();
            if((bool)vals[0])
            {
                if(c_RBVel.Checked)
                    c = new FCentri((double)vals[1], (double)vals[2], velocidad: (double)vals[3]);
                else if(c_RBAcel.Checked)
                    c = new FCentri((double)vals[1], (double)vals[2], aceleracion: (double)vals[3]);
                else if(c_RBPerio.Checked)
                    c = new FCentri((double)vals[1], (double)vals[2], periodo: (double)vals[3]);
                cp = new Point(0, 0);
                secs = 0;
                t.Start();
                fillTable();
            }
            else
            {
                c_LStop_Click(null,null);
                c_tab.Rows.Clear();             
                if ((double)vals[1] == 0)
                    error.SetError(c_TBMasa, NONUM);
                if ((double)vals[2] == 0)
                    error.SetError(c_TBRadio, NONUM);
                if ((double)vals[3] == 0)
                    error.SetError(c_TBParam, NONUM);
                if ((double)vals[2] > 300)
                    error.SetError(c_TBRadio, String.Format(MAXED, 300));
                    
            }
        }
        private object[] values()
        {            
            double m = 0, r=0, p=0;
            object[] ret = new object[4];
            ret[0] = true;
            ret[1] = m;
            ret[2] = r;
            ret[3] = p;
            if (double.TryParse(c_TBMasa.Text, out m))
                ret[1] = m > 0 ? m : 0;
            if (double.TryParse(c_TBRadio.Text, out r))
                ret[2] = r > 0 ? r : 0;
            if (double.TryParse(c_TBParam.Text, out p))
                ret[3] = p > 0 ? p : 0;
            if ((double)ret[1] == 0 || (double)ret[2] == 0 || (double)ret[3] == 0)
                ret[0] = false;
            if (r > 300)
                ret[0] = false;
            return ret;
        }

        private void c_LStop_Click(object sender, EventArgs e)
        {
            t.Stop();                        
        }
        private void fillTable()
        {
            c_tab.Rows.Clear();
            c_tab.Rows.Add("Periodo", c.Periodo, "seg");
            c_tab.Rows.Add("Frecuencia", c.Frecuencia, "hz");
            c_tab.Rows.Add("Velocidad Angular", c.VelocidadAngular, "rad/seg");
            c_tab.Rows.Add("Velocidad Tangencial", c.VelocidadTangencial, "m/seg");
            c_tab.Rows.Add("Aceleracion Angular", c.Aceleracion, "m/s²");
            c_tab.Rows.Add("Fuerza Centrifuga", c.FuerzaCentrifuga, "newton");            
        }
    }
}
