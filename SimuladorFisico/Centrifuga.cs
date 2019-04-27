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

namespace SimuladorFisico
{
    public partial class Centrifuga : Form
    {
        private const int BALLSIZE = 10;
        private const int CENTERS = 10;
        private Brush BALLCOLOR = Brushes.Blue;
        private Pen VECTORA = Pens.Crimson;
        private Pen VECTORB = Pens.Green;
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
            //descriptiva de dibujo
            g.DrawString("Escala", new Font("Arial", 12), Brushes.Green, new Point(15, 10));
            g.DrawString("50 mts", new Font("Arial", 9), Brushes.Green, new Point(20, 38));

            //lineas de escala
            g.DrawLine(Pens.Red, new Point(15,34), new Point(15,36));
            g.DrawLine(Pens.Red, new Point(15+50, 34), new Point(15+50, 36));
            g.DrawLine(Pens.Red, new Point(15, 35), new Point(15 + 50, 35));

            //puntos cardinales centrales
            g.TranslateTransform(this.Width / 2, this.Height / 2);
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(-CENTERS, 0));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(CENTERS, 0));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(0, -CENTERS));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(0, CENTERS));
            if(cp.X != 0 && cp.Y != 0)
            {//anima el movimiento de la esfera
                drawCircle(g, cp, BALLSIZE);
                
                g.DrawLine(Pens.DarkBlue, new PointF(0, 0), cp);
                drawVectors(g, new PointF(0, 0), cp);

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
        /// <summary>
        /// Dibuja una esfera en un punto determinado
        /// </summary>
        /// <param name="g"></param>
        /// <param name="center"></param>
        /// <param name="radius"></param>
        private void drawCircle(Graphics g, PointF center, int radius)
        {
            float x = center.X - radius;
            float y = center.Y - radius;
            float width = 2 * radius;
            float height = 2 * radius;
            g.FillEllipse(Brushes.DarkBlue, x, y, width, height);            
        }
        /// <summary>
        /// Dibuja el venctor
        /// </summary>
        /// <param name="g"></param>
        /// <param name="center"></param>
        /// <param name="origen"></param>
        private void drawVectors(Graphics g, PointF center, PointF origen)
        {
            PointF pm = PM(center, origen);
            g.DrawString("Vector Fuerza Centrifuga", new Font("Arial", 7), Brushes.Red, new Point(-40, this.Height / 2 - 100));

            g.DrawLine(VECTORA,new PointF(origen.X, origen.Y), pm);
            DrawArrowhead(g, VECTORA, pm, origen.X,origen.Y);

        }
        private void DrawArrowhead(Graphics gr, Pen pen,
            PointF p, float nx, float ny)
        {
            float ax = (float)0.1 * (-ny - nx);
            float ay = (float)0.1 * (nx - ny);
            PointF[] points =
            {
                new PointF(p.X - ax, p.Y - ay),p,
                new PointF(p.X + ay, p.Y - ax)
            };
            gr.DrawLines(pen, points);
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
                    
            }
        }
        /// <summary>
        /// Valida y devuelve los campos de entrada
        /// </summary>
        /// <returns></returns>
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
            if(m > 5000)
            {
                error.SetError(c_TBMasa, String.Format(MAXED, 5000));
                ret[0] = false;
            }
            if (r > 300)
            {
                error.SetError(c_TBRadio, String.Format(MAXED, 300));
                ret[0] = false;
            }
            if(p > 5000)
            {
                error.SetError(c_TBParam, String.Format(MAXED, 5000));
                ret[0] = false;
            }
                
            return ret;
        }

        private void c_LStop_Click(object sender, EventArgs e)
        {
            t.Stop();                        
        }
        /// <summary>
        /// Rellena la tabla de variables
        /// </summary>
        private void fillTable()
        {
            c_tab.Rows.Clear();
            c_tab.Rows.Add("Periodo", inRound(c.Periodo), "seg");
            c_tab.Rows.Add("Frecuencia", inRound(c.Frecuencia), "hz");
            c_tab.Rows.Add("Velocidad Angular", inRound(c.VelocidadAngular), "rad/seg");
            c_tab.Rows.Add("Velocidad Tangencial", inRound(c.VelocidadTangencial), "m/seg");
            c_tab.Rows.Add("Aceleracion Angular", inRound(c.Aceleracion), "m/s²");
            c_tab.Rows.Add("Fuerza Centrifuga", inRound(c.FuerzaCentrifuga), "newton");            
        }
        /// <summary>
        /// Redondea el valor pasado como parametro a 2 decimales
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private double inRound(double val)
        {
            return Math.Round(val, 2);
        }
        /// <summary>
        /// Distancia entre 2 puntos
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        private PointF PM(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }
    }
}
