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
        double angulo;
        double anguloO;
        int arm_length;
        double VelocidadAngular;
        double AceleracionAngular;
        double GRAVEDAD;
        double friccion;

        public PenduloDoble()
        {
            InitializeComponent();
        }

        private void PenduloDoble_Load(object sender, EventArgs e)
        {
            blueBall.Location = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 4);
            redBall.Location = new Point((ClientRectangle.Width / 4) * 3, ClientRectangle.Height / 2);
            pen = new Pen(Color.Black);
            arm_length = 100;
            AceleracionAngular = 0.0;
            VelocidadAngular = 0.0;
            InitDraw();
        }
        

        // Inicializar el timer para ejecutar codigo 60 veces por segundo
        public void InitDraw()
        {
            draw = new Timer();
            draw.Tick += new EventHandler(drawTick);
            draw.Interval = 10; // in miliseconds
            draw.Start();
        }
        // El codigo que se ejecuta varias veces
        private void drawTick(object sender, EventArgs e)
        {
            // Limpiar la pantalla
            this.Invalidate();

            AceleracionAngular = (-1 * GRAVEDAD / arm_length) * Math.Sin(angulo);
            VelocidadAngular += AceleracionAngular;
            VelocidadAngular *= friccion;
            angulo += VelocidadAngular;

            label_VelocidadAngular.Text = "Velocidad Angular = " + VelocidadAngular;
            label_AceleracionAngular.Text = "Aceleracion Angular = " + AceleracionAngular;

            int x = Convert.ToInt32(blueBall.Location.X + arm_length * Math.Sin(angulo));
            int y = Convert.ToInt32(blueBall.Location.Y + arm_length * Math.Cos(angulo));
            redBall.Location = new Point(x, y);

            anguloO = 45 * Math.PI / 180;
            int xO = Convert.ToInt32(redBall.Location.X + arm_length * Math.Sin(anguloO));
            int yO = Convert.ToInt32(redBall.Location.Y + arm_length * Math.Cos(anguloO));
            otherBall.Location = new Point(xO, yO);
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
            AceleracionAngular = 0.0;
            VelocidadAngular = 0.0;
            if (text_lenBrazo.Text != String.Empty)
            {
                arm_length = Convert.ToInt32(text_lenBrazo.Text);
            }

            if (text_angulo.Text != String.Empty)
            {
                angulo = Convert.ToInt32(text_angulo.Text);
                angulo = angulo * Math.PI / 180;
            }

            if (text_gravedad.Text != String.Empty)
            {
                GRAVEDAD = Convert.ToDouble(text_gravedad.Text);
            }

            friccion = 100 - Convert.ToInt32(numericUpDown_friccion.Value);
            friccion = friccion / 100;

        }

        private void PenduloDoble_FormClosed(object sender, FormClosedEventArgs e)
        {
            draw.Stop();
            this.Owner.Show();
        }
    }
}
