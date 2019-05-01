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
    public partial class PenduloDoble : Form
    {
        private Timer draw;
        private Pen pen;

        Point CENTER;

        double r1 = 100;
        double r2 = 100;
        double m1 = 10;
        double m2 = 10;
        double a1 = 0;
        double a2 = 0;
        double a1_v = 0;
        double a2_v = 0;
        
        double g = 1;


        public PenduloDoble()
        {
            InitializeComponent();
        }

        private void PenduloDoble_Load(object sender, EventArgs e)
        {
            CENTER = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 4);
            blueBall.Location = CENTER;
            //redBall.Location = new Point((ClientRectangle.Width / 4) * 3, ClientRectangle.Height / 2);
            pen = new Pen(Color.Black);
            //arm_length = 100;
            //AceleracionAngular = 0.0;
            //VelocidadAngular = 0.0;
            InitDraw();
        }

        // Inicializar el timer para ejecutar codigo 60 veces por segundo
        public void InitDraw()
        {
            draw = new Timer();
            draw.Tick += new EventHandler(drawTick);
            draw.Interval = 13; // in miliseconds
            draw.Start();
        }
        // El codigo que se ejecuta varias veces
        private void drawTick(object sender, EventArgs e)
        {
            // Limpiar la pantalla
            this.Invalidate();

            double num1 = -g * (2 * m1 + m2) * Math.Sin(a1);
            double num2 = -m2 * g * Math.Sin(a1 - 2 * a2);
            double num3 = -2 * Math.Sin(a1 - a2) * m2;
            double num4 = a2_v * a2_v * r2 + a1_v * a1_v * r1 * Math.Cos(a1 - a2);
            double den = r1 * (2 * m1 + m2 - m2 * Math.Cos(2 * a1 - 2 * a2));

            double a1_a = (num1 + num2 + num3 * num4) / den;

            num1 = 2 * Math.Sin(a1 - a2);
            num2 = (a1_v * a1_v * r1 * (m1 + m2));
            num3 = g * (m1 + m2) * Math.Cos(a1);
            num4 = a2_v * a2_v * r2 * m2 * Math.Cos(a1 - a2);
            den = r2 * (2 * m1 + m2 - m2 * Math.Cos(2 * a1 - 2 * a2));

            double a2_a = num1 * (num2 + num3 + num4) / den;

            a1_v += a1_a;
            a2_v += a2_a;
            a1 += a1_v;
            a2 += a2_v;


            int x1 = Convert.ToInt32(CENTER.X + r1 * Math.Sin(a1));
            int y1 = Convert.ToInt32(CENTER.Y + r1 * Math.Cos(a1));

            redBall.Location = new Point(x1, y1);

            int x2 = Convert.ToInt32(x1 + r2 * Math.Sin(a2));
            int y2 = Convert.ToInt32(y1 + r2 * Math.Cos(a2));

            otherBall.Location = new Point(x2, y2);
            
        }

        

        private void PenduloDoble_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Dibujar linea entre bolas
            Point a = new Point(blueBall.Location.X + 16, blueBall.Location.Y + 16);
            Point b = new Point(redBall.Location.X + 16, redBall.Location.Y + 16);
            g.DrawLine(pen, a, b);

            Point c = new Point(otherBall.Location.X + 16, otherBall.Location.Y + 16);
            g.DrawLine(pen, b, c);
        }



        private void button_simular_Click(object sender, EventArgs e)
        {
            a1_v = 0;
            a2_v = 0;

            // r1
            if (text_brazo1.Text != String.Empty)
            {
                r1 = Convert.ToInt32(text_brazo1.Text);
            }

            // r2

            if (text_brazo2.Text != String.Empty)
            {
                r2 = Convert.ToInt32(text_brazo2.Text);
            }

            // angulo 1
            if (text_angulo1.Text != String.Empty)
            {
                a1 = Convert.ToInt32(text_angulo1.Text);
                a1 = a1 * Math.PI / 180;
            }
            // angulo 2

            if (text_angulo2.Text != String.Empty)
            {
                a2 = Convert.ToInt32(text_angulo2.Text);
                a2 = a2 * Math.PI / 180;
            }

            // constante g
            if (text_gravedad.Text != String.Empty)
            {
                g = Convert.ToInt32(text_gravedad.Text);
            }
            // masa 1
            if (text_masa1.Text != String.Empty)
            {
                m1 = Convert.ToInt32(text_masa1.Text);
            }
            // masa 2
            if (text_masa2.Text != String.Empty)
            {
                m2 = Convert.ToInt32(text_masa2.Text);
            }
        }

        private void PenduloDoble_FormClosed(object sender, FormClosedEventArgs e)
        {
            draw.Stop();
            this.Owner.Show();
        }

       

    }
}
